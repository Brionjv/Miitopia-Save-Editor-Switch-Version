Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_unlockable
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim Unlock_sprinkles = &H110
    Dim Unlock_classes = &H144
    Dim Unlock_amiibo = &H2B4

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

    'keep settings
    Private Sub MSE_unlockable_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MSE_hub.Text_filepath.Text = mainsav
    End Sub
    'end keep settings

    Private Sub Fea_unlock_amiibo_Click(sender As Object, e As EventArgs) Handles Fea_unlock_amiibo.Click
        valu_unlock_amiibo.Value = 4294967295
    End Sub

    Private Sub Fea_unlock_classes_Click(sender As Object, e As EventArgs) Handles Fea_unlock_classes.Click
        valu_unlock_classes.Value = &H3FFF
    End Sub

    Private Sub Fea_unlock_sprinkles_Click(sender As Object, e As EventArgs) Handles Fea_unlock_sprinkles.Click
        valu_unlock_sprinkles.Value = &HFF
    End Sub

    'load process
    Private Sub MSE_unlockable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MSE_hub.Text_filepath.Text = Nothing Then
        Else
            ReadMSEunlockable()
        End If
    End Sub

    Public Sub ReadMSEunlockable()
        Try
            Dim ReadUnlockable As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            ReadUnlockable.Position = Unlock_amiibo
            valu_unlock_amiibo.Value = ReadUnlockable.ReadUInt64
            ReadUnlockable.Position = Unlock_classes
            valu_unlock_classes.Value = ReadUnlockable.ReadUInt16
            ReadUnlockable.Position = Unlock_sprinkles
            valu_unlock_sprinkles.Value = ReadUnlockable.ReadByte
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read main.sav inventory" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        WriteMSEunlockable
    End Sub

    Public Sub WriteMSEunlockable()
        Try
            Dim WriteUnlockable As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
            WriteUnlockable.Position = Unlock_amiibo
            WriteUnlockable.WriteInt64(valu_unlock_amiibo.Value)
            WriteUnlockable.Position = Unlock_classes
            WriteUnlockable.WriteUInt16(valu_unlock_classes.Value)

            Dim WriteBUnlockable As New System.IO.FileStream(CStr(mainsav), FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            WriteBUnlockable.Position = Unlock_sprinkles
            WriteBUnlockable.WriteByte(valu_unlock_sprinkles.Value)

            MSE_dialog.text_dialog.Text = "Unlockables has been succefully edited"
            MSE_dialog.ShowDialog()
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to write unlockables" & vbNewLine & "Check if your save file is not used with an other application or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub



End Class