<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserCommentCard
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lblUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        picUser = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        txtComment = New Guna.UI2.WinForms.Guna2TextBox()
        lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        btnReport = New Guna.UI2.WinForms.Guna2Button()
        CType(picUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.BackColor = Color.Transparent
        lblUser.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = SystemColors.ControlDarkDark
        lblUser.Location = New Point(7, 15)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(96, 18)
        lblUser.TabIndex = 0
        lblUser.Text = "Guna2HtmlLabel1"
        ' 
        ' picUser
        ' 
        picUser.Image = My.Resources.Resources.img
        picUser.ImageRotate = 0F
        picUser.Location = New Point(6, 41)
        picUser.Name = "picUser"
        picUser.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        picUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        picUser.Size = New Size(32, 34)
        picUser.SizeMode = PictureBoxSizeMode.StretchImage
        picUser.TabIndex = 1
        picUser.TabStop = False
        ' 
        ' txtComment
        ' 
        txtComment.BorderRadius = 6
        txtComment.CustomizableEdges = CustomizableEdges2
        txtComment.DefaultText = ""
        txtComment.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtComment.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtComment.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtComment.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtComment.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtComment.Font = New Font("Segoe UI", 9F)
        txtComment.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtComment.Location = New Point(44, 41)
        txtComment.Multiline = True
        txtComment.Name = "txtComment"
        txtComment.PasswordChar = ChrW(0)
        txtComment.PlaceholderText = ""
        txtComment.ReadOnly = True
        txtComment.SelectedText = ""
        txtComment.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        txtComment.Size = New Size(217, 36)
        txtComment.TabIndex = 2
        ' 
        ' lblDate
        ' 
        lblDate.BackColor = Color.Transparent
        lblDate.ForeColor = SystemColors.ControlDarkDark
        lblDate.Location = New Point(6, 84)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(98, 17)
        lblDate.TabIndex = 3
        lblDate.Text = "Guna2HtmlLabel2"
        ' 
        ' btnDelete
        ' 
        btnDelete.CustomizableEdges = CustomizableEdges4
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Transparent
        btnDelete.Font = New Font("Segoe UI", 9F)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.Location = New Point(267, 41)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        btnDelete.Size = New Size(37, 36)
        btnDelete.TabIndex = 4
        ' 
        ' btnReport
        ' 
        btnReport.CustomizableEdges = CustomizableEdges6
        btnReport.DisabledState.BorderColor = Color.DarkGray
        btnReport.DisabledState.CustomBorderColor = Color.DarkGray
        btnReport.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnReport.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnReport.FillColor = Color.Transparent
        btnReport.Font = New Font("Segoe UI", 9F)
        btnReport.ForeColor = Color.White
        btnReport.Image = My.Resources.Resources.problem_report
        btnReport.Location = New Point(263, 41)
        btnReport.Name = "btnReport"
        btnReport.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        btnReport.Size = New Size(44, 36)
        btnReport.TabIndex = 5
        ' 
        ' UserCommentCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnReport)
        Controls.Add(btnDelete)
        Controls.Add(lblDate)
        Controls.Add(txtComment)
        Controls.Add(picUser)
        Controls.Add(lblUser)
        Name = "UserCommentCard"
        Size = New Size(307, 107)
        CType(picUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents picUser As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txtComment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReport As Guna.UI2.WinForms.Guna2Button

End Class
