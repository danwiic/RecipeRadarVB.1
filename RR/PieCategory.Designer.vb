<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PieCategory
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
        GunaChart = New Guna.Charts.WinForms.GunaChart()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2GradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.BackColor = Color.Transparent
        Guna2GradientPanel1.BorderRadius = 12
        Guna2GradientPanel1.Controls.Add(Guna2HtmlLabel1)
        Guna2GradientPanel1.Controls.Add(GunaChart)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.White
        Guna2GradientPanel1.FillColor2 = Color.White
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.Size = New Size(495, 281)
        Guna2GradientPanel1.TabIndex = 0
        ' 
        ' GunaChart
        ' 
        ChartFont1.FontName = "Arial"
        GunaChart.Legend.LabelFont = ChartFont1
        GunaChart.Location = New Point(8, 35)
        GunaChart.Name = "GunaChart"
        GunaChart.Size = New Size(472, 237)
        GunaChart.TabIndex = 0
        ChartFont2.FontName = "Arial"
        ChartFont2.Size = 12
        ChartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        GunaChart.Title.Font = ChartFont2
        ChartFont3.FontName = "Arial"
        GunaChart.Tooltips.BodyFont = ChartFont3
        ChartFont4.FontName = "Arial"
        ChartFont4.Size = 9
        ChartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        GunaChart.Tooltips.TitleFont = ChartFont4
        GunaChart.XAxes.GridLines = Grid1
        ChartFont5.FontName = "Arial"
        Tick1.Font = ChartFont5
        GunaChart.XAxes.Ticks = Tick1
        GunaChart.YAxes.GridLines = Grid2
        ChartFont6.FontName = "Arial"
        Tick2.Font = ChartFont6
        GunaChart.YAxes.Ticks = Tick2
        GunaChart.ZAxes.GridLines = Grid3
        ChartFont7.FontName = "Arial"
        PointLabel1.Font = ChartFont7
        GunaChart.ZAxes.PointLabels = PointLabel1
        ChartFont8.FontName = "Arial"
        Tick3.Font = ChartFont8
        GunaChart.ZAxes.Ticks = Tick3
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2HtmlLabel1.Location = New Point(132, 10)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(230, 19)
        Guna2HtmlLabel1.TabIndex = 9
        Guna2HtmlLabel1.Text = "TOTAL RECIPE PER CATEGORY"
        ' 
        ' PieCategory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Guna2GradientPanel1)
        Name = "PieCategory"
        Size = New Size(495, 281)
        Guna2GradientPanel1.ResumeLayout(False)
        Guna2GradientPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GunaChart As Guna.Charts.WinForms.GunaChart
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
