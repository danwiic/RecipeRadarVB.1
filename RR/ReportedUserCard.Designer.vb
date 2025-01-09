<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportedUserCard
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtComment = New Guna.UI2.WinForms.Guna2TextBox()
        lblReason = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        btnMute = New Guna.UI2.WinForms.Guna2Button()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblUsername.Location = New Point(20, 17)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(71, 19)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' txtComment
        ' 
        txtComment.Animated = True
        txtComment.AutoScroll = True
        txtComment.BorderRadius = 6
        txtComment.CustomizableEdges = CustomizableEdges1
        txtComment.DefaultText = ""
        txtComment.DisabledState.BorderColor = Color.White
        txtComment.DisabledState.FillColor = Color.White
        txtComment.DisabledState.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtComment.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtComment.Enabled = False
        txtComment.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtComment.Font = New Font("Arial", 9.75F)
        txtComment.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtComment.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtComment.Location = New Point(123, 8)
        txtComment.Name = "txtComment"
        txtComment.PasswordChar = ChrW(0)
        txtComment.PlaceholderText = ""
        txtComment.ReadOnly = True
        txtComment.SelectedText = ""
        txtComment.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtComment.Size = New Size(266, 36)
        txtComment.TabIndex = 1
        ' 
        ' lblReason
        ' 
        lblReason.BackColor = Color.Transparent
        lblReason.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReason.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblReason.Location = New Point(424, 17)
        lblReason.Name = "lblReason"
        lblReason.Size = New Size(153, 19)
        lblReason.TabIndex = 2
        lblReason.Text = "Inappropriate comment"
        ' 
        ' btnDelete
        ' 
        btnDelete.Animated = True
        btnDelete.BorderRadius = 6
        btnDelete.Cursor = Cursors.Hand
        btnDelete.CustomizableEdges = CustomizableEdges3
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Tomato
        btnDelete.Font = New Font("Segoe UI", 9F)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.delete_white
        btnDelete.Location = New Point(736, 7)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnDelete.Size = New Size(75, 36)
        btnDelete.TabIndex = 6
        ' 
        ' btnMute
        ' 
        btnMute.Animated = True
        btnMute.BorderRadius = 6
        btnMute.Cursor = Cursors.Hand
        btnMute.CustomizableEdges = CustomizableEdges5
        btnMute.DisabledState.BorderColor = Color.DarkGray
        btnMute.DisabledState.CustomBorderColor = Color.DarkGray
        btnMute.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnMute.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnMute.FillColor = Color.LimeGreen
        btnMute.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMute.ForeColor = Color.White
        btnMute.Location = New Point(655, 7)
        btnMute.Name = "btnMute"
        btnMute.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnMute.Size = New Size(75, 36)
        btnMute.TabIndex = 14
        btnMute.Text = "MUTE"
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.BackColor = Color.Transparent
        Guna2Separator1.FillThickness = 2
        Guna2Separator1.Location = New Point(0, 43)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(833, 10)
        Guna2Separator1.TabIndex = 15
        ' 
        ' ReportedUserCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2Separator1)
        Controls.Add(btnMute)
        Controls.Add(btnDelete)
        Controls.Add(lblReason)
        Controls.Add(txtComment)
        Controls.Add(lblUsername)
        Name = "ReportedUserCard"
        Size = New Size(833, 50)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtComment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblReason As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMute As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator

End Class
