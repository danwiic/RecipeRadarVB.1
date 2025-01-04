Imports MySql.Data.MySqlClient

Public Class MealCardFavorites
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Public Property mealID As Integer
    Public Property isFavorite As Boolean

    Public Sub SetMealData(mealID As Integer, mealName As String, mealImage As String, mealRating As Single, isFavorite As Boolean)
        Me.mealID = mealID
        lblMealName.Text = mealName
        picMealImage.Load(mealImage)
        mealRatings.Value = mealRating
        Me.isFavorite = isFavorite

        If mealRating > 1 Then
            lblRates.Text = mealRating.ToString("F1")
        Else
            lblRates.Text = mealRating.ToString()
        End If

        checkIsFav()
    End Sub

    Private Sub checkIsFav()
        If isFavorite Then
            chkFav.BackgroundImage = My.Resources.colored
        Else
            chkFav.BackgroundImage = My.Resources.borderedHeart
        End If
    End Sub

    Private Sub chkFav_Click(sender As Object, e As EventArgs) Handles chkFav.Click
        Dim userId As Integer = LoginForm.currentUserID

        Try
            conn.Open()

            Dim checkQuery As String = "SELECT COUNT(*) FROM favorites WHERE user_id = @userId AND idMeal = @mealId"
            Using checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@userId", userId)
                checkCmd.Parameters.AddWithValue("@mealId", mealID)

                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If exists = 0 Then
                    Dim insertQuery As String = "INSERT INTO favorites (user_id, idMeal, created_at) VALUES (@userId, @mealId, NOW())"
                    Using insertCmd As New MySqlCommand(insertQuery, conn)
                        insertCmd.Parameters.AddWithValue("@userId", userId)
                        insertCmd.Parameters.AddWithValue("@mealId", mealID)

                        insertCmd.ExecuteNonQuery()
                        MessageBox.Show("Meal added to favorites", "Adding success", MessageBoxButtons.OK, MessageBoxIcon.None)
                        isFavorite = True
                    End Using
                ElseIf exists > 0 Then
                    Dim deleteQuery As String = "DELETE FROM favorites WHERE user_id = @userId AND idMeal = @mealId"
                    Using deleteCmd As New MySqlCommand(deleteQuery, conn)
                        deleteCmd.Parameters.AddWithValue("@userId", userId)
                        deleteCmd.Parameters.AddWithValue("@mealId", mealID)

                        deleteCmd.ExecuteNonQuery()
                        isFavorite = False
                    End Using
                End If
            End Using

            checkIsFav()

            Dim mainForm As MainForm = CType(Application.OpenForms("MainForm"), MainForm)
            mainForm.displayPanel.Controls.Clear()
            Dim fav As New Favorites
            mainForm.displayPanel.Controls.Add(fav)
            fav.Dock = DockStyle.Fill

        Catch ex As Exception
            MessageBox.Show("Error updating favorites: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub MealCardFav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkIsFav()
    End Sub

    Private Sub btnView_MouseEnter(sender As Object, e As EventArgs) Handles btnView.MouseEnter
        btnView.FillColor = Color.FromArgb(94, 148, 255)
        btnView.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub btnView_MouseLeave(sender As Object, e As EventArgs) Handles btnView.MouseLeave
        btnView.FillColor = Color.WhiteSmoke
        btnView.ForeColor = Color.FromArgb(94, 148, 255)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim StarRecipeControl As New ViewRecipe(mealID)
        Dim main As MainForm = CType(Application.OpenForms("MainForm"), MainForm)
        main.displayPanel.Controls.Add(StarRecipeControl)
        StarRecipeControl.Dock = DockStyle.Fill
        main.displayPanel.VerticalScroll.Value = 0
        StarRecipeControl.BringToFront()
        main.displayPanel.PerformLayout()
        main.displayPanel.Invalidate()
    End Sub

    Private Sub picMealImage_Click(sender As Object, e As EventArgs) Handles picMealImage.Click

    End Sub
End Class
