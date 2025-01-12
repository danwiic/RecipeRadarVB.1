Public Class ViewPending
    Dim isDragging As Boolean
    Dim startPoint As Point
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub


    Private Sub RecoverAccount_MouseDown(sender As Object, e As MouseEventArgs) Handles recoverPanel.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub RecoverAccount_MouseMove(sender As Object, e As MouseEventArgs) Handles recoverPanel.MouseMove
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub RecoverAccount_MouseUp(sender As Object, e As MouseEventArgs) Handles recoverPanel.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub
End Class