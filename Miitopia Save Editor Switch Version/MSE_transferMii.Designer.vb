<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSE_transferMii
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_transferMii))
        Me.Icon_menu = New System.Windows.Forms.PictureBox()
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.MSE_title = New System.Windows.Forms.PictureBox()
        Me.Icon_minimize = New System.Windows.Forms.PictureBox()
        Me.Icon_close = New System.Windows.Forms.PictureBox()
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.Panel_description = New System.Windows.Forms.Panel()
        Me.Text_description = New System.Windows.Forms.Label()
        Me.Text_Mii_appareanceI = New System.Windows.Forms.TextBox()
        Me.Text_Mii_appareanceE = New System.Windows.Forms.TextBox()
        Me.Select_Mii = New System.Windows.Forms.ComboBox()
        Me.Icon_import = New System.Windows.Forms.PictureBox()
        Me.Icon_extract = New System.Windows.Forms.PictureBox()
        Me.Text_Miiname = New System.Windows.Forms.Label()
        Me.Iconwar_partylevel = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_description.SuspendLayout()
        CType(Me.Icon_import, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_extract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Iconwar_partylevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Icon_menu
        '
        Me.Icon_menu.BackColor = System.Drawing.Color.Transparent
        Me.Icon_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_menu.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_menu
        Me.Icon_menu.Location = New System.Drawing.Point(120, 50)
        Me.Icon_menu.Name = "Icon_menu"
        Me.Icon_menu.Size = New System.Drawing.Size(62, 50)
        Me.Icon_menu.TabIndex = 23
        Me.Icon_menu.TabStop = False
        '
        'MSE_header
        '
        Me.MSE_header.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_white
        Me.MSE_header.Controls.Add(Me.MSE_title)
        Me.MSE_header.Controls.Add(Me.Icon_minimize)
        Me.MSE_header.Controls.Add(Me.Icon_close)
        Me.MSE_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.MSE_header.Location = New System.Drawing.Point(120, 0)
        Me.MSE_header.Name = "MSE_header"
        Me.MSE_header.Size = New System.Drawing.Size(710, 50)
        Me.MSE_header.TabIndex = 21
        '
        'MSE_title
        '
        Me.MSE_title.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.MSE_title.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.MSE_title
        Me.MSE_title.Location = New System.Drawing.Point(83, 7)
        Me.MSE_title.Name = "MSE_title"
        Me.MSE_title.Size = New System.Drawing.Size(414, 37)
        Me.MSE_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MSE_title.TabIndex = 2
        Me.MSE_title.TabStop = False
        '
        'Icon_minimize
        '
        Me.Icon_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_minimize.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_minimize
        Me.Icon_minimize.Location = New System.Drawing.Point(590, 0)
        Me.Icon_minimize.Name = "Icon_minimize"
        Me.Icon_minimize.Size = New System.Drawing.Size(60, 50)
        Me.Icon_minimize.TabIndex = 1
        Me.Icon_minimize.TabStop = False
        '
        'Icon_close
        '
        Me.Icon_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_close.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_close
        Me.Icon_close.Location = New System.Drawing.Point(650, 0)
        Me.Icon_close.Name = "Icon_close"
        Me.Icon_close.Size = New System.Drawing.Size(60, 50)
        Me.Icon_close.TabIndex = 0
        Me.Icon_close.TabStop = False
        '
        'MSE_logo
        '
        Me.MSE_logo.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.MSE_logo
        Me.MSE_logo.Location = New System.Drawing.Point(0, 0)
        Me.MSE_logo.Name = "MSE_logo"
        Me.MSE_logo.Size = New System.Drawing.Size(120, 100)
        Me.MSE_logo.TabIndex = 20
        Me.MSE_logo.TabStop = False
        '
        'Panel_description
        '
        Me.Panel_description.BackColor = System.Drawing.Color.Transparent
        Me.Panel_description.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_description
        Me.Panel_description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_description.Controls.Add(Me.Text_description)
        Me.Panel_description.Location = New System.Drawing.Point(0, 320)
        Me.Panel_description.Name = "Panel_description"
        Me.Panel_description.Size = New System.Drawing.Size(830, 40)
        Me.Panel_description.TabIndex = 37
        Me.Panel_description.Visible = False
        '
        'Text_description
        '
        Me.Text_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_description.ForeColor = System.Drawing.Color.White
        Me.Text_description.Location = New System.Drawing.Point(65, 0)
        Me.Text_description.Name = "Text_description"
        Me.Text_description.Size = New System.Drawing.Size(700, 40)
        Me.Text_description.TabIndex = 0
        Me.Text_description.Text = "Miitopia Save Editor"
        Me.Text_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_Mii_appareanceI
        '
        Me.Text_Mii_appareanceI.Location = New System.Drawing.Point(480, 163)
        Me.Text_Mii_appareanceI.MaxLength = 999999999
        Me.Text_Mii_appareanceI.Multiline = True
        Me.Text_Mii_appareanceI.Name = "Text_Mii_appareanceI"
        Me.Text_Mii_appareanceI.Size = New System.Drawing.Size(181, 122)
        Me.Text_Mii_appareanceI.TabIndex = 45
        Me.Text_Mii_appareanceI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text_Mii_appareanceI.Visible = False
        '
        'Text_Mii_appareanceE
        '
        Me.Text_Mii_appareanceE.Location = New System.Drawing.Point(262, 163)
        Me.Text_Mii_appareanceE.MaxLength = 999999999
        Me.Text_Mii_appareanceE.Multiline = True
        Me.Text_Mii_appareanceE.Name = "Text_Mii_appareanceE"
        Me.Text_Mii_appareanceE.Size = New System.Drawing.Size(181, 122)
        Me.Text_Mii_appareanceE.TabIndex = 44
        Me.Text_Mii_appareanceE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text_Mii_appareanceE.Visible = False
        '
        'Select_Mii
        '
        Me.Select_Mii.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Select_Mii.DropDownHeight = 80
        Me.Select_Mii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_Mii.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_Mii.FormattingEnabled = True
        Me.Select_Mii.IntegralHeight = False
        Me.Select_Mii.Items.AddRange(New Object() {"Mii 1", "Mii 2", "Mii 3", "Mii 4", "Mii 5", "Mii 6", "Mii 7", "Mii 8", "Mii 9", "Mii 10", "Mii 11", "Mii 12", "Mii 13", "Mii 14", "Mii 15", "Mii 16", "Mii 17", "Mii 18", "Mii 19", "Mii 20", "Mii 21", "Mii 22", "Mii 23", "Mii 24", "Mii 25", "Mii 26", "Mii 27", "Mii 28", "Mii 29", "Mii 30", "Mii 31", "Mii 32", "Mii 33", "Mii 34", "Mii 35", "Mii 36", "Mii 37", "Mii 38", "Mii 39", "Mii 40", "Mii 41", "Mii 42", "Mii 43", "Mii 44", "Mii 45", "Mii 46", "Mii 47", "Mii 48", "Mii 49", "Mii 50", "Mii 51", "Mii 52", "Mii 53", "Mii 54", "Mii 55", "Mii 56", "Mii 57", "Mii 58", "Mii 59", "Mii 60", "Mii 61", "Mii 62", "Mii 63", "Mii 64", "Mii 65", "Mii 66", "Mii 67", "Mii 68", "Mii 69", "Mii 70", "Mii 71", "Mii 72", "Mii 73", "Mii 74", "Mii 75", "Mii 76", "Mii 77", "Mii 78", "Mii 79", "Mii 80", "Mii 81", "Mii 82", "Mii 83", "Mii 84", "Mii 85", "Mii 86", "Mii 87", "Mii 88", "Mii 89", "Mii 90", "Mii 91", "Mii 92", "Mii 93", "Mii 94", "Mii 95", "Mii 96", "Mii 97", "Mii 98", "Mii 99", "Mii 100", "Mii 101", "Mii 102", "Mii 103", "Mii 104", "Mii 105", "Mii 106", "Mii 107", "Mii 108", "Mii 109", "Mii 110", "Mii 111", "Mii 112", "Mii 113", "Mii 114", "Mii 115", "Mii 116", "Mii 117", "Mii 118", "Mii 119", "Mii 120", "Mii 121", "Mii 122", "Mii 123", "Mii 124", "Mii 125", "Mii 126", "Mii 127", "Mii 128", "Mii 129", "Mii 130", "Mii 131", "Mii 132", "Mii 133", "Mii 134", "Mii 135", "Mii 136", "Mii 137", "Mii 138", "Mii 139", "Mii 140", "Mii 141", "Mii 142", "Mii 143", "Mii 144", "Mii 145", "Mii 146", "Mii 147", "Mii 148", "Mii 149", "Mii 150", "Mii 151", "Mii 152", "Mii 153", "Mii 154", "Mii 155", "Mii 156", "Mii 157", "Mii 158", "Mii 159", "Mii 160", "Mii 161", "Mii 162", "Mii 163", "Mii 164", "Mii 165", "Mii 166", "Mii 167", "Mii 168", "Mii 169", "Mii 170", "Mii 171", "Mii 172", "Mii 173", "Mii 174", "Mii 175", "Mii 176", "Mii 177", "Mii 178", "Mii 179", "Mii 180", "Mii 181", "Mii 182", "Mii 183", "Mii 184", "Mii 185", "Mii 186", "Mii 187", "Mii 188", "Mii 189", "Mii 190", "Mii 191", "Mii 192", "Mii 193", "Mii 194", "Mii 195", "Mii 196", "Mii 197", "Mii 198", "Mii 199", "Mii 200", "Mii 201", "Mii 202", "Mii 203", "Mii 204", "Mii 205", "Mii 206", "Mii 207", "Mii 208", "Mii 209", "Mii 210", "Mii 211", "Mii 212", "Mii 213", "Mii 214", "Mii 215", "Mii 216", "Mii 217", "Mii 218", "Mii 219", "Mii 220", "Mii 221", "Mii 222", "Mii 223", "Mii 224", "Mii 225", "Mii 226", "Mii 227", "Mii 228", "Mii 229", "Mii 230", "Mii 231", "Mii 232", "Mii 233", "Mii 234", "Mii 235", "Mii 236", "Mii 237", "Mii 238", "Mii 239", "Mii 240", "Mii 241", "Mii 242", "Mii 243", "Mii 244", "Mii 245", "Mii 246", "Mii 247", "Mii 248", "Mii 249", "Mii 250", "Mii 251", "Mii 252", "Mii 253", "Mii 254", "Mii 255", "Mii 256", "Mii 257", "Mii 258", "Mii 259", "Mii 260", "Mii 261", "Mii 262", "Mii 263", "Mii 264", "Mii 265", "Mii 266", "Mii 267", "Mii 268", "Mii 269", "Mii 270", "Mii 271", "Mii 272", "Mii 273", "Mii 274", "Mii 275", "Mii 276", "Mii 277", "Mii 278", "Mii 279", "Mii 280", "Mii 281", "Mii 282", "Mii 283", "Mii 284", "Mii 285", "Mii 286", "Mii 287", "Mii 288", "Mii 289", "Mii 290", "Mii 291", "Mii 292", "Mii 293", "Mii 294", "Mii 295", "Mii 296", "Mii 297", "Mii 298", "Mii 299", "Mii 300", "Mii 301", "Mii 302", "Mii 303", "Mii 304", "Mii 305", "Mii 306", "Mii 307", "Mii 308", "Mii 309", "Mii 310", "Mii 311", "Mii 312", "Mii 313", "Mii 314", "Mii 315", "Mii 316", "Mii 317", "Mii 318", "Mii 319", "Mii 320", "Mii 321", "Mii 322", "Mii 323", "Mii 324", "Mii 325", "Mii 326", "Mii 327", "Mii 328", "Mii 329", "Mii 330", "Mii 331", "Mii 332", "Mii 333", "Mii 334", "Mii 335", "Mii 336", "Mii 337", "Mii 338", "Mii 339", "Mii 340", "Mii 341", "Mii 342", "Mii 343", "Mii 344", "Mii 345", "Mii 346", "Mii 347", "Mii 348", "Mii 349", "Mii 350", "Mii 351", "Mii 352", "Mii 353", "Mii 354", "Mii 355", "Mii 356", "Mii 357", "Mii 358", "Mii 359", "Mii 360", "Mii 361", "Mii 362", "Mii 363", "Mii 364", "Mii 365", "Mii 366", "Mii 367", "Mii 368", "Mii 369", "Mii 370", "Mii 371", "Mii 372", "Mii 373", "Mii 374", "Mii 375", "Mii 376", "Mii 377", "Mii 378", "Mii 379", "Mii 380", "Mii 381", "Mii 382", "Mii 383", "Mii 384", "Mii 385", "Mii 386", "Mii 387", "Mii 388", "Mii 389", "Mii 390", "Mii 391", "Mii 392", "Mii 393", "Mii 394", "Mii 395", "Mii 396", "Mii 397", "Mii 398", "Mii 399", "Mii 400", "Mii 401", "Mii 402", "Mii 403", "Mii 404", "Mii 405", "Mii 406", "Mii 407", "Mii 408", "Mii 409", "Mii 410", "Mii 411", "Mii 412", "Mii 413", "Mii 414", "Mii 415", "Mii 416", "Mii 417", "Mii 418", "Mii 419", "Mii 420", "Mii 421", "Mii 422", "Mii 423", "Mii 424", "Mii 425", "Mii 426", "Mii 427", "Mii 428", "Mii 429", "Mii 430", "Mii 431", "Mii 432", "Mii 433", "Mii 434", "Mii 435", "Mii 436", "Mii 437", "Mii 438", "Mii 439", "Mii 440", "Mii 441", "Mii 442", "Mii 443", "Mii 444", "Mii 445", "Mii 446", "Mii 447", "Mii 448", "Mii 449", "Mii 450", "Mii 451", "Mii 452", "Mii 453", "Mii 454", "Mii 455", "Mii 456", "Mii 457", "Mii 458", "Mii 459", "Mii 460", "Mii 461", "Mii 462", "Mii 463", "Mii 464", "Mii 465", "Mii 466", "Mii 467", "Mii 468", "Mii 469", "Mii 470", "Mii 471", "Mii 472", "Mii 473", "Mii 474", "Mii 475", "Mii 476", "Mii 477", "Mii 478", "Mii 479", "Mii 480", "Mii 481", "Mii 482", "Mii 483", "Mii 484", "Mii 485", "Mii 486", "Mii 487", "Mii 488", "Mii 489", "Mii 490", "Mii 491", "Mii 492", "Mii 493", "Mii 494", "Mii 495", "Mii 496", "Mii 497", "Mii 498", "Mii 499", "Mii 500"})
        Me.Select_Mii.Location = New System.Drawing.Point(114, 136)
        Me.Select_Mii.Name = "Select_Mii"
        Me.Select_Mii.Size = New System.Drawing.Size(142, 21)
        Me.Select_Mii.TabIndex = 43
        '
        'Icon_import
        '
        Me.Icon_import.BackColor = System.Drawing.Color.Transparent
        Me.Icon_import.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_import.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_import
        Me.Icon_import.Location = New System.Drawing.Point(667, 228)
        Me.Icon_import.Name = "Icon_import"
        Me.Icon_import.Size = New System.Drawing.Size(50, 41)
        Me.Icon_import.TabIndex = 42
        Me.Icon_import.TabStop = False
        '
        'Icon_extract
        '
        Me.Icon_extract.BackColor = System.Drawing.Color.Transparent
        Me.Icon_extract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_extract.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_extract
        Me.Icon_extract.Location = New System.Drawing.Point(206, 228)
        Me.Icon_extract.Name = "Icon_extract"
        Me.Icon_extract.Size = New System.Drawing.Size(50, 41)
        Me.Icon_extract.TabIndex = 41
        Me.Icon_extract.TabStop = False
        '
        'Text_Miiname
        '
        Me.Text_Miiname.BackColor = System.Drawing.Color.Transparent
        Me.Text_Miiname.Location = New System.Drawing.Point(263, 136)
        Me.Text_Miiname.Name = "Text_Miiname"
        Me.Text_Miiname.Size = New System.Drawing.Size(111, 21)
        Me.Text_Miiname.TabIndex = 46
        Me.Text_Miiname.Text = "Mii"
        Me.Text_Miiname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Iconwar_partylevel
        '
        Me.Iconwar_partylevel.BackColor = System.Drawing.Color.Transparent
        Me.Iconwar_partylevel.Cursor = System.Windows.Forms.Cursors.Help
        Me.Iconwar_partylevel.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_warning
        Me.Iconwar_partylevel.Location = New System.Drawing.Point(188, 76)
        Me.Iconwar_partylevel.Name = "Iconwar_partylevel"
        Me.Iconwar_partylevel.Size = New System.Drawing.Size(26, 24)
        Me.Iconwar_partylevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Iconwar_partylevel.TabIndex = 47
        Me.Iconwar_partylevel.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(217, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Import a Mii appareance on a existing Mii"
        '
        'MSE_transferMii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_lightgreen
        Me.ClientSize = New System.Drawing.Size(830, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Iconwar_partylevel)
        Me.Controls.Add(Me.Text_Miiname)
        Me.Controls.Add(Me.Text_Mii_appareanceI)
        Me.Controls.Add(Me.Text_Mii_appareanceE)
        Me.Controls.Add(Me.Select_Mii)
        Me.Controls.Add(Me.Icon_import)
        Me.Controls.Add(Me.Icon_extract)
        Me.Controls.Add(Me.Panel_description)
        Me.Controls.Add(Me.Icon_menu)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSE_transferMii"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSE_transferMii"
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSE_header.ResumeLayout(False)
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_description.ResumeLayout(False)
        CType(Me.Icon_import, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_extract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Iconwar_partylevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Icon_menu As PictureBox
    Friend WithEvents MSE_header As Panel
    Friend WithEvents MSE_title As PictureBox
    Friend WithEvents Icon_minimize As PictureBox
    Friend WithEvents Icon_close As PictureBox
    Friend WithEvents MSE_logo As PictureBox
    Friend WithEvents Panel_description As Panel
    Friend WithEvents Text_description As Label
    Friend WithEvents Text_Mii_appareanceI As TextBox
    Friend WithEvents Text_Mii_appareanceE As TextBox
    Friend WithEvents Select_Mii As ComboBox
    Friend WithEvents Icon_import As PictureBox
    Friend WithEvents Icon_extract As PictureBox
    Friend WithEvents Text_Miiname As Label
    Friend WithEvents Iconwar_partylevel As PictureBox
    Friend WithEvents Label1 As Label
End Class
