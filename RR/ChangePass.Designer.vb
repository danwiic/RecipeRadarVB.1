<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        verifyCodePanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        txtNewPass = New Guna.UI2.WinForms.Guna2TextBox()
        lblResend = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnChange = New Guna.UI2.WinForms.Guna2Button()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        verifyCodePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' verifyCodePanel
        ' 
        verifyCodePanel.BackgroundImage = My.Resources.Resources.bg
        verifyCodePanel.BackgroundImageLayout = ImageLayout.Stretch
        verifyCodePanel.Controls.Add(btnBack)
        verifyCodePanel.Controls.Add(txtNewPass)
        verifyCodePanel.Controls.Add(lblResend)
        verifyCodePanel.Controls.Add(Guna2HtmlLabel1)
        verifyCodePanel.Controls.Add(txtConfirmPass)
        verifyCodePanel.Controls.Add(Guna2HtmlLabel7)
        verifyCodePanel.Controls.Add(btnChange)
        verifyCodePanel.CustomizableEdges = CustomizableEdges9
        verifyCodePanel.Dock = DockStyle.Fill
        verifyCodePanel.ForeColor = SystemColors.ControlLightLight
        verifyCodePanel.Location = New Point(0, 0)
        verifyCodePanel.Name = "verifyCodePanel"
        verifyCodePanel.ShadowDecoration.BorderRadius = 4
        verifyCodePanel.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        verifyCodePanel.Size = New Size(590, 425)
        verifyCodePanel.TabIndex = 25
        ' 
        ' txtNewPass
        ' 
        txtNewPass.Animated = True
        txtNewPass.BackColor = Color.Transparent
        txtNewPass.BorderRadius = 8
        txtNewPass.CustomizableEdges = CustomizableEdges3
        txtNewPass.DefaultText = ""
        txtNewPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtNewPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtNewPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNewPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNewPass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtNewPass.Font = New Font("Segoe UI", 9F)
        txtNewPass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtNewPass.Location = New Point(185, 167)
        txtNewPass.Name = "txtNewPass"
        txtNewPass.PasswordChar = ChrW(0)
        txtNewPass.PlaceholderText = "Enter new password"
        txtNewPass.SelectedText = ""
        txtNewPass.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtNewPass.ShadowDecoration.Depth = 10
        txtNewPass.Size = New Size(232, 45)
        txtNewPass.TabIndex = 22
        ' 
        ' lblResend
        ' 
        lblResend.BackColor = Color.Transparent
        lblResend.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResend.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblResend.Location = New Point(185, 143)
        lblResend.Name = "lblResend"
        lblResend.Size = New Size(79, 18)
        lblResend.TabIndex = 21
        lblResend.Text = "New Password"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold)
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel1.Location = New Point(185, 225)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(99, 18)
        Guna2HtmlLabel1.TabIndex = 20
        Guna2HtmlLabel1.Text = "Confirm Password"
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.Animated = True
        txtConfirmPass.BackColor = Color.Transparent
        txtConfirmPass.BorderRadius = 8
        txtConfirmPass.CustomizableEdges = CustomizableEdges5
        txtConfirmPass.DefaultText = ""
        txtConfirmPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtConfirmPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtConfirmPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtConfirmPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtConfirmPass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtConfirmPass.Font = New Font("Segoe UI", 9F)
        txtConfirmPass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtConfirmPass.Location = New Point(185, 249)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.PasswordChar = ChrW(0)
        txtConfirmPass.PlaceholderText = "Confirm password"
        txtConfirmPass.SelectedText = ""
        txtConfirmPass.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtConfirmPass.ShadowDecoration.Depth = 10
        txtConfirmPass.Size = New Size(232, 45)
        txtConfirmPass.TabIndex = 19
        ' 
        ' Guna2HtmlLabel7
        ' 
        Guna2HtmlLabel7.BackColor = Color.Transparent
        Guna2HtmlLabel7.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel7.Location = New Point(173, 70)
        Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Guna2HtmlLabel7.Size = New Size(256, 37)
        Guna2HtmlLabel7.TabIndex = 18
        Guna2HtmlLabel7.Text = "CHANGE PASSWORD"
        ' 
        ' btnChange
        ' 
        btnChange.Animated = True
        btnChange.BackColor = Color.Transparent
        btnChange.BorderRadius = 8
        btnChange.CustomizableEdges = CustomizableEdges7
        btnChange.DisabledState.BorderColor = Color.Transparent
        btnChange.DisabledState.CustomBorderColor = Color.Transparent
        btnChange.DisabledState.FillColor = Color.FromArgb(CByte(122), CByte(156), CByte(223))
        btnChange.DisabledState.ForeColor = Color.White
        btnChange.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChange.ForeColor = Color.White
        btnChange.Location = New Point(185, 309)
        btnChange.Name = "btnChange"
        btnChange.ShadowDecoration.BorderRadius = 8
        btnChange.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnChange.ShadowDecoration.Depth = 10
        btnChange.Size = New Size(232, 51)
        btnChange.TabIndex = 17
        btnChange.Text = "CHANGE"
        ' 
        ' btnBack
        ' 
        btnBack.Animated = True
        btnBack.BorderRadius = 8
        btnBack.CustomizableEdges = CustomizableEdges1
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(13, 14)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(132, 45)
        btnBack.TabIndex = 23
        btnBack.Text = "BACK"
        ' 
        ' ChangePass
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(verifyCodePanel)
        MaximumSize = New Size(590, 425)
        MinimumSize = New Size(590, 425)
        Name = "ChangePass"
        Size = New Size(590, 425)
        verifyCodePanel.ResumeLayout(False)
        verifyCodePanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents verifyCodePanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtNewPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblResend As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnChange As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button

End Class
