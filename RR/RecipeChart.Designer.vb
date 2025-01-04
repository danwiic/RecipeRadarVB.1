<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeChart
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
        Dim ChartFont1 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont2 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont3 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont4 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid1 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim Tick1 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont5 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid2 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim Tick2 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont6 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid3 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim PointLabel1 As Guna.Charts.WinForms.PointLabel = New Guna.Charts.WinForms.PointLabel()
        Dim ChartFont7 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Tick3 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont8 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        cbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        cbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        GunaChart1 = New Guna.Charts.WinForms.GunaChart()
        SuspendLayout()
        ' 
        ' cbFilter
        ' 
        cbFilter.BackColor = Color.Transparent
        cbFilter.CustomizableEdges = CustomizableEdges1
        cbFilter.DrawMode = DrawMode.OwnerDrawFixed
        cbFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cbFilter.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbFilter.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbFilter.Font = New Font("Segoe UI", 10F)
        cbFilter.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbFilter.ItemHeight = 30
        cbFilter.Location = New Point(117, 1)
        cbFilter.Name = "cbFilter"
        cbFilter.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cbFilter.Size = New Size(140, 36)
        cbFilter.TabIndex = 4
        ' 
        ' cbYear
        ' 
        cbYear.BackColor = Color.Transparent
        cbYear.CustomizableEdges = CustomizableEdges3
        cbYear.DrawMode = DrawMode.OwnerDrawFixed
        cbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cbYear.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbYear.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbYear.Font = New Font("Segoe UI", 10F)
        cbYear.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbYear.ItemHeight = 30
        cbYear.Location = New Point(286, 1)
        cbYear.Name = "cbYear"
        cbYear.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        cbYear.Size = New Size(140, 36)
        cbYear.TabIndex = 5
        ' 
        ' GunaChart1
        ' 
        GunaChart1.Dock = DockStyle.Bottom
        ChartFont1.FontName = "Arial"
        GunaChart1.Legend.LabelFont = ChartFont1
        GunaChart1.Location = New Point(0, 40)
        GunaChart1.Name = "GunaChart1"
        GunaChart1.Size = New Size(514, 241)
        GunaChart1.TabIndex = 3
        ChartFont2.FontName = "Arial"
        ChartFont2.Size = 12
        ChartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        GunaChart1.Title.Font = ChartFont2
        ChartFont3.FontName = "Arial"
        GunaChart1.Tooltips.BodyFont = ChartFont3
        ChartFont4.FontName = "Arial"
        ChartFont4.Size = 9
        ChartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        GunaChart1.Tooltips.TitleFont = ChartFont4
        GunaChart1.XAxes.GridLines = Grid1
        ChartFont5.FontName = "Arial"
        Tick1.Font = ChartFont5
        GunaChart1.XAxes.Ticks = Tick1
        GunaChart1.YAxes.GridLines = Grid2
        ChartFont6.FontName = "Arial"
        Tick2.Font = ChartFont6
        GunaChart1.YAxes.Ticks = Tick2
        GunaChart1.ZAxes.GridLines = Grid3
        ChartFont7.FontName = "Arial"
        PointLabel1.Font = ChartFont7
        GunaChart1.ZAxes.PointLabels = PointLabel1
        ChartFont8.FontName = "Arial"
        Tick3.Font = ChartFont8
        GunaChart1.ZAxes.Ticks = Tick3
        ' 
        ' RecipeChart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GunaChart1)
        Controls.Add(cbYear)
        Controls.Add(cbFilter)
        Name = "RecipeChart"
        Size = New Size(514, 281)
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaChart1 As Guna.Charts.WinForms.GunaChart

End Class
