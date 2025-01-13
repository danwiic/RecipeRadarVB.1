Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class UpdateRecipe
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim userID As Integer = LoginForm.currentUserID
    Dim recipeID As Integer = 8

    Public Sub New(pendingID As Integer)
        Me.recipeID = pendingID
        InitializeComponent()
    End Sub

    Private Sub LoadRecipe()
        Dim query As String = "SELECT * FROM pending_recipes WHERE id = @recipeID"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@recipeID", recipeID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtMealName.Text = reader("strMeal")
                        txtRecipeImageLink.Text = reader("strMealThumb")
                        txtRecipeYoutubeLink.Text = reader("strYoutube")
                        Dim ingredients As String = reader("ingredients")
                        txtRecipeInstruction.Text = reader("strInstructions")

                        DisplayIngredients(ingredients)
                        Dim category_id As Integer = reader("category_id")
                        Dim area_id As Integer = reader("area_id")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading recipe: " & ex.Message)
        Finally
            conn.Close()
        End Try
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

    Private Sub DisplayIngredients(ingredientsJson As String)
        Try
            Dim ingredientsList As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(ingredientsJson)
            txtRecipeIngredients.Clear()

            For Each ingredient As String In ingredientsList
                txtRecipeIngredients.AppendText(ingredient & "," & Environment.NewLine)
            Next

        Catch ex As Exception
            MessageBox.Show("Error parsing ingredients: " & ex.Message)
        End Try
    End Sub



    Private Sub UpdatePending()
        Dim recipeIngredients As String = txtRecipeIngredients.Text
        Try
            conn.Open()
            Dim ingredientsArray As String() = ConvertIngredientsToArray(recipeIngredients)
            Dim ingredientsJson As String = JsonConvert.SerializeObject(ingredientsArray)
            ' Get the selected category and origin names
            Dim selectedCategory As String = cbRecipeCategory.SelectedItem.ToString()
            Dim selectedOrigin As String = cbRecipeOrigin.SelectedItem.ToString()


            Dim categoryID As Integer
            Dim areaID As Integer

            Try
                Dim categoryQuery As String = "SELECT id FROM categories WHERE category_name = @categoryName"
                Using cmd As New MySqlCommand(categoryQuery, conn)
                    cmd.Parameters.AddWithValue("@categoryName", selectedCategory)
                    categoryID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching category ID: " & ex.Message)
                Return
            End Try

            Try
                Dim areaQuery As String = "SELECT area_id FROM recipe_origin WHERE area_origin = @originName"
                Using cmd As New MySqlCommand(areaQuery, conn)
                    cmd.Parameters.AddWithValue("@originName", selectedOrigin)
                    areaID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching area ID: " & ex.Message)
                Return
            End Try

            ' Update the recipe in the database
            Dim query As String = "UPDATE pending_recipes SET strMeal = @mealName, strMealThumb = @mealImage, strYoutube = @youtubeLink, ingredients = @ingredients, strInstructions = @instructions, category_id = @categoryID, area_id = @areaID WHERE id = @recipeID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@mealName", txtMealName.Text)
                cmd.Parameters.AddWithValue("@mealImage", txtRecipeImageLink.Text)
                cmd.Parameters.AddWithValue("@youtubeLink", txtRecipeYoutubeLink.Text)
                cmd.Parameters.AddWithValue("@ingredients", ingredientsJson)
                cmd.Parameters.AddWithValue("@instructions", txtRecipeInstruction.Text)
                cmd.Parameters.AddWithValue("@categoryID", categoryID)
                cmd.Parameters.AddWithValue("@areaID", areaID)
                cmd.Parameters.AddWithValue("@recipeID", recipeID)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Recipe updated successfully.")
                Me.Hide()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function ConvertIngredientsToArray(ingredients As String) As String()
        Return ingredients.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries).Select(Function(i) i.Trim()).ToArray()
    End Function

    Private Sub UpdateRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shadowForm.SetShadowForm(Me)
        FetchCategory()
        FetchMealOrigin()
        LoadRecipe()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub

    Private Sub btnAddNewRecipe_Click(sender As Object, e As EventArgs) Handles btnAddNewRecipe.Click
        UpdatePending()
    End Sub
End Class