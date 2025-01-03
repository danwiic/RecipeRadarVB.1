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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        picMealImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnView = New Guna.UI2.WinForms.Guna2Button()
        lblMealName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        approvePanel = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        CType(picMealImage, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        approvePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' picMealImage
        ' 
        picMealImage.BorderRadius = 14
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
        Guna2Panel1.FillColor = Color.WhiteSmoke
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.BorderRadius = 24
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel1.ShadowDecoration.Depth = 8
        Guna2Panel1.ShadowDecoration.Enabled = True
        Guna2Panel1.Size = New Size(194, 279)
        Guna2Panel1.TabIndex = 3
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
        btnView.FillColor = Color.WhiteSmoke
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
        lblMealName.Location = New Point(12, 170)
        lblMealName.Name = "lblMealName"
        lblMealName.Size = New Size(88, 18)
        lblMealName.TabIndex = 1
        lblMealName.Text = "Recipe Name"
        ' 
        ' approvePanel
        ' 
        approvePanel.Controls.Add(Guna2Button1)
        approvePanel.Controls.Add(Guna2Button2)
        approvePanel.CustomizableEdges = CustomizableEdges7
        approvePanel.Location = New Point(7, 189)
        approvePanel.Name = "approvePanel"
        approvePanel.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        approvePanel.Size = New Size(180, 32)
        approvePanel.TabIndex = 6
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Dock = DockStyle.Left
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(0, 0)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(86, 32)
        Guna2Button1.TabIndex = 7
        Guna2Button1.Text = "Guna2Button1"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges5
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Dock = DockStyle.Right
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(94, 0)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button2.Size = New Size(86, 32)
        Guna2Button2.TabIndex = 8
        Guna2Button2.Text = "Guna2Button2"
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
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button

End Class
