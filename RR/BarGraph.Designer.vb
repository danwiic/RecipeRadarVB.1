<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarGraph
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
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        cbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        GunaChart1 = New Guna.Charts.WinForms.GunaChart()
        Guna2GradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.BackColor = Color.Transparent
        Guna2GradientPanel1.BorderRadius = 12
        Guna2GradientPanel1.Controls.Add(Guna2HtmlLabel2)
        Guna2GradientPanel1.Controls.Add(Guna2HtmlLabel1)
        Guna2GradientPanel1.Controls.Add(cbYear)
        Guna2GradientPanel1.Controls.Add(cbFilter)
        Guna2GradientPanel1.Controls.Add(GunaChart1)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges5
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.White
        Guna2GradientPanel1.FillColor2 = Color.White
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.BorderRadius = 20
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientPanel1.ShadowDecoration.Depth = 8
        Guna2GradientPanel1.ShadowDecoration.Enabled = True
        Guna2GradientPanel1.Size = New Size(657, 281)
        Guna2GradientPanel1.TabIndex = 5
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.Location = New Point(434, 19)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(37, 19)
        Guna2HtmlLabel2.TabIndex = 9
        Guna2HtmlLabel2.Text = "Year:"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(193, 17)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(58, 19)
        Guna2HtmlLabel1.TabIndex = 8
        Guna2HtmlLabel1.Text = "Filter by:"
        ' 
        ' cbYear
        ' 
        cbYear.BackColor = Color.Transparent
        cbYear.CustomizableEdges = CustomizableEdges1
        cbYear.DrawMode = DrawMode.OwnerDrawFixed
        cbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cbYear.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbYear.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbYear.Font = New Font("Segoe UI", 10F)
        cbYear.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbYear.ItemHeight = 30
        cbYear.Location = New Point(477, 10)
        cbYear.Name = "cbYear"
        cbYear.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cbYear.Size = New Size(140, 36)
        cbYear.TabIndex = 7
        ' 
        ' cbFilter
        ' 
        cbFilter.BackColor = Color.Transparent
        cbFilter.CustomizableEdges = CustomizableEdges3
        cbFilter.DrawMode = DrawMode.OwnerDrawFixed
        cbFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cbFilter.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbFilter.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbFilter.Font = New Font("Segoe UI", 10F)
        cbFilter.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbFilter.ItemHeight = 30
        cbFilter.Location = New Point(257, 10)
        cbFilter.Name = "cbFilter"
        cbFilter.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        cbFilter.Size = New Size(140, 36)
        cbFilter.TabIndex = 6
        ' 
        ' GunaChart1
        ' 
        ChartFont1.FontName = "Arial"
        GunaChart1.Legend.LabelFont = ChartFont1
        GunaChart1.Location = New Point(14, 52)
        GunaChart1.Name = "GunaChart1"
        GunaChart1.Size = New Size(628, 222)
        GunaChart1.TabIndex = 5
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
        ' BarGraph
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Guna2GradientPanel1)
        Name = "BarGraph"
        Size = New Size(657, 281)
        Guna2GradientPanel1.ResumeLayout(False)
        Guna2GradientPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaChart1 As Guna.Charts.WinForms.GunaChart

End Class
