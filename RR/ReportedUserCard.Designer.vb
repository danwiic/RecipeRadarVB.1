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
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        btnDismiss = New Guna.UI2.WinForms.Guna2Button()
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
        btnDelete.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(769, 8)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnDelete.Size = New Size(91, 36)
        btnDelete.TabIndex = 6
        btnDelete.Text = "DELETE"
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.BackColor = Color.Transparent
        Guna2Separator1.FillThickness = 2
        Guna2Separator1.Location = New Point(0, 43)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(882, 10)
        Guna2Separator1.TabIndex = 15
        ' 
        ' btnDismiss
        ' 
        btnDismiss.Animated = True
        btnDismiss.BorderRadius = 6
        btnDismiss.Cursor = Cursors.Hand
        btnDismiss.CustomizableEdges = CustomizableEdges5
        btnDismiss.DisabledState.BorderColor = Color.DarkGray
        btnDismiss.DisabledState.CustomBorderColor = Color.DarkGray
        btnDismiss.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDismiss.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDismiss.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDismiss.ForeColor = Color.White
        btnDismiss.Location = New Point(672, 8)
        btnDismiss.Name = "btnDismiss"
        btnDismiss.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnDismiss.Size = New Size(91, 36)
        btnDismiss.TabIndex = 16
        btnDismiss.Text = "DISMISS"
        ' 
        ' ReportedUserCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtComment)
        Controls.Add(btnDelete)
        Controls.Add(btnDismiss)
        Controls.Add(Guna2Separator1)
        Controls.Add(lblReason)
        Controls.Add(lblUsername)
        DoubleBuffered = True
        Name = "ReportedUserCard"
        Size = New Size(880, 50)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtComment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblReason As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnDismiss As Guna.UI2.WinForms.Guna2Button

End Class
