Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class PendingData
    Dim recipeID As Integer = ViewInfoPendingRecipe.pendingRecipeID
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Private Sub PendingData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPendingRecipe()
    End Sub


    Private Sub LoadPendingRecipe()
        Try
            conn.Open()
            Dim query As String = "SELECT pr.*, c.category_name, ro.area_origin " &
                              "FROM pending_recipes pr " &
                              "JOIN categories c ON pr.category_id = c.id " &
                              "JOIN recipe_origin ro ON pr.area_id = ro.area_id " &
                              "WHERE pr.id = @recipeID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@recipeID", recipeID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        lblMealName.Text = reader.GetString("strMeal")
                        txtInstructions.Text = reader.GetString("strInstructions")
                        Dim IngredientsJSON As String = reader.GetString("ingredients")
                        DisplayIngredients(IngredientsJSON)
                        Dim url As String = reader.GetString("strYoutube")
                        Dim vid As New SmallVid(url)
                        flowPanelVideo.Controls.Add(vid)
                        lblCategory.Text = reader.GetString("category_name")
                        lblOrigin.Text = reader.GetString("area_origin") & " Dish"
                    Else
                        MessageBox.Show("No data found for the specified recipe ID.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pending recipe: " & ex.Message)
        Finally
            conn.Close()
        End Try
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
    Private Sub txtInstructions_TextChanged(sender As Object, e As EventArgs) Handles txtInstructions.TextChanged

    End Sub
End Class
