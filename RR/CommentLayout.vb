Imports MySql.Data.MySqlClient

Public Class CommentLayout

    Dim connStr As String = "Server=localhost; Database=recipe_books; Uid=root; Pwd=;"
    Dim mealID As Integer

    Public Sub New(mealID As Integer)
        InitializeComponent()
        Me.mealID = mealID
        LoadComments()
    End Sub

    Private Sub LoadComments()
        Dim query As String = "SELECT COUNT(*) FROM comments c " &
                              "JOIN users u ON c.user_id = u.user_id " &
                              "WHERE c.meal_id = @mealID"

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@mealID", mealID)

                    Dim commentCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    commentPanel.Controls.Clear()

                    If commentCount = 0 Then
                        lblNoComment.AutoSize = True
                        lblNoComment.ForeColor = Color.Gray
                        lblNoComment.Dock = DockStyle.Fill

                        commentPanel.Controls.Add(lblNoComment)
                    Else
                        LoadActualComments()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading comments: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadActualComments()
        Dim query As String = "SELECT c.comment_id, c.comment_text, u.username, c.created_at " &
                              "FROM comments c " &
                              "JOIN users u ON c.user_id = u.user_id " &
                              "WHERE c.meal_id = @mealID " &
                              "ORDER BY c.created_at DESC"

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@mealID", mealID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        commentPanel.Controls.Clear()

                        While reader.Read()
                            Dim commentID As Integer = reader.GetInt32("comment_id")
                            Dim userName As String = reader("username").ToString()
                            Dim commentText As String = reader("comment_text").ToString()
                            Dim createdAt As DateTime = Convert.ToDateTime(reader("created_at"))
                            Dim comment As New UserCommentCard()
                            comment.setComment(commentID, userName, commentText, createdAt)

                            AddHandler comment.CommentDeleted, AddressOf OnCommentDeleted

                            commentPanel.Controls.Add(comment)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading comments: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub OnCommentDeleted(sender As Object, e As EventArgs)
        LoadComments()
    End Sub

    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        submitComment()
    End Sub

    Private Sub submitComment()
        If Not String.IsNullOrWhiteSpace(txtInputComment.Text) Then
            Dim userId As Integer = LoginForm.currentUserID
            Dim commentText As String = txtInputComment.Text
            Dim createdAt As DateTime = DateTime.Now

            Dim insertQuery As String = "INSERT INTO comments (user_id, meal_id, comment_text, created_at) " &
                                         "VALUES (@userId, @mealID, @commentText, @createdAt)"

            Using conn As New MySqlConnection(connStr)
                Try
                    conn.Open()
                    Using cmd As New MySqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@userId", userId)
                        cmd.Parameters.AddWithValue("@mealID", mealID)
                        cmd.Parameters.AddWithValue("@commentText", commentText)
                        cmd.Parameters.AddWithValue("@createdAt", createdAt)

                        cmd.ExecuteNonQuery()
                    End Using

                    txtInputComment.Clear()

                    LoadComments()
                Catch ex As Exception
                    MessageBox.Show("Error submitting comment: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please enter a comment before submitting.")
        End If
    End Sub
    Private Sub txtInputComment_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInputComment.KeyDown
        If e.KeyCode = Keys.Enter Then
            submitComment()
        End If
    End Sub
End Class
