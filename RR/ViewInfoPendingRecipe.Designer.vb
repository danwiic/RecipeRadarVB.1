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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        recoverPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        ShadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        lblCategory = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblMealName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        flowPanelVideo = New FlowLayoutPanel()
        txtIngredients = New Guna.UI2.WinForms.Guna2TextBox()
        Ingredients = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtInstructions = New Guna.UI2.WinForms.Guna2TextBox()
        Instructions = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        ' lblCategory
        ' 
        lblCategory.BackColor = Color.Transparent
        lblCategory.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategory.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblCategory.Location = New Point(12, 90)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(101, 26)
        lblCategory.TabIndex = 33
        lblCategory.Text = "Category: "
        ' 
        ' lblMealName
        ' 
        lblMealName.BackColor = Color.Transparent
        lblMealName.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMealName.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblMealName.Location = New Point(12, 31)
        lblMealName.Name = "lblMealName"
        lblMealName.Size = New Size(146, 34)
        lblMealName.TabIndex = 32
        lblMealName.Text = "Meal Name"
        ' 
        ' flowPanelVideo
        ' 
        flowPanelVideo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        flowPanelVideo.Location = New Point(478, 31)
        flowPanelVideo.Name = "flowPanelVideo"
        flowPanelVideo.Size = New Size(300, 180)
        flowPanelVideo.TabIndex = 34
        ' 
        ' txtIngredients
        ' 
        txtIngredients.Animated = True
        txtIngredients.BackColor = Color.Transparent
        txtIngredients.BorderColor = Color.Transparent
        txtIngredients.BorderThickness = 0
        txtIngredients.CustomizableEdges = CustomizableEdges3
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
        txtIngredients.Location = New Point(453, 246)
        txtIngredients.Margin = New Padding(3, 5, 3, 5)
        txtIngredients.Multiline = True
        txtIngredients.Name = "txtIngredients"
        txtIngredients.PasswordChar = ChrW(0)
        txtIngredients.PlaceholderText = ""
        txtIngredients.ReadOnly = True
        txtIngredients.SelectedText = ""
        txtIngredients.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtIngredients.Size = New Size(199, 199)
        txtIngredients.TabIndex = 38
        ' 
        ' Ingredients
        ' 
        Ingredients.BackColor = Color.Transparent
        Ingredients.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ingredients.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Ingredients.Location = New Point(453, 216)
        Ingredients.Name = "Ingredients"
        Ingredients.Size = New Size(152, 34)
        Ingredients.TabIndex = 37
        Ingredients.Text = "Ingredients"
        ' 
        ' txtInstructions
        ' 
        txtInstructions.Animated = True
        txtInstructions.AutoScroll = True
        txtInstructions.BackColor = Color.Transparent
        txtInstructions.BorderColor = Color.Transparent
        txtInstructions.BorderThickness = 0
        txtInstructions.CustomizableEdges = CustomizableEdges5
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
        txtInstructions.Location = New Point(12, 200)
        txtInstructions.Margin = New Padding(3, 4, 3, 4)
        txtInstructions.Multiline = True
        txtInstructions.Name = "txtInstructions"
        txtInstructions.PasswordChar = ChrW(0)
        txtInstructions.PlaceholderText = ""
        txtInstructions.ReadOnly = True
        txtInstructions.SelectedText = ""
        txtInstructions.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtInstructions.Size = New Size(435, 245)
        txtInstructions.TabIndex = 36
        ' 
        ' Instructions
        ' 
        Instructions.BackColor = Color.Transparent
        Instructions.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Instructions.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Instructions.Location = New Point(12, 159)
        Instructions.Name = "Instructions"
        Instructions.Size = New Size(161, 34)
        Instructions.TabIndex = 35
        Instructions.Text = "Instructions"
        ' 
        ' ViewInfoPendingRecipe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(790, 459)
        Controls.Add(txtIngredients)
        Controls.Add(Ingredients)
        Controls.Add(txtInstructions)
        Controls.Add(Instructions)
        Controls.Add(flowPanelVideo)
        Controls.Add(lblCategory)
        Controls.Add(lblMealName)
        Controls.Add(recoverPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewInfoPendingRecipe"
        Text = "ViewInfoPendingRecipe"
        recoverPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents recoverPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ShadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents lblCategory As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMealName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents flowPanelVideo As FlowLayoutPanel
    Friend WithEvents txtIngredients As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Ingredients As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtInstructions As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Instructions As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
