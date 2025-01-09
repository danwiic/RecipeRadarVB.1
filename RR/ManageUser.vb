Imports MySql.Data.MySqlClient

Public Class ManageUser
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Public Event UserDeleted As EventHandler

    Private currentPage As Integer = 1
    Private usersPerPage As Integer = 10
    Private totalUsers As Integer = 0
    Private totalPages As Integer = 1
    Private searchTerm As String = String.Empty ' Variable to hold the search term

    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUsers() ' Load users when the form loads
        PageCheck()
    End Sub

    Private Sub RefreshUsers()
        FlowLayoutPanel1.Controls.Clear()
        FetchUsers()
        PageCheck()
    End Sub

    Private Sub PageCheck()
        If currentPage = 1 Then
            btnPrev.Enabled = False
        Else
            btnPrev.Enabled = True
        End If
        If currentPage = totalPages Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If

        If totalPages = 0 Then
            totalPages = 1
        End If
    End Sub

    Private Sub FetchUsers()
        Try
            conn.Open()

            ' Get total number of users based on search term
            Dim countQuery As String = "SELECT COUNT(*) FROM users WHERE role = 'user' AND (username LIKE @searchTerm OR email LIKE @searchTerm)"
            Dim countCmd As New MySqlCommand(countQuery, conn)
            countCmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
            totalUsers = Convert.ToInt32(countCmd.ExecuteScalar())
            totalPages = Math.Ceiling(totalUsers / usersPerPage)

            ' Update the label to show current page
            lblPages.Text = $"Page {currentPage} of {totalPages}"

            ' Calculate the offset
            Dim offset As Integer = (currentPage - 1) * usersPerPage

            Dim query As String = $"SELECT * FROM users WHERE role = 'user' AND (username LIKE @searchTerm OR email LIKE @searchTerm) LIMIT {usersPerPage} OFFSET {offset}"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If Not reader.HasRows Then
                lblStatus.Text = "No users found."
                lblStatus.Visible = True
            Else
                lblStatus.Visible = False
            End If
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
                PageCheck()
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

    Private Sub txtUserSearch_TextChanged(sender As Object, e As EventArgs) Handles txtUserSearch.TextChanged
        searchTerm = txtUserSearch.Text.Trim() ' Update the search term
        currentPage = 1 ' Reset to the first page
        RefreshUsers() ' Refresh the user list based on the search term
        PageCheck()
    End Sub

    Private Sub btnUserSearch_Click(sender As Object, e As EventArgs) Handles btnUserSearch.Click
        searchTerm = txtUserSearch.Text.Trim() ' Update the search term
        currentPage = 1 ' Reset to the first page
        RefreshUsers() ' Refresh the user list based on the search term
    End Sub

    Private Sub lblPages_Click(sender As Object, e As EventArgs) Handles lblPages.Click

    End Sub
End Class