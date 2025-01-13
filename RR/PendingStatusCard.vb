Imports System.Management
Imports MySql.Data.MySqlClient

Public Class PendingStatusCard
    Private pendingID As Integer
    Dim status As String
    Dim connStr As String = "server=localhost; uid=root; pwd=; database=recipe_books"
    Dim conn As New MySqlConnection(connStr)
    Public Event RecipeDeleted()


        Public Sub SetData(pendingID As Integer, mealName As String, status As String)
        Me.pendingID = pendingID
        lblRecipeName.Text = mealName
        lblStatus.Text = status.ToUpper
        Me.status = status
    End Sub
    Private Sub PendingStatusCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkStatus()
    End Sub

    Private Sub checkStatus()
        If status = "pending" Then
            lblStatus.ForeColor = Color.Blue
        ElseIf status = "approved" Then
            lblStatus.ForeColor = Color.Green
        ElseIf status = "rejected" Then
            lblStatus.ForeColor = Color.Tomato
            btnUpdate.Hide()
            btnDelete.Location = New Point(344, 8)
        End If
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateRecipe As New UpdateRecipe(pendingID)
        updateRecipe.Show()
    End Sub

    Private Sub DeleteFromPending()
        Try
            conn.Open()
            Dim query As String = "DELETE FROM pending_recipes WHERE id = @pendingID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@pendingID", pendingID)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RaiseEvent RecipeDeleted()
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteFromPending()
    End Sub
End Class
