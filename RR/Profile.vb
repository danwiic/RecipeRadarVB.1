Imports System.IO
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Profile

    Dim userID As String = LoginForm.currentUserID
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
        txtUsername.BorderThickness = 1
        txtUsername.ReadOnly = False
        btnSave.Visible = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newUsername As String = txtUsername.Text.Trim()
        lblError.Text = String.Empty

        If String.IsNullOrEmpty(newUsername) OrElse newUsername.Length < 5 Then
            lblError.Text = "Username must be at least 5 characters long."
            Return
        End If

        If UsernameExists(newUsername) Then
            lblError.Text = "Username already exists. Please choose a different username."
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "UPDATE users SET username = @newUsername WHERE user_id = @userID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@newUsername", newUsername)
                cmd.Parameters.AddWithValue("@userID", userID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    txtUsername.ReadOnly = True
                    txtUsername.BorderThickness = 0
                    btnSave.Visible = False
                    btnEdit.Visible = True
                Else
                    lblError.Text = "No user found with the specified ID."
                End If
            End Using
        Catch ex As MySqlException
            lblError.Text = $"MySQL Error: {ex.Message}"
        Catch ex As Exception
            lblError.Text = $"Error: {ex.Message}"
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function UsernameExists(username As String) As Boolean
        Dim exists As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND user_id <> @userID"

        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@userID", userID)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                exists = (count > 0)
            End Using
        End Using

        Return exists
    End Function

    Private Sub Guna2ContainerControl1_Click(sender As Object, e As EventArgs) Handles Guna2ContainerControl1.Click

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*" ' Filter for image files

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            pbUserImage.Image = Image.FromFile(filePath)

            SaveImageToDatabase(filePath)
        End If
    End Sub

    Private Sub SaveImageToDatabase(filePath As String)
        Try
            Dim imageData As Byte() = System.IO.File.ReadAllBytes(filePath) ' Read the image file into a byte array

            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "UPDATE users SET profile_image = @profileImage WHERE user_id = @userID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@profileImage", imageData)
                    cmd.Parameters.AddWithValue("@userID", userID) ' Assuming userID is defined

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery() ' Execute the update command

                    If rowsAffected > 0 Then
                        MessageBox.Show("Profile picture uploaded successfully.")
                    Else
                        MessageBox.Show("No user found with the specified ID.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving profile picture: " & ex.Message)
        End Try
    End Sub
End Class