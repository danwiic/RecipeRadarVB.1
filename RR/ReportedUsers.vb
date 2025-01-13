Imports MySql.Data.MySqlClient

Public Class ReportedUsers
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Private currentPage As Integer = 1
    Private usersPerPage As Integer = 10
    Private totalUsers As Integer = 0
    Private totalPages As Integer = 1

    Private Sub ReportedUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReportedUsers()
        PageCheck()
    End Sub

    Private Sub PageCheck()
        btnPrev.Enabled = currentPage > 1
        btnNext.Enabled = currentPage < totalPages
    End Sub

    Private Sub LoadReportedUsers()
        FlowLayoutPanel1.Controls.Clear()
        Dim countQuery As String = "SELECT COUNT(*) FROM reported_users"
        Try
            conn.Open()
            Using countCmd As New MySqlCommand(countQuery, conn)
                totalUsers = Convert.ToInt32(countCmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error counting reported users: " & ex.Message)
        Finally
            conn.Close()
        End Try

        totalPages = Math.Ceiling(totalUsers / usersPerPage)

        Dim query As String = "SELECT ru.*, u.username FROM reported_users ru JOIN users u ON ru.reported_user_id = u.user_id LIMIT @limit OFFSET @offset"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@limit", usersPerPage)
                cmd.Parameters.AddWithValue("@offset", (currentPage - 1) * usersPerPage)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If Not reader.HasRows Then
                        lblStatus.Text = "No reported users found."
                        lblStatus.Visible = True
                        lblUsername.Visible = False
                        lblComments.Visible = False
                        lblAction.Visible = False
                        lblReason.Visible = False
                    Else
                        lblStatus.Visible = False
                        While reader.Read()
                            Dim reportedUserCard As New ReportedUserCard()
                            Dim report_id As Integer = reader.GetInt32("report_id")
                            Dim userId As Integer = reader.GetInt32("reported_user_id")
                            Dim username As String = reader.GetString("username")
                            Dim comment As String = reader.GetString("comment")
                            Dim reason As String = reader.GetString("reason")
                            ReportedUserCard.getReportID(report_id)
                            ReportedUserCard.SetReportedUser(userId, username, comment, reason)
                            AddHandler ReportedUserCard.ReportDeleted, AddressOf OnReportDeleted
                            FlowLayoutPanel1.Controls.Add(ReportedUserCard)
                        End While
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading reported users: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub OnReportDeleted(sender As Object, e As EventArgs)
        LoadReportedUsers()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadReportedUsers()
            PageCheck()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < totalPages Then
            currentPage += 1
            LoadReportedUsers()
            PageCheck()
        End If
    End Sub
End Class