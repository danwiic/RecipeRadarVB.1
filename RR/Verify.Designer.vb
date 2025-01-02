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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        verifyCodePanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        lblNotif = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblResend = New LinkLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtOTP = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnVerify = New Guna.UI2.WinForms.Guna2Button()
        countdownTimer = New Timer(components)
        Timer1 = New Timer(components)
        verifyCodePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' verifyCodePanel
        ' 
        verifyCodePanel.BackgroundImage = My.Resources.Resources.bg
        verifyCodePanel.BackgroundImageLayout = ImageLayout.Stretch
        verifyCodePanel.Controls.Add(lblNotif)
        verifyCodePanel.Controls.Add(lblResend)
        verifyCodePanel.Controls.Add(Guna2HtmlLabel1)
        verifyCodePanel.Controls.Add(txtOTP)
        verifyCodePanel.Controls.Add(Guna2HtmlLabel7)
        verifyCodePanel.Controls.Add(btnVerify)
        verifyCodePanel.CustomizableEdges = CustomizableEdges11
        verifyCodePanel.Dock = DockStyle.Fill
        verifyCodePanel.ForeColor = SystemColors.ControlLightLight
        verifyCodePanel.Location = New Point(0, 0)
        verifyCodePanel.Name = "verifyCodePanel"
        verifyCodePanel.ShadowDecoration.BorderRadius = 4
        verifyCodePanel.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        verifyCodePanel.Size = New Size(573, 411)
        verifyCodePanel.TabIndex = 25
        ' 
        ' lblNotif
        ' 
        lblNotif.BackColor = Color.Transparent
        lblNotif.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold)
        lblNotif.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNotif.Location = New Point(157, 157)
        lblNotif.Name = "lblNotif"
        lblNotif.Size = New Size(122, 18)
        lblNotif.TabIndex = 24
        lblNotif.Text = "Email has been sent to "
        ' 
        ' lblResend
        ' 
        lblResend.AutoSize = True
        lblResend.BackColor = Color.Transparent
        lblResend.Cursor = Cursors.Hand
        lblResend.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResend.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblResend.LinkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblResend.Location = New Point(314, 294)
        lblResend.Name = "lblResend"
        lblResend.Size = New Size(47, 16)
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
        txtOTP.CustomizableEdges = CustomizableEdges7
        txtOTP.DefaultText = ""
        txtOTP.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtOTP.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtOTP.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtOTP.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtOTP.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtOTP.Font = New Font("Segoe UI", 9F)
        txtOTP.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtOTP.Location = New Point(183, 191)
        txtOTP.Name = "txtOTP"
        txtOTP.PasswordChar = ChrW(0)
        txtOTP.PlaceholderText = "Enter 6-Digit Code"
        txtOTP.SelectedText = ""
        txtOTP.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtOTP.ShadowDecoration.Depth = 10
        txtOTP.Size = New Size(232, 45)
        txtOTP.TabIndex = 19
        ' 
        ' Guna2HtmlLabel7
        ' 
        Guna2HtmlLabel7.BackColor = Color.Transparent
        Guna2HtmlLabel7.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel7.Location = New Point(211, 55)
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
        btnVerify.CustomizableEdges = CustomizableEdges9
        btnVerify.DisabledState.BorderColor = Color.Transparent
        btnVerify.DisabledState.CustomBorderColor = Color.Transparent
        btnVerify.DisabledState.FillColor = Color.FromArgb(CByte(122), CByte(156), CByte(223))
        btnVerify.DisabledState.ForeColor = Color.White
        btnVerify.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerify.ForeColor = Color.White
        btnVerify.Location = New Point(183, 242)
        btnVerify.Name = "btnVerify"
        btnVerify.ShadowDecoration.BorderRadius = 8
        btnVerify.ShadowDecoration.CustomizableEdges = CustomizableEdges10
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
        ' Verify
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(573, 411)
        Controls.Add(verifyCodePanel)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximumSize = New Size(589, 450)
        MinimumSize = New Size(589, 450)
        Name = "Verify"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Verify OTP"
        verifyCodePanel.ResumeLayout(False)
        verifyCodePanel.PerformLayout()
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
End Class
