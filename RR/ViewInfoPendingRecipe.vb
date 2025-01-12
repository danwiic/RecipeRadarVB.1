Public Class ViewInfoPendingRecipe
    Dim pendingRecipeID As Integer
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Hide()
    End Sub

    Private Sub ViewInfoPendingRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShadowForm.SetShadowForm(Me)

        Dim vid As New SmallVid("https://www.youtube.com/watch?v=G6fA2kSnpUw")
        flowPanelVideo.Controls.Add(vid)

    End Sub

    Public Sub GetRecipeInfo(recipeID As Integer)
        recipeID = Me.pendingRecipeID
    End Sub

    Private Sub txtInstructions_TextChanged(sender As Object, e As EventArgs) Handles txtInstructions.TextChanged

    End Sub
End Class