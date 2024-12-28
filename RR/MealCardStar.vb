Public Class MealCardStar
    Public Property mealID As Integer

    Public Sub SetMealData(mealID As Integer, mealName As String, mealImage As String, mealRating As Single, noOfRatings As Integer)
        Me.mealID = mealID
        lblMealName.Text = mealName
        picMealImage.Load(mealImage)
        mealRatings.Value = mealRating
        lblRates.Text = mealRating.ToString("F1")
        lblNoOfRatings.Text = "(" & noOfRatings.ToString() & ")"
    End Sub

    Private Sub btnView_MouseEnter(sender As Object, e As EventArgs) Handles btnView.MouseEnter
        btnView.FillColor = Color.FromArgb(94, 148, 255)
        btnView.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub btnView_MouseLeave(sender As Object, e As EventArgs) Handles btnView.MouseLeave
        btnView.FillColor = Color.WhiteSmoke
        btnView.ForeColor = Color.FromArgb(94, 148, 255)
    End Sub

    Private Sub MealCardStar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim StarRecipeControl As New ViewRecipe(mealID)
        Dim main As MainForm = CType(Application.OpenForms("MainForm"), MainForm)
        main.displayPanel.Controls.Add(StarRecipeControl)
        StarRecipeControl.Dock = DockStyle.Fill
        main.displayPanel.VerticalScroll.Value = 0
        StarRecipeControl.BringToFront()
        main.displayPanel.PerformLayout()
        main.displayPanel.Invalidate()
    End Sub
End Class
