Imports MySql.Data.MySqlClient

Public Class ManageUser
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Public Event UserDeleted As EventHandler

    Private currentPage As Integer = 1
    Private usersPerPage As Integer = 10
    Private totalUsers As Integer = 0
    Private totalPages As Integer = 0

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

            ' Get total number of users
            Dim countQuery As String = "SELECT COUNT(*) FROM users WHERE role = 'user'"
            Dim countCmd As New MySqlCommand(countQuery, conn)
            totalUsers = Convert.ToInt32(countCmd.ExecuteScalar())
            totalPages = Math.Ceiling(totalUsers / usersPerPage)

            ' Update the label to show current page
            lblPages.Text = $"Page {currentPage} of {totalPages}"

            ' Calculate the offset
            Dim offset As Integer = (currentPage - 1) * usersPerPage

            ' Fetch users for the current page
            Dim query As String = $"SELECT * FROM users WHERE role = 'user' LIMIT {usersPerPage} OFFSET {offset}"
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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < totalPages Then
            currentPage += 1
            RefreshUsers()
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentPage > 1 Then
            currentPage -= 1
            RefreshUsers()
        End If
    End Sub
End Class