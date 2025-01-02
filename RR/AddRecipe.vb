Public Class AddRecipe
    Dim userRole As String = LoginForm.currentUserRole
    Private Sub AddRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shadowForm.SetShadowForm(Me)
    End Sub

    Private Sub CheckUserRole()
        If userRole = "admin" Then
            btnAddNewRecipe.Text = "ADD RECIPE"
        Else
            btnAddNewRecipe.Text = "SUBMIT FOR REVIEW"
        End If
    End Sub
    Private Sub btnAddNewRecipe_Click(sender As Object, e As EventArgs) Handles btnAddNewRecipe.Click

    End Sub
End Class