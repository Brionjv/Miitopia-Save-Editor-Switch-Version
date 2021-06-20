Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_horse
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim horsename = &H1376A8
    Dim gender = &H1376BE
    Dim Ho_appareance = &H1377F0 '&he0
    Dim Horseappareance As String

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

    Private Sub valu_gender_ValueChanged(sender As Object, e As EventArgs) Handles valu_gender.ValueChanged
        If valu_gender.Value = 0 Then
            Icon_gender_boy.BorderStyle = BorderStyle.FixedSingle
            Icon_gender_girl.BorderStyle = BorderStyle.None
        End If
        If valu_gender.Value = 1 Then
            Icon_gender_boy.BorderStyle = BorderStyle.None
            Icon_gender_girl.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    Private Sub Icon_gender_boy_Click(sender As Object, e As EventArgs) Handles Icon_gender_boy.Click
        valu_gender.Value = 0
    End Sub

    Private Sub Icon_gender_girl_Click(sender As Object, e As EventArgs) Handles Icon_gender_girl.Click
        valu_gender.Value = 1
    End Sub

    'keep settings
    Private Sub MSE_horse_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        MSE_hub.Text_filepath.Text = mainsav
    End Sub
    'end keep settings

    'load process
    Private Sub MSE_horse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MSE_hub.Text_filepath.Text = Nothing Then
        Else
            ReadMSEhorse()
        End If
    End Sub

    Public Sub ReadMSEhorse()
        Try
            Dim ReadHorse As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            ReadHorse.Position = horsename
            Text_horsename.Text = ReadHorse.ReadUnicodeString(10)
            ReadHorse.Position = gender
            valu_gender.Value = ReadHorse.ReadByte
            ReadHorse.Position = Ho_appareance
            Text_Ho_appareance.Text = ReadHorse.ReadHexString(&HE0)
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read main.sav horse" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Icon_extract_Click(sender As Object, e As EventArgs) Handles Icon_extract.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Miitopia Horse|*.MiitopiaHoA"
            SaveFileDialog1.FileName = "Horseappareance_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                Writer1.Close()
                Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                Writer.WriteHexString(Text_Ho_appareance.Text)
                MSE_dialog.text_dialog.Text = "Horse appareance has been successfully extracted"
                MSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to extract horse" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Icon_extract_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_extract.MouseMove
        Text_description.Text = "Click to extract your horse appareance"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_extract_MouseLeave(sender As Object, e As EventArgs) Handles Icon_extract.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_import_Click(sender As Object, e As EventArgs) Handles Icon_import.Click
        Dim open As New OpenFileDialog

        MSE_dialog.text_dialog.Text = "Open a Miitopia Horse appareance file" & vbNewLine & "Current horse appareance will be replace by horse appareance in Miitopia horse appareance file" & vbNewLine & vbNewLine & "Do you want to continue ?"
        MSE_dialog.MSE_dialog_panelbuttons.Visible = True
        MSE_dialog.ShowDialog()

        If MSE_dialog.DialogResult = Windows.Forms.DialogResult.OK Then
            open.Filter = "Horse appareance file|*.MiitopiaHoA"
            open.Title = "Open a Miitopia Horse appareance file"
            open.ShowDialog()
            Horseappareance = open.FileName
            Try
                Dim ReadHoA As New PackageIO.Reader(Horseappareance, PackageIO.Endian.Little)
                ReadHoA.Position = &H0
                Text_globalhorse.Text = ReadHoA.ReadHexString(&HE0)
                ReadHoA.Close()
            Catch ex As Exception
                MSE_dialog.text_dialog.Text = "Failed to read Miitopia Horse appareance file" & vbNewLine & "Select a valid Miitopia horse appareance file or report this issue"
                MSE_dialog.ShowDialog()
            End Try
            Try
                Dim Writer As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                Writer.Position = Ho_appareance
                Writer.WriteHexString(Text_globalhorse.Text)
                MSE_dialog.text_dialog.Text = "This Horse appareance has been successfully replaced, you will be back to menu"
                MSE_dialog.ShowDialog()
                MSE_hub.Show()
                Me.Close()
            Catch ex As Exception
                MSE_dialog.text_dialog.Text = "Failed to write Horse appareance" & vbNewLine & "Make sure you have opened a Miitopia save file before or report this issue"
                MSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Icon_import_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_import.MouseMove
        Text_description.Text = "Click to import a horse appareance"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_import_MouseLeave(sender As Object, e As EventArgs) Handles Icon_import.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        WriteMSEhorse()
    End Sub

    Public Sub WriteMSEhorse()
        Try
            Dim WriteHorse As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
            For i As Integer = 0 To 19
                WriteHorse.Position = horsename + i
                WriteHorse.WriteInt8(0)
            Next
            WriteHorse.Position = horsename
            WriteHorse.WriteUnicodeString(Text_horsename.Text)
            WriteHorse.Position = gender
            WriteHorse.WriteInt8(valu_gender.Value)
            MSE_dialog.text_dialog.Text = "Horse has been succefully edited"
            MSE_dialog.ShowDialog()
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to write horse" & vbNewLine & "Check if your save file is not used with an other application or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub


End Class