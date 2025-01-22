<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecoverAccount
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        recoverPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        countdownTimer = New Timer(components)
        displayPanel = New Guna.UI2.WinForms.Guna2Panel()
        shadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        recoverPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' recoverPanel
        ' 
        recoverPanel.BackColor = Color.Transparent
        recoverPanel.Controls.Add(Guna2HtmlLabel8)
        recoverPanel.Controls.Add(Guna2Button1)
        recoverPanel.Dock = DockStyle.Top
        recoverPanel.FillColor = Color.WhiteSmoke
        recoverPanel.Location = New Point(0, 0)
        recoverPanel.Name = "recoverPanel"
        recoverPanel.ShadowColor = Color.Black
        recoverPanel.ShadowShift = 0
        recoverPanel.Size = New Size(589, 25)
        recoverPanel.TabIndex = 15
        ' 
        ' Guna2HtmlLabel8
        ' 
        Guna2HtmlLabel8.BackColor = Color.Transparent
        Guna2HtmlLabel8.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel8.Location = New Point(3, 2)
        Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Guna2HtmlLabel8.Size = New Size(108, 21)
        Guna2HtmlLabel8.TabIndex = 51
        Guna2HtmlLabel8.Text = "Recover Account"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Dock = DockStyle.Right
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2Button1.Location = New Point(544, 0)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(45, 25)
        Guna2Button1.TabIndex = 10
        Guna2Button1.Text = "✕"
        ' 
        ' countdownTimer
        ' 
        countdownTimer.Interval = 1000
        ' 
        ' displayPanel
        ' 
        displayPanel.CustomizableEdges = CustomizableEdges3
        displayPanel.Dock = DockStyle.Fill
        displayPanel.Location = New Point(0, 25)
        displayPanel.Name = "displayPanel"
        displayPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        displayPanel.Size = New Size(589, 425)
        displayPanel.TabIndex = 0
        ' 
        ' RecoverAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(589, 450)
        Controls.Add(displayPanel)
        Controls.Add(recoverPanel)
        DoubleBuffered = True
        Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(589, 450)
        MinimumSize = New Size(589, 450)
        Name = "RecoverAccount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RecoverAccount"
        recoverPanel.ResumeLayout(False)
        recoverPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents recoverPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents countdownTimer As Timer
    Friend WithEvents displayPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents shadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
