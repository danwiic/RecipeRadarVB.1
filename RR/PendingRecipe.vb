Imports MySql.Data.MySqlClient

Public Class PendingRecipe

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim maxColumns As Integer = 5
    Private currentPage As Integer = 1
    Private pageSize As Integer = 10
    Private totalMeals As Integer = 0

    Private Sub PendingRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayPendingRecipes.FlowDirection = FlowDirection.LeftToRight
        displayPendingRecipes.WrapContents = True
        AdjustPanelSizes()
        FetchPendingRecipes()
    End Sub

    Private Sub OnRecipeUpdated()
        displayPendingRecipes.Controls.Clear()
        FetchPendingRecipes()
    End Sub
    Public Sub FetchPendingRecipes()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM pending_recipes"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If Not reader.HasRows Then
                        lblMessage.Visible = True
                        lblMessage.Text = "No pending recipes found."
                    End If

                    While reader.Read()
                        lblMessage.Visible = False
                        Dim pendingCard As New PendingRecipeCard
                        Dim mealID As Integer = reader.GetInt32("id")
                        Dim mealName As String = reader.GetString("strMeal")
                        Dim mealImage As String = reader.GetString("strMealThumb")
                        pendingCard.SetMeal(mealID, mealName, mealImage)
                        AddHandler pendingCard.RecipeUpdated, AddressOf OnRecipeUpdated
                        displayPendingRecipes.Controls.Add(pendingCard)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching pending recipes: " & ex.Message)
        Finally
            conn.Close()
        End Try

        AdjustPanelSizes() ' Call this after adding cards
    End Sub

    Private Sub AdjustPanelSizes()
        If maxColumns <= 0 Then
            MessageBox.Show("Max columns must be greater than 0.")
            Return
        End If

        Dim panelWidth As Integer = displayPendingRecipes.Width
        Dim cardWidth As Integer = (panelWidth - (maxColumns - 1) * 10) / maxColumns

        For Each ctrl As Control In displayPendingRecipes.Controls
            If TypeOf ctrl Is PendingRecipeCard Then
                ctrl.Width = cardWidth
            End If
        Next

        Dim cardHeight As Integer = 290
        Dim resultRows As Integer = Math.Ceiling(displayPendingRecipes.Controls.Count / maxColumns)
        displayPendingRecipes.Height = If(resultRows > 0, (resultRows * cardHeight) + (resultRows - 1) * 10, 0)
    End Sub
End Class