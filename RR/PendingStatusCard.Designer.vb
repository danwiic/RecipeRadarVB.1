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
        btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
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
        ' btnUpdate
        ' 
        btnUpdate.Animated = True
        btnUpdate.BorderRadius = 8
        btnUpdate.CustomizableEdges = CustomizableEdges5
        btnUpdate.DisabledState.BorderColor = Color.DarkGray
        btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray
        btnUpdate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUpdate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUpdate.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(301, 8)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnUpdate.Size = New Size(72, 35)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "UPDATE"
        ' 
        ' btnDelete
        ' 
        btnDelete.Animated = True
        btnDelete.BorderRadius = 8
        btnDelete.CustomizableEdges = CustomizableEdges7
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Tomato
        btnDelete.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(379, 8)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnDelete.Size = New Size(72, 35)
        btnDelete.TabIndex = 3
        btnDelete.Text = "DELETE"
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
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
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
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator

End Class
