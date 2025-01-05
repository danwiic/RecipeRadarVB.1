<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dashDisplayPanel = New Guna.UI2.WinForms.Guna2Panel()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        btnViewReported = New Guna.UI2.WinForms.Guna2Button()
        btnViewManage = New Guna.UI2.WinForms.Guna2Button()
        btnViewPending = New Guna.UI2.WinForms.Guna2Button()
        btnViewOverview = New Guna.UI2.WinForms.Guna2Button()
        Guna2GradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dashDisplayPanel
        ' 
        dashDisplayPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dashDisplayPanel.AutoScroll = True
        dashDisplayPanel.CustomizableEdges = CustomizableEdges1
        dashDisplayPanel.Location = New Point(3, 51)
        dashDisplayPanel.MaximumSize = New Size(1041, 1100)
        dashDisplayPanel.Name = "dashDisplayPanel"
        dashDisplayPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        dashDisplayPanel.Size = New Size(1041, 546)
        dashDisplayPanel.TabIndex = 1
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.BackColor = Color.Transparent
        Guna2GradientPanel1.BorderRadius = 12
        Guna2GradientPanel1.Controls.Add(btnViewReported)
        Guna2GradientPanel1.Controls.Add(btnViewManage)
        Guna2GradientPanel1.Controls.Add(btnViewPending)
        Guna2GradientPanel1.Controls.Add(btnViewOverview)
        CustomizableEdges11.TopLeft = False
        CustomizableEdges11.TopRight = False
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges11
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2GradientPanel1.Location = New Point(162, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2GradientPanel1.Size = New Size(722, 51)
        Guna2GradientPanel1.TabIndex = 2
        ' 
        ' btnViewReported
        ' 
        btnViewReported.Animated = True
        btnViewReported.Cursor = Cursors.Hand
        btnViewReported.CustomizableEdges = CustomizableEdges3
        btnViewReported.DisabledState.BorderColor = Color.DarkGray
        btnViewReported.DisabledState.CustomBorderColor = Color.DarkGray
        btnViewReported.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnViewReported.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnViewReported.Dock = DockStyle.Right
        btnViewReported.FillColor = Color.Transparent
        btnViewReported.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewReported.ForeColor = Color.White
        btnViewReported.Location = New Point(542, 0)
        btnViewReported.Name = "btnViewReported"
        btnViewReported.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnViewReported.Size = New Size(180, 51)
        btnViewReported.TabIndex = 8
        btnViewReported.Text = "REPORTED ACCOUNTS"
        ' 
        ' btnViewManage
        ' 
        btnViewManage.Animated = True
        btnViewManage.Cursor = Cursors.Hand
        btnViewManage.CustomizableEdges = CustomizableEdges5
        btnViewManage.DisabledState.BorderColor = Color.DarkGray
        btnViewManage.DisabledState.CustomBorderColor = Color.DarkGray
        btnViewManage.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnViewManage.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnViewManage.Dock = DockStyle.Left
        btnViewManage.FillColor = Color.Transparent
        btnViewManage.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewManage.ForeColor = Color.White
        btnViewManage.Location = New Point(360, 0)
        btnViewManage.Name = "btnViewManage"
        btnViewManage.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnViewManage.Size = New Size(185, 51)
        btnViewManage.TabIndex = 7
        btnViewManage.Text = "MANAGE USERS"
        ' 
        ' btnViewPending
        ' 
        btnViewPending.Animated = True
        btnViewPending.Cursor = Cursors.Hand
        btnViewPending.CustomizableEdges = CustomizableEdges7
        btnViewPending.DisabledState.BorderColor = Color.DarkGray
        btnViewPending.DisabledState.CustomBorderColor = Color.DarkGray
        btnViewPending.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnViewPending.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnViewPending.Dock = DockStyle.Left
        btnViewPending.FillColor = Color.Transparent
        btnViewPending.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewPending.ForeColor = Color.White
        btnViewPending.Location = New Point(180, 0)
        btnViewPending.Name = "btnViewPending"
        btnViewPending.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnViewPending.Size = New Size(180, 51)
        btnViewPending.TabIndex = 6
        btnViewPending.Text = "PENDING RECIPE"
        ' 
        ' btnViewOverview
        ' 
        btnViewOverview.Animated = True
        btnViewOverview.Cursor = Cursors.Hand
        btnViewOverview.CustomizableEdges = CustomizableEdges9
        btnViewOverview.DisabledState.BorderColor = Color.DarkGray
        btnViewOverview.DisabledState.CustomBorderColor = Color.DarkGray
        btnViewOverview.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnViewOverview.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnViewOverview.Dock = DockStyle.Left
        btnViewOverview.FillColor = Color.Transparent
        btnViewOverview.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewOverview.ForeColor = Color.White
        btnViewOverview.Location = New Point(0, 0)
        btnViewOverview.Name = "btnViewOverview"
        btnViewOverview.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnViewOverview.Size = New Size(180, 51)
        btnViewOverview.TabIndex = 5
        btnViewOverview.Text = "OVERVIEW"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2GradientPanel1)
        Controls.Add(dashDisplayPanel)
        MinimumSize = New Size(1047, 600)
        Name = "Dashboard"
        Size = New Size(1047, 600)
        Guna2GradientPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents dashDisplayPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnViewReported As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewManage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewPending As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewOverview As Guna.UI2.WinForms.Guna2Button

End Class
