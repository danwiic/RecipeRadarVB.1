Imports mysql.data.MySqlClient
Public Class LoginForm

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)

    Public Shared currentUserRole As String
    Public Shared currentUserID As Integer
    Public Shared currentUsername As String
    Public Shared currentUserEmail As String
    Private isDragging As Boolean
    Private startPoint As Point
    Private Sub Login()
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.")
            Exit Sub
        End If

        Try
            conn.Open()

            ' Query to fetch the user details including role
            Dim query As String = "SELECT user_id, username, password, email, role FROM users WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                currentUserID = reader.GetInt32("user_id")
                currentUsername = reader.GetString("username")
                currentUserEmail = reader.GetString("email")
                currentUserRole = reader.GetString("role")

                Me.Hide()
                Dim mainform As New MainForm
                mainform.Show()
            Else
                MessageBox.Show("Invalid username or password.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            txtUsername.Text = ""
            txtPassword.Text = ""
        End Try
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If Keys.Enter = e.KeyCode Then
            Login()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Guna2CustomCheckBox1_Click(sender As Object, e As EventArgs) Handles chkSeePass.Click
        If chkSeePass.Checked Then
            chkSeePass.BackgroundImage = My.Resources.eye
            txtPassword.PasswordChar = "" ' Show password
        Else
            txtPassword.PasswordChar = "*" ' Hide password
            chkSeePass.BackgroundImage = My.Resources.hidden
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Focused Then
            chkSeePass.Show()
            chkSeePass.BackgroundImage = My.Resources.hidden
        Else
            chkSeePass.Hide()
        End If
    End Sub

    Private Sub btnGoToSignup_Click(sender As Object, e As EventArgs) Handles btnGoToSignup.Click
        Me.Hide()
        Dim signupForm As New SignupForm
        signupForm.Show()
    End Sub

    Private Sub SignupForm_MouseDown(sender As Object, e As MouseEventArgs) Handles loginPanel.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub SignupForm_MouseMove(sender As Object, e As MouseEventArgs) Handles loginPanel.MouseMove
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub SignupForm_MouseUp(sender As Object, e As MouseEventArgs) Handles loginPanel.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub
End Class