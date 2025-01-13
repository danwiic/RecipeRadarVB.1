Imports MySql.Data.MySqlClient

Public Class ReportedUserCard
    Dim userID As Integer
    Dim reportid As Integer
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Public Event ReportDeleted As EventHandler

    Private Sub ReportedUserCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub getReportID(reportID As Integer)
        Me.reportid = reportID
    End Sub
    Public Sub SetReportedUser(userID As Integer, username As String, comment As String, reason As String)
        Me.userID = userID
        lblUsername.Text = username
        txtComment.Text = comment
        lblReason.Text = reason
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this report?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DeleteComment()
            RaiseEvent ReportDeleted(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub DeleteComment()
        Try
            conn.Open()
            Dim selectQuery As String = "SELECT comment_id from reported_users WHERE report_id = @reportID"
            Dim commentID As Integer
            Using selectCMD As New MySqlCommand(selectQuery, conn)
                selectCMD.Parameters.AddWithValue("@reportID", reportid)
                Using SelectReader As MySqlDataReader = selectCMD.ExecuteReader
                    While SelectReader.Read()
                        commentID = SelectReader("comment_id")
                    End While
                End Using
            End Using

            Try
                Dim deleteQuery As String = "DELETE FROM comments where comment_id = @commentID"
                Using deleteCMD As New MySqlCommand(deleteQuery, conn)
                    deleteCMD.Parameters.AddWithValue("@commentID", commentID)
                    deleteCMD.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try

            Try
                Dim deleteReportQuery As String = "DELETE FROM reported_users WHERE comment_id = @commentID"
                Using deleteReportCMD As New MySqlCommand(deleteReportQuery, conn)
                    deleteReportCMD.Parameters.AddWithValue("@commentID", commentID)
                    deleteReportCMD.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub DeleteReport()
        Dim query As String = "DELETE FROM reported_users WHERE report_id = @reportID"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@reportID", reportid)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Report deleted successfully.")
                Else
                    MessageBox.Show("No report found with the specified report_id.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting report: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnDismiss_Click(sender As Object, e As EventArgs) Handles btnDismiss.Click
        If MessageBox.Show("Are you sure you want to delete this report?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DeleteReport()
            RaiseEvent ReportDeleted(Me, EventArgs.Empty)
        End If
    End Sub
End Class