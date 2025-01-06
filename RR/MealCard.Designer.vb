<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealCard
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnView = New Guna.UI2.WinForms.Guna2Button()
        lblFavoriteCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblMealCategory = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblMealName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        picMealImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Panel1.SuspendLayout()
        CType(picMealImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 14
        Guna2Panel1.Controls.Add(btnView)
        Guna2Panel1.Controls.Add(lblFavoriteCount)
        Guna2Panel1.Controls.Add(lblMealCategory)
        Guna2Panel1.Controls.Add(Guna2HtmlLabel2)
        Guna2Panel1.Controls.Add(lblMealName)
        Guna2Panel1.Controls.Add(picMealImage)
        Guna2Panel1.CustomizableEdges = CustomizableEdges5
        Guna2Panel1.FillColor = Color.WhiteSmoke
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.BorderRadius = 24
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel1.ShadowDecoration.Depth = 8
        Guna2Panel1.ShadowDecoration.Enabled = True
        Guna2Panel1.Size = New Size(197, 279)
        Guna2Panel1.TabIndex = 0
        ' 
        ' btnView
        ' 
        btnView.Animated = True
        btnView.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnView.BorderRadius = 8
        btnView.BorderThickness = 2
        btnView.Cursor = Cursors.Hand
        btnView.CustomizableEdges = CustomizableEdges1
        btnView.DisabledState.BorderColor = Color.DarkGray
        btnView.DisabledState.CustomBorderColor = Color.DarkGray
        btnView.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnView.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnView.FillColor = Color.WhiteSmoke
        btnView.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnView.ForeColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnView.Location = New Point(8, 227)
        btnView.Name = "btnView"
        btnView.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnView.Size = New Size(180, 45)
        btnView.TabIndex = 5
        btnView.Text = "VIEW RECIPE"
        ' 
        ' lblFavoriteCount
        ' 
        lblFavoriteCount.BackColor = Color.Transparent
        lblFavoriteCount.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFavoriteCount.Location = New Point(88, 203)
        lblFavoriteCount.Name = "lblFavoriteCount"
        lblFavoriteCount.Size = New Size(10, 18)
        lblFavoriteCount.TabIndex = 4
        lblFavoriteCount.Text = "0"
        ' 
        ' lblMealCategory
        ' 
        lblMealCategory.BackColor = Color.Transparent
        lblMealCategory.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMealCategory.Location = New Point(119, 203)
        lblMealCategory.Name = "lblMealCategory"
        lblMealCategory.Size = New Size(60, 18)
        lblMealCategory.TabIndex = 3
        lblMealCategory.Text = "Category"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.Location = New Point(12, 203)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(73, 18)
        Guna2HtmlLabel2.TabIndex = 2
        Guna2HtmlLabel2.Text = "Favorites of: "
        ' 
        ' lblMealName
        ' 
        lblMealName.BackColor = Color.Transparent
        lblMealName.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMealName.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblMealName.Location = New Point(12, 178)
        lblMealName.Name = "lblMealName"
        lblMealName.Size = New Size(88, 18)
        lblMealName.TabIndex = 1
        lblMealName.Text = "Recipe Name"
        ' 
        ' picMealImage
        ' 
        picMealImage.BorderRadius = 14
        CustomizableEdges3.BottomLeft = False
        CustomizableEdges3.BottomRight = False
        picMealImage.CustomizableEdges = CustomizableEdges3
        picMealImage.FillColor = Color.Transparent
        picMealImage.ImageRotate = 0F
        picMealImage.Location = New Point(0, 0)
        picMealImage.Name = "picMealImage"
        picMealImage.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        picMealImage.Size = New Size(197, 163)
        picMealImage.SizeMode = PictureBoxSizeMode.StretchImage
        picMealImage.TabIndex = 0
        picMealImage.TabStop = False
        ' 
        ' MealCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Guna2Panel1)
        Name = "MealCard"
        Size = New Size(197, 319)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(picMealImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents picMealImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblFavoriteCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMealCategory As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMealName As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
