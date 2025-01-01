Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Profile

    Dim userID As String = 16
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)

    Private Sub FetchUserInfo()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM users WHERE user_id = @userID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtUsername.Text = reader("username").ToString()
                        txtEmail.Text = reader("email").ToString()

                        ' Retrieve the image data
                        Dim imageData As Byte() = If(reader("profile_image") IsNot DBNull.Value, CType(reader("profile_image"), Byte()), Nothing)

                        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                            Using ms As New MemoryStream(imageData)
                                pbUserImage.Image = Image.FromStream(ms)
                            End Using
                        Else
                            pbUserImage.Image = My.Resources.img
                        End If
                    Else
                        MessageBox.Show("No user found with the specified ID.")
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show($"MySQL Error: {ex.Message}")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUserInfo()
    End Sub

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Visible = False
        txtUsername.ReadOnly = False
        btnSave.Visible = True

    End Sub
End Class