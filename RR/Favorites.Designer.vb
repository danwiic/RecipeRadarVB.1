<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Favorites
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lblFav = New Guna.UI2.WinForms.Guna2HtmlLabel()
        panelFav = New FlowLayoutPanel()
        btnPrev = New Guna.UI2.WinForms.Guna2Button()
        btnNext = New Guna.UI2.WinForms.Guna2Button()
        lblPage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblPages = New Guna.UI2.WinForms.Guna2HtmlLabel()
        SuspendLayout()
        ' 
        ' lblFav
        ' 
        lblFav.BackColor = Color.Transparent
        lblFav.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFav.ForeColor = SystemColors.ControlDarkDark
        lblFav.Location = New Point(13, 27)
        lblFav.Name = "lblFav"
        lblFav.Size = New Size(121, 40)
        lblFav.TabIndex = 7
        lblFav.Text = "Favorites"
        ' 
        ' panelFav
        ' 
        panelFav.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelFav.BackColor = Color.Transparent
        panelFav.Location = New Point(13, 73)
        panelFav.MaximumSize = New Size(1045, 1000)
        panelFav.Name = "panelFav"
        panelFav.Size = New Size(1021, 468)
        panelFav.TabIndex = 8
        ' 
        ' btnPrev
        ' 
        btnPrev.Anchor = AnchorStyles.Bottom
        btnPrev.Animated = True
        btnPrev.AutoRoundedCorners = True
        btnPrev.BorderRadius = 21
        btnPrev.Cursor = Cursors.Hand
        btnPrev.CustomizableEdges = CustomizableEdges5
        btnPrev.DisabledState.BorderColor = Color.DarkGray
        btnPrev.DisabledState.CustomBorderColor = Color.DarkGray
        btnPrev.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPrev.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPrev.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold)
        btnPrev.ForeColor = Color.White
        btnPrev.Location = New Point(275, 547)
        btnPrev.Name = "btnPrev"
        btnPrev.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnPrev.Size = New Size(180, 45)
        btnPrev.TabIndex = 11
        btnPrev.Text = "Previous"
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Bottom
        btnNext.Animated = True
        btnNext.AutoRoundedCorners = True
        btnNext.BorderRadius = 21
        btnNext.Cursor = Cursors.Hand
        btnNext.CustomizableEdges = CustomizableEdges7
        btnNext.DisabledState.BorderColor = Color.DarkGray
        btnNext.DisabledState.CustomBorderColor = Color.DarkGray
        btnNext.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNext.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnNext.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold)
        btnNext.ForeColor = Color.White
        btnNext.Location = New Point(591, 547)
        btnNext.Name = "btnNext"
        btnNext.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnNext.Size = New Size(180, 45)
        btnNext.TabIndex = 13
        btnNext.Text = "Next"
        ' 
        ' lblPage
        ' 
        lblPage.Anchor = AnchorStyles.Bottom
        lblPage.BackColor = Color.Transparent
        lblPage.Location = New Point(493, 20)
        lblPage.Name = "lblPage"
        lblPage.Size = New Size(61, 17)
        lblPage.TabIndex = 12
        lblPage.Text = "Page 1 of 1"
        ' 
        ' lblPages
        ' 
        lblPages.Anchor = AnchorStyles.Bottom
        lblPages.BackColor = Color.Transparent
        lblPages.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPages.Location = New Point(490, 560)
        lblPages.Name = "lblPages"
        lblPages.Size = New Size(69, 18)
        lblPages.TabIndex = 14
        lblPages.Text = "Page 1 of 1"
        ' 
        ' Favorites
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(lblPages)
        Controls.Add(btnNext)
        Controls.Add(btnPrev)
        Controls.Add(panelFav)
        Controls.Add(lblFav)
        MinimumSize = New Size(1047, 600)
        Name = "Favorites"
        Size = New Size(1047, 600)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFav As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents panelFav As FlowLayoutPanel
    Friend WithEvents btnPrev As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPages As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
