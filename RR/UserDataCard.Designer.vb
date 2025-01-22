<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDataCard
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
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        profImage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        btnEdit = New Guna.UI2.WinForms.Guna2Button()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        chkSeePass = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        CType(profImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' profImage
        ' 
        profImage.ImageRotate = 0F
        profImage.Location = New Point(8, 3)
        profImage.Name = "profImage"
        profImage.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        profImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        profImage.Size = New Size(40, 44)
        profImage.SizeMode = PictureBoxSizeMode.StretchImage
        profImage.TabIndex = 0
        profImage.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Animated = True
        txtUsername.BorderRadius = 6
        txtUsername.BorderThickness = 0
        txtUsername.CustomizableEdges = CustomizableEdges2
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.White
        txtUsername.DisabledState.FillColor = Color.White
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtUsername.Enabled = False
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9F)
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Location = New Point(65, 7)
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
        txtEmail.Animated = True
        txtEmail.BorderRadius = 6
        txtEmail.BorderThickness = 0
        txtEmail.CustomizableEdges = CustomizableEdges4
        txtEmail.DefaultText = ""
        txtEmail.DisabledState.BorderColor = Color.White
        txtEmail.DisabledState.FillColor = Color.White
        txtEmail.DisabledState.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.Enabled = False
        txtEmail.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.Font = New Font("Segoe UI", 9F)
        txtEmail.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.Location = New Point(282, 7)
        txtEmail.Name = "txtEmail"
        txtEmail.PasswordChar = ChrW(0)
        txtEmail.PlaceholderText = ""
        txtEmail.ReadOnly = True
        txtEmail.SelectedText = ""
        txtEmail.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        txtEmail.Size = New Size(200, 36)
        txtEmail.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Animated = True
        txtPassword.BorderRadius = 6
        txtPassword.BorderThickness = 0
        txtPassword.CustomizableEdges = CustomizableEdges6
        txtPassword.DefaultText = ""
        txtPassword.DisabledState.BorderColor = Color.White
        txtPassword.DisabledState.FillColor = Color.White
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.Enabled = False
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("Segoe UI", 9F)
        txtPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Location = New Point(502, 7)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = ""
        txtPassword.ReadOnly = True
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        txtPassword.Size = New Size(200, 36)
        txtPassword.TabIndex = 3
        ' 
        ' btnEdit
        ' 
        btnEdit.Animated = True
        btnEdit.BorderRadius = 6
        btnEdit.Cursor = Cursors.Hand
        btnEdit.CustomizableEdges = CustomizableEdges8
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.FillColor = Color.LimeGreen
        btnEdit.Font = New Font("Segoe UI", 9F)
        btnEdit.ForeColor = Color.White
        btnEdit.Image = My.Resources.Resources.pencil
        btnEdit.Location = New Point(731, 7)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        btnEdit.Size = New Size(59, 36)
        btnEdit.TabIndex = 4
        ' 
        ' btnDelete
        ' 
        btnDelete.Animated = True
        btnDelete.BorderRadius = 6
        btnDelete.Cursor = Cursors.Hand
        btnDelete.CustomizableEdges = CustomizableEdges10
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Tomato
        btnDelete.Font = New Font("Segoe UI", 9F)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.delete_white
        btnDelete.Location = New Point(796, 7)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        btnDelete.Size = New Size(59, 36)
        btnDelete.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.Animated = True
        btnSave.BorderRadius = 6
        btnSave.Cursor = Cursors.Hand
        btnSave.CustomizableEdges = CustomizableEdges12
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.Font = New Font("Segoe UI", 9F)
        btnSave.ForeColor = Color.White
        btnSave.Image = My.Resources.Resources.save
        btnSave.Location = New Point(731, 7)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges13
        btnSave.Size = New Size(59, 36)
        btnSave.TabIndex = 6
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.FillThickness = 2
        Guna2Separator1.Location = New Point(0, 43)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(875, 10)
        Guna2Separator1.TabIndex = 7
        ' 
        ' chkSeePass
        ' 
        chkSeePass.BackColor = Color.White
        chkSeePass.BackgroundImage = My.Resources.Resources.hidden
        chkSeePass.BackgroundImageLayout = ImageLayout.Center
        chkSeePass.CheckedState.BorderColor = Color.Transparent
        chkSeePass.CheckedState.BorderRadius = 2
        chkSeePass.CheckedState.BorderThickness = 0
        chkSeePass.CheckedState.FillColor = Color.Transparent
        chkSeePass.CheckMarkColor = Color.Transparent
        chkSeePass.Cursor = Cursors.Hand
        chkSeePass.CustomizableEdges = CustomizableEdges14
        chkSeePass.ForeColor = Color.Transparent
        chkSeePass.Location = New Point(673, 12)
        chkSeePass.Name = "chkSeePass"
        chkSeePass.ShadowDecoration.CustomizableEdges = CustomizableEdges15
        chkSeePass.Size = New Size(22, 25)
        chkSeePass.TabIndex = 12
        chkSeePass.UncheckedState.BorderColor = Color.Transparent
        chkSeePass.UncheckedState.BorderRadius = 0
        chkSeePass.UncheckedState.BorderThickness = 0
        chkSeePass.UncheckedState.FillColor = Color.Transparent
        ' 
        ' UserDataCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(chkSeePass)
        Controls.Add(Guna2Separator1)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        Controls.Add(profImage)
        Controls.Add(btnSave)
        DoubleBuffered = True
        Name = "UserDataCard"
        Size = New Size(874, 50)
        CType(profImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents profImage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents chkSeePass As Guna.UI2.WinForms.Guna2CustomCheckBox

End Class
