Imports MySql.Data.MySqlClient

Public Class Overview

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchTotalUsers()
    End Sub

    Private Sub FetchTotalUsers()
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM users"
            Dim cmd As New MySqlCommand(query, conn)
            Dim totalUsers As Integer = cmd.ExecuteScalar()
            lblTotalUsers.Text = totalUsers.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
