﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealCardStar
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        picMealImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        lblRates = New Guna.UI2.WinForms.Guna2HtmlLabel()
        mealRatings = New Guna.UI2.WinForms.Guna2RatingStar()
        lblNoOfRatings = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnView = New Guna.UI2.WinForms.Guna2Button()
        lblMealName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(picMealImage, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
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
        picMealImage.Size = New Size(197, 163)
        picMealImage.SizeMode = PictureBoxSizeMode.StretchImage
        picMealImage.TabIndex = 0
        picMealImage.TabStop = False
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 14
        Guna2Panel1.Controls.Add(lblRates)
        Guna2Panel1.Controls.Add(mealRatings)
        Guna2Panel1.Controls.Add(lblNoOfRatings)
        Guna2Panel1.Controls.Add(btnView)
        Guna2Panel1.Controls.Add(lblMealName)
        Guna2Panel1.Controls.Add(picMealImage)
        Guna2Panel1.CustomizableEdges = CustomizableEdges5
        Guna2Panel1.FillColor = Color.White
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.BorderRadius = 24
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel1.ShadowDecoration.Depth = 8
        Guna2Panel1.ShadowDecoration.Enabled = True
        Guna2Panel1.Size = New Size(197, 279)
        Guna2Panel1.TabIndex = 2
        ' 
        ' lblRates
        ' 
        lblRates.BackColor = Color.Transparent
        lblRates.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRates.Location = New Point(12, 203)
        lblRates.Name = "lblRates"
        lblRates.Size = New Size(23, 19)
        lblRates.TabIndex = 7
        lblRates.Text = "0.4"
        lblRates.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' mealRatings
        ' 
        mealRatings.Location = New Point(34, 199)
        mealRatings.Name = "mealRatings"
        mealRatings.RatingColor = Color.Gold
        mealRatings.ReadOnly = True
        mealRatings.Size = New Size(129, 27)
        mealRatings.TabIndex = 8
        ' 
        ' lblNoOfRatings
        ' 
        lblNoOfRatings.BackColor = Color.Transparent
        lblNoOfRatings.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNoOfRatings.Location = New Point(165, 202)
        lblNoOfRatings.Name = "lblNoOfRatings"
        lblNoOfRatings.Size = New Size(21, 19)
        lblNoOfRatings.TabIndex = 9
        lblNoOfRatings.Text = "(0)"
        lblNoOfRatings.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' btnView
        ' 
        btnView.Animated = True
        btnView.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnView.BorderRadius = 8
        btnView.BorderThickness = 2
        btnView.Cursor = Cursors.Hand
        btnView.CustomizableEdges = CustomizableEdges3
        btnView.DisabledState.BorderColor = Color.DarkGray
        btnView.DisabledState.CustomBorderColor = Color.DarkGray
        btnView.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnView.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnView.FillColor = Color.White
        btnView.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnView.ForeColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnView.Location = New Point(8, 227)
        btnView.Name = "btnView"
        btnView.ShadowDecoration.CustomizableEdges = CustomizableEdges4
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
        ' MealCardStar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Guna2Panel1)
        Name = "MealCardStar"
        Size = New Size(197, 319)
        CType(picMealImage, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picMealImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblNoOfRatings As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRates As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblMealName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents mealRatings As Guna.UI2.WinForms.Guna2RatingStar

End Class
