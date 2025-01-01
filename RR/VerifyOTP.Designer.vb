<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyOTP
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        verifyCodePanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        lblNotif = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblResend = New LinkLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtOTP = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnVerify = New Guna.UI2.WinForms.Guna2Button()
        countdownTimer = New Timer(components)
        verifyCodePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' verifyCodePanel
        ' 
        verifyCodePanel.Controls.Add(lblNotif)
        verifyCodePanel.Controls.Add(lblResend)
        verifyCodePanel.Controls.Add(Guna2HtmlLabel1)
        verifyCodePanel.Controls.Add(txtOTP)
        verifyCodePanel.Controls.Add(Guna2HtmlLabel7)
        verifyCodePanel.Controls.Add(btnVerify)
        verifyCodePanel.CustomizableEdges = CustomizableEdges5
        verifyCodePanel.Dock = DockStyle.Fill
        verifyCodePanel.FillColor = Color.FromArgb(CByte(77), CByte(161), CByte(169))
        verifyCodePanel.FillColor2 = Color.FromArgb(CByte(188), CByte(204), CByte(220))
        verifyCodePanel.ForeColor = SystemColors.ControlLightLight
        verifyCodePanel.Location = New Point(0, 0)
        verifyCodePanel.MaximumSize = New Size(590, 425)
        verifyCodePanel.MinimumSize = New Size(590, 425)
        verifyCodePanel.Name = "verifyCodePanel"
        verifyCodePanel.ShadowDecoration.BorderRadius = 4
        verifyCodePanel.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        verifyCodePanel.Size = New Size(590, 425)
        verifyCodePanel.TabIndex = 24
        ' 
        ' lblNotif
        ' 
        lblNotif.BackColor = Color.Transparent
        lblNotif.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold)
        lblNotif.ForeColor = SystemColors.ControlLightLight
        lblNotif.Location = New Point(130, 175)
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
        lblResend.LinkColor = Color.White
        lblResend.Location = New Point(309, 319)
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
        Guna2HtmlLabel1.ForeColor = SystemColors.ControlLightLight
        Guna2HtmlLabel1.Location = New Point(179, 318)
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
        txtOTP.Font = New Font("Segoe UI", 9F)
        txtOTP.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtOTP.Location = New Point(178, 216)
        txtOTP.Name = "txtOTP"
        txtOTP.PasswordChar = ChrW(0)
        txtOTP.PlaceholderText = "Enter 6-Digit Code"
        txtOTP.SelectedText = ""
        txtOTP.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtOTP.ShadowDecoration.Depth = 10
        txtOTP.Size = New Size(232, 45)
        txtOTP.TabIndex = 19
        ' 
        ' Guna2HtmlLabel7
        ' 
        Guna2HtmlLabel7.BackColor = Color.Transparent
        Guna2HtmlLabel7.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel7.ForeColor = SystemColors.ControlLightLight
        Guna2HtmlLabel7.Location = New Point(219, 108)
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
        btnVerify.CustomizableEdges = CustomizableEdges3
        btnVerify.DisabledState.BorderColor = Color.Transparent
        btnVerify.DisabledState.CustomBorderColor = Color.Transparent
        btnVerify.DisabledState.FillColor = Color.FromArgb(CByte(122), CByte(156), CByte(223))
        btnVerify.DisabledState.ForeColor = Color.White
        btnVerify.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerify.ForeColor = Color.White
        btnVerify.Location = New Point(178, 267)
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
        ' VerifyOTP
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(verifyCodePanel)
        MaximumSize = New Size(590, 425)
        MinimumSize = New Size(590, 425)
        Name = "VerifyOTP"
        Size = New Size(590, 425)
        verifyCodePanel.ResumeLayout(False)
        verifyCodePanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents verifyCodePanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtOTP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnVerify As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblResend As LinkLabel
    Friend WithEvents countdownTimer As Timer
    Friend WithEvents lblNotif As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
