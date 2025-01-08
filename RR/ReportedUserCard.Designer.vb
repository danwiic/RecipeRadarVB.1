﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportedUserCard
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txtUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtComment = New Guna.UI2.WinForms.Guna2TextBox()
        lblReason = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        btnMute = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Transparent
        txtUsername.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(20, 17)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(71, 19)
        txtUsername.TabIndex = 0
        txtUsername.Text = "Username"
        ' 
        ' txtComment
        ' 
        txtComment.Animated = True
        txtComment.AutoScroll = True
        txtComment.BorderRadius = 8
        txtComment.CustomizableEdges = CustomizableEdges7
        txtComment.DefaultText = ""
        txtComment.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtComment.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtComment.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtComment.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtComment.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtComment.Font = New Font("Arial", 9.75F)
        txtComment.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtComment.Location = New Point(123, 7)
        txtComment.Name = "txtComment"
        txtComment.PasswordChar = ChrW(0)
        txtComment.PlaceholderText = ""
        txtComment.SelectedText = ""
        txtComment.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtComment.Size = New Size(255, 38)
        txtComment.TabIndex = 1
        ' 
        ' lblReason
        ' 
        lblReason.BackColor = Color.Transparent
        lblReason.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReason.Location = New Point(424, 17)
        lblReason.Name = "lblReason"
        lblReason.Size = New Size(153, 19)
        lblReason.TabIndex = 2
        lblReason.Text = "Inappropriate comment"
        ' 
        ' btnDelete
        ' 
        btnDelete.Animated = True
        btnDelete.BorderRadius = 6
        btnDelete.Cursor = Cursors.Hand
        btnDelete.CustomizableEdges = CustomizableEdges9
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Tomato
        btnDelete.Font = New Font("Segoe UI", 9F)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.delete_white
        btnDelete.Location = New Point(736, 7)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnDelete.Size = New Size(75, 36)
        btnDelete.TabIndex = 6
        ' 
        ' btnMute
        ' 
        btnMute.Animated = True
        btnMute.BorderRadius = 6
        btnMute.Cursor = Cursors.Hand
        btnMute.CustomizableEdges = CustomizableEdges11
        btnMute.DisabledState.BorderColor = Color.DarkGray
        btnMute.DisabledState.CustomBorderColor = Color.DarkGray
        btnMute.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnMute.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnMute.FillColor = Color.LimeGreen
        btnMute.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMute.ForeColor = Color.White
        btnMute.Location = New Point(655, 7)
        btnMute.Name = "btnMute"
        btnMute.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnMute.Size = New Size(75, 36)
        btnMute.TabIndex = 14
        btnMute.Text = "MUTE"
        ' 
        ' ReportedUserCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnMute)
        Controls.Add(btnDelete)
        Controls.Add(lblReason)
        Controls.Add(txtComment)
        Controls.Add(txtUsername)
        Name = "ReportedUserCard"
        Size = New Size(874, 50)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtComment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblReason As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMute As Guna.UI2.WinForms.Guna2Button

End Class
