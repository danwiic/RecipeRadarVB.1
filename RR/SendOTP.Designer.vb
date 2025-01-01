<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendOTP
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
        sendCodePanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnSend = New Guna.UI2.WinForms.Guna2Button()
        countdownTimer = New Timer(components)
        sendCodePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' sendCodePanel
        ' 
        sendCodePanel.Controls.Add(txtEmail)
        sendCodePanel.Controls.Add(Guna2HtmlLabel2)
        sendCodePanel.Controls.Add(btnSend)
        sendCodePanel.CustomizableEdges = CustomizableEdges5
        sendCodePanel.Dock = DockStyle.Fill
        sendCodePanel.FillColor = Color.FromArgb(CByte(77), CByte(161), CByte(169))
        sendCodePanel.FillColor2 = Color.FromArgb(CByte(188), CByte(204), CByte(220))
        sendCodePanel.Location = New Point(0, 0)
        sendCodePanel.MaximumSize = New Size(590, 425)
        sendCodePanel.MinimumSize = New Size(590, 425)
        sendCodePanel.Name = "sendCodePanel"
        sendCodePanel.ShadowDecoration.BorderRadius = 4
        sendCodePanel.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        sendCodePanel.Size = New Size(590, 425)
        sendCodePanel.TabIndex = 23
        ' 
        ' txtEmail
        ' 
        txtEmail.Animated = True
        txtEmail.BackColor = Color.Transparent
        txtEmail.BorderRadius = 8
        txtEmail.CustomizableEdges = CustomizableEdges1
        txtEmail.DefaultText = ""
        txtEmail.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtEmail.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtEmail.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.Font = New Font("Segoe UI", 9F)
        txtEmail.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.IconLeft = My.Resources.Resources.mail
        txtEmail.Location = New Point(179, 189)
        txtEmail.Name = "txtEmail"
        txtEmail.PasswordChar = ChrW(0)
        txtEmail.PlaceholderText = "Enter email"
        txtEmail.SelectedText = ""
        txtEmail.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtEmail.ShadowDecoration.Depth = 10
        txtEmail.Size = New Size(232, 45)
        txtEmail.TabIndex = 19
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = SystemColors.ControlLightLight
        Guna2HtmlLabel2.Location = New Point(256, 87)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(72, 37)
        Guna2HtmlLabel2.TabIndex = 18
        Guna2HtmlLabel2.Text = "SEND"
        ' 
        ' btnSend
        ' 
        btnSend.Animated = True
        btnSend.BackColor = Color.Transparent
        btnSend.BorderRadius = 8
        btnSend.CustomizableEdges = CustomizableEdges3
        btnSend.DisabledState.BorderColor = Color.Transparent
        btnSend.DisabledState.CustomBorderColor = Color.Transparent
        btnSend.DisabledState.FillColor = Color.FromArgb(CByte(122), CByte(156), CByte(223))
        btnSend.DisabledState.ForeColor = Color.White
        btnSend.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSend.ForeColor = Color.White
        btnSend.Location = New Point(179, 240)
        btnSend.Name = "btnSend"
        btnSend.ShadowDecoration.BorderRadius = 8
        btnSend.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSend.ShadowDecoration.Depth = 10
        btnSend.Size = New Size(232, 45)
        btnSend.TabIndex = 17
        btnSend.Text = "SEND OTP"
        ' 
        ' countdownTimer
        ' 
        countdownTimer.Interval = 1000
        ' 
        ' SendOTP
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(sendCodePanel)
        MaximumSize = New Size(590, 425)
        MinimumSize = New Size(590, 425)
        Name = "SendOTP"
        Size = New Size(590, 425)
        sendCodePanel.ResumeLayout(False)
        sendCodePanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents sendCodePanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents countdownTimer As Timer

End Class
