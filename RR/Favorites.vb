Imports MySql.Data.MySqlClient

Public Class Favorites

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim maxColumns As Integer = 5
    Private currentPage As Integer = 1
    Private pageSize As Integer = 10
    Private totalMeals As Integer = 0
    Private Sub Favorites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelFav.FlowDirection = FlowDirection.LeftToRight
        panelFav.WrapContents = True
        LoadFavoriteMeals()
        checkButton()
    End Sub

    Private Sub checkButton()
        If totalMeals <= currentPage * pageSize Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If

        If currentPage = 1 Then
            btnPrev.Enabled = False
        Else
            btnPrev.Enabled = True
        End If
    End Sub

    Private Sub AdjustPanelSizes()
        If maxColumns <= 0 Then
            MessageBox.Show("Max columns must be greater than 0.")
            Return
        End If

        Dim panelWidth As Integer = panelFav.Width
        Dim cardWidth As Integer = (panelWidth - (maxColumns - 1) * 10) / maxColumns

        For Each ctrl As Control In panelFav.Controls
            If TypeOf ctrl Is MealCard Then
                ctrl.Width = cardWidth
            End If
        Next

        Dim cardHeight As Integer = 290
        Dim resultRows As Integer = Math.Ceiling(panelFav.Controls.Count / maxColumns)
        panelFav.Height = If(resultRows > 0, (resultRows * cardHeight) + (resultRows - 1) * 10, 0)

    End Sub

    Public Sub LoadFavoriteMeals()
        Dim userId As Integer = LoginForm.currentUserID

        Dim countQuery As String = "SELECT COUNT(*) FROM favorites WHERE user_id = @userId"

        Try
            conn.Open()
            Using countCmd As New MySqlCommand(countQuery, conn)
                countCmd.Parameters.AddWithValue("@userId", userId)
                totalMeals = Convert.ToInt32(countCmd.ExecuteScalar())
            End Using

            Dim offset As Integer = (currentPage - 1) * pageSize

            Dim query As String = "SELECT m.idMeal, m.strMeal, m.strMealThumb, AVG(r.rating) AS averageRating " &
                              "FROM favorites f " &
                              "JOIN meals m ON f.idMeal = m.idMeal " &
                              "LEFT JOIN ratings r ON m.idMeal = r.meal_id " &
                              "WHERE f.user_id = @userId " &
                              "GROUP BY m.idMeal, m.strMeal, m.strMealThumb " &
                              "LIMIT @pageSize OFFSET @offset"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.Parameters.AddWithValue("@pageSize", pageSize)
                cmd.Parameters.AddWithValue("@offset", offset)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    panelFav.Controls.Clear()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim mealID As Integer = reader.GetInt32("idMeal")
                            Dim mealName As String = reader.GetString("strMeal")
                            Dim mealImage As String = reader.GetString("strMealThumb")
                            Dim averageRating As Single = If(reader.IsDBNull(reader.GetOrdinal("averageRating")), 0, reader.GetFloat("averageRating"))

                            Dim mealCard As New MealCardFavorites()
                            mealCard.SetMealData(mealID, mealName, mealImage, averageRating, True)
                            panelFav.Controls.Add(mealCard)
                        End While
                        AdjustPanelSizes()
                    Else
                        lblMessage.Visible = True
                        lblMessage.Text = "No favoite recipes added yet."
                    End If
                End Using
            End Using

            Dim totalPages As Integer = Math.Ceiling(totalMeals / pageSize)

            If totalPages = 0 Then
                totalPages = 1
                Return
            End If
            lblPages.Text = $"Page {currentPage.ToString()} of {totalPages.ToString()}"

        Catch ex As Exception
            MessageBox.Show("Error loading favorite meals: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub RemoveMealFromFavorites(mealID As Integer)
        Dim userId As Integer = LoginForm.currentUserID

        Dim deleteQuery As String = "DELETE FROM favorites WHERE user_id = @userId AND idMeal = @mealId"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(deleteQuery, conn)
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.Parameters.AddWithValue("@mealId", mealID)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Meal removed from favorites.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error removing meal from favorites: " & ex.Message)
        Finally
            conn.Close()
        End Try
        LoadFavoriteMeals()
    End Sub

    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < Math.Ceiling(totalMeals / pageSize) Then
            currentPage += 1
            LoadFavoriteMeals()
            checkButton()
        End If
    End Sub

    Private Sub btnPrev_Click_1(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadFavoriteMeals()
            checkButton()
        End If
    End Sub

    Private Sub lblPages_Click(sender As Object, e As EventArgs) Handles lblPages.Click

    End Sub
End Class
