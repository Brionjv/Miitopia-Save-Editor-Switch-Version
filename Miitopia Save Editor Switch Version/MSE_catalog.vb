Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_catalog
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim monsters = &H1E8
    Dim grubs = &H228
    Dim clothes = &H27C
    Dim weapons = &H244
    Dim musics = &H7F0

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

    Private Sub Fea_catalog_monsters_Click(sender As Object, e As EventArgs) Handles Fea_catalog_monsters.Click
        Text_catalog_monsters.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"
    End Sub

    Private Sub Fea_catalog_monsters_MouseMove(sender As Object, e As MouseEventArgs) Handles Fea_catalog_monsters.MouseMove
        Text_description.Text = "Click to unlock all monsters in journal"
        Panel_description.Visible = True
    End Sub

    Private Sub Fea_catalog_monsters_MouseLeave(sender As Object, e As EventArgs) Handles Fea_catalog_monsters.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Fea_catalog_grubs_Click(sender As Object, e As EventArgs) Handles Fea_catalog_grubs.Click
        Text_catalog_grubs.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0F"
    End Sub

    Private Sub Fea_catalog_grubs_MouseMove(sender As Object, e As MouseEventArgs) Handles Fea_catalog_grubs.MouseMove
        Text_description.Text = "Click to unlock all grubs in journal"
        Panel_description.Visible = True
    End Sub

    Private Sub Fea_catalog_grubs_MouseLeave(sender As Object, e As EventArgs) Handles Fea_catalog_grubs.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Fea_catalog_clothes_Click(sender As Object, e As EventArgs) Handles Fea_catalog_clothes.Click
        Text_catalog_clothes.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"
    End Sub

    Private Sub Fea_catalog_clothes_MouseMove(sender As Object, e As MouseEventArgs) Handles Fea_catalog_clothes.MouseMove
        Text_description.Text = "Click to unlock all clothes in journal"
        Panel_description.Visible = True
    End Sub

    Private Sub Fea_catalog_clothes_MouseLeave(sender As Object, e As EventArgs) Handles Fea_catalog_clothes.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Fea_catalog_weapons_Click(sender As Object, e As EventArgs) Handles Fea_catalog_weapons.Click
        Text_catalog_weapons.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"
    End Sub

    Private Sub Fea_catalog_weapons_MouseMove(sender As Object, e As MouseEventArgs) Handles Fea_catalog_weapons.MouseMove
        Text_description.Text = "Click to unlock all weapons in journal"
        Panel_description.Visible = True
    End Sub

    Private Sub Fea_catalog_weapons_MouseLeave(sender As Object, e As EventArgs) Handles Fea_catalog_weapons.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Fea_catalog_musics_Click(sender As Object, e As EventArgs) Handles Fea_catalog_musics.Click
        Text_catalog_musics.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"
    End Sub

    Private Sub Fea_catalog_musics_MouseMove(sender As Object, e As MouseEventArgs) Handles Fea_catalog_musics.MouseMove
        Text_description.Text = "Click to unlock all musics in journal"
        Panel_description.Visible = True
    End Sub

    Private Sub Fea_catalog_musics_MouseLeave(sender As Object, e As EventArgs) Handles Fea_catalog_musics.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Text_catalog_monsters_TextChanged(sender As Object, e As EventArgs) Handles Text_catalog_monsters.TextChanged
        If Text_catalog_monsters.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" Then
            Icon_catalog_monsters.Visible = True
        Else
            Icon_catalog_monsters.Visible = False
        End If
    End Sub

    Private Sub Text_catalog_grubs_TextChanged(sender As Object, e As EventArgs) Handles Text_catalog_grubs.TextChanged
        If Text_catalog_grubs.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0F" Then
            Icon_catalog_grubs.Visible = True
        Else
            Icon_catalog_grubs.Visible = False
        End If
    End Sub

    Private Sub Text_catalog_clothes_TextChanged(sender As Object, e As EventArgs) Handles Text_catalog_clothes.TextChanged
        If Text_catalog_clothes.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" Then
            Icon_catalog_clothes.Visible = True
        Else
            Icon_catalog_clothes.Visible = False
        End If
    End Sub

    Private Sub Text_catalog_weapons_TextChanged(sender As Object, e As EventArgs) Handles Text_catalog_weapons.TextChanged
        If Text_catalog_weapons.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" Then
            Icon_catalog_weapons.Visible = True
        Else
            Icon_catalog_weapons.Visible = False
        End If
    End Sub

    Private Sub Text_catalog_musics_TextChanged(sender As Object, e As EventArgs) Handles Text_catalog_musics.TextChanged
        If Text_catalog_musics.Text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF" Then
            Icon_catalog_musics.Visible = True
        Else
            Icon_catalog_musics.Visible = False
        End If
    End Sub

    Private Sub MSE_catalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MSE_hub.Text_filepath.Text = Nothing Then
        Else
            ReadMSEcatalog()
        End If
    End Sub

    Public Sub ReadMSEcatalog()
        Try
            Dim Readcatalog As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            Readcatalog.Position = monsters
            Text_catalog_monsters.Text = Readcatalog.ReadHexString(&H2B)
            Readcatalog.Position = grubs
            Text_catalog_grubs.Text = Readcatalog.ReadHexString(&H19)
            Readcatalog.Position = clothes
            Text_catalog_clothes.Text = Readcatalog.ReadHexString(&H38)
            Readcatalog.Position = weapons
            Text_catalog_weapons.Text = Readcatalog.ReadHexString(&H38)
            Readcatalog.Position = musics
            Text_catalog_musics.Text = Readcatalog.ReadHexString(&H1F)
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read main.sav journal" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        WriteMSEcatalog()
    End Sub

    Public Sub WriteMSEcatalog()
        Try
            Dim Writecatalog As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
            Writecatalog.Position = monsters
            Writecatalog.WriteHexString(Text_catalog_monsters.Text)
            Writecatalog.Position = grubs
            Writecatalog.WriteHexString(Text_catalog_grubs.Text)
            Writecatalog.Position = clothes
            Writecatalog.WriteHexString(Text_catalog_clothes.Text)
            Writecatalog.Position = weapons
            Writecatalog.WriteHexString(Text_catalog_weapons.Text)
            Writecatalog.Position = musics
            Writecatalog.WriteHexString(Text_catalog_musics.Text)
            MSE_dialog.text_dialog.Text = "Journal has been successfully edited"
            MSE_dialog.ShowDialog()
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to write journal" & vbNewLine & "Check if your save file is not used with an other application or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub
End Class