<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overview
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
        lblFav = New Guna.UI2.WinForms.Guna2HtmlLabel()
        SuspendLayout()
        ' 
        ' lblFav
        ' 
        lblFav.BackColor = Color.Transparent
        lblFav.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFav.ForeColor = SystemColors.ControlDarkDark
        lblFav.Location = New Point(13, 14)
        lblFav.Name = "lblFav"
        lblFav.Size = New Size(120, 40)
        lblFav.TabIndex = 9
        lblFav.Text = "Overview"
        ' 
        ' Overview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblFav)
        Name = "Overview"
        Size = New Size(1041, 500)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFav As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
