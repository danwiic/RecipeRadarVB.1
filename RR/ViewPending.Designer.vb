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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        recoverPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        ViewPendingPanel = New FlowLayoutPanel()
        ShadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        lblRecipeHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblStatusHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblActionHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        recoverPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' recoverPanel
        ' 
        recoverPanel.BackColor = Color.Transparent
        recoverPanel.Controls.Add(Guna2HtmlLabel8)
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
        ' Guna2HtmlLabel8
        ' 
        Guna2HtmlLabel8.BackColor = Color.Transparent
        Guna2HtmlLabel8.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel8.Location = New Point(3, 2)
        Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Guna2HtmlLabel8.Size = New Size(143, 21)
        Guna2HtmlLabel8.TabIndex = 51
        Guna2HtmlLabel8.Text = "Pending Recipe Status"
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
        Guna2Button1.Location = New Point(439, 0)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(45, 25)
        Guna2Button1.TabIndex = 10
        Guna2Button1.Text = "✕"
        ' 
        ' ViewPendingPanel
        ' 
        ViewPendingPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ViewPendingPanel.AutoScroll = True
        ViewPendingPanel.Location = New Point(0, 63)
        ViewPendingPanel.Name = "ViewPendingPanel"
        ViewPendingPanel.Size = New Size(484, 310)
        ViewPendingPanel.TabIndex = 18
        ' 
        ' lblRecipeHeader
        ' 
        lblRecipeHeader.BackColor = Color.White
        lblRecipeHeader.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        lblRecipeHeader.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblRecipeHeader.Location = New Point(12, 37)
        lblRecipeHeader.Name = "lblRecipeHeader"
        lblRecipeHeader.Size = New Size(97, 20)
        lblRecipeHeader.TabIndex = 19
        lblRecipeHeader.Text = "Recipe Name"
        ' 
        ' lblStatusHeader
        ' 
        lblStatusHeader.BackColor = Color.White
        lblStatusHeader.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        lblStatusHeader.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblStatusHeader.Location = New Point(185, 37)
        lblStatusHeader.Name = "lblStatusHeader"
        lblStatusHeader.Size = New Size(102, 20)
        lblStatusHeader.TabIndex = 20
        lblStatusHeader.Text = "Recipe Status"
        ' 
        ' lblActionHeader
        ' 
        lblActionHeader.BackColor = Color.White
        lblActionHeader.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        lblActionHeader.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblActionHeader.Location = New Point(356, 37)
        lblActionHeader.Name = "lblActionHeader"
        lblActionHeader.Size = New Size(47, 20)
        lblActionHeader.TabIndex = 21
        lblActionHeader.Text = "Action"
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.ControlDarkDark
        lblStatus.Location = New Point(12, 31)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(157, 31)
        lblStatus.TabIndex = 15
        lblStatus.Text = "Reported Users"
        ' 
        ' ViewPending
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(484, 370)
        Controls.Add(lblActionHeader)
        Controls.Add(lblStatusHeader)
        Controls.Add(lblRecipeHeader)
        Controls.Add(ViewPendingPanel)
        Controls.Add(recoverPanel)
        Controls.Add(lblStatus)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewPending"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewPending"
        recoverPanel.ResumeLayout(False)
        recoverPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents recoverPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ViewPendingPanel As FlowLayoutPanel
    Friend WithEvents ShadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents lblRecipeHeader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStatusHeader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblActionHeader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
