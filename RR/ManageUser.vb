Imports MySql.Data.MySqlClient

Public Class ManageUser
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Public Event UserDeleted As EventHandler

    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUsers() ' Load users when the form loads
    End Sub

    Private Sub RefreshUsers()
        FlowLayoutPanel1.Controls.Clear()
        FetchUsers()
    End Sub

    Private Sub FetchUsers()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM users WHERE role = 'user'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing user cards if any
            FlowLayoutPanel1.Controls.Clear()

            While reader.Read()
                Dim id As Integer = reader("user_id")
                Dim username As String = reader("username")
                Dim email As String = reader("email")
                Dim password As String = reader("password")
                Dim imageData As Byte() = If(reader("profile_image") IsNot DBNull.Value, CType(reader("profile_image"), Byte()), Nothing)

                Dim userData As New UserDataCard
                userData.SetUserData(id, username, email, password, imageData)
                AddHandler userData.UserDeleted, AddressOf RefreshUsers
                ' Add the UserDataCard to the FlowLayoutPanel
                FlowLayoutPanel1.Controls.Add(userData)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class