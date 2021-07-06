Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_transferMii
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim Miiappareance As String
    Dim Mii_common_1 = &H2FC8 '&h800 x ? (Mii appareance, make up,...)
    Dim Mii_hero_1 = &HFCFD8 '&h340 x 10 (Mii equipment,jobs,...)
    Dim Mii_name_1 = &H2FE8
    Dim Mii_name_2 = &H37E8
    Dim Mii_name_3 = &H3FE8
    Dim Mii_name_4 = &H47E8
    Dim Mii_name_5 = &H4FE8
    Dim Mii_name_6 = &H57E8
    Dim Mii_name_7 = &H5FE8
    Dim Mii_name_8 = &H67E8
    Dim Mii_name_9 = &H6FE8
    Dim Mii_name_10 = &H77E8
    Dim Mii_name_11 = &H7FE8
    Dim Mii_name_12 = &H87E8
    Dim Mii_name_13 = &H8FE8
    Dim Mii_name_14 = &H97E8
    Dim Mii_name_15 = &H9FE8
    Dim Mii_name_16 = &HA7E8
    Dim Mii_name_17 = &HAFE8
    Dim Mii_name_18 = &HB7E8
    Dim Mii_name_19 = &HBFE8
    Dim Mii_name_20 = &HC7E8
    Dim Mii_name_21 = &HCFE8
    Dim Mii_name_22 = &HD7E8
    Dim Mii_name_23 = &HDFE8
    Dim Mii_name_24 = &HE7E8
    Dim Mii_name_25 = &HEFE8
    Dim Mii_name_26 = &HF7E8
    Dim Mii_name_27 = &HFFE8
    Dim Mii_name_28 = &H107E8
    Dim Mii_name_29 = &H10FE8
    Dim Mii_name_30 = &H117E8
    Dim Mii_name_31 = &H11FE8
    Dim Mii_name_32 = &H127E8
    Dim Mii_name_33 = &H12FE8
    Dim Mii_name_34 = &H137E8
    Dim Mii_name_35 = &H13FE8
    Dim Mii_name_36 = &H147E8
    Dim Mii_name_37 = &H14FE8
    Dim Mii_name_38 = &H157E8
    Dim Mii_name_39 = &H15FE8
    Dim Mii_name_40 = &H167E8
    Dim Mii_name_41 = &H16FE8
    Dim Mii_name_42 = &H177E8
    Dim Mii_name_43 = &H17FE8
    Dim Mii_name_44 = &H187E8
    Dim Mii_name_45 = &H18FE8
    Dim Mii_name_46 = &H197E8
    Dim Mii_name_47 = &H19FE8
    Dim Mii_name_48 = &H1A7E8
    Dim Mii_name_49 = &H1AFE8
    Dim Mii_name_50 = &H1B7E8
    Dim Mii_name_51 = &H1BFE8
    Dim Mii_name_52 = &H1C7E8
    Dim Mii_name_53 = &H1CFE8
    Dim Mii_name_54 = &H1D7E8
    Dim Mii_name_55 = &H1DFE8
    Dim Mii_name_56 = &H1E7E8
    Dim Mii_name_57 = &H1EFE8
    Dim Mii_name_58 = &H1F7E8
    Dim Mii_name_59 = &H1FFE8
    Dim Mii_name_60 = &H207E8
    Dim Mii_name_61 = &H20FE8
    Dim Mii_name_62 = &H217E8
    Dim Mii_name_63 = &H21FE8
    Dim Mii_name_64 = &H227E8
    Dim Mii_name_65 = &H22FE8
    Dim Mii_name_66 = &H237E8
    Dim Mii_name_67 = &H23FE8
    Dim Mii_name_68 = &H247E8
    Dim Mii_name_69 = &H24FE8
    Dim Mii_name_70 = &H257E8
    Dim Mii_name_71 = &H25FE8
    Dim Mii_name_72 = &H267E8
    Dim Mii_name_73 = &H26FE8
    Dim Mii_name_74 = &H277E8
    Dim Mii_name_75 = &H27FE8
    Dim Mii_name_76 = &H287E8
    Dim Mii_name_77 = &H28FE8
    Dim Mii_name_78 = &H297E8
    Dim Mii_name_79 = &H29FE8
    Dim Mii_name_80 = &H2A7E8
    Dim Mii_name_81 = &H2AFE8
    Dim Mii_name_82 = &H2B7E8
    Dim Mii_name_83 = &H2BFE8
    Dim Mii_name_84 = &H2C7E8
    Dim Mii_name_85 = &H2CFE8
    Dim Mii_name_86 = &H2D7E8
    Dim Mii_name_87 = &H2DFE8
    Dim Mii_name_88 = &H2E7E8
    Dim Mii_name_89 = &H2EFE8
    Dim Mii_name_90 = &H2F7E8
    Dim Mii_name_91 = &H2FFE8
    Dim Mii_name_92 = &H307E8
    Dim Mii_name_93 = &H30FE8
    Dim Mii_name_94 = &H317E8
    Dim Mii_name_95 = &H31FE8
    Dim Mii_name_96 = &H327E8
    Dim Mii_name_97 = &H32FE8
    Dim Mii_name_98 = &H337E8
    Dim Mii_name_99 = &H33FE8
    Dim Mii_name_100 = &H347E8
    Dim Mii_appareance_1 = &H3000
    Dim Mii_appareance_2 = &H3800
    Dim Mii_appareance_3 = &H4000
    Dim Mii_appareance_4 = &H4800
    Dim Mii_appareance_5 = &H5000
    Dim Mii_appareance_6 = &H5800
    Dim Mii_appareance_7 = &H6000
    Dim Mii_appareance_8 = &H6800
    Dim Mii_appareance_9 = &H7000
    Dim Mii_appareance_10 = &H7800
    Dim Mii_appareance_11 = &H8000
    Dim Mii_appareance_12 = &H8800
    Dim Mii_appareance_13 = &H9000
    Dim Mii_appareance_14 = &H9800
    Dim Mii_appareance_15 = &HA000
    Dim Mii_appareance_16 = &HA800
    Dim Mii_appareance_17 = &HB000
    Dim Mii_appareance_18 = &HB800
    Dim Mii_appareance_19 = &HC000
    Dim Mii_appareance_20 = &HC800
    Dim Mii_appareance_21 = &HD000
    Dim Mii_appareance_22 = &HD800
    Dim Mii_appareance_23 = &HE000
    Dim Mii_appareance_24 = &HE800
    Dim Mii_appareance_25 = &HF000
    Dim Mii_appareance_26 = &HF800
    Dim Mii_appareance_27 = &H10000
    Dim Mii_appareance_28 = &H10800
    Dim Mii_appareance_29 = &H11000
    Dim Mii_appareance_30 = &H11800
    Dim Mii_appareance_31 = &H12000
    Dim Mii_appareance_32 = &H12800
    Dim Mii_appareance_33 = &H13000
    Dim Mii_appareance_34 = &H13800
    Dim Mii_appareance_35 = &H14000
    Dim Mii_appareance_36 = &H14800
    Dim Mii_appareance_37 = &H15000
    Dim Mii_appareance_38 = &H15800
    Dim Mii_appareance_39 = &H16000
    Dim Mii_appareance_40 = &H16800
    Dim Mii_appareance_41 = &H17000
    Dim Mii_appareance_42 = &H17800
    Dim Mii_appareance_43 = &H18000
    Dim Mii_appareance_44 = &H18800
    Dim Mii_appareance_45 = &H19000
    Dim Mii_appareance_46 = &H19800
    Dim Mii_appareance_47 = &H1A000
    Dim Mii_appareance_48 = &H1A800
    Dim Mii_appareance_49 = &H1B000
    Dim Mii_appareance_50 = &H1B800
    Dim Mii_appareance_51 = &H1C000
    Dim Mii_appareance_52 = &H1C800
    Dim Mii_appareance_53 = &H1D000
    Dim Mii_appareance_54 = &H1D800
    Dim Mii_appareance_55 = &H1E000
    Dim Mii_appareance_56 = &H1E800
    Dim Mii_appareance_57 = &H1F000
    Dim Mii_appareance_58 = &H1F800
    Dim Mii_appareance_59 = &H20000
    Dim Mii_appareance_60 = &H20800
    Dim Mii_appareance_61 = &H21000
    Dim Mii_appareance_62 = &H21800
    Dim Mii_appareance_63 = &H22000
    Dim Mii_appareance_64 = &H22800
    Dim Mii_appareance_65 = &H23000
    Dim Mii_appareance_66 = &H23800
    Dim Mii_appareance_67 = &H24000
    Dim Mii_appareance_68 = &H24800
    Dim Mii_appareance_69 = &H25000
    Dim Mii_appareance_70 = &H25800
    Dim Mii_appareance_71 = &H26000
    Dim Mii_appareance_72 = &H26800
    Dim Mii_appareance_73 = &H27000
    Dim Mii_appareance_74 = &H27800
    Dim Mii_appareance_75 = &H28000
    Dim Mii_appareance_76 = &H28800
    Dim Mii_appareance_77 = &H29000
    Dim Mii_appareance_78 = &H29800
    Dim Mii_appareance_79 = &H2A000
    Dim Mii_appareance_80 = &H2A800
    Dim Mii_appareance_81 = &H2B000
    Dim Mii_appareance_82 = &H2B800
    Dim Mii_appareance_83 = &H2C000
    Dim Mii_appareance_84 = &H2C800
    Dim Mii_appareance_85 = &H2D000
    Dim Mii_appareance_86 = &H2D800
    Dim Mii_appareance_87 = &H2E000
    Dim Mii_appareance_88 = &H2E800
    Dim Mii_appareance_89 = &H2F000
    Dim Mii_appareance_90 = &H2F800
    Dim Mii_appareance_91 = &H30000
    Dim Mii_appareance_92 = &H30800
    Dim Mii_appareance_93 = &H31000
    Dim Mii_appareance_94 = &H31800
    Dim Mii_appareance_95 = &H32000
    Dim Mii_appareance_96 = &H32800
    Dim Mii_appareance_97 = &H33000
    Dim Mii_appareance_98 = &H33800
    Dim Mii_appareance_99 = &H34000
    Dim Mii_appareance_100 = &H34800

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
    Private Sub MSE_transferMii_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        MSE_hub.Text_filepath.Text = mainsav
    End Sub
    'end keep settings

    'load process
    Private Sub MSE_transferMii_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MSE_hub.Text_filepath.Text = Nothing Then
        Else
            ReadteamMiiname()
        End If
    End Sub

    Public Sub ReadteamMiiname()
        Try
            Dim ReadMiiname As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            ReadMiiname.Position = Mii_name_1
            Select_Mii.Items.Item(0) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_2
            Select_Mii.Items.Item(1) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_3
            Select_Mii.Items.Item(2) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_4
            Select_Mii.Items.Item(3) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_5
            Select_Mii.Items.Item(4) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_6
            Select_Mii.Items.Item(5) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_7
            Select_Mii.Items.Item(6) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_8
            Select_Mii.Items.Item(7) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_9
            Select_Mii.Items.Item(8) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_10
            Select_Mii.Items.Item(9) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_11
            Select_Mii.Items.Item(10) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_12
            Select_Mii.Items.Item(11) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_13
            Select_Mii.Items.Item(12) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_14
            Select_Mii.Items.Item(13) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_15
            Select_Mii.Items.Item(14) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_16
            Select_Mii.Items.Item(15) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_17
            Select_Mii.Items.Item(16) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_18
            Select_Mii.Items.Item(17) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_19
            Select_Mii.Items.Item(18) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_20
            Select_Mii.Items.Item(19) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_21
            Select_Mii.Items.Item(20) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_22
            Select_Mii.Items.Item(21) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_23
            Select_Mii.Items.Item(22) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_24
            Select_Mii.Items.Item(23) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_25
            Select_Mii.Items.Item(24) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_26
            Select_Mii.Items.Item(25) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_27
            Select_Mii.Items.Item(26) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_28
            Select_Mii.Items.Item(27) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_29
            Select_Mii.Items.Item(28) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_30
            Select_Mii.Items.Item(29) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_31
            Select_Mii.Items.Item(30) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_32
            Select_Mii.Items.Item(31) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_33
            Select_Mii.Items.Item(32) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_34
            Select_Mii.Items.Item(33) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_35
            Select_Mii.Items.Item(34) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_36
            Select_Mii.Items.Item(35) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_37
            Select_Mii.Items.Item(36) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_38
            Select_Mii.Items.Item(37) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_39
            Select_Mii.Items.Item(38) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_40
            Select_Mii.Items.Item(39) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_41
            Select_Mii.Items.Item(40) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_42
            Select_Mii.Items.Item(41) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_43
            Select_Mii.Items.Item(42) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_44
            Select_Mii.Items.Item(43) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_45
            Select_Mii.Items.Item(44) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_46
            Select_Mii.Items.Item(45) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_47
            Select_Mii.Items.Item(46) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_48
            Select_Mii.Items.Item(47) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_49
            Select_Mii.Items.Item(48) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_50
            Select_Mii.Items.Item(49) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_51
            Select_Mii.Items.Item(50) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_52
            Select_Mii.Items.Item(51) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_53
            Select_Mii.Items.Item(52) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_54
            Select_Mii.Items.Item(53) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_55
            Select_Mii.Items.Item(54) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_56
            Select_Mii.Items.Item(55) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_57
            Select_Mii.Items.Item(56) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_58
            Select_Mii.Items.Item(57) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_59
            Select_Mii.Items.Item(58) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_60
            Select_Mii.Items.Item(59) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_61
            Select_Mii.Items.Item(60) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_62
            Select_Mii.Items.Item(61) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_63
            Select_Mii.Items.Item(62) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_64
            Select_Mii.Items.Item(63) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_65
            Select_Mii.Items.Item(64) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_66
            Select_Mii.Items.Item(65) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_67
            Select_Mii.Items.Item(66) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_68
            Select_Mii.Items.Item(67) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_69
            Select_Mii.Items.Item(68) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_70
            Select_Mii.Items.Item(69) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_71
            Select_Mii.Items.Item(70) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_72
            Select_Mii.Items.Item(71) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_73
            Select_Mii.Items.Item(72) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_74
            Select_Mii.Items.Item(73) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_75
            Select_Mii.Items.Item(74) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_76
            Select_Mii.Items.Item(75) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_77
            Select_Mii.Items.Item(76) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_78
            Select_Mii.Items.Item(77) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_79
            Select_Mii.Items.Item(78) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_80
            Select_Mii.Items.Item(79) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_81
            Select_Mii.Items.Item(80) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_82
            Select_Mii.Items.Item(81) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_83
            Select_Mii.Items.Item(82) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_84
            Select_Mii.Items.Item(83) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_85
            Select_Mii.Items.Item(84) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_86
            Select_Mii.Items.Item(85) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_87
            Select_Mii.Items.Item(86) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_88
            Select_Mii.Items.Item(87) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_89
            Select_Mii.Items.Item(88) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_90
            Select_Mii.Items.Item(89) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_91
            Select_Mii.Items.Item(90) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_92
            Select_Mii.Items.Item(91) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_93
            Select_Mii.Items.Item(92) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_94
            Select_Mii.Items.Item(93) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_95
            Select_Mii.Items.Item(94) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_96
            Select_Mii.Items.Item(95) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_97
            Select_Mii.Items.Item(96) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_98
            Select_Mii.Items.Item(97) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_99
            Select_Mii.Items.Item(98) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_100
            Select_Mii.Items.Item(99) = ReadMiiname.ReadUnicodeString(10)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Select_Mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Mii.SelectedIndexChanged
        ReadMiiappareance()
        Text_Miiname.Text = Select_Mii.SelectedItem
    End Sub

    Public Sub ReadMiiappareance()
        Try
            Dim ReadMiiapp As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                ReadMiiapp.Position = Mii_appareance_1
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                ReadMiiapp.Position = Mii_appareance_2
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                ReadMiiapp.Position = Mii_appareance_3
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                ReadMiiapp.Position = Mii_appareance_4
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                ReadMiiapp.Position = Mii_appareance_5
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                ReadMiiapp.Position = Mii_appareance_6
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                ReadMiiapp.Position = Mii_appareance_7
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                ReadMiiapp.Position = Mii_appareance_8
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                ReadMiiapp.Position = Mii_appareance_9
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                ReadMiiapp.Position = Mii_appareance_10
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(10) Then
                ReadMiiapp.Position = Mii_appareance_11
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(11) Then
                ReadMiiapp.Position = Mii_appareance_12
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(12) Then
                ReadMiiapp.Position = Mii_appareance_13
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(13) Then
                ReadMiiapp.Position = Mii_appareance_14
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(14) Then
                ReadMiiapp.Position = Mii_appareance_15
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(15) Then
                ReadMiiapp.Position = Mii_appareance_16
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(16) Then
                ReadMiiapp.Position = Mii_appareance_17
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(17) Then
                ReadMiiapp.Position = Mii_appareance_18
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(18) Then
                ReadMiiapp.Position = Mii_appareance_19
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(19) Then
                ReadMiiapp.Position = Mii_appareance_20
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(20) Then
                ReadMiiapp.Position = Mii_appareance_21
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(21) Then
                ReadMiiapp.Position = Mii_appareance_22
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(22) Then
                ReadMiiapp.Position = Mii_appareance_23
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(23) Then
                ReadMiiapp.Position = Mii_appareance_24
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(24) Then
                ReadMiiapp.Position = Mii_appareance_25
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(25) Then
                ReadMiiapp.Position = Mii_appareance_26
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(26) Then
                ReadMiiapp.Position = Mii_appareance_27
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(27) Then
                ReadMiiapp.Position = Mii_appareance_28
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(28) Then
                ReadMiiapp.Position = Mii_appareance_29
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(29) Then
                ReadMiiapp.Position = Mii_appareance_30
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(30) Then
                ReadMiiapp.Position = Mii_appareance_31
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(31) Then
                ReadMiiapp.Position = Mii_appareance_32
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(32) Then
                ReadMiiapp.Position = Mii_appareance_33
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(33) Then
                ReadMiiapp.Position = Mii_appareance_34
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(34) Then
                ReadMiiapp.Position = Mii_appareance_35
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(35) Then
                ReadMiiapp.Position = Mii_appareance_36
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(36) Then
                ReadMiiapp.Position = Mii_appareance_37
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(37) Then
                ReadMiiapp.Position = Mii_appareance_38
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(38) Then
                ReadMiiapp.Position = Mii_appareance_39
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(39) Then
                ReadMiiapp.Position = Mii_appareance_40
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(40) Then
                ReadMiiapp.Position = Mii_appareance_41
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(41) Then
                ReadMiiapp.Position = Mii_appareance_42
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(42) Then
                ReadMiiapp.Position = Mii_appareance_43
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(43) Then
                ReadMiiapp.Position = Mii_appareance_44
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(44) Then
                ReadMiiapp.Position = Mii_appareance_45
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(45) Then
                ReadMiiapp.Position = Mii_appareance_46
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(46) Then
                ReadMiiapp.Position = Mii_appareance_47
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(47) Then
                ReadMiiapp.Position = Mii_appareance_48
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(48) Then
                ReadMiiapp.Position = Mii_appareance_49
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(49) Then
                ReadMiiapp.Position = Mii_appareance_50
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(50) Then
                ReadMiiapp.Position = Mii_appareance_51
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(51) Then
                ReadMiiapp.Position = Mii_appareance_52
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(52) Then
                ReadMiiapp.Position = Mii_appareance_53
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(53) Then
                ReadMiiapp.Position = Mii_appareance_54
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(54) Then
                ReadMiiapp.Position = Mii_appareance_55
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(55) Then
                ReadMiiapp.Position = Mii_appareance_56
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(56) Then
                ReadMiiapp.Position = Mii_appareance_57
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(57) Then
                ReadMiiapp.Position = Mii_appareance_58
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(58) Then
                ReadMiiapp.Position = Mii_appareance_59
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(59) Then
                ReadMiiapp.Position = Mii_appareance_60
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(60) Then
                ReadMiiapp.Position = Mii_appareance_61
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(61) Then
                ReadMiiapp.Position = Mii_appareance_62
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(62) Then
                ReadMiiapp.Position = Mii_appareance_63
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(63) Then
                ReadMiiapp.Position = Mii_appareance_64
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(64) Then
                ReadMiiapp.Position = Mii_appareance_65
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(65) Then
                ReadMiiapp.Position = Mii_appareance_66
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(66) Then
                ReadMiiapp.Position = Mii_appareance_67
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(67) Then
                ReadMiiapp.Position = Mii_appareance_68
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(68) Then
                ReadMiiapp.Position = Mii_appareance_69
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(69) Then
                ReadMiiapp.Position = Mii_appareance_70
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(70) Then
                ReadMiiapp.Position = Mii_appareance_71
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(71) Then
                ReadMiiapp.Position = Mii_appareance_72
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(72) Then
                ReadMiiapp.Position = Mii_appareance_73
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(73) Then
                ReadMiiapp.Position = Mii_appareance_74
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(74) Then
                ReadMiiapp.Position = Mii_appareance_75
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(75) Then
                ReadMiiapp.Position = Mii_appareance_76
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(76) Then
                ReadMiiapp.Position = Mii_appareance_77
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(77) Then
                ReadMiiapp.Position = Mii_appareance_78
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(78) Then
                ReadMiiapp.Position = Mii_appareance_79
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(79) Then
                ReadMiiapp.Position = Mii_appareance_80
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(80) Then
                ReadMiiapp.Position = Mii_appareance_81
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(81) Then
                ReadMiiapp.Position = Mii_appareance_82
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(82) Then
                ReadMiiapp.Position = Mii_appareance_83
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(83) Then
                ReadMiiapp.Position = Mii_appareance_84
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(84) Then
                ReadMiiapp.Position = Mii_appareance_85
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(85) Then
                ReadMiiapp.Position = Mii_appareance_86
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(86) Then
                ReadMiiapp.Position = Mii_appareance_87
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(87) Then
                ReadMiiapp.Position = Mii_appareance_88
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(88) Then
                ReadMiiapp.Position = Mii_appareance_89
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(89) Then
                ReadMiiapp.Position = Mii_appareance_90
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(90) Then
                ReadMiiapp.Position = Mii_appareance_91
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(91) Then
                ReadMiiapp.Position = Mii_appareance_92
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(92) Then
                ReadMiiapp.Position = Mii_appareance_93
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(93) Then
                ReadMiiapp.Position = Mii_appareance_94
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(94) Then
                ReadMiiapp.Position = Mii_appareance_95
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(95) Then
                ReadMiiapp.Position = Mii_appareance_96
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(96) Then
                ReadMiiapp.Position = Mii_appareance_97
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(97) Then
                ReadMiiapp.Position = Mii_appareance_98
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(98) Then
                ReadMiiapp.Position = Mii_appareance_99
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(99) Then
                ReadMiiapp.Position = Mii_appareance_100
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read main.sav Mii appareance" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Icon_extract_Click(sender As Object, e As EventArgs) Handles Icon_extract.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Miitopia Mii|*.MiitopiaMiA"
            SaveFileDialog1.FileName = "Miiappareance_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                Writer1.Close()
                Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                Writer.WriteHexString(Text_Mii_appareanceE.Text)
                MSE_dialog.text_dialog.Text = "Mii appareance has been successfully extracted"
                MSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to extract Mii appareance" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Icon_extract_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_extract.MouseMove
        Text_description.Text = "Click to export your Mii appareance"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_extract_MouseLeave(sender As Object, e As EventArgs) Handles Icon_extract.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_import_Click(sender As Object, e As EventArgs) Handles Icon_import.Click
        Dim open As New OpenFileDialog

        MSE_dialog.text_dialog.Text = "Open a Miitopia Mii appareance file" & vbNewLine & "Current Mii appareance will be replace by Mii appareance in Miitopia Mii appareance file" & vbNewLine & vbNewLine & "Do you want to continue ?"
        MSE_dialog.MSE_dialog_panelbuttons.Visible = True
        MSE_dialog.ShowDialog()

        If MSE_dialog.DialogResult = Windows.Forms.DialogResult.OK Then
            open.Filter = "Mii appareance file|*.MiitopiaMiA"
            open.Title = "Open a Miitopia Mii appareance file"
            open.ShowDialog()
            Miiappareance = open.FileName
            Try
                Dim ReadMiA As New PackageIO.Reader(Miiappareance, PackageIO.Endian.Little)
                ReadMiA.Position = &H0
                Text_Mii_appareanceI.Text = ReadMiA.ReadHexString(&H7C8)
                ReadMiA.Close()
            Catch ex As Exception
                MSE_dialog.text_dialog.Text = "Failed to read Miitopia Mii appareance file" & vbNewLine & "Select a valid Miitopia Mii appareance file or report this issue"
                MSE_dialog.ShowDialog()
            End Try
            Try
                Dim Writer As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                    Writer.Position = Mii_appareance_1
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                    Writer.Position = Mii_appareance_2
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Writer.Position = Mii_appareance_3
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                    Writer.Position = Mii_appareance_4
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                    Writer.Position = Mii_appareance_5
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                    Writer.Position = Mii_appareance_6
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                    Writer.Position = Mii_appareance_7
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                    Writer.Position = Mii_appareance_8
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                    Writer.Position = Mii_appareance_9
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                    Writer.Position = Mii_appareance_10
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(10) Then
                    Writer.Position = Mii_appareance_11
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(11) Then
                    Writer.Position = Mii_appareance_12
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(12) Then
                    Writer.Position = Mii_appareance_13
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(13) Then
                    Writer.Position = Mii_appareance_14
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(14) Then
                    Writer.Position = Mii_appareance_15
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(15) Then
                    Writer.Position = Mii_appareance_16
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(16) Then
                    Writer.Position = Mii_appareance_17
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(17) Then
                    Writer.Position = Mii_appareance_18
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(18) Then
                    Writer.Position = Mii_appareance_19
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(19) Then
                    Writer.Position = Mii_appareance_20
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(20) Then
                    Writer.Position = Mii_appareance_21
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(21) Then
                    Writer.Position = Mii_appareance_22
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(22) Then
                    Writer.Position = Mii_appareance_23
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(23) Then
                    Writer.Position = Mii_appareance_24
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(24) Then
                    Writer.Position = Mii_appareance_25
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(25) Then
                    Writer.Position = Mii_appareance_26
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(26) Then
                    Writer.Position = Mii_appareance_27
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(27) Then
                    Writer.Position = Mii_appareance_28
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(28) Then
                    Writer.Position = Mii_appareance_29
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(29) Then
                    Writer.Position = Mii_appareance_30
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(30) Then
                    Writer.Position = Mii_appareance_31
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(31) Then
                    Writer.Position = Mii_appareance_32
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(32) Then
                    Writer.Position = Mii_appareance_33
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(33) Then
                    Writer.Position = Mii_appareance_34
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(34) Then
                    Writer.Position = Mii_appareance_35
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(35) Then
                    Writer.Position = Mii_appareance_36
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(36) Then
                    Writer.Position = Mii_appareance_37
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(37) Then
                    Writer.Position = Mii_appareance_38
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(38) Then
                    Writer.Position = Mii_appareance_39
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(39) Then
                    Writer.Position = Mii_appareance_40
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(40) Then
                    Writer.Position = Mii_appareance_41
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(41) Then
                    Writer.Position = Mii_appareance_42
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(42) Then
                    Writer.Position = Mii_appareance_43
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(43) Then
                    Writer.Position = Mii_appareance_44
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(44) Then
                    Writer.Position = Mii_appareance_45
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(45) Then
                    Writer.Position = Mii_appareance_46
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(46) Then
                    Writer.Position = Mii_appareance_47
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(47) Then
                    Writer.Position = Mii_appareance_48
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(48) Then
                    Writer.Position = Mii_appareance_49
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(49) Then
                    Writer.Position = Mii_appareance_50
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(50) Then
                    Writer.Position = Mii_appareance_51
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(51) Then
                    Writer.Position = Mii_appareance_52
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(52) Then
                    Writer.Position = Mii_appareance_53
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(53) Then
                    Writer.Position = Mii_appareance_54
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(54) Then
                    Writer.Position = Mii_appareance_55
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(55) Then
                    Writer.Position = Mii_appareance_56
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(56) Then
                    Writer.Position = Mii_appareance_57
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(57) Then
                    Writer.Position = Mii_appareance_58
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(58) Then
                    Writer.Position = Mii_appareance_59
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(59) Then
                    Writer.Position = Mii_appareance_60
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(60) Then
                    Writer.Position = Mii_appareance_61
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(61) Then
                    Writer.Position = Mii_appareance_62
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(62) Then
                    Writer.Position = Mii_appareance_63
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(63) Then
                    Writer.Position = Mii_appareance_64
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(64) Then
                    Writer.Position = Mii_appareance_65
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(65) Then
                    Writer.Position = Mii_appareance_66
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(66) Then
                    Writer.Position = Mii_appareance_67
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(67) Then
                    Writer.Position = Mii_appareance_68
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(68) Then
                    Writer.Position = Mii_appareance_69
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(69) Then
                    Writer.Position = Mii_appareance_70
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(70) Then
                    Writer.Position = Mii_appareance_71
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(71) Then
                    Writer.Position = Mii_appareance_72
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(72) Then
                    Writer.Position = Mii_appareance_73
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(73) Then
                    Writer.Position = Mii_appareance_74
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(74) Then
                    Writer.Position = Mii_appareance_75
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(75) Then
                    Writer.Position = Mii_appareance_76
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(76) Then
                    Writer.Position = Mii_appareance_77
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(77) Then
                    Writer.Position = Mii_appareance_78
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(78) Then
                    Writer.Position = Mii_appareance_79
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(79) Then
                    Writer.Position = Mii_appareance_80
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(80) Then
                    Writer.Position = Mii_appareance_81
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(81) Then
                    Writer.Position = Mii_appareance_82
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(82) Then
                    Writer.Position = Mii_appareance_83
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(83) Then
                    Writer.Position = Mii_appareance_84
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(84) Then
                    Writer.Position = Mii_appareance_85
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(85) Then
                    Writer.Position = Mii_appareance_86
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(86) Then
                    Writer.Position = Mii_appareance_87
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(87) Then
                    Writer.Position = Mii_appareance_88
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(88) Then
                    Writer.Position = Mii_appareance_89
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(89) Then
                    Writer.Position = Mii_appareance_90
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(90) Then
                    Writer.Position = Mii_appareance_91
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(91) Then
                    Writer.Position = Mii_appareance_92
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(92) Then
                    Writer.Position = Mii_appareance_93
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(93) Then
                    Writer.Position = Mii_appareance_94
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(94) Then
                    Writer.Position = Mii_appareance_95
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(95) Then
                    Writer.Position = Mii_appareance_96
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(96) Then
                    Writer.Position = Mii_appareance_97
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(97) Then
                    Writer.Position = Mii_appareance_98
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(98) Then
                    Writer.Position = Mii_appareance_99
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(99) Then
                    Writer.Position = Mii_appareance_100
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                MSE_dialog.text_dialog.Text = "This Mii appareance has been successfully replaced, you will be back to menu"
                MSE_dialog.ShowDialog()
                MSE_hub.Show()
                Me.Close()
            Catch ex As Exception
                MSE_dialog.text_dialog.Text = "Failed to write Mii appareance" & vbNewLine & "Make sure you have opened a Miitopia save file before or report this issue"
                MSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Icon_import_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_import.MouseMove
        Text_description.Text = "Click to import a Mii appareance"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_import_MouseLeave(sender As Object, e As EventArgs) Handles Icon_import.MouseLeave
        Panel_description.Visible = False
    End Sub
End Class