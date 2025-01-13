<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        verifyCodePanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        txtNewPass = New Guna.UI2.WinForms.Guna2TextBox()
        lblResend = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnChange = New Guna.UI2.WinForms.Guna2Button()
        recoverPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        countdownTimer = New Timer(components)
        shadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        verifyCodePanel.SuspendLayout()
        recoverPanel.SuspendLayout()
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
        verifyCodePanel.Size = New Size(589, 450)
        verifyCodePanel.TabIndex = 26
        ' 
        ' btnBack
        ' 
        btnBack.Animated = True
        btnBack.BorderRadius = 8
        btnBack.Cursor = Cursors.Hand
        btnBack.CustomizableEdges = CustomizableEdges1
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 31)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(132, 45)
        btnBack.TabIndex = 23
        btnBack.Text = "BACK"
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
        txtNewPass.IconLeft = My.Resources.Resources.key
        txtNewPass.Location = New Point(170, 167)
        txtNewPass.Name = "txtNewPass"
        txtNewPass.PasswordChar = "*"c
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
        lblResend.Location = New Point(170, 143)
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
        Guna2HtmlLabel1.Location = New Point(170, 225)
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
        txtConfirmPass.IconLeft = My.Resources.Resources.key
        txtConfirmPass.Location = New Point(170, 249)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.PasswordChar = "*"c
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
        Guna2HtmlLabel7.Location = New Point(158, 70)
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
        btnChange.Cursor = Cursors.Hand
        btnChange.CustomizableEdges = CustomizableEdges7
        btnChange.DisabledState.BorderColor = Color.Transparent
        btnChange.DisabledState.CustomBorderColor = Color.Transparent
        btnChange.DisabledState.FillColor = Color.FromArgb(CByte(122), CByte(156), CByte(223))
        btnChange.DisabledState.ForeColor = Color.White
        btnChange.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChange.ForeColor = Color.White
        btnChange.Location = New Point(170, 309)
        btnChange.Name = "btnChange"
        btnChange.ShadowDecoration.BorderRadius = 8
        btnChange.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnChange.ShadowDecoration.Depth = 10
        btnChange.Size = New Size(232, 51)
        btnChange.TabIndex = 17
        btnChange.Text = "CHANGE"
        ' 
        ' recoverPanel
        ' 
        recoverPanel.BackColor = Color.Transparent
        recoverPanel.Controls.Add(Guna2HtmlLabel8)
        recoverPanel.Controls.Add(Guna2Button1)
        recoverPanel.Dock = DockStyle.Top
        recoverPanel.FillColor = Color.WhiteSmoke
        recoverPanel.Location = New Point(0, 0)
        recoverPanel.MaximumSize = New Size(589, 25)
        recoverPanel.MinimumSize = New Size(589, 25)
        recoverPanel.Name = "recoverPanel"
        recoverPanel.ShadowColor = Color.Black
        recoverPanel.ShadowShift = 0
        recoverPanel.Size = New Size(589, 25)
        recoverPanel.TabIndex = 27
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges11
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Dock = DockStyle.Right
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2Button1.Location = New Point(549, 0)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Button1.Size = New Size(40, 25)
        Guna2Button1.TabIndex = 10
        Guna2Button1.Text = "✕"
        ' 
        ' countdownTimer
        ' 
        countdownTimer.Interval = 1000
        ' 
        ' Guna2HtmlLabel8
        ' 
        Guna2HtmlLabel8.BackColor = Color.Transparent
        Guna2HtmlLabel8.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel8.Location = New Point(3, 2)
        Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Guna2HtmlLabel8.Size = New Size(99, 21)
        Guna2HtmlLabel8.TabIndex = 51
        Guna2HtmlLabel8.Text = "Reset Password"
        ' 
        ' ResetPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(589, 450)
        Controls.Add(recoverPanel)
        Controls.Add(verifyCodePanel)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(589, 450)
        MinimumSize = New Size(589, 450)
        Name = "ResetPassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reset Password"
        verifyCodePanel.ResumeLayout(False)
        verifyCodePanel.PerformLayout()
        recoverPanel.ResumeLayout(False)
        recoverPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents verifyCodePanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNewPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblResend As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnChange As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents recoverPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents countdownTimer As Timer
    Friend WithEvents shadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
