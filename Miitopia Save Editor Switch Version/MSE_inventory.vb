Imports System.ComponentModel
Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_inventory
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim MiitopiaG = &H34
    Dim HPbanana = &H38
    Dim MPcandy = &H3A
    Dim Gametickets = &H84A
    Dim Outingticket_1 = &H2E80
    Dim Outingticket_2 = &H2E81
    Dim Outingticket_3 = &H2E82
    Dim Outingticket_4 = &H2E83
    Dim Outingticket_5 = &H2E84
    Dim Outingticket_6 = &H2E85
    Dim Outingticket_7 = &H2E86
    Dim Outingticket_8 = &H2E87
    Dim Outingticket_9 = &H2E88
    Dim Outingticket_10 = &H2E89
    Dim Outingticket_11 = &H2E8A
    Dim Outingticket_12 = &H2E8B
    Dim Outingticket_13 = &H2E8C
    Dim Outingticket_14 = &H2E8D
    Dim Outingticket_15 = &H2E8E

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
    Private Sub MSE_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MSE_hub.Text_filepath.Text = Nothing Then
        Else
            ReadMSEinventory()
        End If
    End Sub

    Public Sub ReadMSEinventory()
        Try
            Dim ReadInventory As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            ReadInventory.Position = MiitopiaG
            valu_MiitopiaG.Value = ReadInventory.ReadUInt32
            ReadInventory.Position = HPbanana
            valu_hpbanana.Value = ReadInventory.ReadUInt16
            ReadInventory.Position = MPcandy
            valu_mpcandy.Value = ReadInventory.ReadUInt16
            ReadInventory.Position = Gametickets
            valu_gametickets.Value = ReadInventory.ReadUInt16
            ReadInventory.Position = Outingticket_1
            valu_outingticket_1.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_2
            valu_outingticket_2.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_3
            valu_outingticket_3.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_4
            valu_outingticket_4.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_5
            valu_outingticket_5.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_6
            valu_outingticket_6.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_7
            valu_outingticket_7.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_8
            valu_outingticket_8.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_9
            valu_outingticket_9.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_10
            valu_outingticket_10.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_11
            valu_outingticket_11.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_12
            valu_outingticket_12.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_13
            valu_outingticket_13.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_14
            valu_outingticket_14.Value = ReadInventory.ReadByte
            ReadInventory.Position = Outingticket_15
            valu_outingticket_15.Value = ReadInventory.ReadByte
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read main.sav inventory" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub
    'end load process

    'keep settings
    Private Sub MSE_inventory_FormClosing(sender As Object, e As CancelEventArgs) Handles Me.FormClosing
        MSE_hub.Text_filepath.Text = mainsav
    End Sub
    'end keep settings

    Private Sub Fea_gametickets_Click(sender As Object, e As EventArgs) Handles Fea_gametickets.Click
        valu_gametickets.Value = valu_gametickets.Maximum
    End Sub

    Private Sub Fea_hpbanana_Click(sender As Object, e As EventArgs) Handles Fea_hpbanana.Click
        valu_hpbanana.Value = valu_hpbanana.Maximum
    End Sub

    Private Sub Fea_MiitopiaG_Click(sender As Object, e As EventArgs) Handles Fea_MiitopiaG.Click
        valu_MiitopiaG.Value = valu_MiitopiaG.Maximum
    End Sub

    Private Sub Fea_mpcandy_Click(sender As Object, e As EventArgs) Handles Fea_mpcandy.Click
        valu_mpcandy.Value = valu_mpcandy.Maximum
    End Sub

    Private Sub Icon_outingticket_1_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_1.Click
        valu_outingticket_1.Value = valu_outingticket_1.Maximum
    End Sub

    Private Sub Icon_outingticket_2_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_2.Click
        valu_outingticket_2.Value = valu_outingticket_2.Maximum
    End Sub

    Private Sub Icon_outingticket_3_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_3.Click
        valu_outingticket_3.Value = valu_outingticket_3.Maximum
    End Sub

    Private Sub Icon_outingticket_4_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_4.Click
        valu_outingticket_4.Value = valu_outingticket_4.Maximum
    End Sub

    Private Sub Icon_outingticket_5_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_5.Click
        valu_outingticket_5.Value = valu_outingticket_5.Maximum
    End Sub

    Private Sub Icon_outingticket_6_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_6.Click
        valu_outingticket_6.Value = valu_outingticket_6.Maximum
    End Sub

    Private Sub Icon_outingticket_7_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_7.Click
        valu_outingticket_7.Value = valu_outingticket_7.Maximum
    End Sub

    Private Sub Icon_outingticket_8_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_8.Click
        valu_outingticket_8.Value = valu_outingticket_8.Maximum
    End Sub

    Private Sub Icon_outingticket_9_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_9.Click
        valu_outingticket_9.Value = valu_outingticket_9.Maximum
    End Sub

    Private Sub Icon_outingticket_10_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_10.Click
        valu_outingticket_10.Value = valu_outingticket_10.Maximum
    End Sub

    Private Sub Icon_outingticket_11_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_11.Click
        valu_outingticket_11.Value = valu_outingticket_11.Maximum
    End Sub

    Private Sub Icon_outingticket_12_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_12.Click
        valu_outingticket_12.Value = valu_outingticket_12.Maximum
    End Sub

    Private Sub Icon_outingticket_13_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_13.Click
        valu_outingticket_13.Value = valu_outingticket_13.Maximum
    End Sub

    Private Sub Icon_outingticket_14_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_14.Click
        valu_outingticket_14.Value = valu_outingticket_14.Maximum
    End Sub

    Private Sub Icon_outingticket_15_Click(sender As Object, e As EventArgs) Handles Icon_outingticket_15.Click
        valu_outingticket_15.Value = valu_outingticket_15.Maximum
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        WriteMSEinventory()
    End Sub

    Public Sub WriteMSEinventory()
        Try
            Dim WriteInventory As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
            WriteInventory.Position = MiitopiaG
            WriteInventory.WriteUInt32(valu_MiitopiaG.Value)
            WriteInventory.Position = HPbanana
            WriteInventory.WriteUInt16(valu_hpbanana.Value)
            WriteInventory.Position = MPcandy
            WriteInventory.WriteUInt16(valu_mpcandy.Value)
            WriteInventory.Position = Gametickets
            WriteInventory.WriteUInt16(valu_gametickets.Value)
            WriteInventory.Position = Gametickets 'repete to fix last function not write
            WriteInventory.WriteUInt16(valu_gametickets.Value)

            Dim WriteBInventory As New System.IO.FileStream(CStr(mainsav), FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            WriteBInventory.Position = Outingticket_1
            WriteBInventory.WriteByte(valu_outingticket_1.Value)
            WriteBInventory.Position = Outingticket_2
            WriteBInventory.WriteByte(valu_outingticket_2.Value)
            WriteBInventory.Position = Outingticket_3
            WriteBInventory.WriteByte(valu_outingticket_3.Value)
            WriteBInventory.Position = Outingticket_4
            WriteBInventory.WriteByte(valu_outingticket_4.Value)
            WriteBInventory.Position = Outingticket_5
            WriteBInventory.WriteByte(valu_outingticket_5.Value)
            WriteBInventory.Position = Outingticket_6
            WriteBInventory.WriteByte(valu_outingticket_6.Value)
            WriteBInventory.Position = Outingticket_7
            WriteBInventory.WriteByte(valu_outingticket_7.Value)
            WriteBInventory.Position = Outingticket_8
            WriteBInventory.WriteByte(valu_outingticket_8.Value)
            WriteBInventory.Position = Outingticket_9
            WriteBInventory.WriteByte(valu_outingticket_9.Value)
            WriteBInventory.Position = Outingticket_10
            WriteBInventory.WriteByte(valu_outingticket_10.Value)
            WriteBInventory.Position = Outingticket_11
            WriteBInventory.WriteByte(valu_outingticket_11.Value)
            WriteBInventory.Position = Outingticket_12
            WriteBInventory.WriteByte(valu_outingticket_12.Value)
            WriteBInventory.Position = Outingticket_13
            WriteBInventory.WriteByte(valu_outingticket_13.Value)
            WriteBInventory.Position = Outingticket_14
            WriteBInventory.WriteByte(valu_outingticket_14.Value)
            WriteBInventory.Position = Outingticket_15
            WriteBInventory.WriteByte(valu_outingticket_15.Value)

            MSE_dialog.text_dialog.Text = "Inventory has been succefully edited"
            MSE_dialog.ShowDialog()
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to write inventory" & vbNewLine & "Check if your save file is not used with an other application or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub
End Class