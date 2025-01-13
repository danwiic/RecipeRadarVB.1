Imports MySql.Data.MySqlClient

Public Class ViewPending
    Dim isDragging As Boolean
    Dim startPoint As Point
    Dim connStr As String = "server=localhost; user=root; password=; database=recipe_books"
    Dim conn As New MySqlConnection(connStr)
    Dim currentUserID As Integer = LoginForm.currentUserID
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

    Private Sub FetchPendingOfUser()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM pending_recipes WHERE user_id = @currentUserID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@currentUserID", currentUserID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()


                    If reader.HasRows Then
                        lblStatus.Visible = False
                        lblRecipeHeader.Visible = True
                        lblStatusHeader.Visible = True
                        lblActionHeader.Visible = True

                        While reader.Read()
                            Dim pendingID As Integer = reader("id")
                            Dim mealName As String = reader("strMeal")
                            Dim status As String = reader("status")
                            Dim pendingCard As New PendingStatusCard
                            pendingCard.SetData(pendingID, mealName, status)
                            AddHandler pendingCard.RecipeDeleted, AddressOf RefreshPendingList
                            pendingCard.Dock = DockStyle.Top
                            ViewPendingPanel.Controls.Add(pendingCard)
                        End While

                    Else
                        lblRecipeHeader.Visible = False
                        lblStatusHeader.Visible = False
                        lblActionHeader.Visible = False
                        lblStatus.Visible = True
                        lblStatus.Text = "No record of pending recipes."
                    End If

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ViewPending_Load(sender As Object, e As EventArgs) Handles Me.Load
        FetchPendingOfUser()
        ShadowForm.SetShadowForm(Me)

    End Sub

    Public Sub RefreshPendingList()
        ViewPendingPanel.Controls.Clear()
        FetchPendingOfUser()
    End Sub

    Private Sub ViewPendingPanel_Paint(sender As Object, e As PaintEventArgs) Handles ViewPendingPanel.Paint

    End Sub
End Class