Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_miiprofile
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim Miiname_1 = &HFCFE4
    Dim Warcry_1 = &HFD008
    Dim Personality_1 = &HFD043
    Dim Job_1 = &HFD044
    Dim Pose_1 = &HFD045
    Dim Miiname_2 = &HFD324
    Dim Warcry_2 = &HFD348
    Dim Personality_2 = &HFD383
    Dim Job_2 = &HFD384
    Dim Pose_2 = &HFD385
    Dim Miiname_3 = &HFD664
    Dim Warcry_3 = &HFD688
    Dim Personality_3 = &HFD6C3
    Dim Job_3 = &HFD6C4
    Dim Pose_3 = &HFD6C5
    Dim Miiname_4 = &HFD9A4
    Dim Warcry_4 = &HFD9C8
    Dim Personality_4 = &HFDA03
    Dim Job_4 = &HFDA04
    Dim Pose_4 = &HFDA05
    Dim Miiname_5 = &HFDCE4
    Dim Warcry_5 = &HFDD08
    Dim Personality_5 = &HFDD43
    Dim Job_5 = &HFDD44
    Dim Pose_5 = &HFDD45
    Dim Miiname_6 = &HFE024
    Dim Warcry_6 = &HFE048
    Dim Personality_6 = &HFE083
    Dim Job_6 = &HFE084
    Dim Pose_6 = &HFE085
    Dim Miiname_7 = &HFE364
    Dim Warcry_7 = &HFE388
    Dim Personality_7 = &HFE3C3
    Dim Job_7 = &HFE3C4
    Dim Pose_7 = &HFE3C5
    Dim Miiname_8 = &HFE6A4
    Dim Warcry_8 = &HFE6C8
    Dim Personality_8 = &HFE703
    Dim Job_8 = &HFE704
    Dim Pose_8 = &HFE705
    Dim Miiname_9 = &HFE9E4
    Dim Warcry_9 = &HFEA08
    Dim Personality_9 = &HFEA43
    Dim Job_9 = &HFEA44
    Dim Pose_9 = &HFEA45
    Dim Miiname_10 = &HFED24
    Dim Warcry_10 = &HFED48
    Dim Personality_10 = &HFED83
    Dim Job_10 = &HFED84
    Dim Pose_10 = &HFED85
    Dim Miiname_11 = &H12522C
    Dim Warcry_11 = &H125250
    Dim Personality_11 = &H12528B
    Dim Job_11 = &H12528C
    Dim Pose_11 = &H12528D
    Dim Miiname_12 = &H12556C
    Dim Warcry_12 = &H125590
    Dim Personality_12 = &H1255CB
    Dim Job_12 = &H1255CC
    Dim Pose_12 = &H1255CD
    Dim Miiname_13 = &H1258AC
    Dim Warcry_13 = &H1258D0
    Dim Personality_13 = &H12590B
    Dim Job_13 = &H12590C
    Dim Pose_13 = &H12590D
    Dim Miiname_14 = &H125BEC
    Dim Warcry_14 = &H125C10
    Dim Personality_14 = &H125C4B
    Dim Job_14 = &H125C4C
    Dim Pose_14 = &H125C4D
    Dim Miiname_15 = &H125F2C
    Dim Warcry_15 = &H125F50
    Dim Personality_15 = &H125F8B
    Dim Job_15 = &H125F8C
    Dim Pose_15 = &H125F8D
    Dim Miiname_16 = &H12626C
    Dim Warcry_16 = &H126290
    Dim Personality_16 = &H1262CB
    Dim Job_16 = &H1262CC
    Dim Pose_16 = &H1262CD
    Dim Miiname_17 = &H1265AC
    Dim Warcry_17 = &H1265D0
    Dim Personality_17 = &H12660B
    Dim Job_17 = &H12660C
    Dim Pose_17 = &H12660D
    Dim Miiname_18 = &H1268EC
    Dim Warcry_18 = &H126910
    Dim Personality_18 = &H12694B
    Dim Job_18 = &H12694C
    Dim Pose_18 = &H12694D
    Dim Miiname_19 = &H126C2C
    Dim Warcry_19 = &H126C50
    Dim Personality_19 = &H126C8B
    Dim Job_19 = &H126C8C
    Dim Pose_19 = &H126C8D
    Dim Miiname_20 = &H126F6C
    Dim Warcry_20 = &H126F90
    Dim Personality_20 = &H126FCB
    Dim Job_20 = &H126FCC
    Dim Pose_20 = &H126FCD
    Dim Miiname_21 = &H1272AC
    Dim Warcry_21 = &H1272D0
    Dim Personality_21 = &H12730B
    Dim Job_21 = &H12730C
    Dim Pose_21 = &H12730D
    Dim Miiname_22 = &H1275EC
    Dim Warcry_22 = &H127610
    Dim Personality_22 = &H12764B
    Dim Job_22 = &H12764C
    Dim Pose_22 = &H12764D
    Dim Miiname_23 = &H12792C
    Dim Warcry_23 = &H127950
    Dim Personality_23 = &H12798B
    Dim Job_23 = &H12798C
    Dim Pose_23 = &H12798D
    Dim Miiname_24 = &H127C6C
    Dim Warcry_24 = &H127C90
    Dim Personality_24 = &H127CCB
    Dim Job_24 = &H127CCC
    Dim Pose_24 = &H127CCD
    Dim Miiname_25 = &H127FAC
    Dim Warcry_25 = &H127FD0
    Dim Personality_25 = &H12800B
    Dim Job_25 = &H12800C
    Dim Pose_25 = &H12800D
    Dim Miiname_26 = &H1282EC
    Dim Warcry_26 = &H128310
    Dim Personality_26 = &H12834B
    Dim Job_26 = &H12834C
    Dim Pose_26 = &H12834D
    Dim Miiname_27 = &H12862C
    Dim Warcry_27 = &H128650
    Dim Personality_27 = &H12868B
    Dim Job_27 = &H12868C
    Dim Pose_27 = &H12868D
    Dim Miiname_28 = &H12896C
    Dim Warcry_28 = &H128990
    Dim Personality_28 = &H1289CB
    Dim Job_28 = &H1289CC
    Dim Pose_28 = &H1289CD
    Dim Miiname_29 = &H128CAC
    Dim Warcry_29 = &H128CD0
    Dim Personality_29 = &H128D0B
    Dim Job_29 = &H128D0C
    Dim Pose_29 = &H128D0D
    Dim Miiname_30 = &H128FEC
    Dim Warcry_30 = &H129010
    Dim Personality_30 = &H12904B
    Dim Job_30 = &H12904C
    Dim Pose_30 = &H12904D
    Dim Miiname_31 = &H12932C
    Dim Warcry_31 = &H129350
    Dim Personality_31 = &H12938B
    Dim Job_31 = &H12938C
    Dim Pose_31 = &H12938D
    Dim Miiname_32 = &H12966C
    Dim Warcry_32 = &H129690
    Dim Personality_32 = &H1296CB
    Dim Job_32 = &H1296CC
    Dim Pose_32 = &H1296CD
    Dim Miiname_33 = &H1299AC
    Dim Warcry_33 = &H1299D0
    Dim Personality_33 = &H129A0B
    Dim Job_33 = &H129A0C
    Dim Pose_33 = &H129A0D
    Dim Miiname_34 = &H129CEC
    Dim Warcry_34 = &H129D10
    Dim Personality_34 = &H129D4B
    Dim Job_34 = &H129D4C
    Dim Pose_34 = &H129D4D
    Dim Miiname_35 = &H12A02C
    Dim Warcry_35 = &H12A050
    Dim Personality_35 = &H12A08B
    Dim Job_35 = &H12A08C
    Dim Pose_35 = &H12A08D
    Dim Miiname_36 = &H12A36C
    Dim Warcry_36 = &H12A390
    Dim Personality_36 = &H12A3CB
    Dim Job_36 = &H12A3CC
    Dim Pose_36 = &H12A3CD
    Dim Miiname_37 = &H12A6AC
    Dim Warcry_37 = &H12A6D0
    Dim Personality_37 = &H12A70B
    Dim Job_37 = &H12A70C
    Dim Pose_37 = &H12A70D
    Dim Miiname_38 = &H12A9EC
    Dim Warcry_38 = &H12AA10
    Dim Personality_38 = &H12AA4B
    Dim Job_38 = &H12AA4C
    Dim Pose_38 = &H12AA4D
    Dim Miiname_39 = &H12AD2C
    Dim Warcry_39 = &H12AD50
    Dim Personality_39 = &H12AD8B
    Dim Job_39 = &H12AD8C
    Dim Pose_39 = &H12AD8D
    Dim Miiname_40 = &H12B06C
    Dim Warcry_40 = &H12B090
    Dim Personality_40 = &H12B0CB
    Dim Job_40 = &H12B0CC
    Dim Pose_40 = &H12B0CD
    Dim Miiname_41 = &H12B3AC
    Dim Warcry_41 = &H12B3D0
    Dim Personality_41 = &H12B40B
    Dim Job_41 = &H12B40C
    Dim Pose_41 = &H12B40D
    Dim Miiname_42 = &H12B6EC
    Dim Warcry_42 = &H12B710
    Dim Personality_42 = &H12B74B
    Dim Job_42 = &H12B74C
    Dim Pose_42 = &H12B74D
    Dim Miiname_43 = &H12BA2C
    Dim Warcry_43 = &H12BA50
    Dim Personality_43 = &H12BA8B
    Dim Job_43 = &H12BA8C
    Dim Pose_43 = &H12BA8D
    Dim Miiname_44 = &H12BD6C
    Dim Warcry_44 = &H12BD90
    Dim Personality_44 = &H12BDCB
    Dim Job_44 = &H12BDCC
    Dim Pose_44 = &H12BDCD
    Dim Miiname_45 = &H12C0AC
    Dim Warcry_45 = &H12C0D0
    Dim Personality_45 = &H12C10B
    Dim Job_45 = &H12C10C
    Dim Pose_45 = &H12C10D
    Dim Miiname_46 = &H12C3EC
    Dim Warcry_46 = &H12C410
    Dim Personality_46 = &H12C44B
    Dim Job_46 = &H12C44C
    Dim Pose_46 = &H12C44D
    Dim Miiname_47 = &H12C72C
    Dim Warcry_47 = &H12C750
    Dim Personality_47 = &H12C78B
    Dim Job_47 = &H12C78C
    Dim Pose_47 = &H12C78D
    Dim Miiname_48 = &H12CA6C
    Dim Warcry_48 = &H12CA90
    Dim Personality_48 = &H12CACB
    Dim Job_48 = &H12CACC
    Dim Pose_48 = &H12CACD
    Dim Miiname_49 = &H12CDAC
    Dim Warcry_49 = &H12CDD0
    Dim Personality_49 = &H12CE0B
    Dim Job_49 = &H12CE0C
    Dim Pose_49 = &H12CE0D
    Dim Miiname_50 = &H12D0EC
    Dim Warcry_50 = &H12D110
    Dim Personality_50 = &H12D14B
    Dim Job_50 = &H12D14C
    Dim Pose_50 = &H12D14D
    Dim Miiname_51 = &H12D42C
    Dim Warcry_51 = &H12D450
    Dim Personality_51 = &H12D48B
    Dim Job_51 = &H12D48C
    Dim Pose_51 = &H12D48D
    Dim Miiname_52 = &H12D76C
    Dim Warcry_52 = &H12D790
    Dim Personality_52 = &H12D7CB
    Dim Job_52 = &H12D7CC
    Dim Pose_52 = &H12D7CD
    Dim Miiname_53 = &H12DAAC
    Dim Warcry_53 = &H12DAD0
    Dim Personality_53 = &H12DB0B
    Dim Job_53 = &H12DB0C
    Dim Pose_53 = &H12DB0D
    Dim Miiname_54 = &H12DDEC
    Dim Warcry_54 = &H12DE10
    Dim Personality_54 = &H12DE4B
    Dim Job_54 = &H12DE4C
    Dim Pose_54 = &H12DE4D
    Dim Miiname_55 = &H12E12C
    Dim Warcry_55 = &H12E150
    Dim Personality_55 = &H12E18B
    Dim Job_55 = &H12E18C
    Dim Pose_55 = &H12E18D
    Dim Miiname_56 = &H12E46C
    Dim Warcry_56 = &H12E490
    Dim Personality_56 = &H12E4CB
    Dim Job_56 = &H12E4CC
    Dim Pose_56 = &H12E4CD
    Dim Miiname_57 = &H12E7AC
    Dim Warcry_57 = &H12E7D0
    Dim Personality_57 = &H12E80B
    Dim Job_57 = &H12E80C
    Dim Pose_57 = &H12E80D
    Dim Miiname_58 = &H12EAEC
    Dim Warcry_58 = &H12EB10
    Dim Personality_58 = &H12EB4B
    Dim Job_58 = &H12EB4C
    Dim Pose_58 = &H12EB4D
    Dim Miiname_59 = &H12EE2C
    Dim Warcry_59 = &H12EE50
    Dim Personality_59 = &H12EE8B
    Dim Job_59 = &H12EE8C
    Dim Pose_59 = &H12EE8D
    Dim Miiname_60 = &H12F16C
    Dim Warcry_60 = &H12F190
    Dim Personality_60 = &H12F1CB
    Dim Job_60 = &H12F1CC
    Dim Pose_60 = &H12F1CD
    Dim Miiname_61 = &H12F4AC
    Dim Warcry_61 = &H12F4D0
    Dim Personality_61 = &H12F50B
    Dim Job_61 = &H12F50C
    Dim Pose_61 = &H12F50D
    Dim Miiname_62 = &H12F7EC
    Dim Warcry_62 = &H12F810
    Dim Personality_62 = &H12F84B
    Dim Job_62 = &H12F84C
    Dim Pose_62 = &H12F84D
    Dim Miiname_63 = &H12FB2C
    Dim Warcry_63 = &H12FB50
    Dim Personality_63 = &H12FB8B
    Dim Job_63 = &H12FB8C
    Dim Pose_63 = &H12FB8D
    Dim Miiname_64 = &H12FE6C
    Dim Warcry_64 = &H12FE90
    Dim Personality_64 = &H12FECB
    Dim Job_64 = &H12FECC
    Dim Pose_64 = &H12FECD
    Dim Miiname_65 = &H1301AC
    Dim Warcry_65 = &H1301D0
    Dim Personality_65 = &H13020B
    Dim Job_65 = &H13020C
    Dim Pose_65 = &H13020D
    Dim Miiname_66 = &H1304EC
    Dim Warcry_66 = &H130510
    Dim Personality_66 = &H13054B
    Dim Job_66 = &H13054C
    Dim Pose_66 = &H13054D
    Dim Miiname_67 = &H13082C
    Dim Warcry_67 = &H130850
    Dim Personality_67 = &H13088B
    Dim Job_67 = &H13088C
    Dim Pose_67 = &H13088D
    Dim Miiname_68 = &H130B6C
    Dim Warcry_68 = &H130B90
    Dim Personality_68 = &H130BCB
    Dim Job_68 = &H130BCC
    Dim Pose_68 = &H130BCD
    Dim Miiname_69 = &H130EAC
    Dim Warcry_69 = &H130ED0
    Dim Personality_69 = &H130F0B
    Dim Job_69 = &H130F0C
    Dim Pose_69 = &H130F0D
    Dim Miiname_70 = &H1311EC
    Dim Warcry_70 = &H131210
    Dim Personality_70 = &H13124B
    Dim Job_70 = &H13124C
    Dim Pose_70 = &H13124D
    Dim Miiname_71 = &H13152C
    Dim Warcry_71 = &H131550
    Dim Personality_71 = &H13158B
    Dim Job_71 = &H13158C
    Dim Pose_71 = &H13158D
    Dim Miiname_72 = &H13186C
    Dim Warcry_72 = &H131890
    Dim Personality_72 = &H1318CB
    Dim Job_72 = &H1318CC
    Dim Pose_72 = &H1318CD
    Dim Miiname_73 = &H131BAC
    Dim Warcry_73 = &H131BD0
    Dim Personality_73 = &H131C0B
    Dim Job_73 = &H131C0C
    Dim Pose_73 = &H131C0D
    Dim Miiname_74 = &H131EEC
    Dim Warcry_74 = &H131F10
    Dim Personality_74 = &H131F4B
    Dim Job_74 = &H131F4C
    Dim Pose_74 = &H131F4D
    Dim Miiname_75 = &H13222C
    Dim Warcry_75 = &H132250
    Dim Personality_75 = &H13228B
    Dim Job_75 = &H13228C
    Dim Pose_75 = &H13228D
    Dim Miiname_76 = &H13256C
    Dim Warcry_76 = &H132590
    Dim Personality_76 = &H1325CB
    Dim Job_76 = &H1325CC
    Dim Pose_76 = &H1325CD
    Dim Miiname_77 = &H1328AC
    Dim Warcry_77 = &H1328D0
    Dim Personality_77 = &H13290B
    Dim Job_77 = &H13290C
    Dim Pose_77 = &H13290D
    Dim Miiname_78 = &H132BEC
    Dim Warcry_78 = &H132C10
    Dim Personality_78 = &H132C4B
    Dim Job_78 = &H132C4C
    Dim Pose_78 = &H132C4D
    Dim Miiname_79 = &H132F2C
    Dim Warcry_79 = &H132F50
    Dim Personality_79 = &H132F8B
    Dim Job_79 = &H132F8C
    Dim Pose_79 = &H132F8D
    Dim Miiname_80 = &H13326C
    Dim Warcry_80 = &H133290
    Dim Personality_80 = &H1332CB
    Dim Job_80 = &H1332CC
    Dim Pose_80 = &H1332CD
    Dim Miiname_81 = &H1335AC
    Dim Warcry_81 = &H1335D0
    Dim Personality_81 = &H13360B
    Dim Job_81 = &H13360C
    Dim Pose_81 = &H13360D
    Dim Miiname_82 = &H1338EC
    Dim Warcry_82 = &H133910
    Dim Personality_82 = &H13394B
    Dim Job_82 = &H13394C
    Dim Pose_82 = &H13394D
    Dim Miiname_83 = &H133C2C
    Dim Warcry_83 = &H133C50
    Dim Personality_83 = &H133C8B
    Dim Job_83 = &H133C8C
    Dim Pose_83 = &H133C8D
    Dim Miiname_84 = &H133F6C
    Dim Warcry_84 = &H133F90
    Dim Personality_84 = &H133FCB
    Dim Job_84 = &H133FCC
    Dim Pose_84 = &H133FCD
    Dim Miiname_85 = &H1342AC
    Dim Warcry_85 = &H1342D0
    Dim Personality_85 = &H13430B
    Dim Job_85 = &H13430C
    Dim Pose_85 = &H13430D
    Dim Miiname_86 = &H1345EC
    Dim Warcry_86 = &H134610
    Dim Personality_86 = &H13464B
    Dim Job_86 = &H13464C
    Dim Pose_86 = &H13464D
    Dim Miiname_87 = &H13492C
    Dim Warcry_87 = &H134950
    Dim Personality_87 = &H13498B
    Dim Job_87 = &H13498C
    Dim Pose_87 = &H13498D
    Dim Miiname_88 = &H134C6C
    Dim Warcry_88 = &H134C90
    Dim Personality_88 = &H134CCB
    Dim Job_88 = &H134CCC
    Dim Pose_88 = &H134CCD
    Dim Miiname_89 = &H134FAC
    Dim Warcry_89 = &H134FD0
    Dim Personality_89 = &H13500B
    Dim Job_89 = &H13500C
    Dim Pose_89 = &H13500D
    Dim Miiname_90 = &H1352EC
    Dim Warcry_90 = &H135310
    Dim Personality_90 = &H13534B
    Dim Job_90 = &H13534C
    Dim Pose_90 = &H13534D
    Dim Miiname_91 = &H13562C
    Dim Warcry_91 = &H135650
    Dim Personality_91 = &H13568B
    Dim Job_91 = &H13568C
    Dim Pose_91 = &H13568D
    Dim Miiname_92 = &H13596C
    Dim Warcry_92 = &H135990
    Dim Personality_92 = &H1359CB
    Dim Job_92 = &H1359CC
    Dim Pose_92 = &H1359CD
    Dim Miiname_93 = &H135CAC
    Dim Warcry_93 = &H135CD0
    Dim Personality_93 = &H135D0B
    Dim Job_93 = &H135D0C
    Dim Pose_93 = &H135D0D
    Dim Miiname_94 = &H135FEC
    Dim Warcry_94 = &H136010
    Dim Personality_94 = &H13604B
    Dim Job_94 = &H13604C
    Dim Pose_94 = &H13604D
    Dim Miiname_95 = &H13632C
    Dim Warcry_95 = &H136350
    Dim Personality_95 = &H13638B
    Dim Job_95 = &H13638C
    Dim Pose_95 = &H13638D
    Dim Miiname_96 = &H13666C
    Dim Warcry_96 = &H136690
    Dim Personality_96 = &H1366CB
    Dim Job_96 = &H1366CC
    Dim Pose_96 = &H1366CD
    Dim Miiname_97 = &H1369AC
    Dim Warcry_97 = &H1369D0
    Dim Personality_97 = &H136A0B
    Dim Job_97 = &H136A0C
    Dim Pose_97 = &H136A0D
    Dim Miiname_98 = &H136CEC
    Dim Warcry_98 = &H136D10
    Dim Personality_98 = &H136D4B
    Dim Job_98 = &H136D4C
    Dim Pose_98 = &H136D4D
    Dim Miiname_99 = &H13702C
    Dim Warcry_99 = &H137050
    Dim Personality_99 = &H13708B
    Dim Job_99 = &H13708C
    Dim Pose_99 = &H13708D
    Dim Miiname_100 = &H13736C
    Dim Warcry_100 = &H137390
    Dim Personality_100 = &H1373CB
    Dim Job_100 = &H1373CC
    Dim Pose_100 = &H1373CD

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

    Private Sub Select_personality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_personality.SelectedIndexChanged
        If Select_personality.SelectedItem = Select_personality.Items.Item(0) Then
            valu_personality.Value = 0
        ElseIf Select_personality.SelectedItem = Select_personality.Items.Item(1) Then
            valu_personality.Value = 1
        ElseIf Select_personality.SelectedItem = Select_personality.Items.Item(2) Then
            valu_personality.Value = 2
        ElseIf Select_personality.SelectedItem = Select_personality.Items.Item(3) Then
            valu_personality.Value = 3
        ElseIf Select_personality.SelectedItem = Select_personality.Items.Item(4) Then
            valu_personality.Value = 4
        ElseIf Select_personality.SelectedItem = Select_personality.Items.Item(5) Then
            valu_personality.Value = 5
        ElseIf Select_personality.SelectedItem = Select_personality.Items.Item(6) Then
            valu_personality.Value = 6
        End If
    End Sub

    Private Sub valu_personality_ValueChanged(sender As Object, e As EventArgs) Handles valu_personality.ValueChanged
        If valu_personality.Value = 0 Then
            Select_personality.SelectedItem = Select_personality.Items.Item(0)
        ElseIf valu_personality.Value = 1 Then
            Select_personality.SelectedItem = Select_personality.Items.Item(1)
        ElseIf valu_personality.Value = 2 Then
            Select_personality.SelectedItem = Select_personality.Items.Item(2)
        ElseIf valu_personality.Value = 3 Then
            Select_personality.SelectedItem = Select_personality.Items.Item(3)
        ElseIf valu_personality.Value = 4 Then
            Select_personality.SelectedItem = Select_personality.Items.Item(4)
        ElseIf valu_personality.Value = 5 Then
            Select_personality.SelectedItem = Select_personality.Items.Item(5)
        ElseIf valu_personality.Value = 6 Then
            Select_personality.SelectedItem = Select_personality.Items.Item(6)
        End If
    End Sub

    Private Sub valu_pose_ValueChanged(sender As Object, e As EventArgs) Handles valu_pose.ValueChanged
        If valu_pose.Value = 0 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(0)
        ElseIf valu_pose.Value = 1 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(1)
        ElseIf valu_pose.Value = 2 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(2)
        ElseIf valu_pose.Value = 3 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(3)
        ElseIf valu_pose.Value = 4 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(4)
        ElseIf valu_pose.Value = 5 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(5)
        ElseIf valu_pose.Value = 6 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(6)
        ElseIf valu_pose.Value = 7 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(7)
        ElseIf valu_pose.Value = 8 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(8)
        ElseIf valu_pose.Value = 9 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(9)
        ElseIf valu_pose.Value = 10 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(10)
        ElseIf valu_pose.Value = 11 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(11)
        ElseIf valu_pose.Value = 12 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(12)
        ElseIf valu_pose.Value = 13 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(13)
        ElseIf valu_pose.Value = 14 Then
            Select_pose.SelectedItem = Select_pose.Items.Item(14)
        End If
    End Sub

    Private Sub Select_pose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_pose.SelectedIndexChanged
        If Select_pose.SelectedItem = Select_pose.Items.Item(0) Then
            valu_pose.Value = 0
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(1) Then
            valu_pose.Value = 1
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(2) Then
            valu_pose.Value = 2
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(3) Then
            valu_pose.Value = 3
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(4) Then
            valu_pose.Value = 4
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(5) Then
            valu_pose.Value = 5
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(6) Then
            valu_pose.Value = 6
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(7) Then
            valu_pose.Value = 7
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(8) Then
            valu_pose.Value = 8
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(9) Then
            valu_pose.Value = 9
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(10) Then
            valu_pose.Value = 10
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(11) Then
            valu_pose.Value = 11
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(12) Then
            valu_pose.Value = 12
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(13) Then
            valu_pose.Value = 13
        ElseIf Select_pose.SelectedItem = Select_pose.Items.Item(14) Then
            valu_pose.Value = 14
        End If
    End Sub

    Private Sub valu_job_ValueChanged(sender As Object, e As EventArgs) Handles valu_job.ValueChanged
        If valu_job.Value = 0 Then
            Icon_job.Image = My.Resources.Miitopia___Warrior_Icon
            Select_job.SelectedItem = Select_job.Items.Item(0)
        ElseIf valu_job.Value = 1 Then
            Icon_job.Image = My.Resources.Miitopia___Mage_Icon
            Select_job.SelectedItem = Select_job.Items.Item(1)
        ElseIf valu_job.Value = 2 Then
            Icon_job.Image = My.Resources.Miitopia___Cleric_Icon
            Select_job.SelectedItem = Select_job.Items.Item(2)
        ElseIf valu_job.Value = 3 Then
            Icon_job.Image = My.Resources.Miitopia___Thief_Icon
            Select_job.SelectedItem = Select_job.Items.Item(3)
        ElseIf valu_job.Value = 4 Then
            Icon_job.Image = My.Resources.Miitopia___Pop_Star_Icon
            Select_job.SelectedItem = Select_job.Items.Item(4)
        ElseIf valu_job.Value = 5 Then
            Icon_job.Image = My.Resources.Miitopia___Pop_Star_Icon
            Select_job.SelectedItem = Select_job.Items.Item(5)
        ElseIf valu_job.Value = 6 Then
            Icon_job.Image = My.Resources.Miitopia___Vampire_Icon
            Select_job.SelectedItem = Select_job.Items.Item(6)
        ElseIf valu_job.Value = 7 Then
            Icon_job.Image = My.Resources.Miitopia___Chef_Icon
            Select_job.SelectedItem = Select_job.Items.Item(7)
        ElseIf valu_job.Value = 8 Then
            Icon_job.Image = My.Resources.Miitopia___Tank_Icon
            Select_job.SelectedItem = Select_job.Items.Item(8)
        ElseIf valu_job.Value = 9 Then
            Icon_job.Image = My.Resources.Miitopia___Imp_Icon
            Select_job.SelectedItem = Select_job.Items.Item(9)
        ElseIf valu_job.Value = 10 Then
            Icon_job.Image = My.Resources.Miitopia___Princess_Icon
            Select_job.SelectedItem = Select_job.Items.Item(10)
        ElseIf valu_job.Value = 11 Then
            Icon_job.Image = My.Resources.Miitopia___Flower_Icon
            Select_job.SelectedItem = Select_job.Items.Item(11)
        ElseIf valu_job.Value = 12 Then
            Icon_job.Image = My.Resources.Miitopia___Scientist_Icon
            Select_job.SelectedItem = Select_job.Items.Item(12)
        ElseIf valu_job.Value = 13 Then
            Icon_job.Image = My.Resources.Miitopia___Cat_Icon
            Select_job.SelectedItem = Select_job.Items.Item(13)
        ElseIf valu_job.Value = 14 Then
            Icon_job.Image = My.Resources.Miitopia___Elf_Icon
            Select_job.SelectedItem = Select_job.Items.Item(14)
        ElseIf valu_job.Value = 15 Then
            Icon_job.Image = Nothing
            Select_job.SelectedItem = Select_job.Items.Item(15)
        End If
    End Sub

    Private Sub Select_job_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_job.SelectedIndexChanged
        If Select_job.SelectedItem = Select_job.Items.Item(0) Then
            valu_job.Value = 0
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(1) Then
            valu_job.Value = 1
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(2) Then
            valu_job.Value = 2
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(3) Then
            valu_job.Value = 3
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(4) Then
            valu_job.Value = 4
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(5) Then
            valu_job.Value = 5
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(6) Then
            valu_job.Value = 6
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(7) Then
            valu_job.Value = 7
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(8) Then
            valu_job.Value = 8
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(9) Then
            valu_job.Value = 9
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(10) Then
            valu_job.Value = 10
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(11) Then
            valu_job.Value = 11
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(12) Then
            valu_job.Value = 12
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(13) Then
            valu_job.Value = 13
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(14) Then
            valu_job.Value = 14
        ElseIf Select_job.SelectedItem = Select_job.Items.Item(15) Then
            valu_job.Value = 15
        End If
    End Sub

    Private Sub Select_Mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Mii.SelectedIndexChanged
        Select_job.SelectedItem = Select_job.Items.Item(0)
        Select_personality.SelectedItem = Select_personality.Items.Item(0)
        Select_pose.SelectedItem = Select_pose.Items.Item(0)
        Readmiiprofile()
        Text_Miieditname.Text = Select_Mii.Text
        If Select_Mii.SelectedItem = Select_Mii.Items(0) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(1) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(2) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(3) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(4) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(5) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(6) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(7) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(8) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(9) Then
            Icon_innvilla.Image = My.Resources.icon_mii_inn
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(10) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(11) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(12) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(13) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(14) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(15) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(16) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(17) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(18) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(19) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(20) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(21) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(22) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(23) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(24) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(25) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(26) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(27) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(28) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(29) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(30) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(31) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(32) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(33) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(34) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(35) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(36) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(37) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(38) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(39) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(40) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(41) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(42) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(43) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(44) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(45) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(46) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(47) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(48) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(49) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(50) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(51) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(52) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(53) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(54) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(55) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(56) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(57) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(58) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(59) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(60) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(61) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(62) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(63) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(64) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(65) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(66) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(67) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(68) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(69) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(70) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(71) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(72) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(73) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(74) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(75) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(76) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(77) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(78) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(79) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(80) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(81) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(82) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(83) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(84) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(85) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(86) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(87) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(88) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(89) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(90) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(91) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(92) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(93) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(94) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(95) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(96) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(97) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(98) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        If Select_Mii.SelectedItem = Select_Mii.Items(99) Then
            Icon_innvilla.Image = My.Resources.icon_mii_villa
        End If
        Readmiiprofile()
    End Sub

    Public Sub Readmiiprofile()
        Try
            Dim Readmiiprofile As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            If Select_Mii.SelectedItem = Select_Mii.Items(0) Then
                Readmiiprofile.Position = Miiname_1
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_1
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_1
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_1
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_1
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(1) Then
                Readmiiprofile.Position = Miiname_2
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_2
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_2
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_2
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_2
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(2) Then
                Readmiiprofile.Position = Miiname_3
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_3
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_3
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_3
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_3
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(3) Then
                Readmiiprofile.Position = Miiname_4
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_4
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_4
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_4
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_4
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(4) Then
                Readmiiprofile.Position = Miiname_5
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_5
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_5
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_5
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_5
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(5) Then
                Readmiiprofile.Position = Miiname_6
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_6
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_6
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_6
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_6
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(6) Then
                Readmiiprofile.Position = Miiname_7
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_7
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_7
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_7
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_7
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(7) Then
                Readmiiprofile.Position = Miiname_8
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_8
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_8
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_8
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_8
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(8) Then
                Readmiiprofile.Position = Miiname_9
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_9
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_9
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_9
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_9
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(9) Then
                Readmiiprofile.Position = Miiname_10
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_10
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_10
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_10
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_10
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(10) Then
                Readmiiprofile.Position = Miiname_11
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_11
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_11
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_11
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_11
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(11) Then
                Readmiiprofile.Position = Miiname_12
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_12
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_12
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_12
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_12
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(12) Then
                Readmiiprofile.Position = Miiname_13
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_13
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_13
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_13
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_13
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(13) Then
                Readmiiprofile.Position = Miiname_14
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_14
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_14
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_14
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_14
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(14) Then
                Readmiiprofile.Position = Miiname_15
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_15
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_15
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_15
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_15
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(15) Then
                Readmiiprofile.Position = Miiname_16
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_16
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_16
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_16
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_16
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(16) Then
                Readmiiprofile.Position = Miiname_17
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_17
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_17
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_17
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_17
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(17) Then
                Readmiiprofile.Position = Miiname_18
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_18
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_18
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_18
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_18
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(18) Then
                Readmiiprofile.Position = Miiname_19
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_19
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_19
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_19
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_19
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(19) Then
                Readmiiprofile.Position = Miiname_20
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_20
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_20
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_20
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_20
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(20) Then
                Readmiiprofile.Position = Miiname_21
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_21
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_21
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_21
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_21
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(21) Then
                Readmiiprofile.Position = Miiname_22
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_22
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_22
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_22
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_22
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(22) Then
                Readmiiprofile.Position = Miiname_23
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_23
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_23
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_23
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_23
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(23) Then
                Readmiiprofile.Position = Miiname_24
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_24
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_24
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_24
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_24
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(24) Then
                Readmiiprofile.Position = Miiname_25
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_25
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_25
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_25
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_25
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(25) Then
                Readmiiprofile.Position = Miiname_26
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_26
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_26
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_26
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_26
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(26) Then
                Readmiiprofile.Position = Miiname_27
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_27
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_27
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_27
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_27
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(27) Then
                Readmiiprofile.Position = Miiname_28
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_28
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_28
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_28
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_28
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(28) Then
                Readmiiprofile.Position = Miiname_29
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_29
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_29
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_29
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_29
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(29) Then
                Readmiiprofile.Position = Miiname_30
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_30
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_30
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_30
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_30
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(30) Then
                Readmiiprofile.Position = Miiname_31
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_31
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_31
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_31
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_31
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(31) Then
                Readmiiprofile.Position = Miiname_32
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_32
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_32
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_32
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_32
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(32) Then
                Readmiiprofile.Position = Miiname_33
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_33
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_33
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_33
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_33
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(33) Then
                Readmiiprofile.Position = Miiname_34
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_34
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_34
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_34
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_34
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(34) Then
                Readmiiprofile.Position = Miiname_35
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_35
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_35
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_35
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_35
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(35) Then
                Readmiiprofile.Position = Miiname_36
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_36
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_36
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_36
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_36
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(36) Then
                Readmiiprofile.Position = Miiname_37
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_37
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_37
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_37
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_37
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(37) Then
                Readmiiprofile.Position = Miiname_38
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_38
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_38
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_38
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_38
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(38) Then
                Readmiiprofile.Position = Miiname_39
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_39
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_39
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_39
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_39
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(39) Then
                Readmiiprofile.Position = Miiname_40
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_40
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_40
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_40
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_40
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(40) Then
                Readmiiprofile.Position = Miiname_41
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_41
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_41
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_41
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_41
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(41) Then
                Readmiiprofile.Position = Miiname_42
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_42
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_42
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_42
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_42
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(42) Then
                Readmiiprofile.Position = Miiname_43
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_43
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_43
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_43
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_43
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(43) Then
                Readmiiprofile.Position = Miiname_44
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_44
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_44
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_44
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_44
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(44) Then
                Readmiiprofile.Position = Miiname_45
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_45
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_45
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_45
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_45
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(45) Then
                Readmiiprofile.Position = Miiname_46
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_46
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_46
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_46
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_46
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(46) Then
                Readmiiprofile.Position = Miiname_47
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_47
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_47
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_47
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_47
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(47) Then
                Readmiiprofile.Position = Miiname_48
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_48
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_48
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_48
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_48
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(48) Then
                Readmiiprofile.Position = Miiname_49
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_49
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_49
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_49
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_49
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(49) Then
                Readmiiprofile.Position = Miiname_50
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_50
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_50
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_50
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_50
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(50) Then
                Readmiiprofile.Position = Miiname_51
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_51
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_51
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_51
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_51
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(51) Then
                Readmiiprofile.Position = Miiname_52
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_52
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_52
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_52
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_52
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(52) Then
                Readmiiprofile.Position = Miiname_53
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_53
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_53
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_53
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_53
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(53) Then
                Readmiiprofile.Position = Miiname_54
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_54
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_54
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_54
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_54
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(54) Then
                Readmiiprofile.Position = Miiname_55
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_55
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_55
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_55
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_55
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(55) Then
                Readmiiprofile.Position = Miiname_56
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_56
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_56
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_56
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_56
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(56) Then
                Readmiiprofile.Position = Miiname_57
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_57
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_57
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_57
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_57
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(57) Then
                Readmiiprofile.Position = Miiname_58
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_58
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_58
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_58
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_58
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(58) Then
                Readmiiprofile.Position = Miiname_59
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_59
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_59
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_59
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_59
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(59) Then
                Readmiiprofile.Position = Miiname_60
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_60
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_60
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_60
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_60
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(60) Then
                Readmiiprofile.Position = Miiname_61
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_61
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_61
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_61
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_61
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(61) Then
                Readmiiprofile.Position = Miiname_62
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_62
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_62
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_62
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_62
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(62) Then
                Readmiiprofile.Position = Miiname_63
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_63
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_63
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_63
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_63
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(63) Then
                Readmiiprofile.Position = Miiname_64
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_64
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_64
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_64
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_64
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(64) Then
                Readmiiprofile.Position = Miiname_65
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_65
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_65
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_65
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_65
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(65) Then
                Readmiiprofile.Position = Miiname_66
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_66
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_66
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_66
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_66
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(66) Then
                Readmiiprofile.Position = Miiname_67
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_67
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_67
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_67
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_67
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(67) Then
                Readmiiprofile.Position = Miiname_68
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_68
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_68
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_68
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_68
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(68) Then
                Readmiiprofile.Position = Miiname_69
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_69
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_69
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_69
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_69
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(69) Then
                Readmiiprofile.Position = Miiname_70
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_70
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_70
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_70
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_70
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(70) Then
                Readmiiprofile.Position = Miiname_71
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_71
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_71
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_71
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_71
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(71) Then
                Readmiiprofile.Position = Miiname_72
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_72
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_72
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_72
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_72
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(72) Then
                Readmiiprofile.Position = Miiname_73
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_73
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_73
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_73
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_73
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(73) Then
                Readmiiprofile.Position = Miiname_74
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_74
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_74
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_74
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_74
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(74) Then
                Readmiiprofile.Position = Miiname_75
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_75
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_75
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_75
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_75
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(75) Then
                Readmiiprofile.Position = Miiname_76
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_76
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_76
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_76
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_76
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(76) Then
                Readmiiprofile.Position = Miiname_77
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_77
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_77
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_77
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_77
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(77) Then
                Readmiiprofile.Position = Miiname_78
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_78
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_78
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_78
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_78
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(78) Then
                Readmiiprofile.Position = Miiname_79
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_79
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_79
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_79
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_79
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(79) Then
                Readmiiprofile.Position = Miiname_80
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_80
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_80
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_80
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_80
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(80) Then
                Readmiiprofile.Position = Miiname_81
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_81
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_81
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_81
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_81
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(81) Then
                Readmiiprofile.Position = Miiname_82
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_82
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_82
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_82
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_82
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(82) Then
                Readmiiprofile.Position = Miiname_83
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_83
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_83
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_83
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_83
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(83) Then
                Readmiiprofile.Position = Miiname_84
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_84
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_84
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_84
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_84
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(84) Then
                Readmiiprofile.Position = Miiname_85
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_85
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_85
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_85
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_85
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(85) Then
                Readmiiprofile.Position = Miiname_86
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_86
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_86
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_86
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_86
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(86) Then
                Readmiiprofile.Position = Miiname_87
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_87
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_87
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_87
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_87
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(87) Then
                Readmiiprofile.Position = Miiname_88
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_88
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_88
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_88
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_88
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(88) Then
                Readmiiprofile.Position = Miiname_89
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_89
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_89
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_89
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_89
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(89) Then
                Readmiiprofile.Position = Miiname_90
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_90
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_90
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_90
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_90
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(90) Then
                Readmiiprofile.Position = Miiname_91
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_91
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_91
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_91
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_91
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(91) Then
                Readmiiprofile.Position = Miiname_92
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_92
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_92
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_92
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_92
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(92) Then
                Readmiiprofile.Position = Miiname_93
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_93
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_93
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_93
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_93
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(93) Then
                Readmiiprofile.Position = Miiname_94
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_94
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_94
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_94
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_94
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(94) Then
                Readmiiprofile.Position = Miiname_95
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_95
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_95
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_95
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_95
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(95) Then
                Readmiiprofile.Position = Miiname_96
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_96
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_96
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_96
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_96
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(96) Then
                Readmiiprofile.Position = Miiname_97
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_97
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_97
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_97
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_97
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(97) Then
                Readmiiprofile.Position = Miiname_98
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_98
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_98
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_98
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_98
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(98) Then
                Readmiiprofile.Position = Miiname_99
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_99
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_99
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_99
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_99
                valu_job.Value = Readmiiprofile.ReadByte
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(99) Then
                Readmiiprofile.Position = Miiname_100
                Text_miiname.Text = Readmiiprofile.ReadUnicodeString(10)
                Readmiiprofile.Position = Warcry_100
                Text_warcry.Text = Readmiiprofile.ReadUnicodeString(26)
                Readmiiprofile.Position = Personality_100
                valu_personality.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Pose_100
                valu_pose.Value = Readmiiprofile.ReadByte
                Readmiiprofile.Position = Job_100
                valu_job.Value = Readmiiprofile.ReadByte
            End If
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read profile of this Mii" & vbNewLine & "Retry or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub ReadMiiname()
        Try
            Dim ReadMiiname As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            ReadMiiname.Position = Miiname_1
            Select_Mii.Items.Item(0) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_2
            Select_Mii.Items.Item(1) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_3
            Select_Mii.Items.Item(2) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_4
            Select_Mii.Items.Item(3) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_5
            Select_Mii.Items.Item(4) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_6
            Select_Mii.Items.Item(5) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_7
            Select_Mii.Items.Item(6) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_8
            Select_Mii.Items.Item(7) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_9
            Select_Mii.Items.Item(8) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_10
            Select_Mii.Items.Item(9) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_11
            Select_Mii.Items.Item(10) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_12
            Select_Mii.Items.Item(11) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_13
            Select_Mii.Items.Item(12) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_14
            Select_Mii.Items.Item(13) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_15
            Select_Mii.Items.Item(14) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_16
            Select_Mii.Items.Item(15) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_17
            Select_Mii.Items.Item(16) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_18
            Select_Mii.Items.Item(17) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_19
            Select_Mii.Items.Item(18) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_20
            Select_Mii.Items.Item(19) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_21
            Select_Mii.Items.Item(20) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_22
            Select_Mii.Items.Item(21) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_23
            Select_Mii.Items.Item(22) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_24
            Select_Mii.Items.Item(23) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_25
            Select_Mii.Items.Item(24) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_26
            Select_Mii.Items.Item(25) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_27
            Select_Mii.Items.Item(26) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_28
            Select_Mii.Items.Item(27) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_29
            Select_Mii.Items.Item(28) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_30
            Select_Mii.Items.Item(29) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_31
            Select_Mii.Items.Item(30) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_32
            Select_Mii.Items.Item(31) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_33
            Select_Mii.Items.Item(32) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_34
            Select_Mii.Items.Item(33) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_35
            Select_Mii.Items.Item(34) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_36
            Select_Mii.Items.Item(35) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_37
            Select_Mii.Items.Item(36) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_38
            Select_Mii.Items.Item(37) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_39
            Select_Mii.Items.Item(38) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_40
            Select_Mii.Items.Item(39) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_41
            Select_Mii.Items.Item(40) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_42
            Select_Mii.Items.Item(41) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_43
            Select_Mii.Items.Item(42) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_44
            Select_Mii.Items.Item(43) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_45
            Select_Mii.Items.Item(44) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_46
            Select_Mii.Items.Item(45) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_47
            Select_Mii.Items.Item(46) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_48
            Select_Mii.Items.Item(47) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_49
            Select_Mii.Items.Item(48) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_50
            Select_Mii.Items.Item(49) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_51
            Select_Mii.Items.Item(50) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_52
            Select_Mii.Items.Item(51) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_53
            Select_Mii.Items.Item(52) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_54
            Select_Mii.Items.Item(53) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_55
            Select_Mii.Items.Item(54) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_56
            Select_Mii.Items.Item(55) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_57
            Select_Mii.Items.Item(56) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_58
            Select_Mii.Items.Item(57) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_59
            Select_Mii.Items.Item(58) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_60
            Select_Mii.Items.Item(59) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_61
            Select_Mii.Items.Item(60) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_62
            Select_Mii.Items.Item(61) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_63
            Select_Mii.Items.Item(62) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_64
            Select_Mii.Items.Item(63) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_65
            Select_Mii.Items.Item(64) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_66
            Select_Mii.Items.Item(65) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_67
            Select_Mii.Items.Item(66) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_68
            Select_Mii.Items.Item(67) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_69
            Select_Mii.Items.Item(68) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_70
            Select_Mii.Items.Item(69) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_71
            Select_Mii.Items.Item(70) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_72
            Select_Mii.Items.Item(71) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_73
            Select_Mii.Items.Item(72) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_74
            Select_Mii.Items.Item(73) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_75
            Select_Mii.Items.Item(74) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_76
            Select_Mii.Items.Item(75) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_77
            Select_Mii.Items.Item(76) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_78
            Select_Mii.Items.Item(77) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_79
            Select_Mii.Items.Item(78) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_80
            Select_Mii.Items.Item(79) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_81
            Select_Mii.Items.Item(80) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_82
            Select_Mii.Items.Item(81) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_83
            Select_Mii.Items.Item(82) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_84
            Select_Mii.Items.Item(83) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_85
            Select_Mii.Items.Item(84) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_86
            Select_Mii.Items.Item(85) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_87
            Select_Mii.Items.Item(86) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_88
            Select_Mii.Items.Item(87) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_89
            Select_Mii.Items.Item(88) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_90
            Select_Mii.Items.Item(89) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_91
            Select_Mii.Items.Item(90) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_92
            Select_Mii.Items.Item(91) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_93
            Select_Mii.Items.Item(92) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_94
            Select_Mii.Items.Item(93) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_95
            Select_Mii.Items.Item(94) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_96
            Select_Mii.Items.Item(95) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_97
            Select_Mii.Items.Item(96) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_98
            Select_Mii.Items.Item(97) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_99
            Select_Mii.Items.Item(98) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Miiname_100
            Select_Mii.Items.Item(99) = ReadMiiname.ReadUnicodeString(10)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MSE_miiprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadMiiname()
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Savemiiprofile()
    End Sub

    Public Sub Savemiiprofile()
        Try
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_1 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_1
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_1 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_1
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_1
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_1
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_1
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_2 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_2
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_2 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_2
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_2
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_2
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_2
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_3 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_3
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_3 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_3
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_3
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_3
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_3
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_4 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_4
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_4 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_4
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_4
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_4
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_4
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_5 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_5
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_5 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_5
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_5
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_5
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_5
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_6 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_6
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_6 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_6
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_6
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_6
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_6
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_7 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_7
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_7 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_7
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_7
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_7
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_7
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_8 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_8
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_8 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_8
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_8
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_8
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_8
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_9 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_9
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_9 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_9
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_9
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_9
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_9
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_10 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_10
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_10 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_10
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_10
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_10
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_10
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(10) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_11 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_11
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_11 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_11
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_11
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_11
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_11
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(11) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_12 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_12
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_12 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_12
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_12
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_12
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_12
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(12) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_13 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_13
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_13 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_13
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_13
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_13
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_13
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(13) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_14 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_14
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_14 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_14
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_14
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_14
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_14
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(14) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_15 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_15
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_15 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_15
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_15
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_15
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_15
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(15) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_16 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_16
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_16 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_16
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_16
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_16
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_16
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(16) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_17 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_17
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_17 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_17
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_17
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_17
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_17
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(17) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_18 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_18
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_18 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_18
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_18
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_18
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_18
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(18) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_19 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_19
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_19 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_19
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_19
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_19
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_19
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(19) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_20 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_20
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_20 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_20
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_20
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_20
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_20
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(20) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_21 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_21
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_21 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_21
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_21
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_21
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_21
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(21) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_22 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_22
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_22 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_22
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_22
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_22
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_22
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(22) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_23 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_23
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_23 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_23
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_23
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_23
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_23
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(23) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_24 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_24
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_24 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_24
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_24
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_24
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_24
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(24) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_25 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_25
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_25 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_25
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_25
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_25
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_25
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(25) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_26 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_26
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_26 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_26
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_26
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_26
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_26
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(26) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_27 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_27
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_27 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_27
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_27
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_27
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_27
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(27) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_28 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_28
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_28 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_28
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_28
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_28
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_28
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(28) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_29 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_29
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_29 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_29
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_29
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_29
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_29
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(29) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_30 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_30
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_30 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_30
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_30
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_30
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_30
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(30) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_31 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_31
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_31 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_31
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_31
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_31
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_31
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(31) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_32 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_32
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_32 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_32
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_32
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_32
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_32
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(32) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_33 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_33
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_33 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_33
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_33
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_33
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_33
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(33) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_34 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_34
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_34 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_34
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_34
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_34
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_34
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(34) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_35 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_35
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_35 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_35
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_35
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_35
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_35
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(35) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_36 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_36
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_36 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_36
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_36
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_36
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_36
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(36) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_37 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_37
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_37 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_37
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_37
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_37
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_37
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(37) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_38 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_38
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_38 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_38
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_38
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_38
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_38
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(38) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_39 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_39
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_39 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_39
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_39
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_39
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_39
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(39) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_40 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_40
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_40 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_40
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_40
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_40
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_40
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(40) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_41 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_41
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_41 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_41
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_41
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_41
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_41
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(41) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_42 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_42
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_42 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_42
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_42
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_42
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_42
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(42) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_43 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_43
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_43 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_43
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_43
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_43
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_43
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(43) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_44 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_44
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_44 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_44
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_44
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_44
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_44
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(44) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_45 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_45
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_45 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_45
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_45
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_45
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_45
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(45) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_46 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_46
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_46 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_46
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_46
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_46
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_46
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(46) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_47 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_47
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_47 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_47
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_47
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_47
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_47
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(47) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_48 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_48
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_48 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_48
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_48
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_48
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_48
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(48) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_49 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_49
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_49 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_49
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_49
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_49
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_49
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(49) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_50 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_50
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_50 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_50
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_50
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_50
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_50
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(50) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_51 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_51
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_51 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_51
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_51
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_51
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_51
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(51) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_52 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_52
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_52 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_52
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_52
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_52
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_52
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(52) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_53 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_53
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_53 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_53
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_53
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_53
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_53
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(53) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_54 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_54
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_54 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_54
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_54
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_54
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_54
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(54) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_55 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_55
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_55 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_55
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_55
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_55
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_55
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(55) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_56 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_56
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_56 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_56
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_56
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_56
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_56
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(56) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_57 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_57
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_57 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_57
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_57
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_57
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_57
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(57) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_58 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_58
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_58 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_58
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_58
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_58
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_58
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(58) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_59 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_59
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_59 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_59
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_59
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_59
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_59
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(59) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_60 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_60
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_60 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_60
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_60
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_60
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_60
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(60) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_61 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_61
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_61 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_61
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_61
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_61
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_61
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(61) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_62 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_62
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_62 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_62
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_62
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_62
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_62
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(62) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_63 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_63
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_63 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_63
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_63
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_63
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_63
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(63) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_64 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_64
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_64 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_64
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_64
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_64
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_64
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(64) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_65 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_65
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_65 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_65
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_65
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_65
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_65
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(65) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_66 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_66
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_66 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_66
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_66
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_66
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_66
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(66) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_67 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_67
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_67 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_67
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_67
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_67
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_67
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(67) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_68 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_68
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_68 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_68
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_68
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_68
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_68
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(68) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_69 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_69
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_69 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_69
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_69
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_69
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_69
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(69) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_70 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_70
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_70 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_70
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_70
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_70
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_70
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(70) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_71 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_71
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_71 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_71
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_71
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_71
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_71
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(71) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_72 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_72
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_72 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_72
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_72
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_72
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_72
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(72) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_73 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_73
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_73 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_73
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_73
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_73
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_73
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(73) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_74 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_74
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_74 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_74
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_74
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_74
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_74
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(74) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_75 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_75
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_75 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_75
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_75
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_75
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_75
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(75) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_76 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_76
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_76 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_76
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_76
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_76
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_76
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(76) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_77 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_77
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_77 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_77
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_77
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_77
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_77
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(77) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_78 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_78
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_78 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_78
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_78
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_78
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_78
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(78) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_79 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_79
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_79 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_79
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_79
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_79
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_79
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(79) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_80 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_80
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_80 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_80
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_80
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_80
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_80
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(80) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_81 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_81
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_81 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_81
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_81
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_81
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_81
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(81) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_82 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_82
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_82 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_82
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_82
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_82
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_82
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(82) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_83 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_83
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_83 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_83
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_83
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_83
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_83
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(83) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_84 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_84
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_84 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_84
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_84
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_84
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_84
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(84) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_85 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_85
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_85 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_85
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_85
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_85
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_85
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(85) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_86 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_86
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_86 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_86
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_86
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_86
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_86
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(86) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_87 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_87
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_87 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_87
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_87
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_87
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_87
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(87) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_88 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_88
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_88 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_88
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_88
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_88
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_88
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(88) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_89 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_89
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_89 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_89
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_89
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_89
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_89
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(89) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_90 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_90
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_90 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_90
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_90
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_90
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_90
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(90) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_91 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_91
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_91 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_91
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_91
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_91
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_91
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(91) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_92 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_92
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_92 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_92
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_92
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_92
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_92
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(92) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_93 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_93
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_93 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_93
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_93
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_93
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_93
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(93) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_94 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_94
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_94 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_94
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_94
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_94
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_94
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(94) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_95 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_95
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_95 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_95
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_95
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_95
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_95
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(95) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_96 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_96
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_96 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_96
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_96
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_96
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_96
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(96) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_97 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_97
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_97 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_97
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_97
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_97
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_97
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(97) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_98 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_98
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_98 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_98
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_98
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_98
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_98
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(98) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_99 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_99
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_99 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_99
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_99
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_99
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_99
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(99) Then
                Dim Writemiiprofile As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writemiiprofile.Position = Miiname_100 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Miiname_100
                Writemiiprofile.WriteUnicodeString(Text_miiname.Text)
                For i As Integer = 0 To 51
                    Writemiiprofile.Position = Warcry_100 + i
                    Writemiiprofile.WriteInt8(0)
                Next
                Writemiiprofile.Position = Warcry_100
                Writemiiprofile.WriteUnicodeString(Text_warcry.Text)
                Writemiiprofile.Position = Personality_100
                Writemiiprofile.WriteInt8(valu_personality.Value)
                Writemiiprofile.Position = Pose_100
                Writemiiprofile.WriteInt8(valu_pose.Value)
                Writemiiprofile.Position = Job_100
                Writemiiprofile.WriteInt8(valu_job.Value)
            End If
            MSE_dialog.text_dialog.Text = "Mii profile has been successfully edited"
            MSE_dialog.ShowDialog()
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to edit profile of this Mii" & vbNewLine & "Retry or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub
End Class