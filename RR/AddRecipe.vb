Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Imports Newtonsoft.Json

Public Class AddRecipe
    Dim userRole As String = LoginForm.currentUserRole
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim userID As Integer = LoginForm.currentUserID
    Private Sub AddRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shadowForm.SetShadowForm(Me)
        CheckUserRole()
        FetchCategory()
        FetchMealOrigin()

        cbRecipeOrigin.MaxDropDownItems = 5

    End Sub

    Private Sub CheckUserRole()
        If userRole = "admin" Then
            btnAddNewRecipe.Text = "ADD RECIPE"
        Else
            btnAddNewRecipe.Text = "SUBMIT FOR REVIEW"
        End If
    End Sub

    Private Sub AddRecipe()
        Dim mealName As String = txtMealName.Text.Trim()
        Dim recipeCategory As String = cbRecipeCategory.SelectedItem.ToString()
        Dim recipeOrigin As String = cbRecipeOrigin.SelectedItem.ToString()
        Dim recipeImageLink As String = txtRecipeImageLink.Text.Trim()
        Dim recipeInstruction As String = txtRecipeInstruction.Text.Trim()
        Dim recipeYoutubeLink As String = txtRecipeYoutubeLink.Text.Trim()
        Dim recipeIngredients As String = txtRecipeIngredients.Text.Trim()

        ' Check for empty fields
        If String.IsNullOrEmpty(mealName) OrElse String.IsNullOrEmpty(recipeCategory) OrElse String.IsNullOrEmpty(recipeOrigin) OrElse
       String.IsNullOrEmpty(recipeImageLink) OrElse String.IsNullOrEmpty(recipeInstruction) OrElse String.IsNullOrEmpty(recipeYoutubeLink) OrElse
       String.IsNullOrEmpty(recipeIngredients) Then
            MessageBox.Show("All fields are required.")
            Return
        End If

        ' Validate URLs
        If Not IsValidUrl(recipeImageLink) Then
            MessageBox.Show("Please enter a valid image URL.")
            Return
        End If

        If Not IsValidUrl(recipeYoutubeLink) Then
            MessageBox.Show("Please enter a valid YouTube URL.")
            Return
        End If

        Dim ingredientsArray As String() = ConvertIngredientsToArray(recipeIngredients)
        Dim ingredientsJson As String = JsonConvert.SerializeObject(ingredientsArray)

        Dim categoryID As Integer
        Dim areaID As Integer

        Try
            Dim userID As Integer = 16
            conn.Open()
            Try
                Dim categoryQuery As String = "SELECT id FROM categories WHERE category_name = @categoryName"
                Using cmd As New MySqlCommand(categoryQuery, conn)
                    cmd.Parameters.AddWithValue("@categoryName", recipeCategory)
                    categoryID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching category ID: " & ex.Message)
                Return
            End Try

            Try
                Dim areaQuery As String = "SELECT area_id FROM recipe_origin WHERE area_origin = @originName"
                Using cmd As New MySqlCommand(areaQuery, conn)
                    cmd.Parameters.AddWithValue("@originName", recipeOrigin)
                    areaID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching area ID: " & ex.Message)
                Return
            End Try

            Dim query As String = "INSERT INTO meals (strMeal, category_id, area_id, strMealThumb, strInstructions, strYoutube, ingredients, user_id) " &
                          "VALUES (@recipeName, @categoryID, @areaID, @imageLink, @instructions, @youtubeLink, @ingredients, @userID)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@recipeName", mealName)
                cmd.Parameters.AddWithValue("@categoryID", categoryID)
                cmd.Parameters.AddWithValue("@areaID", areaID)
                cmd.Parameters.AddWithValue("@imageLink", recipeImageLink)
                cmd.Parameters.AddWithValue("@instructions", recipeInstruction)
                cmd.Parameters.AddWithValue("@youtubeLink", recipeYoutubeLink)
                cmd.Parameters.AddWithValue("@ingredients", ingredientsJson)
                cmd.Parameters.AddWithValue("@userID", userID)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Recipe added successfully.")
            ClearFields()
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error adding recipe: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function IsValidUrl(url As String) As Boolean
        Dim pattern As String = "^(http|https)://[^\s/$.?#].[^\s]*$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(url)
    End Function


    Private Function ConvertIngredientsToArray(ingredients As String) As String()
        Return ingredients.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries).Select(Function(i) i.Trim()).ToArray()
    End Function

    Private Sub SubmitRecipe()
        Dim mealName As String = txtMealName.Text.Trim()
        Dim recipeCategory As String = cbRecipeCategory.SelectedItem.ToString()
        Dim recipeOrigin As String = cbRecipeOrigin.SelectedItem.ToString()
        Dim recipeImageLink As String = txtRecipeImageLink.Text.Trim()
        Dim recipeInstruction As String = txtRecipeInstruction.Text.Trim()
        Dim recipeYoutubeLink As String = txtRecipeYoutubeLink.Text.Trim()
        Dim recipeIngredients As String = txtRecipeIngredients.Text.Trim()

        ' Check for empty fields
        If String.IsNullOrEmpty(mealName) OrElse String.IsNullOrEmpty(recipeCategory) OrElse String.IsNullOrEmpty(recipeOrigin) OrElse
       String.IsNullOrEmpty(recipeImageLink) OrElse String.IsNullOrEmpty(recipeInstruction) OrElse String.IsNullOrEmpty(recipeYoutubeLink) OrElse
       String.IsNullOrEmpty(recipeIngredients) Then
            MessageBox.Show("All fields are required.")
            Return
        End If

        ' Validate URLs
        If Not IsValidUrl(recipeImageLink) Then
            MessageBox.Show("Please enter a valid image URL.")
            Return
        End If

        If Not IsValidUrl(recipeYoutubeLink) Then
            MessageBox.Show("Please enter a valid YouTube URL.")
            Return
        End If

        Dim ingredientsArray As String() = ConvertIngredientsToArray(recipeIngredients)
        Dim ingredientsJson As String = JsonConvert.SerializeObject(ingredientsArray)

        Dim categoryID As Integer
        Dim areaID As Integer

        Try

            conn.Open()
            Try
                Dim categoryQuery As String = "SELECT id FROM categories WHERE category_name = @categoryName"
                Using cmd As New MySqlCommand(categoryQuery, conn)
                    cmd.Parameters.AddWithValue("@categoryName", recipeCategory)
                    categoryID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching category ID: " & ex.Message)
                Return
            End Try

            Try
                Dim areaQuery As String = "SELECT area_id FROM recipe_origin WHERE area_origin = @originName"
                Using cmd As New MySqlCommand(areaQuery, conn)
                    cmd.Parameters.AddWithValue("@originName", recipeOrigin)
                    areaID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching area ID: " & ex.Message)
                Return
            End Try

            Dim query As String = "INSERT INTO pending_recipes (strMeal, category_id, area_id, strMealThumb, strInstructions, strYoutube, ingredients, user_id) " &
                          "VALUES (@recipeName, @categoryID, @areaID, @imageLink, @instructions, @youtubeLink, @ingredients, @userID)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@recipeName", mealName)
                cmd.Parameters.AddWithValue("@categoryID", categoryID)
                cmd.Parameters.AddWithValue("@areaID", areaID)
                cmd.Parameters.AddWithValue("@imageLink", recipeImageLink)
                cmd.Parameters.AddWithValue("@instructions", recipeInstruction)
                cmd.Parameters.AddWithValue("@youtubeLink", recipeYoutubeLink)
                cmd.Parameters.AddWithValue("@ingredients", ingredientsJson)
                cmd.Parameters.AddWithValue("@userID", userID)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Recipe added successfully.")
            ClearFields()
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error adding recipe: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAddNewRecipe_Click(sender As Object, e As EventArgs) Handles btnAddNewRecipe.Click
        SubmitRecipe()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub

    Private Sub txtMealName_TextChanged(sender As Object, e As EventArgs) Handles txtMealName.TextChanged

    End Sub

    Private Sub cbRecipeCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRecipeCategory.SelectedIndexChanged

    End Sub

    Private Sub FetchCategory()
        cbRecipeCategory.Items.Add("--SELECT CATEGORY--")
        cbRecipeCategory.StartIndex = 0
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM categories"
            Using cmd As New MySqlCommand(query, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim category As String = dr("category_name").ToString()
                        cbRecipeCategory.Items.Add(category)
                    End While
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error fetching categories: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub talk()

    End Sub
    Private Sub FetchMealOrigin()
        cbRecipeOrigin.Items.Add("--SELECT ORIGIN--")
        cbRecipeOrigin.StartIndex = 0
        Try
            conn.Open()
            Dim query As String = "SELECT * from recipe_origin"
            Using cmd As New MySqlCommand(query, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim origin As String = dr("area_origin").ToString()
                        cbRecipeOrigin.Items.Add(origin)
                    End While
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error fetching recipe origin: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub ClearFields()
        txtMealName.Text = ""
        cbRecipeCategory.SelectedIndex = 0
        cbRecipeOrigin.SelectedIndex = 0
        txtRecipeImageLink.Text = ""
        txtRecipeInstruction.Text = ""
        txtRecipeYoutubeLink.Text = ""
        txtRecipeIngredients.Text = ""
    End Sub
    Private Sub cbRecipeOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRecipeOrigin.SelectedIndexChanged

    End Sub

    Private Sub txtRecipeImageLink_TextChanged(sender As Object, e As EventArgs) Handles txtRecipeImageLink.TextChanged

    End Sub

    Private Sub txtRecipeInstruction_TextChanged(sender As Object, e As EventArgs) Handles txtRecipeInstruction.TextChanged

    End Sub

    Private Sub txtRecipeYoutubeLink_TextChanged(sender As Object, e As EventArgs) Handles txtRecipeYoutubeLink.TextChanged

    End Sub

    Private Sub txtRecipeIngredients_TextChanged(sender As Object, e As EventArgs) Handles txtRecipeIngredients.TextChanged

    End Sub
End Class