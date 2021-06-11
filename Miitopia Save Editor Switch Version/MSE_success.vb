Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_success
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim Miirescued = &H140
    Dim HPbananaseaten = &H180
    Dim MPcandieseaten = &H184
    Dim questscleared = &H188
    Dim chestsopened = &H18C

    'base
    Private Sub Icon_close_Click(sender As Object, e As EventArgs) Handles Icon_close.Click
        My.Settings.Para_ckupdate = 0
        Me.Close()
    End Sub

    Private Sub Icon_close_MouseMove(sender As Object, e As EventArgs) Handles Icon_close.MouseMove
        Icon_close.Image = My.Resources.icon_close_red
    End Sub

    Private Sub Icon_close_MouseLeave(sender As Object, e As EventArgs) Handles Icon_close.MouseLeave
        Icon_close.Image = My.Resources.icon_close
    End Sub

    Private Sub TLSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseDown, MSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub MSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseUp, MSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub MSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseMove, MSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Icon_minimize_Click(sender As Object, e As EventArgs) Handles Icon_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Icon_minimize_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_minimize.MouseMove
        Icon_minimize.Image = My.Resources.icon_minimize_red
    End Sub

    Private Sub Icon_minimize_MouseLeave(sender As Object, e As EventArgs) Handles Icon_minimize.MouseLeave
        Icon_minimize.Image = My.Resources.icon_minimize
    End Sub

    Private Sub Icon_menu_Click(sender As Object, e As EventArgs) Handles Icon_menu.Click
        MSE_hub.Show()
        Me.Close()
    End Sub

    'end base

    'load process
    Private Sub MSE_success_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MSE_hub.Text_filepath.Text = Nothing Then
        Else
            ReadMSEsuccess()
        End If
    End Sub

    Public Sub ReadMSEsuccess()
        Try
            Dim ReadSuccess As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            ReadSuccess.Position = Miirescued
            valu_miirescued.Value = ReadSuccess.ReadUInt16
            ReadSuccess.Position = HPbananaseaten
            valu_HPbananaseaten.Value = ReadSuccess.ReadUInt32
            ReadSuccess.Position = MPcandieseaten
            valu_MPcandieseaten.Value = ReadSuccess.ReadUInt32
            ReadSuccess.Position = chestsopened
            valu_chestsopened.Value = ReadSuccess.ReadUInt32
            ReadSuccess.Position = questscleared
            valu_questscleared.Value = ReadSuccess.ReadUInt32
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read main.sav success" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub
    'end load process

    'keep settings
    Private Sub MSE_success_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        MSE_hub.Text_filepath.Text = mainsav
    End Sub
    'end keep settings

    Private Sub Fea_HPbananaseaten_Click(sender As Object, e As EventArgs) Handles Fea_HPbananaseaten.Click
        valu_HPbananaseaten.Value = valu_HPbananaseaten.Maximum
    End Sub

    Private Sub Fea_MPcandieseaten_Click(sender As Object, e As EventArgs) Handles Fea_MPcandieseaten.Click
        valu_MPcandieseaten.Value = valu_MPcandieseaten.Maximum
    End Sub

    Private Sub Fea_Chestsopened_Click(sender As Object, e As EventArgs) Handles Fea_chestsopened.Click
        valu_chestsopened.Value = valu_chestsopened.Maximum
    End Sub

    Private Sub Fea_Questscleared_Click(sender As Object, e As EventArgs) Handles Fea_questscleared.Click
        valu_questscleared.Value = valu_questscleared.Maximum
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        WriteMSEsuccess()
    End Sub

    Public Sub WriteMSEsuccess()
        Try
            Dim WriteSuccess As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
            WriteSuccess.Position = Miirescued
            WriteSuccess.WriteUInt16(valu_miirescued.Value)
            WriteSuccess.Position = HPbananaseaten
            WriteSuccess.WriteUInt32(valu_HPbananaseaten.Value)
            WriteSuccess.Position = MPcandieseaten
            WriteSuccess.WriteUInt32(valu_MPcandieseaten.Value)
            WriteSuccess.Position = chestsopened
            WriteSuccess.WriteUInt32(valu_chestsopened.Value)
            WriteSuccess.Position = questscleared
            WriteSuccess.WriteUInt32(valu_questscleared.Value)

            MSE_dialog.text_dialog.Text = "Success has been succefully edited"
            MSE_dialog.ShowDialog()
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to write success" & vbNewLine & "Check if your save file is not used with an other application or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub
End Class