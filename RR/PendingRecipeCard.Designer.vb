<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PendingRecipeCard
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        picMealImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        approvePanel = New Guna.UI2.WinForms.Guna2Panel()
        btnReject = New Guna.UI2.WinForms.Guna2Button()
        btnAprrove = New Guna.UI2.WinForms.Guna2Button()
        btnView = New Guna.UI2.WinForms.Guna2Button()
        lblMealName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(picMealImage, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        approvePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' picMealImage
        ' 
        picMealImage.BorderRadius = 14
        CustomizableEdges1.BottomLeft = False
        CustomizableEdges1.BottomRight = False
        picMealImage.CustomizableEdges = CustomizableEdges1
        picMealImage.FillColor = Color.Transparent
        picMealImage.ImageRotate = 0F
        picMealImage.Location = New Point(0, 0)
        picMealImage.Name = "picMealImage"
        picMealImage.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        picMealImage.Size = New Size(194, 163)
        picMealImage.SizeMode = PictureBoxSizeMode.StretchImage
        picMealImage.TabIndex = 0
        picMealImage.TabStop = False
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 14
        Guna2Panel1.Controls.Add(approvePanel)
        Guna2Panel1.Controls.Add(btnView)
        Guna2Panel1.Controls.Add(lblMealName)
        Guna2Panel1.Controls.Add(picMealImage)
        Guna2Panel1.CustomizableEdges = CustomizableEdges11
        Guna2Panel1.FillColor = Color.White
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.BorderRadius = 24
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel1.ShadowDecoration.Depth = 8
        Guna2Panel1.ShadowDecoration.Enabled = True
        Guna2Panel1.Size = New Size(194, 279)
        Guna2Panel1.TabIndex = 3
        ' 
        ' approvePanel
        ' 
        approvePanel.Controls.Add(btnReject)
        approvePanel.Controls.Add(btnAprrove)
        approvePanel.CustomizableEdges = CustomizableEdges7
        approvePanel.Location = New Point(7, 189)
        approvePanel.Name = "approvePanel"
        approvePanel.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        approvePanel.Size = New Size(180, 32)
        approvePanel.TabIndex = 6
        ' 
        ' btnReject
        ' 
        btnReject.Animated = True
        btnReject.BorderRadius = 4
        btnReject.CustomizableEdges = CustomizableEdges3
        btnReject.DisabledState.BorderColor = Color.DarkGray
        btnReject.DisabledState.CustomBorderColor = Color.DarkGray
        btnReject.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnReject.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnReject.Dock = DockStyle.Left
        btnReject.FillColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnReject.Font = New Font("Segoe UI", 9F)
        btnReject.ForeColor = Color.White
        btnReject.Image = My.Resources.Resources.wrong
        btnReject.Location = New Point(0, 0)
        btnReject.Name = "btnReject"
        btnReject.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnReject.Size = New Size(86, 32)
        btnReject.TabIndex = 7
        ' 
        ' btnAprrove
        ' 
        btnAprrove.Animated = True
        btnAprrove.BorderRadius = 4
        btnAprrove.CustomizableEdges = CustomizableEdges5
        btnAprrove.DisabledState.BorderColor = Color.DarkGray
        btnAprrove.DisabledState.CustomBorderColor = Color.DarkGray
        btnAprrove.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAprrove.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAprrove.Dock = DockStyle.Right
        btnAprrove.FillColor = Color.LimeGreen
        btnAprrove.Font = New Font("Segoe UI", 9F)
        btnAprrove.ForeColor = Color.White
        btnAprrove.Image = My.Resources.Resources.check1
        btnAprrove.Location = New Point(94, 0)
        btnAprrove.Name = "btnAprrove"
        btnAprrove.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnAprrove.Size = New Size(86, 32)
        btnAprrove.TabIndex = 8
        ' 
        ' btnView
        ' 
        btnView.Animated = True
        btnView.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnView.BorderRadius = 8
        btnView.BorderThickness = 2
        btnView.Cursor = Cursors.Hand
        btnView.CustomizableEdges = CustomizableEdges9
        btnView.DisabledState.BorderColor = Color.DarkGray
        btnView.DisabledState.CustomBorderColor = Color.DarkGray
        btnView.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnView.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnView.FillColor = Color.White
        btnView.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnView.ForeColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnView.Location = New Point(7, 227)
        btnView.Name = "btnView"
        btnView.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnView.Size = New Size(180, 45)
        btnView.TabIndex = 5
        btnView.Text = "VIEW RECIPE"
        ' 
        ' lblMealName
        ' 
        lblMealName.BackColor = Color.Transparent
        lblMealName.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMealName.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblMealName.Location = New Point(7, 169)
        lblMealName.Name = "lblMealName"
        lblMealName.Size = New Size(88, 18)
        lblMealName.TabIndex = 1
        lblMealName.Text = "Recipe Name"
        ' 
        ' PendingRecipeCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Guna2Panel1)
        Name = "PendingRecipeCard"
        Size = New Size(198, 295)
        CType(picMealImage, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        approvePanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents picMealImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblMealName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents approvePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnReject As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAprrove As Guna.UI2.WinForms.Guna2Button

End Class
