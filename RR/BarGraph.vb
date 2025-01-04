Imports Guna.Charts.Interfaces
Imports Guna.Charts.WinForms
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class BarGraph
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)

    Private Sub BarGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFilter.Items.Add("All")
        cbFilter.Items.Add("1st Quarter")
        cbFilter.Items.Add("2nd Quarter")
        cbFilter.Items.Add("3rd Quarter")
        cbFilter.Items.Add("4th Quarter")

        LoadAvailableYears()
        cbFilter.SelectedIndex = 0
        cbYear.SelectedIndex = 0
        UpdateChart()
    End Sub

    Private Sub LoadAvailableYears()
        Dim query As String = "SELECT DISTINCT YEAR(created_at) AS Year FROM users ORDER BY Year DESC"
        Using conn As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, conn)
            Try
                conn.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    cbYear.Items.Add(reader("Year").ToString())
                End While
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter.SelectedIndexChanged
        UpdateChart()
    End Sub

    Private Sub cbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYear.SelectedIndexChanged
        UpdateChart()
    End Sub

    Private Sub UpdateChart()
        Dim selectedFilter As String = cbFilter.SelectedItem.ToString()
        Dim selectedYear As String = If(cbYear.SelectedItem IsNot Nothing, cbYear.SelectedItem.ToString(), "")

        Dim query As String = "SELECT MONTH(created_at) AS Month, COUNT(*) AS AccountsCreated " &
                              "FROM users"

        Dim whereClauses As New List(Of String)()

        If Not String.IsNullOrEmpty(selectedYear) Then
            whereClauses.Add($"YEAR(created_at) = {selectedYear}")
        End If

        If selectedFilter <> "All" Then
            Select Case selectedFilter
                Case "1st Quarter"
                    whereClauses.Add("MONTH(created_at) IN (1, 2, 3)")
                Case "2nd Quarter"
                    whereClauses.Add("MONTH(created_at) IN (4, 5, 6)")
                Case "3rd Quarter"
                    whereClauses.Add("MONTH(created_at) IN (7, 8, 9)")
                Case "4th Quarter"
                    whereClauses.Add("MONTH(created_at) IN (10, 11, 12)")
            End Select
        End If

        If whereClauses.Count > 0 Then
            query += " WHERE " & String.Join(" AND ", whereClauses)
        End If

        query += " GROUP BY MONTH(created_at) ORDER BY Month"

        Example(GunaChart1, query, selectedFilter)
    End Sub

    Public Shared Sub Example(ByVal chart As GunaChart, ByVal query As String, ByVal selectedFilter As String)
        chart.YAxes.GridLines.Display = False
        Dim dataset As New GunaBarDataset()
        Dim dataTable As New DataTable()

        Using conn As New MySqlConnection("Server=localhost; Database=recipe_books; Uid=root; Pwd=;")
            Dim command As New MySqlCommand(query, conn)

            Try
                conn.Open()
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)

                Dim monthData As New Dictionary(Of Integer, Integer) From {
                    {1, 0}, {2, 0}, {3, 0}, {4, 0}, {5, 0}, {6, 0},
                    {7, 0}, {8, 0}, {9, 0}, {10, 0}, {11, 0}, {12, 0}
 }

                For Each row As DataRow In dataTable.Rows
                    Dim month As Integer = Convert.ToInt32(row("Month"))
                    Dim accountsCreated As Integer = Convert.ToInt32(row("AccountsCreated"))
                    monthData(month) = accountsCreated
                Next

                ' Add month data to the dataset based on the selected filter
                If selectedFilter = "All" Then
                    For month As Integer = 1 To 12
                        Dim monthName As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)
                        dataset.DataPoints.Add(monthName, monthData(month))
                    Next
                Else
                    Dim monthsInQuarter As List(Of Integer) = GetMonthsInQuarter(selectedFilter)
                    For Each month As Integer In monthsInQuarter
                        Dim monthName As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)
                        dataset.DataPoints.Add(monthName, monthData(month))
                    Next
                End If

                chart.Datasets.Clear()
                chart.Datasets.Add(dataset)
                chart.Update()

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Shared Function GetMonthsInQuarter(selectedFilter As String) As List(Of Integer)
        Select Case selectedFilter
            Case "1st Quarter"
                Return New List(Of Integer) From {1, 2, 3}
            Case "2nd Quarter"
                Return New List(Of Integer) From {4, 5, 6}
            Case "3rd Quarter"
                Return New List(Of Integer) From {7, 8, 9}
            Case "4th Quarter"
                Return New List(Of Integer) From {10, 11, 12}
            Case Else
                Return New List(Of Integer)()
        End Select
    End Function

    Private Sub GunaChart1_Load(sender As Object, e As EventArgs) Handles GunaChart1.Load
    End Sub
End Class