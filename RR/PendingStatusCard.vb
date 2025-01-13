Public Class PendingStatusCard
    Private pendingID As Integer
    Dim status As String

    Public Sub SetData(pendingID As Integer, mealName As String, status As String)
        Me.pendingID = pendingID
        lblRecipeName.Text = mealName
        lblStatus.Text = status.ToUpper
        Me.status = status
    End Sub
    Private Sub PendingStatusCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkStatus()
    End Sub

    Private Sub checkStatus()
        If status = "pending" Then
            lblStatus.ForeColor = Color.Blue
        ElseIf status = "approved" Then
            lblStatus.ForeColor = Color.Green
        ElseIf status = "rejected" Then
            lblStatus.ForeColor = Color.Tomato
        End If
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim updateRecipe As New UpdateRecipe(pendingID)
        updateRecipe.Show()
    End Sub
End Class
