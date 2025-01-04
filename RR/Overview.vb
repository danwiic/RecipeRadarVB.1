Imports MySql.Data.MySqlClient

Public Class Overview

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchTotalUsers()
        FetchTotalCategories()
        FetchTotalRecipe()
        FetchTotalPending()

        Dim bar As New BarGraph()
        bar.Dock = DockStyle.Fill
        panelBarGraph.Controls.Add(bar)

        Dim recChart As New RecipeChart()
        recChart.Dock = DockStyle.Fill
        panelRecipeChart.Controls.Add(recChart)

    End Sub

    Private Sub FetchTotalUsers()
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM users WHERE role = 'user'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim totalUsers As Integer = cmd.ExecuteScalar()
            btnTotalUsers.Text = totalUsers.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub FetchTotalRecipe()
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM meals"
            Dim cmd As New MySqlCommand(query, conn)
            Dim totalRecipes As Integer = cmd.ExecuteScalar()
            btnTotalRecipes.Text = totalRecipes.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub FetchTotalPending()
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM pending_recipes"
            Dim cmd As New MySqlCommand(query, conn)
            Dim totalPending As Integer = cmd.ExecuteScalar()
            btnPendingRecipe.Text = totalPending.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub FetchTotalCategories()
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM categories"
            Dim cmd As New MySqlCommand(query, conn)
            Dim totalCategories As Integer = cmd.ExecuteScalar()
            btnTotalCategory.Text = totalCategories.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTotalRecipes_Click(sender As Object, e As EventArgs) Handles btnTotalRecipes.Click

    End Sub

    Private Sub Guna2GradientPanel6_Paint(sender As Object, e As PaintEventArgs) Handles panelRecipeChart.Paint

    End Sub
End Class
