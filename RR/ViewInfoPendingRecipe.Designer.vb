<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewInfoPendingRecipe
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
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        ShadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        PanelData = New Guna.UI2.WinForms.Guna2Panel()
        recoverPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' recoverPanel
        ' 
        recoverPanel.BackColor = Color.Transparent
        recoverPanel.Controls.Add(Guna2Button1)
        recoverPanel.Dock = DockStyle.Top
        recoverPanel.FillColor = Color.WhiteSmoke
        recoverPanel.Location = New Point(0, 0)
        recoverPanel.Name = "recoverPanel"
        recoverPanel.ShadowColor = Color.Black
        recoverPanel.ShadowShift = 0
        recoverPanel.Size = New Size(790, 25)
        recoverPanel.TabIndex = 16
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
        Guna2Button1.Location = New Point(745, 0)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(45, 25)
        Guna2Button1.TabIndex = 10
        Guna2Button1.Text = "✕"
        ' 
        ' PanelData
        ' 
        PanelData.CustomizableEdges = CustomizableEdges3
        PanelData.Dock = DockStyle.Fill
        PanelData.Location = New Point(0, 25)
        PanelData.Name = "PanelData"
        PanelData.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        PanelData.Size = New Size(790, 434)
        PanelData.TabIndex = 17
        ' 
        ' ViewInfoPendingRecipe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(790, 459)
        Controls.Add(PanelData)
        Controls.Add(recoverPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewInfoPendingRecipe"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewInfoPendingRecipe"
        recoverPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents recoverPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ShadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents PanelData As Guna.UI2.WinForms.Guna2Panel
End Class
