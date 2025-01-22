<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PendingRecipe
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
        displayPendingRecipes = New FlowLayoutPanel()
        lblMessage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        SuspendLayout()
        ' 
        ' lblFav
        ' 
        lblFav.BackColor = Color.Transparent
        lblFav.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFav.ForeColor = SystemColors.ControlDarkDark
        lblFav.Location = New Point(13, 14)
        lblFav.Name = "lblFav"
        lblFav.Size = New Size(201, 40)
        lblFav.TabIndex = 8
        lblFav.Text = "Pending Recipes"
        ' 
        ' displayPendingRecipes
        ' 
        displayPendingRecipes.Location = New Point(13, 60)
        displayPendingRecipes.Name = "displayPendingRecipes"
        displayPendingRecipes.Size = New Size(1013, 303)
        displayPendingRecipes.TabIndex = 9
        ' 
        ' lblMessage
        ' 
        lblMessage.BackColor = Color.Transparent
        lblMessage.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblMessage.ForeColor = SystemColors.ControlDarkDark
        lblMessage.Location = New Point(13, 86)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(202, 40)
        lblMessage.TabIndex = 10
        lblMessage.Text = "Pending Recipes"
        ' 
        ' PendingRecipe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        Controls.Add(lblMessage)
        Controls.Add(displayPendingRecipes)
        Controls.Add(lblFav)
        DoubleBuffered = True
        Name = "PendingRecipe"
        Size = New Size(1041, 500)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFav As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents displayPendingRecipes As FlowLayoutPanel
    Friend WithEvents lblMessage As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
