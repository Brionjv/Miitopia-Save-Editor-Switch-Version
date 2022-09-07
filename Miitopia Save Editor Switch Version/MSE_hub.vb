Imports System
Imports System.Net

Public Class MSE_hub
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav As String

    'base
    Private Sub Icon_close_Click(sender As Object, e As EventArgs) Handles Icon_close.Click
        valu_checkMSEupdate.Value = 0
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
    'end base

    'menu
    Private Sub Menu_text_inventory_Click(sender As Object, e As EventArgs) Handles Menu_text_inventory.Click
        MSE_inventory.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_inventory_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_inventory.MouseLeave
        Menu_inventory.BackgroundImage = My.Resources.menu_inventory_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_inventory_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_inventory.MouseMove
        Menu_inventory.BackgroundImage = My.Resources.menu_inventory_on
        Text_description.Text = "Edit amount of tickets, golds, HP bananas, MP candies"
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_unlockable_Click(sender As Object, e As EventArgs) Handles Menu_text_unlockable.Click
        MSE_unlockable.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_unlockable_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_unlockable.MouseLeave
        Menu_unlockable.BackgroundImage = My.Resources.menu_unlockable_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_unlockable_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_unlockable.MouseMove
        Menu_unlockable.BackgroundImage = My.Resources.menu_unlockable_on
        Text_description.Text = "Unlock sprinkles, classes, amiibo outfits, inn options"
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_horse_Click(sender As Object, e As EventArgs) Handles Menu_text_horse.Click
        MSE_horse.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_horse_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_horse.MouseLeave
        Menu_horse.BackgroundImage = My.Resources.menu_horse_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_horse_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_horse.MouseMove
        Menu_horse.BackgroundImage = My.Resources.menu_horse_on
        Text_description.Text = "Edit horse name, gender, extract and import horse"
        Panel_description.Visible = True
    End Sub


    Private Sub Menu_text_success_Click(sender As Object, e As EventArgs) Handles Menu_text_success.Click
        MSE_success.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_success_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_success.MouseLeave
        Menu_success.BackgroundImage = My.Resources.menu_success_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_success_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_success.MouseMove
        Menu_success.BackgroundImage = My.Resources.menu_success_on
        Text_description.Text = "Edit amount of chests opened, quests cleared, HP bananas and MP candies eaten"
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_party_Click(sender As Object, e As EventArgs) Handles Menu_text_party.Click
        MSE_party.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_party_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_party.MouseLeave
        Menu_party.BackgroundImage = My.Resources.menu_party_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_party_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_party.MouseMove
        Menu_party.BackgroundImage = My.Resources.menu_party_on
        Text_description.Text = "Edit your party location and mount on the dragon"
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_grubs_Click(sender As Object, e As EventArgs) Handles Menu_text_grubs.Click
        MSE_grubs.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_grubs_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_grubs.MouseLeave
        Menu_grubs.BackgroundImage = My.Resources.menu_grubs_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_grubs_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_grubs.MouseMove
        Menu_grubs.BackgroundImage = My.Resources.menu_grubs_on
        Text_description.Text = "Edit all grubs"
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_transferMii_Click(sender As Object, e As EventArgs) Handles Menu_text_transferMii.Click
        MSE_transferMii.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_transferMii_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_transferMii.MouseLeave
        Menu_transferMii.BackgroundImage = My.Resources.menu_Miitransfert_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_transferMii_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_transferMii.MouseMove
        Menu_transferMii.BackgroundImage = My.Resources.menu_Miitransfert_on
        Text_description.Text = "Export and import Miis"
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_jobslevelsboosts_Click(sender As Object, e As EventArgs) Handles Menu_text_jobslevelsboosts.Click
        MSE_jobslevelsboosts.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_jobslevelsboosts_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_jobslevelsboosts.MouseLeave
        Menu_jobslevelsboosts.BackgroundImage = My.Resources.Menu_jobslevelboost_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_jobslevelsboosts_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_jobslevelsboosts.MouseMove
        Menu_jobslevelsboosts.BackgroundImage = My.Resources.Menu_jobslevelboost_on
        Text_description.Text = "Edit Miis jobs levels and boosts"
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_catalog_Click(sender As Object, e As EventArgs) Handles Menu_text_catalog.Click
        MSE_catalog.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_catalog_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_catalog.MouseLeave
        Menu_catalog.BackgroundImage = My.Resources.menu_catalog_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_catalog_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_catalog.MouseMove
        Menu_catalog.BackgroundImage = My.Resources.menu_catalog_on
        Text_description.Text = "Unlock monsters, grubs, equpments and musics in journal"
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_miiprofile_Click(sender As Object, e As EventArgs) Handles Menu_text_miiprofile.Click
        MSE_miiprofile.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_miiprofile_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_miiprofile.MouseLeave
        Menu_miiprofile.BackgroundImage = My.Resources.menu_miiprofile_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_miiprofile_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_miiprofile.MouseMove
        Menu_miiprofile.BackgroundImage = My.Resources.menu_miiprofile_on
        Text_description.Text = "Edit Mii name (hero), war cry, pose, job, personality"
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_bodyandface_Click(sender As Object, e As EventArgs) Handles Menu_text_bodyandface.Click
        MSE_bodyandface.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_bodyandface_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_bodyandface.MouseLeave
        Menu_bodyandface.BackgroundImage = My.Resources.menu_bodyandface_off
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_text_bodyandface_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_bodyandface.MouseMove
        Menu_bodyandface.BackgroundImage = My.Resources.menu_bodyandface_on
        Text_description.Text = "Edit Mii name (common), favorite color, gender, body and face"
        Panel_description.Visible = True
    End Sub

    'end menu

    'update
    Private Sub MSE_logo_update_Click(sender As Object, e As EventArgs) Handles MSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Miitopia-Save-Editor-Switch-Version/releases")
    End Sub

    Public Sub CheckMSEupdate()
        Try
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
            Dim MAJ As New WebClient
            Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Miitopia-Save-Editor-Switch-Version/main/Version.txt")
            If MSE_version.Text = lastupdate Then
                MSE_logo.Visible = True
                MSE_logo_update.Visible = False
            Else
                MSE_logo.Visible = False
                MSE_logo_update.Visible = True
                MSE_dialog.text_dialog.Text = "An update is available" & vbNewLine & "Click on Miitopia Save Editor logo to download new version"
                MSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to check if an update is available"
            MSE_dialog.ShowDialog()
        End Try
        valu_checkMSEupdate.Value = 1
    End Sub
    'end update

    'keep settings
    Private Sub MSE_hub_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If valu_checkMSEupdate.Value = 0 Then
            CheckMSEupdate()
        End If
    End Sub
    Private Sub MSE_hub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            valu_checkMSEupdate.Value = My.Settings.Para_ckupdate
        Catch ex As Exception
        End Try
    End Sub
    'end keep settings
    Private Sub Button_open_Click(sender As Object, e As EventArgs) Handles Button_open.Click
        Dim open As New OpenFileDialog
        MSE_dialog.text_dialog.Text = "Open main.sav file" & vbNewLine & "Miitopia Save Editor will make a backup of your save file before any changes, check ''backup'' folder"
        MSE_dialog.ShowDialog()
        open.Filter = "SAV files|*main.sav"
        open.Title = "Open save main.sav"
        open.ShowDialog()
        mainsav = open.FileName
        Text_filepath.Text = mainsav
        Makebakmainsav()
    End Sub

    Public Sub Makebakmainsav()
        Try
            My.Computer.FileSystem.CopyFile(
                         mainsav,
                       applicationpath & "\backup\main.sav\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\main.sav")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MSE_hub_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        My.Settings.Para_ckupdate = valu_checkMSEupdate.Value
    End Sub
End Class
