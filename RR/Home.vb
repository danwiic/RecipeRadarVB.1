Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class Home

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim maxColumns As Integer = 5
    Dim currentUserID As Integer = LoginForm.currentUserID

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flowPanelPopular.FlowDirection = FlowDirection.LeftToRight
        flowPanelPopular.WrapContents = True
        LoadMealsData()

        flowPanelHighRated.FlowDirection = FlowDirection.LeftToRight
        flowPanelHighRated.WrapContents = True
        LoadRatedMeal()

        flowPanelResults.FlowDirection = FlowDirection.LeftToRight
        flowPanelResults.WrapContents = True

        flowPanelResults.Visible = False  ' Initially hidden
        lblResults.Visible = False
    End Sub

    Private Sub AdjustPanelSizes()
        ' Ensure maxColumns is greater than 0 to avoid division by zero
        If maxColumns <= 0 Then
            MessageBox.Show("Max columns must be greater than 0.")
            Return
        End If

        Dim panelWidth As Integer = flowPanelPopular.Width
        Dim panelWidthRated As Integer = flowPanelHighRated.Width
        Dim panelWidthResults As Integer = flowPanelResults.Width

        ' Calculate card widths
        Dim cardWidth As Integer = (panelWidth - (maxColumns - 1) * 10) \ maxColumns
        Dim cardWidthRated As Integer = (panelWidthRated - (maxColumns - 1) * 10) \ maxColumns
        Dim cardWidthResults As Integer = (panelWidthResults - (maxColumns - 1) * 10) \ maxColumns

        ' Adjust widths for each panel
        For Each ctrl As Control In flowPanelPopular.Controls
            If TypeOf ctrl Is MealCard Then
                ctrl.Width = cardWidth
            End If
        Next

        For Each ctrl As Control In flowPanelHighRated.Controls
            If TypeOf ctrl Is MealCardStar Then
                ctrl.Width = cardWidthRated
            End If
        Next

        For Each ctrl As Control In flowPanelResults.Controls
            If TypeOf ctrl Is MealCardFav Then ' Ensure correct type check
                ctrl.Width = cardWidthResults
            End If
        Next

        Dim cardHeight As Integer = 290

        ' Calculate the number of rows for each panel
        Dim resultRows As Integer = Math.Ceiling(flowPanelPopular.Controls.Count / maxColumns)
        Dim resultRowsRated As Integer = Math.Ceiling(flowPanelHighRated.Controls.Count / maxColumns)
        Dim resultRowsResult As Integer = Math.Ceiling(flowPanelResults.Controls.Count / maxColumns)

        ' Adjust heights for each panel
        flowPanelPopular.Height = If(resultRows > 0, (resultRows * cardHeight) + (resultRows - 1) * 10, 0)
        flowPanelHighRated.Height = If(resultRowsRated > 0, (resultRowsRated * cardHeight) + (resultRowsRated - 1) * 10, 0)
        flowPanelResults.Height = If(resultRowsResult > 0, (resultRowsResult * cardHeight) + (resultRowsResult - 1) * 10, 0)
    End Sub

    Private Sub LoadMealsData()
        Try
            conn.Open()

            Dim query As String = "SELECT m.idMeal, m.strMeal, m.strMealThumb, m.strArea, " &
                                  "IFNULL(favorite_count, 0) AS favorite_count, c.category_name " &
                                  "FROM meals m " &
                                  "LEFT JOIN ( " &
                                  "    SELECT f.idMeal, COUNT(*) AS favorite_count " &
                                  "    FROM favorites f " &
                                  "    GROUP BY f.idMeal " &
                                  ") AS f ON m.idMeal = f.idMeal " &
                                  "JOIN categories c ON m.category_id = c.id " &
                                  "ORDER BY favorite_count DESC " &
                                  "LIMIT 5"

            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            flowPanelPopular.Controls.Clear()

            While reader.Read()
                Dim mealCard As New MealCard()
                Dim mealID As String = reader("idMeal").ToString()
                Dim mealName As String = reader("strMeal").ToString()
                Dim mealImage As String = reader("strMealThumb").ToString()
                Dim mealCategory As String = reader("category_name").ToString()
                Dim favoriteCount As Integer = Convert.ToInt32(reader("favorite_count"))

                mealCard.SetMealData(mealID, mealName, mealImage, mealCategory, favoriteCount)
                flowPanelPopular.Controls.Add(mealCard)
            End While

            AdjustPanelSizes() ' Call to adjust sizes after loading data

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadRatedMeal()
        Try
            conn.Open()
            Dim query As String = "SELECT m.idMeal, m.strMeal, m.strMealThumb, AVG(r.rating) AS averageRating, COUNT(r.rating) AS ratingCount, c.category_name " &
                                  "FROM meals m " &
                                  "JOIN ratings r ON m.idMeal = r.meal_id " &
                                  "LEFT JOIN categories c ON m.category_id = c.id " &
                                  "GROUP BY m.idMeal " &
                                  "HAVING ratingCount >= 5 " &
                                  "ORDER BY averageRating DESC, ratingCount DESC " &
                                  "LIMIT 5"

            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            flowPanelHighRated.Controls.Clear()  ' Clear old controls

            While reader.Read()
                Dim mealCard As New MealCardStar()
                Dim mealID As Integer = reader("idMeal")
                Dim mealName As String = reader("strMeal").ToString()
                Dim mealImage As String = reader("strMealThumb").ToString()
                Dim averageRating As Single = Convert.ToSingle(reader("averageRating"))
                Dim ratingCount As Integer = Convert.ToInt32(reader("ratingCount"))
                Dim mealCategory As String = reader("category_name").ToString()

                mealCard.SetMealData(mealID, mealName, mealImage, averageRating, ratingCount)
                flowPanelHighRated.Controls.Add(mealCard)
            End While

            AdjustPanelSizes() ' Call to adjust sizes after loading rated meals

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadSearchResults(searchText As String)
        Try
            conn.Open()

            ' Define the SQL query
            Dim query As String = "SELECT m.idMeal, " &
                   "m.strMeal, " &
                   "m.strMealThumb, " &
                   "COALESCE(AVG(r.rating), 0) AS averageRating, " &
                   "COALESCE(COUNT(r.rating), 0) AS ratingCount, " &
                   "c.category_name, " &
                   "CASE WHEN f.idMeal IS NOT NULL THEN 1 ELSE 0 END AS isFavorite " &
                   "FROM meals m " &
                   "LEFT JOIN ratings r ON m.idMeal = r.meal_id " &
                   "LEFT JOIN categories c ON m.category_id = c.id " &
                   "LEFT JOIN favorites f ON m.idMeal = f.idMeal AND f.user_id = @currentUserID " &
                   "WHERE LOWER(m.strMeal) LIKE LOWER(@searchText) " &
                   "GROUP BY m.idMeal, m.strMeal, m.strMealThumb, c.category_name " &
                   "ORDER BY averageRating DESC, ratingCount DESC"

            ' Create the command
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters
            cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            cmd.Parameters.AddWithValue("@currentUserID", currentUserID) ' Assuming currentUser  ID is accessible

            ' Execute the command and read the results
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                ' Clear previous results
                flowPanelResults.Controls.Clear()
                flowPanelResults.Visible = True

                ' Read the results
                Dim resultCount As Integer = 0 ' To count results
                While reader.Read()
                    Dim MealCard As New MealCardFav
                    Dim mealID As Integer = reader("idMeal")
                    Dim mealName As String = reader("strMeal").ToString()
                    Dim mealImage As String = reader("strMealThumb").ToString()
                    Dim averageRating As Single = If(IsDBNull(reader("averageRating")), 0.0F, Convert.ToSingle(reader("averageRating")))
                    Dim ratingCount As Integer = If(IsDBNull(reader("ratingCount")), 0, Convert.ToInt32(reader("ratingCount")))
                    Dim isFavorite As Boolean = Convert.ToBoolean(reader("isFavorite"))

                    ' Set meal data to the MealCard
                    MealCard.SetMealData(mealID, mealName, mealImage, averageRating, isFavorite)

                    ' Add the MealCard to the FlowLayoutPanel
                    flowPanelResults.Controls.Add(MealCard)
                    resultCount += 1 ' Increment result count
                End While

                ' Debugging output
                If resultCount = 0 Then
                    MessageBox.Show("No results found for: " & searchText)
                End If

                ' Adjust panel sizes after loading results
                AdjustPanelSizes()

                ' Manage visibility of FlowLayoutPanels
                lblPopular.Visible = False
                flowPanelPopular.Visible = False
                lblHighRated.Visible = False
                flowPanelHighRated.Visible = False
                lblResults.Visible = True
                lblResults.Text = "Search results for: " & searchText

            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally ' Ensure the connection is closed
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, btnSearch.Click
        LoadSearchResults(txtSearch.Text)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadSearchResults(txtSearch.Text)
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Focused Then
            btnRemove.Visible = True
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        txtSearch.Clear()
        flowPanelPopular.Visible = True
        lblPopular.Visible = True
        flowPanelHighRated.Visible = True
        lblHighRated.Visible = True
        lblResults.Visible = False
        flowPanelResults.Visible = False
        btnRemove.Visible = False
    End Sub

    Private Sub lblHighRated_Click(sender As Object, e As EventArgs) Handles lblHighRated.Click
    End Sub
End Class