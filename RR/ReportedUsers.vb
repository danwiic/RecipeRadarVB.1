﻿Imports MySql.Data.MySqlClient

Public Class ReportedUsers
    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(connStr)
    Private Sub ReportedUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReportedUsers()
    End Sub

    Private Sub LoadReportedUsers()
        Dim query As String = "SELECT ru.*, u.username FROM reported_users ru JOIN users u ON ru.reported_user_id = u.user_id"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If Not reader.HasRows Then
                        MessageBox.Show("No reported users found.")
                    End If

                    While reader.Read()
                        Dim reportedUserCard As New ReportedUserCard()
                        Dim report_id As Integer = reader.GetInt32("report_id")
                        Dim userId As Integer = reader.GetInt32("reported_user_id")
                        Dim username As String = reader.GetString("username")
                        Dim comment As String = reader.GetString("comment")
                        Dim reason As String = reader.GetString("reason")
                        reportedUserCard.SetReportedUser(report_id, userId, username, comment, reason)
                        FlowLayoutPanel1.Controls.Add(reportedUserCard)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading reported users: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
