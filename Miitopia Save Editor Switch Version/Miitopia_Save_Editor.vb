Imports System.Net
Imports PackageIO
Imports System.IO
Public Class Miitopia_Save_Editor
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav As String
    Dim MiitopiaG = &H34
    Dim Hpbanana = &H38
    Dim MPcandy = &H3A

    Private Sub MSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseDown, MSE_logo.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub MSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseUp, MSE_logo.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub MSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseMove, MSE_logo.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Icon_close_MouseMove(sender As Object, e As EventArgs) Handles Icon_close.MouseMove
        Icon_close.Image = My.Resources.icon_close_red
    End Sub

    Private Sub Icon_close_MouseLeave(sender As Object, e As EventArgs) Handles Icon_close.MouseLeave
        Icon_close.Image = My.Resources.icon_close
    End Sub

    Private Sub Icon_close_Click(sender As Object, e As EventArgs) Handles Icon_close.Click
        Me.Close()
    End Sub

    Private Sub Icon_minimize_MouseMove(sender As Object, e As EventArgs) Handles Icon_minimize.MouseMove
        Icon_minimize.Image = My.Resources.icon_minimize_red
    End Sub

    Private Sub Icon_minimize_MouseLeave(sender As Object, e As EventArgs) Handles Icon_minimize.MouseLeave
        Icon_minimize.Image = My.Resources.icon_minimize
    End Sub

    Private Sub Icon_minimize_Click(sender As Object, e As EventArgs) Handles Icon_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub Makebackup()
        Try
            My.Computer.FileSystem.CopyFile(
          mainsav,
        applicationpath & "\backup\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\main.sav")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button_open_Click(sender As Object, e As EventArgs) Handles Button_open.Click
        Dim open As New OpenFileDialog
        MsgBox("Open main.sav file" & System.Environment.NewLine & "Miitopia Save Editor will make a backup of your save file before any changes, check ''backup'' folder")
        open.Filter = "SAV files|*main.sav"
        open.Title = "Open save main.sav"
        open.ShowDialog()
        mainsav = open.FileName
        Readmainsav()
        Makebackup()
    End Sub

    Public Sub Readmainsav()
        Try
            Dim Reader As New PackageIO.Reader(mainsav, PackageIO.Endian.Little)
            Reader.Position = MiitopiaG
            valu_MiitopiaG.Value = Reader.ReadUInt32
            Reader.Position = Hpbanana
            valu_HPbanana.Value = Reader.ReadUInt16
            Reader.Position = MPcandy
            valu_MPcandy.Value = Reader.ReadUInt16
        Catch ex As Exception
            MsgBox("Error when reading file, retry or report this issue")
        End Try
    End Sub

    Public Sub Writemainsav()
        Try
            Dim Writer As New PackageIO.Writer(mainsav, PackageIO.Endian.Little)
            Writer.Position = MiitopiaG
            Writer.WriteUInt32(valu_MiitopiaG.Value)
            Writer.Position = Hpbanana
            Writer.WriteUInt16(valu_HPbanana.Value)
            Writer.Position = MPcandy
            Writer.WriteUInt16(valu_MPcandy.Value)
            Writer.Position = MPcandy 'repete last write function -> (last function not save fixed)
            Writer.WriteUInt16(valu_MPcandy.Value)
            MsgBox("File save")
        Catch ex As Exception
            MsgBox("Error when writing file, retry or report this issue")
        End Try
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Writemainsav()
    End Sub

    Public Sub Checkupdates()
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
                MsgBox("An update is avalible, click on Miitopia Save Editor logo to download new version")
            End If
        Catch ex As Exception
            MsgBox("An error has occured")
        End Try
    End Sub

    Private Sub MSE_logo_update_Click(sender As Object, e As EventArgs) Handles MSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Miitopia-Save-Editor-Switch-Version/releases")
    End Sub

    Private Sub Miitopia_Save_Editor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Checkupdates()
    End Sub
End Class
