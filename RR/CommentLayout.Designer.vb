<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommentLayout
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        commentPanel = New FlowLayoutPanel()
        lblNoComment = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        btnComment = New Guna.UI2.WinForms.Guna2Button()
        txtInputComment = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Panel1.SuspendLayout()
        commentPanel.SuspendLayout()
        Guna2Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderRadius = 8
        Guna2Panel1.Controls.Add(commentPanel)
        Guna2Panel1.Controls.Add(Guna2Panel3)
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.FillColor = Color.WhiteSmoke
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(351, 390)
        Guna2Panel1.TabIndex = 0
        ' 
        ' commentPanel
        ' 
        commentPanel.AutoScroll = True
        commentPanel.Controls.Add(lblNoComment)
        commentPanel.Dock = DockStyle.Fill
        commentPanel.Location = New Point(0, 0)
        commentPanel.Name = "commentPanel"
        commentPanel.Size = New Size(351, 339)
        commentPanel.TabIndex = 3
        ' 
        ' lblNoComment
        ' 
        lblNoComment.BackColor = Color.Transparent
        lblNoComment.Font = New Font("Arial Narrow", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNoComment.Location = New Point(3, 3)
        lblNoComment.Name = "lblNoComment"
        lblNoComment.Size = New Size(253, 22)
        lblNoComment.TabIndex = 2
        lblNoComment.Text = "No comments yet. Be the first one to comment."
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.Controls.Add(btnComment)
        Guna2Panel3.Controls.Add(txtInputComment)
        Guna2Panel3.CustomizableEdges = CustomizableEdges5
        Guna2Panel3.Dock = DockStyle.Bottom
        Guna2Panel3.Location = New Point(0, 339)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel3.Size = New Size(351, 51)
        Guna2Panel3.TabIndex = 2
        ' 
        ' btnComment
        ' 
        btnComment.CustomizableEdges = CustomizableEdges1
        btnComment.DisabledState.BorderColor = Color.DarkGray
        btnComment.DisabledState.CustomBorderColor = Color.DarkGray
        btnComment.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnComment.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnComment.Dock = DockStyle.Right
        btnComment.Font = New Font("Segoe UI", 9F)
        btnComment.ForeColor = Color.White
        btnComment.Image = My.Resources.Resources.chat
        btnComment.Location = New Point(269, 0)
        btnComment.Name = "btnComment"
        btnComment.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnComment.Size = New Size(82, 51)
        btnComment.TabIndex = 1
        ' 
        ' txtInputComment
        ' 
        txtInputComment.CustomizableEdges = CustomizableEdges3
        txtInputComment.DefaultText = ""
        txtInputComment.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtInputComment.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtInputComment.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtInputComment.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtInputComment.Dock = DockStyle.Fill
        txtInputComment.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtInputComment.Font = New Font("Segoe UI", 9F)
        txtInputComment.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtInputComment.Location = New Point(0, 0)
        txtInputComment.Name = "txtInputComment"
        txtInputComment.PasswordChar = ChrW(0)
        txtInputComment.PlaceholderText = "Enter your comment"
        txtInputComment.SelectedText = ""
        txtInputComment.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtInputComment.Size = New Size(351, 51)
        txtInputComment.TabIndex = 0
        ' 
        ' CommentLayout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Guna2Panel1)
        Name = "CommentLayout"
        Size = New Size(351, 445)
        Guna2Panel1.ResumeLayout(False)
        commentPanel.ResumeLayout(False)
        commentPanel.PerformLayout()
        Guna2Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblNoComment As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnComment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtInputComment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents commentPanel As FlowLayoutPanel

End Class
