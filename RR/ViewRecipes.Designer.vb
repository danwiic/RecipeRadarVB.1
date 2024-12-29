<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRecipe
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        flowPanelVideo = New FlowLayoutPanel()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        lblMealName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblRating = New Guna.UI2.WinForms.Guna2HtmlLabel()
        rating = New Guna.UI2.WinForms.Guna2RatingStar()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        lblTotalUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnFav = New Guna.UI2.WinForms.Guna2Button()
        btnRate = New Guna.UI2.WinForms.Guna2Button()
        Instructions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtInstructions = New Guna.UI2.WinForms.Guna2TextBox()
        Ingredients = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtIngredients = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CommentPanel = New FlowLayoutPanel()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        lblCategory = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' flowPanelVideo
        ' 
        flowPanelVideo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        flowPanelVideo.Location = New Point(612, 12)
        flowPanelVideo.Name = "flowPanelVideo"
        flowPanelVideo.Size = New Size(423, 300)
        flowPanelVideo.TabIndex = 3
        ' 
        ' btnBack
        ' 
        btnBack.Animated = True
        btnBack.AutoRoundedCorners = True
        btnBack.BorderRadius = 21
        btnBack.Cursor = Cursors.Hand
        btnBack.CustomizableEdges = CustomizableEdges1
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(17, 12)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(180, 45)
        btnBack.TabIndex = 15
        btnBack.Text = "BACK"
        ' 
        ' lblMealName
        ' 
        lblMealName.BackColor = Color.Transparent
        lblMealName.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMealName.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblMealName.Location = New Point(20, 99)
        lblMealName.Name = "lblMealName"
        lblMealName.Size = New Size(146, 34)
        lblMealName.TabIndex = 16
        lblMealName.Text = "Meal Name"
        ' 
        ' lblRating
        ' 
        lblRating.BackColor = Color.Transparent
        lblRating.Dock = DockStyle.Left
        lblRating.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRating.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblRating.Location = New Point(0, 0)
        lblRating.Name = "lblRating"
        lblRating.Size = New Size(18, 34)
        lblRating.TabIndex = 17
        lblRating.Text = "0"
        ' 
        ' rating
        ' 
        rating.Dock = DockStyle.Fill
        rating.Location = New Point(18, 0)
        rating.Name = "rating"
        rating.RatingColor = Color.Gold
        rating.ReadOnly = True
        rating.Size = New Size(189, 34)
        rating.TabIndex = 19
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(rating)
        Guna2Panel1.Controls.Add(lblRating)
        Guna2Panel1.Controls.Add(lblTotalUser)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Location = New Point(20, 194)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(243, 34)
        Guna2Panel1.TabIndex = 21
        ' 
        ' lblTotalUser
        ' 
        lblTotalUser.BackColor = Color.Transparent
        lblTotalUser.Dock = DockStyle.Right
        lblTotalUser.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalUser.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblTotalUser.Location = New Point(207, 0)
        lblTotalUser.Name = "lblTotalUser"
        lblTotalUser.Size = New Size(36, 34)
        lblTotalUser.TabIndex = 22
        lblTotalUser.Text = "(0)"
        ' 
        ' btnFav
        ' 
        btnFav.Animated = True
        btnFav.BorderRadius = 8
        btnFav.Cursor = Cursors.Hand
        btnFav.CustomizableEdges = CustomizableEdges5
        btnFav.DisabledState.BorderColor = Color.DarkGray
        btnFav.DisabledState.CustomBorderColor = Color.DarkGray
        btnFav.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnFav.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnFav.FillColor = Color.Red
        btnFav.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFav.ForeColor = Color.White
        btnFav.Image = My.Resources.Resources.favorite
        btnFav.Location = New Point(20, 247)
        btnFav.Name = "btnFav"
        btnFav.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnFav.Size = New Size(180, 45)
        btnFav.TabIndex = 22
        btnFav.Text = "Add to Favorites"
        ' 
        ' btnRate
        ' 
        btnRate.Animated = True
        btnRate.BorderRadius = 8
        btnRate.Cursor = Cursors.Hand
        btnRate.CustomizableEdges = CustomizableEdges7
        btnRate.DisabledState.BorderColor = Color.DarkGray
        btnRate.DisabledState.CustomBorderColor = Color.DarkGray
        btnRate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRate.FillColor = Color.Gold
        btnRate.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRate.ForeColor = Color.White
        btnRate.Image = My.Resources.Resources.star
        btnRate.Location = New Point(206, 247)
        btnRate.Name = "btnRate"
        btnRate.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnRate.Size = New Size(180, 45)
        btnRate.TabIndex = 23
        btnRate.Text = "Rate Meal"
        ' 
        ' Instructions
        ' 
        Instructions.BackColor = Color.Transparent
        Instructions.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Instructions.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Instructions.Location = New Point(17, 319)
        Instructions.Name = "Instructions"
        Instructions.Size = New Size(161, 34)
        Instructions.TabIndex = 24
        Instructions.Text = "Instructions"
        ' 
        ' txtInstructions
        ' 
        txtInstructions.Animated = True
        txtInstructions.AutoScroll = True
        txtInstructions.BackColor = Color.Transparent
        txtInstructions.BorderColor = Color.Transparent
        txtInstructions.BorderThickness = 0
        txtInstructions.CustomizableEdges = CustomizableEdges9
        txtInstructions.DefaultText = ""
        txtInstructions.DisabledState.BorderColor = Color.Transparent
        txtInstructions.DisabledState.FillColor = Color.Transparent
        txtInstructions.DisabledState.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtInstructions.DisabledState.PlaceholderForeColor = Color.Transparent
        txtInstructions.Enabled = False
        txtInstructions.FillColor = SystemColors.Control
        txtInstructions.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtInstructions.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInstructions.ForeColor = Color.Black
        txtInstructions.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtInstructions.Location = New Point(17, 349)
        txtInstructions.Margin = New Padding(3, 4, 3, 4)
        txtInstructions.Multiline = True
        txtInstructions.Name = "txtInstructions"
        txtInstructions.PasswordChar = ChrW(0)
        txtInstructions.PlaceholderText = ""
        txtInstructions.ReadOnly = True
        txtInstructions.SelectedText = ""
        txtInstructions.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtInstructions.Size = New Size(435, 545)
        txtInstructions.TabIndex = 25
        ' 
        ' Ingredients
        ' 
        Ingredients.BackColor = Color.Transparent
        Ingredients.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ingredients.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Ingredients.Location = New Point(458, 319)
        Ingredients.Name = "Ingredients"
        Ingredients.Size = New Size(152, 34)
        Ingredients.TabIndex = 26
        Ingredients.Text = "Ingredients"
        ' 
        ' txtIngredients
        ' 
        txtIngredients.Animated = True
        txtIngredients.BackColor = Color.Transparent
        txtIngredients.BorderColor = Color.Transparent
        txtIngredients.BorderThickness = 0
        txtIngredients.CustomizableEdges = CustomizableEdges11
        txtIngredients.DefaultText = ""
        txtIngredients.DisabledState.BorderColor = Color.Transparent
        txtIngredients.DisabledState.FillColor = Color.Transparent
        txtIngredients.DisabledState.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtIngredients.DisabledState.PlaceholderForeColor = Color.Transparent
        txtIngredients.Enabled = False
        txtIngredients.FillColor = SystemColors.Control
        txtIngredients.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtIngredients.Font = New Font("Arial Narrow", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtIngredients.ForeColor = Color.Black
        txtIngredients.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtIngredients.Location = New Point(458, 349)
        txtIngredients.Margin = New Padding(3, 5, 3, 5)
        txtIngredients.Multiline = True
        txtIngredients.Name = "txtIngredients"
        txtIngredients.PasswordChar = ChrW(0)
        txtIngredients.PlaceholderText = ""
        txtIngredients.ReadOnly = True
        txtIngredients.SelectedText = ""
        txtIngredients.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txtIngredients.Size = New Size(199, 391)
        txtIngredients.TabIndex = 27
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel1.Location = New Point(663, 319)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(148, 34)
        Guna2HtmlLabel1.TabIndex = 28
        Guna2HtmlLabel1.Text = "Comments"
        ' 
        ' CommentPanel
        ' 
        CommentPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        CommentPanel.FlowDirection = FlowDirection.TopDown
        CommentPanel.Location = New Point(663, 349)
        CommentPanel.Name = "CommentPanel"
        CommentPanel.Size = New Size(372, 495)
        CommentPanel.TabIndex = 29
        ' 
        ' btnDelete
        ' 
        btnDelete.Animated = True
        btnDelete.BorderRadius = 8
        btnDelete.Cursor = Cursors.Hand
        btnDelete.CustomizableEdges = CustomizableEdges13
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Red
        btnDelete.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.delete_white
        btnDelete.Location = New Point(392, 247)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnDelete.Size = New Size(180, 45)
        btnDelete.TabIndex = 30
        btnDelete.Text = "Delete Meal"
        ' 
        ' lblCategory
        ' 
        lblCategory.BackColor = Color.Transparent
        lblCategory.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategory.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblCategory.Location = New Point(20, 151)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(101, 26)
        lblCategory.TabIndex = 31
        lblCategory.Text = "Category: "
        ' 
        ' ViewRecipe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(lblCategory)
        Controls.Add(btnDelete)
        Controls.Add(CommentPanel)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(txtIngredients)
        Controls.Add(Ingredients)
        Controls.Add(txtInstructions)
        Controls.Add(Instructions)
        Controls.Add(btnRate)
        Controls.Add(btnFav)
        Controls.Add(Guna2Panel1)
        Controls.Add(lblMealName)
        Controls.Add(btnBack)
        Controls.Add(flowPanelVideo)
        MinimumSize = New Size(1047, 600)
        Name = "ViewRecipe"
        Size = New Size(1047, 909)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flowPanelVideo As FlowLayoutPanel
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblMealName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRating As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents rating As Guna.UI2.WinForms.Guna2RatingStar
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnFav As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Instructions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtInstructions As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Ingredients As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtIngredients As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CommentPanel As FlowLayoutPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCategory As Guna.UI2.WinForms.Guna2HtmlLabel


End Class
