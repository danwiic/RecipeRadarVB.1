<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verify
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        verifyCodePanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblNotif = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblResend = New LinkLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtOTP = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnVerify = New Guna.UI2.WinForms.Guna2Button()
        countdownTimer = New Timer(components)
        Timer1 = New Timer(components)
        recoverPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        shadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        verifyCodePanel.SuspendLayout()
        recoverPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' verifyCodePanel
        ' 
        verifyCodePanel.BackgroundImage = My.Resources.Resources.bg
        verifyCodePanel.BackgroundImageLayout = ImageLayout.Stretch
        verifyCodePanel.Controls.Add(Guna2HtmlLabel2)
        verifyCodePanel.Controls.Add(lblNotif)
        verifyCodePanel.Controls.Add(lblResend)
        verifyCodePanel.Controls.Add(Guna2HtmlLabel1)
        verifyCodePanel.Controls.Add(txtOTP)
        verifyCodePanel.Controls.Add(Guna2HtmlLabel7)
        verifyCodePanel.Controls.Add(btnVerify)
        verifyCodePanel.CustomizableEdges = CustomizableEdges5
        verifyCodePanel.Dock = DockStyle.Fill
        verifyCodePanel.ForeColor = SystemColors.ControlLightLight
        verifyCodePanel.Location = New Point(0, 0)
        verifyCodePanel.MaximumSize = New Size(589, 450)
        verifyCodePanel.MinimumSize = New Size(589, 450)
        verifyCodePanel.Name = "verifyCodePanel"
        verifyCodePanel.ShadowDecoration.BorderRadius = 4
        verifyCodePanel.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        verifyCodePanel.Size = New Size(589, 450)
        verifyCodePanel.TabIndex = 25
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold)
        Guna2HtmlLabel2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel2.Location = New Point(132, 167)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(180, 18)
        Guna2HtmlLabel2.TabIndex = 25
        Guna2HtmlLabel2.Text = "The 6-Digit code has been sent to"
        ' 
        ' lblNotif
        ' 
        lblNotif.BackColor = Color.Transparent
        lblNotif.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblNotif.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNotif.Location = New Point(312, 167)
        lblNotif.Name = "lblNotif"
        lblNotif.Size = New Size(129, 18)
        lblNotif.TabIndex = 24
        lblNotif.Text = "danpirante9@gmail.com"
        ' 
        ' lblResend
        ' 
        lblResend.AutoSize = True
        lblResend.BackColor = Color.Transparent
        lblResend.Cursor = Cursors.Hand
        lblResend.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResend.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblResend.LinkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblResend.Location = New Point(314, 294)
        lblResend.Name = "lblResend"
        lblResend.Size = New Size(54, 16)
        lblResend.TabIndex = 23
        lblResend.TabStop = True
        lblResend.Text = "Resend"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold)
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel1.Location = New Point(184, 293)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(131, 18)
        Guna2HtmlLabel1.TabIndex = 20
        Guna2HtmlLabel1.Text = "Didn't receive the code?"
        ' 
        ' txtOTP
        ' 
        txtOTP.Animated = True
        txtOTP.BackColor = Color.Transparent
        txtOTP.BorderRadius = 8
        txtOTP.CustomizableEdges = CustomizableEdges1
        txtOTP.DefaultText = ""
        txtOTP.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtOTP.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtOTP.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtOTP.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtOTP.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtOTP.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOTP.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtOTP.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtOTP.Location = New Point(183, 188)
        txtOTP.Name = "txtOTP"
        txtOTP.PasswordChar = ChrW(0)
        txtOTP.PlaceholderText = "Enter 6-Digit Code"
        txtOTP.SelectedText = ""
        txtOTP.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtOTP.ShadowDecoration.Depth = 10
        txtOTP.Size = New Size(232, 48)
        txtOTP.TabIndex = 19
        ' 
        ' Guna2HtmlLabel7
        ' 
        Guna2HtmlLabel7.BackColor = Color.Transparent
        Guna2HtmlLabel7.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel7.Location = New Point(219, 55)
        Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Guna2HtmlLabel7.Size = New Size(151, 37)
        Guna2HtmlLabel7.TabIndex = 18
        Guna2HtmlLabel7.Text = "VERIFY OTP"
        ' 
        ' btnVerify
        ' 
        btnVerify.Animated = True
        btnVerify.BackColor = Color.Transparent
        btnVerify.BorderRadius = 8
        btnVerify.Cursor = Cursors.Hand
        btnVerify.CustomizableEdges = CustomizableEdges3
        btnVerify.DisabledState.BorderColor = Color.Transparent
        btnVerify.DisabledState.CustomBorderColor = Color.Transparent
        btnVerify.DisabledState.FillColor = Color.FromArgb(CByte(122), CByte(156), CByte(223))
        btnVerify.DisabledState.ForeColor = Color.White
        btnVerify.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerify.ForeColor = Color.White
        btnVerify.Location = New Point(183, 242)
        btnVerify.Name = "btnVerify"
        btnVerify.ShadowDecoration.BorderRadius = 8
        btnVerify.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnVerify.ShadowDecoration.Depth = 10
        btnVerify.Size = New Size(232, 45)
        btnVerify.TabIndex = 17
        btnVerify.Text = "VERIFY OTP"
        ' 
        ' countdownTimer
        ' 
        countdownTimer.Enabled = True
        countdownTimer.Interval = 1000
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
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
        recoverPanel.TabIndex = 28
        ' 
        ' Guna2HtmlLabel8
        ' 
        Guna2HtmlLabel8.BackColor = Color.Transparent
        Guna2HtmlLabel8.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel8.Location = New Point(3, 2)
        Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Guna2HtmlLabel8.Size = New Size(75, 21)
        Guna2HtmlLabel8.TabIndex = 51
        Guna2HtmlLabel8.Text = "Verify OTP"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges7
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
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button1.Size = New Size(40, 25)
        Guna2Button1.TabIndex = 10
        Guna2Button1.Text = "✕"
        ' 
        ' Verify
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(589, 450)
        Controls.Add(recoverPanel)
        Controls.Add(verifyCodePanel)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(589, 450)
        MinimumSize = New Size(589, 450)
        Name = "Verify"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Verify OTP"
        verifyCodePanel.ResumeLayout(False)
        verifyCodePanel.PerformLayout()
        recoverPanel.ResumeLayout(False)
        recoverPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents verifyCodePanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblNotif As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblResend As LinkLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtOTP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnVerify As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents countdownTimer As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents recoverPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents shadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
