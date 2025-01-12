﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PendingData
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
        txtIngredients = New Guna.UI2.WinForms.Guna2TextBox()
        Ingredients = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtInstructions = New Guna.UI2.WinForms.Guna2TextBox()
        Instructions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        flowPanelVideo = New FlowLayoutPanel()
        lblCategory = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblMealName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblOrigin = New Guna.UI2.WinForms.Guna2HtmlLabel()
        SuspendLayout()
        ' 
        ' txtIngredients
        ' 
        txtIngredients.Animated = True
        txtIngredients.BackColor = Color.Transparent
        txtIngredients.BorderColor = Color.Transparent
        txtIngredients.BorderThickness = 0
        txtIngredients.CustomizableEdges = CustomizableEdges1
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
        txtIngredients.Location = New Point(453, 237)
        txtIngredients.Margin = New Padding(3, 5, 3, 5)
        txtIngredients.Multiline = True
        txtIngredients.Name = "txtIngredients"
        txtIngredients.PasswordChar = ChrW(0)
        txtIngredients.PlaceholderText = ""
        txtIngredients.ReadOnly = True
        txtIngredients.SelectedText = ""
        txtIngredients.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtIngredients.Size = New Size(199, 258)
        txtIngredients.TabIndex = 45
        ' 
        ' Ingredients
        ' 
        Ingredients.BackColor = Color.Transparent
        Ingredients.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ingredients.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Ingredients.Location = New Point(453, 195)
        Ingredients.Name = "Ingredients"
        Ingredients.Size = New Size(152, 34)
        Ingredients.TabIndex = 44
        Ingredients.Text = "Ingredients"
        ' 
        ' txtInstructions
        ' 
        txtInstructions.Animated = True
        txtInstructions.AutoScroll = True
        txtInstructions.BackColor = Color.Transparent
        txtInstructions.BorderColor = Color.Transparent
        txtInstructions.BorderThickness = 0
        txtInstructions.CustomizableEdges = CustomizableEdges3
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
        txtInstructions.Location = New Point(15, 143)
        txtInstructions.Margin = New Padding(3, 4, 3, 4)
        txtInstructions.Multiline = True
        txtInstructions.Name = "txtInstructions"
        txtInstructions.PasswordChar = ChrW(0)
        txtInstructions.PlaceholderText = ""
        txtInstructions.ReadOnly = True
        txtInstructions.SelectedText = ""
        txtInstructions.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtInstructions.Size = New Size(423, 326)
        txtInstructions.TabIndex = 43
        ' 
        ' Instructions
        ' 
        Instructions.BackColor = Color.Transparent
        Instructions.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Instructions.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Instructions.Location = New Point(3, 102)
        Instructions.Name = "Instructions"
        Instructions.Size = New Size(161, 34)
        Instructions.TabIndex = 42
        Instructions.Text = "Instructions"
        ' 
        ' flowPanelVideo
        ' 
        flowPanelVideo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        flowPanelVideo.Location = New Point(478, 9)
        flowPanelVideo.Name = "flowPanelVideo"
        flowPanelVideo.Size = New Size(300, 180)
        flowPanelVideo.TabIndex = 41
        ' 
        ' lblCategory
        ' 
        lblCategory.BackColor = Color.Transparent
        lblCategory.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategory.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblCategory.Location = New Point(3, 44)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(101, 26)
        lblCategory.TabIndex = 40
        lblCategory.Text = "Category: "
        ' 
        ' lblMealName
        ' 
        lblMealName.BackColor = Color.Transparent
        lblMealName.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMealName.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblMealName.Location = New Point(3, 4)
        lblMealName.Name = "lblMealName"
        lblMealName.Size = New Size(146, 34)
        lblMealName.TabIndex = 39
        lblMealName.Text = "Meal Name"
        ' 
        ' lblOrigin
        ' 
        lblOrigin.BackColor = Color.Transparent
        lblOrigin.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrigin.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblOrigin.Location = New Point(3, 76)
        lblOrigin.Name = "lblOrigin"
        lblOrigin.Size = New Size(138, 26)
        lblOrigin.TabIndex = 46
        lblOrigin.Text = "Recipe Origin"
        ' 
        ' PendingData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(lblOrigin)
        Controls.Add(txtIngredients)
        Controls.Add(Ingredients)
        Controls.Add(txtInstructions)
        Controls.Add(Instructions)
        Controls.Add(flowPanelVideo)
        Controls.Add(lblCategory)
        Controls.Add(lblMealName)
        Name = "PendingData"
        Size = New Size(790, 507)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIngredients As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Ingredients As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtInstructions As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Instructions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents flowPanelVideo As FlowLayoutPanel
    Friend WithEvents lblCategory As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMealName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblOrigin As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
