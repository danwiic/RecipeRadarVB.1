Imports System.Net.Http
Imports MySql.Data.MySqlClient
Imports System.Text
Imports Guna.UI2.WinForms.Suite

Public Class Verify
    Dim currentEmail As String = SendOTP.currentEmail
    Dim countdown As Integer = 60
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)

    Public Function GenerateOTP() As String
        Dim random As New Random()
        Return random.Next(100000, 999999).ToString()
    End Function

    Public Async Function SendOtpEmail(recipientEmail As String, otp As String) As Task
        Dim apiKey As String = "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"
        Dim apiUrl As String = "https://api.brevo.com/v3/smtp/email"

        Dim jsonPayload As String = $"{{""sender"":{{""name"":""reciperadar@noreply.com"", ""email"":""danpirante9@gmail.com""}}, ""to"":[{{""email"":""{recipientEmail}""}}], ""subject"":""Your OTP Code"", ""htmlContent"":""<html><body><p>Your OTP code is: {otp}</p><p>Your OTP will only be valid for 5 minutes.</p></body></html>""}}"

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("api-key", apiKey)
            Dim content As New StringContent(jsonPayload, Encoding.UTF8, "application/json")

            Try
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("OTP email sent successfully.")
                    Dim reqOTP As New SendOTP
                    reqOTP.btnSend.Enabled = False
                    countdown = 60
                    reqOTP.btnSend.Text = countdown.ToString() & " seconds"
                    lblResend.Text = "Resend in " & countdown.ToString() & " seconds"
                    lblResend.Enabled = False
                    countdownTimer.Interval = 1000
                    countdownTimer.Start()
                    StoreOtpInDatabase(recipientEmail, otp)
                Else
                    Dim errorMessage As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show($"Error sending email: {response.StatusCode} - {errorMessage}")
                End If
            Catch ex As Exception
                MessageBox.Show($"Exception: {ex.Message}")
            End Try
        End Using
    End Function

    Public Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        Dim reqOTP As New SendOTP
        countdown -= 1
        reqOTP.btnSend.Text = countdown.ToString & " seconds"
        lblResend.Text = "Resend in " & countdown.ToString & " seconds"

        If countdown <= 0 Then
            countdownTimer.Stop()
            reqOTP.btnSend.Enabled = True
            reqOTP.btnSend.Text = "SEND CODE"
            lblResend.Text = "Resend"
            lblResend.Enabled = True
        End If
    End Sub

    Public Sub StoreOtpInDatabase(email As String, otp As String)
        Dim expiresAt As DateTime = DateTime.Now.AddMinutes(5)
        Dim lastRequestedAt As DateTime = DateTime.Now
        Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"

        Using connection As New MySqlConnection(connStr)
            connection.Open()
            Dim command As New MySqlCommand("INSERT INTO otps (email, otp, expires_at, last_requested_at) VALUES (@Email, @Otp, @ExpiresAt, @LastRequestedAt) ON DUPLICATE KEY UPDATE otp = @Otp, expires_at = @ExpiresAt, last_requested_at = @LastRequestedAt", connection)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@Otp", otp)
            command.Parameters.AddWithValue("@ExpiresAt", expiresAt)
            command.Parameters.AddWithValue("@LastRequestedAt", lastRequestedAt)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Async Sub lblResend_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblResend.LinkClicked
        If countdown <= 0 Then
            Dim otp As String = GenerateOTP()
            Await SendOtpEmail(currentEmail, otp)
        End If
    End Sub

    Private Sub VerifyOTP_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblNotif.Text = "The 6-Digit code has been sent to " & SendOTP.currentEmail
        lblNotif.Visible = True
        ShadowForm.setShadowForm(Me)
    End Sub

    Private Sub verifyCodePanel_Paint(sender As Object, e As PaintEventArgs) Handles verifyCodePanel.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        verifyOTP()
    End Sub

    Private Sub verifyOTP()
        Try
            conn.Open()
            Dim otp As Integer = txtOTP.Text
            Dim query As String = "SELECT * FROM otps WHERE email = @currentEmail AND otp = @otp AND expires_at > @CurrentTime"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@currentEmail", currentEmail)
                cmd.Parameters.AddWithValue("@otp", otp)
                cmd.Parameters.AddWithValue("@CurrentTime", DateTime.Now)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    MessageBox.Show("OTP verified successfully.")
                    Dim resetPassword As New ResetPassword
                    Me.Hide()
                    resetPassword.Show()
                Else
                    MessageBox.Show("Invalid OTP code.")
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

End Class