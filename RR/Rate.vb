Imports MySql.Data.MySqlClient

Public Class Rate
    Private connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Private mealID As Integer
    Private userID As Integer = LoginForm.currentUserID
    Public Event RefreshRating()

    Public Sub New(mealID As Integer)
        InitializeComponent()
        Me.mealID = mealID
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub

    Private Sub Rate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shadowForm.SetShadowForm(Me)
    End Sub

    Private Sub btnSubmitRate_Click(sender As Object, e As EventArgs) Handles btnSubmitRate.Click

        Dim ratingValue As Integer = ratingStar.Value

        If ratingValue = 0 Then
            MessageBox.Show("Please select a rating before submitting.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Check if the rating already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM ratings WHERE meal_id = @mealID AND user_id = @userID"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@mealID", mealID)
                    checkCmd.Parameters.AddWithValue("@userID", userID)

                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists > 0 Then
                        ' Update the existing rating
                        Dim updateQuery As String = "UPDATE ratings SET rating = @rating, created_at = NOW() WHERE meal_id = @mealID AND user_id = @userID"
                        Using updateCmd As New MySqlCommand(updateQuery, conn)
                            updateCmd.Parameters.AddWithValue("@mealID", mealID)
                            updateCmd.Parameters.AddWithValue("@userID", userID)
                            updateCmd.Parameters.AddWithValue("@rating", ratingValue)

                            updateCmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Your rating has been updated!")
                    Else
                        ' Insert a new rating
                        Dim insertQuery As String = "INSERT INTO ratings (meal_id, user_id, rating, created_at) VALUES (@mealID, @userID, @rating, NOW())"
                        Using insertCmd As New MySqlCommand(insertQuery, conn)
                            insertCmd.Parameters.AddWithValue("@mealID", mealID)
                            insertCmd.Parameters.AddWithValue("@userID", userID)
                            insertCmd.Parameters.AddWithValue("@rating", ratingValue)

                            insertCmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Thank you for your rating!")
                    End If
                End Using
            End Using

            ' Optionally raise the RefreshRating event here if needed
            RaiseEvent RefreshRating()

        Catch ex As Exception
            MessageBox.Show("Error submitting rating: " & ex.Message)
        End Try
    End Sub


End Class