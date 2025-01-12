Public Class ViewInfoPendingRecipe
    Public Shared PendingRecipeID As Integer

    Public Sub New(pendingRecipeID As Integer)
        InitializeComponent()
        Me.PendingRecipeID = pendingRecipeID
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Hide()
    End Sub

    Private Sub ViewInfoPendingRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShadowForm.SetShadowForm(Me)
        Dim pending As New PendingData()
        PanelData.Controls.Add(pending)
    End Sub


    Private Sub PanelData_Paint(sender As Object, e As PaintEventArgs) Handles PanelData.Paint

    End Sub
End Class