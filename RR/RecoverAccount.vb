﻿Imports MySql.Data.MySqlClient
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class RecoverAccount
    Dim isDragging As Boolean
    Private startPoint As Point

    Public Shared CurrentEmail As String

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub RecoverAccount_MouseDown(sender As Object, e As MouseEventArgs) Handles recoverPanel.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub RecoverAccount_MouseMove(sender As Object, e As MouseEventArgs) Handles recoverPanel.MouseMove
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub RecoverAccount_MouseUp(sender As Object, e As MouseEventArgs) Handles recoverPanel.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub RecoverAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayPanel.Visible = True
        displayPanel.Controls.Clear()
        Dim sendOtpControl As New SendOTP()
        displayPanel.Controls.Add(sendOtpControl)

        AddHandler sendOtpControl.BackButtonClicked, AddressOf OnBackButtonClicked

        AddHandler sendOtpControl.HideFormButton, AddressOf HideForm

        shadowForm.SetShadowForm(Me)
    End Sub

    Private Sub OnBackButtonClicked()
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub HideForm()
        Me.Hide()
    End Sub
    Private Sub displayPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub recoverPanel_Paint(sender As Object, e As PaintEventArgs) Handles recoverPanel.Paint

    End Sub

    Private Sub displayPanel_Paint_1(sender As Object, e As PaintEventArgs) Handles displayPanel.Paint

    End Sub

    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick

    End Sub
End Class