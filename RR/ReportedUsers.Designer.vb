﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportedUsers
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
        lblAction = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblReason = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblComments = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnNext = New Guna.UI2.WinForms.Guna2Button()
        lblPages = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnPrev = New Guna.UI2.WinForms.Guna2Button()
        lblFav = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2GradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblAction
        ' 
        lblAction.BackColor = Color.White
        lblAction.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        lblAction.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblAction.Location = New Point(758, 19)
        lblAction.Name = "lblAction"
        lblAction.Size = New Size(47, 20)
        lblAction.TabIndex = 4
        lblAction.Text = "Action"
        ' 
        ' lblReason
        ' 
        lblReason.BackColor = Color.White
        lblReason.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        lblReason.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblReason.Location = New Point(452, 19)
        lblReason.Name = "lblReason"
        lblReason.Size = New Size(57, 20)
        lblReason.TabIndex = 3
        lblReason.Text = "Reason"
        ' 
        ' lblUsername
        ' 
        lblUsername.BackColor = Color.White
        lblUsername.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblUsername.Location = New Point(50, 19)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(75, 20)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblComments
        ' 
        lblComments.BackColor = Color.White
        lblComments.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        lblComments.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblComments.Location = New Point(154, 19)
        lblComments.Name = "lblComments"
        lblComments.Size = New Size(78, 20)
        lblComments.TabIndex = 2
        lblComments.Text = "Comments"
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2GradientPanel1.BackColor = Color.Transparent
        Guna2GradientPanel1.BorderRadius = 12
        Guna2GradientPanel1.Controls.Add(lblStatus)
        Guna2GradientPanel1.Controls.Add(FlowLayoutPanel1)
        Guna2GradientPanel1.Controls.Add(btnNext)
        Guna2GradientPanel1.Controls.Add(lblPages)
        Guna2GradientPanel1.Controls.Add(btnPrev)
        Guna2GradientPanel1.Controls.Add(lblAction)
        Guna2GradientPanel1.Controls.Add(lblReason)
        Guna2GradientPanel1.Controls.Add(lblUsername)
        Guna2GradientPanel1.Controls.Add(lblComments)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges5
        Guna2GradientPanel1.FillColor = Color.White
        Guna2GradientPanel1.FillColor2 = Color.White
        Guna2GradientPanel1.Location = New Point(56, 52)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.BorderRadius = 12
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientPanel1.ShadowDecoration.Depth = 8
        Guna2GradientPanel1.ShadowDecoration.Enabled = True
        Guna2GradientPanel1.Size = New Size(903, 497)
        Guna2GradientPanel1.TabIndex = 12
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.ControlDarkDark
        lblStatus.Location = New Point(24, 8)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(157, 31)
        lblStatus.TabIndex = 14
        lblStatus.Text = "Reported Users"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.Location = New Point(24, 44)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(855, 395)
        FlowLayoutPanel1.TabIndex = 20
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Bottom
        btnNext.Animated = True
        btnNext.AutoRoundedCorners = True
        btnNext.BorderRadius = 21
        btnNext.Cursor = Cursors.Hand
        btnNext.CustomizableEdges = CustomizableEdges1
        btnNext.DisabledState.BorderColor = Color.DarkGray
        btnNext.DisabledState.CustomBorderColor = Color.DarkGray
        btnNext.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNext.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnNext.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold)
        btnNext.ForeColor = Color.White
        btnNext.Location = New Point(492, 445)
        btnNext.Name = "btnNext"
        btnNext.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnNext.Size = New Size(180, 45)
        btnNext.TabIndex = 19
        btnNext.Text = "Next"
        ' 
        ' lblPages
        ' 
        lblPages.Anchor = AnchorStyles.Bottom
        lblPages.BackColor = Color.Transparent
        lblPages.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPages.Location = New Point(417, 459)
        lblPages.Name = "lblPages"
        lblPages.Size = New Size(69, 18)
        lblPages.TabIndex = 18
        lblPages.Text = "Page 1 of 1"
        ' 
        ' btnPrev
        ' 
        btnPrev.Anchor = AnchorStyles.Bottom
        btnPrev.Animated = True
        btnPrev.AutoRoundedCorners = True
        btnPrev.BorderRadius = 21
        btnPrev.Cursor = Cursors.Hand
        btnPrev.CustomizableEdges = CustomizableEdges3
        btnPrev.DisabledState.BorderColor = Color.DarkGray
        btnPrev.DisabledState.CustomBorderColor = Color.DarkGray
        btnPrev.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPrev.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPrev.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold)
        btnPrev.ForeColor = Color.White
        btnPrev.Location = New Point(231, 445)
        btnPrev.Name = "btnPrev"
        btnPrev.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnPrev.Size = New Size(180, 45)
        btnPrev.TabIndex = 17
        btnPrev.Text = "Previous"
        ' 
        ' lblFav
        ' 
        lblFav.BackColor = Color.Transparent
        lblFav.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFav.ForeColor = SystemColors.ControlDarkDark
        lblFav.Location = New Point(17, 5)
        lblFav.Name = "lblFav"
        lblFav.Size = New Size(203, 40)
        lblFav.TabIndex = 13
        lblFav.Text = "Reported Users"
        ' 
        ' ReportedUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2GradientPanel1)
        Controls.Add(lblFav)
        DoubleBuffered = True
        Name = "ReportedUsers"
        Size = New Size(1014, 554)
        Guna2GradientPanel1.ResumeLayout(False)
        Guna2GradientPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblAction As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblReason As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblComments As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblFav As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPages As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnPrev As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
