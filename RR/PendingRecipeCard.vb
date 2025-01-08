Imports MySql.Data.MySqlClient

Public Class PendingRecipeCard
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim mealID As Integer
    Public Event RecipeUpdated()

    Public Sub SetMeal(mealID As Integer, mealName As String, mealImage As String)
        picMealImage.Load(mealImage)
        Me.mealID = mealID
        lblMealName.Text = mealName
    End Sub

    Private Sub InsertRecipe()
        Dim strMeal As String
        Dim category_id As Integer
        Dim area_id As Integer
        Dim strInstructions As String
        Dim strMealThumb As String
        Dim strYoutube As String
        Dim ingredients As String
        Dim user_id As Integer

        Try
            conn.Open()

            Dim queryPendingDetails As String = "SELECT * FROM pending_recipes WHERE id = @mealID"
            Using cmdPendingDetails As New MySqlCommand(queryPendingDetails, conn)
                cmdPendingDetails.Parameters.AddWithValue("@mealID", mealID)
                Using reader As MySqlDataReader = cmdPendingDetails.ExecuteReader()
                    If reader.Read() Then
                        strMeal = reader.GetString("strMeal")
                        category_id = reader.GetInt32("category_id")
                        area_id = reader.GetInt32("area_id")
                        strInstructions = reader.GetString("strInstructions")
                        strMealThumb = reader.GetString("strMealThumb")
                        strYoutube = reader.GetString("strYoutube")
                        ingredients = reader.GetString("ingredients")
                        user_id = reader.GetInt32("user_id")
                    End If
                End Using
            End Using

            Dim insertQuery As String = "INSERT INTO meals (strMeal, category_id, area_id, strInstructions, strMealThumb, strYoutube, ingredients, user_id) " &
                                         "VALUES (@strMeal, @category_id, @area_id, @strInstructions, @strMealThumb, @strYoutube, @ingredients, @user_id)"

            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@strMeal", strMeal)
                cmd.Parameters.AddWithValue("@category_id", category_id)
                cmd.Parameters.AddWithValue("@area_id", area_id)
                cmd.Parameters.AddWithValue("@strInstructions", strInstructions)
                cmd.Parameters.AddWithValue("@strMealThumb", strMealThumb)
                cmd.Parameters.AddWithValue("@strYoutube", strYoutube)
                cmd.Parameters.AddWithValue("@ingredients", ingredients)
                cmd.Parameters.AddWithValue("@user_id", user_id)

                cmd.ExecuteNonQuery() ' Execute the insert command
            End Using

            ' Delete from pending_recipes after successful insertion
            Dim deleteQuery As String = "DELETE FROM pending_recipes WHERE id = @mealID"
            Using cmdDelete As New MySqlCommand(deleteQuery, conn)
                cmdDelete.Parameters.AddWithValue("@mealID", mealID)
                cmdDelete.ExecuteNonQuery() ' Execute the delete command
            End Using

            RaiseEvent RecipeUpdated()
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error inserting recipe: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub RejectRecipe()
        Try
            conn.Open()

            Dim query As String = "DELETE FROM pending_recipes WHERE id = @mealID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@mealID", mealID)
                cmd.ExecuteNonQuery()
            End Using

            RaiseEvent RecipeUpdated()
        Catch ex As Exception
            MessageBox.Show("Error rejecting recipe: " & ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub btnView_MouseEnter(sender As Object, e As EventArgs) Handles btnView.MouseEnter
        btnView.FillColor = Color.FromArgb(94, 148, 255)
        btnView.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub btnView_MouseLeave(sender As Object, e As EventArgs) Handles btnView.MouseLeave
        btnView.FillColor = Color.WhiteSmoke
        btnView.ForeColor = Color.FromArgb(94, 148, 255)
    End Sub

    Private Sub btnAprrove_Click(sender As Object, e As EventArgs) Handles btnAprrove.Click
        InsertRecipe()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        RejectRecipe()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

    End Sub
End Class