<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meals
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
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnNext = New Guna.UI2.WinForms.Guna2Button()
        lblPage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnPrev = New Guna.UI2.WinForms.Guna2Button()
        panelAddedMeals = New FlowLayoutPanel()
        lblMessage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblMeals = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.Controls.Add(btnNext)
        Guna2Panel1.Controls.Add(lblPage)
        Guna2Panel1.Controls.Add(btnPrev)
        Guna2Panel1.CustomizableEdges = CustomizableEdges5
        Guna2Panel1.Dock = DockStyle.Bottom
        Guna2Panel1.Location = New Point(0, 540)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel1.Size = New Size(1047, 60)
        Guna2Panel1.TabIndex = 9
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
        btnNext.Location = New Point(595, 8)
        btnNext.Name = "btnNext"
        btnNext.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnNext.Size = New Size(180, 45)
        btnNext.TabIndex = 13
        btnNext.Text = "Next"
        ' 
        ' lblPage
        ' 
        lblPage.Anchor = AnchorStyles.Bottom
        lblPage.BackColor = Color.Transparent
        lblPage.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPage.Location = New Point(489, 20)
        lblPage.Name = "lblPage"
        lblPage.Size = New Size(69, 18)
        lblPage.TabIndex = 12
        lblPage.Text = "Page 1 of 1"
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
        btnPrev.Location = New Point(271, 8)
        btnPrev.Name = "btnPrev"
        btnPrev.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnPrev.Size = New Size(180, 45)
        btnPrev.TabIndex = 11
        btnPrev.Text = "Previous"
        ' 
        ' panelAddedMeals
        ' 
        panelAddedMeals.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelAddedMeals.BackColor = Color.Transparent
        panelAddedMeals.Location = New Point(13, 60)
        panelAddedMeals.MaximumSize = New Size(1045, 1000)
        panelAddedMeals.Name = "panelAddedMeals"
        panelAddedMeals.Size = New Size(1021, 461)
        panelAddedMeals.TabIndex = 11
        ' 
        ' lblMessage
        ' 
        lblMessage.BackColor = Color.Transparent
        lblMessage.Font = New Font("Comic Sans MS", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblMessage.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblMessage.Location = New Point(13, 113)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(196, 36)
        lblMessage.TabIndex = 12
        lblMessage.Text = "Guna2HtmlLabel1"
        ' 
        ' lblMeals
        ' 
        lblMeals.BackColor = Color.Transparent
        lblMeals.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMeals.ForeColor = SystemColors.ControlDarkDark
        lblMeals.Location = New Point(13, 14)
        lblMeals.Name = "lblMeals"
        lblMeals.Size = New Size(75, 40)
        lblMeals.TabIndex = 10
        lblMeals.Text = "Meals"
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.Animated = True
        btnAdd.AutoRoundedCorners = True
        btnAdd.BorderRadius = 21
        btnAdd.Cursor = Cursors.Hand
        btnAdd.CustomizableEdges = CustomizableEdges7
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(854, 9)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAdd.Size = New Size(180, 45)
        btnAdd.TabIndex = 14
        btnAdd.Text = "ADD"
        ' 
        ' Meals
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblMessage)
        Controls.Add(btnAdd)
        Controls.Add(Guna2Panel1)
        Controls.Add(panelAddedMeals)
        Controls.Add(lblMeals)
        MinimumSize = New Size(1047, 0)
        Name = "Meals"
        Size = New Size(1047, 600)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnPrev As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelAddedMeals As FlowLayoutPanel
    Friend WithEvents lblMeals As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMessage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button

End Class
