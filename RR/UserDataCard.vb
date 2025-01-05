Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class UserDataCard
    Dim userID As Integer
    Dim connStr As String = "server=localhost;user id=root;password=;database=recipe_books"
    Dim conn As New MySqlConnection(connStr)
    Public Event UserDeleted As EventHandler
    Public Sub SetUserData(id As Integer, username As String, email As String, password As String, Optional imageData As Byte() = Nothing)
        Me.userID = id
        txtUsername.Text = username
        txtEmail.Text = email
        txtPassword.Text = password

        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            Using ms As New MemoryStream(imageData)
                profImage.Image = Image.FromStream(ms)
            End Using
        Else
            profImage.Image = My.Resources.img ' Default image
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtEmail.ReadOnly = False
        txtPassword.ReadOnly = False
        txtUsername.ReadOnly = False

        txtEmail.Enabled = True
        txtPassword.Enabled = True
        txtUsername.Enabled = True

        txtEmail.FillColor = Color.White
        txtPassword.FillColor = Color.White
        txtUsername.FillColor = Color.White


        txtEmail.BorderThickness = 1
        txtPassword.BorderThickness = 1
        txtUsername.BorderThickness = 1

        btnEdit.Visible = False
        btnSave.Visible = True
    End Sub

    Private Sub SaveEdit()
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        If password.Length < 8 Then
            MessageBox.Show("The password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the username or email already exists
        If IsUsernameOrEmailTaken(username, email) Then
            MessageBox.Show("The username or email is already in use. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "UPDATE users SET username = @username, email = @email, password = @password WHERE user_id = @userID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@userID", userID)
            cmd.ExecuteNonQuery()

            MessageBox.Show("User  details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmail.ReadOnly = True
            txtPassword.ReadOnly = True
            txtUsername.ReadOnly = True

            txtEmail.Enabled = False
            txtPassword.Enabled = False
            txtUsername.Enabled = False

            txtEmail.DisabledState.FillColor = Color.Transparent
            txtPassword.DisabledState.FillColor = Color.Transparent
            txtUsername.DisabledState.FillColor = Color.Transparent

            btnSave.Visible = False
            btnEdit.Visible = True
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveEdit()
    End Sub

    Private Function IsUsernameOrEmailTaken(username As String, email As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE (username = @username OR email = @email) AND user_id <> @userID"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@userID", userID) ' Assuming userID is the ID of the user being edited

        Try
            conn.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0 ' Return true if the count is greater than 0, meaning the username or email is taken
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking for existing username/email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo)

        If confirmResult = DialogResult.Yes Then
            If DeleteUser() Then
                RaiseEvent UserDeleted(Me, EventArgs.Empty)
                MessageBox.Show("User  with ID: " & userID & " deleted.")
            End If
        End If
    End Sub


    Private Function DeleteUser() As Boolean
        Try
            conn.Open()
            Dim query As String = "DELETE FROM users WHERE user_id = @userID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userID", userID)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try

    End Function

    Private Sub UserDataCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class