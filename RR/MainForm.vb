
Imports Windows.Win32.System

Public Class MainForm

    Dim currentUserRole As String = LoginForm.currentUserRole
    Private favoritesControl As Favorites
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim userControlSize As Size = displayPanel.Size
        'MessageBox.Show($"User Control Size: {userControlSize.Width} x {userControlSize.Height}")
        displayPanel.Controls.Clear()
        Dim home As New Home
        displayPanel.Controls.Add(home)
        home.Dock = DockStyle.Fill

        favoritesControl = New Favorites()
        displayPanel.Controls.Add(favoritesControl)
    End Sub

    Public Sub RefreshFavorites()
        favoritesControl.LoadFavoriteMeals()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        displayPanel.Controls.Clear()
        Dim home As New Home
        displayPanel.Controls.Add(home)
        home.Dock = DockStyle.Fill
    End Sub

    Private Sub btnFav_Click(sender As Object, e As EventArgs) Handles btnFav.Click
        displayPanel.Controls.Clear()
        Dim fav As New Favorites
        displayPanel.Controls.Add(fav)
        fav.Dock = DockStyle.Fill
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginForm.currentUserRole = ""
        LoginForm.currentUserID = 0
        LoginForm.currentUsername = ""
        LoginForm.currentUserEmail = ""
        Me.Hide()
        Dim login As New LoginForm()
        login.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub btnMeals_Click(sender As Object, e As EventArgs) Handles btnMeals.Click
        displayPanel.Controls.Clear()
        Dim meal As New Meals
        displayPanel.Controls.Add(meal)
        meal.Dock = DockStyle.Fill
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class