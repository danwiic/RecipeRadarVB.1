Public Class AddRecipe
    Dim userRole As String = LoginForm.currentUserRole
    Private Sub AddRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shadowForm.SetShadowForm(Me)
        CheckUserRole()
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub
End Class