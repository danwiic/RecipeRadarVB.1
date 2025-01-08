Imports System.IO
Imports MySql.Data.MySqlClient

Public Class UserCommentCard
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Dim commentID As Integer
    Dim userRole = LoginForm.currentUserRole

    Public Sub setComment(commentID As Integer, userName As String, comment As String, createdAt As DateTime, Optional imageData As Byte() = Nothing)
        Me.commentID = commentID
        lblUser.Text = userName
        txtComment.Text = comment
        lblDate.Text = createdAt.ToString("g")

        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            Using ms As New MemoryStream(imageData)
                picUser.Image = Image.FromStream(ms)
            End Using
        Else
            picUser.Image = My.Resources.img
        End If
    End Sub

    Public Event CommentDeleted As EventHandler

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "DELETE FROM comments WHERE comment_id = @commentID"

                Using deleteComment As New MySqlCommand(query, conn)
                    deleteComment.Parameters.AddWithValue("@commentID", commentID)
                    deleteComment.ExecuteNonQuery()
                End Using
            End Using

            RaiseEvent CommentDeleted(Me, EventArgs.Empty)

        Catch ex As Exception
            MessageBox.Show("Error deleting comment: " & ex.Message)
        End Try
    End Sub

    Private Sub CheckUserRole()
        btnDelete.Visible = False

        If LoginForm.currentUserRole = "admin" Then
            btnDelete.Visible = True
            btnReport.Visible = False
        Else
            btnReport.Visible = True
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ' Call the SubmitReport method when the report button is clicked
        SubmitReport()
    End Sub

    Private Sub SubmitReport()
        Try
            conn.Open()
            Dim query As String = "SELECT comment_text FROM comments WHERE comment_id = @commentID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@commentID", commentID)
                Dim commentText As String = cmd.ExecuteScalar().ToString()

                ' Insert the report into the reported_users table
                Dim reportQuery As String = "INSERT INTO reported_users (reported_user_id, reason, comment, created_at) VALUES (@reportedUser Id, @reason, @commentText, NOW())"
                Using reportCmd As New MySqlCommand(reportQuery, conn)
                    reportCmd.Parameters.AddWithValue("@reportedUser Id", LoginForm.currentUserID) ' Assuming this is the user being reported
                    reportCmd.Parameters.AddWithValue("@reason", "Inappropriate Comment") ' You can modify this to get the reason from the user
                    reportCmd.Parameters.AddWithValue("@commentText", commentText)
                    reportCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Report submitted successfully.")

        Catch ex As Exception
            MessageBox.Show("Error submitting report: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub UserCommentCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckUserRole()
    End Sub

    Private Sub txtComment_TextChanged(sender As Object, e As EventArgs) Handles txtComment.TextChanged

    End Sub

    Private Sub picUser_Click(sender As Object, e As EventArgs) Handles picUser.Click

    End Sub
End Class