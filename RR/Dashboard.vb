Public Class Dashboard
    Private Sub btnViewPending_Click(sender As Object, e As EventArgs)
        dashDisplayPanel.Controls.Clear()
        Dim pending As New PendingRecipe
        dashDisplayPanel.Controls.Add(pending)
        pending.Dock = DockStyle.Fill
    End Sub

    Private Sub btnViewOverview_Click(sender As Object, e As EventArgs) Handles btnViewOverview.Click
        DefaultView()
    End Sub

    Private Sub DefaultView()
        dashDisplayPanel.Controls.Clear()
        Dim ovr As New Overview
        dashDisplayPanel.Controls.Add(ovr)
        ovr.Dock = DockStyle.Fill
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        DefaultView()
    End Sub
End Class
