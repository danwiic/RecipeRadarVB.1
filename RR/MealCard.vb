Public Class MealCard

    Public Property mealID As Integer

    Public Sub SetMealData(mealID As Integer, mealName As String, mealImage As String, mealCategory As String, favoriteCount As Integer)
        Me.mealID = mealID
        lblMealName.Text = mealName
        lblMealCategory.Text = mealCategory
        lblFavoriteCount.Text = favoriteCount.ToString()
        picMealImage.Load(mealImage)
    End Sub
    Private Sub Guna2Button1_MouseHover(sender As Object, e As EventArgs) Handles btnView.MouseHover

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

    Private Sub btnView_MouseEnter(sender As Object, e As EventArgs) Handles btnView.MouseEnter
        btnView.FillColor = Color.FromArgb(94, 148, 255)
        btnView.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub btnView_MouseLeave(sender As Object, e As EventArgs) Handles btnView.MouseLeave
        btnView.FillColor = Color.WhiteSmoke
        btnView.ForeColor = Color.FromArgb(94, 148, 255)
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles picMealImage.Click

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class
