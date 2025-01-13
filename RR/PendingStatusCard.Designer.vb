<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PendingStatusCard
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
        lblRecipeName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        SuspendLayout()
        ' 
        ' lblRecipeName
        ' 
        lblRecipeName.BackColor = Color.Transparent
        lblRecipeName.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRecipeName.Location = New Point(13, 16)
        lblRecipeName.Name = "lblRecipeName"
        lblRecipeName.Size = New Size(69, 18)
        lblRecipeName.TabIndex = 0
        lblRecipeName.Text = "Meal Name"
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.Tomato
        lblStatus.Location = New Point(195, 16)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(41, 18)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Status"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.Animated = True
        Guna2Button1.BorderRadius = 8
        Guna2Button1.CustomizableEdges = CustomizableEdges5
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(301, 8)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button1.Size = New Size(72, 35)
        Guna2Button1.TabIndex = 2
        Guna2Button1.Text = "UPDATE"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.Animated = True
        Guna2Button2.BorderRadius = 8
        Guna2Button2.CustomizableEdges = CustomizableEdges7
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Tomato
        Guna2Button2.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(379, 8)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button2.Size = New Size(72, 35)
        Guna2Button2.TabIndex = 3
        Guna2Button2.Text = "DELETE"
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.Location = New Point(11, 42)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(452, 10)
        Guna2Separator1.TabIndex = 4
        ' 
        ' PendingStatusCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2Button1)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Separator1)
        Controls.Add(lblStatus)
        Controls.Add(lblRecipeName)
        Name = "PendingStatusCard"
        Size = New Size(470, 50)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRecipeName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator

End Class
