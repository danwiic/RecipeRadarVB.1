Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class SignupForm

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim isDragging As Boolean
    Private startPoint As Point

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Focused Then
            chkSeePass.Show()
            chkSeePass.BackgroundImage = My.Resources.hidden
        Else
            chkSeePass.Hide()
        End If
    End Sub

    Private Sub txtConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtConfirm.TextChanged
        If txtConfirm.Focused Then
            chkConfirm.Show()
            chkConfirm.BackgroundImage = My.Resources.hidden
        Else
            chkConfirm.Hide()
        End If
    End Sub

    Private Sub chkSeePass_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeePass.CheckedChanged
        If chkSeePass.Checked Then
            chkSeePass.BackgroundImage = My.Resources.eye
            txtPassword.PasswordChar = ""
        Else
            chkSeePass.BackgroundImage = My.Resources.hidden
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub chkConfirm_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfirm.CheckedChanged
        If chkConfirm.Checked Then
            chkConfirm.BackgroundImage = My.Resources.eye
            txtConfirm.PasswordChar = ""
        Else
            chkConfirm.BackgroundImage = My.Resources.hidden
            txtConfirm.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnGoToLogin_Click(sender As Object, e As EventArgs) Handles btnGoToLogin.Click
        Me.Hide()
        Dim login As New LoginForm
        login.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub createAccount()
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirm.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Or String.IsNullOrEmpty(confirmPassword) Then
            MessageBox.Show("Please fill in all fields.", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Check if the password is at least 8 characters long
        If password.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.", "Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            conn.Open()

            Dim checkEmailQuery As String = "SELECT COUNT(*) FROM users WHERE email = @Email"
            Dim cmdEmail As New MySqlCommand(checkEmailQuery, conn)
            cmdEmail.Parameters.AddWithValue("@Email", email)
            Dim emailCount As Integer = Convert.ToInt32(cmdEmail.ExecuteScalar())

            If emailCount > 0 Then
                MessageBox.Show("The email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim checkUsernameQuery As String = "SELECT COUNT(*) FROM users WHERE username = @Username"
            Dim cmdUsername As New MySqlCommand(checkUsernameQuery, conn)
            cmdUsername.Parameters.AddWithValue("@Username", username)
            Dim usernameCount As Integer = Convert.ToInt32(cmdUsername.ExecuteScalar())

            If usernameCount > 0 Then
                MessageBox.Show("The username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim createQuery As String = "INSERT INTO users (username, email, password) VALUES (@Username, @Email, @Password)"
            Dim cmdCreate As New MySqlCommand(createQuery, conn)
            cmdCreate.Parameters.AddWithValue("@Username", username)
            cmdCreate.Parameters.AddWithValue("@Email", email)
            cmdCreate.Parameters.AddWithValue("@Password", password)

            cmdCreate.ExecuteNonQuery()

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Text = ""
            txtEmail.Text = ""
            txtPassword.Text = ""
            txtConfirm.Text = ""
            Me.Hide()

            Dim loginForm As New LoginForm
            loginForm.Show()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(emailPattern)
        Return regex.IsMatch(email)
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        createAccount()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If Keys.Enter = e.KeyCode Then
            createAccount()
        End If
    End Sub

    Private Sub txtConfirm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtConfirm.KeyDown
        If Keys.Enter = e.KeyCode Then
            createAccount()
        End If
    End Sub

    Private Sub SignupForm_MouseDown(sender As Object, e As MouseEventArgs) Handles signupPanel.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub SignupForm_MouseMove(sender As Object, e As MouseEventArgs) Handles signupPanel.MouseMove
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub SignupForm_MouseUp(sender As Object, e As MouseEventArgs) Handles signupPanel.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub signupPanel_Paint(sender As Object, e As PaintEventArgs) Handles signupPanel.Paint

    End Sub
End Class