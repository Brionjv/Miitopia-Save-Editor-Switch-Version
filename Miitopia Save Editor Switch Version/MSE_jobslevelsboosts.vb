Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_jobslevelsboosts
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim Lv_warrior_1 = &HFD058
    Dim Lv_warrior_2 = &HFD398
    Dim Lv_warrior_3 = &HFD6D8
    Dim Lv_warrior_4 = &HFDA18
    Dim Lv_warrior_5 = &HFDD58
    Dim Lv_warrior_6 = &HFE098
    Dim Lv_warrior_7 = &HFE3D8
    Dim Lv_warrior_8 = &HFE718
    Dim Lv_warrior_9 = &HFEA58
    Dim Lv_warrior_10 = &HFED98
    Dim Lv_warrior_11 = &H1252A0
    Dim Lv_warrior_12 = &H1255E0
    Dim Lv_warrior_13 = &H125920
    Dim Lv_warrior_14 = &H125C60
    Dim Lv_warrior_15 = &H125FA0
    Dim Lv_warrior_16 = &H1262E0
    Dim Lv_warrior_17 = &H126620
    Dim Lv_warrior_18 = &H126960
    Dim Lv_warrior_19 = &H126CA0
    Dim Lv_warrior_20 = &H126FE0
    Dim Lv_warrior_21 = &H127320
    Dim Lv_warrior_22 = &H127660
    Dim Lv_warrior_23 = &H1279A0
    Dim Lv_warrior_24 = &H127CE0
    Dim Lv_warrior_25 = &H128020
    Dim Lv_warrior_26 = &H128360
    Dim Lv_warrior_27 = &H1286A0
    Dim Lv_warrior_28 = &H1289E0
    Dim Lv_warrior_29 = &H128D20
    Dim Lv_warrior_30 = &H129060
    Dim Lv_warrior_31 = &H1293A0
    Dim Lv_warrior_32 = &H1296E0
    Dim Lv_warrior_33 = &H129A20
    Dim Lv_warrior_34 = &H129D60
    Dim Lv_warrior_35 = &H12A0A0
    Dim Lv_warrior_36 = &H12A3E0
    Dim Lv_warrior_37 = &H12A720
    Dim Lv_warrior_38 = &H12AA60
    Dim Lv_warrior_39 = &H12ADA0
    Dim Lv_warrior_40 = &H12B0E0
    Dim Lv_warrior_41 = &H12B420
    Dim Lv_warrior_42 = &H12B760
    Dim Lv_warrior_43 = &H12BAA0
    Dim Lv_warrior_44 = &H12BDE0
    Dim Lv_warrior_45 = &H12C120
    Dim Lv_warrior_46 = &H12C460
    Dim Lv_warrior_47 = &H12C7A0
    Dim Lv_warrior_48 = &H12CAE0
    Dim Lv_warrior_49 = &H12CE20
    Dim Lv_warrior_50 = &H12D160
    Dim Lv_warrior_51 = &H12D4A0
    Dim Lv_warrior_52 = &H12D7E0
    Dim Lv_warrior_53 = &H12DB20
    Dim Lv_warrior_54 = &H12DE60
    Dim Lv_warrior_55 = &H12E1A0
    Dim Lv_warrior_56 = &H12E4E0
    Dim Lv_warrior_57 = &H12E820
    Dim Lv_warrior_58 = &H12EB60
    Dim Lv_warrior_59 = &H12EEA0
    Dim Lv_warrior_60 = &H12F1E0
    Dim Lv_warrior_61 = &H12F520
    Dim Lv_warrior_62 = &H12F860
    Dim Lv_warrior_63 = &H12FBA0
    Dim Lv_warrior_64 = &H12FEE0
    Dim Lv_warrior_65 = &H130220
    Dim Lv_warrior_66 = &H130560
    Dim Lv_warrior_67 = &H1308A0
    Dim Lv_warrior_68 = &H130BE0
    Dim Lv_warrior_69 = &H130F20
    Dim Lv_warrior_70 = &H131260
    Dim Lv_warrior_71 = &H1315A0
    Dim Lv_warrior_72 = &H1318E0
    Dim Lv_warrior_73 = &H131C20
    Dim Lv_warrior_74 = &H131F60
    Dim Lv_warrior_75 = &H1322A0
    Dim Lv_warrior_76 = &H1325E0
    Dim Lv_warrior_77 = &H132920
    Dim Lv_warrior_78 = &H132C60
    Dim Lv_warrior_79 = &H132FA0
    Dim Lv_warrior_80 = &H1332E0
    Dim Lv_warrior_81 = &H133620
    Dim Lv_warrior_82 = &H133960
    Dim Lv_warrior_83 = &H133CA0
    Dim Lv_warrior_84 = &H133FE0
    Dim Lv_warrior_85 = &H134320
    Dim Lv_warrior_86 = &H134660
    Dim Lv_warrior_87 = &H1349A0
    Dim Lv_warrior_88 = &H134CE0
    Dim Lv_warrior_89 = &H135020
    Dim Lv_warrior_90 = &H135360
    Dim Lv_warrior_91 = &H1356A0
    Dim Lv_warrior_92 = &H1359E0
    Dim Lv_warrior_93 = &H135D20
    Dim Lv_warrior_94 = &H136060
    Dim Lv_warrior_95 = &H1363A0
    Dim Lv_warrior_96 = &H1366E0
    Dim Lv_warrior_97 = &H136A20
    Dim Lv_warrior_98 = &H136D60
    Dim Lv_warrior_99 = &H1370A0
    Dim Lv_warrior_100 = &H1373E0
    Dim Lv_mage_1 = &HFD05C
    Dim Lv_mage_2 = &HFD39C
    Dim Lv_mage_3 = &HFD6DC
    Dim Lv_mage_4 = &HFDA1C
    Dim Lv_mage_5 = &HFDD5C
    Dim Lv_mage_6 = &HFE09C
    Dim Lv_mage_7 = &HFE3DC
    Dim Lv_mage_8 = &HFE71C
    Dim Lv_mage_9 = &HFEA5C
    Dim Lv_mage_10 = &HFED9C
    Dim Lv_mage_11 = &H1252A4
    Dim Lv_mage_12 = &H1255E4
    Dim Lv_mage_13 = &H125924
    Dim Lv_mage_14 = &H125C64
    Dim Lv_mage_15 = &H125FA4
    Dim Lv_mage_16 = &H1262E4
    Dim Lv_mage_17 = &H126624
    Dim Lv_mage_18 = &H126964
    Dim Lv_mage_19 = &H126CA4
    Dim Lv_mage_20 = &H126FE4
    Dim Lv_mage_21 = &H127324
    Dim Lv_mage_22 = &H127664
    Dim Lv_mage_23 = &H1279A4
    Dim Lv_mage_24 = &H127CE4
    Dim Lv_mage_25 = &H128024
    Dim Lv_mage_26 = &H128364
    Dim Lv_mage_27 = &H1286A4
    Dim Lv_mage_28 = &H1289E4
    Dim Lv_mage_29 = &H128D24
    Dim Lv_mage_30 = &H129064
    Dim Lv_mage_31 = &H1293A4
    Dim Lv_mage_32 = &H1296E4
    Dim Lv_mage_33 = &H129A24
    Dim Lv_mage_34 = &H129D64
    Dim Lv_mage_35 = &H12A0A4
    Dim Lv_mage_36 = &H12A3E4
    Dim Lv_mage_37 = &H12A724
    Dim Lv_mage_38 = &H12AA64
    Dim Lv_mage_39 = &H12ADA4
    Dim Lv_mage_40 = &H12B0E4
    Dim Lv_mage_41 = &H12B424
    Dim Lv_mage_42 = &H12B764
    Dim Lv_mage_43 = &H12BAA4
    Dim Lv_mage_44 = &H12BDE4
    Dim Lv_mage_45 = &H12C124
    Dim Lv_mage_46 = &H12C464
    Dim Lv_mage_47 = &H12C7A4
    Dim Lv_mage_48 = &H12CAE4
    Dim Lv_mage_49 = &H12CE24
    Dim Lv_mage_50 = &H12D164
    Dim Lv_mage_51 = &H12D4A4
    Dim Lv_mage_52 = &H12D7E4
    Dim Lv_mage_53 = &H12DB24
    Dim Lv_mage_54 = &H12DE64
    Dim Lv_mage_55 = &H12E1A4
    Dim Lv_mage_56 = &H12E4E4
    Dim Lv_mage_57 = &H12E824
    Dim Lv_mage_58 = &H12EB64
    Dim Lv_mage_59 = &H12EEA4
    Dim Lv_mage_60 = &H12F1E4
    Dim Lv_mage_61 = &H12F524
    Dim Lv_mage_62 = &H12F864
    Dim Lv_mage_63 = &H12FBA4
    Dim Lv_mage_64 = &H12FEE4
    Dim Lv_mage_65 = &H130224
    Dim Lv_mage_66 = &H130564
    Dim Lv_mage_67 = &H1308A4
    Dim Lv_mage_68 = &H130BE4
    Dim Lv_mage_69 = &H130F24
    Dim Lv_mage_70 = &H131264
    Dim Lv_mage_71 = &H1315A4
    Dim Lv_mage_72 = &H1318E4
    Dim Lv_mage_73 = &H131C24
    Dim Lv_mage_74 = &H131F64
    Dim Lv_mage_75 = &H1322A4
    Dim Lv_mage_76 = &H1325E4
    Dim Lv_mage_77 = &H132924
    Dim Lv_mage_78 = &H132C64
    Dim Lv_mage_79 = &H132FA4
    Dim Lv_mage_80 = &H1332E4
    Dim Lv_mage_81 = &H133624
    Dim Lv_mage_82 = &H133964
    Dim Lv_mage_83 = &H133CA4
    Dim Lv_mage_84 = &H133FE4
    Dim Lv_mage_85 = &H134324
    Dim Lv_mage_86 = &H134664
    Dim Lv_mage_87 = &H1349A4
    Dim Lv_mage_88 = &H134CE4
    Dim Lv_mage_89 = &H135024
    Dim Lv_mage_90 = &H135364
    Dim Lv_mage_91 = &H1356A4
    Dim Lv_mage_92 = &H1359E4
    Dim Lv_mage_93 = &H135D24
    Dim Lv_mage_94 = &H136064
    Dim Lv_mage_95 = &H1363A4
    Dim Lv_mage_96 = &H1366E4
    Dim Lv_mage_97 = &H136A24
    Dim Lv_mage_98 = &H136D64
    Dim Lv_mage_99 = &H1370A4
    Dim Lv_mage_100 = &H1373E4
    Dim Lv_cleric_1 = &HFD060
    Dim Lv_cleric_2 = &HFD3A0
    Dim Lv_cleric_3 = &HFD6E0
    Dim Lv_cleric_4 = &HFDA20
    Dim Lv_cleric_5 = &HFDD60
    Dim Lv_cleric_6 = &HFE0A0
    Dim Lv_cleric_7 = &HFE3E0
    Dim Lv_cleric_8 = &HFE720
    Dim Lv_cleric_9 = &HFEA60
    Dim Lv_cleric_10 = &HFEDA0
    Dim Lv_cleric_11 = &H1252A8
    Dim Lv_cleric_12 = &H1255E8
    Dim Lv_cleric_13 = &H125928
    Dim Lv_cleric_14 = &H125C68
    Dim Lv_cleric_15 = &H125FA8
    Dim Lv_cleric_16 = &H1262E8
    Dim Lv_cleric_17 = &H126628
    Dim Lv_cleric_18 = &H126968
    Dim Lv_cleric_19 = &H126CA8
    Dim Lv_cleric_20 = &H126FE8
    Dim Lv_cleric_21 = &H127328
    Dim Lv_cleric_22 = &H127668
    Dim Lv_cleric_23 = &H1279A8
    Dim Lv_cleric_24 = &H127CE8
    Dim Lv_cleric_25 = &H128028
    Dim Lv_cleric_26 = &H128368
    Dim Lv_cleric_27 = &H1286A8
    Dim Lv_cleric_28 = &H1289E8
    Dim Lv_cleric_29 = &H128D28
    Dim Lv_cleric_30 = &H129068
    Dim Lv_cleric_31 = &H1293A8
    Dim Lv_cleric_32 = &H1296E8
    Dim Lv_cleric_33 = &H129A28
    Dim Lv_cleric_34 = &H129D68
    Dim Lv_cleric_35 = &H12A0A8
    Dim Lv_cleric_36 = &H12A3E8
    Dim Lv_cleric_37 = &H12A728
    Dim Lv_cleric_38 = &H12AA68
    Dim Lv_cleric_39 = &H12ADA8
    Dim Lv_cleric_40 = &H12B0E8
    Dim Lv_cleric_41 = &H12B428
    Dim Lv_cleric_42 = &H12B768
    Dim Lv_cleric_43 = &H12BAA8
    Dim Lv_cleric_44 = &H12BDE8
    Dim Lv_cleric_45 = &H12C128
    Dim Lv_cleric_46 = &H12C468
    Dim Lv_cleric_47 = &H12C7A8
    Dim Lv_cleric_48 = &H12CAE8
    Dim Lv_cleric_49 = &H12CE28
    Dim Lv_cleric_50 = &H12D168
    Dim Lv_cleric_51 = &H12D4A8
    Dim Lv_cleric_52 = &H12D7E8
    Dim Lv_cleric_53 = &H12DB28
    Dim Lv_cleric_54 = &H12DE68
    Dim Lv_cleric_55 = &H12E1A8
    Dim Lv_cleric_56 = &H12E4E8
    Dim Lv_cleric_57 = &H12E828
    Dim Lv_cleric_58 = &H12EB68
    Dim Lv_cleric_59 = &H12EEA8
    Dim Lv_cleric_60 = &H12F1E8
    Dim Lv_cleric_61 = &H12F528
    Dim Lv_cleric_62 = &H12F868
    Dim Lv_cleric_63 = &H12FBA8
    Dim Lv_cleric_64 = &H12FEE8
    Dim Lv_cleric_65 = &H130228
    Dim Lv_cleric_66 = &H130568
    Dim Lv_cleric_67 = &H1308A8
    Dim Lv_cleric_68 = &H130BE8
    Dim Lv_cleric_69 = &H130F28
    Dim Lv_cleric_70 = &H131268
    Dim Lv_cleric_71 = &H1315A8
    Dim Lv_cleric_72 = &H1318E8
    Dim Lv_cleric_73 = &H131C28
    Dim Lv_cleric_74 = &H131F68
    Dim Lv_cleric_75 = &H1322A8
    Dim Lv_cleric_76 = &H1325E8
    Dim Lv_cleric_77 = &H132928
    Dim Lv_cleric_78 = &H132C68
    Dim Lv_cleric_79 = &H132FA8
    Dim Lv_cleric_80 = &H1332E8
    Dim Lv_cleric_81 = &H133628
    Dim Lv_cleric_82 = &H133968
    Dim Lv_cleric_83 = &H133CA8
    Dim Lv_cleric_84 = &H133FE8
    Dim Lv_cleric_85 = &H134328
    Dim Lv_cleric_86 = &H134668
    Dim Lv_cleric_87 = &H1349A8
    Dim Lv_cleric_88 = &H134CE8
    Dim Lv_cleric_89 = &H135028
    Dim Lv_cleric_90 = &H135368
    Dim Lv_cleric_91 = &H1356A8
    Dim Lv_cleric_92 = &H1359E8
    Dim Lv_cleric_93 = &H135D28
    Dim Lv_cleric_94 = &H136068
    Dim Lv_cleric_95 = &H1363A8
    Dim Lv_cleric_96 = &H1366E8
    Dim Lv_cleric_97 = &H136A28
    Dim Lv_cleric_98 = &H136D68
    Dim Lv_cleric_99 = &H1370A8
    Dim Lv_cleric_100 = &H1373E8
    Dim Lv_thief_1 = &HFD064
    Dim Lv_thief_2 = &HFD3A4
    Dim Lv_thief_3 = &HFD6E4
    Dim Lv_thief_4 = &HFDA24
    Dim Lv_thief_5 = &HFDD64
    Dim Lv_thief_6 = &HFE0A4
    Dim Lv_thief_7 = &HFE3E4
    Dim Lv_thief_8 = &HFE724
    Dim Lv_thief_9 = &HFEA64
    Dim Lv_thief_10 = &HFEDA4
    Dim Lv_thief_11 = &H1252AC
    Dim Lv_thief_12 = &H1255EC
    Dim Lv_thief_13 = &H12592C
    Dim Lv_thief_14 = &H125C6C
    Dim Lv_thief_15 = &H125FAC
    Dim Lv_thief_16 = &H1262EC
    Dim Lv_thief_17 = &H12662C
    Dim Lv_thief_18 = &H12696C
    Dim Lv_thief_19 = &H126CAC
    Dim Lv_thief_20 = &H126FEC
    Dim Lv_thief_21 = &H12732C
    Dim Lv_thief_22 = &H12766C
    Dim Lv_thief_23 = &H1279AC
    Dim Lv_thief_24 = &H127CEC
    Dim Lv_thief_25 = &H12802C
    Dim Lv_thief_26 = &H12836C
    Dim Lv_thief_27 = &H1286AC
    Dim Lv_thief_28 = &H1289EC
    Dim Lv_thief_29 = &H128D2C
    Dim Lv_thief_30 = &H12906C
    Dim Lv_thief_31 = &H1293AC
    Dim Lv_thief_32 = &H1296EC
    Dim Lv_thief_33 = &H129A2C
    Dim Lv_thief_34 = &H129D6C
    Dim Lv_thief_35 = &H12A0AC
    Dim Lv_thief_36 = &H12A3EC
    Dim Lv_thief_37 = &H12A72C
    Dim Lv_thief_38 = &H12AA6C
    Dim Lv_thief_39 = &H12ADAC
    Dim Lv_thief_40 = &H12B0EC
    Dim Lv_thief_41 = &H12B42C
    Dim Lv_thief_42 = &H12B76C
    Dim Lv_thief_43 = &H12BAAC
    Dim Lv_thief_44 = &H12BDEC
    Dim Lv_thief_45 = &H12C12C
    Dim Lv_thief_46 = &H12C46C
    Dim Lv_thief_47 = &H12C7AC
    Dim Lv_thief_48 = &H12CAEC
    Dim Lv_thief_49 = &H12CE2C
    Dim Lv_thief_50 = &H12D16C
    Dim Lv_thief_51 = &H12D4AC
    Dim Lv_thief_52 = &H12D7EC
    Dim Lv_thief_53 = &H12DB2C
    Dim Lv_thief_54 = &H12DE6C
    Dim Lv_thief_55 = &H12E1AC
    Dim Lv_thief_56 = &H12E4EC
    Dim Lv_thief_57 = &H12E82C
    Dim Lv_thief_58 = &H12EB6C
    Dim Lv_thief_59 = &H12EEAC
    Dim Lv_thief_60 = &H12F1EC
    Dim Lv_thief_61 = &H12F52C
    Dim Lv_thief_62 = &H12F86C
    Dim Lv_thief_63 = &H12FBAC
    Dim Lv_thief_64 = &H12FEEC
    Dim Lv_thief_65 = &H13022C
    Dim Lv_thief_66 = &H13056C
    Dim Lv_thief_67 = &H1308AC
    Dim Lv_thief_68 = &H130BEC
    Dim Lv_thief_69 = &H130F2C
    Dim Lv_thief_70 = &H13126C
    Dim Lv_thief_71 = &H1315AC
    Dim Lv_thief_72 = &H1318EC
    Dim Lv_thief_73 = &H131C2C
    Dim Lv_thief_74 = &H131F6C
    Dim Lv_thief_75 = &H1322AC
    Dim Lv_thief_76 = &H1325EC
    Dim Lv_thief_77 = &H13292C
    Dim Lv_thief_78 = &H132C6C
    Dim Lv_thief_79 = &H132FAC
    Dim Lv_thief_80 = &H1332EC
    Dim Lv_thief_81 = &H13362C
    Dim Lv_thief_82 = &H13396C
    Dim Lv_thief_83 = &H133CAC
    Dim Lv_thief_84 = &H133FEC
    Dim Lv_thief_85 = &H13432C
    Dim Lv_thief_86 = &H13466C
    Dim Lv_thief_87 = &H1349AC
    Dim Lv_thief_88 = &H134CEC
    Dim Lv_thief_89 = &H13502C
    Dim Lv_thief_90 = &H13536C
    Dim Lv_thief_91 = &H1356AC
    Dim Lv_thief_92 = &H1359EC
    Dim Lv_thief_93 = &H135D2C
    Dim Lv_thief_94 = &H13606C
    Dim Lv_thief_95 = &H1363AC
    Dim Lv_thief_96 = &H1366EC
    Dim Lv_thief_97 = &H136A2C
    Dim Lv_thief_98 = &H136D6C
    Dim Lv_thief_99 = &H1370AC
    Dim Lv_thief_100 = &H1373EC
    Dim Lv_popstar_1 = &HFD068
    Dim Lv_popstar_2 = &HFD3A8
    Dim Lv_popstar_3 = &HFD6E8
    Dim Lv_popstar_4 = &HFDA28
    Dim Lv_popstar_5 = &HFDD68
    Dim Lv_popstar_6 = &HFE0A8
    Dim Lv_popstar_7 = &HFE3E8
    Dim Lv_popstar_8 = &HFE728
    Dim Lv_popstar_9 = &HFEA68
    Dim Lv_popstar_10 = &HFEDA8
    Dim Lv_popstar_11 = &H1252B0
    Dim Lv_popstar_12 = &H1255F0
    Dim Lv_popstar_13 = &H125930
    Dim Lv_popstar_14 = &H125C70
    Dim Lv_popstar_15 = &H125FB0
    Dim Lv_popstar_16 = &H1262F0
    Dim Lv_popstar_17 = &H126630
    Dim Lv_popstar_18 = &H126970
    Dim Lv_popstar_19 = &H126CB0
    Dim Lv_popstar_20 = &H126FF0
    Dim Lv_popstar_21 = &H127330
    Dim Lv_popstar_22 = &H127670
    Dim Lv_popstar_23 = &H1279B0
    Dim Lv_popstar_24 = &H127CF0
    Dim Lv_popstar_25 = &H128030
    Dim Lv_popstar_26 = &H128370
    Dim Lv_popstar_27 = &H1286B0
    Dim Lv_popstar_28 = &H1289F0
    Dim Lv_popstar_29 = &H128D30
    Dim Lv_popstar_30 = &H129070
    Dim Lv_popstar_31 = &H1293B0
    Dim Lv_popstar_32 = &H1296F0
    Dim Lv_popstar_33 = &H129A30
    Dim Lv_popstar_34 = &H129D70
    Dim Lv_popstar_35 = &H12A0B0
    Dim Lv_popstar_36 = &H12A3F0
    Dim Lv_popstar_37 = &H12A730
    Dim Lv_popstar_38 = &H12AA70
    Dim Lv_popstar_39 = &H12ADB0
    Dim Lv_popstar_40 = &H12B0F0
    Dim Lv_popstar_41 = &H12B430
    Dim Lv_popstar_42 = &H12B770
    Dim Lv_popstar_43 = &H12BAB0
    Dim Lv_popstar_44 = &H12BDF0
    Dim Lv_popstar_45 = &H12C130
    Dim Lv_popstar_46 = &H12C470
    Dim Lv_popstar_47 = &H12C7B0
    Dim Lv_popstar_48 = &H12CAF0
    Dim Lv_popstar_49 = &H12CE30
    Dim Lv_popstar_50 = &H12D170
    Dim Lv_popstar_51 = &H12D4B0
    Dim Lv_popstar_52 = &H12D7F0
    Dim Lv_popstar_53 = &H12DB30
    Dim Lv_popstar_54 = &H12DE70
    Dim Lv_popstar_55 = &H12E1B0
    Dim Lv_popstar_56 = &H12E4F0
    Dim Lv_popstar_57 = &H12E830
    Dim Lv_popstar_58 = &H12EB70
    Dim Lv_popstar_59 = &H12EEB0
    Dim Lv_popstar_60 = &H12F1F0
    Dim Lv_popstar_61 = &H12F530
    Dim Lv_popstar_62 = &H12F870
    Dim Lv_popstar_63 = &H12FBB0
    Dim Lv_popstar_64 = &H12FEF0
    Dim Lv_popstar_65 = &H130230
    Dim Lv_popstar_66 = &H130570
    Dim Lv_popstar_67 = &H1308B0
    Dim Lv_popstar_68 = &H130BF0
    Dim Lv_popstar_69 = &H130F30
    Dim Lv_popstar_70 = &H131270
    Dim Lv_popstar_71 = &H1315B0
    Dim Lv_popstar_72 = &H1318F0
    Dim Lv_popstar_73 = &H131C30
    Dim Lv_popstar_74 = &H131F70
    Dim Lv_popstar_75 = &H1322B0
    Dim Lv_popstar_76 = &H1325F0
    Dim Lv_popstar_77 = &H132930
    Dim Lv_popstar_78 = &H132C70
    Dim Lv_popstar_79 = &H132FB0
    Dim Lv_popstar_80 = &H1332F0
    Dim Lv_popstar_81 = &H133630
    Dim Lv_popstar_82 = &H133970
    Dim Lv_popstar_83 = &H133CB0
    Dim Lv_popstar_84 = &H133FF0
    Dim Lv_popstar_85 = &H134330
    Dim Lv_popstar_86 = &H134670
    Dim Lv_popstar_87 = &H1349B0
    Dim Lv_popstar_88 = &H134CF0
    Dim Lv_popstar_89 = &H135030
    Dim Lv_popstar_90 = &H135370
    Dim Lv_popstar_91 = &H1356B0
    Dim Lv_popstar_92 = &H1359F0
    Dim Lv_popstar_93 = &H135D30
    Dim Lv_popstar_94 = &H136070
    Dim Lv_popstar_95 = &H1363B0
    Dim Lv_popstar_96 = &H1366F0
    Dim Lv_popstar_97 = &H136A30
    Dim Lv_popstar_98 = &H136D70
    Dim Lv_popstar_99 = &H1370B0
    Dim Lv_popstar_100 = &H1373F0
    Dim Lv_vampire_1 = &HFD06C
    Dim Lv_vampire_2 = &HFD3AC
    Dim Lv_vampire_3 = &HFD6EC
    Dim Lv_vampire_4 = &HFDA2C
    Dim Lv_vampire_5 = &HFDD6C
    Dim Lv_vampire_6 = &HFE0AC
    Dim Lv_vampire_7 = &HFE3EC
    Dim Lv_vampire_8 = &HFE72C
    Dim Lv_vampire_9 = &HFEA6C
    Dim Lv_vampire_10 = &HFEDAC
    Dim Lv_vampire_11 = &H1252B4
    Dim Lv_vampire_12 = &H1255F4
    Dim Lv_vampire_13 = &H125934
    Dim Lv_vampire_14 = &H125C74
    Dim Lv_vampire_15 = &H125FB4
    Dim Lv_vampire_16 = &H1262F4
    Dim Lv_vampire_17 = &H126634
    Dim Lv_vampire_18 = &H126974
    Dim Lv_vampire_19 = &H126CB4
    Dim Lv_vampire_20 = &H126FF4
    Dim Lv_vampire_21 = &H127334
    Dim Lv_vampire_22 = &H127674
    Dim Lv_vampire_23 = &H1279B4
    Dim Lv_vampire_24 = &H127CF4
    Dim Lv_vampire_25 = &H128034
    Dim Lv_vampire_26 = &H128374
    Dim Lv_vampire_27 = &H1286B4
    Dim Lv_vampire_28 = &H1289F4
    Dim Lv_vampire_29 = &H128D34
    Dim Lv_vampire_30 = &H129074
    Dim Lv_vampire_31 = &H1293B4
    Dim Lv_vampire_32 = &H1296F4
    Dim Lv_vampire_33 = &H129A34
    Dim Lv_vampire_34 = &H129D74
    Dim Lv_vampire_35 = &H12A0B4
    Dim Lv_vampire_36 = &H12A3F4
    Dim Lv_vampire_37 = &H12A734
    Dim Lv_vampire_38 = &H12AA74
    Dim Lv_vampire_39 = &H12ADB4
    Dim Lv_vampire_40 = &H12B0F4
    Dim Lv_vampire_41 = &H12B434
    Dim Lv_vampire_42 = &H12B774
    Dim Lv_vampire_43 = &H12BAB4
    Dim Lv_vampire_44 = &H12BDF4
    Dim Lv_vampire_45 = &H12C134
    Dim Lv_vampire_46 = &H12C474
    Dim Lv_vampire_47 = &H12C7B4
    Dim Lv_vampire_48 = &H12CAF4
    Dim Lv_vampire_49 = &H12CE34
    Dim Lv_vampire_50 = &H12D174
    Dim Lv_vampire_51 = &H12D4B4
    Dim Lv_vampire_52 = &H12D7F4
    Dim Lv_vampire_53 = &H12DB34
    Dim Lv_vampire_54 = &H12DE74
    Dim Lv_vampire_55 = &H12E1B4
    Dim Lv_vampire_56 = &H12E4F4
    Dim Lv_vampire_57 = &H12E834
    Dim Lv_vampire_58 = &H12EB74
    Dim Lv_vampire_59 = &H12EEB4
    Dim Lv_vampire_60 = &H12F1F4
    Dim Lv_vampire_61 = &H12F534
    Dim Lv_vampire_62 = &H12F874
    Dim Lv_vampire_63 = &H12FBB4
    Dim Lv_vampire_64 = &H12FEF4
    Dim Lv_vampire_65 = &H130234
    Dim Lv_vampire_66 = &H130574
    Dim Lv_vampire_67 = &H1308B4
    Dim Lv_vampire_68 = &H130BF4
    Dim Lv_vampire_69 = &H130F34
    Dim Lv_vampire_70 = &H131274
    Dim Lv_vampire_71 = &H1315B4
    Dim Lv_vampire_72 = &H1318F4
    Dim Lv_vampire_73 = &H131C34
    Dim Lv_vampire_74 = &H131F74
    Dim Lv_vampire_75 = &H1322B4
    Dim Lv_vampire_76 = &H1325F4
    Dim Lv_vampire_77 = &H132934
    Dim Lv_vampire_78 = &H132C74
    Dim Lv_vampire_79 = &H132FB4
    Dim Lv_vampire_80 = &H1332F4
    Dim Lv_vampire_81 = &H133634
    Dim Lv_vampire_82 = &H133974
    Dim Lv_vampire_83 = &H133CB4
    Dim Lv_vampire_84 = &H133FF4
    Dim Lv_vampire_85 = &H134334
    Dim Lv_vampire_86 = &H134674
    Dim Lv_vampire_87 = &H1349B4
    Dim Lv_vampire_88 = &H134CF4
    Dim Lv_vampire_89 = &H135034
    Dim Lv_vampire_90 = &H135374
    Dim Lv_vampire_91 = &H1356B4
    Dim Lv_vampire_92 = &H1359F4
    Dim Lv_vampire_93 = &H135D34
    Dim Lv_vampire_94 = &H136074
    Dim Lv_vampire_95 = &H1363B4
    Dim Lv_vampire_96 = &H1366F4
    Dim Lv_vampire_97 = &H136A34
    Dim Lv_vampire_98 = &H136D74
    Dim Lv_vampire_99 = &H1370B4
    Dim Lv_vampire_100 = &H1373F4
    Dim Lv_chef_1 = &HFD070
    Dim Lv_chef_2 = &HFD3B0
    Dim Lv_chef_3 = &HFD6F0
    Dim Lv_chef_4 = &HFDA30
    Dim Lv_chef_5 = &HFDD70
    Dim Lv_chef_6 = &HFE0B0
    Dim Lv_chef_7 = &HFE3F0
    Dim Lv_chef_8 = &HFE730
    Dim Lv_chef_9 = &HFEA70
    Dim Lv_chef_10 = &HFEDB0
    Dim Lv_chef_11 = &H1252B8
    Dim Lv_chef_12 = &H1255F8
    Dim Lv_chef_13 = &H125938
    Dim Lv_chef_14 = &H125C78
    Dim Lv_chef_15 = &H125FB8
    Dim Lv_chef_16 = &H1262F8
    Dim Lv_chef_17 = &H126638
    Dim Lv_chef_18 = &H126978
    Dim Lv_chef_19 = &H126CB8
    Dim Lv_chef_20 = &H126FF8
    Dim Lv_chef_21 = &H127338
    Dim Lv_chef_22 = &H127678
    Dim Lv_chef_23 = &H1279B8
    Dim Lv_chef_24 = &H127CF8
    Dim Lv_chef_25 = &H128038
    Dim Lv_chef_26 = &H128378
    Dim Lv_chef_27 = &H1286B8
    Dim Lv_chef_28 = &H1289F8
    Dim Lv_chef_29 = &H128D38
    Dim Lv_chef_30 = &H129078
    Dim Lv_chef_31 = &H1293B8
    Dim Lv_chef_32 = &H1296F8
    Dim Lv_chef_33 = &H129A38
    Dim Lv_chef_34 = &H129D78
    Dim Lv_chef_35 = &H12A0B8
    Dim Lv_chef_36 = &H12A3F8
    Dim Lv_chef_37 = &H12A738
    Dim Lv_chef_38 = &H12AA78
    Dim Lv_chef_39 = &H12ADB8
    Dim Lv_chef_40 = &H12B0F8
    Dim Lv_chef_41 = &H12B438
    Dim Lv_chef_42 = &H12B778
    Dim Lv_chef_43 = &H12BAB8
    Dim Lv_chef_44 = &H12BDF8
    Dim Lv_chef_45 = &H12C138
    Dim Lv_chef_46 = &H12C478
    Dim Lv_chef_47 = &H12C7B8
    Dim Lv_chef_48 = &H12CAF8
    Dim Lv_chef_49 = &H12CE38
    Dim Lv_chef_50 = &H12D178
    Dim Lv_chef_51 = &H12D4B8
    Dim Lv_chef_52 = &H12D7F8
    Dim Lv_chef_53 = &H12DB38
    Dim Lv_chef_54 = &H12DE78
    Dim Lv_chef_55 = &H12E1B8
    Dim Lv_chef_56 = &H12E4F8
    Dim Lv_chef_57 = &H12E838
    Dim Lv_chef_58 = &H12EB78
    Dim Lv_chef_59 = &H12EEB8
    Dim Lv_chef_60 = &H12F1F8
    Dim Lv_chef_61 = &H12F538
    Dim Lv_chef_62 = &H12F878
    Dim Lv_chef_63 = &H12FBB8
    Dim Lv_chef_64 = &H12FEF8
    Dim Lv_chef_65 = &H130238
    Dim Lv_chef_66 = &H130578
    Dim Lv_chef_67 = &H1308B8
    Dim Lv_chef_68 = &H130BF8
    Dim Lv_chef_69 = &H130F38
    Dim Lv_chef_70 = &H131278
    Dim Lv_chef_71 = &H1315B8
    Dim Lv_chef_72 = &H1318F8
    Dim Lv_chef_73 = &H131C38
    Dim Lv_chef_74 = &H131F78
    Dim Lv_chef_75 = &H1322B8
    Dim Lv_chef_76 = &H1325F8
    Dim Lv_chef_77 = &H132938
    Dim Lv_chef_78 = &H132C78
    Dim Lv_chef_79 = &H132FB8
    Dim Lv_chef_80 = &H1332F8
    Dim Lv_chef_81 = &H133638
    Dim Lv_chef_82 = &H133978
    Dim Lv_chef_83 = &H133CB8
    Dim Lv_chef_84 = &H133FF8
    Dim Lv_chef_85 = &H134338
    Dim Lv_chef_86 = &H134678
    Dim Lv_chef_87 = &H1349B8
    Dim Lv_chef_88 = &H134CF8
    Dim Lv_chef_89 = &H135038
    Dim Lv_chef_90 = &H135378
    Dim Lv_chef_91 = &H1356B8
    Dim Lv_chef_92 = &H1359F8
    Dim Lv_chef_93 = &H135D38
    Dim Lv_chef_94 = &H136078
    Dim Lv_chef_95 = &H1363B8
    Dim Lv_chef_96 = &H1366F8
    Dim Lv_chef_97 = &H136A38
    Dim Lv_chef_98 = &H136D78
    Dim Lv_chef_99 = &H1370B8
    Dim Lv_chef_100 = &H1373F8
    Dim Lv_tank_1 = &HFD074
    Dim Lv_tank_2 = &HFD3B4
    Dim Lv_tank_3 = &HFD6F4
    Dim Lv_tank_4 = &HFDA34
    Dim Lv_tank_5 = &HFDD74
    Dim Lv_tank_6 = &HFE0B4
    Dim Lv_tank_7 = &HFE3F4
    Dim Lv_tank_8 = &HFE734
    Dim Lv_tank_9 = &HFEA74
    Dim Lv_tank_10 = &HFEDB4
    Dim Lv_tank_11 = &H1252BC
    Dim Lv_tank_12 = &H1255FC
    Dim Lv_tank_13 = &H12593C
    Dim Lv_tank_14 = &H125C7C
    Dim Lv_tank_15 = &H125FBC
    Dim Lv_tank_16 = &H1262FC
    Dim Lv_tank_17 = &H12663C
    Dim Lv_tank_18 = &H12697C
    Dim Lv_tank_19 = &H126CBC
    Dim Lv_tank_20 = &H126FFC
    Dim Lv_tank_21 = &H12733C
    Dim Lv_tank_22 = &H12767C
    Dim Lv_tank_23 = &H1279BC
    Dim Lv_tank_24 = &H127CFC
    Dim Lv_tank_25 = &H12803C
    Dim Lv_tank_26 = &H12837C
    Dim Lv_tank_27 = &H1286BC
    Dim Lv_tank_28 = &H1289FC
    Dim Lv_tank_29 = &H128D3C
    Dim Lv_tank_30 = &H12907C
    Dim Lv_tank_31 = &H1293BC
    Dim Lv_tank_32 = &H1296FC
    Dim Lv_tank_33 = &H129A3C
    Dim Lv_tank_34 = &H129D7C
    Dim Lv_tank_35 = &H12A0BC
    Dim Lv_tank_36 = &H12A3FC
    Dim Lv_tank_37 = &H12A73C
    Dim Lv_tank_38 = &H12AA7C
    Dim Lv_tank_39 = &H12ADBC
    Dim Lv_tank_40 = &H12B0FC
    Dim Lv_tank_41 = &H12B43C
    Dim Lv_tank_42 = &H12B77C
    Dim Lv_tank_43 = &H12BABC
    Dim Lv_tank_44 = &H12BDFC
    Dim Lv_tank_45 = &H12C13C
    Dim Lv_tank_46 = &H12C47C
    Dim Lv_tank_47 = &H12C7BC
    Dim Lv_tank_48 = &H12CAFC
    Dim Lv_tank_49 = &H12CE3C
    Dim Lv_tank_50 = &H12D17C
    Dim Lv_tank_51 = &H12D4BC
    Dim Lv_tank_52 = &H12D7FC
    Dim Lv_tank_53 = &H12DB3C
    Dim Lv_tank_54 = &H12DE7C
    Dim Lv_tank_55 = &H12E1BC
    Dim Lv_tank_56 = &H12E4FC
    Dim Lv_tank_57 = &H12E83C
    Dim Lv_tank_58 = &H12EB7C
    Dim Lv_tank_59 = &H12EEBC
    Dim Lv_tank_60 = &H12F1FC
    Dim Lv_tank_61 = &H12F53C
    Dim Lv_tank_62 = &H12F87C
    Dim Lv_tank_63 = &H12FBBC
    Dim Lv_tank_64 = &H12FEFC
    Dim Lv_tank_65 = &H13023C
    Dim Lv_tank_66 = &H13057C
    Dim Lv_tank_67 = &H1308BC
    Dim Lv_tank_68 = &H130BFC
    Dim Lv_tank_69 = &H130F3C
    Dim Lv_tank_70 = &H13127C
    Dim Lv_tank_71 = &H1315BC
    Dim Lv_tank_72 = &H1318FC
    Dim Lv_tank_73 = &H131C3C
    Dim Lv_tank_74 = &H131F7C
    Dim Lv_tank_75 = &H1322BC
    Dim Lv_tank_76 = &H1325FC
    Dim Lv_tank_77 = &H13293C
    Dim Lv_tank_78 = &H132C7C
    Dim Lv_tank_79 = &H132FBC
    Dim Lv_tank_80 = &H1332FC
    Dim Lv_tank_81 = &H13363C
    Dim Lv_tank_82 = &H13397C
    Dim Lv_tank_83 = &H133CBC
    Dim Lv_tank_84 = &H133FFC
    Dim Lv_tank_85 = &H13433C
    Dim Lv_tank_86 = &H13467C
    Dim Lv_tank_87 = &H1349BC
    Dim Lv_tank_88 = &H134CFC
    Dim Lv_tank_89 = &H13503C
    Dim Lv_tank_90 = &H13537C
    Dim Lv_tank_91 = &H1356BC
    Dim Lv_tank_92 = &H1359FC
    Dim Lv_tank_93 = &H135D3C
    Dim Lv_tank_94 = &H13607C
    Dim Lv_tank_95 = &H1363BC
    Dim Lv_tank_96 = &H1366FC
    Dim Lv_tank_97 = &H136A3C
    Dim Lv_tank_98 = &H136D7C
    Dim Lv_tank_99 = &H1370BC
    Dim Lv_tank_100 = &H1373FC
    Dim Lv_imp_1 = &HFD078
    Dim Lv_imp_2 = &HFD3B8
    Dim Lv_imp_3 = &HFD6F8
    Dim Lv_imp_4 = &HFDA38
    Dim Lv_imp_5 = &HFDD78
    Dim Lv_imp_6 = &HFE0B8
    Dim Lv_imp_7 = &HFE3F8
    Dim Lv_imp_8 = &HFE738
    Dim Lv_imp_9 = &HFEA78
    Dim Lv_imp_10 = &HFEDB8
    Dim Lv_imp_11 = &H1252C0
    Dim Lv_imp_12 = &H125600
    Dim Lv_imp_13 = &H125940
    Dim Lv_imp_14 = &H125C80
    Dim Lv_imp_15 = &H125FC0
    Dim Lv_imp_16 = &H126300
    Dim Lv_imp_17 = &H126640
    Dim Lv_imp_18 = &H126980
    Dim Lv_imp_19 = &H126CC0
    Dim Lv_imp_20 = &H127000
    Dim Lv_imp_21 = &H127340
    Dim Lv_imp_22 = &H127680
    Dim Lv_imp_23 = &H1279C0
    Dim Lv_imp_24 = &H127D00
    Dim Lv_imp_25 = &H128040
    Dim Lv_imp_26 = &H128380
    Dim Lv_imp_27 = &H1286C0
    Dim Lv_imp_28 = &H128A00
    Dim Lv_imp_29 = &H128D40
    Dim Lv_imp_30 = &H129080
    Dim Lv_imp_31 = &H1293C0
    Dim Lv_imp_32 = &H129700
    Dim Lv_imp_33 = &H129A40
    Dim Lv_imp_34 = &H129D80
    Dim Lv_imp_35 = &H12A0C0
    Dim Lv_imp_36 = &H12A400
    Dim Lv_imp_37 = &H12A740
    Dim Lv_imp_38 = &H12AA80
    Dim Lv_imp_39 = &H12ADC0
    Dim Lv_imp_40 = &H12B100
    Dim Lv_imp_41 = &H12B440
    Dim Lv_imp_42 = &H12B780
    Dim Lv_imp_43 = &H12BAC0
    Dim Lv_imp_44 = &H12BE00
    Dim Lv_imp_45 = &H12C140
    Dim Lv_imp_46 = &H12C480
    Dim Lv_imp_47 = &H12C7C0
    Dim Lv_imp_48 = &H12CB00
    Dim Lv_imp_49 = &H12CE40
    Dim Lv_imp_50 = &H12D180
    Dim Lv_imp_51 = &H12D4C0
    Dim Lv_imp_52 = &H12D800
    Dim Lv_imp_53 = &H12DB40
    Dim Lv_imp_54 = &H12DE80
    Dim Lv_imp_55 = &H12E1C0
    Dim Lv_imp_56 = &H12E500
    Dim Lv_imp_57 = &H12E840
    Dim Lv_imp_58 = &H12EB80
    Dim Lv_imp_59 = &H12EEC0
    Dim Lv_imp_60 = &H12F200
    Dim Lv_imp_61 = &H12F540
    Dim Lv_imp_62 = &H12F880
    Dim Lv_imp_63 = &H12FBC0
    Dim Lv_imp_64 = &H12FF00
    Dim Lv_imp_65 = &H130240
    Dim Lv_imp_66 = &H130580
    Dim Lv_imp_67 = &H1308C0
    Dim Lv_imp_68 = &H130C00
    Dim Lv_imp_69 = &H130F40
    Dim Lv_imp_70 = &H131280
    Dim Lv_imp_71 = &H1315C0
    Dim Lv_imp_72 = &H131900
    Dim Lv_imp_73 = &H131C40
    Dim Lv_imp_74 = &H131F80
    Dim Lv_imp_75 = &H1322C0
    Dim Lv_imp_76 = &H132600
    Dim Lv_imp_77 = &H132940
    Dim Lv_imp_78 = &H132C80
    Dim Lv_imp_79 = &H132FC0
    Dim Lv_imp_80 = &H133300
    Dim Lv_imp_81 = &H133640
    Dim Lv_imp_82 = &H133980
    Dim Lv_imp_83 = &H133CC0
    Dim Lv_imp_84 = &H134000
    Dim Lv_imp_85 = &H134340
    Dim Lv_imp_86 = &H134680
    Dim Lv_imp_87 = &H1349C0
    Dim Lv_imp_88 = &H134D00
    Dim Lv_imp_89 = &H135040
    Dim Lv_imp_90 = &H135380
    Dim Lv_imp_91 = &H1356C0
    Dim Lv_imp_92 = &H135A00
    Dim Lv_imp_93 = &H135D40
    Dim Lv_imp_94 = &H136080
    Dim Lv_imp_95 = &H1363C0
    Dim Lv_imp_96 = &H136700
    Dim Lv_imp_97 = &H136A40
    Dim Lv_imp_98 = &H136D80
    Dim Lv_imp_99 = &H1370C0
    Dim Lv_imp_100 = &H137400
    Dim Lv_princess_1 = &HFD07C
    Dim Lv_princess_2 = &HFD3BC
    Dim Lv_princess_3 = &HFD6FC
    Dim Lv_princess_4 = &HFDA3C
    Dim Lv_princess_5 = &HFDD7C
    Dim Lv_princess_6 = &HFE0BC
    Dim Lv_princess_7 = &HFE3FC
    Dim Lv_princess_8 = &HFE73C
    Dim Lv_princess_9 = &HFEA7C
    Dim Lv_princess_10 = &HFEDBC
    Dim Lv_princess_11 = &H1252C4
    Dim Lv_princess_12 = &H125604
    Dim Lv_princess_13 = &H125944
    Dim Lv_princess_14 = &H125C84
    Dim Lv_princess_15 = &H125FC4
    Dim Lv_princess_16 = &H126304
    Dim Lv_princess_17 = &H126644
    Dim Lv_princess_18 = &H126984
    Dim Lv_princess_19 = &H126CC4
    Dim Lv_princess_20 = &H127004
    Dim Lv_princess_21 = &H127344
    Dim Lv_princess_22 = &H127684
    Dim Lv_princess_23 = &H1279C4
    Dim Lv_princess_24 = &H127D04
    Dim Lv_princess_25 = &H128044
    Dim Lv_princess_26 = &H128384
    Dim Lv_princess_27 = &H1286C4
    Dim Lv_princess_28 = &H128A04
    Dim Lv_princess_29 = &H128D44
    Dim Lv_princess_30 = &H129084
    Dim Lv_princess_31 = &H1293C4
    Dim Lv_princess_32 = &H129704
    Dim Lv_princess_33 = &H129A44
    Dim Lv_princess_34 = &H129D84
    Dim Lv_princess_35 = &H12A0C4
    Dim Lv_princess_36 = &H12A404
    Dim Lv_princess_37 = &H12A744
    Dim Lv_princess_38 = &H12AA84
    Dim Lv_princess_39 = &H12ADC4
    Dim Lv_princess_40 = &H12B104
    Dim Lv_princess_41 = &H12B444
    Dim Lv_princess_42 = &H12B784
    Dim Lv_princess_43 = &H12BAC4
    Dim Lv_princess_44 = &H12BE04
    Dim Lv_princess_45 = &H12C144
    Dim Lv_princess_46 = &H12C484
    Dim Lv_princess_47 = &H12C7C4
    Dim Lv_princess_48 = &H12CB04
    Dim Lv_princess_49 = &H12CE44
    Dim Lv_princess_50 = &H12D184
    Dim Lv_princess_51 = &H12D4C4
    Dim Lv_princess_52 = &H12D804
    Dim Lv_princess_53 = &H12DB44
    Dim Lv_princess_54 = &H12DE84
    Dim Lv_princess_55 = &H12E1C4
    Dim Lv_princess_56 = &H12E504
    Dim Lv_princess_57 = &H12E844
    Dim Lv_princess_58 = &H12EB84
    Dim Lv_princess_59 = &H12EEC4
    Dim Lv_princess_60 = &H12F204
    Dim Lv_princess_61 = &H12F544
    Dim Lv_princess_62 = &H12F884
    Dim Lv_princess_63 = &H12FBC4
    Dim Lv_princess_64 = &H12FF04
    Dim Lv_princess_65 = &H130244
    Dim Lv_princess_66 = &H130584
    Dim Lv_princess_67 = &H1308C4
    Dim Lv_princess_68 = &H130C04
    Dim Lv_princess_69 = &H130F44
    Dim Lv_princess_70 = &H131284
    Dim Lv_princess_71 = &H1315C4
    Dim Lv_princess_72 = &H131904
    Dim Lv_princess_73 = &H131C44
    Dim Lv_princess_74 = &H131F84
    Dim Lv_princess_75 = &H1322C4
    Dim Lv_princess_76 = &H132604
    Dim Lv_princess_77 = &H132944
    Dim Lv_princess_78 = &H132C84
    Dim Lv_princess_79 = &H132FC4
    Dim Lv_princess_80 = &H133304
    Dim Lv_princess_81 = &H133644
    Dim Lv_princess_82 = &H133984
    Dim Lv_princess_83 = &H133CC4
    Dim Lv_princess_84 = &H134004
    Dim Lv_princess_85 = &H134344
    Dim Lv_princess_86 = &H134684
    Dim Lv_princess_87 = &H1349C4
    Dim Lv_princess_88 = &H134D04
    Dim Lv_princess_89 = &H135044
    Dim Lv_princess_90 = &H135384
    Dim Lv_princess_91 = &H1356C4
    Dim Lv_princess_92 = &H135A04
    Dim Lv_princess_93 = &H135D44
    Dim Lv_princess_94 = &H136084
    Dim Lv_princess_95 = &H1363C4
    Dim Lv_princess_96 = &H136704
    Dim Lv_princess_97 = &H136A44
    Dim Lv_princess_98 = &H136D84
    Dim Lv_princess_99 = &H1370C4
    Dim Lv_princess_100 = &H137404
    Dim Lv_flower_1 = &HFD080
    Dim Lv_flower_2 = &HFD3C0
    Dim Lv_flower_3 = &HFD700
    Dim Lv_flower_4 = &HFDA40
    Dim Lv_flower_5 = &HFDD80
    Dim Lv_flower_6 = &HFE0C0
    Dim Lv_flower_7 = &HFE400
    Dim Lv_flower_8 = &HFE740
    Dim Lv_flower_9 = &HFEA80
    Dim Lv_flower_10 = &HFEDC0
    Dim Lv_flower_11 = &H1252C8
    Dim Lv_flower_12 = &H125608
    Dim Lv_flower_13 = &H125948
    Dim Lv_flower_14 = &H125C88
    Dim Lv_flower_15 = &H125FC8
    Dim Lv_flower_16 = &H126308
    Dim Lv_flower_17 = &H126648
    Dim Lv_flower_18 = &H126988
    Dim Lv_flower_19 = &H126CC8
    Dim Lv_flower_20 = &H127008
    Dim Lv_flower_21 = &H127348
    Dim Lv_flower_22 = &H127688
    Dim Lv_flower_23 = &H1279C8
    Dim Lv_flower_24 = &H127D08
    Dim Lv_flower_25 = &H128048
    Dim Lv_flower_26 = &H128388
    Dim Lv_flower_27 = &H1286C8
    Dim Lv_flower_28 = &H128A08
    Dim Lv_flower_29 = &H128D48
    Dim Lv_flower_30 = &H129088
    Dim Lv_flower_31 = &H1293C8
    Dim Lv_flower_32 = &H129708
    Dim Lv_flower_33 = &H129A48
    Dim Lv_flower_34 = &H129D88
    Dim Lv_flower_35 = &H12A0C8
    Dim Lv_flower_36 = &H12A408
    Dim Lv_flower_37 = &H12A748
    Dim Lv_flower_38 = &H12AA88
    Dim Lv_flower_39 = &H12ADC8
    Dim Lv_flower_40 = &H12B108
    Dim Lv_flower_41 = &H12B448
    Dim Lv_flower_42 = &H12B788
    Dim Lv_flower_43 = &H12BAC8
    Dim Lv_flower_44 = &H12BE08
    Dim Lv_flower_45 = &H12C148
    Dim Lv_flower_46 = &H12C488
    Dim Lv_flower_47 = &H12C7C8
    Dim Lv_flower_48 = &H12CB08
    Dim Lv_flower_49 = &H12CE48
    Dim Lv_flower_50 = &H12D188
    Dim Lv_flower_51 = &H12D4C8
    Dim Lv_flower_52 = &H12D808
    Dim Lv_flower_53 = &H12DB48
    Dim Lv_flower_54 = &H12DE88
    Dim Lv_flower_55 = &H12E1C8
    Dim Lv_flower_56 = &H12E508
    Dim Lv_flower_57 = &H12E848
    Dim Lv_flower_58 = &H12EB88
    Dim Lv_flower_59 = &H12EEC8
    Dim Lv_flower_60 = &H12F208
    Dim Lv_flower_61 = &H12F548
    Dim Lv_flower_62 = &H12F888
    Dim Lv_flower_63 = &H12FBC8
    Dim Lv_flower_64 = &H12FF08
    Dim Lv_flower_65 = &H130248
    Dim Lv_flower_66 = &H130588
    Dim Lv_flower_67 = &H1308C8
    Dim Lv_flower_68 = &H130C08
    Dim Lv_flower_69 = &H130F48
    Dim Lv_flower_70 = &H131288
    Dim Lv_flower_71 = &H1315C8
    Dim Lv_flower_72 = &H131908
    Dim Lv_flower_73 = &H131C48
    Dim Lv_flower_74 = &H131F88
    Dim Lv_flower_75 = &H1322C8
    Dim Lv_flower_76 = &H132608
    Dim Lv_flower_77 = &H132948
    Dim Lv_flower_78 = &H132C88
    Dim Lv_flower_79 = &H132FC8
    Dim Lv_flower_80 = &H133308
    Dim Lv_flower_81 = &H133648
    Dim Lv_flower_82 = &H133988
    Dim Lv_flower_83 = &H133CC8
    Dim Lv_flower_84 = &H134008
    Dim Lv_flower_85 = &H134348
    Dim Lv_flower_86 = &H134688
    Dim Lv_flower_87 = &H1349C8
    Dim Lv_flower_88 = &H134D08
    Dim Lv_flower_89 = &H135048
    Dim Lv_flower_90 = &H135388
    Dim Lv_flower_91 = &H1356C8
    Dim Lv_flower_92 = &H135A08
    Dim Lv_flower_93 = &H135D48
    Dim Lv_flower_94 = &H136088
    Dim Lv_flower_95 = &H1363C8
    Dim Lv_flower_96 = &H136708
    Dim Lv_flower_97 = &H136A48
    Dim Lv_flower_98 = &H136D88
    Dim Lv_flower_99 = &H1370C8
    Dim Lv_flower_100 = &H137408
    Dim Lv_scientist_1 = &HFD084
    Dim Lv_scientist_2 = &HFD3C4
    Dim Lv_scientist_3 = &HFD704
    Dim Lv_scientist_4 = &HFDA44
    Dim Lv_scientist_5 = &HFDD84
    Dim Lv_scientist_6 = &HFE0C4
    Dim Lv_scientist_7 = &HFE404
    Dim Lv_scientist_8 = &HFE744
    Dim Lv_scientist_9 = &HFEA84
    Dim Lv_scientist_10 = &HFEDC4
    Dim Lv_scientist_11 = &H1252CC
    Dim Lv_scientist_12 = &H12560C
    Dim Lv_scientist_13 = &H12594C
    Dim Lv_scientist_14 = &H125C8C
    Dim Lv_scientist_15 = &H125FCC
    Dim Lv_scientist_16 = &H12630C
    Dim Lv_scientist_17 = &H12664C
    Dim Lv_scientist_18 = &H12698C
    Dim Lv_scientist_19 = &H126CCC
    Dim Lv_scientist_20 = &H12700C
    Dim Lv_scientist_21 = &H12734C
    Dim Lv_scientist_22 = &H12768C
    Dim Lv_scientist_23 = &H1279CC
    Dim Lv_scientist_24 = &H127D0C
    Dim Lv_scientist_25 = &H12804C
    Dim Lv_scientist_26 = &H12838C
    Dim Lv_scientist_27 = &H1286CC
    Dim Lv_scientist_28 = &H128A0C
    Dim Lv_scientist_29 = &H128D4C
    Dim Lv_scientist_30 = &H12908C
    Dim Lv_scientist_31 = &H1293CC
    Dim Lv_scientist_32 = &H12970C
    Dim Lv_scientist_33 = &H129A4C
    Dim Lv_scientist_34 = &H129D8C
    Dim Lv_scientist_35 = &H12A0CC
    Dim Lv_scientist_36 = &H12A40C
    Dim Lv_scientist_37 = &H12A74C
    Dim Lv_scientist_38 = &H12AA8C
    Dim Lv_scientist_39 = &H12ADCC
    Dim Lv_scientist_40 = &H12B10C
    Dim Lv_scientist_41 = &H12B44C
    Dim Lv_scientist_42 = &H12B78C
    Dim Lv_scientist_43 = &H12BACC
    Dim Lv_scientist_44 = &H12BE0C
    Dim Lv_scientist_45 = &H12C14C
    Dim Lv_scientist_46 = &H12C48C
    Dim Lv_scientist_47 = &H12C7CC
    Dim Lv_scientist_48 = &H12CB0C
    Dim Lv_scientist_49 = &H12CE4C
    Dim Lv_scientist_50 = &H12D18C
    Dim Lv_scientist_51 = &H12D4CC
    Dim Lv_scientist_52 = &H12D80C
    Dim Lv_scientist_53 = &H12DB4C
    Dim Lv_scientist_54 = &H12DE8C
    Dim Lv_scientist_55 = &H12E1CC
    Dim Lv_scientist_56 = &H12E50C
    Dim Lv_scientist_57 = &H12E84C
    Dim Lv_scientist_58 = &H12EB8C
    Dim Lv_scientist_59 = &H12EECC
    Dim Lv_scientist_60 = &H12F20C
    Dim Lv_scientist_61 = &H12F54C
    Dim Lv_scientist_62 = &H12F88C
    Dim Lv_scientist_63 = &H12FBCC
    Dim Lv_scientist_64 = &H12FF0C
    Dim Lv_scientist_65 = &H13024C
    Dim Lv_scientist_66 = &H13058C
    Dim Lv_scientist_67 = &H1308CC
    Dim Lv_scientist_68 = &H130C0C
    Dim Lv_scientist_69 = &H130F4C
    Dim Lv_scientist_70 = &H13128C
    Dim Lv_scientist_71 = &H1315CC
    Dim Lv_scientist_72 = &H13190C
    Dim Lv_scientist_73 = &H131C4C
    Dim Lv_scientist_74 = &H131F8C
    Dim Lv_scientist_75 = &H1322CC
    Dim Lv_scientist_76 = &H13260C
    Dim Lv_scientist_77 = &H13294C
    Dim Lv_scientist_78 = &H132C8C
    Dim Lv_scientist_79 = &H132FCC
    Dim Lv_scientist_80 = &H13330C
    Dim Lv_scientist_81 = &H13364C
    Dim Lv_scientist_82 = &H13398C
    Dim Lv_scientist_83 = &H133CCC
    Dim Lv_scientist_84 = &H13400C
    Dim Lv_scientist_85 = &H13434C
    Dim Lv_scientist_86 = &H13468C
    Dim Lv_scientist_87 = &H1349CC
    Dim Lv_scientist_88 = &H134D0C
    Dim Lv_scientist_89 = &H13504C
    Dim Lv_scientist_90 = &H13538C
    Dim Lv_scientist_91 = &H1356CC
    Dim Lv_scientist_92 = &H135A0C
    Dim Lv_scientist_93 = &H135D4C
    Dim Lv_scientist_94 = &H13608C
    Dim Lv_scientist_95 = &H1363CC
    Dim Lv_scientist_96 = &H13670C
    Dim Lv_scientist_97 = &H136A4C
    Dim Lv_scientist_98 = &H136D8C
    Dim Lv_scientist_99 = &H1370CC
    Dim Lv_scientist_100 = &H13740C
    Dim Lv_cat_1 = &HFD088
    Dim Lv_cat_2 = &HFD3C8
    Dim Lv_cat_3 = &HFD708
    Dim Lv_cat_4 = &HFDA48
    Dim Lv_cat_5 = &HFDD88
    Dim Lv_cat_6 = &HFE0C8
    Dim Lv_cat_7 = &HFE408
    Dim Lv_cat_8 = &HFE748
    Dim Lv_cat_9 = &HFEA88
    Dim Lv_cat_10 = &HFEDC8
    Dim Lv_cat_11 = &H1252D0
    Dim Lv_cat_12 = &H125610
    Dim Lv_cat_13 = &H125950
    Dim Lv_cat_14 = &H125C90
    Dim Lv_cat_15 = &H125FD0
    Dim Lv_cat_16 = &H126310
    Dim Lv_cat_17 = &H126650
    Dim Lv_cat_18 = &H126990
    Dim Lv_cat_19 = &H126CD0
    Dim Lv_cat_20 = &H127010
    Dim Lv_cat_21 = &H127350
    Dim Lv_cat_22 = &H127690
    Dim Lv_cat_23 = &H1279D0
    Dim Lv_cat_24 = &H127D10
    Dim Lv_cat_25 = &H128050
    Dim Lv_cat_26 = &H128390
    Dim Lv_cat_27 = &H1286D0
    Dim Lv_cat_28 = &H128A10
    Dim Lv_cat_29 = &H128D50
    Dim Lv_cat_30 = &H129090
    Dim Lv_cat_31 = &H1293D0
    Dim Lv_cat_32 = &H129710
    Dim Lv_cat_33 = &H129A50
    Dim Lv_cat_34 = &H129D90
    Dim Lv_cat_35 = &H12A0D0
    Dim Lv_cat_36 = &H12A410
    Dim Lv_cat_37 = &H12A750
    Dim Lv_cat_38 = &H12AA90
    Dim Lv_cat_39 = &H12ADD0
    Dim Lv_cat_40 = &H12B110
    Dim Lv_cat_41 = &H12B450
    Dim Lv_cat_42 = &H12B790
    Dim Lv_cat_43 = &H12BAD0
    Dim Lv_cat_44 = &H12BE10
    Dim Lv_cat_45 = &H12C150
    Dim Lv_cat_46 = &H12C490
    Dim Lv_cat_47 = &H12C7D0
    Dim Lv_cat_48 = &H12CB10
    Dim Lv_cat_49 = &H12CE50
    Dim Lv_cat_50 = &H12D190
    Dim Lv_cat_51 = &H12D4D0
    Dim Lv_cat_52 = &H12D810
    Dim Lv_cat_53 = &H12DB50
    Dim Lv_cat_54 = &H12DE90
    Dim Lv_cat_55 = &H12E1D0
    Dim Lv_cat_56 = &H12E510
    Dim Lv_cat_57 = &H12E850
    Dim Lv_cat_58 = &H12EB90
    Dim Lv_cat_59 = &H12EED0
    Dim Lv_cat_60 = &H12F210
    Dim Lv_cat_61 = &H12F550
    Dim Lv_cat_62 = &H12F890
    Dim Lv_cat_63 = &H12FBD0
    Dim Lv_cat_64 = &H12FF10
    Dim Lv_cat_65 = &H130250
    Dim Lv_cat_66 = &H130590
    Dim Lv_cat_67 = &H1308D0
    Dim Lv_cat_68 = &H130C10
    Dim Lv_cat_69 = &H130F50
    Dim Lv_cat_70 = &H131290
    Dim Lv_cat_71 = &H1315D0
    Dim Lv_cat_72 = &H131910
    Dim Lv_cat_73 = &H131C50
    Dim Lv_cat_74 = &H131F90
    Dim Lv_cat_75 = &H1322D0
    Dim Lv_cat_76 = &H132610
    Dim Lv_cat_77 = &H132950
    Dim Lv_cat_78 = &H132C90
    Dim Lv_cat_79 = &H132FD0
    Dim Lv_cat_80 = &H133310
    Dim Lv_cat_81 = &H133650
    Dim Lv_cat_82 = &H133990
    Dim Lv_cat_83 = &H133CD0
    Dim Lv_cat_84 = &H134010
    Dim Lv_cat_85 = &H134350
    Dim Lv_cat_86 = &H134690
    Dim Lv_cat_87 = &H1349D0
    Dim Lv_cat_88 = &H134D10
    Dim Lv_cat_89 = &H135050
    Dim Lv_cat_90 = &H135390
    Dim Lv_cat_91 = &H1356D0
    Dim Lv_cat_92 = &H135A10
    Dim Lv_cat_93 = &H135D50
    Dim Lv_cat_94 = &H136090
    Dim Lv_cat_95 = &H1363D0
    Dim Lv_cat_96 = &H136710
    Dim Lv_cat_97 = &H136A50
    Dim Lv_cat_98 = &H136D90
    Dim Lv_cat_99 = &H1370D0
    Dim Lv_cat_100 = &H137410
    Dim Lv_elf_1 = &HFD08C
    Dim Lv_elf_2 = &HFD3CC
    Dim Lv_elf_3 = &HFD70C
    Dim Lv_elf_4 = &HFDA4C
    Dim Lv_elf_5 = &HFDD8C
    Dim Lv_elf_6 = &HFE0CC
    Dim Lv_elf_7 = &HFE40C
    Dim Lv_elf_8 = &HFE74C
    Dim Lv_elf_9 = &HFEA8C
    Dim Lv_elf_10 = &HFEDCC
    Dim Lv_elf_11 = &H1252D4
    Dim Lv_elf_12 = &H125614
    Dim Lv_elf_13 = &H125954
    Dim Lv_elf_14 = &H125C94
    Dim Lv_elf_15 = &H125FD4
    Dim Lv_elf_16 = &H126314
    Dim Lv_elf_17 = &H126654
    Dim Lv_elf_18 = &H126994
    Dim Lv_elf_19 = &H126CD4
    Dim Lv_elf_20 = &H127014
    Dim Lv_elf_21 = &H127354
    Dim Lv_elf_22 = &H127694
    Dim Lv_elf_23 = &H1279D4
    Dim Lv_elf_24 = &H127D14
    Dim Lv_elf_25 = &H128054
    Dim Lv_elf_26 = &H128394
    Dim Lv_elf_27 = &H1286D4
    Dim Lv_elf_28 = &H128A14
    Dim Lv_elf_29 = &H128D54
    Dim Lv_elf_30 = &H129094
    Dim Lv_elf_31 = &H1293D4
    Dim Lv_elf_32 = &H129714
    Dim Lv_elf_33 = &H129A54
    Dim Lv_elf_34 = &H129D94
    Dim Lv_elf_35 = &H12A0D4
    Dim Lv_elf_36 = &H12A414
    Dim Lv_elf_37 = &H12A754
    Dim Lv_elf_38 = &H12AA94
    Dim Lv_elf_39 = &H12ADD4
    Dim Lv_elf_40 = &H12B114
    Dim Lv_elf_41 = &H12B454
    Dim Lv_elf_42 = &H12B794
    Dim Lv_elf_43 = &H12BAD4
    Dim Lv_elf_44 = &H12BE14
    Dim Lv_elf_45 = &H12C154
    Dim Lv_elf_46 = &H12C494
    Dim Lv_elf_47 = &H12C7D4
    Dim Lv_elf_48 = &H12CB14
    Dim Lv_elf_49 = &H12CE54
    Dim Lv_elf_50 = &H12D194
    Dim Lv_elf_51 = &H12D4D4
    Dim Lv_elf_52 = &H12D814
    Dim Lv_elf_53 = &H12DB54
    Dim Lv_elf_54 = &H12DE94
    Dim Lv_elf_55 = &H12E1D4
    Dim Lv_elf_56 = &H12E514
    Dim Lv_elf_57 = &H12E854
    Dim Lv_elf_58 = &H12EB94
    Dim Lv_elf_59 = &H12EED4
    Dim Lv_elf_60 = &H12F214
    Dim Lv_elf_61 = &H12F554
    Dim Lv_elf_62 = &H12F894
    Dim Lv_elf_63 = &H12FBD4
    Dim Lv_elf_64 = &H12FF14
    Dim Lv_elf_65 = &H130254
    Dim Lv_elf_66 = &H130594
    Dim Lv_elf_67 = &H1308D4
    Dim Lv_elf_68 = &H130C14
    Dim Lv_elf_69 = &H130F54
    Dim Lv_elf_70 = &H131294
    Dim Lv_elf_71 = &H1315D4
    Dim Lv_elf_72 = &H131914
    Dim Lv_elf_73 = &H131C54
    Dim Lv_elf_74 = &H131F94
    Dim Lv_elf_75 = &H1322D4
    Dim Lv_elf_76 = &H132614
    Dim Lv_elf_77 = &H132954
    Dim Lv_elf_78 = &H132C94
    Dim Lv_elf_79 = &H132FD4
    Dim Lv_elf_80 = &H133314
    Dim Lv_elf_81 = &H133654
    Dim Lv_elf_82 = &H133994
    Dim Lv_elf_83 = &H133CD4
    Dim Lv_elf_84 = &H134014
    Dim Lv_elf_85 = &H134354
    Dim Lv_elf_86 = &H134694
    Dim Lv_elf_87 = &H1349D4
    Dim Lv_elf_88 = &H134D14
    Dim Lv_elf_89 = &H135054
    Dim Lv_elf_90 = &H135394
    Dim Lv_elf_91 = &H1356D4
    Dim Lv_elf_92 = &H135A14
    Dim Lv_elf_93 = &H135D54
    Dim Lv_elf_94 = &H136094
    Dim Lv_elf_95 = &H1363D4
    Dim Lv_elf_96 = &H136714
    Dim Lv_elf_97 = &H136A54
    Dim Lv_elf_98 = &H136D94
    Dim Lv_elf_99 = &H1370D4
    Dim Lv_elf_100 = &H137414
    Dim Boost_hp_1 = &HFD094
    Dim Boost_hp_2 = &HFD3D4
    Dim Boost_hp_3 = &HFD714
    Dim Boost_hp_4 = &HFDA54
    Dim Boost_hp_5 = &HFDD94
    Dim Boost_hp_6 = &HFE0D4
    Dim Boost_hp_7 = &HFE414
    Dim Boost_hp_8 = &HFE754
    Dim Boost_hp_9 = &HFEA94
    Dim Boost_hp_10 = &HFEDD4
    Dim Boost_hp_11 = &H1252DC
    Dim Boost_hp_12 = &H12561C
    Dim Boost_hp_13 = &H12595C
    Dim Boost_hp_14 = &H125C9C
    Dim Boost_hp_15 = &H125FDC
    Dim Boost_hp_16 = &H12631C
    Dim Boost_hp_17 = &H12665C
    Dim Boost_hp_18 = &H12699C
    Dim Boost_hp_19 = &H126CDC
    Dim Boost_hp_20 = &H12701C
    Dim Boost_hp_21 = &H12735C
    Dim Boost_hp_22 = &H12769C
    Dim Boost_hp_23 = &H1279DC
    Dim Boost_hp_24 = &H127D1C
    Dim Boost_hp_25 = &H12805C
    Dim Boost_hp_26 = &H12839C
    Dim Boost_hp_27 = &H1286DC
    Dim Boost_hp_28 = &H128A1C
    Dim Boost_hp_29 = &H128D5C
    Dim Boost_hp_30 = &H12909C
    Dim Boost_hp_31 = &H1293DC
    Dim Boost_hp_32 = &H12971C
    Dim Boost_hp_33 = &H129A5C
    Dim Boost_hp_34 = &H129D9C
    Dim Boost_hp_35 = &H12A0DC
    Dim Boost_hp_36 = &H12A41C
    Dim Boost_hp_37 = &H12A75C
    Dim Boost_hp_38 = &H12AA9C
    Dim Boost_hp_39 = &H12ADDC
    Dim Boost_hp_40 = &H12B11C
    Dim Boost_hp_41 = &H12B45C
    Dim Boost_hp_42 = &H12B79C
    Dim Boost_hp_43 = &H12BADC
    Dim Boost_hp_44 = &H12BE1C
    Dim Boost_hp_45 = &H12C15C
    Dim Boost_hp_46 = &H12C49C
    Dim Boost_hp_47 = &H12C7DC
    Dim Boost_hp_48 = &H12CB1C
    Dim Boost_hp_49 = &H12CE5C
    Dim Boost_hp_50 = &H12D19C
    Dim Boost_hp_51 = &H12D4DC
    Dim Boost_hp_52 = &H12D81C
    Dim Boost_hp_53 = &H12DB5C
    Dim Boost_hp_54 = &H12DE9C
    Dim Boost_hp_55 = &H12E1DC
    Dim Boost_hp_56 = &H12E51C
    Dim Boost_hp_57 = &H12E85C
    Dim Boost_hp_58 = &H12EB9C
    Dim Boost_hp_59 = &H12EEDC
    Dim Boost_hp_60 = &H12F21C
    Dim Boost_hp_61 = &H12F55C
    Dim Boost_hp_62 = &H12F89C
    Dim Boost_hp_63 = &H12FBDC
    Dim Boost_hp_64 = &H12FF1C
    Dim Boost_hp_65 = &H13025C
    Dim Boost_hp_66 = &H13059C
    Dim Boost_hp_67 = &H1308DC
    Dim Boost_hp_68 = &H130C1C
    Dim Boost_hp_69 = &H130F5C
    Dim Boost_hp_70 = &H13129C
    Dim Boost_hp_71 = &H1315DC
    Dim Boost_hp_72 = &H13191C
    Dim Boost_hp_73 = &H131C5C
    Dim Boost_hp_74 = &H131F9C
    Dim Boost_hp_75 = &H1322DC
    Dim Boost_hp_76 = &H13261C
    Dim Boost_hp_77 = &H13295C
    Dim Boost_hp_78 = &H132C9C
    Dim Boost_hp_79 = &H132FDC
    Dim Boost_hp_80 = &H13331C
    Dim Boost_hp_81 = &H13365C
    Dim Boost_hp_82 = &H13399C
    Dim Boost_hp_83 = &H133CDC
    Dim Boost_hp_84 = &H13401C
    Dim Boost_hp_85 = &H13435C
    Dim Boost_hp_86 = &H13469C
    Dim Boost_hp_87 = &H1349DC
    Dim Boost_hp_88 = &H134D1C
    Dim Boost_hp_89 = &H13505C
    Dim Boost_hp_90 = &H13539C
    Dim Boost_hp_91 = &H1356DC
    Dim Boost_hp_92 = &H135A1C
    Dim Boost_hp_93 = &H135D5C
    Dim Boost_hp_94 = &H13609C
    Dim Boost_hp_95 = &H1363DC
    Dim Boost_hp_96 = &H13671C
    Dim Boost_hp_97 = &H136A5C
    Dim Boost_hp_98 = &H136D9C
    Dim Boost_hp_99 = &H1370DC
    Dim Boost_hp_100 = &H13741C
    Dim Boost_mp_1 = &HFD098
    Dim Boost_mp_2 = &HFD3D8
    Dim Boost_mp_3 = &HFD718
    Dim Boost_mp_4 = &HFDA58
    Dim Boost_mp_5 = &HFDD98
    Dim Boost_mp_6 = &HFE0D8
    Dim Boost_mp_7 = &HFE418
    Dim Boost_mp_8 = &HFE758
    Dim Boost_mp_9 = &HFEA98
    Dim Boost_mp_10 = &HFEDD8
    Dim Boost_mp_11 = &H1252E0
    Dim Boost_mp_12 = &H125620
    Dim Boost_mp_13 = &H125960
    Dim Boost_mp_14 = &H125CA0
    Dim Boost_mp_15 = &H125FE0
    Dim Boost_mp_16 = &H126320
    Dim Boost_mp_17 = &H126660
    Dim Boost_mp_18 = &H1269A0
    Dim Boost_mp_19 = &H126CE0
    Dim Boost_mp_20 = &H127020
    Dim Boost_mp_21 = &H127360
    Dim Boost_mp_22 = &H1276A0
    Dim Boost_mp_23 = &H1279E0
    Dim Boost_mp_24 = &H127D20
    Dim Boost_mp_25 = &H128060
    Dim Boost_mp_26 = &H1283A0
    Dim Boost_mp_27 = &H1286E0
    Dim Boost_mp_28 = &H128A20
    Dim Boost_mp_29 = &H128D60
    Dim Boost_mp_30 = &H1290A0
    Dim Boost_mp_31 = &H1293E0
    Dim Boost_mp_32 = &H129720
    Dim Boost_mp_33 = &H129A60
    Dim Boost_mp_34 = &H129DA0
    Dim Boost_mp_35 = &H12A0E0
    Dim Boost_mp_36 = &H12A420
    Dim Boost_mp_37 = &H12A760
    Dim Boost_mp_38 = &H12AAA0
    Dim Boost_mp_39 = &H12ADE0
    Dim Boost_mp_40 = &H12B120
    Dim Boost_mp_41 = &H12B460
    Dim Boost_mp_42 = &H12B7A0
    Dim Boost_mp_43 = &H12BAE0
    Dim Boost_mp_44 = &H12BE20
    Dim Boost_mp_45 = &H12C160
    Dim Boost_mp_46 = &H12C4A0
    Dim Boost_mp_47 = &H12C7E0
    Dim Boost_mp_48 = &H12CB20
    Dim Boost_mp_49 = &H12CE60
    Dim Boost_mp_50 = &H12D1A0
    Dim Boost_mp_51 = &H12D4E0
    Dim Boost_mp_52 = &H12D820
    Dim Boost_mp_53 = &H12DB60
    Dim Boost_mp_54 = &H12DEA0
    Dim Boost_mp_55 = &H12E1E0
    Dim Boost_mp_56 = &H12E520
    Dim Boost_mp_57 = &H12E860
    Dim Boost_mp_58 = &H12EBA0
    Dim Boost_mp_59 = &H12EEE0
    Dim Boost_mp_60 = &H12F220
    Dim Boost_mp_61 = &H12F560
    Dim Boost_mp_62 = &H12F8A0
    Dim Boost_mp_63 = &H12FBE0
    Dim Boost_mp_64 = &H12FF20
    Dim Boost_mp_65 = &H130260
    Dim Boost_mp_66 = &H1305A0
    Dim Boost_mp_67 = &H1308E0
    Dim Boost_mp_68 = &H130C20
    Dim Boost_mp_69 = &H130F60
    Dim Boost_mp_70 = &H1312A0
    Dim Boost_mp_71 = &H1315E0
    Dim Boost_mp_72 = &H131920
    Dim Boost_mp_73 = &H131C60
    Dim Boost_mp_74 = &H131FA0
    Dim Boost_mp_75 = &H1322E0
    Dim Boost_mp_76 = &H132620
    Dim Boost_mp_77 = &H132960
    Dim Boost_mp_78 = &H132CA0
    Dim Boost_mp_79 = &H132FE0
    Dim Boost_mp_80 = &H133320
    Dim Boost_mp_81 = &H133660
    Dim Boost_mp_82 = &H1339A0
    Dim Boost_mp_83 = &H133CE0
    Dim Boost_mp_84 = &H134020
    Dim Boost_mp_85 = &H134360
    Dim Boost_mp_86 = &H1346A0
    Dim Boost_mp_87 = &H1349E0
    Dim Boost_mp_88 = &H134D20
    Dim Boost_mp_89 = &H135060
    Dim Boost_mp_90 = &H1353A0
    Dim Boost_mp_91 = &H1356E0
    Dim Boost_mp_92 = &H135A20
    Dim Boost_mp_93 = &H135D60
    Dim Boost_mp_94 = &H1360A0
    Dim Boost_mp_95 = &H1363E0
    Dim Boost_mp_96 = &H136720
    Dim Boost_mp_97 = &H136A60
    Dim Boost_mp_98 = &H136DA0
    Dim Boost_mp_99 = &H1370E0
    Dim Boost_mp_100 = &H137420
    Dim Boost_attack_1 = &HFD09C
    Dim Boost_attack_2 = &HFD3DC
    Dim Boost_attack_3 = &HFD71C
    Dim Boost_attack_4 = &HFDA5C
    Dim Boost_attack_5 = &HFDD9C
    Dim Boost_attack_6 = &HFE0DC
    Dim Boost_attack_7 = &HFE41C
    Dim Boost_attack_8 = &HFE75C
    Dim Boost_attack_9 = &HFEA9C
    Dim Boost_attack_10 = &HFEDDC
    Dim Boost_attack_11 = &H1252E4
    Dim Boost_attack_12 = &H125624
    Dim Boost_attack_13 = &H125964
    Dim Boost_attack_14 = &H125CA4
    Dim Boost_attack_15 = &H125FE4
    Dim Boost_attack_16 = &H126324
    Dim Boost_attack_17 = &H126664
    Dim Boost_attack_18 = &H1269A4
    Dim Boost_attack_19 = &H126CE4
    Dim Boost_attack_20 = &H127024
    Dim Boost_attack_21 = &H127364
    Dim Boost_attack_22 = &H1276A4
    Dim Boost_attack_23 = &H1279E4
    Dim Boost_attack_24 = &H127D24
    Dim Boost_attack_25 = &H128064
    Dim Boost_attack_26 = &H1283A4
    Dim Boost_attack_27 = &H1286E4
    Dim Boost_attack_28 = &H128A24
    Dim Boost_attack_29 = &H128D64
    Dim Boost_attack_30 = &H1290A4
    Dim Boost_attack_31 = &H1293E4
    Dim Boost_attack_32 = &H129724
    Dim Boost_attack_33 = &H129A64
    Dim Boost_attack_34 = &H129DA4
    Dim Boost_attack_35 = &H12A0E4
    Dim Boost_attack_36 = &H12A424
    Dim Boost_attack_37 = &H12A764
    Dim Boost_attack_38 = &H12AAA4
    Dim Boost_attack_39 = &H12ADE4
    Dim Boost_attack_40 = &H12B124
    Dim Boost_attack_41 = &H12B464
    Dim Boost_attack_42 = &H12B7A4
    Dim Boost_attack_43 = &H12BAE4
    Dim Boost_attack_44 = &H12BE24
    Dim Boost_attack_45 = &H12C164
    Dim Boost_attack_46 = &H12C4A4
    Dim Boost_attack_47 = &H12C7E4
    Dim Boost_attack_48 = &H12CB24
    Dim Boost_attack_49 = &H12CE64
    Dim Boost_attack_50 = &H12D1A4
    Dim Boost_attack_51 = &H12D4E4
    Dim Boost_attack_52 = &H12D824
    Dim Boost_attack_53 = &H12DB64
    Dim Boost_attack_54 = &H12DEA4
    Dim Boost_attack_55 = &H12E1E4
    Dim Boost_attack_56 = &H12E524
    Dim Boost_attack_57 = &H12E864
    Dim Boost_attack_58 = &H12EBA4
    Dim Boost_attack_59 = &H12EEE4
    Dim Boost_attack_60 = &H12F224
    Dim Boost_attack_61 = &H12F564
    Dim Boost_attack_62 = &H12F8A4
    Dim Boost_attack_63 = &H12FBE4
    Dim Boost_attack_64 = &H12FF24
    Dim Boost_attack_65 = &H130264
    Dim Boost_attack_66 = &H1305A4
    Dim Boost_attack_67 = &H1308E4
    Dim Boost_attack_68 = &H130C24
    Dim Boost_attack_69 = &H130F64
    Dim Boost_attack_70 = &H1312A4
    Dim Boost_attack_71 = &H1315E4
    Dim Boost_attack_72 = &H131924
    Dim Boost_attack_73 = &H131C64
    Dim Boost_attack_74 = &H131FA4
    Dim Boost_attack_75 = &H1322E4
    Dim Boost_attack_76 = &H132624
    Dim Boost_attack_77 = &H132964
    Dim Boost_attack_78 = &H132CA4
    Dim Boost_attack_79 = &H132FE4
    Dim Boost_attack_80 = &H133324
    Dim Boost_attack_81 = &H133664
    Dim Boost_attack_82 = &H1339A4
    Dim Boost_attack_83 = &H133CE4
    Dim Boost_attack_84 = &H134024
    Dim Boost_attack_85 = &H134364
    Dim Boost_attack_86 = &H1346A4
    Dim Boost_attack_87 = &H1349E4
    Dim Boost_attack_88 = &H134D24
    Dim Boost_attack_89 = &H135064
    Dim Boost_attack_90 = &H1353A4
    Dim Boost_attack_91 = &H1356E4
    Dim Boost_attack_92 = &H135A24
    Dim Boost_attack_93 = &H135D64
    Dim Boost_attack_94 = &H1360A4
    Dim Boost_attack_95 = &H1363E4
    Dim Boost_attack_96 = &H136724
    Dim Boost_attack_97 = &H136A64
    Dim Boost_attack_98 = &H136DA4
    Dim Boost_attack_99 = &H1370E4
    Dim Boost_attack_100 = &H137424
    Dim Boost_defense_1 = &HFD0A0
    Dim Boost_defense_2 = &HFD3E0
    Dim Boost_defense_3 = &HFD720
    Dim Boost_defense_4 = &HFDA60
    Dim Boost_defense_5 = &HFDDA0
    Dim Boost_defense_6 = &HFE0E0
    Dim Boost_defense_7 = &HFE420
    Dim Boost_defense_8 = &HFE760
    Dim Boost_defense_9 = &HFEAA0
    Dim Boost_defense_10 = &HFEDE0
    Dim Boost_defense_11 = &H1252E8
    Dim Boost_defense_12 = &H125628
    Dim Boost_defense_13 = &H125968
    Dim Boost_defense_14 = &H125CA8
    Dim Boost_defense_15 = &H125FE8
    Dim Boost_defense_16 = &H126328
    Dim Boost_defense_17 = &H126668
    Dim Boost_defense_18 = &H1269A8
    Dim Boost_defense_19 = &H126CE8
    Dim Boost_defense_20 = &H127028
    Dim Boost_defense_21 = &H127368
    Dim Boost_defense_22 = &H1276A8
    Dim Boost_defense_23 = &H1279E8
    Dim Boost_defense_24 = &H127D28
    Dim Boost_defense_25 = &H128068
    Dim Boost_defense_26 = &H1283A8
    Dim Boost_defense_27 = &H1286E8
    Dim Boost_defense_28 = &H128A28
    Dim Boost_defense_29 = &H128D68
    Dim Boost_defense_30 = &H1290A8
    Dim Boost_defense_31 = &H1293E8
    Dim Boost_defense_32 = &H129728
    Dim Boost_defense_33 = &H129A68
    Dim Boost_defense_34 = &H129DA8
    Dim Boost_defense_35 = &H12A0E8
    Dim Boost_defense_36 = &H12A428
    Dim Boost_defense_37 = &H12A768
    Dim Boost_defense_38 = &H12AAA8
    Dim Boost_defense_39 = &H12ADE8
    Dim Boost_defense_40 = &H12B128
    Dim Boost_defense_41 = &H12B468
    Dim Boost_defense_42 = &H12B7A8
    Dim Boost_defense_43 = &H12BAE8
    Dim Boost_defense_44 = &H12BE28
    Dim Boost_defense_45 = &H12C168
    Dim Boost_defense_46 = &H12C4A8
    Dim Boost_defense_47 = &H12C7E8
    Dim Boost_defense_48 = &H12CB28
    Dim Boost_defense_49 = &H12CE68
    Dim Boost_defense_50 = &H12D1A8
    Dim Boost_defense_51 = &H12D4E8
    Dim Boost_defense_52 = &H12D828
    Dim Boost_defense_53 = &H12DB68
    Dim Boost_defense_54 = &H12DEA8
    Dim Boost_defense_55 = &H12E1E8
    Dim Boost_defense_56 = &H12E528
    Dim Boost_defense_57 = &H12E868
    Dim Boost_defense_58 = &H12EBA8
    Dim Boost_defense_59 = &H12EEE8
    Dim Boost_defense_60 = &H12F228
    Dim Boost_defense_61 = &H12F568
    Dim Boost_defense_62 = &H12F8A8
    Dim Boost_defense_63 = &H12FBE8
    Dim Boost_defense_64 = &H12FF28
    Dim Boost_defense_65 = &H130268
    Dim Boost_defense_66 = &H1305A8
    Dim Boost_defense_67 = &H1308E8
    Dim Boost_defense_68 = &H130C28
    Dim Boost_defense_69 = &H130F68
    Dim Boost_defense_70 = &H1312A8
    Dim Boost_defense_71 = &H1315E8
    Dim Boost_defense_72 = &H131928
    Dim Boost_defense_73 = &H131C68
    Dim Boost_defense_74 = &H131FA8
    Dim Boost_defense_75 = &H1322E8
    Dim Boost_defense_76 = &H132628
    Dim Boost_defense_77 = &H132968
    Dim Boost_defense_78 = &H132CA8
    Dim Boost_defense_79 = &H132FE8
    Dim Boost_defense_80 = &H133328
    Dim Boost_defense_81 = &H133668
    Dim Boost_defense_82 = &H1339A8
    Dim Boost_defense_83 = &H133CE8
    Dim Boost_defense_84 = &H134028
    Dim Boost_defense_85 = &H134368
    Dim Boost_defense_86 = &H1346A8
    Dim Boost_defense_87 = &H1349E8
    Dim Boost_defense_88 = &H134D28
    Dim Boost_defense_89 = &H135068
    Dim Boost_defense_90 = &H1353A8
    Dim Boost_defense_91 = &H1356E8
    Dim Boost_defense_92 = &H135A28
    Dim Boost_defense_93 = &H135D68
    Dim Boost_defense_94 = &H1360A8
    Dim Boost_defense_95 = &H1363E8
    Dim Boost_defense_96 = &H136728
    Dim Boost_defense_97 = &H136A68
    Dim Boost_defense_98 = &H136DA8
    Dim Boost_defense_99 = &H1370E8
    Dim Boost_defense_100 = &H137428
    Dim Boost_magic_1 = &HFD0A4
    Dim Boost_magic_2 = &HFD3E4
    Dim Boost_magic_3 = &HFD724
    Dim Boost_magic_4 = &HFDA64
    Dim Boost_magic_5 = &HFDDA4
    Dim Boost_magic_6 = &HFE0E4
    Dim Boost_magic_7 = &HFE424
    Dim Boost_magic_8 = &HFE764
    Dim Boost_magic_9 = &HFEAA4
    Dim Boost_magic_10 = &HFEDE4
    Dim Boost_magic_11 = &H1252EC
    Dim Boost_magic_12 = &H12562C
    Dim Boost_magic_13 = &H12596C
    Dim Boost_magic_14 = &H125CAC
    Dim Boost_magic_15 = &H125FEC
    Dim Boost_magic_16 = &H12632C
    Dim Boost_magic_17 = &H12666C
    Dim Boost_magic_18 = &H1269AC
    Dim Boost_magic_19 = &H126CEC
    Dim Boost_magic_20 = &H12702C
    Dim Boost_magic_21 = &H12736C
    Dim Boost_magic_22 = &H1276AC
    Dim Boost_magic_23 = &H1279EC
    Dim Boost_magic_24 = &H127D2C
    Dim Boost_magic_25 = &H12806C
    Dim Boost_magic_26 = &H1283AC
    Dim Boost_magic_27 = &H1286EC
    Dim Boost_magic_28 = &H128A2C
    Dim Boost_magic_29 = &H128D6C
    Dim Boost_magic_30 = &H1290AC
    Dim Boost_magic_31 = &H1293EC
    Dim Boost_magic_32 = &H12972C
    Dim Boost_magic_33 = &H129A6C
    Dim Boost_magic_34 = &H129DAC
    Dim Boost_magic_35 = &H12A0EC
    Dim Boost_magic_36 = &H12A42C
    Dim Boost_magic_37 = &H12A76C
    Dim Boost_magic_38 = &H12AAAC
    Dim Boost_magic_39 = &H12ADEC
    Dim Boost_magic_40 = &H12B12C
    Dim Boost_magic_41 = &H12B46C
    Dim Boost_magic_42 = &H12B7AC
    Dim Boost_magic_43 = &H12BAEC
    Dim Boost_magic_44 = &H12BE2C
    Dim Boost_magic_45 = &H12C16C
    Dim Boost_magic_46 = &H12C4AC
    Dim Boost_magic_47 = &H12C7EC
    Dim Boost_magic_48 = &H12CB2C
    Dim Boost_magic_49 = &H12CE6C
    Dim Boost_magic_50 = &H12D1AC
    Dim Boost_magic_51 = &H12D4EC
    Dim Boost_magic_52 = &H12D82C
    Dim Boost_magic_53 = &H12DB6C
    Dim Boost_magic_54 = &H12DEAC
    Dim Boost_magic_55 = &H12E1EC
    Dim Boost_magic_56 = &H12E52C
    Dim Boost_magic_57 = &H12E86C
    Dim Boost_magic_58 = &H12EBAC
    Dim Boost_magic_59 = &H12EEEC
    Dim Boost_magic_60 = &H12F22C
    Dim Boost_magic_61 = &H12F56C
    Dim Boost_magic_62 = &H12F8AC
    Dim Boost_magic_63 = &H12FBEC
    Dim Boost_magic_64 = &H12FF2C
    Dim Boost_magic_65 = &H13026C
    Dim Boost_magic_66 = &H1305AC
    Dim Boost_magic_67 = &H1308EC
    Dim Boost_magic_68 = &H130C2C
    Dim Boost_magic_69 = &H130F6C
    Dim Boost_magic_70 = &H1312AC
    Dim Boost_magic_71 = &H1315EC
    Dim Boost_magic_72 = &H13192C
    Dim Boost_magic_73 = &H131C6C
    Dim Boost_magic_74 = &H131FAC
    Dim Boost_magic_75 = &H1322EC
    Dim Boost_magic_76 = &H13262C
    Dim Boost_magic_77 = &H13296C
    Dim Boost_magic_78 = &H132CAC
    Dim Boost_magic_79 = &H132FEC
    Dim Boost_magic_80 = &H13332C
    Dim Boost_magic_81 = &H13366C
    Dim Boost_magic_82 = &H1339AC
    Dim Boost_magic_83 = &H133CEC
    Dim Boost_magic_84 = &H13402C
    Dim Boost_magic_85 = &H13436C
    Dim Boost_magic_86 = &H1346AC
    Dim Boost_magic_87 = &H1349EC
    Dim Boost_magic_88 = &H134D2C
    Dim Boost_magic_89 = &H13506C
    Dim Boost_magic_90 = &H1353AC
    Dim Boost_magic_91 = &H1356EC
    Dim Boost_magic_92 = &H135A2C
    Dim Boost_magic_93 = &H135D6C
    Dim Boost_magic_94 = &H1360AC
    Dim Boost_magic_95 = &H1363EC
    Dim Boost_magic_96 = &H13672C
    Dim Boost_magic_97 = &H136A6C
    Dim Boost_magic_98 = &H136DAC
    Dim Boost_magic_99 = &H1370EC
    Dim Boost_magic_100 = &H13742C
    Dim Boost_speed_1 = &HFD0A8
    Dim Boost_speed_2 = &HFD3E8
    Dim Boost_speed_3 = &HFD728
    Dim Boost_speed_4 = &HFDA68
    Dim Boost_speed_5 = &HFDDA8
    Dim Boost_speed_6 = &HFE0E8
    Dim Boost_speed_7 = &HFE428
    Dim Boost_speed_8 = &HFE768
    Dim Boost_speed_9 = &HFEAA8
    Dim Boost_speed_10 = &HFEDE8
    Dim Boost_speed_11 = &H1252F0
    Dim Boost_speed_12 = &H125630
    Dim Boost_speed_13 = &H125970
    Dim Boost_speed_14 = &H125CB0
    Dim Boost_speed_15 = &H125FF0
    Dim Boost_speed_16 = &H126330
    Dim Boost_speed_17 = &H126670
    Dim Boost_speed_18 = &H1269B0
    Dim Boost_speed_19 = &H126CF0
    Dim Boost_speed_20 = &H127030
    Dim Boost_speed_21 = &H127370
    Dim Boost_speed_22 = &H1276B0
    Dim Boost_speed_23 = &H1279F0
    Dim Boost_speed_24 = &H127D30
    Dim Boost_speed_25 = &H128070
    Dim Boost_speed_26 = &H1283B0
    Dim Boost_speed_27 = &H1286F0
    Dim Boost_speed_28 = &H128A30
    Dim Boost_speed_29 = &H128D70
    Dim Boost_speed_30 = &H1290B0
    Dim Boost_speed_31 = &H1293F0
    Dim Boost_speed_32 = &H129730
    Dim Boost_speed_33 = &H129A70
    Dim Boost_speed_34 = &H129DB0
    Dim Boost_speed_35 = &H12A0F0
    Dim Boost_speed_36 = &H12A430
    Dim Boost_speed_37 = &H12A770
    Dim Boost_speed_38 = &H12AAB0
    Dim Boost_speed_39 = &H12ADF0
    Dim Boost_speed_40 = &H12B130
    Dim Boost_speed_41 = &H12B470
    Dim Boost_speed_42 = &H12B7B0
    Dim Boost_speed_43 = &H12BAF0
    Dim Boost_speed_44 = &H12BE30
    Dim Boost_speed_45 = &H12C170
    Dim Boost_speed_46 = &H12C4B0
    Dim Boost_speed_47 = &H12C7F0
    Dim Boost_speed_48 = &H12CB30
    Dim Boost_speed_49 = &H12CE70
    Dim Boost_speed_50 = &H12D1B0
    Dim Boost_speed_51 = &H12D4F0
    Dim Boost_speed_52 = &H12D830
    Dim Boost_speed_53 = &H12DB70
    Dim Boost_speed_54 = &H12DEB0
    Dim Boost_speed_55 = &H12E1F0
    Dim Boost_speed_56 = &H12E530
    Dim Boost_speed_57 = &H12E870
    Dim Boost_speed_58 = &H12EBB0
    Dim Boost_speed_59 = &H12EEF0
    Dim Boost_speed_60 = &H12F230
    Dim Boost_speed_61 = &H12F570
    Dim Boost_speed_62 = &H12F8B0
    Dim Boost_speed_63 = &H12FBF0
    Dim Boost_speed_64 = &H12FF30
    Dim Boost_speed_65 = &H130270
    Dim Boost_speed_66 = &H1305B0
    Dim Boost_speed_67 = &H1308F0
    Dim Boost_speed_68 = &H130C30
    Dim Boost_speed_69 = &H130F70
    Dim Boost_speed_70 = &H1312B0
    Dim Boost_speed_71 = &H1315F0
    Dim Boost_speed_72 = &H131930
    Dim Boost_speed_73 = &H131C70
    Dim Boost_speed_74 = &H131FB0
    Dim Boost_speed_75 = &H1322F0
    Dim Boost_speed_76 = &H132630
    Dim Boost_speed_77 = &H132970
    Dim Boost_speed_78 = &H132CB0
    Dim Boost_speed_79 = &H132FF0
    Dim Boost_speed_80 = &H133330
    Dim Boost_speed_81 = &H133670
    Dim Boost_speed_82 = &H1339B0
    Dim Boost_speed_83 = &H133CF0
    Dim Boost_speed_84 = &H134030
    Dim Boost_speed_85 = &H134370
    Dim Boost_speed_86 = &H1346B0
    Dim Boost_speed_87 = &H1349F0
    Dim Boost_speed_88 = &H134D30
    Dim Boost_speed_89 = &H135070
    Dim Boost_speed_90 = &H1353B0
    Dim Boost_speed_91 = &H1356F0
    Dim Boost_speed_92 = &H135A30
    Dim Boost_speed_93 = &H135D70
    Dim Boost_speed_94 = &H1360B0
    Dim Boost_speed_95 = &H1363F0
    Dim Boost_speed_96 = &H136730
    Dim Boost_speed_97 = &H136A70
    Dim Boost_speed_98 = &H136DB0
    Dim Boost_speed_99 = &H1370F0
    Dim Boost_speed_100 = &H137430
    Dim Mii_name_1 = &HFCFE4
    Dim Mii_name_2 = &HFD324
    Dim Mii_name_3 = &HFD664
    Dim Mii_name_4 = &HFD9A4
    Dim Mii_name_5 = &HFDCE4
    Dim Mii_name_6 = &HFE024
    Dim Mii_name_7 = &HFE364
    Dim Mii_name_8 = &HFE6A4
    Dim Mii_name_9 = &HFE9E4
    Dim Mii_name_10 = &HFED24
    Dim Mii_name_11 = &H12522C
    Dim Mii_name_12 = &H12556C
    Dim Mii_name_13 = &H1258AC
    Dim Mii_name_14 = &H125BEC
    Dim Mii_name_15 = &H125F2C
    Dim Mii_name_16 = &H12626C
    Dim Mii_name_17 = &H1265AC
    Dim Mii_name_18 = &H1268EC
    Dim Mii_name_19 = &H126C2C
    Dim Mii_name_20 = &H126F6C
    Dim Mii_name_21 = &H1272AC
    Dim Mii_name_22 = &H1275EC
    Dim Mii_name_23 = &H12792C
    Dim Mii_name_24 = &H127C6C
    Dim Mii_name_25 = &H127FAC
    Dim Mii_name_26 = &H1282EC
    Dim Mii_name_27 = &H12862C
    Dim Mii_name_28 = &H12896C
    Dim Mii_name_29 = &H128CAC
    Dim Mii_name_30 = &H128FEC
    Dim Mii_name_31 = &H12932C
    Dim Mii_name_32 = &H12966C
    Dim Mii_name_33 = &H1299AC
    Dim Mii_name_34 = &H129CEC
    Dim Mii_name_35 = &H12A02C
    Dim Mii_name_36 = &H12A36C
    Dim Mii_name_37 = &H12A6AC
    Dim Mii_name_38 = &H12A9EC
    Dim Mii_name_39 = &H12AD2C
    Dim Mii_name_40 = &H12B06C
    Dim Mii_name_41 = &H12B3AC
    Dim Mii_name_42 = &H12B6EC
    Dim Mii_name_43 = &H12BA2C
    Dim Mii_name_44 = &H12BD6C
    Dim Mii_name_45 = &H12C0AC
    Dim Mii_name_46 = &H12C3EC
    Dim Mii_name_47 = &H12C72C
    Dim Mii_name_48 = &H12CA6C
    Dim Mii_name_49 = &H12CDAC
    Dim Mii_name_50 = &H12D0EC
    Dim Mii_name_51 = &H12D42C
    Dim Mii_name_52 = &H12D76C
    Dim Mii_name_53 = &H12DAAC
    Dim Mii_name_54 = &H12DDEC
    Dim Mii_name_55 = &H12E12C
    Dim Mii_name_56 = &H12E46C
    Dim Mii_name_57 = &H12E7AC
    Dim Mii_name_58 = &H12EAEC
    Dim Mii_name_59 = &H12EE2C
    Dim Mii_name_60 = &H12F16C
    Dim Mii_name_61 = &H12F4AC
    Dim Mii_name_62 = &H12F7EC
    Dim Mii_name_63 = &H12FB2C
    Dim Mii_name_64 = &H12FE6C
    Dim Mii_name_65 = &H1301AC
    Dim Mii_name_66 = &H1304EC
    Dim Mii_name_67 = &H13082C
    Dim Mii_name_68 = &H130B6C
    Dim Mii_name_69 = &H130EAC
    Dim Mii_name_70 = &H1311EC
    Dim Mii_name_71 = &H13152C
    Dim Mii_name_72 = &H13186C
    Dim Mii_name_73 = &H131BAC
    Dim Mii_name_74 = &H131EEC
    Dim Mii_name_75 = &H13222C
    Dim Mii_name_76 = &H13256C
    Dim Mii_name_77 = &H1328AC
    Dim Mii_name_78 = &H132BEC
    Dim Mii_name_79 = &H132F2C
    Dim Mii_name_80 = &H13326C
    Dim Mii_name_81 = &H1335AC
    Dim Mii_name_82 = &H1338EC
    Dim Mii_name_83 = &H133C2C
    Dim Mii_name_84 = &H133F6C
    Dim Mii_name_85 = &H1342AC
    Dim Mii_name_86 = &H1345EC
    Dim Mii_name_87 = &H13492C
    Dim Mii_name_88 = &H134C6C
    Dim Mii_name_89 = &H134FAC
    Dim Mii_name_90 = &H1352EC
    Dim Mii_name_91 = &H13562C
    Dim Mii_name_92 = &H13596C
    Dim Mii_name_93 = &H135CAC
    Dim Mii_name_94 = &H135FEC
    Dim Mii_name_95 = &H13632C
    Dim Mii_name_96 = &H13666C
    Dim Mii_name_97 = &H1369AC
    Dim Mii_name_98 = &H136CEC
    Dim Mii_name_99 = &H13702C
    Dim Mii_name_100 = &H13736C

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

    Private Sub Select_Mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Mii.SelectedIndexChanged
        Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(0)
        Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(0)
        Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(0)
        Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(0)
        Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(0)
        Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(0)
        Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(0)
        Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(0)
        Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(0)
        Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(0)
        Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(0)
        Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(0)
        Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(0)
        Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(0)
        Readjobslevelsboosts()
        Text_Miiname.Text = Select_Mii.Text
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
        Readjobslevelsboosts()
    End Sub

    Public Sub Readjobslevelsboosts()
        Try
            Dim Readjobs As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            If Select_Mii.SelectedItem = Select_Mii.Items(0) Then
                Readjobs.Position = Lv_cat_1
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_1
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_1
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_1
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_1
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_1
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_1
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_1
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_1
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_1
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_1
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_1
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_1
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_1
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_1
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_1
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_1
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_1
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_1
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_1
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(1) Then
                Readjobs.Position = Lv_cat_2
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_2
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_2
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_2
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_2
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_2
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_2
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_2
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_2
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_2
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_2
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_2
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_2
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_2
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_2
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_2
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_2
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_2
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_2
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_2
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(2) Then
                Readjobs.Position = Lv_cat_3
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_3
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_3
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_3
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_3
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_3
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_3
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_3
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_3
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_3
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_3
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_3
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_3
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_3
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_3
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_3
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_3
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_3
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_3
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_3
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(3) Then
                Readjobs.Position = Lv_cat_4
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_4
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_4
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_4
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_4
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_4
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_4
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_4
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_4
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_4
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_4
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_4
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_4
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_4
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_4
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_4
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_4
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_4
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_4
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_4
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(4) Then
                Readjobs.Position = Lv_cat_5
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_5
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_5
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_5
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_5
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_5
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_5
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_5
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_5
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_5
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_5
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_5
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_5
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_5
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_5
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_5
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_5
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_5
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_5
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_5
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(5) Then
                Readjobs.Position = Lv_cat_6
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_6
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_6
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_6
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_6
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_6
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_6
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_6
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_6
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_6
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_6
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_6
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_6
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_6
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_6
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_6
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_6
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_6
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_6
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_6
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(6) Then
                Readjobs.Position = Lv_cat_7
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_7
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_7
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_7
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_7
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_7
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_7
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_7
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_7
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_7
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_7
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_7
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_7
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_7
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_7
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_7
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_7
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_7
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_7
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_7
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(7) Then
                Readjobs.Position = Lv_cat_8
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_8
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_8
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_8
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_8
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_8
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_8
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_8
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_8
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_8
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_8
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_8
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_8
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_8
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_8
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_8
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_8
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_8
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_8
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_8
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(8) Then
                Readjobs.Position = Lv_cat_9
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_9
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_9
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_9
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_9
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_9
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_9
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_9
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_9
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_9
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_9
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_9
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_9
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_9
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_9
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_9
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_9
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_9
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_9
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_9
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(9) Then
                Readjobs.Position = Lv_cat_10
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_10
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_10
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_10
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_10
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_10
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_10
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_10
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_10
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_10
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_10
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_10
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_10
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_10
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_10
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_10
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_10
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_10
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_10
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_10
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(10) Then
                Readjobs.Position = Lv_cat_11
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_11
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_11
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_11
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_11
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_11
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_11
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_11
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_11
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_11
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_11
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_11
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_11
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_11
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_11
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_11
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_11
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_11
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_11
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_11
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(11) Then
                Readjobs.Position = Lv_cat_12
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_12
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_12
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_12
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_12
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_12
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_12
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_12
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_12
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_12
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_12
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_12
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_12
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_12
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_12
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_12
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_12
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_12
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_12
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_12
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(12) Then
                Readjobs.Position = Lv_cat_13
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_13
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_13
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_13
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_13
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_13
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_13
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_13
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_13
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_13
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_13
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_13
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_13
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_13
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_13
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_13
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_13
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_13
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_13
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_13
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(13) Then
                Readjobs.Position = Lv_cat_14
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_14
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_14
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_14
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_14
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_14
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_14
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_14
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_14
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_14
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_14
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_14
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_14
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_14
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_14
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_14
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_14
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_14
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_14
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_14
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(14) Then
                Readjobs.Position = Lv_cat_15
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_15
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_15
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_15
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_15
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_15
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_15
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_15
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_15
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_15
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_15
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_15
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_15
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_15
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_15
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_15
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_15
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_15
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_15
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_15
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(15) Then
                Readjobs.Position = Lv_cat_16
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_16
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_16
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_16
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_16
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_16
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_16
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_16
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_16
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_16
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_16
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_16
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_16
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_16
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_16
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_16
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_16
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_16
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_16
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_16
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(16) Then
                Readjobs.Position = Lv_cat_17
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_17
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_17
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_17
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_17
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_17
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_17
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_17
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_17
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_17
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_17
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_17
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_17
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_17
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_17
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_17
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_17
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_17
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_17
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_17
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(17) Then
                Readjobs.Position = Lv_cat_18
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_18
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_18
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_18
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_18
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_18
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_18
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_18
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_18
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_18
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_18
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_18
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_18
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_18
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_18
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_18
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_18
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_18
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_18
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_18
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(18) Then
                Readjobs.Position = Lv_cat_19
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_19
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_19
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_19
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_19
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_19
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_19
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_19
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_19
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_19
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_19
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_19
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_19
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_19
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_19
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_19
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_19
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_19
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_19
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_19
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(19) Then
                Readjobs.Position = Lv_cat_20
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_20
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_20
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_20
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_20
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_20
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_20
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_20
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_20
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_20
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_20
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_20
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_20
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_20
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_20
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_20
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_20
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_20
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_20
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_20
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(20) Then
                Readjobs.Position = Lv_cat_21
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_21
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_21
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_21
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_21
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_21
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_21
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_21
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_21
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_21
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_21
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_21
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_21
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_21
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_21
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_21
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_21
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_21
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_21
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_21
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(21) Then
                Readjobs.Position = Lv_cat_22
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_22
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_22
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_22
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_22
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_22
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_22
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_22
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_22
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_22
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_22
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_22
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_22
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_22
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_22
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_22
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_22
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_22
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_22
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_22
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(22) Then
                Readjobs.Position = Lv_cat_23
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_23
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_23
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_23
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_23
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_23
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_23
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_23
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_23
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_23
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_23
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_23
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_23
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_23
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_23
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_23
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_23
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_23
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_23
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_23
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(23) Then
                Readjobs.Position = Lv_cat_24
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_24
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_24
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_24
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_24
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_24
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_24
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_24
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_24
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_24
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_24
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_24
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_24
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_24
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_24
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_24
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_24
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_24
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_24
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_24
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(24) Then
                Readjobs.Position = Lv_cat_25
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_25
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_25
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_25
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_25
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_25
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_25
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_25
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_25
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_25
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_25
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_25
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_25
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_25
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_25
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_25
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_25
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_25
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_25
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_25
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(25) Then
                Readjobs.Position = Lv_cat_26
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_26
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_26
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_26
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_26
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_26
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_26
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_26
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_26
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_26
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_26
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_26
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_26
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_26
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_26
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_26
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_26
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_26
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_26
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_26
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(26) Then
                Readjobs.Position = Lv_cat_27
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_27
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_27
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_27
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_27
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_27
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_27
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_27
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_27
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_27
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_27
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_27
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_27
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_27
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_27
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_27
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_27
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_27
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_27
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_27
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(27) Then
                Readjobs.Position = Lv_cat_28
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_28
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_28
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_28
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_28
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_28
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_28
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_28
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_28
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_28
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_28
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_28
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_28
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_28
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_28
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_28
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_28
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_28
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_28
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_28
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(28) Then
                Readjobs.Position = Lv_cat_29
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_29
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_29
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_29
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_29
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_29
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_29
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_29
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_29
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_29
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_29
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_29
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_29
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_29
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_29
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_29
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_29
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_29
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_29
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_29
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(29) Then
                Readjobs.Position = Lv_cat_30
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_30
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_30
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_30
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_30
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_30
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_30
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_30
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_30
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_30
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_30
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_30
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_30
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_30
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_30
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_30
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_30
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_30
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_30
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_30
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(30) Then
                Readjobs.Position = Lv_cat_31
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_31
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_31
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_31
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_31
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_31
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_31
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_31
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_31
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_31
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_31
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_31
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_31
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_31
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_31
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_31
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_31
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_31
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_31
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_31
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(31) Then
                Readjobs.Position = Lv_cat_32
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_32
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_32
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_32
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_32
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_32
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_32
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_32
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_32
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_32
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_32
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_32
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_32
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_32
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_32
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_32
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_32
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_32
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_32
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_32
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(32) Then
                Readjobs.Position = Lv_cat_33
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_33
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_33
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_33
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_33
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_33
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_33
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_33
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_33
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_33
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_33
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_33
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_33
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_33
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_33
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_33
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_33
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_33
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_33
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_33
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(33) Then
                Readjobs.Position = Lv_cat_34
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_34
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_34
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_34
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_34
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_34
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_34
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_34
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_34
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_34
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_34
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_34
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_34
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_34
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_34
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_34
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_34
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_34
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_34
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_34
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(34) Then
                Readjobs.Position = Lv_cat_35
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_35
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_35
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_35
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_35
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_35
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_35
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_35
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_35
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_35
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_35
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_35
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_35
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_35
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_35
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_35
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_35
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_35
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_35
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_35
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(35) Then
                Readjobs.Position = Lv_cat_36
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_36
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_36
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_36
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_36
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_36
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_36
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_36
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_36
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_36
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_36
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_36
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_36
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_36
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_36
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_36
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_36
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_36
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_36
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_36
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(36) Then
                Readjobs.Position = Lv_cat_37
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_37
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_37
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_37
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_37
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_37
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_37
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_37
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_37
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_37
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_37
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_37
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_37
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_37
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_37
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_37
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_37
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_37
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_37
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_37
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(37) Then
                Readjobs.Position = Lv_cat_38
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_38
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_38
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_38
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_38
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_38
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_38
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_38
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_38
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_38
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_38
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_38
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_38
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_38
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_38
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_38
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_38
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_38
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_38
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_38
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(38) Then
                Readjobs.Position = Lv_cat_39
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_39
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_39
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_39
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_39
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_39
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_39
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_39
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_39
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_39
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_39
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_39
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_39
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_39
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_39
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_39
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_39
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_39
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_39
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_39
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(39) Then
                Readjobs.Position = Lv_cat_40
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_40
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_40
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_40
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_40
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_40
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_40
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_40
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_40
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_40
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_40
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_40
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_40
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_40
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_40
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_40
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_40
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_40
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_40
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_40
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(40) Then
                Readjobs.Position = Lv_cat_41
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_41
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_41
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_41
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_41
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_41
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_41
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_41
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_41
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_41
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_41
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_41
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_41
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_41
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_41
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_41
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_41
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_41
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_41
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_41
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(41) Then
                Readjobs.Position = Lv_cat_42
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_42
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_42
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_42
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_42
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_42
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_42
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_42
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_42
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_42
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_42
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_42
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_42
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_42
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_42
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_42
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_42
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_42
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_42
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_42
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(42) Then
                Readjobs.Position = Lv_cat_43
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_43
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_43
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_43
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_43
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_43
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_43
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_43
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_43
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_43
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_43
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_43
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_43
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_43
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_43
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_43
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_43
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_43
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_43
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_43
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(43) Then
                Readjobs.Position = Lv_cat_44
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_44
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_44
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_44
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_44
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_44
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_44
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_44
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_44
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_44
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_44
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_44
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_44
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_44
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_44
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_44
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_44
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_44
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_44
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_44
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(44) Then
                Readjobs.Position = Lv_cat_45
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_45
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_45
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_45
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_45
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_45
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_45
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_45
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_45
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_45
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_45
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_45
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_45
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_45
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_45
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_45
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_45
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_45
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_45
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_45
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(45) Then
                Readjobs.Position = Lv_cat_46
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_46
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_46
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_46
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_46
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_46
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_46
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_46
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_46
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_46
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_46
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_46
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_46
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_46
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_46
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_46
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_46
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_46
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_46
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_46
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(46) Then
                Readjobs.Position = Lv_cat_47
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_47
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_47
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_47
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_47
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_47
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_47
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_47
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_47
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_47
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_47
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_47
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_47
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_47
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_47
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_47
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_47
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_47
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_47
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_47
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(47) Then
                Readjobs.Position = Lv_cat_48
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_48
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_48
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_48
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_48
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_48
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_48
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_48
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_48
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_48
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_48
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_48
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_48
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_48
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_48
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_48
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_48
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_48
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_48
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_48
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(48) Then
                Readjobs.Position = Lv_cat_49
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_49
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_49
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_49
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_49
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_49
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_49
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_49
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_49
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_49
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_49
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_49
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_49
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_49
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_49
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_49
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_49
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_49
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_49
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_49
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(49) Then
                Readjobs.Position = Lv_cat_50
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_50
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_50
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_50
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_50
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_50
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_50
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_50
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_50
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_50
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_50
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_50
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_50
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_50
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_50
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_50
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_50
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_50
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_50
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_50
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(50) Then
                Readjobs.Position = Lv_cat_51
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_51
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_51
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_51
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_51
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_51
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_51
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_51
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_51
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_51
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_51
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_51
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_51
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_51
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_51
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_51
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_51
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_51
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_51
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_51
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(51) Then
                Readjobs.Position = Lv_cat_52
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_52
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_52
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_52
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_52
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_52
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_52
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_52
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_52
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_52
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_52
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_52
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_52
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_52
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_52
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_52
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_52
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_52
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_52
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_52
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(52) Then
                Readjobs.Position = Lv_cat_53
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_53
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_53
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_53
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_53
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_53
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_53
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_53
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_53
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_53
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_53
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_53
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_53
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_53
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_53
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_53
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_53
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_53
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_53
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_53
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(53) Then
                Readjobs.Position = Lv_cat_54
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_54
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_54
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_54
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_54
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_54
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_54
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_54
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_54
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_54
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_54
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_54
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_54
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_54
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_54
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_54
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_54
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_54
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_54
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_54
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(54) Then
                Readjobs.Position = Lv_cat_55
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_55
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_55
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_55
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_55
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_55
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_55
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_55
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_55
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_55
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_55
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_55
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_55
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_55
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_55
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_55
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_55
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_55
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_55
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_55
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(55) Then
                Readjobs.Position = Lv_cat_56
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_56
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_56
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_56
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_56
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_56
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_56
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_56
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_56
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_56
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_56
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_56
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_56
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_56
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_56
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_56
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_56
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_56
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_56
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_56
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(56) Then
                Readjobs.Position = Lv_cat_57
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_57
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_57
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_57
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_57
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_57
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_57
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_57
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_57
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_57
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_57
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_57
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_57
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_57
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_57
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_57
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_57
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_57
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_57
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_57
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(57) Then
                Readjobs.Position = Lv_cat_58
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_58
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_58
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_58
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_58
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_58
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_58
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_58
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_58
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_58
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_58
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_58
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_58
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_58
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_58
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_58
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_58
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_58
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_58
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_58
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(58) Then
                Readjobs.Position = Lv_cat_59
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_59
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_59
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_59
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_59
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_59
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_59
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_59
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_59
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_59
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_59
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_59
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_59
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_59
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_59
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_59
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_59
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_59
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_59
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_59
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(59) Then
                Readjobs.Position = Lv_cat_60
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_60
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_60
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_60
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_60
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_60
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_60
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_60
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_60
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_60
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_60
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_60
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_60
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_60
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_60
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_60
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_60
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_60
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_60
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_60
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(60) Then
                Readjobs.Position = Lv_cat_61
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_61
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_61
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_61
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_61
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_61
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_61
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_61
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_61
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_61
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_61
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_61
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_61
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_61
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_61
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_61
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_61
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_61
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_61
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_61
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(61) Then
                Readjobs.Position = Lv_cat_62
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_62
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_62
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_62
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_62
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_62
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_62
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_62
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_62
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_62
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_62
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_62
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_62
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_62
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_62
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_62
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_62
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_62
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_62
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_62
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(62) Then
                Readjobs.Position = Lv_cat_63
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_63
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_63
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_63
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_63
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_63
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_63
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_63
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_63
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_63
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_63
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_63
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_63
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_63
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_63
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_63
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_63
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_63
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_63
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_63
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(63) Then
                Readjobs.Position = Lv_cat_64
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_64
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_64
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_64
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_64
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_64
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_64
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_64
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_64
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_64
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_64
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_64
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_64
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_64
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_64
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_64
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_64
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_64
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_64
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_64
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(64) Then
                Readjobs.Position = Lv_cat_65
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_65
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_65
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_65
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_65
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_65
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_65
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_65
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_65
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_65
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_65
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_65
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_65
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_65
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_65
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_65
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_65
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_65
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_65
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_65
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(65) Then
                Readjobs.Position = Lv_cat_66
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_66
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_66
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_66
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_66
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_66
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_66
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_66
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_66
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_66
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_66
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_66
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_66
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_66
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_66
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_66
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_66
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_66
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_66
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_66
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(66) Then
                Readjobs.Position = Lv_cat_67
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_67
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_67
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_67
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_67
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_67
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_67
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_67
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_67
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_67
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_67
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_67
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_67
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_67
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_67
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_67
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_67
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_67
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_67
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_67
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(67) Then
                Readjobs.Position = Lv_cat_68
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_68
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_68
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_68
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_68
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_68
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_68
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_68
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_68
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_68
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_68
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_68
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_68
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_68
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_68
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_68
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_68
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_68
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_68
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_68
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(68) Then
                Readjobs.Position = Lv_cat_69
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_69
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_69
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_69
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_69
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_69
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_69
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_69
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_69
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_69
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_69
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_69
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_69
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_69
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_69
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_69
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_69
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_69
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_69
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_69
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(69) Then
                Readjobs.Position = Lv_cat_70
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_70
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_70
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_70
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_70
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_70
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_70
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_70
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_70
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_70
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_70
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_70
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_70
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_70
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_70
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_70
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_70
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_70
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_70
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_70
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(70) Then
                Readjobs.Position = Lv_cat_71
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_71
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_71
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_71
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_71
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_71
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_71
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_71
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_71
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_71
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_71
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_71
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_71
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_71
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_71
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_71
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_71
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_71
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_71
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_71
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(71) Then
                Readjobs.Position = Lv_cat_72
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_72
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_72
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_72
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_72
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_72
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_72
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_72
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_72
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_72
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_72
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_72
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_72
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_72
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_72
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_72
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_72
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_72
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_72
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_72
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(72) Then
                Readjobs.Position = Lv_cat_73
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_73
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_73
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_73
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_73
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_73
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_73
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_73
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_73
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_73
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_73
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_73
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_73
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_73
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_73
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_73
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_73
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_73
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_73
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_73
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(73) Then
                Readjobs.Position = Lv_cat_74
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_74
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_74
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_74
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_74
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_74
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_74
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_74
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_74
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_74
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_74
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_74
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_74
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_74
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_74
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_74
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_74
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_74
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_74
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_74
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(74) Then
                Readjobs.Position = Lv_cat_75
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_75
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_75
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_75
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_75
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_75
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_75
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_75
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_75
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_75
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_75
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_75
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_75
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_75
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_75
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_75
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_75
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_75
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_75
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_75
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(75) Then
                Readjobs.Position = Lv_cat_76
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_76
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_76
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_76
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_76
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_76
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_76
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_76
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_76
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_76
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_76
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_76
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_76
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_76
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_76
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_76
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_76
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_76
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_76
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_76
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(76) Then
                Readjobs.Position = Lv_cat_77
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_77
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_77
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_77
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_77
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_77
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_77
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_77
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_77
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_77
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_77
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_77
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_77
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_77
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_77
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_77
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_77
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_77
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_77
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_77
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(77) Then
                Readjobs.Position = Lv_cat_78
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_78
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_78
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_78
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_78
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_78
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_78
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_78
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_78
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_78
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_78
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_78
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_78
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_78
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_78
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_78
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_78
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_78
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_78
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_78
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(78) Then
                Readjobs.Position = Lv_cat_79
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_79
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_79
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_79
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_79
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_79
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_79
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_79
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_79
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_79
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_79
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_79
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_79
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_79
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_79
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_79
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_79
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_79
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_79
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_79
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(79) Then
                Readjobs.Position = Lv_cat_80
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_80
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_80
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_80
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_80
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_80
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_80
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_80
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_80
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_80
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_80
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_80
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_80
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_80
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_80
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_80
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_80
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_80
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_80
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_80
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(80) Then
                Readjobs.Position = Lv_cat_81
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_81
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_81
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_81
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_81
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_81
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_81
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_81
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_81
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_81
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_81
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_81
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_81
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_81
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_81
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_81
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_81
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_81
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_81
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_81
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(81) Then
                Readjobs.Position = Lv_cat_82
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_82
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_82
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_82
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_82
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_82
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_82
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_82
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_82
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_82
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_82
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_82
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_82
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_82
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_82
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_82
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_82
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_82
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_82
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_82
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(82) Then
                Readjobs.Position = Lv_cat_83
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_83
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_83
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_83
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_83
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_83
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_83
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_83
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_83
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_83
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_83
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_83
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_83
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_83
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_83
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_83
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_83
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_83
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_83
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_83
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(83) Then
                Readjobs.Position = Lv_cat_84
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_84
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_84
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_84
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_84
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_84
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_84
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_84
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_84
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_84
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_84
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_84
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_84
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_84
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_84
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_84
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_84
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_84
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_84
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_84
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(84) Then
                Readjobs.Position = Lv_cat_85
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_85
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_85
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_85
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_85
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_85
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_85
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_85
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_85
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_85
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_85
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_85
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_85
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_85
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_85
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_85
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_85
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_85
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_85
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_85
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(85) Then
                Readjobs.Position = Lv_cat_86
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_86
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_86
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_86
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_86
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_86
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_86
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_86
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_86
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_86
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_86
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_86
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_86
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_86
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_86
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_86
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_86
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_86
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_86
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_86
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(86) Then
                Readjobs.Position = Lv_cat_87
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_87
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_87
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_87
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_87
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_87
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_87
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_87
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_87
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_87
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_87
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_87
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_87
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_87
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_87
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_87
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_87
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_87
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_87
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_87
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(87) Then
                Readjobs.Position = Lv_cat_88
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_88
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_88
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_88
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_88
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_88
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_88
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_88
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_88
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_88
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_88
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_88
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_88
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_88
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_88
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_88
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_88
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_88
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_88
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_88
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(88) Then
                Readjobs.Position = Lv_cat_89
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_89
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_89
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_89
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_89
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_89
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_89
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_89
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_89
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_89
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_89
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_89
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_89
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_89
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_89
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_89
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_89
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_89
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_89
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_89
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(89) Then
                Readjobs.Position = Lv_cat_90
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_90
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_90
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_90
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_90
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_90
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_90
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_90
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_90
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_90
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_90
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_90
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_90
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_90
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_90
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_90
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_90
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_90
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_90
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_90
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(90) Then
                Readjobs.Position = Lv_cat_91
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_91
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_91
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_91
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_91
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_91
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_91
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_91
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_91
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_91
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_91
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_91
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_91
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_91
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_91
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_91
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_91
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_91
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_91
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_91
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(91) Then
                Readjobs.Position = Lv_cat_92
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_92
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_92
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_92
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_92
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_92
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_92
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_92
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_92
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_92
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_92
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_92
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_92
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_92
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_92
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_92
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_92
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_92
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_92
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_92
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(92) Then
                Readjobs.Position = Lv_cat_93
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_93
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_93
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_93
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_93
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_93
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_93
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_93
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_93
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_93
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_93
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_93
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_93
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_93
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_93
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_93
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_93
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_93
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_93
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_93
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(93) Then
                Readjobs.Position = Lv_cat_94
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_94
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_94
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_94
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_94
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_94
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_94
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_94
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_94
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_94
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_94
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_94
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_94
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_94
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_94
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_94
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_94
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_94
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_94
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_94
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(94) Then
                Readjobs.Position = Lv_cat_95
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_95
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_95
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_95
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_95
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_95
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_95
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_95
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_95
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_95
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_95
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_95
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_95
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_95
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_95
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_95
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_95
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_95
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_95
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_95
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(95) Then
                Readjobs.Position = Lv_cat_96
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_96
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_96
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_96
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_96
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_96
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_96
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_96
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_96
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_96
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_96
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_96
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_96
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_96
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_96
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_96
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_96
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_96
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_96
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_96
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(96) Then
                Readjobs.Position = Lv_cat_97
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_97
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_97
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_97
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_97
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_97
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_97
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_97
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_97
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_97
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_97
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_97
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_97
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_97
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_97
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_97
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_97
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_97
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_97
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_97
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(97) Then
                Readjobs.Position = Lv_cat_98
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_98
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_98
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_98
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_98
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_98
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_98
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_98
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_98
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_98
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_98
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_98
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_98
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_98
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_98
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_98
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_98
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_98
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_98
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_98
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(98) Then
                Readjobs.Position = Lv_cat_99
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_99
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_99
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_99
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_99
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_99
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_99
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_99
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_99
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_99
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_99
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_99
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_99
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_99
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_99
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_99
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_99
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_99
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_99
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_99
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items(99) Then
                Readjobs.Position = Lv_cat_100
                valu_exp_cat.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_chef_100
                valu_exp_chef.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_cleric_100
                valu_exp_cleric.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_elf_100
                valu_exp_elf.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_flower_100
                valu_exp_flower.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_imp_100
                valu_exp_imp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_mage_100
                valu_exp_mage.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_popstar_100
                valu_exp_popstar.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_princess_100
                valu_exp_princess.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_scientist_100
                valu_exp_scientist.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_tank_100
                valu_exp_tank.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_thief_100
                valu_exp_thief.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_vampire_100
                valu_exp_vampire.Value = Readjobs.ReadUInt32
                Readjobs.Position = Lv_warrior_100
                valu_exp_warrior.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_attack_100
                valu_foodexp_attack.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_defense_100
                valu_foodexp_defense.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_hp_100
                valu_foodexp_hp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_magic_100
                valu_foodexp_magic.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_mp_100
                valu_foodexp_mp.Value = Readjobs.ReadUInt32
                Readjobs.Position = Boost_speed_100
                valu_foodexp_speed.Value = Readjobs.ReadUInt32
            End If
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read Jobs levels and boosts of this Mii" & vbNewLine & "Retry or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub ReadMiiname()
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

    Private Sub MSE_jobslevelsboosts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadMiiname()
    End Sub

    Private Sub Select_exp_warrior_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_warrior.SelectedIndexChanged
        If Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(0) Then
            valu_exp_warrior.Value = 0
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(1) Then
            valu_exp_warrior.Value = 10
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(2) Then
            valu_exp_warrior.Value = 50
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(3) Then
            valu_exp_warrior.Value = 150
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(4) Then
            valu_exp_warrior.Value = 340
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(5) Then
            valu_exp_warrior.Value = 650
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(6) Then
            valu_exp_warrior.Value = 1140
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(7) Then
            valu_exp_warrior.Value = 1870
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(8) Then
            valu_exp_warrior.Value = 2920
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(9) Then
            valu_exp_warrior.Value = 4390
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(10) Then
            valu_exp_warrior.Value = 6390
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(11) Then
            valu_exp_warrior.Value = 9060
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(12) Then
            valu_exp_warrior.Value = 12570
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(13) Then
            valu_exp_warrior.Value = 17120
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(14) Then
            valu_exp_warrior.Value = 22920
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(15) Then
            valu_exp_warrior.Value = 30230
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(16) Then
            valu_exp_warrior.Value = 39340
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(17) Then
            valu_exp_warrior.Value = 50580
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(18) Then
            valu_exp_warrior.Value = 64320
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(19) Then
            valu_exp_warrior.Value = 80960
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(20) Then
            valu_exp_warrior.Value = 100960
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(21) Then
            valu_exp_warrior.Value = 124820
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(22) Then
            valu_exp_warrior.Value = 153090
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(23) Then
            valu_exp_warrior.Value = 186360
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(24) Then
            valu_exp_warrior.Value = 225300
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(25) Then
            valu_exp_warrior.Value = 270610
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(26) Then
            valu_exp_warrior.Value = 315920
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(27) Then
            valu_exp_warrior.Value = 361230
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(28) Then
            valu_exp_warrior.Value = 406540
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(29) Then
            valu_exp_warrior.Value = 451850
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(30) Then
            valu_exp_warrior.Value = 497160
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(31) Then
            valu_exp_warrior.Value = 545590
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(32) Then
            valu_exp_warrior.Value = 599690
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(33) Then
            valu_exp_warrior.Value = 659900
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(34) Then
            valu_exp_warrior.Value = 726690
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(35) Then
            valu_exp_warrior.Value = 800540
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(36) Then
            valu_exp_warrior.Value = 881950
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(37) Then
            valu_exp_warrior.Value = 971440
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(38) Then
            valu_exp_warrior.Value = 1069540
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(39) Then
            valu_exp_warrior.Value = 1176790
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(40) Then
            valu_exp_warrior.Value = 1293750
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(41) Then
            valu_exp_warrior.Value = 1420990
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(42) Then
            valu_exp_warrior.Value = 1559090
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(43) Then
            valu_exp_warrior.Value = 1708640
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(44) Then
            valu_exp_warrior.Value = 1870250
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(45) Then
            valu_exp_warrior.Value = 2044530
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(46) Then
            valu_exp_warrior.Value = 2232090
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(47) Then
            valu_exp_warrior.Value = 2448870
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(48) Then
            valu_exp_warrior.Value = 2698120
        ElseIf Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(49) Then
            valu_exp_warrior.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_mage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_mage.SelectedIndexChanged
        If Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(0) Then
            valu_exp_mage.Value = 0
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(1) Then
            valu_exp_mage.Value = 10
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(2) Then
            valu_exp_mage.Value = 50
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(3) Then
            valu_exp_mage.Value = 150
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(4) Then
            valu_exp_mage.Value = 340
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(5) Then
            valu_exp_mage.Value = 650
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(6) Then
            valu_exp_mage.Value = 1140
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(7) Then
            valu_exp_mage.Value = 1870
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(8) Then
            valu_exp_mage.Value = 2920
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(9) Then
            valu_exp_mage.Value = 4390
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(10) Then
            valu_exp_mage.Value = 6390
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(11) Then
            valu_exp_mage.Value = 9060
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(12) Then
            valu_exp_mage.Value = 12570
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(13) Then
            valu_exp_mage.Value = 17120
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(14) Then
            valu_exp_mage.Value = 22920
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(15) Then
            valu_exp_mage.Value = 30230
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(16) Then
            valu_exp_mage.Value = 39340
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(17) Then
            valu_exp_mage.Value = 50580
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(18) Then
            valu_exp_mage.Value = 64320
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(19) Then
            valu_exp_mage.Value = 80960
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(20) Then
            valu_exp_mage.Value = 100960
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(21) Then
            valu_exp_mage.Value = 124820
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(22) Then
            valu_exp_mage.Value = 153090
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(23) Then
            valu_exp_mage.Value = 186360
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(24) Then
            valu_exp_mage.Value = 225300
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(25) Then
            valu_exp_mage.Value = 270610
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(26) Then
            valu_exp_mage.Value = 315920
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(27) Then
            valu_exp_mage.Value = 361230
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(28) Then
            valu_exp_mage.Value = 406540
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(29) Then
            valu_exp_mage.Value = 451850
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(30) Then
            valu_exp_mage.Value = 497160
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(31) Then
            valu_exp_mage.Value = 545590
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(32) Then
            valu_exp_mage.Value = 599690
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(33) Then
            valu_exp_mage.Value = 659900
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(34) Then
            valu_exp_mage.Value = 726690
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(35) Then
            valu_exp_mage.Value = 800540
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(36) Then
            valu_exp_mage.Value = 881950
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(37) Then
            valu_exp_mage.Value = 971440
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(38) Then
            valu_exp_mage.Value = 1069540
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(39) Then
            valu_exp_mage.Value = 1176790
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(40) Then
            valu_exp_mage.Value = 1293750
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(41) Then
            valu_exp_mage.Value = 1420990
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(42) Then
            valu_exp_mage.Value = 1559090
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(43) Then
            valu_exp_mage.Value = 1708640
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(44) Then
            valu_exp_mage.Value = 1870250
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(45) Then
            valu_exp_mage.Value = 2044530
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(46) Then
            valu_exp_mage.Value = 2232090
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(47) Then
            valu_exp_mage.Value = 2448870
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(48) Then
            valu_exp_mage.Value = 2698120
        ElseIf Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(49) Then
            valu_exp_mage.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_cleric_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_cleric.SelectedIndexChanged
        If Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(0) Then
            valu_exp_cleric.Value = 0
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(1) Then
            valu_exp_cleric.Value = 10
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(2) Then
            valu_exp_cleric.Value = 50
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(3) Then
            valu_exp_cleric.Value = 150
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(4) Then
            valu_exp_cleric.Value = 340
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(5) Then
            valu_exp_cleric.Value = 650
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(6) Then
            valu_exp_cleric.Value = 1140
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(7) Then
            valu_exp_cleric.Value = 1870
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(8) Then
            valu_exp_cleric.Value = 2920
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(9) Then
            valu_exp_cleric.Value = 4390
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(10) Then
            valu_exp_cleric.Value = 6390
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(11) Then
            valu_exp_cleric.Value = 9060
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(12) Then
            valu_exp_cleric.Value = 12570
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(13) Then
            valu_exp_cleric.Value = 17120
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(14) Then
            valu_exp_cleric.Value = 22920
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(15) Then
            valu_exp_cleric.Value = 30230
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(16) Then
            valu_exp_cleric.Value = 39340
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(17) Then
            valu_exp_cleric.Value = 50580
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(18) Then
            valu_exp_cleric.Value = 64320
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(19) Then
            valu_exp_cleric.Value = 80960
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(20) Then
            valu_exp_cleric.Value = 100960
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(21) Then
            valu_exp_cleric.Value = 124820
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(22) Then
            valu_exp_cleric.Value = 153090
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(23) Then
            valu_exp_cleric.Value = 186360
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(24) Then
            valu_exp_cleric.Value = 225300
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(25) Then
            valu_exp_cleric.Value = 270610
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(26) Then
            valu_exp_cleric.Value = 315920
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(27) Then
            valu_exp_cleric.Value = 361230
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(28) Then
            valu_exp_cleric.Value = 406540
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(29) Then
            valu_exp_cleric.Value = 451850
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(30) Then
            valu_exp_cleric.Value = 497160
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(31) Then
            valu_exp_cleric.Value = 545590
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(32) Then
            valu_exp_cleric.Value = 599690
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(33) Then
            valu_exp_cleric.Value = 659900
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(34) Then
            valu_exp_cleric.Value = 726690
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(35) Then
            valu_exp_cleric.Value = 800540
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(36) Then
            valu_exp_cleric.Value = 881950
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(37) Then
            valu_exp_cleric.Value = 971440
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(38) Then
            valu_exp_cleric.Value = 1069540
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(39) Then
            valu_exp_cleric.Value = 1176790
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(40) Then
            valu_exp_cleric.Value = 1293750
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(41) Then
            valu_exp_cleric.Value = 1420990
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(42) Then
            valu_exp_cleric.Value = 1559090
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(43) Then
            valu_exp_cleric.Value = 1708640
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(44) Then
            valu_exp_cleric.Value = 1870250
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(45) Then
            valu_exp_cleric.Value = 2044530
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(46) Then
            valu_exp_cleric.Value = 2232090
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(47) Then
            valu_exp_cleric.Value = 2448870
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(48) Then
            valu_exp_cleric.Value = 2698120
        ElseIf Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(49) Then
            valu_exp_cleric.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_thief_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_thief.SelectedIndexChanged
        If Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(0) Then
            valu_exp_thief.Value = 0
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(1) Then
            valu_exp_thief.Value = 10
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(2) Then
            valu_exp_thief.Value = 50
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(3) Then
            valu_exp_thief.Value = 150
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(4) Then
            valu_exp_thief.Value = 340
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(5) Then
            valu_exp_thief.Value = 650
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(6) Then
            valu_exp_thief.Value = 1140
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(7) Then
            valu_exp_thief.Value = 1870
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(8) Then
            valu_exp_thief.Value = 2920
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(9) Then
            valu_exp_thief.Value = 4390
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(10) Then
            valu_exp_thief.Value = 6390
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(11) Then
            valu_exp_thief.Value = 9060
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(12) Then
            valu_exp_thief.Value = 12570
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(13) Then
            valu_exp_thief.Value = 17120
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(14) Then
            valu_exp_thief.Value = 22920
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(15) Then
            valu_exp_thief.Value = 30230
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(16) Then
            valu_exp_thief.Value = 39340
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(17) Then
            valu_exp_thief.Value = 50580
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(18) Then
            valu_exp_thief.Value = 64320
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(19) Then
            valu_exp_thief.Value = 80960
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(20) Then
            valu_exp_thief.Value = 100960
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(21) Then
            valu_exp_thief.Value = 124820
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(22) Then
            valu_exp_thief.Value = 153090
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(23) Then
            valu_exp_thief.Value = 186360
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(24) Then
            valu_exp_thief.Value = 225300
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(25) Then
            valu_exp_thief.Value = 270610
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(26) Then
            valu_exp_thief.Value = 315920
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(27) Then
            valu_exp_thief.Value = 361230
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(28) Then
            valu_exp_thief.Value = 406540
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(29) Then
            valu_exp_thief.Value = 451850
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(30) Then
            valu_exp_thief.Value = 497160
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(31) Then
            valu_exp_thief.Value = 545590
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(32) Then
            valu_exp_thief.Value = 599690
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(33) Then
            valu_exp_thief.Value = 659900
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(34) Then
            valu_exp_thief.Value = 726690
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(35) Then
            valu_exp_thief.Value = 800540
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(36) Then
            valu_exp_thief.Value = 881950
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(37) Then
            valu_exp_thief.Value = 971440
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(38) Then
            valu_exp_thief.Value = 1069540
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(39) Then
            valu_exp_thief.Value = 1176790
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(40) Then
            valu_exp_thief.Value = 1293750
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(41) Then
            valu_exp_thief.Value = 1420990
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(42) Then
            valu_exp_thief.Value = 1559090
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(43) Then
            valu_exp_thief.Value = 1708640
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(44) Then
            valu_exp_thief.Value = 1870250
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(45) Then
            valu_exp_thief.Value = 2044530
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(46) Then
            valu_exp_thief.Value = 2232090
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(47) Then
            valu_exp_thief.Value = 2448870
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(48) Then
            valu_exp_thief.Value = 2698120
        ElseIf Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(49) Then
            valu_exp_thief.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_popstar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_popstar.SelectedIndexChanged
        If Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(0) Then
            valu_exp_popstar.Value = 0
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(1) Then
            valu_exp_popstar.Value = 10
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(2) Then
            valu_exp_popstar.Value = 50
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(3) Then
            valu_exp_popstar.Value = 150
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(4) Then
            valu_exp_popstar.Value = 340
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(5) Then
            valu_exp_popstar.Value = 650
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(6) Then
            valu_exp_popstar.Value = 1140
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(7) Then
            valu_exp_popstar.Value = 1870
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(8) Then
            valu_exp_popstar.Value = 2920
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(9) Then
            valu_exp_popstar.Value = 4390
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(10) Then
            valu_exp_popstar.Value = 6390
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(11) Then
            valu_exp_popstar.Value = 9060
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(12) Then
            valu_exp_popstar.Value = 12570
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(13) Then
            valu_exp_popstar.Value = 17120
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(14) Then
            valu_exp_popstar.Value = 22920
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(15) Then
            valu_exp_popstar.Value = 30230
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(16) Then
            valu_exp_popstar.Value = 39340
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(17) Then
            valu_exp_popstar.Value = 50580
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(18) Then
            valu_exp_popstar.Value = 64320
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(19) Then
            valu_exp_popstar.Value = 80960
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(20) Then
            valu_exp_popstar.Value = 100960
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(21) Then
            valu_exp_popstar.Value = 124820
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(22) Then
            valu_exp_popstar.Value = 153090
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(23) Then
            valu_exp_popstar.Value = 186360
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(24) Then
            valu_exp_popstar.Value = 225300
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(25) Then
            valu_exp_popstar.Value = 270610
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(26) Then
            valu_exp_popstar.Value = 315920
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(27) Then
            valu_exp_popstar.Value = 361230
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(28) Then
            valu_exp_popstar.Value = 406540
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(29) Then
            valu_exp_popstar.Value = 451850
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(30) Then
            valu_exp_popstar.Value = 497160
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(31) Then
            valu_exp_popstar.Value = 545590
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(32) Then
            valu_exp_popstar.Value = 599690
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(33) Then
            valu_exp_popstar.Value = 659900
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(34) Then
            valu_exp_popstar.Value = 726690
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(35) Then
            valu_exp_popstar.Value = 800540
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(36) Then
            valu_exp_popstar.Value = 881950
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(37) Then
            valu_exp_popstar.Value = 971440
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(38) Then
            valu_exp_popstar.Value = 1069540
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(39) Then
            valu_exp_popstar.Value = 1176790
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(40) Then
            valu_exp_popstar.Value = 1293750
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(41) Then
            valu_exp_popstar.Value = 1420990
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(42) Then
            valu_exp_popstar.Value = 1559090
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(43) Then
            valu_exp_popstar.Value = 1708640
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(44) Then
            valu_exp_popstar.Value = 1870250
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(45) Then
            valu_exp_popstar.Value = 2044530
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(46) Then
            valu_exp_popstar.Value = 2232090
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(47) Then
            valu_exp_popstar.Value = 2448870
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(48) Then
            valu_exp_popstar.Value = 2698120
        ElseIf Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(49) Then
            valu_exp_popstar.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_vampire_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_vampire.SelectedIndexChanged
        If Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(0) Then
            valu_exp_vampire.Value = 0
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(1) Then
            valu_exp_vampire.Value = 10
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(2) Then
            valu_exp_vampire.Value = 50
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(3) Then
            valu_exp_vampire.Value = 150
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(4) Then
            valu_exp_vampire.Value = 340
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(5) Then
            valu_exp_vampire.Value = 650
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(6) Then
            valu_exp_vampire.Value = 1140
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(7) Then
            valu_exp_vampire.Value = 1870
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(8) Then
            valu_exp_vampire.Value = 2920
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(9) Then
            valu_exp_vampire.Value = 4390
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(10) Then
            valu_exp_vampire.Value = 6390
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(11) Then
            valu_exp_vampire.Value = 9060
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(12) Then
            valu_exp_vampire.Value = 12570
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(13) Then
            valu_exp_vampire.Value = 17120
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(14) Then
            valu_exp_vampire.Value = 22920
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(15) Then
            valu_exp_vampire.Value = 30230
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(16) Then
            valu_exp_vampire.Value = 39340
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(17) Then
            valu_exp_vampire.Value = 50580
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(18) Then
            valu_exp_vampire.Value = 64320
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(19) Then
            valu_exp_vampire.Value = 80960
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(20) Then
            valu_exp_vampire.Value = 100960
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(21) Then
            valu_exp_vampire.Value = 124820
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(22) Then
            valu_exp_vampire.Value = 153090
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(23) Then
            valu_exp_vampire.Value = 186360
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(24) Then
            valu_exp_vampire.Value = 225300
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(25) Then
            valu_exp_vampire.Value = 270610
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(26) Then
            valu_exp_vampire.Value = 315920
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(27) Then
            valu_exp_vampire.Value = 361230
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(28) Then
            valu_exp_vampire.Value = 406540
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(29) Then
            valu_exp_vampire.Value = 451850
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(30) Then
            valu_exp_vampire.Value = 497160
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(31) Then
            valu_exp_vampire.Value = 545590
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(32) Then
            valu_exp_vampire.Value = 599690
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(33) Then
            valu_exp_vampire.Value = 659900
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(34) Then
            valu_exp_vampire.Value = 726690
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(35) Then
            valu_exp_vampire.Value = 800540
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(36) Then
            valu_exp_vampire.Value = 881950
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(37) Then
            valu_exp_vampire.Value = 971440
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(38) Then
            valu_exp_vampire.Value = 1069540
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(39) Then
            valu_exp_vampire.Value = 1176790
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(40) Then
            valu_exp_vampire.Value = 1293750
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(41) Then
            valu_exp_vampire.Value = 1420990
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(42) Then
            valu_exp_vampire.Value = 1559090
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(43) Then
            valu_exp_vampire.Value = 1708640
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(44) Then
            valu_exp_vampire.Value = 1870250
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(45) Then
            valu_exp_vampire.Value = 2044530
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(46) Then
            valu_exp_vampire.Value = 2232090
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(47) Then
            valu_exp_vampire.Value = 2448870
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(48) Then
            valu_exp_vampire.Value = 2698120
        ElseIf Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(49) Then
            valu_exp_vampire.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_chef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_chef.SelectedIndexChanged
        If Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(0) Then
            valu_exp_chef.Value = 0
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(1) Then
            valu_exp_chef.Value = 10
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(2) Then
            valu_exp_chef.Value = 50
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(3) Then
            valu_exp_chef.Value = 150
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(4) Then
            valu_exp_chef.Value = 340
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(5) Then
            valu_exp_chef.Value = 650
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(6) Then
            valu_exp_chef.Value = 1140
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(7) Then
            valu_exp_chef.Value = 1870
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(8) Then
            valu_exp_chef.Value = 2920
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(9) Then
            valu_exp_chef.Value = 4390
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(10) Then
            valu_exp_chef.Value = 6390
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(11) Then
            valu_exp_chef.Value = 9060
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(12) Then
            valu_exp_chef.Value = 12570
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(13) Then
            valu_exp_chef.Value = 17120
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(14) Then
            valu_exp_chef.Value = 22920
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(15) Then
            valu_exp_chef.Value = 30230
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(16) Then
            valu_exp_chef.Value = 39340
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(17) Then
            valu_exp_chef.Value = 50580
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(18) Then
            valu_exp_chef.Value = 64320
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(19) Then
            valu_exp_chef.Value = 80960
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(20) Then
            valu_exp_chef.Value = 100960
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(21) Then
            valu_exp_chef.Value = 124820
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(22) Then
            valu_exp_chef.Value = 153090
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(23) Then
            valu_exp_chef.Value = 186360
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(24) Then
            valu_exp_chef.Value = 225300
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(25) Then
            valu_exp_chef.Value = 270610
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(26) Then
            valu_exp_chef.Value = 315920
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(27) Then
            valu_exp_chef.Value = 361230
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(28) Then
            valu_exp_chef.Value = 406540
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(29) Then
            valu_exp_chef.Value = 451850
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(30) Then
            valu_exp_chef.Value = 497160
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(31) Then
            valu_exp_chef.Value = 545590
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(32) Then
            valu_exp_chef.Value = 599690
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(33) Then
            valu_exp_chef.Value = 659900
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(34) Then
            valu_exp_chef.Value = 726690
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(35) Then
            valu_exp_chef.Value = 800540
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(36) Then
            valu_exp_chef.Value = 881950
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(37) Then
            valu_exp_chef.Value = 971440
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(38) Then
            valu_exp_chef.Value = 1069540
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(39) Then
            valu_exp_chef.Value = 1176790
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(40) Then
            valu_exp_chef.Value = 1293750
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(41) Then
            valu_exp_chef.Value = 1420990
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(42) Then
            valu_exp_chef.Value = 1559090
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(43) Then
            valu_exp_chef.Value = 1708640
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(44) Then
            valu_exp_chef.Value = 1870250
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(45) Then
            valu_exp_chef.Value = 2044530
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(46) Then
            valu_exp_chef.Value = 2232090
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(47) Then
            valu_exp_chef.Value = 2448870
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(48) Then
            valu_exp_chef.Value = 2698120
        ElseIf Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(49) Then
            valu_exp_chef.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_tank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_tank.SelectedIndexChanged
        If Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(0) Then
            valu_exp_tank.Value = 0
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(1) Then
            valu_exp_tank.Value = 10
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(2) Then
            valu_exp_tank.Value = 50
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(3) Then
            valu_exp_tank.Value = 150
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(4) Then
            valu_exp_tank.Value = 340
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(5) Then
            valu_exp_tank.Value = 650
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(6) Then
            valu_exp_tank.Value = 1140
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(7) Then
            valu_exp_tank.Value = 1870
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(8) Then
            valu_exp_tank.Value = 2920
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(9) Then
            valu_exp_tank.Value = 4390
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(10) Then
            valu_exp_tank.Value = 6390
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(11) Then
            valu_exp_tank.Value = 9060
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(12) Then
            valu_exp_tank.Value = 12570
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(13) Then
            valu_exp_tank.Value = 17120
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(14) Then
            valu_exp_tank.Value = 22920
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(15) Then
            valu_exp_tank.Value = 30230
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(16) Then
            valu_exp_tank.Value = 39340
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(17) Then
            valu_exp_tank.Value = 50580
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(18) Then
            valu_exp_tank.Value = 64320
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(19) Then
            valu_exp_tank.Value = 80960
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(20) Then
            valu_exp_tank.Value = 100960
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(21) Then
            valu_exp_tank.Value = 124820
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(22) Then
            valu_exp_tank.Value = 153090
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(23) Then
            valu_exp_tank.Value = 186360
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(24) Then
            valu_exp_tank.Value = 225300
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(25) Then
            valu_exp_tank.Value = 270610
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(26) Then
            valu_exp_tank.Value = 315920
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(27) Then
            valu_exp_tank.Value = 361230
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(28) Then
            valu_exp_tank.Value = 406540
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(29) Then
            valu_exp_tank.Value = 451850
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(30) Then
            valu_exp_tank.Value = 497160
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(31) Then
            valu_exp_tank.Value = 545590
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(32) Then
            valu_exp_tank.Value = 599690
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(33) Then
            valu_exp_tank.Value = 659900
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(34) Then
            valu_exp_tank.Value = 726690
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(35) Then
            valu_exp_tank.Value = 800540
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(36) Then
            valu_exp_tank.Value = 881950
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(37) Then
            valu_exp_tank.Value = 971440
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(38) Then
            valu_exp_tank.Value = 1069540
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(39) Then
            valu_exp_tank.Value = 1176790
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(40) Then
            valu_exp_tank.Value = 1293750
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(41) Then
            valu_exp_tank.Value = 1420990
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(42) Then
            valu_exp_tank.Value = 1559090
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(43) Then
            valu_exp_tank.Value = 1708640
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(44) Then
            valu_exp_tank.Value = 1870250
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(45) Then
            valu_exp_tank.Value = 2044530
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(46) Then
            valu_exp_tank.Value = 2232090
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(47) Then
            valu_exp_tank.Value = 2448870
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(48) Then
            valu_exp_tank.Value = 2698120
        ElseIf Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(49) Then
            valu_exp_tank.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_imp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_imp.SelectedIndexChanged
        If Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(0) Then
            valu_exp_imp.Value = 0
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(1) Then
            valu_exp_imp.Value = 10
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(2) Then
            valu_exp_imp.Value = 50
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(3) Then
            valu_exp_imp.Value = 150
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(4) Then
            valu_exp_imp.Value = 340
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(5) Then
            valu_exp_imp.Value = 650
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(6) Then
            valu_exp_imp.Value = 1140
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(7) Then
            valu_exp_imp.Value = 1870
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(8) Then
            valu_exp_imp.Value = 2920
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(9) Then
            valu_exp_imp.Value = 4390
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(10) Then
            valu_exp_imp.Value = 6390
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(11) Then
            valu_exp_imp.Value = 9060
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(12) Then
            valu_exp_imp.Value = 12570
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(13) Then
            valu_exp_imp.Value = 17120
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(14) Then
            valu_exp_imp.Value = 22920
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(15) Then
            valu_exp_imp.Value = 30230
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(16) Then
            valu_exp_imp.Value = 39340
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(17) Then
            valu_exp_imp.Value = 50580
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(18) Then
            valu_exp_imp.Value = 64320
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(19) Then
            valu_exp_imp.Value = 80960
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(20) Then
            valu_exp_imp.Value = 100960
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(21) Then
            valu_exp_imp.Value = 124820
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(22) Then
            valu_exp_imp.Value = 153090
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(23) Then
            valu_exp_imp.Value = 186360
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(24) Then
            valu_exp_imp.Value = 225300
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(25) Then
            valu_exp_imp.Value = 270610
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(26) Then
            valu_exp_imp.Value = 315920
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(27) Then
            valu_exp_imp.Value = 361230
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(28) Then
            valu_exp_imp.Value = 406540
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(29) Then
            valu_exp_imp.Value = 451850
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(30) Then
            valu_exp_imp.Value = 497160
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(31) Then
            valu_exp_imp.Value = 545590
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(32) Then
            valu_exp_imp.Value = 599690
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(33) Then
            valu_exp_imp.Value = 659900
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(34) Then
            valu_exp_imp.Value = 726690
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(35) Then
            valu_exp_imp.Value = 800540
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(36) Then
            valu_exp_imp.Value = 881950
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(37) Then
            valu_exp_imp.Value = 971440
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(38) Then
            valu_exp_imp.Value = 1069540
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(39) Then
            valu_exp_imp.Value = 1176790
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(40) Then
            valu_exp_imp.Value = 1293750
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(41) Then
            valu_exp_imp.Value = 1420990
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(42) Then
            valu_exp_imp.Value = 1559090
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(43) Then
            valu_exp_imp.Value = 1708640
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(44) Then
            valu_exp_imp.Value = 1870250
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(45) Then
            valu_exp_imp.Value = 2044530
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(46) Then
            valu_exp_imp.Value = 2232090
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(47) Then
            valu_exp_imp.Value = 2448870
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(48) Then
            valu_exp_imp.Value = 2698120
        ElseIf Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(49) Then
            valu_exp_imp.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_princess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_princess.SelectedIndexChanged
        If Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(0) Then
            valu_exp_princess.Value = 0
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(1) Then
            valu_exp_princess.Value = 10
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(2) Then
            valu_exp_princess.Value = 50
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(3) Then
            valu_exp_princess.Value = 150
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(4) Then
            valu_exp_princess.Value = 340
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(5) Then
            valu_exp_princess.Value = 650
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(6) Then
            valu_exp_princess.Value = 1140
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(7) Then
            valu_exp_princess.Value = 1870
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(8) Then
            valu_exp_princess.Value = 2920
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(9) Then
            valu_exp_princess.Value = 4390
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(10) Then
            valu_exp_princess.Value = 6390
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(11) Then
            valu_exp_princess.Value = 9060
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(12) Then
            valu_exp_princess.Value = 12570
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(13) Then
            valu_exp_princess.Value = 17120
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(14) Then
            valu_exp_princess.Value = 22920
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(15) Then
            valu_exp_princess.Value = 30230
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(16) Then
            valu_exp_princess.Value = 39340
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(17) Then
            valu_exp_princess.Value = 50580
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(18) Then
            valu_exp_princess.Value = 64320
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(19) Then
            valu_exp_princess.Value = 80960
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(20) Then
            valu_exp_princess.Value = 100960
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(21) Then
            valu_exp_princess.Value = 124820
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(22) Then
            valu_exp_princess.Value = 153090
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(23) Then
            valu_exp_princess.Value = 186360
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(24) Then
            valu_exp_princess.Value = 225300
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(25) Then
            valu_exp_princess.Value = 270610
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(26) Then
            valu_exp_princess.Value = 315920
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(27) Then
            valu_exp_princess.Value = 361230
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(28) Then
            valu_exp_princess.Value = 406540
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(29) Then
            valu_exp_princess.Value = 451850
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(30) Then
            valu_exp_princess.Value = 497160
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(31) Then
            valu_exp_princess.Value = 545590
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(32) Then
            valu_exp_princess.Value = 599690
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(33) Then
            valu_exp_princess.Value = 659900
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(34) Then
            valu_exp_princess.Value = 726690
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(35) Then
            valu_exp_princess.Value = 800540
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(36) Then
            valu_exp_princess.Value = 881950
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(37) Then
            valu_exp_princess.Value = 971440
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(38) Then
            valu_exp_princess.Value = 1069540
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(39) Then
            valu_exp_princess.Value = 1176790
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(40) Then
            valu_exp_princess.Value = 1293750
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(41) Then
            valu_exp_princess.Value = 1420990
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(42) Then
            valu_exp_princess.Value = 1559090
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(43) Then
            valu_exp_princess.Value = 1708640
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(44) Then
            valu_exp_princess.Value = 1870250
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(45) Then
            valu_exp_princess.Value = 2044530
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(46) Then
            valu_exp_princess.Value = 2232090
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(47) Then
            valu_exp_princess.Value = 2448870
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(48) Then
            valu_exp_princess.Value = 2698120
        ElseIf Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(49) Then
            valu_exp_princess.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_flower_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_flower.SelectedIndexChanged
        If Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(0) Then
            valu_exp_flower.Value = 0
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(1) Then
            valu_exp_flower.Value = 10
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(2) Then
            valu_exp_flower.Value = 50
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(3) Then
            valu_exp_flower.Value = 150
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(4) Then
            valu_exp_flower.Value = 340
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(5) Then
            valu_exp_flower.Value = 650
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(6) Then
            valu_exp_flower.Value = 1140
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(7) Then
            valu_exp_flower.Value = 1870
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(8) Then
            valu_exp_flower.Value = 2920
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(9) Then
            valu_exp_flower.Value = 4390
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(10) Then
            valu_exp_flower.Value = 6390
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(11) Then
            valu_exp_flower.Value = 9060
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(12) Then
            valu_exp_flower.Value = 12570
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(13) Then
            valu_exp_flower.Value = 17120
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(14) Then
            valu_exp_flower.Value = 22920
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(15) Then
            valu_exp_flower.Value = 30230
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(16) Then
            valu_exp_flower.Value = 39340
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(17) Then
            valu_exp_flower.Value = 50580
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(18) Then
            valu_exp_flower.Value = 64320
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(19) Then
            valu_exp_flower.Value = 80960
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(20) Then
            valu_exp_flower.Value = 100960
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(21) Then
            valu_exp_flower.Value = 124820
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(22) Then
            valu_exp_flower.Value = 153090
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(23) Then
            valu_exp_flower.Value = 186360
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(24) Then
            valu_exp_flower.Value = 225300
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(25) Then
            valu_exp_flower.Value = 270610
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(26) Then
            valu_exp_flower.Value = 315920
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(27) Then
            valu_exp_flower.Value = 361230
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(28) Then
            valu_exp_flower.Value = 406540
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(29) Then
            valu_exp_flower.Value = 451850
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(30) Then
            valu_exp_flower.Value = 497160
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(31) Then
            valu_exp_flower.Value = 545590
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(32) Then
            valu_exp_flower.Value = 599690
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(33) Then
            valu_exp_flower.Value = 659900
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(34) Then
            valu_exp_flower.Value = 726690
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(35) Then
            valu_exp_flower.Value = 800540
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(36) Then
            valu_exp_flower.Value = 881950
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(37) Then
            valu_exp_flower.Value = 971440
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(38) Then
            valu_exp_flower.Value = 1069540
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(39) Then
            valu_exp_flower.Value = 1176790
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(40) Then
            valu_exp_flower.Value = 1293750
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(41) Then
            valu_exp_flower.Value = 1420990
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(42) Then
            valu_exp_flower.Value = 1559090
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(43) Then
            valu_exp_flower.Value = 1708640
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(44) Then
            valu_exp_flower.Value = 1870250
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(45) Then
            valu_exp_flower.Value = 2044530
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(46) Then
            valu_exp_flower.Value = 2232090
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(47) Then
            valu_exp_flower.Value = 2448870
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(48) Then
            valu_exp_flower.Value = 2698120
        ElseIf Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(49) Then
            valu_exp_flower.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_scientist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_scientist.SelectedIndexChanged
        If Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(0) Then
            valu_exp_scientist.Value = 0
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(1) Then
            valu_exp_scientist.Value = 10
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(2) Then
            valu_exp_scientist.Value = 50
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(3) Then
            valu_exp_scientist.Value = 150
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(4) Then
            valu_exp_scientist.Value = 340
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(5) Then
            valu_exp_scientist.Value = 650
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(6) Then
            valu_exp_scientist.Value = 1140
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(7) Then
            valu_exp_scientist.Value = 1870
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(8) Then
            valu_exp_scientist.Value = 2920
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(9) Then
            valu_exp_scientist.Value = 4390
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(10) Then
            valu_exp_scientist.Value = 6390
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(11) Then
            valu_exp_scientist.Value = 9060
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(12) Then
            valu_exp_scientist.Value = 12570
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(13) Then
            valu_exp_scientist.Value = 17120
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(14) Then
            valu_exp_scientist.Value = 22920
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(15) Then
            valu_exp_scientist.Value = 30230
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(16) Then
            valu_exp_scientist.Value = 39340
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(17) Then
            valu_exp_scientist.Value = 50580
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(18) Then
            valu_exp_scientist.Value = 64320
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(19) Then
            valu_exp_scientist.Value = 80960
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(20) Then
            valu_exp_scientist.Value = 100960
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(21) Then
            valu_exp_scientist.Value = 124820
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(22) Then
            valu_exp_scientist.Value = 153090
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(23) Then
            valu_exp_scientist.Value = 186360
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(24) Then
            valu_exp_scientist.Value = 225300
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(25) Then
            valu_exp_scientist.Value = 270610
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(26) Then
            valu_exp_scientist.Value = 315920
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(27) Then
            valu_exp_scientist.Value = 361230
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(28) Then
            valu_exp_scientist.Value = 406540
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(29) Then
            valu_exp_scientist.Value = 451850
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(30) Then
            valu_exp_scientist.Value = 497160
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(31) Then
            valu_exp_scientist.Value = 545590
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(32) Then
            valu_exp_scientist.Value = 599690
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(33) Then
            valu_exp_scientist.Value = 659900
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(34) Then
            valu_exp_scientist.Value = 726690
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(35) Then
            valu_exp_scientist.Value = 800540
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(36) Then
            valu_exp_scientist.Value = 881950
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(37) Then
            valu_exp_scientist.Value = 971440
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(38) Then
            valu_exp_scientist.Value = 1069540
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(39) Then
            valu_exp_scientist.Value = 1176790
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(40) Then
            valu_exp_scientist.Value = 1293750
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(41) Then
            valu_exp_scientist.Value = 1420990
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(42) Then
            valu_exp_scientist.Value = 1559090
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(43) Then
            valu_exp_scientist.Value = 1708640
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(44) Then
            valu_exp_scientist.Value = 1870250
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(45) Then
            valu_exp_scientist.Value = 2044530
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(46) Then
            valu_exp_scientist.Value = 2232090
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(47) Then
            valu_exp_scientist.Value = 2448870
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(48) Then
            valu_exp_scientist.Value = 2698120
        ElseIf Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(49) Then
            valu_exp_scientist.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_cat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_cat.SelectedIndexChanged
        If Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(0) Then
            valu_exp_cat.Value = 0
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(1) Then
            valu_exp_cat.Value = 10
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(2) Then
            valu_exp_cat.Value = 50
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(3) Then
            valu_exp_cat.Value = 150
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(4) Then
            valu_exp_cat.Value = 340
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(5) Then
            valu_exp_cat.Value = 650
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(6) Then
            valu_exp_cat.Value = 1140
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(7) Then
            valu_exp_cat.Value = 1870
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(8) Then
            valu_exp_cat.Value = 2920
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(9) Then
            valu_exp_cat.Value = 4390
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(10) Then
            valu_exp_cat.Value = 6390
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(11) Then
            valu_exp_cat.Value = 9060
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(12) Then
            valu_exp_cat.Value = 12570
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(13) Then
            valu_exp_cat.Value = 17120
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(14) Then
            valu_exp_cat.Value = 22920
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(15) Then
            valu_exp_cat.Value = 30230
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(16) Then
            valu_exp_cat.Value = 39340
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(17) Then
            valu_exp_cat.Value = 50580
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(18) Then
            valu_exp_cat.Value = 64320
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(19) Then
            valu_exp_cat.Value = 80960
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(20) Then
            valu_exp_cat.Value = 100960
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(21) Then
            valu_exp_cat.Value = 124820
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(22) Then
            valu_exp_cat.Value = 153090
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(23) Then
            valu_exp_cat.Value = 186360
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(24) Then
            valu_exp_cat.Value = 225300
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(25) Then
            valu_exp_cat.Value = 270610
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(26) Then
            valu_exp_cat.Value = 315920
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(27) Then
            valu_exp_cat.Value = 361230
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(28) Then
            valu_exp_cat.Value = 406540
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(29) Then
            valu_exp_cat.Value = 451850
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(30) Then
            valu_exp_cat.Value = 497160
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(31) Then
            valu_exp_cat.Value = 545590
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(32) Then
            valu_exp_cat.Value = 599690
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(33) Then
            valu_exp_cat.Value = 659900
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(34) Then
            valu_exp_cat.Value = 726690
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(35) Then
            valu_exp_cat.Value = 800540
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(36) Then
            valu_exp_cat.Value = 881950
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(37) Then
            valu_exp_cat.Value = 971440
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(38) Then
            valu_exp_cat.Value = 1069540
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(39) Then
            valu_exp_cat.Value = 1176790
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(40) Then
            valu_exp_cat.Value = 1293750
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(41) Then
            valu_exp_cat.Value = 1420990
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(42) Then
            valu_exp_cat.Value = 1559090
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(43) Then
            valu_exp_cat.Value = 1708640
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(44) Then
            valu_exp_cat.Value = 1870250
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(45) Then
            valu_exp_cat.Value = 2044530
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(46) Then
            valu_exp_cat.Value = 2232090
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(47) Then
            valu_exp_cat.Value = 2448870
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(48) Then
            valu_exp_cat.Value = 2698120
        ElseIf Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(49) Then
            valu_exp_cat.Value = 2983350
        End If
    End Sub

    Private Sub Select_exp_elf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_exp_elf.SelectedIndexChanged
        If Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(0) Then
            valu_exp_elf.Value = 0
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(1) Then
            valu_exp_elf.Value = 10
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(2) Then
            valu_exp_elf.Value = 50
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(3) Then
            valu_exp_elf.Value = 150
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(4) Then
            valu_exp_elf.Value = 340
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(5) Then
            valu_exp_elf.Value = 650
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(6) Then
            valu_exp_elf.Value = 1140
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(7) Then
            valu_exp_elf.Value = 1870
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(8) Then
            valu_exp_elf.Value = 2920
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(9) Then
            valu_exp_elf.Value = 4390
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(10) Then
            valu_exp_elf.Value = 6390
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(11) Then
            valu_exp_elf.Value = 9060
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(12) Then
            valu_exp_elf.Value = 12570
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(13) Then
            valu_exp_elf.Value = 17120
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(14) Then
            valu_exp_elf.Value = 22920
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(15) Then
            valu_exp_elf.Value = 30230
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(16) Then
            valu_exp_elf.Value = 39340
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(17) Then
            valu_exp_elf.Value = 50580
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(18) Then
            valu_exp_elf.Value = 64320
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(19) Then
            valu_exp_elf.Value = 80960
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(20) Then
            valu_exp_elf.Value = 100960
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(21) Then
            valu_exp_elf.Value = 124820
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(22) Then
            valu_exp_elf.Value = 153090
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(23) Then
            valu_exp_elf.Value = 186360
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(24) Then
            valu_exp_elf.Value = 225300
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(25) Then
            valu_exp_elf.Value = 270610
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(26) Then
            valu_exp_elf.Value = 315920
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(27) Then
            valu_exp_elf.Value = 361230
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(28) Then
            valu_exp_elf.Value = 406540
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(29) Then
            valu_exp_elf.Value = 451850
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(30) Then
            valu_exp_elf.Value = 497160
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(31) Then
            valu_exp_elf.Value = 545590
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(32) Then
            valu_exp_elf.Value = 599690
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(33) Then
            valu_exp_elf.Value = 659900
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(34) Then
            valu_exp_elf.Value = 726690
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(35) Then
            valu_exp_elf.Value = 800540
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(36) Then
            valu_exp_elf.Value = 881950
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(37) Then
            valu_exp_elf.Value = 971440
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(38) Then
            valu_exp_elf.Value = 1069540
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(39) Then
            valu_exp_elf.Value = 1176790
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(40) Then
            valu_exp_elf.Value = 1293750
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(41) Then
            valu_exp_elf.Value = 1420990
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(42) Then
            valu_exp_elf.Value = 1559090
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(43) Then
            valu_exp_elf.Value = 1708640
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(44) Then
            valu_exp_elf.Value = 1870250
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(45) Then
            valu_exp_elf.Value = 2044530
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(46) Then
            valu_exp_elf.Value = 2232090
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(47) Then
            valu_exp_elf.Value = 2448870
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(48) Then
            valu_exp_elf.Value = 2698120
        ElseIf Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(49) Then
            valu_exp_elf.Value = 2983350
        End If
    End Sub

    Private Sub valu_exp_warrior_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_warrior.ValueChanged
        If valu_exp_warrior.Value > 0 And valu_exp_warrior.Value < 10 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(0)
        ElseIf valu_exp_warrior.Value >= 10 And valu_exp_warrior.Value < 50 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(1)
        ElseIf valu_exp_warrior.Value >= 50 And valu_exp_warrior.Value < 150 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(2)
        ElseIf valu_exp_warrior.Value >= 150 And valu_exp_warrior.Value < 340 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(3)
        ElseIf valu_exp_warrior.Value >= 340 And valu_exp_warrior.Value < 650 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(4)
        ElseIf valu_exp_warrior.Value >= 650 And valu_exp_warrior.Value < 1140 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(5)
        ElseIf valu_exp_warrior.Value >= 1140 And valu_exp_warrior.Value < 1870 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(6)
        ElseIf valu_exp_warrior.Value >= 1870 And valu_exp_warrior.Value < 2920 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(7)
        ElseIf valu_exp_warrior.Value >= 2920 And valu_exp_warrior.Value < 4390 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(8)
        ElseIf valu_exp_warrior.Value >= 4390 And valu_exp_warrior.Value < 6390 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(9)
        ElseIf valu_exp_warrior.Value >= 6390 And valu_exp_warrior.Value < 9060 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(10)
        ElseIf valu_exp_warrior.Value >= 9060 And valu_exp_warrior.Value < 12570 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(11)
        ElseIf valu_exp_warrior.Value >= 12570 And valu_exp_warrior.Value < 17120 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(12)
        ElseIf valu_exp_warrior.Value >= 17120 And valu_exp_warrior.Value < 22920 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(13)
        ElseIf valu_exp_warrior.Value >= 22920 And valu_exp_warrior.Value < 30230 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(14)
        ElseIf valu_exp_warrior.Value >= 30230 And valu_exp_warrior.Value < 39340 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(15)
        ElseIf valu_exp_warrior.Value >= 39340 And valu_exp_warrior.Value < 50580 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(16)
        ElseIf valu_exp_warrior.Value >= 50580 And valu_exp_warrior.Value < 64320 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(17)
        ElseIf valu_exp_warrior.Value >= 64320 And valu_exp_warrior.Value < 80960 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(18)
        ElseIf valu_exp_warrior.Value >= 80960 And valu_exp_warrior.Value < 100960 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(19)
        ElseIf valu_exp_warrior.Value >= 100960 And valu_exp_warrior.Value < 124820 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(20)
        ElseIf valu_exp_warrior.Value >= 124820 And valu_exp_warrior.Value < 153090 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(21)
        ElseIf valu_exp_warrior.Value >= 153090 And valu_exp_warrior.Value < 186360 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(22)
        ElseIf valu_exp_warrior.Value >= 186360 And valu_exp_warrior.Value < 225300 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(23)
        ElseIf valu_exp_warrior.Value >= 225300 And valu_exp_warrior.Value < 270610 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(24)
        ElseIf valu_exp_warrior.Value >= 270610 And valu_exp_warrior.Value < 315920 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(25)
        ElseIf valu_exp_warrior.Value >= 315920 And valu_exp_warrior.Value < 361230 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(26)
        ElseIf valu_exp_warrior.Value >= 361230 And valu_exp_warrior.Value < 406540 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(27)
        ElseIf valu_exp_warrior.Value >= 406540 And valu_exp_warrior.Value < 451850 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(28)
        ElseIf valu_exp_warrior.Value >= 451850 And valu_exp_warrior.Value < 497160 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(29)
        ElseIf valu_exp_warrior.Value >= 497160 And valu_exp_warrior.Value < 545590 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(30)
        ElseIf valu_exp_warrior.Value >= 545590 And valu_exp_warrior.Value < 599690 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(31)
        ElseIf valu_exp_warrior.Value >= 599690 And valu_exp_warrior.Value < 659900 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(32)
        ElseIf valu_exp_warrior.Value >= 659900 And valu_exp_warrior.Value < 726690 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(33)
        ElseIf valu_exp_warrior.Value >= 726690 And valu_exp_warrior.Value < 800540 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(34)
        ElseIf valu_exp_warrior.Value >= 800540 And valu_exp_warrior.Value < 881950 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(35)
        ElseIf valu_exp_warrior.Value >= 881950 And valu_exp_warrior.Value < 971440 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(36)
        ElseIf valu_exp_warrior.Value >= 971440 And valu_exp_warrior.Value < 1069540 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(37)
        ElseIf valu_exp_warrior.Value >= 1069540 And valu_exp_warrior.Value < 1176790 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(38)
        ElseIf valu_exp_warrior.Value >= 1176790 And valu_exp_warrior.Value < 1293750 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(39)
        ElseIf valu_exp_warrior.Value >= 1293750 And valu_exp_warrior.Value < 1420990 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(40)
        ElseIf valu_exp_warrior.Value >= 1420990 And valu_exp_warrior.Value < 1559090 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(41)
        ElseIf valu_exp_warrior.Value >= 1559090 And valu_exp_warrior.Value < 1708640 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(42)
        ElseIf valu_exp_warrior.Value >= 1708640 And valu_exp_warrior.Value < 1870250 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(43)
        ElseIf valu_exp_warrior.Value >= 1870250 And valu_exp_warrior.Value < 2044530 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(44)
        ElseIf valu_exp_warrior.Value >= 2044530 And valu_exp_warrior.Value < 2232090 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(45)
        ElseIf valu_exp_warrior.Value >= 2232090 And valu_exp_warrior.Value < 2448870 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(46)
        ElseIf valu_exp_warrior.Value >= 2448870 And valu_exp_warrior.Value < 2698120 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(47)
        ElseIf valu_exp_warrior.Value >= 2698120 And valu_exp_warrior.Value < 2983350 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(48)
        ElseIf valu_exp_warrior.Value >= 2983350 Then
            Select_exp_warrior.SelectedItem = Select_exp_warrior.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_mage_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_mage.ValueChanged
        If valu_exp_mage.Value > 0 And valu_exp_mage.Value < 10 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(0)
        ElseIf valu_exp_mage.Value >= 10 And valu_exp_mage.Value < 50 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(1)
        ElseIf valu_exp_mage.Value >= 50 And valu_exp_mage.Value < 150 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(2)
        ElseIf valu_exp_mage.Value >= 150 And valu_exp_mage.Value < 340 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(3)
        ElseIf valu_exp_mage.Value >= 340 And valu_exp_mage.Value < 650 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(4)
        ElseIf valu_exp_mage.Value >= 650 And valu_exp_mage.Value < 1140 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(5)
        ElseIf valu_exp_mage.Value >= 1140 And valu_exp_mage.Value < 1870 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(6)
        ElseIf valu_exp_mage.Value >= 1870 And valu_exp_mage.Value < 2920 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(7)
        ElseIf valu_exp_mage.Value >= 2920 And valu_exp_mage.Value < 4390 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(8)
        ElseIf valu_exp_mage.Value >= 4390 And valu_exp_mage.Value < 6390 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(9)
        ElseIf valu_exp_mage.Value >= 6390 And valu_exp_mage.Value < 9060 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(10)
        ElseIf valu_exp_mage.Value >= 9060 And valu_exp_mage.Value < 12570 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(11)
        ElseIf valu_exp_mage.Value >= 12570 And valu_exp_mage.Value < 17120 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(12)
        ElseIf valu_exp_mage.Value >= 17120 And valu_exp_mage.Value < 22920 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(13)
        ElseIf valu_exp_mage.Value >= 22920 And valu_exp_mage.Value < 30230 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(14)
        ElseIf valu_exp_mage.Value >= 30230 And valu_exp_mage.Value < 39340 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(15)
        ElseIf valu_exp_mage.Value >= 39340 And valu_exp_mage.Value < 50580 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(16)
        ElseIf valu_exp_mage.Value >= 50580 And valu_exp_mage.Value < 64320 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(17)
        ElseIf valu_exp_mage.Value >= 64320 And valu_exp_mage.Value < 80960 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(18)
        ElseIf valu_exp_mage.Value >= 80960 And valu_exp_mage.Value < 100960 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(19)
        ElseIf valu_exp_mage.Value >= 100960 And valu_exp_mage.Value < 124820 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(20)
        ElseIf valu_exp_mage.Value >= 124820 And valu_exp_mage.Value < 153090 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(21)
        ElseIf valu_exp_mage.Value >= 153090 And valu_exp_mage.Value < 186360 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(22)
        ElseIf valu_exp_mage.Value >= 186360 And valu_exp_mage.Value < 225300 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(23)
        ElseIf valu_exp_mage.Value >= 225300 And valu_exp_mage.Value < 270610 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(24)
        ElseIf valu_exp_mage.Value >= 270610 And valu_exp_mage.Value < 315920 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(25)
        ElseIf valu_exp_mage.Value >= 315920 And valu_exp_mage.Value < 361230 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(26)
        ElseIf valu_exp_mage.Value >= 361230 And valu_exp_mage.Value < 406540 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(27)
        ElseIf valu_exp_mage.Value >= 406540 And valu_exp_mage.Value < 451850 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(28)
        ElseIf valu_exp_mage.Value >= 451850 And valu_exp_mage.Value < 497160 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(29)
        ElseIf valu_exp_mage.Value >= 497160 And valu_exp_mage.Value < 545590 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(30)
        ElseIf valu_exp_mage.Value >= 545590 And valu_exp_mage.Value < 599690 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(31)
        ElseIf valu_exp_mage.Value >= 599690 And valu_exp_mage.Value < 659900 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(32)
        ElseIf valu_exp_mage.Value >= 659900 And valu_exp_mage.Value < 726690 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(33)
        ElseIf valu_exp_mage.Value >= 726690 And valu_exp_mage.Value < 800540 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(34)
        ElseIf valu_exp_mage.Value >= 800540 And valu_exp_mage.Value < 881950 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(35)
        ElseIf valu_exp_mage.Value >= 881950 And valu_exp_mage.Value < 971440 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(36)
        ElseIf valu_exp_mage.Value >= 971440 And valu_exp_mage.Value < 1069540 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(37)
        ElseIf valu_exp_mage.Value >= 1069540 And valu_exp_mage.Value < 1176790 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(38)
        ElseIf valu_exp_mage.Value >= 1176790 And valu_exp_mage.Value < 1293750 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(39)
        ElseIf valu_exp_mage.Value >= 1293750 And valu_exp_mage.Value < 1420990 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(40)
        ElseIf valu_exp_mage.Value >= 1420990 And valu_exp_mage.Value < 1559090 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(41)
        ElseIf valu_exp_mage.Value >= 1559090 And valu_exp_mage.Value < 1708640 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(42)
        ElseIf valu_exp_mage.Value >= 1708640 And valu_exp_mage.Value < 1870250 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(43)
        ElseIf valu_exp_mage.Value >= 1870250 And valu_exp_mage.Value < 2044530 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(44)
        ElseIf valu_exp_mage.Value >= 2044530 And valu_exp_mage.Value < 2232090 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(45)
        ElseIf valu_exp_mage.Value >= 2232090 And valu_exp_mage.Value < 2448870 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(46)
        ElseIf valu_exp_mage.Value >= 2448870 And valu_exp_mage.Value < 2698120 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(47)
        ElseIf valu_exp_mage.Value >= 2698120 And valu_exp_mage.Value < 2983350 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(48)
        ElseIf valu_exp_mage.Value >= 2983350 Then
            Select_exp_mage.SelectedItem = Select_exp_mage.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_cleric_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_cleric.ValueChanged
        If valu_exp_cleric.Value > 0 And valu_exp_cleric.Value < 10 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(0)
        ElseIf valu_exp_cleric.Value >= 10 And valu_exp_cleric.Value < 50 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(1)
        ElseIf valu_exp_cleric.Value >= 50 And valu_exp_cleric.Value < 150 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(2)
        ElseIf valu_exp_cleric.Value >= 150 And valu_exp_cleric.Value < 340 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(3)
        ElseIf valu_exp_cleric.Value >= 340 And valu_exp_cleric.Value < 650 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(4)
        ElseIf valu_exp_cleric.Value >= 650 And valu_exp_cleric.Value < 1140 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(5)
        ElseIf valu_exp_cleric.Value >= 1140 And valu_exp_cleric.Value < 1870 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(6)
        ElseIf valu_exp_cleric.Value >= 1870 And valu_exp_cleric.Value < 2920 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(7)
        ElseIf valu_exp_cleric.Value >= 2920 And valu_exp_cleric.Value < 4390 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(8)
        ElseIf valu_exp_cleric.Value >= 4390 And valu_exp_cleric.Value < 6390 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(9)
        ElseIf valu_exp_cleric.Value >= 6390 And valu_exp_cleric.Value < 9060 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(10)
        ElseIf valu_exp_cleric.Value >= 9060 And valu_exp_cleric.Value < 12570 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(11)
        ElseIf valu_exp_cleric.Value >= 12570 And valu_exp_cleric.Value < 17120 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(12)
        ElseIf valu_exp_cleric.Value >= 17120 And valu_exp_cleric.Value < 22920 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(13)
        ElseIf valu_exp_cleric.Value >= 22920 And valu_exp_cleric.Value < 30230 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(14)
        ElseIf valu_exp_cleric.Value >= 30230 And valu_exp_cleric.Value < 39340 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(15)
        ElseIf valu_exp_cleric.Value >= 39340 And valu_exp_cleric.Value < 50580 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(16)
        ElseIf valu_exp_cleric.Value >= 50580 And valu_exp_cleric.Value < 64320 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(17)
        ElseIf valu_exp_cleric.Value >= 64320 And valu_exp_cleric.Value < 80960 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(18)
        ElseIf valu_exp_cleric.Value >= 80960 And valu_exp_cleric.Value < 100960 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(19)
        ElseIf valu_exp_cleric.Value >= 100960 And valu_exp_cleric.Value < 124820 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(20)
        ElseIf valu_exp_cleric.Value >= 124820 And valu_exp_cleric.Value < 153090 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(21)
        ElseIf valu_exp_cleric.Value >= 153090 And valu_exp_cleric.Value < 186360 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(22)
        ElseIf valu_exp_cleric.Value >= 186360 And valu_exp_cleric.Value < 225300 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(23)
        ElseIf valu_exp_cleric.Value >= 225300 And valu_exp_cleric.Value < 270610 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(24)
        ElseIf valu_exp_cleric.Value >= 270610 And valu_exp_cleric.Value < 315920 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(25)
        ElseIf valu_exp_cleric.Value >= 315920 And valu_exp_cleric.Value < 361230 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(26)
        ElseIf valu_exp_cleric.Value >= 361230 And valu_exp_cleric.Value < 406540 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(27)
        ElseIf valu_exp_cleric.Value >= 406540 And valu_exp_cleric.Value < 451850 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(28)
        ElseIf valu_exp_cleric.Value >= 451850 And valu_exp_cleric.Value < 497160 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(29)
        ElseIf valu_exp_cleric.Value >= 497160 And valu_exp_cleric.Value < 545590 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(30)
        ElseIf valu_exp_cleric.Value >= 545590 And valu_exp_cleric.Value < 599690 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(31)
        ElseIf valu_exp_cleric.Value >= 599690 And valu_exp_cleric.Value < 659900 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(32)
        ElseIf valu_exp_cleric.Value >= 659900 And valu_exp_cleric.Value < 726690 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(33)
        ElseIf valu_exp_cleric.Value >= 726690 And valu_exp_cleric.Value < 800540 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(34)
        ElseIf valu_exp_cleric.Value >= 800540 And valu_exp_cleric.Value < 881950 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(35)
        ElseIf valu_exp_cleric.Value >= 881950 And valu_exp_cleric.Value < 971440 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(36)
        ElseIf valu_exp_cleric.Value >= 971440 And valu_exp_cleric.Value < 1069540 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(37)
        ElseIf valu_exp_cleric.Value >= 1069540 And valu_exp_cleric.Value < 1176790 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(38)
        ElseIf valu_exp_cleric.Value >= 1176790 And valu_exp_cleric.Value < 1293750 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(39)
        ElseIf valu_exp_cleric.Value >= 1293750 And valu_exp_cleric.Value < 1420990 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(40)
        ElseIf valu_exp_cleric.Value >= 1420990 And valu_exp_cleric.Value < 1559090 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(41)
        ElseIf valu_exp_cleric.Value >= 1559090 And valu_exp_cleric.Value < 1708640 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(42)
        ElseIf valu_exp_cleric.Value >= 1708640 And valu_exp_cleric.Value < 1870250 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(43)
        ElseIf valu_exp_cleric.Value >= 1870250 And valu_exp_cleric.Value < 2044530 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(44)
        ElseIf valu_exp_cleric.Value >= 2044530 And valu_exp_cleric.Value < 2232090 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(45)
        ElseIf valu_exp_cleric.Value >= 2232090 And valu_exp_cleric.Value < 2448870 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(46)
        ElseIf valu_exp_cleric.Value >= 2448870 And valu_exp_cleric.Value < 2698120 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(47)
        ElseIf valu_exp_cleric.Value >= 2698120 And valu_exp_cleric.Value < 2983350 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(48)
        ElseIf valu_exp_cleric.Value >= 2983350 Then
            Select_exp_cleric.SelectedItem = Select_exp_cleric.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_thief_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_thief.ValueChanged
        If valu_exp_thief.Value > 0 And valu_exp_thief.Value < 10 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(0)
        ElseIf valu_exp_thief.Value >= 10 And valu_exp_thief.Value < 50 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(1)
        ElseIf valu_exp_thief.Value >= 50 And valu_exp_thief.Value < 150 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(2)
        ElseIf valu_exp_thief.Value >= 150 And valu_exp_thief.Value < 340 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(3)
        ElseIf valu_exp_thief.Value >= 340 And valu_exp_thief.Value < 650 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(4)
        ElseIf valu_exp_thief.Value >= 650 And valu_exp_thief.Value < 1140 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(5)
        ElseIf valu_exp_thief.Value >= 1140 And valu_exp_thief.Value < 1870 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(6)
        ElseIf valu_exp_thief.Value >= 1870 And valu_exp_thief.Value < 2920 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(7)
        ElseIf valu_exp_thief.Value >= 2920 And valu_exp_thief.Value < 4390 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(8)
        ElseIf valu_exp_thief.Value >= 4390 And valu_exp_thief.Value < 6390 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(9)
        ElseIf valu_exp_thief.Value >= 6390 And valu_exp_thief.Value < 9060 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(10)
        ElseIf valu_exp_thief.Value >= 9060 And valu_exp_thief.Value < 12570 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(11)
        ElseIf valu_exp_thief.Value >= 12570 And valu_exp_thief.Value < 17120 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(12)
        ElseIf valu_exp_thief.Value >= 17120 And valu_exp_thief.Value < 22920 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(13)
        ElseIf valu_exp_thief.Value >= 22920 And valu_exp_thief.Value < 30230 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(14)
        ElseIf valu_exp_thief.Value >= 30230 And valu_exp_thief.Value < 39340 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(15)
        ElseIf valu_exp_thief.Value >= 39340 And valu_exp_thief.Value < 50580 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(16)
        ElseIf valu_exp_thief.Value >= 50580 And valu_exp_thief.Value < 64320 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(17)
        ElseIf valu_exp_thief.Value >= 64320 And valu_exp_thief.Value < 80960 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(18)
        ElseIf valu_exp_thief.Value >= 80960 And valu_exp_thief.Value < 100960 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(19)
        ElseIf valu_exp_thief.Value >= 100960 And valu_exp_thief.Value < 124820 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(20)
        ElseIf valu_exp_thief.Value >= 124820 And valu_exp_thief.Value < 153090 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(21)
        ElseIf valu_exp_thief.Value >= 153090 And valu_exp_thief.Value < 186360 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(22)
        ElseIf valu_exp_thief.Value >= 186360 And valu_exp_thief.Value < 225300 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(23)
        ElseIf valu_exp_thief.Value >= 225300 And valu_exp_thief.Value < 270610 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(24)
        ElseIf valu_exp_thief.Value >= 270610 And valu_exp_thief.Value < 315920 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(25)
        ElseIf valu_exp_thief.Value >= 315920 And valu_exp_thief.Value < 361230 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(26)
        ElseIf valu_exp_thief.Value >= 361230 And valu_exp_thief.Value < 406540 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(27)
        ElseIf valu_exp_thief.Value >= 406540 And valu_exp_thief.Value < 451850 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(28)
        ElseIf valu_exp_thief.Value >= 451850 And valu_exp_thief.Value < 497160 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(29)
        ElseIf valu_exp_thief.Value >= 497160 And valu_exp_thief.Value < 545590 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(30)
        ElseIf valu_exp_thief.Value >= 545590 And valu_exp_thief.Value < 599690 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(31)
        ElseIf valu_exp_thief.Value >= 599690 And valu_exp_thief.Value < 659900 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(32)
        ElseIf valu_exp_thief.Value >= 659900 And valu_exp_thief.Value < 726690 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(33)
        ElseIf valu_exp_thief.Value >= 726690 And valu_exp_thief.Value < 800540 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(34)
        ElseIf valu_exp_thief.Value >= 800540 And valu_exp_thief.Value < 881950 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(35)
        ElseIf valu_exp_thief.Value >= 881950 And valu_exp_thief.Value < 971440 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(36)
        ElseIf valu_exp_thief.Value >= 971440 And valu_exp_thief.Value < 1069540 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(37)
        ElseIf valu_exp_thief.Value >= 1069540 And valu_exp_thief.Value < 1176790 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(38)
        ElseIf valu_exp_thief.Value >= 1176790 And valu_exp_thief.Value < 1293750 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(39)
        ElseIf valu_exp_thief.Value >= 1293750 And valu_exp_thief.Value < 1420990 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(40)
        ElseIf valu_exp_thief.Value >= 1420990 And valu_exp_thief.Value < 1559090 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(41)
        ElseIf valu_exp_thief.Value >= 1559090 And valu_exp_thief.Value < 1708640 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(42)
        ElseIf valu_exp_thief.Value >= 1708640 And valu_exp_thief.Value < 1870250 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(43)
        ElseIf valu_exp_thief.Value >= 1870250 And valu_exp_thief.Value < 2044530 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(44)
        ElseIf valu_exp_thief.Value >= 2044530 And valu_exp_thief.Value < 2232090 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(45)
        ElseIf valu_exp_thief.Value >= 2232090 And valu_exp_thief.Value < 2448870 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(46)
        ElseIf valu_exp_thief.Value >= 2448870 And valu_exp_thief.Value < 2698120 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(47)
        ElseIf valu_exp_thief.Value >= 2698120 And valu_exp_thief.Value < 2983350 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(48)
        ElseIf valu_exp_thief.Value >= 2983350 Then
            Select_exp_thief.SelectedItem = Select_exp_thief.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_popstar_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_popstar.ValueChanged
        If valu_exp_popstar.Value > 0 And valu_exp_popstar.Value < 10 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(0)
        ElseIf valu_exp_popstar.Value >= 10 And valu_exp_popstar.Value < 50 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(1)
        ElseIf valu_exp_popstar.Value >= 50 And valu_exp_popstar.Value < 150 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(2)
        ElseIf valu_exp_popstar.Value >= 150 And valu_exp_popstar.Value < 340 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(3)
        ElseIf valu_exp_popstar.Value >= 340 And valu_exp_popstar.Value < 650 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(4)
        ElseIf valu_exp_popstar.Value >= 650 And valu_exp_popstar.Value < 1140 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(5)
        ElseIf valu_exp_popstar.Value >= 1140 And valu_exp_popstar.Value < 1870 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(6)
        ElseIf valu_exp_popstar.Value >= 1870 And valu_exp_popstar.Value < 2920 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(7)
        ElseIf valu_exp_popstar.Value >= 2920 And valu_exp_popstar.Value < 4390 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(8)
        ElseIf valu_exp_popstar.Value >= 4390 And valu_exp_popstar.Value < 6390 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(9)
        ElseIf valu_exp_popstar.Value >= 6390 And valu_exp_popstar.Value < 9060 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(10)
        ElseIf valu_exp_popstar.Value >= 9060 And valu_exp_popstar.Value < 12570 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(11)
        ElseIf valu_exp_popstar.Value >= 12570 And valu_exp_popstar.Value < 17120 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(12)
        ElseIf valu_exp_popstar.Value >= 17120 And valu_exp_popstar.Value < 22920 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(13)
        ElseIf valu_exp_popstar.Value >= 22920 And valu_exp_popstar.Value < 30230 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(14)
        ElseIf valu_exp_popstar.Value >= 30230 And valu_exp_popstar.Value < 39340 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(15)
        ElseIf valu_exp_popstar.Value >= 39340 And valu_exp_popstar.Value < 50580 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(16)
        ElseIf valu_exp_popstar.Value >= 50580 And valu_exp_popstar.Value < 64320 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(17)
        ElseIf valu_exp_popstar.Value >= 64320 And valu_exp_popstar.Value < 80960 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(18)
        ElseIf valu_exp_popstar.Value >= 80960 And valu_exp_popstar.Value < 100960 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(19)
        ElseIf valu_exp_popstar.Value >= 100960 And valu_exp_popstar.Value < 124820 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(20)
        ElseIf valu_exp_popstar.Value >= 124820 And valu_exp_popstar.Value < 153090 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(21)
        ElseIf valu_exp_popstar.Value >= 153090 And valu_exp_popstar.Value < 186360 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(22)
        ElseIf valu_exp_popstar.Value >= 186360 And valu_exp_popstar.Value < 225300 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(23)
        ElseIf valu_exp_popstar.Value >= 225300 And valu_exp_popstar.Value < 270610 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(24)
        ElseIf valu_exp_popstar.Value >= 270610 And valu_exp_popstar.Value < 315920 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(25)
        ElseIf valu_exp_popstar.Value >= 315920 And valu_exp_popstar.Value < 361230 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(26)
        ElseIf valu_exp_popstar.Value >= 361230 And valu_exp_popstar.Value < 406540 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(27)
        ElseIf valu_exp_popstar.Value >= 406540 And valu_exp_popstar.Value < 451850 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(28)
        ElseIf valu_exp_popstar.Value >= 451850 And valu_exp_popstar.Value < 497160 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(29)
        ElseIf valu_exp_popstar.Value >= 497160 And valu_exp_popstar.Value < 545590 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(30)
        ElseIf valu_exp_popstar.Value >= 545590 And valu_exp_popstar.Value < 599690 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(31)
        ElseIf valu_exp_popstar.Value >= 599690 And valu_exp_popstar.Value < 659900 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(32)
        ElseIf valu_exp_popstar.Value >= 659900 And valu_exp_popstar.Value < 726690 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(33)
        ElseIf valu_exp_popstar.Value >= 726690 And valu_exp_popstar.Value < 800540 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(34)
        ElseIf valu_exp_popstar.Value >= 800540 And valu_exp_popstar.Value < 881950 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(35)
        ElseIf valu_exp_popstar.Value >= 881950 And valu_exp_popstar.Value < 971440 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(36)
        ElseIf valu_exp_popstar.Value >= 971440 And valu_exp_popstar.Value < 1069540 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(37)
        ElseIf valu_exp_popstar.Value >= 1069540 And valu_exp_popstar.Value < 1176790 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(38)
        ElseIf valu_exp_popstar.Value >= 1176790 And valu_exp_popstar.Value < 1293750 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(39)
        ElseIf valu_exp_popstar.Value >= 1293750 And valu_exp_popstar.Value < 1420990 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(40)
        ElseIf valu_exp_popstar.Value >= 1420990 And valu_exp_popstar.Value < 1559090 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(41)
        ElseIf valu_exp_popstar.Value >= 1559090 And valu_exp_popstar.Value < 1708640 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(42)
        ElseIf valu_exp_popstar.Value >= 1708640 And valu_exp_popstar.Value < 1870250 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(43)
        ElseIf valu_exp_popstar.Value >= 1870250 And valu_exp_popstar.Value < 2044530 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(44)
        ElseIf valu_exp_popstar.Value >= 2044530 And valu_exp_popstar.Value < 2232090 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(45)
        ElseIf valu_exp_popstar.Value >= 2232090 And valu_exp_popstar.Value < 2448870 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(46)
        ElseIf valu_exp_popstar.Value >= 2448870 And valu_exp_popstar.Value < 2698120 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(47)
        ElseIf valu_exp_popstar.Value >= 2698120 And valu_exp_popstar.Value < 2983350 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(48)
        ElseIf valu_exp_popstar.Value >= 2983350 Then
            Select_exp_popstar.SelectedItem = Select_exp_popstar.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_vampire_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_vampire.ValueChanged
        If valu_exp_vampire.Value > 0 And valu_exp_vampire.Value < 10 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(0)
        ElseIf valu_exp_vampire.Value >= 10 And valu_exp_vampire.Value < 50 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(1)
        ElseIf valu_exp_vampire.Value >= 50 And valu_exp_vampire.Value < 150 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(2)
        ElseIf valu_exp_vampire.Value >= 150 And valu_exp_vampire.Value < 340 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(3)
        ElseIf valu_exp_vampire.Value >= 340 And valu_exp_vampire.Value < 650 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(4)
        ElseIf valu_exp_vampire.Value >= 650 And valu_exp_vampire.Value < 1140 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(5)
        ElseIf valu_exp_vampire.Value >= 1140 And valu_exp_vampire.Value < 1870 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(6)
        ElseIf valu_exp_vampire.Value >= 1870 And valu_exp_vampire.Value < 2920 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(7)
        ElseIf valu_exp_vampire.Value >= 2920 And valu_exp_vampire.Value < 4390 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(8)
        ElseIf valu_exp_vampire.Value >= 4390 And valu_exp_vampire.Value < 6390 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(9)
        ElseIf valu_exp_vampire.Value >= 6390 And valu_exp_vampire.Value < 9060 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(10)
        ElseIf valu_exp_vampire.Value >= 9060 And valu_exp_vampire.Value < 12570 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(11)
        ElseIf valu_exp_vampire.Value >= 12570 And valu_exp_vampire.Value < 17120 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(12)
        ElseIf valu_exp_vampire.Value >= 17120 And valu_exp_vampire.Value < 22920 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(13)
        ElseIf valu_exp_vampire.Value >= 22920 And valu_exp_vampire.Value < 30230 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(14)
        ElseIf valu_exp_vampire.Value >= 30230 And valu_exp_vampire.Value < 39340 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(15)
        ElseIf valu_exp_vampire.Value >= 39340 And valu_exp_vampire.Value < 50580 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(16)
        ElseIf valu_exp_vampire.Value >= 50580 And valu_exp_vampire.Value < 64320 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(17)
        ElseIf valu_exp_vampire.Value >= 64320 And valu_exp_vampire.Value < 80960 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(18)
        ElseIf valu_exp_vampire.Value >= 80960 And valu_exp_vampire.Value < 100960 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(19)
        ElseIf valu_exp_vampire.Value >= 100960 And valu_exp_vampire.Value < 124820 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(20)
        ElseIf valu_exp_vampire.Value >= 124820 And valu_exp_vampire.Value < 153090 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(21)
        ElseIf valu_exp_vampire.Value >= 153090 And valu_exp_vampire.Value < 186360 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(22)
        ElseIf valu_exp_vampire.Value >= 186360 And valu_exp_vampire.Value < 225300 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(23)
        ElseIf valu_exp_vampire.Value >= 225300 And valu_exp_vampire.Value < 270610 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(24)
        ElseIf valu_exp_vampire.Value >= 270610 And valu_exp_vampire.Value < 315920 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(25)
        ElseIf valu_exp_vampire.Value >= 315920 And valu_exp_vampire.Value < 361230 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(26)
        ElseIf valu_exp_vampire.Value >= 361230 And valu_exp_vampire.Value < 406540 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(27)
        ElseIf valu_exp_vampire.Value >= 406540 And valu_exp_vampire.Value < 451850 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(28)
        ElseIf valu_exp_vampire.Value >= 451850 And valu_exp_vampire.Value < 497160 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(29)
        ElseIf valu_exp_vampire.Value >= 497160 And valu_exp_vampire.Value < 545590 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(30)
        ElseIf valu_exp_vampire.Value >= 545590 And valu_exp_vampire.Value < 599690 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(31)
        ElseIf valu_exp_vampire.Value >= 599690 And valu_exp_vampire.Value < 659900 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(32)
        ElseIf valu_exp_vampire.Value >= 659900 And valu_exp_vampire.Value < 726690 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(33)
        ElseIf valu_exp_vampire.Value >= 726690 And valu_exp_vampire.Value < 800540 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(34)
        ElseIf valu_exp_vampire.Value >= 800540 And valu_exp_vampire.Value < 881950 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(35)
        ElseIf valu_exp_vampire.Value >= 881950 And valu_exp_vampire.Value < 971440 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(36)
        ElseIf valu_exp_vampire.Value >= 971440 And valu_exp_vampire.Value < 1069540 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(37)
        ElseIf valu_exp_vampire.Value >= 1069540 And valu_exp_vampire.Value < 1176790 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(38)
        ElseIf valu_exp_vampire.Value >= 1176790 And valu_exp_vampire.Value < 1293750 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(39)
        ElseIf valu_exp_vampire.Value >= 1293750 And valu_exp_vampire.Value < 1420990 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(40)
        ElseIf valu_exp_vampire.Value >= 1420990 And valu_exp_vampire.Value < 1559090 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(41)
        ElseIf valu_exp_vampire.Value >= 1559090 And valu_exp_vampire.Value < 1708640 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(42)
        ElseIf valu_exp_vampire.Value >= 1708640 And valu_exp_vampire.Value < 1870250 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(43)
        ElseIf valu_exp_vampire.Value >= 1870250 And valu_exp_vampire.Value < 2044530 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(44)
        ElseIf valu_exp_vampire.Value >= 2044530 And valu_exp_vampire.Value < 2232090 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(45)
        ElseIf valu_exp_vampire.Value >= 2232090 And valu_exp_vampire.Value < 2448870 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(46)
        ElseIf valu_exp_vampire.Value >= 2448870 And valu_exp_vampire.Value < 2698120 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(47)
        ElseIf valu_exp_vampire.Value >= 2698120 And valu_exp_vampire.Value < 2983350 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(48)
        ElseIf valu_exp_vampire.Value >= 2983350 Then
            Select_exp_vampire.SelectedItem = Select_exp_vampire.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_chef_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_chef.ValueChanged
        If valu_exp_chef.Value > 0 And valu_exp_chef.Value < 10 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(0)
        ElseIf valu_exp_chef.Value >= 10 And valu_exp_chef.Value < 50 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(1)
        ElseIf valu_exp_chef.Value >= 50 And valu_exp_chef.Value < 150 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(2)
        ElseIf valu_exp_chef.Value >= 150 And valu_exp_chef.Value < 340 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(3)
        ElseIf valu_exp_chef.Value >= 340 And valu_exp_chef.Value < 650 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(4)
        ElseIf valu_exp_chef.Value >= 650 And valu_exp_chef.Value < 1140 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(5)
        ElseIf valu_exp_chef.Value >= 1140 And valu_exp_chef.Value < 1870 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(6)
        ElseIf valu_exp_chef.Value >= 1870 And valu_exp_chef.Value < 2920 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(7)
        ElseIf valu_exp_chef.Value >= 2920 And valu_exp_chef.Value < 4390 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(8)
        ElseIf valu_exp_chef.Value >= 4390 And valu_exp_chef.Value < 6390 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(9)
        ElseIf valu_exp_chef.Value >= 6390 And valu_exp_chef.Value < 9060 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(10)
        ElseIf valu_exp_chef.Value >= 9060 And valu_exp_chef.Value < 12570 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(11)
        ElseIf valu_exp_chef.Value >= 12570 And valu_exp_chef.Value < 17120 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(12)
        ElseIf valu_exp_chef.Value >= 17120 And valu_exp_chef.Value < 22920 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(13)
        ElseIf valu_exp_chef.Value >= 22920 And valu_exp_chef.Value < 30230 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(14)
        ElseIf valu_exp_chef.Value >= 30230 And valu_exp_chef.Value < 39340 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(15)
        ElseIf valu_exp_chef.Value >= 39340 And valu_exp_chef.Value < 50580 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(16)
        ElseIf valu_exp_chef.Value >= 50580 And valu_exp_chef.Value < 64320 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(17)
        ElseIf valu_exp_chef.Value >= 64320 And valu_exp_chef.Value < 80960 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(18)
        ElseIf valu_exp_chef.Value >= 80960 And valu_exp_chef.Value < 100960 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(19)
        ElseIf valu_exp_chef.Value >= 100960 And valu_exp_chef.Value < 124820 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(20)
        ElseIf valu_exp_chef.Value >= 124820 And valu_exp_chef.Value < 153090 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(21)
        ElseIf valu_exp_chef.Value >= 153090 And valu_exp_chef.Value < 186360 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(22)
        ElseIf valu_exp_chef.Value >= 186360 And valu_exp_chef.Value < 225300 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(23)
        ElseIf valu_exp_chef.Value >= 225300 And valu_exp_chef.Value < 270610 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(24)
        ElseIf valu_exp_chef.Value >= 270610 And valu_exp_chef.Value < 315920 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(25)
        ElseIf valu_exp_chef.Value >= 315920 And valu_exp_chef.Value < 361230 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(26)
        ElseIf valu_exp_chef.Value >= 361230 And valu_exp_chef.Value < 406540 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(27)
        ElseIf valu_exp_chef.Value >= 406540 And valu_exp_chef.Value < 451850 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(28)
        ElseIf valu_exp_chef.Value >= 451850 And valu_exp_chef.Value < 497160 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(29)
        ElseIf valu_exp_chef.Value >= 497160 And valu_exp_chef.Value < 545590 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(30)
        ElseIf valu_exp_chef.Value >= 545590 And valu_exp_chef.Value < 599690 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(31)
        ElseIf valu_exp_chef.Value >= 599690 And valu_exp_chef.Value < 659900 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(32)
        ElseIf valu_exp_chef.Value >= 659900 And valu_exp_chef.Value < 726690 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(33)
        ElseIf valu_exp_chef.Value >= 726690 And valu_exp_chef.Value < 800540 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(34)
        ElseIf valu_exp_chef.Value >= 800540 And valu_exp_chef.Value < 881950 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(35)
        ElseIf valu_exp_chef.Value >= 881950 And valu_exp_chef.Value < 971440 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(36)
        ElseIf valu_exp_chef.Value >= 971440 And valu_exp_chef.Value < 1069540 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(37)
        ElseIf valu_exp_chef.Value >= 1069540 And valu_exp_chef.Value < 1176790 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(38)
        ElseIf valu_exp_chef.Value >= 1176790 And valu_exp_chef.Value < 1293750 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(39)
        ElseIf valu_exp_chef.Value >= 1293750 And valu_exp_chef.Value < 1420990 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(40)
        ElseIf valu_exp_chef.Value >= 1420990 And valu_exp_chef.Value < 1559090 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(41)
        ElseIf valu_exp_chef.Value >= 1559090 And valu_exp_chef.Value < 1708640 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(42)
        ElseIf valu_exp_chef.Value >= 1708640 And valu_exp_chef.Value < 1870250 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(43)
        ElseIf valu_exp_chef.Value >= 1870250 And valu_exp_chef.Value < 2044530 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(44)
        ElseIf valu_exp_chef.Value >= 2044530 And valu_exp_chef.Value < 2232090 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(45)
        ElseIf valu_exp_chef.Value >= 2232090 And valu_exp_chef.Value < 2448870 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(46)
        ElseIf valu_exp_chef.Value >= 2448870 And valu_exp_chef.Value < 2698120 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(47)
        ElseIf valu_exp_chef.Value >= 2698120 And valu_exp_chef.Value < 2983350 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(48)
        ElseIf valu_exp_chef.Value >= 2983350 Then
            Select_exp_chef.SelectedItem = Select_exp_chef.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_tank_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_tank.ValueChanged
        If valu_exp_tank.Value > 0 And valu_exp_tank.Value < 10 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(0)
        ElseIf valu_exp_tank.Value >= 10 And valu_exp_tank.Value < 50 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(1)
        ElseIf valu_exp_tank.Value >= 50 And valu_exp_tank.Value < 150 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(2)
        ElseIf valu_exp_tank.Value >= 150 And valu_exp_tank.Value < 340 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(3)
        ElseIf valu_exp_tank.Value >= 340 And valu_exp_tank.Value < 650 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(4)
        ElseIf valu_exp_tank.Value >= 650 And valu_exp_tank.Value < 1140 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(5)
        ElseIf valu_exp_tank.Value >= 1140 And valu_exp_tank.Value < 1870 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(6)
        ElseIf valu_exp_tank.Value >= 1870 And valu_exp_tank.Value < 2920 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(7)
        ElseIf valu_exp_tank.Value >= 2920 And valu_exp_tank.Value < 4390 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(8)
        ElseIf valu_exp_tank.Value >= 4390 And valu_exp_tank.Value < 6390 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(9)
        ElseIf valu_exp_tank.Value >= 6390 And valu_exp_tank.Value < 9060 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(10)
        ElseIf valu_exp_tank.Value >= 9060 And valu_exp_tank.Value < 12570 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(11)
        ElseIf valu_exp_tank.Value >= 12570 And valu_exp_tank.Value < 17120 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(12)
        ElseIf valu_exp_tank.Value >= 17120 And valu_exp_tank.Value < 22920 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(13)
        ElseIf valu_exp_tank.Value >= 22920 And valu_exp_tank.Value < 30230 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(14)
        ElseIf valu_exp_tank.Value >= 30230 And valu_exp_tank.Value < 39340 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(15)
        ElseIf valu_exp_tank.Value >= 39340 And valu_exp_tank.Value < 50580 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(16)
        ElseIf valu_exp_tank.Value >= 50580 And valu_exp_tank.Value < 64320 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(17)
        ElseIf valu_exp_tank.Value >= 64320 And valu_exp_tank.Value < 80960 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(18)
        ElseIf valu_exp_tank.Value >= 80960 And valu_exp_tank.Value < 100960 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(19)
        ElseIf valu_exp_tank.Value >= 100960 And valu_exp_tank.Value < 124820 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(20)
        ElseIf valu_exp_tank.Value >= 124820 And valu_exp_tank.Value < 153090 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(21)
        ElseIf valu_exp_tank.Value >= 153090 And valu_exp_tank.Value < 186360 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(22)
        ElseIf valu_exp_tank.Value >= 186360 And valu_exp_tank.Value < 225300 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(23)
        ElseIf valu_exp_tank.Value >= 225300 And valu_exp_tank.Value < 270610 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(24)
        ElseIf valu_exp_tank.Value >= 270610 And valu_exp_tank.Value < 315920 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(25)
        ElseIf valu_exp_tank.Value >= 315920 And valu_exp_tank.Value < 361230 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(26)
        ElseIf valu_exp_tank.Value >= 361230 And valu_exp_tank.Value < 406540 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(27)
        ElseIf valu_exp_tank.Value >= 406540 And valu_exp_tank.Value < 451850 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(28)
        ElseIf valu_exp_tank.Value >= 451850 And valu_exp_tank.Value < 497160 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(29)
        ElseIf valu_exp_tank.Value >= 497160 And valu_exp_tank.Value < 545590 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(30)
        ElseIf valu_exp_tank.Value >= 545590 And valu_exp_tank.Value < 599690 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(31)
        ElseIf valu_exp_tank.Value >= 599690 And valu_exp_tank.Value < 659900 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(32)
        ElseIf valu_exp_tank.Value >= 659900 And valu_exp_tank.Value < 726690 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(33)
        ElseIf valu_exp_tank.Value >= 726690 And valu_exp_tank.Value < 800540 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(34)
        ElseIf valu_exp_tank.Value >= 800540 And valu_exp_tank.Value < 881950 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(35)
        ElseIf valu_exp_tank.Value >= 881950 And valu_exp_tank.Value < 971440 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(36)
        ElseIf valu_exp_tank.Value >= 971440 And valu_exp_tank.Value < 1069540 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(37)
        ElseIf valu_exp_tank.Value >= 1069540 And valu_exp_tank.Value < 1176790 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(38)
        ElseIf valu_exp_tank.Value >= 1176790 And valu_exp_tank.Value < 1293750 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(39)
        ElseIf valu_exp_tank.Value >= 1293750 And valu_exp_tank.Value < 1420990 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(40)
        ElseIf valu_exp_tank.Value >= 1420990 And valu_exp_tank.Value < 1559090 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(41)
        ElseIf valu_exp_tank.Value >= 1559090 And valu_exp_tank.Value < 1708640 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(42)
        ElseIf valu_exp_tank.Value >= 1708640 And valu_exp_tank.Value < 1870250 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(43)
        ElseIf valu_exp_tank.Value >= 1870250 And valu_exp_tank.Value < 2044530 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(44)
        ElseIf valu_exp_tank.Value >= 2044530 And valu_exp_tank.Value < 2232090 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(45)
        ElseIf valu_exp_tank.Value >= 2232090 And valu_exp_tank.Value < 2448870 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(46)
        ElseIf valu_exp_tank.Value >= 2448870 And valu_exp_tank.Value < 2698120 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(47)
        ElseIf valu_exp_tank.Value >= 2698120 And valu_exp_tank.Value < 2983350 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(48)
        ElseIf valu_exp_tank.Value >= 2983350 Then
            Select_exp_tank.SelectedItem = Select_exp_tank.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_imp_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_imp.ValueChanged
        If valu_exp_imp.Value > 0 And valu_exp_imp.Value < 10 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(0)
        ElseIf valu_exp_imp.Value >= 10 And valu_exp_imp.Value < 50 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(1)
        ElseIf valu_exp_imp.Value >= 50 And valu_exp_imp.Value < 150 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(2)
        ElseIf valu_exp_imp.Value >= 150 And valu_exp_imp.Value < 340 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(3)
        ElseIf valu_exp_imp.Value >= 340 And valu_exp_imp.Value < 650 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(4)
        ElseIf valu_exp_imp.Value >= 650 And valu_exp_imp.Value < 1140 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(5)
        ElseIf valu_exp_imp.Value >= 1140 And valu_exp_imp.Value < 1870 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(6)
        ElseIf valu_exp_imp.Value >= 1870 And valu_exp_imp.Value < 2920 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(7)
        ElseIf valu_exp_imp.Value >= 2920 And valu_exp_imp.Value < 4390 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(8)
        ElseIf valu_exp_imp.Value >= 4390 And valu_exp_imp.Value < 6390 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(9)
        ElseIf valu_exp_imp.Value >= 6390 And valu_exp_imp.Value < 9060 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(10)
        ElseIf valu_exp_imp.Value >= 9060 And valu_exp_imp.Value < 12570 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(11)
        ElseIf valu_exp_imp.Value >= 12570 And valu_exp_imp.Value < 17120 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(12)
        ElseIf valu_exp_imp.Value >= 17120 And valu_exp_imp.Value < 22920 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(13)
        ElseIf valu_exp_imp.Value >= 22920 And valu_exp_imp.Value < 30230 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(14)
        ElseIf valu_exp_imp.Value >= 30230 And valu_exp_imp.Value < 39340 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(15)
        ElseIf valu_exp_imp.Value >= 39340 And valu_exp_imp.Value < 50580 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(16)
        ElseIf valu_exp_imp.Value >= 50580 And valu_exp_imp.Value < 64320 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(17)
        ElseIf valu_exp_imp.Value >= 64320 And valu_exp_imp.Value < 80960 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(18)
        ElseIf valu_exp_imp.Value >= 80960 And valu_exp_imp.Value < 100960 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(19)
        ElseIf valu_exp_imp.Value >= 100960 And valu_exp_imp.Value < 124820 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(20)
        ElseIf valu_exp_imp.Value >= 124820 And valu_exp_imp.Value < 153090 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(21)
        ElseIf valu_exp_imp.Value >= 153090 And valu_exp_imp.Value < 186360 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(22)
        ElseIf valu_exp_imp.Value >= 186360 And valu_exp_imp.Value < 225300 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(23)
        ElseIf valu_exp_imp.Value >= 225300 And valu_exp_imp.Value < 270610 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(24)
        ElseIf valu_exp_imp.Value >= 270610 And valu_exp_imp.Value < 315920 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(25)
        ElseIf valu_exp_imp.Value >= 315920 And valu_exp_imp.Value < 361230 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(26)
        ElseIf valu_exp_imp.Value >= 361230 And valu_exp_imp.Value < 406540 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(27)
        ElseIf valu_exp_imp.Value >= 406540 And valu_exp_imp.Value < 451850 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(28)
        ElseIf valu_exp_imp.Value >= 451850 And valu_exp_imp.Value < 497160 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(29)
        ElseIf valu_exp_imp.Value >= 497160 And valu_exp_imp.Value < 545590 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(30)
        ElseIf valu_exp_imp.Value >= 545590 And valu_exp_imp.Value < 599690 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(31)
        ElseIf valu_exp_imp.Value >= 599690 And valu_exp_imp.Value < 659900 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(32)
        ElseIf valu_exp_imp.Value >= 659900 And valu_exp_imp.Value < 726690 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(33)
        ElseIf valu_exp_imp.Value >= 726690 And valu_exp_imp.Value < 800540 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(34)
        ElseIf valu_exp_imp.Value >= 800540 And valu_exp_imp.Value < 881950 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(35)
        ElseIf valu_exp_imp.Value >= 881950 And valu_exp_imp.Value < 971440 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(36)
        ElseIf valu_exp_imp.Value >= 971440 And valu_exp_imp.Value < 1069540 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(37)
        ElseIf valu_exp_imp.Value >= 1069540 And valu_exp_imp.Value < 1176790 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(38)
        ElseIf valu_exp_imp.Value >= 1176790 And valu_exp_imp.Value < 1293750 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(39)
        ElseIf valu_exp_imp.Value >= 1293750 And valu_exp_imp.Value < 1420990 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(40)
        ElseIf valu_exp_imp.Value >= 1420990 And valu_exp_imp.Value < 1559090 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(41)
        ElseIf valu_exp_imp.Value >= 1559090 And valu_exp_imp.Value < 1708640 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(42)
        ElseIf valu_exp_imp.Value >= 1708640 And valu_exp_imp.Value < 1870250 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(43)
        ElseIf valu_exp_imp.Value >= 1870250 And valu_exp_imp.Value < 2044530 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(44)
        ElseIf valu_exp_imp.Value >= 2044530 And valu_exp_imp.Value < 2232090 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(45)
        ElseIf valu_exp_imp.Value >= 2232090 And valu_exp_imp.Value < 2448870 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(46)
        ElseIf valu_exp_imp.Value >= 2448870 And valu_exp_imp.Value < 2698120 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(47)
        ElseIf valu_exp_imp.Value >= 2698120 And valu_exp_imp.Value < 2983350 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(48)
        ElseIf valu_exp_imp.Value >= 2983350 Then
            Select_exp_imp.SelectedItem = Select_exp_imp.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_princess_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_princess.ValueChanged
        If valu_exp_princess.Value > 0 And valu_exp_princess.Value < 10 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(0)
        ElseIf valu_exp_princess.Value >= 10 And valu_exp_princess.Value < 50 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(1)
        ElseIf valu_exp_princess.Value >= 50 And valu_exp_princess.Value < 150 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(2)
        ElseIf valu_exp_princess.Value >= 150 And valu_exp_princess.Value < 340 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(3)
        ElseIf valu_exp_princess.Value >= 340 And valu_exp_princess.Value < 650 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(4)
        ElseIf valu_exp_princess.Value >= 650 And valu_exp_princess.Value < 1140 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(5)
        ElseIf valu_exp_princess.Value >= 1140 And valu_exp_princess.Value < 1870 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(6)
        ElseIf valu_exp_princess.Value >= 1870 And valu_exp_princess.Value < 2920 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(7)
        ElseIf valu_exp_princess.Value >= 2920 And valu_exp_princess.Value < 4390 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(8)
        ElseIf valu_exp_princess.Value >= 4390 And valu_exp_princess.Value < 6390 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(9)
        ElseIf valu_exp_princess.Value >= 6390 And valu_exp_princess.Value < 9060 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(10)
        ElseIf valu_exp_princess.Value >= 9060 And valu_exp_princess.Value < 12570 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(11)
        ElseIf valu_exp_princess.Value >= 12570 And valu_exp_princess.Value < 17120 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(12)
        ElseIf valu_exp_princess.Value >= 17120 And valu_exp_princess.Value < 22920 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(13)
        ElseIf valu_exp_princess.Value >= 22920 And valu_exp_princess.Value < 30230 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(14)
        ElseIf valu_exp_princess.Value >= 30230 And valu_exp_princess.Value < 39340 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(15)
        ElseIf valu_exp_princess.Value >= 39340 And valu_exp_princess.Value < 50580 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(16)
        ElseIf valu_exp_princess.Value >= 50580 And valu_exp_princess.Value < 64320 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(17)
        ElseIf valu_exp_princess.Value >= 64320 And valu_exp_princess.Value < 80960 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(18)
        ElseIf valu_exp_princess.Value >= 80960 And valu_exp_princess.Value < 100960 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(19)
        ElseIf valu_exp_princess.Value >= 100960 And valu_exp_princess.Value < 124820 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(20)
        ElseIf valu_exp_princess.Value >= 124820 And valu_exp_princess.Value < 153090 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(21)
        ElseIf valu_exp_princess.Value >= 153090 And valu_exp_princess.Value < 186360 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(22)
        ElseIf valu_exp_princess.Value >= 186360 And valu_exp_princess.Value < 225300 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(23)
        ElseIf valu_exp_princess.Value >= 225300 And valu_exp_princess.Value < 270610 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(24)
        ElseIf valu_exp_princess.Value >= 270610 And valu_exp_princess.Value < 315920 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(25)
        ElseIf valu_exp_princess.Value >= 315920 And valu_exp_princess.Value < 361230 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(26)
        ElseIf valu_exp_princess.Value >= 361230 And valu_exp_princess.Value < 406540 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(27)
        ElseIf valu_exp_princess.Value >= 406540 And valu_exp_princess.Value < 451850 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(28)
        ElseIf valu_exp_princess.Value >= 451850 And valu_exp_princess.Value < 497160 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(29)
        ElseIf valu_exp_princess.Value >= 497160 And valu_exp_princess.Value < 545590 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(30)
        ElseIf valu_exp_princess.Value >= 545590 And valu_exp_princess.Value < 599690 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(31)
        ElseIf valu_exp_princess.Value >= 599690 And valu_exp_princess.Value < 659900 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(32)
        ElseIf valu_exp_princess.Value >= 659900 And valu_exp_princess.Value < 726690 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(33)
        ElseIf valu_exp_princess.Value >= 726690 And valu_exp_princess.Value < 800540 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(34)
        ElseIf valu_exp_princess.Value >= 800540 And valu_exp_princess.Value < 881950 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(35)
        ElseIf valu_exp_princess.Value >= 881950 And valu_exp_princess.Value < 971440 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(36)
        ElseIf valu_exp_princess.Value >= 971440 And valu_exp_princess.Value < 1069540 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(37)
        ElseIf valu_exp_princess.Value >= 1069540 And valu_exp_princess.Value < 1176790 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(38)
        ElseIf valu_exp_princess.Value >= 1176790 And valu_exp_princess.Value < 1293750 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(39)
        ElseIf valu_exp_princess.Value >= 1293750 And valu_exp_princess.Value < 1420990 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(40)
        ElseIf valu_exp_princess.Value >= 1420990 And valu_exp_princess.Value < 1559090 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(41)
        ElseIf valu_exp_princess.Value >= 1559090 And valu_exp_princess.Value < 1708640 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(42)
        ElseIf valu_exp_princess.Value >= 1708640 And valu_exp_princess.Value < 1870250 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(43)
        ElseIf valu_exp_princess.Value >= 1870250 And valu_exp_princess.Value < 2044530 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(44)
        ElseIf valu_exp_princess.Value >= 2044530 And valu_exp_princess.Value < 2232090 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(45)
        ElseIf valu_exp_princess.Value >= 2232090 And valu_exp_princess.Value < 2448870 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(46)
        ElseIf valu_exp_princess.Value >= 2448870 And valu_exp_princess.Value < 2698120 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(47)
        ElseIf valu_exp_princess.Value >= 2698120 And valu_exp_princess.Value < 2983350 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(48)
        ElseIf valu_exp_princess.Value >= 2983350 Then
            Select_exp_princess.SelectedItem = Select_exp_princess.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_flower_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_flower.ValueChanged
        If valu_exp_flower.Value > 0 And valu_exp_flower.Value < 10 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(0)
        ElseIf valu_exp_flower.Value >= 10 And valu_exp_flower.Value < 50 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(1)
        ElseIf valu_exp_flower.Value >= 50 And valu_exp_flower.Value < 150 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(2)
        ElseIf valu_exp_flower.Value >= 150 And valu_exp_flower.Value < 340 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(3)
        ElseIf valu_exp_flower.Value >= 340 And valu_exp_flower.Value < 650 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(4)
        ElseIf valu_exp_flower.Value >= 650 And valu_exp_flower.Value < 1140 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(5)
        ElseIf valu_exp_flower.Value >= 1140 And valu_exp_flower.Value < 1870 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(6)
        ElseIf valu_exp_flower.Value >= 1870 And valu_exp_flower.Value < 2920 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(7)
        ElseIf valu_exp_flower.Value >= 2920 And valu_exp_flower.Value < 4390 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(8)
        ElseIf valu_exp_flower.Value >= 4390 And valu_exp_flower.Value < 6390 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(9)
        ElseIf valu_exp_flower.Value >= 6390 And valu_exp_flower.Value < 9060 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(10)
        ElseIf valu_exp_flower.Value >= 9060 And valu_exp_flower.Value < 12570 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(11)
        ElseIf valu_exp_flower.Value >= 12570 And valu_exp_flower.Value < 17120 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(12)
        ElseIf valu_exp_flower.Value >= 17120 And valu_exp_flower.Value < 22920 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(13)
        ElseIf valu_exp_flower.Value >= 22920 And valu_exp_flower.Value < 30230 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(14)
        ElseIf valu_exp_flower.Value >= 30230 And valu_exp_flower.Value < 39340 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(15)
        ElseIf valu_exp_flower.Value >= 39340 And valu_exp_flower.Value < 50580 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(16)
        ElseIf valu_exp_flower.Value >= 50580 And valu_exp_flower.Value < 64320 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(17)
        ElseIf valu_exp_flower.Value >= 64320 And valu_exp_flower.Value < 80960 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(18)
        ElseIf valu_exp_flower.Value >= 80960 And valu_exp_flower.Value < 100960 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(19)
        ElseIf valu_exp_flower.Value >= 100960 And valu_exp_flower.Value < 124820 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(20)
        ElseIf valu_exp_flower.Value >= 124820 And valu_exp_flower.Value < 153090 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(21)
        ElseIf valu_exp_flower.Value >= 153090 And valu_exp_flower.Value < 186360 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(22)
        ElseIf valu_exp_flower.Value >= 186360 And valu_exp_flower.Value < 225300 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(23)
        ElseIf valu_exp_flower.Value >= 225300 And valu_exp_flower.Value < 270610 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(24)
        ElseIf valu_exp_flower.Value >= 270610 And valu_exp_flower.Value < 315920 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(25)
        ElseIf valu_exp_flower.Value >= 315920 And valu_exp_flower.Value < 361230 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(26)
        ElseIf valu_exp_flower.Value >= 361230 And valu_exp_flower.Value < 406540 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(27)
        ElseIf valu_exp_flower.Value >= 406540 And valu_exp_flower.Value < 451850 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(28)
        ElseIf valu_exp_flower.Value >= 451850 And valu_exp_flower.Value < 497160 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(29)
        ElseIf valu_exp_flower.Value >= 497160 And valu_exp_flower.Value < 545590 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(30)
        ElseIf valu_exp_flower.Value >= 545590 And valu_exp_flower.Value < 599690 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(31)
        ElseIf valu_exp_flower.Value >= 599690 And valu_exp_flower.Value < 659900 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(32)
        ElseIf valu_exp_flower.Value >= 659900 And valu_exp_flower.Value < 726690 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(33)
        ElseIf valu_exp_flower.Value >= 726690 And valu_exp_flower.Value < 800540 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(34)
        ElseIf valu_exp_flower.Value >= 800540 And valu_exp_flower.Value < 881950 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(35)
        ElseIf valu_exp_flower.Value >= 881950 And valu_exp_flower.Value < 971440 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(36)
        ElseIf valu_exp_flower.Value >= 971440 And valu_exp_flower.Value < 1069540 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(37)
        ElseIf valu_exp_flower.Value >= 1069540 And valu_exp_flower.Value < 1176790 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(38)
        ElseIf valu_exp_flower.Value >= 1176790 And valu_exp_flower.Value < 1293750 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(39)
        ElseIf valu_exp_flower.Value >= 1293750 And valu_exp_flower.Value < 1420990 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(40)
        ElseIf valu_exp_flower.Value >= 1420990 And valu_exp_flower.Value < 1559090 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(41)
        ElseIf valu_exp_flower.Value >= 1559090 And valu_exp_flower.Value < 1708640 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(42)
        ElseIf valu_exp_flower.Value >= 1708640 And valu_exp_flower.Value < 1870250 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(43)
        ElseIf valu_exp_flower.Value >= 1870250 And valu_exp_flower.Value < 2044530 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(44)
        ElseIf valu_exp_flower.Value >= 2044530 And valu_exp_flower.Value < 2232090 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(45)
        ElseIf valu_exp_flower.Value >= 2232090 And valu_exp_flower.Value < 2448870 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(46)
        ElseIf valu_exp_flower.Value >= 2448870 And valu_exp_flower.Value < 2698120 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(47)
        ElseIf valu_exp_flower.Value >= 2698120 And valu_exp_flower.Value < 2983350 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(48)
        ElseIf valu_exp_flower.Value >= 2983350 Then
            Select_exp_flower.SelectedItem = Select_exp_flower.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_scientist_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_scientist.ValueChanged
        If valu_exp_scientist.Value > 0 And valu_exp_scientist.Value < 10 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(0)
        ElseIf valu_exp_scientist.Value >= 10 And valu_exp_scientist.Value < 50 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(1)
        ElseIf valu_exp_scientist.Value >= 50 And valu_exp_scientist.Value < 150 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(2)
        ElseIf valu_exp_scientist.Value >= 150 And valu_exp_scientist.Value < 340 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(3)
        ElseIf valu_exp_scientist.Value >= 340 And valu_exp_scientist.Value < 650 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(4)
        ElseIf valu_exp_scientist.Value >= 650 And valu_exp_scientist.Value < 1140 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(5)
        ElseIf valu_exp_scientist.Value >= 1140 And valu_exp_scientist.Value < 1870 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(6)
        ElseIf valu_exp_scientist.Value >= 1870 And valu_exp_scientist.Value < 2920 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(7)
        ElseIf valu_exp_scientist.Value >= 2920 And valu_exp_scientist.Value < 4390 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(8)
        ElseIf valu_exp_scientist.Value >= 4390 And valu_exp_scientist.Value < 6390 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(9)
        ElseIf valu_exp_scientist.Value >= 6390 And valu_exp_scientist.Value < 9060 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(10)
        ElseIf valu_exp_scientist.Value >= 9060 And valu_exp_scientist.Value < 12570 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(11)
        ElseIf valu_exp_scientist.Value >= 12570 And valu_exp_scientist.Value < 17120 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(12)
        ElseIf valu_exp_scientist.Value >= 17120 And valu_exp_scientist.Value < 22920 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(13)
        ElseIf valu_exp_scientist.Value >= 22920 And valu_exp_scientist.Value < 30230 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(14)
        ElseIf valu_exp_scientist.Value >= 30230 And valu_exp_scientist.Value < 39340 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(15)
        ElseIf valu_exp_scientist.Value >= 39340 And valu_exp_scientist.Value < 50580 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(16)
        ElseIf valu_exp_scientist.Value >= 50580 And valu_exp_scientist.Value < 64320 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(17)
        ElseIf valu_exp_scientist.Value >= 64320 And valu_exp_scientist.Value < 80960 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(18)
        ElseIf valu_exp_scientist.Value >= 80960 And valu_exp_scientist.Value < 100960 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(19)
        ElseIf valu_exp_scientist.Value >= 100960 And valu_exp_scientist.Value < 124820 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(20)
        ElseIf valu_exp_scientist.Value >= 124820 And valu_exp_scientist.Value < 153090 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(21)
        ElseIf valu_exp_scientist.Value >= 153090 And valu_exp_scientist.Value < 186360 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(22)
        ElseIf valu_exp_scientist.Value >= 186360 And valu_exp_scientist.Value < 225300 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(23)
        ElseIf valu_exp_scientist.Value >= 225300 And valu_exp_scientist.Value < 270610 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(24)
        ElseIf valu_exp_scientist.Value >= 270610 And valu_exp_scientist.Value < 315920 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(25)
        ElseIf valu_exp_scientist.Value >= 315920 And valu_exp_scientist.Value < 361230 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(26)
        ElseIf valu_exp_scientist.Value >= 361230 And valu_exp_scientist.Value < 406540 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(27)
        ElseIf valu_exp_scientist.Value >= 406540 And valu_exp_scientist.Value < 451850 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(28)
        ElseIf valu_exp_scientist.Value >= 451850 And valu_exp_scientist.Value < 497160 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(29)
        ElseIf valu_exp_scientist.Value >= 497160 And valu_exp_scientist.Value < 545590 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(30)
        ElseIf valu_exp_scientist.Value >= 545590 And valu_exp_scientist.Value < 599690 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(31)
        ElseIf valu_exp_scientist.Value >= 599690 And valu_exp_scientist.Value < 659900 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(32)
        ElseIf valu_exp_scientist.Value >= 659900 And valu_exp_scientist.Value < 726690 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(33)
        ElseIf valu_exp_scientist.Value >= 726690 And valu_exp_scientist.Value < 800540 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(34)
        ElseIf valu_exp_scientist.Value >= 800540 And valu_exp_scientist.Value < 881950 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(35)
        ElseIf valu_exp_scientist.Value >= 881950 And valu_exp_scientist.Value < 971440 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(36)
        ElseIf valu_exp_scientist.Value >= 971440 And valu_exp_scientist.Value < 1069540 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(37)
        ElseIf valu_exp_scientist.Value >= 1069540 And valu_exp_scientist.Value < 1176790 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(38)
        ElseIf valu_exp_scientist.Value >= 1176790 And valu_exp_scientist.Value < 1293750 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(39)
        ElseIf valu_exp_scientist.Value >= 1293750 And valu_exp_scientist.Value < 1420990 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(40)
        ElseIf valu_exp_scientist.Value >= 1420990 And valu_exp_scientist.Value < 1559090 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(41)
        ElseIf valu_exp_scientist.Value >= 1559090 And valu_exp_scientist.Value < 1708640 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(42)
        ElseIf valu_exp_scientist.Value >= 1708640 And valu_exp_scientist.Value < 1870250 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(43)
        ElseIf valu_exp_scientist.Value >= 1870250 And valu_exp_scientist.Value < 2044530 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(44)
        ElseIf valu_exp_scientist.Value >= 2044530 And valu_exp_scientist.Value < 2232090 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(45)
        ElseIf valu_exp_scientist.Value >= 2232090 And valu_exp_scientist.Value < 2448870 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(46)
        ElseIf valu_exp_scientist.Value >= 2448870 And valu_exp_scientist.Value < 2698120 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(47)
        ElseIf valu_exp_scientist.Value >= 2698120 And valu_exp_scientist.Value < 2983350 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(48)
        ElseIf valu_exp_scientist.Value >= 2983350 Then
            Select_exp_scientist.SelectedItem = Select_exp_scientist.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_cat_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_cat.ValueChanged
        If valu_exp_cat.Value > 0 And valu_exp_cat.Value < 10 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(0)
        ElseIf valu_exp_cat.Value >= 10 And valu_exp_cat.Value < 50 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(1)
        ElseIf valu_exp_cat.Value >= 50 And valu_exp_cat.Value < 150 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(2)
        ElseIf valu_exp_cat.Value >= 150 And valu_exp_cat.Value < 340 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(3)
        ElseIf valu_exp_cat.Value >= 340 And valu_exp_cat.Value < 650 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(4)
        ElseIf valu_exp_cat.Value >= 650 And valu_exp_cat.Value < 1140 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(5)
        ElseIf valu_exp_cat.Value >= 1140 And valu_exp_cat.Value < 1870 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(6)
        ElseIf valu_exp_cat.Value >= 1870 And valu_exp_cat.Value < 2920 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(7)
        ElseIf valu_exp_cat.Value >= 2920 And valu_exp_cat.Value < 4390 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(8)
        ElseIf valu_exp_cat.Value >= 4390 And valu_exp_cat.Value < 6390 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(9)
        ElseIf valu_exp_cat.Value >= 6390 And valu_exp_cat.Value < 9060 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(10)
        ElseIf valu_exp_cat.Value >= 9060 And valu_exp_cat.Value < 12570 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(11)
        ElseIf valu_exp_cat.Value >= 12570 And valu_exp_cat.Value < 17120 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(12)
        ElseIf valu_exp_cat.Value >= 17120 And valu_exp_cat.Value < 22920 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(13)
        ElseIf valu_exp_cat.Value >= 22920 And valu_exp_cat.Value < 30230 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(14)
        ElseIf valu_exp_cat.Value >= 30230 And valu_exp_cat.Value < 39340 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(15)
        ElseIf valu_exp_cat.Value >= 39340 And valu_exp_cat.Value < 50580 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(16)
        ElseIf valu_exp_cat.Value >= 50580 And valu_exp_cat.Value < 64320 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(17)
        ElseIf valu_exp_cat.Value >= 64320 And valu_exp_cat.Value < 80960 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(18)
        ElseIf valu_exp_cat.Value >= 80960 And valu_exp_cat.Value < 100960 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(19)
        ElseIf valu_exp_cat.Value >= 100960 And valu_exp_cat.Value < 124820 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(20)
        ElseIf valu_exp_cat.Value >= 124820 And valu_exp_cat.Value < 153090 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(21)
        ElseIf valu_exp_cat.Value >= 153090 And valu_exp_cat.Value < 186360 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(22)
        ElseIf valu_exp_cat.Value >= 186360 And valu_exp_cat.Value < 225300 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(23)
        ElseIf valu_exp_cat.Value >= 225300 And valu_exp_cat.Value < 270610 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(24)
        ElseIf valu_exp_cat.Value >= 270610 And valu_exp_cat.Value < 315920 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(25)
        ElseIf valu_exp_cat.Value >= 315920 And valu_exp_cat.Value < 361230 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(26)
        ElseIf valu_exp_cat.Value >= 361230 And valu_exp_cat.Value < 406540 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(27)
        ElseIf valu_exp_cat.Value >= 406540 And valu_exp_cat.Value < 451850 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(28)
        ElseIf valu_exp_cat.Value >= 451850 And valu_exp_cat.Value < 497160 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(29)
        ElseIf valu_exp_cat.Value >= 497160 And valu_exp_cat.Value < 545590 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(30)
        ElseIf valu_exp_cat.Value >= 545590 And valu_exp_cat.Value < 599690 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(31)
        ElseIf valu_exp_cat.Value >= 599690 And valu_exp_cat.Value < 659900 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(32)
        ElseIf valu_exp_cat.Value >= 659900 And valu_exp_cat.Value < 726690 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(33)
        ElseIf valu_exp_cat.Value >= 726690 And valu_exp_cat.Value < 800540 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(34)
        ElseIf valu_exp_cat.Value >= 800540 And valu_exp_cat.Value < 881950 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(35)
        ElseIf valu_exp_cat.Value >= 881950 And valu_exp_cat.Value < 971440 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(36)
        ElseIf valu_exp_cat.Value >= 971440 And valu_exp_cat.Value < 1069540 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(37)
        ElseIf valu_exp_cat.Value >= 1069540 And valu_exp_cat.Value < 1176790 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(38)
        ElseIf valu_exp_cat.Value >= 1176790 And valu_exp_cat.Value < 1293750 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(39)
        ElseIf valu_exp_cat.Value >= 1293750 And valu_exp_cat.Value < 1420990 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(40)
        ElseIf valu_exp_cat.Value >= 1420990 And valu_exp_cat.Value < 1559090 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(41)
        ElseIf valu_exp_cat.Value >= 1559090 And valu_exp_cat.Value < 1708640 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(42)
        ElseIf valu_exp_cat.Value >= 1708640 And valu_exp_cat.Value < 1870250 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(43)
        ElseIf valu_exp_cat.Value >= 1870250 And valu_exp_cat.Value < 2044530 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(44)
        ElseIf valu_exp_cat.Value >= 2044530 And valu_exp_cat.Value < 2232090 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(45)
        ElseIf valu_exp_cat.Value >= 2232090 And valu_exp_cat.Value < 2448870 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(46)
        ElseIf valu_exp_cat.Value >= 2448870 And valu_exp_cat.Value < 2698120 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(47)
        ElseIf valu_exp_cat.Value >= 2698120 And valu_exp_cat.Value < 2983350 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(48)
        ElseIf valu_exp_cat.Value >= 2983350 Then
            Select_exp_cat.SelectedItem = Select_exp_cat.Items.Item(49)
        End If
    End Sub

    Private Sub valu_exp_elf_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp_elf.ValueChanged
        If valu_exp_elf.Value > 0 And valu_exp_elf.Value < 10 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(0)
        ElseIf valu_exp_elf.Value >= 10 And valu_exp_elf.Value < 50 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(1)
        ElseIf valu_exp_elf.Value >= 50 And valu_exp_elf.Value < 150 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(2)
        ElseIf valu_exp_elf.Value >= 150 And valu_exp_elf.Value < 340 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(3)
        ElseIf valu_exp_elf.Value >= 340 And valu_exp_elf.Value < 650 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(4)
        ElseIf valu_exp_elf.Value >= 650 And valu_exp_elf.Value < 1140 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(5)
        ElseIf valu_exp_elf.Value >= 1140 And valu_exp_elf.Value < 1870 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(6)
        ElseIf valu_exp_elf.Value >= 1870 And valu_exp_elf.Value < 2920 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(7)
        ElseIf valu_exp_elf.Value >= 2920 And valu_exp_elf.Value < 4390 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(8)
        ElseIf valu_exp_elf.Value >= 4390 And valu_exp_elf.Value < 6390 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(9)
        ElseIf valu_exp_elf.Value >= 6390 And valu_exp_elf.Value < 9060 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(10)
        ElseIf valu_exp_elf.Value >= 9060 And valu_exp_elf.Value < 12570 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(11)
        ElseIf valu_exp_elf.Value >= 12570 And valu_exp_elf.Value < 17120 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(12)
        ElseIf valu_exp_elf.Value >= 17120 And valu_exp_elf.Value < 22920 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(13)
        ElseIf valu_exp_elf.Value >= 22920 And valu_exp_elf.Value < 30230 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(14)
        ElseIf valu_exp_elf.Value >= 30230 And valu_exp_elf.Value < 39340 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(15)
        ElseIf valu_exp_elf.Value >= 39340 And valu_exp_elf.Value < 50580 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(16)
        ElseIf valu_exp_elf.Value >= 50580 And valu_exp_elf.Value < 64320 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(17)
        ElseIf valu_exp_elf.Value >= 64320 And valu_exp_elf.Value < 80960 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(18)
        ElseIf valu_exp_elf.Value >= 80960 And valu_exp_elf.Value < 100960 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(19)
        ElseIf valu_exp_elf.Value >= 100960 And valu_exp_elf.Value < 124820 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(20)
        ElseIf valu_exp_elf.Value >= 124820 And valu_exp_elf.Value < 153090 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(21)
        ElseIf valu_exp_elf.Value >= 153090 And valu_exp_elf.Value < 186360 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(22)
        ElseIf valu_exp_elf.Value >= 186360 And valu_exp_elf.Value < 225300 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(23)
        ElseIf valu_exp_elf.Value >= 225300 And valu_exp_elf.Value < 270610 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(24)
        ElseIf valu_exp_elf.Value >= 270610 And valu_exp_elf.Value < 315920 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(25)
        ElseIf valu_exp_elf.Value >= 315920 And valu_exp_elf.Value < 361230 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(26)
        ElseIf valu_exp_elf.Value >= 361230 And valu_exp_elf.Value < 406540 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(27)
        ElseIf valu_exp_elf.Value >= 406540 And valu_exp_elf.Value < 451850 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(28)
        ElseIf valu_exp_elf.Value >= 451850 And valu_exp_elf.Value < 497160 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(29)
        ElseIf valu_exp_elf.Value >= 497160 And valu_exp_elf.Value < 545590 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(30)
        ElseIf valu_exp_elf.Value >= 545590 And valu_exp_elf.Value < 599690 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(31)
        ElseIf valu_exp_elf.Value >= 599690 And valu_exp_elf.Value < 659900 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(32)
        ElseIf valu_exp_elf.Value >= 659900 And valu_exp_elf.Value < 726690 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(33)
        ElseIf valu_exp_elf.Value >= 726690 And valu_exp_elf.Value < 800540 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(34)
        ElseIf valu_exp_elf.Value >= 800540 And valu_exp_elf.Value < 881950 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(35)
        ElseIf valu_exp_elf.Value >= 881950 And valu_exp_elf.Value < 971440 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(36)
        ElseIf valu_exp_elf.Value >= 971440 And valu_exp_elf.Value < 1069540 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(37)
        ElseIf valu_exp_elf.Value >= 1069540 And valu_exp_elf.Value < 1176790 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(38)
        ElseIf valu_exp_elf.Value >= 1176790 And valu_exp_elf.Value < 1293750 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(39)
        ElseIf valu_exp_elf.Value >= 1293750 And valu_exp_elf.Value < 1420990 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(40)
        ElseIf valu_exp_elf.Value >= 1420990 And valu_exp_elf.Value < 1559090 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(41)
        ElseIf valu_exp_elf.Value >= 1559090 And valu_exp_elf.Value < 1708640 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(42)
        ElseIf valu_exp_elf.Value >= 1708640 And valu_exp_elf.Value < 1870250 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(43)
        ElseIf valu_exp_elf.Value >= 1870250 And valu_exp_elf.Value < 2044530 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(44)
        ElseIf valu_exp_elf.Value >= 2044530 And valu_exp_elf.Value < 2232090 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(45)
        ElseIf valu_exp_elf.Value >= 2232090 And valu_exp_elf.Value < 2448870 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(46)
        ElseIf valu_exp_elf.Value >= 2448870 And valu_exp_elf.Value < 2698120 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(47)
        ElseIf valu_exp_elf.Value >= 2698120 And valu_exp_elf.Value < 2983350 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(48)
        ElseIf valu_exp_elf.Value >= 2983350 Then
            Select_exp_elf.SelectedItem = Select_exp_elf.Items.Item(49)
        End If
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Savejobslevelsboosts()
    End Sub

    Public Sub Savejobslevelsboosts()
        Try
            Dim Writejobslvb As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                Writejobslvb.Position = Lv_cat_1
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_1
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_1
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_1
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_1
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_1
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_1
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_1
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_1
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_1
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_1
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_1
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_1
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_1
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_1
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_1
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_1
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_1
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_1
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_1
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                Writejobslvb.Position = Lv_cat_2
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_2
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_2
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_2
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_2
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_2
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_2
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_2
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_2
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_2
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_2
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_2
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_2
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_2
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_2
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_2
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_2
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_2
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_2
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_2
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                Writejobslvb.Position = Lv_cat_3
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_3
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_3
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_3
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_3
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_3
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_3
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_3
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_3
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_3
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_3
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_3
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_3
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_3
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_3
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_3
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_3
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_3
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_3
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_3
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                Writejobslvb.Position = Lv_cat_4
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_4
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_4
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_4
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_4
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_4
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_4
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_4
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_4
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_4
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_4
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_4
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_4
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_4
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_4
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_4
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_4
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_4
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_4
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_4
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                Writejobslvb.Position = Lv_cat_5
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_5
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_5
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_5
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_5
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_5
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_5
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_5
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_5
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_5
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_5
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_5
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_5
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_5
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_5
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_5
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_5
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_5
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_5
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_5
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                Writejobslvb.Position = Lv_cat_6
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_6
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_6
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_6
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_6
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_6
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_6
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_6
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_6
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_6
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_6
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_6
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_6
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_6
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_6
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_6
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_6
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_6
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_6
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_6
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                Writejobslvb.Position = Lv_cat_7
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_7
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_7
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_7
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_7
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_7
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_7
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_7
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_7
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_7
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_7
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_7
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_7
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_7
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_7
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_7
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_7
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_7
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_7
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_7
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                Writejobslvb.Position = Lv_cat_8
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_8
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_8
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_8
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_8
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_8
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_8
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_8
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_8
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_8
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_8
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_8
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_8
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_8
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_8
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_8
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_8
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_8
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_8
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_8
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                Writejobslvb.Position = Lv_cat_9
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_9
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_9
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_9
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_9
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_9
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_9
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_9
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_9
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_9
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_9
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_9
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_9
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_9
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_9
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_9
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_9
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_9
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_9
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_9
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                Writejobslvb.Position = Lv_cat_10
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_10
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_10
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_10
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_10
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_10
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_10
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_10
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_10
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_10
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_10
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_10
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_10
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_10
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_10
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_10
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_10
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_10
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_10
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_10
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(10) Then
                Writejobslvb.Position = Lv_cat_11
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_11
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_11
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_11
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_11
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_11
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_11
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_11
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_11
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_11
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_11
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_11
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_11
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_11
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_11
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_11
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_11
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_11
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_11
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_11
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(11) Then
                Writejobslvb.Position = Lv_cat_12
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_12
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_12
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_12
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_12
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_12
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_12
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_12
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_12
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_12
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_12
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_12
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_12
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_12
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_12
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_12
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_12
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_12
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_12
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_12
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(12) Then
                Writejobslvb.Position = Lv_cat_13
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_13
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_13
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_13
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_13
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_13
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_13
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_13
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_13
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_13
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_13
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_13
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_13
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_13
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_13
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_13
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_13
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_13
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_13
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_13
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(13) Then
                Writejobslvb.Position = Lv_cat_14
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_14
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_14
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_14
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_14
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_14
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_14
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_14
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_14
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_14
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_14
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_14
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_14
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_14
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_14
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_14
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_14
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_14
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_14
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_14
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(14) Then
                Writejobslvb.Position = Lv_cat_15
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_15
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_15
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_15
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_15
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_15
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_15
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_15
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_15
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_15
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_15
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_15
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_15
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_15
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_15
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_15
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_15
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_15
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_15
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_15
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(15) Then
                Writejobslvb.Position = Lv_cat_16
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_16
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_16
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_16
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_16
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_16
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_16
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_16
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_16
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_16
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_16
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_16
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_16
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_16
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_16
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_16
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_16
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_16
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_16
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_16
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(16) Then
                Writejobslvb.Position = Lv_cat_17
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_17
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_17
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_17
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_17
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_17
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_17
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_17
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_17
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_17
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_17
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_17
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_17
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_17
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_17
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_17
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_17
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_17
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_17
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_17
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(17) Then
                Writejobslvb.Position = Lv_cat_18
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_18
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_18
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_18
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_18
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_18
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_18
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_18
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_18
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_18
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_18
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_18
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_18
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_18
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_18
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_18
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_18
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_18
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_18
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_18
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(18) Then
                Writejobslvb.Position = Lv_cat_19
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_19
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_19
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_19
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_19
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_19
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_19
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_19
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_19
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_19
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_19
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_19
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_19
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_19
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_19
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_19
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_19
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_19
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_19
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_19
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(19) Then
                Writejobslvb.Position = Lv_cat_20
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_20
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_20
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_20
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_20
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_20
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_20
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_20
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_20
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_20
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_20
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_20
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_20
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_20
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_20
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_20
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_20
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_20
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_20
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_20
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(20) Then
                Writejobslvb.Position = Lv_cat_21
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_21
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_21
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_21
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_21
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_21
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_21
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_21
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_21
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_21
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_21
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_21
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_21
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_21
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_21
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_21
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_21
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_21
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_21
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_21
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(21) Then
                Writejobslvb.Position = Lv_cat_22
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_22
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_22
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_22
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_22
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_22
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_22
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_22
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_22
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_22
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_22
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_22
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_22
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_22
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_22
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_22
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_22
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_22
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_22
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_22
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(22) Then
                Writejobslvb.Position = Lv_cat_23
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_23
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_23
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_23
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_23
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_23
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_23
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_23
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_23
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_23
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_23
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_23
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_23
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_23
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_23
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_23
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_23
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_23
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_23
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_23
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(23) Then
                Writejobslvb.Position = Lv_cat_24
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_24
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_24
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_24
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_24
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_24
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_24
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_24
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_24
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_24
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_24
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_24
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_24
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_24
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_24
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_24
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_24
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_24
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_24
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_24
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(24) Then
                Writejobslvb.Position = Lv_cat_25
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_25
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_25
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_25
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_25
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_25
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_25
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_25
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_25
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_25
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_25
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_25
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_25
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_25
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_25
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_25
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_25
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_25
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_25
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_25
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(25) Then
                Writejobslvb.Position = Lv_cat_26
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_26
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_26
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_26
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_26
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_26
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_26
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_26
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_26
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_26
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_26
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_26
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_26
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_26
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_26
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_26
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_26
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_26
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_26
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_26
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(26) Then
                Writejobslvb.Position = Lv_cat_27
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_27
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_27
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_27
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_27
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_27
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_27
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_27
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_27
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_27
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_27
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_27
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_27
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_27
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_27
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_27
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_27
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_27
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_27
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_27
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(27) Then
                Writejobslvb.Position = Lv_cat_28
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_28
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_28
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_28
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_28
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_28
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_28
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_28
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_28
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_28
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_28
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_28
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_28
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_28
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_28
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_28
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_28
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_28
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_28
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_28
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(28) Then
                Writejobslvb.Position = Lv_cat_29
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_29
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_29
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_29
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_29
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_29
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_29
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_29
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_29
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_29
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_29
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_29
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_29
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_29
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_29
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_29
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_29
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_29
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_29
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_29
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(29) Then
                Writejobslvb.Position = Lv_cat_30
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_30
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_30
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_30
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_30
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_30
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_30
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_30
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_30
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_30
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_30
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_30
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_30
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_30
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_30
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_30
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_30
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_30
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_30
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_30
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(30) Then
                Writejobslvb.Position = Lv_cat_31
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_31
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_31
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_31
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_31
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_31
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_31
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_31
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_31
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_31
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_31
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_31
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_31
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_31
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_31
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_31
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_31
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_31
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_31
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_31
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(31) Then
                Writejobslvb.Position = Lv_cat_32
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_32
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_32
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_32
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_32
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_32
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_32
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_32
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_32
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_32
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_32
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_32
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_32
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_32
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_32
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_32
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_32
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_32
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_32
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_32
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(32) Then
                Writejobslvb.Position = Lv_cat_33
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_33
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_33
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_33
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_33
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_33
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_33
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_33
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_33
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_33
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_33
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_33
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_33
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_33
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_33
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_33
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_33
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_33
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_33
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_33
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(33) Then
                Writejobslvb.Position = Lv_cat_34
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_34
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_34
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_34
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_34
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_34
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_34
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_34
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_34
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_34
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_34
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_34
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_34
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_34
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_34
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_34
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_34
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_34
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_34
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_34
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(34) Then
                Writejobslvb.Position = Lv_cat_35
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_35
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_35
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_35
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_35
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_35
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_35
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_35
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_35
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_35
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_35
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_35
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_35
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_35
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_35
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_35
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_35
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_35
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_35
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_35
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(35) Then
                Writejobslvb.Position = Lv_cat_36
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_36
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_36
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_36
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_36
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_36
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_36
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_36
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_36
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_36
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_36
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_36
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_36
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_36
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_36
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_36
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_36
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_36
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_36
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_36
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(36) Then
                Writejobslvb.Position = Lv_cat_37
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_37
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_37
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_37
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_37
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_37
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_37
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_37
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_37
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_37
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_37
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_37
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_37
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_37
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_37
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_37
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_37
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_37
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_37
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_37
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(37) Then
                Writejobslvb.Position = Lv_cat_38
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_38
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_38
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_38
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_38
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_38
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_38
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_38
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_38
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_38
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_38
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_38
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_38
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_38
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_38
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_38
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_38
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_38
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_38
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_38
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(38) Then
                Writejobslvb.Position = Lv_cat_39
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_39
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_39
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_39
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_39
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_39
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_39
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_39
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_39
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_39
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_39
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_39
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_39
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_39
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_39
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_39
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_39
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_39
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_39
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_39
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(39) Then
                Writejobslvb.Position = Lv_cat_40
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_40
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_40
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_40
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_40
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_40
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_40
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_40
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_40
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_40
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_40
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_40
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_40
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_40
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_40
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_40
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_40
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_40
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_40
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_40
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(40) Then
                Writejobslvb.Position = Lv_cat_41
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_41
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_41
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_41
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_41
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_41
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_41
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_41
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_41
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_41
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_41
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_41
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_41
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_41
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_41
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_41
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_41
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_41
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_41
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_41
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(41) Then
                Writejobslvb.Position = Lv_cat_42
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_42
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_42
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_42
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_42
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_42
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_42
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_42
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_42
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_42
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_42
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_42
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_42
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_42
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_42
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_42
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_42
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_42
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_42
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_42
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(42) Then
                Writejobslvb.Position = Lv_cat_43
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_43
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_43
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_43
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_43
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_43
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_43
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_43
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_43
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_43
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_43
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_43
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_43
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_43
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_43
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_43
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_43
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_43
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_43
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_43
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(43) Then
                Writejobslvb.Position = Lv_cat_44
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_44
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_44
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_44
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_44
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_44
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_44
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_44
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_44
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_44
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_44
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_44
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_44
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_44
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_44
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_44
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_44
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_44
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_44
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_44
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(44) Then
                Writejobslvb.Position = Lv_cat_45
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_45
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_45
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_45
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_45
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_45
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_45
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_45
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_45
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_45
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_45
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_45
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_45
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_45
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_45
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_45
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_45
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_45
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_45
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_45
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(45) Then
                Writejobslvb.Position = Lv_cat_46
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_46
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_46
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_46
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_46
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_46
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_46
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_46
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_46
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_46
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_46
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_46
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_46
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_46
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_46
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_46
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_46
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_46
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_46
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_46
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(46) Then
                Writejobslvb.Position = Lv_cat_47
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_47
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_47
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_47
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_47
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_47
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_47
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_47
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_47
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_47
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_47
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_47
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_47
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_47
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_47
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_47
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_47
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_47
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_47
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_47
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(47) Then
                Writejobslvb.Position = Lv_cat_48
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_48
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_48
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_48
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_48
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_48
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_48
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_48
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_48
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_48
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_48
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_48
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_48
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_48
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_48
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_48
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_48
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_48
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_48
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_48
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(48) Then
                Writejobslvb.Position = Lv_cat_49
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_49
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_49
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_49
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_49
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_49
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_49
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_49
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_49
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_49
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_49
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_49
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_49
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_49
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_49
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_49
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_49
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_49
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_49
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_49
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(49) Then
                Writejobslvb.Position = Lv_cat_50
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_50
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_50
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_50
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_50
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_50
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_50
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_50
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_50
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_50
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_50
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_50
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_50
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_50
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_50
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_50
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_50
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_50
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_50
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_50
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(50) Then
                Writejobslvb.Position = Lv_cat_51
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_51
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_51
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_51
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_51
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_51
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_51
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_51
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_51
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_51
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_51
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_51
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_51
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_51
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_51
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_51
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_51
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_51
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_51
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_51
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(51) Then
                Writejobslvb.Position = Lv_cat_52
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_52
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_52
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_52
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_52
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_52
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_52
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_52
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_52
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_52
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_52
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_52
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_52
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_52
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_52
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_52
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_52
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_52
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_52
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_52
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(52) Then
                Writejobslvb.Position = Lv_cat_53
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_53
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_53
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_53
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_53
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_53
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_53
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_53
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_53
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_53
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_53
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_53
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_53
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_53
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_53
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_53
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_53
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_53
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_53
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_53
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(53) Then
                Writejobslvb.Position = Lv_cat_54
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_54
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_54
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_54
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_54
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_54
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_54
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_54
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_54
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_54
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_54
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_54
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_54
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_54
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_54
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_54
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_54
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_54
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_54
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_54
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(54) Then
                Writejobslvb.Position = Lv_cat_55
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_55
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_55
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_55
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_55
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_55
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_55
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_55
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_55
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_55
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_55
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_55
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_55
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_55
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_55
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_55
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_55
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_55
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_55
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_55
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(55) Then
                Writejobslvb.Position = Lv_cat_56
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_56
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_56
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_56
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_56
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_56
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_56
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_56
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_56
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_56
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_56
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_56
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_56
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_56
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_56
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_56
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_56
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_56
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_56
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_56
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(56) Then
                Writejobslvb.Position = Lv_cat_57
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_57
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_57
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_57
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_57
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_57
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_57
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_57
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_57
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_57
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_57
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_57
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_57
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_57
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_57
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_57
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_57
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_57
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_57
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_57
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(57) Then
                Writejobslvb.Position = Lv_cat_58
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_58
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_58
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_58
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_58
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_58
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_58
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_58
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_58
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_58
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_58
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_58
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_58
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_58
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_58
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_58
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_58
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_58
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_58
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_58
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(58) Then
                Writejobslvb.Position = Lv_cat_59
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_59
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_59
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_59
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_59
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_59
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_59
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_59
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_59
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_59
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_59
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_59
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_59
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_59
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_59
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_59
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_59
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_59
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_59
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_59
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(59) Then
                Writejobslvb.Position = Lv_cat_60
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_60
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_60
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_60
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_60
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_60
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_60
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_60
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_60
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_60
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_60
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_60
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_60
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_60
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_60
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_60
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_60
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_60
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_60
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_60
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(60) Then
                Writejobslvb.Position = Lv_cat_61
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_61
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_61
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_61
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_61
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_61
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_61
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_61
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_61
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_61
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_61
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_61
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_61
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_61
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_61
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_61
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_61
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_61
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_61
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_61
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(61) Then
                Writejobslvb.Position = Lv_cat_62
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_62
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_62
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_62
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_62
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_62
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_62
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_62
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_62
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_62
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_62
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_62
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_62
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_62
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_62
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_62
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_62
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_62
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_62
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_62
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(62) Then
                Writejobslvb.Position = Lv_cat_63
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_63
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_63
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_63
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_63
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_63
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_63
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_63
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_63
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_63
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_63
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_63
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_63
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_63
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_63
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_63
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_63
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_63
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_63
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_63
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(63) Then
                Writejobslvb.Position = Lv_cat_64
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_64
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_64
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_64
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_64
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_64
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_64
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_64
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_64
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_64
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_64
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_64
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_64
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_64
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_64
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_64
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_64
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_64
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_64
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_64
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(64) Then
                Writejobslvb.Position = Lv_cat_65
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_65
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_65
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_65
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_65
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_65
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_65
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_65
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_65
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_65
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_65
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_65
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_65
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_65
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_65
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_65
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_65
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_65
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_65
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_65
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(65) Then
                Writejobslvb.Position = Lv_cat_66
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_66
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_66
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_66
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_66
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_66
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_66
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_66
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_66
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_66
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_66
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_66
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_66
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_66
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_66
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_66
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_66
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_66
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_66
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_66
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(66) Then
                Writejobslvb.Position = Lv_cat_67
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_67
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_67
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_67
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_67
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_67
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_67
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_67
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_67
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_67
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_67
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_67
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_67
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_67
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_67
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_67
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_67
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_67
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_67
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_67
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(67) Then
                Writejobslvb.Position = Lv_cat_68
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_68
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_68
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_68
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_68
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_68
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_68
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_68
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_68
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_68
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_68
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_68
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_68
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_68
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_68
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_68
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_68
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_68
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_68
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_68
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(68) Then
                Writejobslvb.Position = Lv_cat_69
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_69
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_69
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_69
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_69
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_69
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_69
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_69
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_69
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_69
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_69
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_69
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_69
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_69
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_69
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_69
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_69
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_69
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_69
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_69
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(69) Then
                Writejobslvb.Position = Lv_cat_70
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_70
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_70
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_70
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_70
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_70
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_70
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_70
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_70
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_70
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_70
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_70
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_70
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_70
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_70
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_70
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_70
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_70
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_70
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_70
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(70) Then
                Writejobslvb.Position = Lv_cat_71
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_71
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_71
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_71
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_71
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_71
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_71
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_71
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_71
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_71
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_71
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_71
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_71
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_71
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_71
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_71
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_71
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_71
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_71
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_71
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(71) Then
                Writejobslvb.Position = Lv_cat_72
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_72
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_72
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_72
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_72
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_72
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_72
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_72
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_72
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_72
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_72
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_72
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_72
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_72
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_72
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_72
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_72
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_72
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_72
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_72
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(72) Then
                Writejobslvb.Position = Lv_cat_73
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_73
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_73
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_73
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_73
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_73
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_73
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_73
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_73
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_73
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_73
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_73
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_73
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_73
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_73
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_73
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_73
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_73
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_73
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_73
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(73) Then
                Writejobslvb.Position = Lv_cat_74
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_74
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_74
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_74
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_74
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_74
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_74
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_74
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_74
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_74
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_74
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_74
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_74
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_74
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_74
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_74
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_74
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_74
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_74
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_74
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(74) Then
                Writejobslvb.Position = Lv_cat_75
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_75
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_75
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_75
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_75
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_75
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_75
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_75
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_75
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_75
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_75
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_75
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_75
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_75
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_75
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_75
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_75
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_75
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_75
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_75
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(75) Then
                Writejobslvb.Position = Lv_cat_76
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_76
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_76
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_76
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_76
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_76
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_76
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_76
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_76
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_76
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_76
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_76
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_76
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_76
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_76
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_76
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_76
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_76
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_76
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_76
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(76) Then
                Writejobslvb.Position = Lv_cat_77
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_77
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_77
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_77
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_77
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_77
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_77
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_77
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_77
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_77
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_77
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_77
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_77
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_77
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_77
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_77
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_77
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_77
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_77
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_77
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(77) Then
                Writejobslvb.Position = Lv_cat_78
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_78
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_78
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_78
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_78
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_78
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_78
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_78
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_78
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_78
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_78
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_78
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_78
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_78
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_78
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_78
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_78
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_78
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_78
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_78
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(78) Then
                Writejobslvb.Position = Lv_cat_79
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_79
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_79
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_79
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_79
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_79
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_79
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_79
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_79
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_79
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_79
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_79
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_79
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_79
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_79
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_79
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_79
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_79
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_79
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_79
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(79) Then
                Writejobslvb.Position = Lv_cat_80
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_80
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_80
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_80
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_80
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_80
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_80
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_80
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_80
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_80
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_80
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_80
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_80
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_80
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_80
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_80
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_80
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_80
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_80
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_80
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(80) Then
                Writejobslvb.Position = Lv_cat_81
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_81
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_81
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_81
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_81
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_81
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_81
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_81
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_81
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_81
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_81
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_81
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_81
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_81
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_81
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_81
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_81
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_81
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_81
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_81
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(81) Then
                Writejobslvb.Position = Lv_cat_82
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_82
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_82
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_82
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_82
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_82
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_82
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_82
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_82
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_82
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_82
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_82
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_82
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_82
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_82
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_82
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_82
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_82
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_82
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_82
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(82) Then
                Writejobslvb.Position = Lv_cat_83
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_83
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_83
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_83
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_83
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_83
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_83
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_83
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_83
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_83
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_83
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_83
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_83
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_83
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_83
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_83
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_83
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_83
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_83
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_83
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(83) Then
                Writejobslvb.Position = Lv_cat_84
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_84
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_84
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_84
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_84
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_84
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_84
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_84
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_84
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_84
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_84
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_84
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_84
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_84
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_84
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_84
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_84
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_84
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_84
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_84
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(84) Then
                Writejobslvb.Position = Lv_cat_85
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_85
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_85
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_85
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_85
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_85
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_85
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_85
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_85
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_85
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_85
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_85
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_85
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_85
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_85
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_85
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_85
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_85
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_85
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_85
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(85) Then
                Writejobslvb.Position = Lv_cat_86
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_86
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_86
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_86
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_86
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_86
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_86
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_86
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_86
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_86
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_86
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_86
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_86
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_86
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_86
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_86
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_86
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_86
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_86
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_86
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(86) Then
                Writejobslvb.Position = Lv_cat_87
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_87
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_87
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_87
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_87
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_87
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_87
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_87
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_87
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_87
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_87
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_87
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_87
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_87
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_87
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_87
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_87
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_87
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_87
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_87
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(87) Then
                Writejobslvb.Position = Lv_cat_88
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_88
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_88
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_88
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_88
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_88
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_88
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_88
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_88
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_88
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_88
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_88
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_88
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_88
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_88
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_88
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_88
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_88
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_88
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_88
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(88) Then
                Writejobslvb.Position = Lv_cat_89
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_89
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_89
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_89
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_89
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_89
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_89
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_89
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_89
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_89
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_89
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_89
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_89
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_89
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_89
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_89
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_89
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_89
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_89
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_89
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(89) Then
                Writejobslvb.Position = Lv_cat_90
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_90
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_90
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_90
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_90
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_90
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_90
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_90
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_90
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_90
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_90
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_90
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_90
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_90
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_90
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_90
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_90
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_90
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_90
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_90
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(90) Then
                Writejobslvb.Position = Lv_cat_91
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_91
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_91
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_91
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_91
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_91
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_91
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_91
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_91
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_91
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_91
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_91
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_91
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_91
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_91
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_91
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_91
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_91
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_91
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_91
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(91) Then
                Writejobslvb.Position = Lv_cat_92
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_92
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_92
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_92
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_92
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_92
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_92
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_92
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_92
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_92
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_92
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_92
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_92
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_92
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_92
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_92
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_92
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_92
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_92
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_92
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(92) Then
                Writejobslvb.Position = Lv_cat_93
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_93
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_93
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_93
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_93
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_93
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_93
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_93
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_93
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_93
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_93
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_93
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_93
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_93
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_93
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_93
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_93
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_93
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_93
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_93
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(93) Then
                Writejobslvb.Position = Lv_cat_94
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_94
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_94
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_94
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_94
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_94
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_94
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_94
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_94
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_94
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_94
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_94
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_94
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_94
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_94
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_94
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_94
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_94
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_94
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_94
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(94) Then
                Writejobslvb.Position = Lv_cat_95
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_95
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_95
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_95
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_95
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_95
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_95
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_95
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_95
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_95
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_95
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_95
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_95
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_95
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_95
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_95
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_95
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_95
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_95
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_95
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(95) Then
                Writejobslvb.Position = Lv_cat_96
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_96
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_96
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_96
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_96
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_96
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_96
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_96
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_96
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_96
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_96
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_96
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_96
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_96
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_96
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_96
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_96
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_96
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_96
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_96
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(96) Then
                Writejobslvb.Position = Lv_cat_97
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_97
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_97
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_97
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_97
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_97
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_97
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_97
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_97
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_97
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_97
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_97
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_97
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_97
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_97
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_97
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_97
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_97
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_97
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_97
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(97) Then
                Writejobslvb.Position = Lv_cat_98
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_98
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_98
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_98
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_98
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_98
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_98
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_98
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_98
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_98
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_98
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_98
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_98
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_98
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_98
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_98
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_98
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_98
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_98
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_98
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(98) Then
                Writejobslvb.Position = Lv_cat_99
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_99
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_99
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_99
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_99
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_99
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_99
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_99
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_99
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_99
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_99
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_99
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_99
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_99
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_99
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_99
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_99
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_99
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_99
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_99
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(99) Then
                Writejobslvb.Position = Lv_cat_100
                Writejobslvb.WriteUInt32(valu_exp_cat.Value)
                Writejobslvb.Position = Lv_chef_100
                Writejobslvb.WriteUInt32(valu_exp_chef.Value)
                Writejobslvb.Position = Lv_cleric_100
                Writejobslvb.WriteUInt32(valu_exp_cleric.Value)
                Writejobslvb.Position = Lv_elf_100
                Writejobslvb.WriteUInt32(valu_exp_elf.Value)
                Writejobslvb.Position = Lv_flower_100
                Writejobslvb.WriteUInt32(valu_exp_flower.Value)
                Writejobslvb.Position = Lv_imp_100
                Writejobslvb.WriteUInt32(valu_exp_imp.Value)
                Writejobslvb.Position = Lv_mage_100
                Writejobslvb.WriteUInt32(valu_exp_mage.Value)
                Writejobslvb.Position = Lv_popstar_100
                Writejobslvb.WriteUInt32(valu_exp_popstar.Value)
                Writejobslvb.Position = Lv_princess_100
                Writejobslvb.WriteUInt32(valu_exp_princess.Value)
                Writejobslvb.Position = Lv_scientist_100
                Writejobslvb.WriteUInt32(valu_exp_scientist.Value)
                Writejobslvb.Position = Lv_tank_100
                Writejobslvb.WriteUInt32(valu_exp_tank.Value)
                Writejobslvb.Position = Lv_thief_100
                Writejobslvb.WriteUInt32(valu_exp_thief.Value)
                Writejobslvb.Position = Lv_vampire_100
                Writejobslvb.WriteUInt32(valu_exp_vampire.Value)
                Writejobslvb.Position = Lv_warrior_100
                Writejobslvb.WriteUInt32(valu_exp_warrior.Value)
                Writejobslvb.Position = Boost_attack_100
                Writejobslvb.WriteUInt32(valu_foodexp_attack.Value)
                Writejobslvb.Position = Boost_defense_100
                Writejobslvb.WriteUInt32(valu_foodexp_defense.Value)
                Writejobslvb.Position = Boost_hp_100
                Writejobslvb.WriteUInt32(valu_foodexp_hp.Value)
                Writejobslvb.Position = Boost_mp_100
                Writejobslvb.WriteUInt32(valu_foodexp_mp.Value)
                Writejobslvb.Position = Boost_magic_100
                Writejobslvb.WriteUInt32(valu_foodexp_magic.Value)
                Writejobslvb.Position = Boost_speed_100
                Writejobslvb.WriteUInt32(valu_foodexp_speed.Value)
            End If
            MSE_dialog.text_dialog.Text = "Jobs levels and boosts has been succefully edited"
            MSE_dialog.ShowDialog()
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to write Jobs levels and boosts" & vbNewLine & "Check if your save file is not used with an other application or report this issue"
            MSE_dialog.ShowDialog()
        End Try
    End Sub
End Class