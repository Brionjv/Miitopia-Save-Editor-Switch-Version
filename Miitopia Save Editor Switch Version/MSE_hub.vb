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
    End Sub

    Private Sub Menu_text_inventory_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_inventory.MouseMove
        Menu_inventory.BackgroundImage = My.Resources.menu_inventory_on
    End Sub

    Private Sub Menu_text_unlockable_Click(sender As Object, e As EventArgs) Handles Menu_text_unlockable.Click
        MSE_unlockable.Show()
        Me.Close()
    End Sub

    Private Sub Menu_text_unlockable_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_unlockable.MouseLeave
        Menu_unlockable.BackgroundImage = My.Resources.menu_unlockable_off
    End Sub

    Private Sub Menu_text_unlockable_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_unlockable.MouseMove
        Menu_unlockable.BackgroundImage = My.Resources.menu_unlockable_on
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
