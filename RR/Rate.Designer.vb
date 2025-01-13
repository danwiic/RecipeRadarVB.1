<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rate
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
        signupPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        shadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        ratingStar = New Guna.UI2.WinForms.Guna2RatingStar()
        btnSubmitRate = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblFav = New Guna.UI2.WinForms.Guna2HtmlLabel()
        signupPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' signupPanel
        ' 
        signupPanel.BackColor = Color.Transparent
        signupPanel.Controls.Add(Guna2HtmlLabel8)
        signupPanel.Controls.Add(Guna2Button1)
        signupPanel.Dock = DockStyle.Top
        signupPanel.FillColor = Color.WhiteSmoke
        signupPanel.Location = New Point(0, 0)
        signupPanel.Name = "signupPanel"
        signupPanel.ShadowColor = Color.Black
        signupPanel.ShadowShift = 0
        signupPanel.Size = New Size(351, 30)
        signupPanel.TabIndex = 15
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
        Guna2Button1.Location = New Point(306, 0)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(45, 30)
        Guna2Button1.TabIndex = 10
        Guna2Button1.Text = "✕"
        ' 
        ' shadowForm
        ' 
        shadowForm.TargetForm = Me
        ' 
        ' ratingStar
        ' 
        ratingStar.Location = New Point(51, 77)
        ratingStar.Name = "ratingStar"
        ratingStar.RatingColor = Color.Gold
        ratingStar.Size = New Size(249, 45)
        ratingStar.TabIndex = 16
        ' 
        ' btnSubmitRate
        ' 
        btnSubmitRate.Animated = True
        btnSubmitRate.BorderRadius = 6
        btnSubmitRate.CustomizableEdges = CustomizableEdges3
        btnSubmitRate.DisabledState.BorderColor = Color.DarkGray
        btnSubmitRate.DisabledState.CustomBorderColor = Color.DarkGray
        btnSubmitRate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSubmitRate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSubmitRate.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmitRate.ForeColor = Color.White
        btnSubmitRate.Location = New Point(47, 128)
        btnSubmitRate.Name = "btnSubmitRate"
        btnSubmitRate.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSubmitRate.Size = New Size(249, 45)
        btnSubmitRate.TabIndex = 17
        btnSubmitRate.Text = "SUBMIT RATE"
        ' 
        ' Guna2HtmlLabel8
        ' 
        Guna2HtmlLabel8.BackColor = Color.Transparent
        Guna2HtmlLabel8.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel8.Location = New Point(3, 5)
        Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Guna2HtmlLabel8.Size = New Size(31, 21)
        Guna2HtmlLabel8.TabIndex = 51
        Guna2HtmlLabel8.Text = "Rate"
        ' 
        ' lblFav
        ' 
        lblFav.BackColor = Color.Transparent
        lblFav.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFav.ForeColor = SystemColors.ControlDarkDark
        lblFav.Location = New Point(54, 36)
        lblFav.Name = "lblFav"
        lblFav.Size = New Size(242, 35)
        lblFav.TabIndex = 18
        lblFav.Text = "Click the star to rate!"
        ' 
        ' Rate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(351, 202)
        Controls.Add(lblFav)
        Controls.Add(btnSubmitRate)
        Controls.Add(ratingStar)
        Controls.Add(signupPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "Rate"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rate"
        signupPanel.ResumeLayout(False)
        signupPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents signupPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents shadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnSubmitRate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ratingStar As Guna.UI2.WinForms.Guna2RatingStar
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFav As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
