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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(3, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1041, 100)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Categories
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(FlowLayoutPanel1)
        Name = "Categories"
        Size = New Size(1047, 600)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel

End Class
