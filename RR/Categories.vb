Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Categories
    Dim connStr As String = "server=localhost; uid=root; pwd=; database=recipe_books;"
    Dim conn As New MySqlConnection(connStr)
    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCategories()
    End Sub

    Private Sub GetCategories()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM categories"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim categoryId As Integer = reader.GetInt32("id")
                        Dim categoryName As String = reader.GetString("category_name")

                        Dim button As New Guna2Button
                        button.Text = categoryName
                        FlowLayoutPanel1.Controls.Add(button)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving categories: " & ex.Message)
        Finally
            conn.Close() ' This is optional here because of the Using statement
        End Try
    End Sub
End Class
