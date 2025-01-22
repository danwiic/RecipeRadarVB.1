<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        FlowLayoutPanelMeals = New FlowLayoutPanel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnNext = New Guna.UI2.WinForms.Guna2Button()
        lblPages = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnPrev = New Guna.UI2.WinForms.Guna2Button()
        cbCategories = New Guna.UI2.WinForms.Guna2ComboBox()
        lblFilter = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanelMeals
        ' 
        FlowLayoutPanelMeals.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanelMeals.Location = New Point(13, 111)
        FlowLayoutPanelMeals.Name = "FlowLayoutPanelMeals"
        FlowLayoutPanelMeals.Size = New Size(1020, 420)
        FlowLayoutPanelMeals.TabIndex = 1
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.Controls.Add(btnNext)
        Guna2Panel1.Controls.Add(lblPages)
        Guna2Panel1.Controls.Add(btnPrev)
        Guna2Panel1.CustomizableEdges = CustomizableEdges5
        Guna2Panel1.Dock = DockStyle.Bottom
        Guna2Panel1.Location = New Point(0, 537)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel1.Size = New Size(1047, 63)
        Guna2Panel1.TabIndex = 11
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Bottom
        btnNext.Animated = True
        btnNext.AutoRoundedCorners = True
        btnNext.BorderRadius = 21
        btnNext.Cursor = Cursors.Hand
        btnNext.CustomizableEdges = CustomizableEdges1
        btnNext.DisabledState.BorderColor = Color.DarkGray
        btnNext.DisabledState.CustomBorderColor = Color.DarkGray
        btnNext.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNext.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnNext.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold)
        btnNext.ForeColor = Color.White
        btnNext.Location = New Point(564, 12)
        btnNext.Name = "btnNext"
        btnNext.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnNext.Size = New Size(180, 45)
        btnNext.TabIndex = 13
        btnNext.Text = "Next"
        ' 
        ' lblPages
        ' 
        lblPages.Anchor = AnchorStyles.Bottom
        lblPages.BackColor = Color.Transparent
        lblPages.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPages.Location = New Point(489, 27)
        lblPages.Name = "lblPages"
        lblPages.Size = New Size(69, 18)
        lblPages.TabIndex = 12
        lblPages.Text = "Page 1 of 1"
        ' 
        ' btnPrev
        ' 
        btnPrev.Anchor = AnchorStyles.Bottom
        btnPrev.Animated = True
        btnPrev.AutoRoundedCorners = True
        btnPrev.BorderRadius = 21
        btnPrev.Cursor = Cursors.Hand
        btnPrev.CustomizableEdges = CustomizableEdges3
        btnPrev.DisabledState.BorderColor = Color.DarkGray
        btnPrev.DisabledState.CustomBorderColor = Color.DarkGray
        btnPrev.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPrev.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPrev.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold)
        btnPrev.ForeColor = Color.White
        btnPrev.Location = New Point(303, 12)
        btnPrev.Name = "btnPrev"
        btnPrev.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnPrev.Size = New Size(180, 45)
        btnPrev.TabIndex = 11
        btnPrev.Text = "Previous"
        ' 
        ' cbCategories
        ' 
        cbCategories.BackColor = Color.Transparent
        cbCategories.CustomizableEdges = CustomizableEdges7
        cbCategories.DrawMode = DrawMode.OwnerDrawFixed
        cbCategories.DropDownHeight = 150
        cbCategories.DropDownStyle = ComboBoxStyle.DropDownList
        cbCategories.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbCategories.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbCategories.Font = New Font("Segoe UI", 10F)
        cbCategories.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbCategories.IntegralHeight = False
        cbCategories.ItemHeight = 30
        cbCategories.Location = New Point(226, 38)
        cbCategories.Name = "cbCategories"
        cbCategories.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        cbCategories.Size = New Size(234, 36)
        cbCategories.TabIndex = 12
        ' 
        ' lblFilter
        ' 
        lblFilter.BackColor = Color.Transparent
        lblFilter.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFilter.ForeColor = SystemColors.ControlDarkDark
        lblFilter.Location = New Point(13, 34)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(207, 40)
        lblFilter.TabIndex = 13
        lblFilter.Text = "Select Category"
        ' 
        ' Categories
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblFilter)
        Controls.Add(cbCategories)
        Controls.Add(Guna2Panel1)
        Controls.Add(FlowLayoutPanelMeals)
        DoubleBuffered = True
        Name = "Categories"
        Size = New Size(1047, 600)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents FlowLayoutPanelMeals As FlowLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPages As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnPrev As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbCategories As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblFilter As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
