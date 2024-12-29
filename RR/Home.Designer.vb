<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        lblResults = New Guna.UI2.WinForms.Guna2HtmlLabel()
        flowPanelPopular = New FlowLayoutPanel()
        lblPopular = New Guna.UI2.WinForms.Guna2HtmlLabel()
        flowPanelHighRated = New FlowLayoutPanel()
        lblHighRated = New Guna.UI2.WinForms.Guna2HtmlLabel()
        flowPanelResults = New FlowLayoutPanel()
        btnRemove = New Guna.UI2.WinForms.Guna2Button()
        btnSearch = New Guna.UI2.WinForms.Guna2CircleButton()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = SystemColors.ControlDarkDark
        Guna2HtmlLabel1.Location = New Point(305, 81)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(436, 54)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Welcome to RecipeRadar!"
        ' 
        ' txtSearch
        ' 
        txtSearch.Animated = True
        txtSearch.AutoRoundedCorners = True
        txtSearch.BackColor = Color.Transparent
        txtSearch.BorderRadius = 24
        txtSearch.CustomizableEdges = CustomizableEdges1
        txtSearch.DefaultText = ""
        txtSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearch.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearch.Location = New Point(356, 180)
        txtSearch.Name = "txtSearch"
        txtSearch.PasswordChar = ChrW(0)
        txtSearch.PlaceholderText = "Search recipes..."
        txtSearch.SelectedText = ""
        txtSearch.ShadowDecoration.BorderRadius = 28
        txtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtSearch.ShadowDecoration.Depth = 15
        txtSearch.ShadowDecoration.Enabled = True
        txtSearch.Size = New Size(334, 50)
        txtSearch.TabIndex = 1
        ' 
        ' lblResults
        ' 
        lblResults.BackColor = Color.Transparent
        lblResults.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResults.ForeColor = SystemColors.ControlDarkDark
        lblResults.Location = New Point(20, 266)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(3, 2)
        lblResults.TabIndex = 4
        lblResults.Text = " "
        ' 
        ' flowPanelPopular
        ' 
        flowPanelPopular.BackColor = Color.Transparent
        flowPanelPopular.Location = New Point(20, 377)
        flowPanelPopular.MaximumSize = New Size(1006, 1000)
        flowPanelPopular.Name = "flowPanelPopular"
        flowPanelPopular.Size = New Size(1006, 266)
        flowPanelPopular.TabIndex = 4
        ' 
        ' lblPopular
        ' 
        lblPopular.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPopular.BackColor = Color.Transparent
        lblPopular.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPopular.ForeColor = SystemColors.ControlDarkDark
        lblPopular.Location = New Point(20, 331)
        lblPopular.Name = "lblPopular"
        lblPopular.Size = New Size(250, 40)
        lblPopular.TabIndex = 5
        lblPopular.Text = "POPULAR RECIPES"
        ' 
        ' flowPanelHighRated
        ' 
        flowPanelHighRated.BackColor = Color.Transparent
        flowPanelHighRated.Location = New Point(20, 724)
        flowPanelHighRated.MaximumSize = New Size(1006, 1000)
        flowPanelHighRated.Name = "flowPanelHighRated"
        flowPanelHighRated.Size = New Size(1006, 266)
        flowPanelHighRated.TabIndex = 5
        ' 
        ' lblHighRated
        ' 
        lblHighRated.BackColor = Color.Transparent
        lblHighRated.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHighRated.ForeColor = SystemColors.ControlDarkDark
        lblHighRated.Location = New Point(20, 678)
        lblHighRated.Name = "lblHighRated"
        lblHighRated.Size = New Size(302, 40)
        lblHighRated.TabIndex = 6
        lblHighRated.Text = "HIGH RATED RECIPES"
        ' 
        ' flowPanelResults
        ' 
        flowPanelResults.BackColor = Color.Transparent
        flowPanelResults.Location = New Point(20, 312)
        flowPanelResults.MaximumSize = New Size(1006, 1000)
        flowPanelResults.Name = "flowPanelResults"
        flowPanelResults.Size = New Size(1006, 266)
        flowPanelResults.TabIndex = 5
        ' 
        ' btnRemove
        ' 
        btnRemove.CustomizableEdges = CustomizableEdges3
        btnRemove.DisabledState.BorderColor = Color.DarkGray
        btnRemove.DisabledState.CustomBorderColor = Color.DarkGray
        btnRemove.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRemove.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRemove.FillColor = Color.White
        btnRemove.Font = New Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemove.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnRemove.HoverState.FillColor = Color.Transparent
        btnRemove.Location = New Point(603, 187)
        btnRemove.Name = "btnRemove"
        btnRemove.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnRemove.Size = New Size(36, 34)
        btnRemove.TabIndex = 7
        btnRemove.Text = "×"
        btnRemove.Visible = False
        ' 
        ' btnSearch
        ' 
        btnSearch.Animated = True
        btnSearch.BackColor = Color.Transparent
        btnSearch.DisabledState.BorderColor = Color.DarkGray
        btnSearch.DisabledState.CustomBorderColor = Color.DarkGray
        btnSearch.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSearch.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSearch.Font = New Font("Segoe UI", 9F)
        btnSearch.ForeColor = Color.White
        btnSearch.Image = My.Resources.Resources.search_white
        btnSearch.Location = New Point(641, 187)
        btnSearch.Name = "btnSearch"
        btnSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnSearch.Size = New Size(40, 36)
        btnSearch.TabIndex = 8
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        Controls.Add(btnSearch)
        Controls.Add(btnRemove)
        Controls.Add(flowPanelResults)
        Controls.Add(lblHighRated)
        Controls.Add(flowPanelHighRated)
        Controls.Add(lblPopular)
        Controls.Add(flowPanelPopular)
        Controls.Add(lblResults)
        Controls.Add(txtSearch)
        Controls.Add(Guna2HtmlLabel1)
        MinimumSize = New Size(1047, 0)
        Name = "Home"
        Size = New Size(1047, 1045)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblResults As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents flowPanelPopular As FlowLayoutPanel
    Friend WithEvents lblPopular As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents flowPanelHighRated As FlowLayoutPanel
    Friend WithEvents lblHighRated As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents flowPanelResults As FlowLayoutPanel
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2CircleButton

End Class
