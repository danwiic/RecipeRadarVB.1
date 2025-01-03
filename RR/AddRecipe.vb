Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor

Public Class AddRecipe
    Dim userRole As String = LoginForm.currentUserRole
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
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
        If mealName = "" Or recipeCategory = "" Or recipeOrigin = "" Or recipeImageLink = "" Or recipeInstruction = "" Or recipeYoutubeLink = "" Or recipeIngredients = "" Then
            MessageBox.Show("All fields are required.")
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO meals (strMeal, category, origin, image_link, instructions, youtube_link, ingredients) VALUES (@recipeName, @category, @origin, @imageLink, @instructions, @youtubeLink, @ingredients)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@recipeName", mealName)
                cmd.Parameters.AddWithValue("@category", recipeCategory)
                cmd.Parameters.AddWithValue("@origin", recipeOrigin)
                cmd.Parameters.AddWithValue("@imageLink", recipeImageLink)
                cmd.Parameters.AddWithValue("@instructions", recipeInstruction)
                cmd.Parameters.AddWithValue("@youtubeLink", recipeYoutubeLink)
                cmd.Parameters.AddWithValue("@ingredients", recipeIngredients)
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
        FetchCategory()
        FetchMealOrigin()
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