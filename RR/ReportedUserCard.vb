Public Class ReportedUserCard
    Dim userID As Integer
    Dim report_id As Integer
    Private Sub ReportedUserCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetReportedUser(userID As Integer, report_id As Integer, username As String, comment As String, reason As String)
        Me.userID = userID
        Me.report_id = report_id
        lblUsername.Text = username
        txtComment.Text = comment
        lblReason.Text = reason
    End Sub


End Class
