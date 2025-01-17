Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Categories
    Dim connStr As String = "server=localhost; uid=root; pwd=; database=recipe_books;"
    Dim conn As New MySqlConnection(connStr)
    Dim currentUserID As Integer = LoginForm.currentUserID
    Private currentPage As Integer = 1
    Private mealsPerPage As Integer = 10
    Private totalMeals As Integer = 0
    Private totalPages As Integer = 1
    Private selectedCategoryId As Integer = 0
    Public Class Category
        Public Property Id As Integer
        Public Property Name As String

        ' Override ToString to return the category name
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCategories()
        LoadMeals() ' Load meals for the first page
    End Sub

    Private Sub GetCategories()
        cbCategories.Items.Clear() ' Clear existing items

        ' Add "All" option to ComboBox
        cbCategories.Items.Add(New Category With {.Id = 0, .Name = "All"}) ' Use 0 for "All"

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM categories"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim categoryId As Integer = reader.GetInt32("id")
                        Dim categoryName As String = reader.GetString("category_name")

                        ' Add category to ComboBox
                        cbCategories.Items.Add(New Category With {.Id = categoryId, .Name = categoryName})
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving categories: " & ex.Message)
        Finally
            conn.Close()
        End Try

        ' Set the ComboBox to the first item
        cbCategories.SelectedIndex = 0
    End Sub

    Private Sub cbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategories.SelectedIndexChanged
        Dim selectedCategory As Category = CType(cbCategories.SelectedItem, Category)

        If selectedCategory IsNot Nothing Then
            selectedCategoryId = selectedCategory.Id ' Store the selected category ID

            If selectedCategory.Id = 0 Then
                currentPage = 1 ' Reset to the first page
                LoadMeals() ' Load all meals
            Else
                currentPage = 1 ' Reset to the first page for the selected category
                LoadMeals(selectedCategory.Id) ' Load meals for the selected category
            End If
        End If
    End Sub

    Private Sub LoadMeals(Optional categoryId As Integer = 0, Optional searchText As String = "")
        FlowLayoutPanelMeals.Controls.Clear()

        ' Use the selectedCategoryId if categoryId is not provided
        If categoryId = 0 Then
            categoryId = selectedCategoryId
        End If

        ' Define the base query with joins and necessary fields
        Dim query As String = "SELECT COUNT(*) FROM meals m " &
                          "LEFT JOIN ratings r ON m.idMeal = r.meal_id " &
                          "LEFT JOIN categories c ON m.category_id = c.id " &
                          "LEFT JOIN favorites f ON m.idMeal = f.idMeal AND f.user_id = @currentUserID "

        ' Add filtering for category
        If categoryId > 0 Then
            query &= "WHERE m.category_id = @categoryId "
        End If

        ' Get total meals count
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                If categoryId > 0 Then
                    cmd.Parameters.AddWithValue("@categoryId", categoryId)
                End If
                cmd.Parameters.AddWithValue("@currentUserID", currentUserID)

                totalMeals = Convert.ToInt32(cmd.ExecuteScalar())
                totalPages = Math.Ceiling(totalMeals / mealsPerPage)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error counting meals: " & ex.Message)
        Finally
            conn.Close()
        End Try

        ' Define the query to load meals for the current page
        query = "SELECT m.idMeal, " &
            "m.strMeal, " &
            "m.strMealThumb, " &
            "COALESCE(AVG(r.rating), 0) AS averageRating, " &
            "COALESCE(COUNT(r.rating), 0) AS ratingCount, " &
            "c.category_name, " &
            "CASE WHEN f.idMeal IS NOT NULL THEN 1 ELSE 0 END AS isFavorite " &
            "FROM meals m " &
            "LEFT JOIN ratings r ON m.idMeal = r.meal_id " &
            "LEFT JOIN categories c ON m.category_id = c.id " &
            "LEFT JOIN favorites f ON m.idMeal = f.idMeal AND f.user_id = @currentUserID "

        ' Add filtering for category and search text
        If categoryId > 0 Then
            query &= "WHERE m.category_id = @categoryId "
        End If

        If Not String.IsNullOrEmpty(searchText) Then
            If categoryId > 0 Then
                query &= "AND LOWER(m.strMeal) LIKE LOWER(@searchText) "
            Else
                query &= "WHERE LOWER(m.strMeal) LIKE LOWER(@searchText) "
            End If
        End If

        query &= "GROUP BY m.idMeal, m.strMeal, m.strMealThumb, c.category_name " &
             "ORDER BY averageRating DESC, ratingCount DESC " &
             "LIMIT @limit OFFSET @offset"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters for category and search text
                If categoryId > 0 Then
                    cmd.Parameters.AddWithValue("@categoryId", categoryId)
                End If

                If Not String.IsNullOrEmpty(searchText) Then
                    cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                End If

                cmd.Parameters.AddWithValue("@currentUserID", currentUserID)
                cmd.Parameters.AddWithValue("@limit", mealsPerPage)
                cmd.Parameters.AddWithValue("@offset", (currentPage - 1) * mealsPerPage)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim MealID As Integer = reader("idMeal")
                        Dim MealName As String = reader("strMeal")
                        Dim ImageLink As String = reader("strMealThumb")
                        Dim MealRatings As Single = reader("averageRating")
                        Dim isFavorite As Boolean = reader("isFavorite")

                        Dim cards As New MealCardFavorites
                        cards.SetMealData(MealID, MealName, ImageLink, MealRatings, isFavorite)

                        FlowLayoutPanelMeals.Controls.Add(cards)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading meals: " & ex.Message)
        Finally
            conn.Close()
        End Try

        UpdatePaginationButtons()
    End Sub
    Private Sub UpdatePaginationButtons()
        btnPrev.Enabled = currentPage > 1
        btnNext.Enabled = currentPage < totalPages
        lblPages.Text = $"Page {currentPage} of {totalPages}"
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadMeals()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < totalPages Then
            currentPage += 1
            LoadMeals()
        End If
    End Sub

    Private Sub lblPages_Click(sender As Object, e As EventArgs) Handles lblPages.Click
    End Sub
End Class