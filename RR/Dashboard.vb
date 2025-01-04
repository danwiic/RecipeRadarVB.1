Public Class Dashboard
    Private Sub btnViewPending_Click(sender As Object, e As EventArgs)
        dashDisplayPanel.Controls.Clear()
        Dim pending As New PendingRecipe
        dashDisplayPanel.Controls.Add(pending)
        pending.Dock = DockStyle.Fill
    End Sub
End Class
