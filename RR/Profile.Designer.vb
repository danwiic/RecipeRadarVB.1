<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pbUserImage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        btnUpload = New Guna.UI2.WinForms.Guna2Button()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(pbUserImage, ComponentModel.ISupportInitialize).BeginInit()
        Guna2ContainerControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbUserImage
        ' 
        pbUserImage.BackColor = Color.Transparent
        pbUserImage.ImageRotate = 0F
        pbUserImage.Location = New Point(330, 3)
        pbUserImage.Name = "pbUserImage"
        pbUserImage.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        pbUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        pbUserImage.Size = New Size(246, 242)
        pbUserImage.SizeMode = PictureBoxSizeMode.StretchImage
        pbUserImage.TabIndex = 0
        pbUserImage.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.CustomizableEdges = CustomizableEdges2
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9F)
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Location = New Point(220, 283)
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = ChrW(0)
        txtUsername.PlaceholderText = ""
        txtUsername.ReadOnly = True
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        txtUsername.Size = New Size(200, 36)
        txtUsername.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.CustomizableEdges = CustomizableEdges4
        txtEmail.DefaultText = ""
        txtEmail.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtEmail.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtEmail.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.Font = New Font("Segoe UI", 9F)
        txtEmail.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.Location = New Point(220, 336)
        txtEmail.Name = "txtEmail"
        txtEmail.PasswordChar = ChrW(0)
        txtEmail.PlaceholderText = ""
        txtEmail.ReadOnly = True
        txtEmail.SelectedText = ""
        txtEmail.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        txtEmail.Size = New Size(200, 36)
        txtEmail.TabIndex = 2
        ' 
        ' Guna2ContainerControl1
        ' 
        Guna2ContainerControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2ContainerControl1.BackColor = Color.Transparent
        Guna2ContainerControl1.BorderRadius = 12
        Guna2ContainerControl1.Controls.Add(btnUpload)
        Guna2ContainerControl1.Controls.Add(btnSave)
        Guna2ContainerControl1.Controls.Add(btnEdit)
        Guna2ContainerControl1.Controls.Add(Guna2HtmlLabel2)
        Guna2ContainerControl1.Controls.Add(Guna2HtmlLabel1)
        Guna2ContainerControl1.Controls.Add(pbUserImage)
        Guna2ContainerControl1.Controls.Add(txtUsername)
        Guna2ContainerControl1.Controls.Add(txtEmail)
        Guna2ContainerControl1.CustomizableEdges = CustomizableEdges12
        Guna2ContainerControl1.Location = New Point(70, 111)
        Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Guna2ContainerControl1.ShadowDecoration.BorderRadius = 14
        Guna2ContainerControl1.ShadowDecoration.CustomizableEdges = CustomizableEdges13
        Guna2ContainerControl1.ShadowDecoration.Depth = 8
        Guna2ContainerControl1.ShadowDecoration.Enabled = True
        Guna2ContainerControl1.ShadowDecoration.Shadow = New Padding(5, 3, 5, 5)
        Guna2ContainerControl1.Size = New Size(906, 471)
        Guna2ContainerControl1.TabIndex = 3
        Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        ' 
        ' btnUpload
        ' 
        btnUpload.Animated = True
        btnUpload.BackColor = Color.Transparent
        btnUpload.BorderRadius = 10
        btnUpload.CustomizableEdges = CustomizableEdges6
        btnUpload.DisabledState.BorderColor = Color.DarkGray
        btnUpload.DisabledState.CustomBorderColor = Color.DarkGray
        btnUpload.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUpload.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUpload.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpload.ForeColor = Color.White
        btnUpload.Location = New Point(582, 200)
        btnUpload.Name = "btnUpload"
        btnUpload.ShadowDecoration.BorderRadius = 12
        btnUpload.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        btnUpload.ShadowDecoration.Depth = 8
        btnUpload.ShadowDecoration.Enabled = True
        btnUpload.ShadowDecoration.Shadow = New Padding(5, 3, 5, 5)
        btnUpload.Size = New Size(172, 45)
        btnUpload.TabIndex = 7
        btnUpload.Text = "CHANGE PROFILE"
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSave.Animated = True
        btnSave.BackColor = Color.Transparent
        btnSave.BorderRadius = 10
        btnSave.CustomizableEdges = CustomizableEdges8
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Image = My.Resources.Resources.save
        btnSave.Location = New Point(710, 411)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.BorderRadius = 12
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        btnSave.ShadowDecoration.Depth = 8
        btnSave.ShadowDecoration.Enabled = True
        btnSave.ShadowDecoration.Shadow = New Padding(5, 3, 5, 5)
        btnSave.Size = New Size(180, 45)
        btnSave.TabIndex = 6
        btnSave.Text = "SAVE"
        btnSave.Visible = False
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEdit.Animated = True
        btnEdit.BackColor = Color.Transparent
        btnEdit.BorderRadius = 10
        btnEdit.CustomizableEdges = CustomizableEdges10
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.White
        btnEdit.Image = My.Resources.Resources.pencil
        btnEdit.Location = New Point(710, 411)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.BorderRadius = 12
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        btnEdit.ShadowDecoration.Depth = 8
        btnEdit.ShadowDecoration.Enabled = True
        btnEdit.ShadowDecoration.Shadow = New Padding(5, 3, 5, 5)
        btnEdit.Size = New Size(180, 45)
        btnEdit.TabIndex = 5
        btnEdit.Text = "EDIT"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.Location = New Point(171, 343)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(43, 20)
        Guna2HtmlLabel2.TabIndex = 4
        Guna2HtmlLabel2.Text = "Email"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(139, 290)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(75, 20)
        Guna2HtmlLabel1.TabIndex = 3
        Guna2HtmlLabel1.Text = "Username"
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2ContainerControl1)
        Name = "Profile"
        Size = New Size(1047, 600)
        CType(pbUserImage, ComponentModel.ISupportInitialize).EndInit()
        Guna2ContainerControl1.ResumeLayout(False)
        Guna2ContainerControl1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbUserImage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpload As Guna.UI2.WinForms.Guna2Button

End Class
