Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class ViewRecipe
    Dim mealID As Integer
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim isFavorite As Boolean = False
    Dim role As String = LoginForm.currentUserRole
    Dim userID As Integer = LoginForm.currentUserID
    Public Event RefreshFavorites()
    Public Sub New(mealID As Integer)
        InitializeComponent()
        Me.mealID = mealID
        LoadRecipeData()
    End Sub

    Public Sub GetMealRatings(mealId As Integer)
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(DISTINCT user_id) as total_users, " &
                                      "AVG (rating) AS ratings " &
                                      "FROM ratings " &
                                      "WHERE meal_id = @mealID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@mealID", mealId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim totalUsers As Integer = reader.GetInt32("total_users")
                            Dim overallAverageRating As Double = If(reader.IsDBNull(reader.GetOrdinal("ratings")), 0, reader.GetDouble("ratings"))

                            lblRating.Text = overallAverageRating
                            lblTotalUser.Text = "(" & totalUsers & ")"
                            rating.Value = overallAverageRating
                        End If
                    End Using
                End Using


            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub LoadRecipeData()
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim query As String = "SELECT m.*, c.category_name FROM meals m JOIN categories c ON m.category_id = c.id WHERE m.idMeal = @mealID;"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@mealID", mealID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    lblMealName.Text = reader("strMeal").ToString()
                    lblCategory.Text = "Category: " & reader("category_name").ToString()

                    Dim youtubeUrl As String = reader("strYoutube").ToString()
                    If Not String.IsNullOrEmpty(youtubeUrl) Then
                        Dim vid As Video = New Video(youtubeUrl)
                        vid.Dock = DockStyle.Top
                        flowPanelVideo.Controls.Add(vid)
                    Else
                        MessageBox.Show("No valid YouTube URL found for this recipe.")
                    End If

                    txtInstructions.Text = reader("strInstructions").ToString()

                    Dim ingredientsJson As String = reader("ingredients").ToString()
                    DisplayIngredients(ingredientsJson)
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub DisplayIngredients(ingredientsJson As String)
        Try
            Dim ingredientsList As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(ingredientsJson)
            txtIngredients.Clear()

            For Each ingredient As String In ingredientsList
                txtIngredients.AppendText(ingredient & Environment.NewLine)
            Next

        Catch ex As Exception
            MessageBox.Show("Error parsing ingredients: " & ex.Message)
        End Try
    End Sub

    Private Sub isFav()
        Dim query As String = "SELECT COUNT(*) > 0 AS isFavorite " &
                              "FROM favorites " &
                              "WHERE idMeal = @mealID AND user_id = @currentUserID"

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@mealID", mealID)
                    cmd.Parameters.AddWithValue("@currentUserID", LoginForm.currentUserID)

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        isFavorite = Convert.ToBoolean(result)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking favorites: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub UpdateFavoriteButton()
        If isFavorite Then
            btnFav.FillColor = Color.DarkRed
            btnFav.Text = "Remove"
            btnFav.Image = My.Resources.close
        Else
            btnFav.FillColor = Color.Red
            btnFav.Text = "Add to Favorites"
            btnFav.Image = My.Resources.favorite
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnFav.Click

        Dim userId As Integer = LoginForm.currentUserID

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                ' Check if the meal is already in favorites
                Dim checkQuery As String = "SELECT COUNT(*) FROM favorites WHERE user_id = @userId AND idMeal = @mealId"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@userId", userId)
                    checkCmd.Parameters.AddWithValue("@mealId", mealID)

                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists = 0 Then
                        ' Meal is not in favorites, so add it
                        Dim insertQuery As String = "INSERT INTO favorites (user_id, idMeal, created_at) VALUES (@userId, @mealId, NOW())"
                        Using insertCmd As New MySqlCommand(insertQuery, conn)
                            insertCmd.Parameters.AddWithValue("@userId", userId)
                            insertCmd.Parameters.AddWithValue("@mealId", mealID)
                            insertCmd.ExecuteNonQuery()
                            isFavorite = True ' Update the local state
                        End Using
                    Else
                        ' Meal is in favorites, so remove it
                        Dim deleteQuery As String = "DELETE FROM favorites WHERE user_id = @userId AND idMeal = @mealId"
                        Using deleteCmd As New MySqlCommand(deleteQuery, conn)
                            deleteCmd.Parameters.AddWithValue("@userId", userId)
                            deleteCmd.Parameters.AddWithValue("@mealId", mealID)
                            deleteCmd.ExecuteNonQuery()
                            isFavorite = False ' Update the local state
                        End Using
                    End If
                    RaiseEvent RefreshFavorites()
                End Using

                UpdateFavoriteButton()

                Dim mainForm As MainForm = CType(Application.OpenForms("MainForm"), MainForm)
                If mainForm IsNot Nothing Then
                    mainForm.RefreshFavorites()
                End If

            Catch ex As Exception
                MessageBox.Show("Error updating favorites: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        flowPanelVideo.Controls.Clear()
    End Sub

    Private Sub lblMealName_Click(sender As Object, e As EventArgs) Handles lblMealName.Click

    End Sub

    Private Sub ViewRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isFav()
        GetMealRatings(mealID)
        UpdateFavoriteButton()

        Dim comments As New CommentLayout(mealID)
        Me.CommentPanel.Controls.Add(comments)
        checkRole()


    End Sub


    Private Sub checkRole()
        If role = "admin" Then
            btnDelete.Visible = True
        Else
            btnDelete.Visible = False
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query As String = "DELETE FROM meals WHERE idMeal = @mealID"

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@mealID", mealID)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Recipe deleted successfully.")
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Error deleting recipe: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
