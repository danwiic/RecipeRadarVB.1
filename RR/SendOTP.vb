Imports MySql.Data.MySqlClient
Imports System.Net.Http
Imports System.Text

Public Class SendOTP
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim countdown As Integer = 60
    Public Shared currentEmail As String

    Public Function EmailExists(email As String) As Boolean
        Dim exists As Boolean = False
        Try
            Using connection As New MySqlConnection(connStr)
                connection.Open()
                Dim command As New MySqlCommand("SELECT COUNT(*) FROM users WHERE email = @email", connection)
                command.Parameters.AddWithValue("@email", email)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                exists = count > 0
            End Using
        Catch ex As MySqlException
            MessageBox.Show($"MySQL Error: {ex.Message}")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
        Return exists
    End Function

    Public Function GenerateOTP() As String
        Dim random As New Random()
        Return random.Next(100000, 999999).ToString()
    End Function

    Public Async Function SendOtpEmail(recipientEmail As String, otp As String) As Task
        Dim apiKey As String = "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"
        Dim apiUrl As String = "https://api.brevo.com/v3/smtp/email"

        Dim jsonPayload As String = $"{{""sender"":{{""name"":""reciperadar@noreply.com"", ""email"":""danpirante9@gmail.com""}}, ""to"":[{{""email"":""{recipientEmail}""}}], ""subject"":""Your OTP Code"", ""htmlContent"":""<html><body><p>Your OTP code is: {otp}</p><br/><p>Your OTP will only be valid for 5 minutes.</p></body></html>""}}"

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("api-key", apiKey)
            Dim content As New StringContent(jsonPayload, Encoding.UTF8, "application/json")

            Try
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("OTP email sent successfully.")
                    btnSend.Enabled = False
                    countdown = 60
                    btnSend.Text = countdown.ToString() & " seconds"
                    countdownTimer.Start()
                    StoreOtpInDatabase(recipientEmail, otp)
                    currentEmail = recipientEmail
                    Dim verifyOTP As New VerifyOTP
                    RecoverAccount.displayPanel.Controls.Add(verifyOTP)
                    verifyOTP.lblResend.Text = "Resend in " & countdown.ToString() & " seconds"
                    verifyOTP.lblResend.Enabled = False
                    verifyOTP.BringToFront()
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

        Dim verifyOTP As New VerifyOTP
        countdown -= 1
        btnSend.Text = countdown.ToString() & " seconds"
        VerifyOTP.lblResend.Text = "Resend in " & countdown.ToString() & " seconds"
        If countdown <= 0 Then
            countdownTimer.Stop()
            btnSend.Enabled = True
            btnSend.Text = "SEND CODE"
            VerifyOTP.lblResend.Text = "Resend"
            VerifyOTP.lblResend.Enabled = True
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

    Private Async Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim email = txtEmail.Text.Trim

        If EmailExists(email) Then
            Dim otp = GenerateOTP()
            Await SendOtpEmail(email, otp)
        Else
            MessageBox.Show("Email does not exist in our records.")
        End If
    End Sub

    Private Sub sendCodePanel_Paint(sender As Object, e As PaintEventArgs) Handles sendCodePanel.Paint

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        RecoverAccount.displayPanel.Controls.Clear()
        RecoverAccount.Hide()
        LoginForm.Show()
    End Sub
End Class
