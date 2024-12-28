Imports MySql.Data.MySqlClient

Public Class Meals

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim maxColumns As Integer = 5
    Private currentPage As Integer = 1
    Private pageSize As Integer = 10
    Private totalMeals As Integer = 0
    Private Sub Meals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTotalMealsCount() ' Load the total number of meals first
        LoadAddedMeals() ' Load meals for the current page
        UpdateCurrentPageLabel() ' Update the current page label
        checkRole() ' Check user role for button text
    End Sub

    Private Sub LoadTotalMealsCount()
        Dim userId As Integer = LoginForm.currentUserID ' Get the current user ID
        Dim countQuery As String = "SELECT COUNT(*) FROM meals WHERE user_id = @userId"

        Try
            conn.Open()
            Using countCmd As New MySqlCommand(countQuery, conn)
                countCmd.Parameters.AddWithValue("@userId", userId)
                totalMeals = Convert.ToInt32(countCmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading total meals count: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub LoadAddedMeals()
        Dim userId As Integer = LoginForm.currentUserID ' Get the current user ID

        ' Updated query to include pagination
        Dim query As String = "SELECT m.idMeal, m.strMeal, m.strMealThumb, AVG(r.rating) AS averageRating " &
                              "FROM meals m " &
                              "LEFT JOIN ratings r ON m.idMeal = r.meal_id " &
                              "WHERE m.user_id = @userId " &
                              "GROUP BY m.idMeal, m.strMeal, m.strMealThumb " &
                              "LIMIT @pageSize OFFSET @offset"

        Dim offset As Integer = (currentPage - 1) * pageSize

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.Parameters.AddWithValue("@pageSize", pageSize)
                cmd.Parameters.AddWithValue("@offset", offset)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Clear existing meal cards in the panel before loading new ones
                    panelAddedMeals.Controls.Clear()

                    If reader.HasRows Then
                        While reader.Read()
                            Dim mealID As Integer = reader.GetInt32("idMeal")
                            Dim mealName As String = reader.GetString("strMeal")
                            Dim mealImage As String = reader.GetString("strMealThumb")
                            Dim averageRating As Single = If(reader.IsDBNull(reader.GetOrdinal("averageRating")), 0, reader.GetFloat("averageRating"))

                            ' Create a new meal card or UI element for each added meal
                            Dim mealCard As New MealCardStar()
                            mealCard.SetMealData(mealID, mealName, mealImage, averageRating, False) ' Assuming isFavorite is False
                            panelAddedMeals.Controls.Add(mealCard)
                        End While
                    Else
                        lblMessage.Text = "No added meals yet." ' Assuming you have a label named lblMessage
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error loading added meals: " & ex.Message)
        Finally
            conn.Close()
        End Try

        UpdateCurrentPageLabel() ' Update the current page label after loading meals
    End Sub

    Private Sub UpdateCurrentPageLabel()
        Dim totalPages As Integer = Math.Ceiling(totalMeals / pageSize) ' Calculate total pages
        lblPage.Text = "Page " & currentPage.ToString() & " of " & totalPages.ToString() ' Update the label text

        btnPrev.Enabled = currentPage > 1
        btnNext.Enabled = currentPage < totalPages
    End Sub

    Private Sub checkRole()
        Dim userRole = LoginForm.currentUserRole

        If userRole = "admin" Then
            btnAdd.Text = "ADD NEW RECIPE"
        Else
            btnAdd.Text = "SUBMIT NEW RECIPE"
        End If
    End Sub
End Class
