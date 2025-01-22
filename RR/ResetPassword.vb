Imports Guna.UI2.WinForms.Suite
Imports MySql.Data.MySqlClient

Public Class ResetPassword

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim currentEmail As String = SendOTP.currentEmail

    Private Sub ChangePassword()
        Dim newPassword As String = txtNewPass.Text.Trim()
        Dim confirmPassword As String = txtConfirmPass.Text.Trim()

        If newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please try again.")
            Return
        End If

        If newPassword.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.")
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "UPDATE users SET password = @newPassword WHERE email = @email"
            Using updatePass As New MySqlCommand(query, conn)
                updatePass.Parameters.AddWithValue("@newPassword", newPassword)
                updatePass.Parameters.AddWithValue("@email", currentEmail)
                updatePass.ExecuteNonQuery()
            End Using
            MessageBox.Show("Password updated successfully")
            Me.Hide()

            LoginForm.Show()

        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ChangePassword()
    End Sub

    Private Sub verifyCodePanel_Paint(sender As Object, e As PaintEventArgs) Handles verifyCodePanel.Paint

    End Sub

    Private Sub ResetPassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        ShadowForm.setShadowForm(Me)
    End Sub

    Private Sub chkSeePass_Click(sender As Object, e As EventArgs) Handles chkSeePass.Click
        If chkSeePass.Checked Then
            chkSeePass.BackgroundImage = My.Resources.eye
            txtNewPass.PasswordChar = ""
        Else
            txtNewPass.PasswordChar = "*"
            chkSeePass.BackgroundImage = My.Resources.hidden
        End If
    End Sub

    Private Sub chkConfirmPass_Click(sender As Object, e As EventArgs) Handles chkConfirmPass.Click
        If chkSeePass.Checked Then
            chkSeePass.BackgroundImage = My.Resources.eye
            txtConfirmPass.PasswordChar = ""
        Else
            txtConfirmPass.PasswordChar = "*"
            chkSeePass.BackgroundImage = My.Resources.hidden
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        If txtNewPass.Focused Then
            chkSeePass.Show()
            chkSeePass.BackgroundImage = My.Resources.hidden
        Else
            chkSeePass.Hide()
        End If
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        If txtConfirmPass.Focused Then
            chkConfirmPass.Show()
            chkConfirmPass.BackgroundImage = My.Resources.hidden
        Else
            chkConfirmPass.Hide()
        End If
    End Sub
End Class
