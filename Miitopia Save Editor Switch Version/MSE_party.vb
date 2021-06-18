Imports System
Imports PackageIO
Imports System.IO

Public Class MSE_party
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim worldparty = &H2D
    Dim whereparty = &H2C
    Dim dragon = &H2F
    Dim levelparty = &H2E

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

    Private Sub Icon_dragon_Click(sender As Object, e As EventArgs) Handles Icon_dragon.Click
        If valu_dragon.Value >= 2 Or valu_dragon.Value = 0 Then
            valu_dragon.Value = 1
        ElseIf valu_dragon.Value = 1 Then
            valu_dragon.Value = 255
        End If
    End Sub

    Private Sub valu_dragon_ValueChanged(sender As Object, e As EventArgs) Handles valu_dragon.ValueChanged
        If valu_dragon.Value >= 2 Or valu_dragon.Value = 0 Then
            Icon_dragon.Image = My.Resources.icon_dragon_off
        ElseIf valu_dragon.Value = 1 Then
            Icon_dragon.Image = My.Resources.icon_dragon_on1
        End If
    End Sub

    Private Sub icon_party_Click(sender As Object, e As EventArgs) Handles icon_party.Click
        If valu_party.Value = 0 Then
            valu_party.Value = 1
        ElseIf valu_party.Value = 1 Then
            valu_party.Value = 2
        ElseIf valu_party.Value = 2 Then
            valu_party.Value = 0
        End If
    End Sub

    Private Sub valu_party_ValueChanged(sender As Object, e As EventArgs) Handles valu_party.ValueChanged
        If valu_party.Value = 0 Then
            icon_party.Image = My.Resources.icon_inn
        ElseIf valu_party.Value = 1 Then
            icon_party.Image = My.Resources.icon_level
        ElseIf valu_party.Value = 2 Then
            icon_party.Image = My.Resources.icon_overworld
        End If
    End Sub

    Private Sub valu_world_ValueChanged(sender As Object, e As EventArgs) Handles valu_world.ValueChanged
        If valu_world.Value = 0 Then
            Select_world.SelectedItem = Select_world.Items.Item(0)
        ElseIf valu_world.Value = 1 Then
            Select_world.SelectedItem = Select_world.Items.Item(1)
        ElseIf valu_world.Value = 2 Then
            Select_world.SelectedItem = Select_world.Items.Item(2)
        ElseIf valu_world.Value = 3 Then
            Select_world.SelectedItem = Select_world.Items.Item(3)
        ElseIf valu_world.Value = 4 Then
            Select_world.SelectedItem = Select_world.Items.Item(4)
        ElseIf valu_world.Value = 5 Then
            Select_world.SelectedItem = Select_world.Items.Item(5)
        ElseIf valu_world.Value = 6 Then
            Select_world.SelectedItem = Select_world.Items.Item(6)
        ElseIf valu_world.Value = 7 Then
            Select_world.SelectedItem = Select_world.Items.Item(7)
        ElseIf valu_world.Value = 8 Then
            Select_world.SelectedItem = Select_world.Items.Item(8)
        ElseIf valu_world.Value = 9 Then
            Select_world.SelectedItem = Select_world.Items.Item(9)
        ElseIf valu_world.Value = 10 Then
            Select_world.SelectedItem = Select_world.Items.Item(10)
        ElseIf valu_world.Value = 11 Then
            Select_world.SelectedItem = Select_world.Items.Item(11)
        ElseIf valu_world.Value = 12 Then
            Select_world.SelectedItem = Select_world.Items.Item(12)
        ElseIf valu_world.Value = 13 Then
            Select_world.SelectedItem = Select_world.Items.Item(13)
        ElseIf valu_world.Value = 14 Then
            Select_world.SelectedItem = Select_world.Items.Item(14)
        ElseIf valu_world.Value = 15 Then
            Select_world.SelectedItem = Select_world.Items.Item(15)
        ElseIf valu_world.Value = 16 Then
            Select_world.SelectedItem = Select_world.Items.Item(16)
        ElseIf valu_world.Value = 17 Then
            Select_world.SelectedItem = Select_world.Items.Item(17)
        ElseIf valu_world.Value = 18 Then
            Select_world.SelectedItem = Select_world.Items.Item(18)
        ElseIf valu_world.Value = 19 Then
            Select_world.SelectedItem = Select_world.Items.Item(19)
        ElseIf valu_world.Value = 20 Then
            Select_world.SelectedItem = Select_world.Items.Item(20)
        ElseIf valu_world.Value = 21 Then
            Select_world.SelectedItem = Select_world.Items.Item(21)
        ElseIf valu_world.Value = 22 Then
            Select_world.SelectedItem = Select_world.Items.Item(22)
        ElseIf valu_world.Value = 23 Then
            Select_world.SelectedItem = Select_world.Items.Item(23)
        ElseIf valu_world.Value = 24 Then
            Select_world.SelectedItem = Select_world.Items.Item(24)
        ElseIf valu_world.Value = 25 Then
            Select_world.SelectedItem = Select_world.Items.Item(25)
        ElseIf valu_world.Value = 26 Then
            Select_world.SelectedItem = Select_world.Items.Item(26)
        ElseIf valu_world.Value = 27 Then
            Select_world.SelectedItem = Select_world.Items.Item(27)
        ElseIf valu_world.Value = 28 Then
            Select_world.SelectedItem = Select_world.Items.Item(28)
        ElseIf valu_world.Value = 29 Then
            Select_world.SelectedItem = Select_world.Items.Item(29)
        ElseIf valu_world.Value = 30 Then
            Select_world.SelectedItem = Select_world.Items.Item(30)
        ElseIf valu_world.Value = 31 Then
            Select_world.SelectedItem = Select_world.Items.Item(31)
        ElseIf valu_world.Value = 32 Then
            Select_world.SelectedItem = Select_world.Items.Item(32)
        ElseIf valu_world.Value = 33 Then
            Select_world.SelectedItem = Select_world.Items.Item(33)
        ElseIf valu_world.Value = 34 Then
            Select_world.SelectedItem = Select_world.Items.Item(34)
        ElseIf valu_world.Value = 35 Then
            Select_world.SelectedItem = Select_world.Items.Item(35)
        ElseIf valu_world.Value = 36 Then
            Select_world.SelectedItem = Select_world.Items.Item(36)
        ElseIf valu_world.Value = 37 Then
            Select_world.SelectedItem = Select_world.Items.Item(37)
        ElseIf valu_world.Value = 38 Then
            Select_world.SelectedItem = Select_world.Items.Item(38)
        ElseIf valu_world.Value = 39 Then
            Select_world.SelectedItem = Select_world.Items.Item(39)
        ElseIf valu_world.Value = 40 Then
            Select_world.SelectedItem = Select_world.Items.Item(40)
        ElseIf valu_world.Value = 41 Then
            Select_world.SelectedItem = Select_world.Items.Item(41)
        ElseIf valu_world.Value = 42 Then
            Select_world.SelectedItem = Select_world.Items.Item(42)
        ElseIf valu_world.Value = 43 Then
            Select_world.SelectedItem = Select_world.Items.Item(43)
        End If
    End Sub

    Private Sub Select_world_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_world.SelectedIndexChanged
        If Select_world.SelectedItem = Select_world.Items.Item(0) Then
            valu_world.Value = 0
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(1) Then
            valu_world.Value = 1
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(2) Then
            valu_world.Value = 2
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(3) Then
            valu_world.Value = 3
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(4) Then
            valu_world.Value = 4
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(5) Then
            valu_world.Value = 5
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(6) Then
            valu_world.Value = 6
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(7) Then
            valu_world.Value = 7
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(8) Then
            valu_world.Value = 8
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(9) Then
            valu_world.Value = 9
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(10) Then
            valu_world.Value = 10
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(11) Then
            valu_world.Value = 11
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(12) Then
            valu_world.Value = 12
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(13) Then
            valu_world.Value = 13
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(14) Then
            valu_world.Value = 14
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(15) Then
            valu_world.Value = 15
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(16) Then
            valu_world.Value = 16
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(17) Then
            valu_world.Value = 17
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(18) Then
            valu_world.Value = 18
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(19) Then
            valu_world.Value = 19
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(20) Then
            valu_world.Value = 20
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(21) Then
            valu_world.Value = 21
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(22) Then
            valu_world.Value = 22
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(23) Then
            valu_world.Value = 23
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(24) Then
            valu_world.Value = 24
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(25) Then
            valu_world.Value = 25
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(26) Then
            valu_world.Value = 26
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(27) Then
            valu_world.Value = 27
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(28) Then
            valu_world.Value = 28
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(29) Then
            valu_world.Value = 29
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(30) Then
            valu_world.Value = 30
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(31) Then
            valu_world.Value = 31
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(32) Then
            valu_world.Value = 32
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(33) Then
            valu_world.Value = 33
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(34) Then
            valu_world.Value = 34
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(35) Then
            valu_world.Value = 35
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(36) Then
            valu_world.Value = 36
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(37) Then
            valu_world.Value = 37
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(38) Then
            valu_world.Value = 38
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(39) Then
            valu_world.Value = 39
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(40) Then
            valu_world.Value = 40
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(41) Then
            valu_world.Value = 41
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(42) Then
            valu_world.Value = 42
        ElseIf Select_world.SelectedItem = Select_world.Items.Item(43) Then
            valu_world.Value = 43
        End If
    End Sub

    'load process
    Private Sub MSE_party_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select_world.SelectedItem = Select_world.Items.Item(0)
        If MSE_hub.Text_filepath.Text = Nothing Then
        Else
            ReadMSEparty()
        End If
    End Sub

    Public Sub ReadMSEparty()
        Try
            Dim ReadParty As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            ReadParty.Position = worldparty
            valu_world.Value = ReadParty.ReadByte
            ReadParty.Position = whereparty
            valu_party.Value = ReadParty.ReadByte
            ReadParty.Position = dragon
            valu_dragon.Value = ReadParty.ReadByte
            ReadParty.Position = levelparty
            valu_level.Value = ReadParty.ReadByte
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read main.sav party" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub
    'end load process

    'keep settings
    Private Sub MSE_party_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        MSE_hub.Text_filepath.Text = mainsav
    End Sub
    'end keep settings

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        WriteMSEparty()
    End Sub

    Public Sub WriteMSEparty()
        Try
            Dim WriteBparty As New System.IO.FileStream(CStr(mainsav), FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            WriteBparty.Position = worldparty
            WriteBparty.WriteByte(valu_world.Value)
            WriteBparty.Position = whereparty
            WriteBparty.WriteByte(valu_party.Value)
            WriteBparty.Position = dragon
            WriteBparty.WriteByte(valu_dragon.Value)
            WriteBparty.Position = levelparty
            WriteBparty.WriteByte(valu_level.Value)

            MSE_dialog.text_dialog.Text = "Party has been succefully edited"
            MSE_dialog.ShowDialog()
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to write party" & vbNewLine & "Check if your save file is not used with an other application or report this issue"
            MSE_dialog.ShowDialog()
        End Try

    End Sub

    Private Sub Icon_dragon_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_dragon.MouseMove
        Text_description.Text = "Click to mount on the dragon"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_dragon_MouseLeave(sender As Object, e As EventArgs) Handles Icon_dragon.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub icon_party_MouseMove(sender As Object, e As MouseEventArgs) Handles icon_party.MouseMove
        Text_description.Text = "Click to edit where the party is"
        Panel_description.Visible = True
    End Sub

    Private Sub icon_party_MouseLeave(sender As Object, e As EventArgs) Handles icon_party.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Iconwar_partylevel_Click(sender As Object, e As EventArgs) Handles Iconwar_partylevel.Click
        MSE_dialog.text_dialog.Text = "If you are stuck in a level, edit with an other value"
        MSE_dialog.ShowDialog()
    End Sub
End Class