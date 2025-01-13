<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPending
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        recoverPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        ViewPendingPanel = New FlowLayoutPanel()
        ShadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        recoverPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' recoverPanel
        ' 
        recoverPanel.BackColor = Color.Transparent
        recoverPanel.Controls.Add(Guna2Button1)
        recoverPanel.Dock = DockStyle.Top
        recoverPanel.FillColor = Color.Transparent
        recoverPanel.Location = New Point(0, 0)
        recoverPanel.Name = "recoverPanel"
        recoverPanel.ShadowColor = Color.Black
        recoverPanel.ShadowShift = 0
        recoverPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        recoverPanel.Size = New Size(484, 25)
        recoverPanel.TabIndex = 17
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Dock = DockStyle.Right
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2Button1.Location = New Point(439, 0)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(45, 25)
        Guna2Button1.TabIndex = 10
        Guna2Button1.Text = "✕"
        ' 
        ' ViewPendingPanel
        ' 
        ViewPendingPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ViewPendingPanel.AutoScroll = True
        ViewPendingPanel.Location = New Point(0, 60)
        ViewPendingPanel.Name = "ViewPendingPanel"
        ViewPendingPanel.Size = New Size(484, 310)
        ViewPendingPanel.TabIndex = 18
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.White
        Guna2HtmlLabel2.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Guna2HtmlLabel2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel2.Location = New Point(12, 37)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(97, 20)
        Guna2HtmlLabel2.TabIndex = 19
        Guna2HtmlLabel2.Text = "Recipe Name"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.White
        Guna2HtmlLabel1.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel1.Location = New Point(185, 37)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(102, 20)
        Guna2HtmlLabel1.TabIndex = 20
        Guna2HtmlLabel1.Text = "Recipe Status"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.White
        Guna2HtmlLabel3.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Guna2HtmlLabel3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel3.Location = New Point(356, 37)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(47, 20)
        Guna2HtmlLabel3.TabIndex = 21
        Guna2HtmlLabel3.Text = "Action"
        ' 
        ' ViewPending
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(484, 370)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(ViewPendingPanel)
        Controls.Add(recoverPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewPending"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewPending"
        recoverPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents recoverPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ViewPendingPanel As FlowLayoutPanel
    Friend WithEvents ShadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
