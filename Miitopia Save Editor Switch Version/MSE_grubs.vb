Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_grubs
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim Grubsstart = &H3C 'x196

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
    Private Sub MSE_grubs_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        MSE_hub.Text_filepath.Text = mainsav
    End Sub
    'end keep settings

    'load process
    Private Sub MSE_horse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MSE_hub.Text_filepath.Text = Nothing Then
        Else
            ReadMSEgrubs()
        End If
    End Sub

    Public Sub ReadMSEgrubs()
        Try
            Dim ReadGrubs As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            ReadGrubs.Position = &H3C
            valu_grub_1.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H3D
            valu_grub_2.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H3E
            valu_grub_3.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H3F
            valu_grub_4.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H40
            valu_grub_5.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H41
            valu_grub_6.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H42
            valu_grub_7.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H43
            valu_grub_8.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H44
            valu_grub_9.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H45
            valu_grub_10.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H46
            valu_grub_11.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H47
            valu_grub_12.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H48
            valu_grub_13.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H49
            valu_grub_14.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H4A
            valu_grub_15.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H4B
            valu_grub_16.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H4C
            valu_grub_17.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H4D
            valu_grub_18.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H4E
            valu_grub_19.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H4F
            valu_grub_20.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H50
            valu_grub_21.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H51
            valu_grub_22.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H52
            valu_grub_23.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H53
            valu_grub_24.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H54
            valu_grub_25.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H55
            valu_grub_26.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H56
            valu_grub_27.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H57
            valu_grub_28.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H58
            valu_grub_29.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H59
            valu_grub_30.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H5A
            valu_grub_31.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H5B
            valu_grub_32.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H5C
            valu_grub_33.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H5D
            valu_grub_34.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H5E
            valu_grub_35.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H5F
            valu_grub_36.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H60
            valu_grub_37.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H61
            valu_grub_38.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H62
            valu_grub_39.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H63
            valu_grub_40.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H64
            valu_grub_41.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H65
            valu_grub_42.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H66
            valu_grub_43.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H67
            valu_grub_44.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H68
            valu_grub_45.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H69
            valu_grub_46.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H6A
            valu_grub_47.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H6B
            valu_grub_48.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H6C
            valu_grub_49.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H6D
            valu_grub_50.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H6E
            valu_grub_51.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H6F
            valu_grub_52.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H70
            valu_grub_53.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H71
            valu_grub_54.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H72
            valu_grub_55.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H73
            valu_grub_56.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H74
            valu_grub_57.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H75
            valu_grub_58.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H76
            valu_grub_59.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H77
            valu_grub_60.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H78
            valu_grub_61.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H79
            valu_grub_62.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H7A
            valu_grub_63.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H7B
            valu_grub_64.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H7C
            valu_grub_65.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H7D
            valu_grub_66.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H7E
            valu_grub_67.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H7F
            valu_grub_68.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H80
            valu_grub_69.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H81
            valu_grub_70.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H82
            valu_grub_71.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H83
            valu_grub_72.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H84
            valu_grub_73.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H85
            valu_grub_74.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H86
            valu_grub_75.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H87
            valu_grub_76.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H88
            valu_grub_77.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H89
            valu_grub_78.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H8A
            valu_grub_79.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H8B
            valu_grub_80.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H8C
            valu_grub_81.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H8D
            valu_grub_82.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H8E
            valu_grub_83.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H8F
            valu_grub_84.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H90
            valu_grub_85.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H91
            valu_grub_86.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H92
            valu_grub_87.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H93
            valu_grub_88.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H94
            valu_grub_89.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H95
            valu_grub_90.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H96
            valu_grub_91.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H97
            valu_grub_92.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H98
            valu_grub_93.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H99
            valu_grub_94.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H9A
            valu_grub_95.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H9B
            valu_grub_96.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H9C
            valu_grub_97.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H9D
            valu_grub_98.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H9E
            valu_grub_99.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &H9F
            valu_grub_100.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA0
            valu_grub_101.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA1
            valu_grub_102.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA2
            valu_grub_103.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA3
            valu_grub_104.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA4
            valu_grub_105.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA5
            valu_grub_106.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA6
            valu_grub_107.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA7
            valu_grub_108.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA8
            valu_grub_109.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HA9
            valu_grub_110.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HAA
            valu_grub_111.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HAB
            valu_grub_112.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HAC
            valu_grub_113.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HAD
            valu_grub_114.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HAE
            valu_grub_115.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HAF
            valu_grub_116.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB0
            valu_grub_117.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB1
            valu_grub_118.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB2
            valu_grub_119.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB3
            valu_grub_120.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB4
            valu_grub_121.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB5
            valu_grub_122.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB6
            valu_grub_123.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB7
            valu_grub_124.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB8
            valu_grub_125.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HB9
            valu_grub_126.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HBA
            valu_grub_127.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HBB
            valu_grub_128.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HBC
            valu_grub_129.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HBD
            valu_grub_130.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HBE
            valu_grub_131.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HBF
            valu_grub_132.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC0
            valu_grub_133.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC1
            valu_grub_134.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC2
            valu_grub_135.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC3
            valu_grub_136.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC4
            valu_grub_137.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC5
            valu_grub_138.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC6
            valu_grub_139.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC7
            valu_grub_140.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC8
            valu_grub_141.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HC9
            valu_grub_142.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HCA
            valu_grub_143.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HCB
            valu_grub_144.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HCC
            valu_grub_145.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HCD
            valu_grub_146.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HCE
            valu_grub_147.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HCF
            valu_grub_148.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD0
            valu_grub_149.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD1
            valu_grub_150.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD2
            valu_grub_151.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD3
            valu_grub_152.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD4
            valu_grub_153.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD5
            valu_grub_154.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD6
            valu_grub_155.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD7
            valu_grub_156.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD8
            valu_grub_157.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HD9
            valu_grub_158.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HDA
            valu_grub_159.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HDB
            valu_grub_160.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HDC
            valu_grub_161.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HDD
            valu_grub_162.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HDE
            valu_grub_163.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HDF
            valu_grub_164.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE0
            valu_grub_165.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE1
            valu_grub_166.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE2
            valu_grub_167.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE3
            valu_grub_168.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE4
            valu_grub_169.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE5
            valu_grub_170.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE6
            valu_grub_171.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE7
            valu_grub_172.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE8
            valu_grub_173.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HE9
            valu_grub_174.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HEA
            valu_grub_175.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HEB
            valu_grub_176.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HEC
            valu_grub_177.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HED
            valu_grub_178.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HEE
            valu_grub_179.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HEF
            valu_grub_180.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF0
            valu_grub_181.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF1
            valu_grub_182.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF2
            valu_grub_183.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF3
            valu_grub_184.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF4
            valu_grub_185.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF5
            valu_grub_186.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF6
            valu_grub_187.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF7
            valu_grub_188.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF8
            valu_grub_189.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HF9
            valu_grub_190.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HFA
            valu_grub_191.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HFB
            valu_grub_192.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HFC
            valu_grub_193.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HFD
            valu_grub_194.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HFE
            valu_grub_195.Value = ReadGrubs.ReadByte
            ReadGrubs.Position = &HFF
            valu_grub_196.Value = ReadGrubs.ReadByte
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read grubs" & vbNewLine & "Check if your save file is not used with an other application or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub
    'end load process

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        WriteAllgrubs()
    End Sub

    Public Sub WriteAllgrubs()
        Try
            Dim WriteBgrubs As New System.IO.FileStream(CStr(mainsav), FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            WriteBgrubs.Position = &H3C
            WriteBgrubs.WriteByte(valu_grub_1.Value)
            WriteBgrubs.Position = &H3D
            WriteBgrubs.WriteByte(valu_grub_2.Value)
            WriteBgrubs.Position = &H3E
            WriteBgrubs.WriteByte(valu_grub_3.Value)
            WriteBgrubs.Position = &H3F
            WriteBgrubs.WriteByte(valu_grub_4.Value)
            WriteBgrubs.Position = &H40
            WriteBgrubs.WriteByte(valu_grub_5.Value)
            WriteBgrubs.Position = &H41
            WriteBgrubs.WriteByte(valu_grub_6.Value)
            WriteBgrubs.Position = &H42
            WriteBgrubs.WriteByte(valu_grub_7.Value)
            WriteBgrubs.Position = &H43
            WriteBgrubs.WriteByte(valu_grub_8.Value)
            WriteBgrubs.Position = &H44
            WriteBgrubs.WriteByte(valu_grub_9.Value)
            WriteBgrubs.Position = &H45
            WriteBgrubs.WriteByte(valu_grub_10.Value)
            WriteBgrubs.Position = &H46
            WriteBgrubs.WriteByte(valu_grub_11.Value)
            WriteBgrubs.Position = &H47
            WriteBgrubs.WriteByte(valu_grub_12.Value)
            WriteBgrubs.Position = &H48
            WriteBgrubs.WriteByte(valu_grub_13.Value)
            WriteBgrubs.Position = &H49
            WriteBgrubs.WriteByte(valu_grub_14.Value)
            WriteBgrubs.Position = &H4A
            WriteBgrubs.WriteByte(valu_grub_15.Value)
            WriteBgrubs.Position = &H4B
            WriteBgrubs.WriteByte(valu_grub_16.Value)
            WriteBgrubs.Position = &H4C
            WriteBgrubs.WriteByte(valu_grub_17.Value)
            WriteBgrubs.Position = &H4D
            WriteBgrubs.WriteByte(valu_grub_18.Value)
            WriteBgrubs.Position = &H4E
            WriteBgrubs.WriteByte(valu_grub_19.Value)
            WriteBgrubs.Position = &H4F
            WriteBgrubs.WriteByte(valu_grub_20.Value)
            WriteBgrubs.Position = &H50
            WriteBgrubs.WriteByte(valu_grub_21.Value)
            WriteBgrubs.Position = &H51
            WriteBgrubs.WriteByte(valu_grub_22.Value)
            WriteBgrubs.Position = &H52
            WriteBgrubs.WriteByte(valu_grub_23.Value)
            WriteBgrubs.Position = &H53
            WriteBgrubs.WriteByte(valu_grub_24.Value)
            WriteBgrubs.Position = &H54
            WriteBgrubs.WriteByte(valu_grub_25.Value)
            WriteBgrubs.Position = &H55
            WriteBgrubs.WriteByte(valu_grub_26.Value)
            WriteBgrubs.Position = &H56
            WriteBgrubs.WriteByte(valu_grub_27.Value)
            WriteBgrubs.Position = &H57
            WriteBgrubs.WriteByte(valu_grub_28.Value)
            WriteBgrubs.Position = &H58
            WriteBgrubs.WriteByte(valu_grub_29.Value)
            WriteBgrubs.Position = &H59
            WriteBgrubs.WriteByte(valu_grub_30.Value)
            WriteBgrubs.Position = &H5A
            WriteBgrubs.WriteByte(valu_grub_31.Value)
            WriteBgrubs.Position = &H5B
            WriteBgrubs.WriteByte(valu_grub_32.Value)
            WriteBgrubs.Position = &H5C
            WriteBgrubs.WriteByte(valu_grub_33.Value)
            WriteBgrubs.Position = &H5D
            WriteBgrubs.WriteByte(valu_grub_34.Value)
            WriteBgrubs.Position = &H5E
            WriteBgrubs.WriteByte(valu_grub_35.Value)
            WriteBgrubs.Position = &H5F
            WriteBgrubs.WriteByte(valu_grub_36.Value)
            WriteBgrubs.Position = &H60
            WriteBgrubs.WriteByte(valu_grub_37.Value)
            WriteBgrubs.Position = &H61
            WriteBgrubs.WriteByte(valu_grub_38.Value)
            WriteBgrubs.Position = &H62
            WriteBgrubs.WriteByte(valu_grub_39.Value)
            WriteBgrubs.Position = &H63
            WriteBgrubs.WriteByte(valu_grub_40.Value)
            WriteBgrubs.Position = &H64
            WriteBgrubs.WriteByte(valu_grub_41.Value)
            WriteBgrubs.Position = &H65
            WriteBgrubs.WriteByte(valu_grub_42.Value)
            WriteBgrubs.Position = &H66
            WriteBgrubs.WriteByte(valu_grub_43.Value)
            WriteBgrubs.Position = &H67
            WriteBgrubs.WriteByte(valu_grub_44.Value)
            WriteBgrubs.Position = &H68
            WriteBgrubs.WriteByte(valu_grub_45.Value)
            WriteBgrubs.Position = &H69
            WriteBgrubs.WriteByte(valu_grub_46.Value)
            WriteBgrubs.Position = &H6A
            WriteBgrubs.WriteByte(valu_grub_47.Value)
            WriteBgrubs.Position = &H6B
            WriteBgrubs.WriteByte(valu_grub_48.Value)
            WriteBgrubs.Position = &H6C
            WriteBgrubs.WriteByte(valu_grub_49.Value)
            WriteBgrubs.Position = &H6D
            WriteBgrubs.WriteByte(valu_grub_50.Value)
            WriteBgrubs.Position = &H6E
            WriteBgrubs.WriteByte(valu_grub_51.Value)
            WriteBgrubs.Position = &H6F
            WriteBgrubs.WriteByte(valu_grub_52.Value)
            WriteBgrubs.Position = &H70
            WriteBgrubs.WriteByte(valu_grub_53.Value)
            WriteBgrubs.Position = &H71
            WriteBgrubs.WriteByte(valu_grub_54.Value)
            WriteBgrubs.Position = &H72
            WriteBgrubs.WriteByte(valu_grub_55.Value)
            WriteBgrubs.Position = &H73
            WriteBgrubs.WriteByte(valu_grub_56.Value)
            WriteBgrubs.Position = &H74
            WriteBgrubs.WriteByte(valu_grub_57.Value)
            WriteBgrubs.Position = &H75
            WriteBgrubs.WriteByte(valu_grub_58.Value)
            WriteBgrubs.Position = &H76
            WriteBgrubs.WriteByte(valu_grub_59.Value)
            WriteBgrubs.Position = &H77
            WriteBgrubs.WriteByte(valu_grub_60.Value)
            WriteBgrubs.Position = &H78
            WriteBgrubs.WriteByte(valu_grub_61.Value)
            WriteBgrubs.Position = &H79
            WriteBgrubs.WriteByte(valu_grub_62.Value)
            WriteBgrubs.Position = &H7A
            WriteBgrubs.WriteByte(valu_grub_63.Value)
            WriteBgrubs.Position = &H7B
            WriteBgrubs.WriteByte(valu_grub_64.Value)
            WriteBgrubs.Position = &H7C
            WriteBgrubs.WriteByte(valu_grub_65.Value)
            WriteBgrubs.Position = &H7D
            WriteBgrubs.WriteByte(valu_grub_66.Value)
            WriteBgrubs.Position = &H7E
            WriteBgrubs.WriteByte(valu_grub_67.Value)
            WriteBgrubs.Position = &H7F
            WriteBgrubs.WriteByte(valu_grub_68.Value)
            WriteBgrubs.Position = &H80
            WriteBgrubs.WriteByte(valu_grub_69.Value)
            WriteBgrubs.Position = &H81
            WriteBgrubs.WriteByte(valu_grub_70.Value)
            WriteBgrubs.Position = &H82
            WriteBgrubs.WriteByte(valu_grub_71.Value)
            WriteBgrubs.Position = &H83
            WriteBgrubs.WriteByte(valu_grub_72.Value)
            WriteBgrubs.Position = &H84
            WriteBgrubs.WriteByte(valu_grub_73.Value)
            WriteBgrubs.Position = &H85
            WriteBgrubs.WriteByte(valu_grub_74.Value)
            WriteBgrubs.Position = &H86
            WriteBgrubs.WriteByte(valu_grub_75.Value)
            WriteBgrubs.Position = &H87
            WriteBgrubs.WriteByte(valu_grub_76.Value)
            WriteBgrubs.Position = &H88
            WriteBgrubs.WriteByte(valu_grub_77.Value)
            WriteBgrubs.Position = &H89
            WriteBgrubs.WriteByte(valu_grub_78.Value)
            WriteBgrubs.Position = &H8A
            WriteBgrubs.WriteByte(valu_grub_79.Value)
            WriteBgrubs.Position = &H8B
            WriteBgrubs.WriteByte(valu_grub_80.Value)
            WriteBgrubs.Position = &H8C
            WriteBgrubs.WriteByte(valu_grub_81.Value)
            WriteBgrubs.Position = &H8D
            WriteBgrubs.WriteByte(valu_grub_82.Value)
            WriteBgrubs.Position = &H8E
            WriteBgrubs.WriteByte(valu_grub_83.Value)
            WriteBgrubs.Position = &H8F
            WriteBgrubs.WriteByte(valu_grub_84.Value)
            WriteBgrubs.Position = &H90
            WriteBgrubs.WriteByte(valu_grub_85.Value)
            WriteBgrubs.Position = &H91
            WriteBgrubs.WriteByte(valu_grub_86.Value)
            WriteBgrubs.Position = &H92
            WriteBgrubs.WriteByte(valu_grub_87.Value)
            WriteBgrubs.Position = &H93
            WriteBgrubs.WriteByte(valu_grub_88.Value)
            WriteBgrubs.Position = &H94
            WriteBgrubs.WriteByte(valu_grub_89.Value)
            WriteBgrubs.Position = &H95
            WriteBgrubs.WriteByte(valu_grub_90.Value)
            WriteBgrubs.Position = &H96
            WriteBgrubs.WriteByte(valu_grub_91.Value)
            WriteBgrubs.Position = &H97
            WriteBgrubs.WriteByte(valu_grub_92.Value)
            WriteBgrubs.Position = &H98
            WriteBgrubs.WriteByte(valu_grub_93.Value)
            WriteBgrubs.Position = &H99
            WriteBgrubs.WriteByte(valu_grub_94.Value)
            WriteBgrubs.Position = &H9A
            WriteBgrubs.WriteByte(valu_grub_95.Value)
            WriteBgrubs.Position = &H9B
            WriteBgrubs.WriteByte(valu_grub_96.Value)
            WriteBgrubs.Position = &H9C
            WriteBgrubs.WriteByte(valu_grub_97.Value)
            WriteBgrubs.Position = &H9D
            WriteBgrubs.WriteByte(valu_grub_98.Value)
            WriteBgrubs.Position = &H9E
            WriteBgrubs.WriteByte(valu_grub_99.Value)
            WriteBgrubs.Position = &H9F
            WriteBgrubs.WriteByte(valu_grub_100.Value)
            WriteBgrubs.Position = &HA0
            WriteBgrubs.WriteByte(valu_grub_101.Value)
            WriteBgrubs.Position = &HA1
            WriteBgrubs.WriteByte(valu_grub_102.Value)
            WriteBgrubs.Position = &HA2
            WriteBgrubs.WriteByte(valu_grub_103.Value)
            WriteBgrubs.Position = &HA3
            WriteBgrubs.WriteByte(valu_grub_104.Value)
            WriteBgrubs.Position = &HA4
            WriteBgrubs.WriteByte(valu_grub_105.Value)
            WriteBgrubs.Position = &HA5
            WriteBgrubs.WriteByte(valu_grub_106.Value)
            WriteBgrubs.Position = &HA6
            WriteBgrubs.WriteByte(valu_grub_107.Value)
            WriteBgrubs.Position = &HA7
            WriteBgrubs.WriteByte(valu_grub_108.Value)
            WriteBgrubs.Position = &HA8
            WriteBgrubs.WriteByte(valu_grub_109.Value)
            WriteBgrubs.Position = &HA9
            WriteBgrubs.WriteByte(valu_grub_110.Value)
            WriteBgrubs.Position = &HAA
            WriteBgrubs.WriteByte(valu_grub_111.Value)
            WriteBgrubs.Position = &HAB
            WriteBgrubs.WriteByte(valu_grub_112.Value)
            WriteBgrubs.Position = &HAC
            WriteBgrubs.WriteByte(valu_grub_113.Value)
            WriteBgrubs.Position = &HAD
            WriteBgrubs.WriteByte(valu_grub_114.Value)
            WriteBgrubs.Position = &HAE
            WriteBgrubs.WriteByte(valu_grub_115.Value)
            WriteBgrubs.Position = &HAF
            WriteBgrubs.WriteByte(valu_grub_116.Value)
            WriteBgrubs.Position = &HB0
            WriteBgrubs.WriteByte(valu_grub_117.Value)
            WriteBgrubs.Position = &HB1
            WriteBgrubs.WriteByte(valu_grub_118.Value)
            WriteBgrubs.Position = &HB2
            WriteBgrubs.WriteByte(valu_grub_119.Value)
            WriteBgrubs.Position = &HB3
            WriteBgrubs.WriteByte(valu_grub_120.Value)
            WriteBgrubs.Position = &HB4
            WriteBgrubs.WriteByte(valu_grub_121.Value)
            WriteBgrubs.Position = &HB5
            WriteBgrubs.WriteByte(valu_grub_122.Value)
            WriteBgrubs.Position = &HB6
            WriteBgrubs.WriteByte(valu_grub_123.Value)
            WriteBgrubs.Position = &HB7
            WriteBgrubs.WriteByte(valu_grub_124.Value)
            WriteBgrubs.Position = &HB8
            WriteBgrubs.WriteByte(valu_grub_125.Value)
            WriteBgrubs.Position = &HB9
            WriteBgrubs.WriteByte(valu_grub_126.Value)
            WriteBgrubs.Position = &HBA
            WriteBgrubs.WriteByte(valu_grub_127.Value)
            WriteBgrubs.Position = &HBB
            WriteBgrubs.WriteByte(valu_grub_128.Value)
            WriteBgrubs.Position = &HBC
            WriteBgrubs.WriteByte(valu_grub_129.Value)
            WriteBgrubs.Position = &HBD
            WriteBgrubs.WriteByte(valu_grub_130.Value)
            WriteBgrubs.Position = &HBE
            WriteBgrubs.WriteByte(valu_grub_131.Value)
            WriteBgrubs.Position = &HBF
            WriteBgrubs.WriteByte(valu_grub_132.Value)
            WriteBgrubs.Position = &HC0
            WriteBgrubs.WriteByte(valu_grub_133.Value)
            WriteBgrubs.Position = &HC1
            WriteBgrubs.WriteByte(valu_grub_134.Value)
            WriteBgrubs.Position = &HC2
            WriteBgrubs.WriteByte(valu_grub_135.Value)
            WriteBgrubs.Position = &HC3
            WriteBgrubs.WriteByte(valu_grub_136.Value)
            WriteBgrubs.Position = &HC4
            WriteBgrubs.WriteByte(valu_grub_137.Value)
            WriteBgrubs.Position = &HC5
            WriteBgrubs.WriteByte(valu_grub_138.Value)
            WriteBgrubs.Position = &HC6
            WriteBgrubs.WriteByte(valu_grub_139.Value)
            WriteBgrubs.Position = &HC7
            WriteBgrubs.WriteByte(valu_grub_140.Value)
            WriteBgrubs.Position = &HC8
            WriteBgrubs.WriteByte(valu_grub_141.Value)
            WriteBgrubs.Position = &HC9
            WriteBgrubs.WriteByte(valu_grub_142.Value)
            WriteBgrubs.Position = &HCA
            WriteBgrubs.WriteByte(valu_grub_143.Value)
            WriteBgrubs.Position = &HCB
            WriteBgrubs.WriteByte(valu_grub_144.Value)
            WriteBgrubs.Position = &HCC
            WriteBgrubs.WriteByte(valu_grub_145.Value)
            WriteBgrubs.Position = &HCD
            WriteBgrubs.WriteByte(valu_grub_146.Value)
            WriteBgrubs.Position = &HCE
            WriteBgrubs.WriteByte(valu_grub_147.Value)
            WriteBgrubs.Position = &HCF
            WriteBgrubs.WriteByte(valu_grub_148.Value)
            WriteBgrubs.Position = &HD0
            WriteBgrubs.WriteByte(valu_grub_149.Value)
            WriteBgrubs.Position = &HD1
            WriteBgrubs.WriteByte(valu_grub_150.Value)
            WriteBgrubs.Position = &HD2
            WriteBgrubs.WriteByte(valu_grub_151.Value)
            WriteBgrubs.Position = &HD3
            WriteBgrubs.WriteByte(valu_grub_152.Value)
            WriteBgrubs.Position = &HD4
            WriteBgrubs.WriteByte(valu_grub_153.Value)
            WriteBgrubs.Position = &HD5
            WriteBgrubs.WriteByte(valu_grub_154.Value)
            WriteBgrubs.Position = &HD6
            WriteBgrubs.WriteByte(valu_grub_155.Value)
            WriteBgrubs.Position = &HD7
            WriteBgrubs.WriteByte(valu_grub_156.Value)
            WriteBgrubs.Position = &HD8
            WriteBgrubs.WriteByte(valu_grub_157.Value)
            WriteBgrubs.Position = &HD9
            WriteBgrubs.WriteByte(valu_grub_158.Value)
            WriteBgrubs.Position = &HDA
            WriteBgrubs.WriteByte(valu_grub_159.Value)
            WriteBgrubs.Position = &HDB
            WriteBgrubs.WriteByte(valu_grub_160.Value)
            WriteBgrubs.Position = &HDC
            WriteBgrubs.WriteByte(valu_grub_161.Value)
            WriteBgrubs.Position = &HDD
            WriteBgrubs.WriteByte(valu_grub_162.Value)
            WriteBgrubs.Position = &HDE
            WriteBgrubs.WriteByte(valu_grub_163.Value)
            WriteBgrubs.Position = &HDF
            WriteBgrubs.WriteByte(valu_grub_164.Value)
            WriteBgrubs.Position = &HE0
            WriteBgrubs.WriteByte(valu_grub_165.Value)
            WriteBgrubs.Position = &HE1
            WriteBgrubs.WriteByte(valu_grub_166.Value)
            WriteBgrubs.Position = &HE2
            WriteBgrubs.WriteByte(valu_grub_167.Value)
            WriteBgrubs.Position = &HE3
            WriteBgrubs.WriteByte(valu_grub_168.Value)
            WriteBgrubs.Position = &HE4
            WriteBgrubs.WriteByte(valu_grub_169.Value)
            WriteBgrubs.Position = &HE5
            WriteBgrubs.WriteByte(valu_grub_170.Value)
            WriteBgrubs.Position = &HE6
            WriteBgrubs.WriteByte(valu_grub_171.Value)
            WriteBgrubs.Position = &HE7
            WriteBgrubs.WriteByte(valu_grub_172.Value)
            WriteBgrubs.Position = &HE8
            WriteBgrubs.WriteByte(valu_grub_173.Value)
            WriteBgrubs.Position = &HE9
            WriteBgrubs.WriteByte(valu_grub_174.Value)
            WriteBgrubs.Position = &HEA
            WriteBgrubs.WriteByte(valu_grub_175.Value)
            WriteBgrubs.Position = &HEB
            WriteBgrubs.WriteByte(valu_grub_176.Value)
            WriteBgrubs.Position = &HEC
            WriteBgrubs.WriteByte(valu_grub_177.Value)
            WriteBgrubs.Position = &HED
            WriteBgrubs.WriteByte(valu_grub_178.Value)
            WriteBgrubs.Position = &HEE
            WriteBgrubs.WriteByte(valu_grub_179.Value)
            WriteBgrubs.Position = &HEF
            WriteBgrubs.WriteByte(valu_grub_180.Value)
            WriteBgrubs.Position = &HF0
            WriteBgrubs.WriteByte(valu_grub_181.Value)
            WriteBgrubs.Position = &HF1
            WriteBgrubs.WriteByte(valu_grub_182.Value)
            WriteBgrubs.Position = &HF2
            WriteBgrubs.WriteByte(valu_grub_183.Value)
            WriteBgrubs.Position = &HF3
            WriteBgrubs.WriteByte(valu_grub_184.Value)
            WriteBgrubs.Position = &HF4
            WriteBgrubs.WriteByte(valu_grub_185.Value)
            WriteBgrubs.Position = &HF5
            WriteBgrubs.WriteByte(valu_grub_186.Value)
            WriteBgrubs.Position = &HF6
            WriteBgrubs.WriteByte(valu_grub_187.Value)
            WriteBgrubs.Position = &HF7
            WriteBgrubs.WriteByte(valu_grub_188.Value)
            WriteBgrubs.Position = &HF8
            WriteBgrubs.WriteByte(valu_grub_189.Value)
            WriteBgrubs.Position = &HF9
            WriteBgrubs.WriteByte(valu_grub_190.Value)
            WriteBgrubs.Position = &HFA
            WriteBgrubs.WriteByte(valu_grub_191.Value)
            WriteBgrubs.Position = &HFB
            WriteBgrubs.WriteByte(valu_grub_192.Value)
            WriteBgrubs.Position = &HFC
            WriteBgrubs.WriteByte(valu_grub_193.Value)
            WriteBgrubs.Position = &HFD
            WriteBgrubs.WriteByte(valu_grub_194.Value)
            WriteBgrubs.Position = &HFE
            WriteBgrubs.WriteByte(valu_grub_195.Value)
            WriteBgrubs.Position = &HFF
            WriteBgrubs.WriteByte(valu_grub_196.Value)
            MSE_dialog.text_dialog.Text = "Grubs has been succefully edited"
            MSE_dialog.ShowDialog()
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to write grubs" & vbNewLine & "Check if your save file is not used with an other application or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub hidepanelsfoods()
        Panel_foods_1.Visible = False
        Panel_foods_2.Visible = False
        Panel_foods_3.Visible = False
        Panel_foods_4.Visible = False
    End Sub

    Public Sub Hidearrows()
        Arrow_left_panel1.Visible = False
        Arrow_left_panel2.Visible = False
        Arrow_left_panel3.Visible = False
        Arrow_right_panel2.Visible = False
        Arrow_right_panel3.Visible = False
        Arrow_right_panel4.Visible = False
    End Sub

    Private Sub Arrow_right_panel2_Click(sender As Object, e As EventArgs) Handles Arrow_right_panel2.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_2.Visible = True
        Arrow_left_panel1.Visible = True
        Arrow_right_panel3.Visible = True
    End Sub

    Private Sub Arrow_left_panel1_Click(sender As Object, e As EventArgs) Handles Arrow_left_panel1.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_1.Visible = True
        Arrow_right_panel2.Visible = True
    End Sub

    Private Sub Arrow_right_panel3_Click(sender As Object, e As EventArgs) Handles Arrow_right_panel3.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_3.Visible = True
        Arrow_left_panel2.Visible = True
        Arrow_right_panel4.Visible = True
    End Sub

    Private Sub Arrow_left_panel2_Click(sender As Object, e As EventArgs) Handles Arrow_left_panel2.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_2.Visible = True
        Arrow_left_panel1.Visible = True
        Arrow_right_panel3.Visible = True
    End Sub

    Private Sub Arrow_right_panel4_Click(sender As Object, e As EventArgs) Handles Arrow_right_panel4.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_4.Visible = True
        Arrow_left_panel3.Visible = True
    End Sub

    Private Sub Arrow_left_panel3_Click(sender As Object, e As EventArgs) Handles Arrow_left_panel3.Click
        hidepanelsfoods()
        Hidearrows()
        Panel_foods_3.Visible = True
        Arrow_left_panel2.Visible = True
        Arrow_right_panel4.Visible = True
    End Sub

    Private Sub Text_setall_Click(sender As Object, e As EventArgs) Handles Text_setall.Click, Fea_setall.Click
        valu_grub_1.Value = valu_setall.Value
        valu_grub_2.Value = valu_setall.Value
        valu_grub_3.Value = valu_setall.Value
        valu_grub_4.Value = valu_setall.Value
        valu_grub_5.Value = valu_setall.Value
        valu_grub_6.Value = valu_setall.Value
        valu_grub_7.Value = valu_setall.Value
        valu_grub_8.Value = valu_setall.Value
        valu_grub_9.Value = valu_setall.Value
        valu_grub_10.Value = valu_setall.Value
        valu_grub_11.Value = valu_setall.Value
        valu_grub_12.Value = valu_setall.Value
        valu_grub_13.Value = valu_setall.Value
        valu_grub_14.Value = valu_setall.Value
        valu_grub_15.Value = valu_setall.Value
        valu_grub_16.Value = valu_setall.Value
        valu_grub_17.Value = valu_setall.Value
        valu_grub_18.Value = valu_setall.Value
        valu_grub_19.Value = valu_setall.Value
        valu_grub_20.Value = valu_setall.Value
        valu_grub_21.Value = valu_setall.Value
        valu_grub_22.Value = valu_setall.Value
        valu_grub_23.Value = valu_setall.Value
        valu_grub_24.Value = valu_setall.Value
        valu_grub_25.Value = valu_setall.Value
        valu_grub_26.Value = valu_setall.Value
        valu_grub_27.Value = valu_setall.Value
        valu_grub_28.Value = valu_setall.Value
        valu_grub_29.Value = valu_setall.Value
        valu_grub_30.Value = valu_setall.Value
        valu_grub_31.Value = valu_setall.Value
        valu_grub_32.Value = valu_setall.Value
        valu_grub_33.Value = valu_setall.Value
        valu_grub_34.Value = valu_setall.Value
        valu_grub_35.Value = valu_setall.Value
        valu_grub_36.Value = valu_setall.Value
        valu_grub_37.Value = valu_setall.Value
        valu_grub_38.Value = valu_setall.Value
        valu_grub_39.Value = valu_setall.Value
        valu_grub_40.Value = valu_setall.Value
        valu_grub_41.Value = valu_setall.Value
        valu_grub_42.Value = valu_setall.Value
        valu_grub_43.Value = valu_setall.Value
        valu_grub_44.Value = valu_setall.Value
        valu_grub_45.Value = valu_setall.Value
        valu_grub_46.Value = valu_setall.Value
        valu_grub_47.Value = valu_setall.Value
        valu_grub_48.Value = valu_setall.Value
        valu_grub_49.Value = valu_setall.Value
        valu_grub_50.Value = valu_setall.Value
        valu_grub_51.Value = valu_setall.Value
        valu_grub_52.Value = valu_setall.Value
        valu_grub_53.Value = valu_setall.Value
        valu_grub_54.Value = valu_setall.Value
        valu_grub_55.Value = valu_setall.Value
        valu_grub_56.Value = valu_setall.Value
        valu_grub_57.Value = valu_setall.Value
        valu_grub_58.Value = valu_setall.Value
        valu_grub_59.Value = valu_setall.Value
        valu_grub_60.Value = valu_setall.Value
        valu_grub_61.Value = valu_setall.Value
        valu_grub_62.Value = valu_setall.Value
        valu_grub_63.Value = valu_setall.Value
        valu_grub_64.Value = valu_setall.Value
        valu_grub_65.Value = valu_setall.Value
        valu_grub_66.Value = valu_setall.Value
        valu_grub_67.Value = valu_setall.Value
        valu_grub_68.Value = valu_setall.Value
        valu_grub_69.Value = valu_setall.Value
        valu_grub_70.Value = valu_setall.Value
        valu_grub_71.Value = valu_setall.Value
        valu_grub_72.Value = valu_setall.Value
        valu_grub_73.Value = valu_setall.Value
        valu_grub_74.Value = valu_setall.Value
        valu_grub_75.Value = valu_setall.Value
        valu_grub_76.Value = valu_setall.Value
        valu_grub_77.Value = valu_setall.Value
        valu_grub_78.Value = valu_setall.Value
        valu_grub_79.Value = valu_setall.Value
        valu_grub_80.Value = valu_setall.Value
        valu_grub_81.Value = valu_setall.Value
        valu_grub_82.Value = valu_setall.Value
        valu_grub_83.Value = valu_setall.Value
        valu_grub_84.Value = valu_setall.Value
        valu_grub_85.Value = valu_setall.Value
        valu_grub_86.Value = valu_setall.Value
        valu_grub_87.Value = valu_setall.Value
        valu_grub_88.Value = valu_setall.Value
        valu_grub_89.Value = valu_setall.Value
        valu_grub_90.Value = valu_setall.Value
        valu_grub_91.Value = valu_setall.Value
        valu_grub_92.Value = valu_setall.Value
        valu_grub_93.Value = valu_setall.Value
        valu_grub_94.Value = valu_setall.Value
        valu_grub_95.Value = valu_setall.Value
        valu_grub_96.Value = valu_setall.Value
        valu_grub_97.Value = valu_setall.Value
        valu_grub_98.Value = valu_setall.Value
        valu_grub_99.Value = valu_setall.Value
        valu_grub_100.Value = valu_setall.Value
        valu_grub_101.Value = valu_setall.Value
        valu_grub_102.Value = valu_setall.Value
        valu_grub_103.Value = valu_setall.Value
        valu_grub_104.Value = valu_setall.Value
        valu_grub_105.Value = valu_setall.Value
        valu_grub_106.Value = valu_setall.Value
        valu_grub_107.Value = valu_setall.Value
        valu_grub_108.Value = valu_setall.Value
        valu_grub_109.Value = valu_setall.Value
        valu_grub_110.Value = valu_setall.Value
        valu_grub_111.Value = valu_setall.Value
        valu_grub_112.Value = valu_setall.Value
        valu_grub_113.Value = valu_setall.Value
        valu_grub_114.Value = valu_setall.Value
        valu_grub_115.Value = valu_setall.Value
        valu_grub_116.Value = valu_setall.Value
        valu_grub_117.Value = valu_setall.Value
        valu_grub_118.Value = valu_setall.Value
        valu_grub_119.Value = valu_setall.Value
        valu_grub_120.Value = valu_setall.Value
        valu_grub_121.Value = valu_setall.Value
        valu_grub_122.Value = valu_setall.Value
        valu_grub_123.Value = valu_setall.Value
        valu_grub_124.Value = valu_setall.Value
        valu_grub_125.Value = valu_setall.Value
        valu_grub_126.Value = valu_setall.Value
        valu_grub_127.Value = valu_setall.Value
        valu_grub_128.Value = valu_setall.Value
        valu_grub_129.Value = valu_setall.Value
        valu_grub_130.Value = valu_setall.Value
        valu_grub_131.Value = valu_setall.Value
        valu_grub_132.Value = valu_setall.Value
        valu_grub_133.Value = valu_setall.Value
        valu_grub_134.Value = valu_setall.Value
        valu_grub_135.Value = valu_setall.Value
        valu_grub_136.Value = valu_setall.Value
        valu_grub_137.Value = valu_setall.Value
        valu_grub_138.Value = valu_setall.Value
        valu_grub_139.Value = valu_setall.Value
        valu_grub_140.Value = valu_setall.Value
        valu_grub_141.Value = valu_setall.Value
        valu_grub_142.Value = valu_setall.Value
        valu_grub_143.Value = valu_setall.Value
        valu_grub_144.Value = valu_setall.Value
        valu_grub_145.Value = valu_setall.Value
        valu_grub_146.Value = valu_setall.Value
        valu_grub_147.Value = valu_setall.Value
        valu_grub_148.Value = valu_setall.Value
        valu_grub_149.Value = valu_setall.Value
        valu_grub_150.Value = valu_setall.Value
        valu_grub_151.Value = valu_setall.Value
        valu_grub_152.Value = valu_setall.Value
        valu_grub_153.Value = valu_setall.Value
        valu_grub_154.Value = valu_setall.Value
        valu_grub_155.Value = valu_setall.Value
        valu_grub_156.Value = valu_setall.Value
        valu_grub_157.Value = valu_setall.Value
        valu_grub_158.Value = valu_setall.Value
        valu_grub_159.Value = valu_setall.Value
        valu_grub_160.Value = valu_setall.Value
        valu_grub_161.Value = valu_setall.Value
        valu_grub_162.Value = valu_setall.Value
        valu_grub_163.Value = valu_setall.Value
        valu_grub_164.Value = valu_setall.Value
        valu_grub_165.Value = valu_setall.Value
        valu_grub_166.Value = valu_setall.Value
        valu_grub_167.Value = valu_setall.Value
        valu_grub_168.Value = valu_setall.Value
        valu_grub_169.Value = valu_setall.Value
        valu_grub_170.Value = valu_setall.Value
        valu_grub_171.Value = valu_setall.Value
        valu_grub_172.Value = valu_setall.Value
        valu_grub_173.Value = valu_setall.Value
        valu_grub_174.Value = valu_setall.Value
        valu_grub_175.Value = valu_setall.Value
        valu_grub_176.Value = valu_setall.Value
        valu_grub_177.Value = valu_setall.Value
        valu_grub_178.Value = valu_setall.Value
        valu_grub_179.Value = valu_setall.Value
        valu_grub_180.Value = valu_setall.Value
        valu_grub_181.Value = valu_setall.Value
        valu_grub_182.Value = valu_setall.Value
        valu_grub_183.Value = valu_setall.Value
        valu_grub_184.Value = valu_setall.Value
        valu_grub_185.Value = valu_setall.Value
        valu_grub_186.Value = valu_setall.Value
        valu_grub_187.Value = valu_setall.Value
        valu_grub_188.Value = valu_setall.Value
        valu_grub_189.Value = valu_setall.Value
        valu_grub_190.Value = valu_setall.Value
        valu_grub_191.Value = valu_setall.Value
        valu_grub_192.Value = valu_setall.Value
        valu_grub_193.Value = valu_setall.Value
        valu_grub_194.Value = valu_setall.Value
        valu_grub_195.Value = valu_setall.Value
        valu_grub_196.Value = valu_setall.Value
    End Sub
End Class