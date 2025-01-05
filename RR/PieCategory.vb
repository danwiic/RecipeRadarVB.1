Imports Guna.Charts.Interfaces
Imports Guna.Charts.WinForms
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class PieCategory
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"

    Private Sub GunaChart_Load(sender As Object, e As EventArgs) Handles GunaChart.Load
        LoadPieChartData()
    End Sub

    Private Sub LoadPieChartData()
        Dim query As String = "SELECT c.category_name, COUNT(m.idMeal) AS MealCount " &
                              "FROM categories c " &
                              "LEFT JOIN meals m ON c.id = m.category_id " &
                              "GROUP BY c.category_name"

        Dim dataTable As New DataTable()

        Using conn As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, conn)

            Try
                conn.Open()
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)

                Dim dataset As New GunaPieDataset()
                dataset.Label = "Total Meals"

                ' Populate the dataset with the data from the DataTable
                For Each row As DataRow In dataTable.Rows
                    Dim categoryName As String = row("category_name").ToString()
                    Dim mealCount As Integer = Convert.ToInt32(row("MealCount"))
                    dataset.DataPoints.Add(categoryName, mealCount)
                Next

                ' Hide grid lines and axes
                GunaChart.XAxes.GridLines.Display = False
                GunaChart.YAxes.GridLines.Display = False
                GunaChart.YAxes.Display = False
                GunaChart.XAxes.Display = False
                GunaChart.Legend.Position = LegendPosition.Right

                ' Clear existing datasets and add the new dataset
                GunaChart.Datasets.Clear()
                GunaChart.Datasets.Add(dataset)

                ' Hide the legend






                ' Update the chart to reflect changes
                GunaChart.Update()

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub
End Class