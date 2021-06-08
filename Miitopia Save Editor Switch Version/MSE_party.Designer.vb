<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSE_party
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_party))
        Me.Icon_menu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_save = New System.Windows.Forms.Label()
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.MSE_title = New System.Windows.Forms.PictureBox()
        Me.Icon_minimize = New System.Windows.Forms.PictureBox()
        Me.Icon_close = New System.Windows.Forms.PictureBox()
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.Panel_partylevel = New System.Windows.Forms.GroupBox()
        Me.valu_level = New System.Windows.Forms.NumericUpDown()
        Me.Iconwar_partylevel = New System.Windows.Forms.PictureBox()
        Me.Panel_partyworld = New System.Windows.Forms.GroupBox()
        Me.valu_world = New System.Windows.Forms.NumericUpDown()
        Me.Select_world = New System.Windows.Forms.ComboBox()
        Me.Group_party = New System.Windows.Forms.GroupBox()
        Me.valu_party = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.icon_party = New System.Windows.Forms.PictureBox()
        Me.Icon_dragon = New System.Windows.Forms.PictureBox()
        Me.Panel_description = New System.Windows.Forms.Panel()
        Me.Text_description = New System.Windows.Forms.Label()
        Me.valu_dragon = New System.Windows.Forms.NumericUpDown()
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_partylevel.SuspendLayout()
        CType(Me.valu_level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Iconwar_partylevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_partyworld.SuspendLayout()
        CType(Me.valu_world, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_party.SuspendLayout()
        CType(Me.valu_party, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icon_party, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_dragon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_description.SuspendLayout()
        CType(Me.valu_dragon, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.button_save
        Me.Panel2.Controls.Add(Me.Button_save)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(717, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(110, 45)
        Me.Panel2.TabIndex = 22
        '
        'Button_save
        '
        Me.Button_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_save.ForeColor = System.Drawing.Color.White
        Me.Button_save.Location = New System.Drawing.Point(0, 0)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(110, 45)
        Me.Button_save.TabIndex = 1
        Me.Button_save.Text = "Save"
        Me.Button_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSE_header
        '
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
        'Panel_partylevel
        '
        Me.Panel_partylevel.BackColor = System.Drawing.Color.Transparent
        Me.Panel_partylevel.BackgroundImage = CType(resources.GetObject("Panel_partylevel.BackgroundImage"), System.Drawing.Image)
        Me.Panel_partylevel.Controls.Add(Me.valu_level)
        Me.Panel_partylevel.Location = New System.Drawing.Point(503, 149)
        Me.Panel_partylevel.Name = "Panel_partylevel"
        Me.Panel_partylevel.Size = New System.Drawing.Size(207, 40)
        Me.Panel_partylevel.TabIndex = 25
        Me.Panel_partylevel.TabStop = False
        Me.Panel_partylevel.Text = "Party is in level"
        '
        'valu_level
        '
        Me.valu_level.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_level.Location = New System.Drawing.Point(73, 16)
        Me.valu_level.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.valu_level.Name = "valu_level"
        Me.valu_level.Size = New System.Drawing.Size(90, 16)
        Me.valu_level.TabIndex = 0
        Me.valu_level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Iconwar_partylevel
        '
        Me.Iconwar_partylevel.BackColor = System.Drawing.Color.Transparent
        Me.Iconwar_partylevel.Cursor = System.Windows.Forms.Cursors.Help
        Me.Iconwar_partylevel.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_warning
        Me.Iconwar_partylevel.Location = New System.Drawing.Point(502, 125)
        Me.Iconwar_partylevel.Name = "Iconwar_partylevel"
        Me.Iconwar_partylevel.Size = New System.Drawing.Size(26, 24)
        Me.Iconwar_partylevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Iconwar_partylevel.TabIndex = 18
        Me.Iconwar_partylevel.TabStop = False
        '
        'Panel_partyworld
        '
        Me.Panel_partyworld.BackColor = System.Drawing.Color.Transparent
        Me.Panel_partyworld.BackgroundImage = CType(resources.GetObject("Panel_partyworld.BackgroundImage"), System.Drawing.Image)
        Me.Panel_partyworld.Controls.Add(Me.valu_world)
        Me.Panel_partyworld.Controls.Add(Me.Select_world)
        Me.Panel_partyworld.Location = New System.Drawing.Point(120, 149)
        Me.Panel_partyworld.Name = "Panel_partyworld"
        Me.Panel_partyworld.Size = New System.Drawing.Size(207, 40)
        Me.Panel_partyworld.TabIndex = 24
        Me.Panel_partyworld.TabStop = False
        Me.Panel_partyworld.Text = "Party is in world"
        '
        'valu_world
        '
        Me.valu_world.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_world.Location = New System.Drawing.Point(3, 16)
        Me.valu_world.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.valu_world.Name = "valu_world"
        Me.valu_world.Size = New System.Drawing.Size(36, 16)
        Me.valu_world.TabIndex = 1
        Me.valu_world.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_world.Visible = False
        '
        'Select_world
        '
        Me.Select_world.BackColor = System.Drawing.Color.White
        Me.Select_world.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_world.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_world.FormattingEnabled = True
        Me.Select_world.Items.AddRange(New Object() {"Greenhorne", "Riverdeep Cavern", "Nightmare Tower", "Neksdor", "Underground Maze", "Great Pyramid", "Realm of the Fey", "Citrus Cave", "Lotus Lake", "Karkaton Ascent", "Karkaton", "Dark Lord's Castle", "Armory", "Inner Passage", "Dark Lord's Throne", "Powdered Peaks", "Peculia", "Peculia Warp (Forest)", "Peculia Warp (Desert)", "Peculia Warp (Castle)", "Nimbus", "Sterile Plant", "The Sky Scraper", "Otherworld", "The Sky Scraper (Entrance)", "Travelers' Hub (Overworld Only)", "Galados Isle (Overworld Only)", "New Lumos", "New Lumos (1st District)", "New Lumos (2nd District)", "New Lumos (3rd District)", "New Lumos (4th District)", "New Lumos (5th District)", "New Lumos (6th District)", "New Lumos (7th District)", "New Lumos (8th District)", "Random Quest (Lotus Lake)", "Random Quest (Pyramid)", "Random Quest (No BG)", "Random Quest (Quizmaster)", "Random Quest (No BG) (2)", "Random Quest (No BG, Split Party)", "Random Quest (No BG) (3)", "Random Quest (No BG) (4)"})
        Me.Select_world.Location = New System.Drawing.Point(18, 14)
        Me.Select_world.Name = "Select_world"
        Me.Select_world.Size = New System.Drawing.Size(170, 21)
        Me.Select_world.TabIndex = 0
        '
        'Group_party
        '
        Me.Group_party.BackColor = System.Drawing.Color.Transparent
        Me.Group_party.BackgroundImage = CType(resources.GetObject("Group_party.BackgroundImage"), System.Drawing.Image)
        Me.Group_party.Controls.Add(Me.valu_party)
        Me.Group_party.Controls.Add(Me.PictureBox5)
        Me.Group_party.Controls.Add(Me.icon_party)
        Me.Group_party.Location = New System.Drawing.Point(234, 221)
        Me.Group_party.Name = "Group_party"
        Me.Group_party.Size = New System.Drawing.Size(164, 81)
        Me.Group_party.TabIndex = 26
        Me.Group_party.TabStop = False
        Me.Group_party.Text = "The party is in"
        '
        'valu_party
        '
        Me.valu_party.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_party.Location = New System.Drawing.Point(39, 15)
        Me.valu_party.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.valu_party.Name = "valu_party"
        Me.valu_party.Size = New System.Drawing.Size(39, 16)
        Me.valu_party.TabIndex = 3
        Me.valu_party.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_party.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 31)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'icon_party
        '
        Me.icon_party.Cursor = System.Windows.Forms.Cursors.Hand
        Me.icon_party.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_inn
        Me.icon_party.Location = New System.Drawing.Point(84, 15)
        Me.icon_party.Name = "icon_party"
        Me.icon_party.Size = New System.Drawing.Size(64, 64)
        Me.icon_party.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.icon_party.TabIndex = 1
        Me.icon_party.TabStop = False
        '
        'Icon_dragon
        '
        Me.Icon_dragon.BackColor = System.Drawing.Color.Transparent
        Me.Icon_dragon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_dragon.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_dragon_off
        Me.Icon_dragon.Location = New System.Drawing.Point(502, 214)
        Me.Icon_dragon.Name = "Icon_dragon"
        Me.Icon_dragon.Size = New System.Drawing.Size(94, 80)
        Me.Icon_dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Icon_dragon.TabIndex = 27
        Me.Icon_dragon.TabStop = False
        '
        'Panel_description
        '
        Me.Panel_description.BackColor = System.Drawing.Color.Transparent
        Me.Panel_description.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_description
        Me.Panel_description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_description.Controls.Add(Me.Text_description)
        Me.Panel_description.Location = New System.Drawing.Point(0, 319)
        Me.Panel_description.Name = "Panel_description"
        Me.Panel_description.Size = New System.Drawing.Size(830, 40)
        Me.Panel_description.TabIndex = 28
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
        'valu_dragon
        '
        Me.valu_dragon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_dragon.Location = New System.Drawing.Point(503, 278)
        Me.valu_dragon.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.valu_dragon.Name = "valu_dragon"
        Me.valu_dragon.Size = New System.Drawing.Size(36, 16)
        Me.valu_dragon.TabIndex = 29
        Me.valu_dragon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_dragon.Visible = False
        '
        'MSE_party
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_blue
        Me.ClientSize = New System.Drawing.Size(830, 360)
        Me.Controls.Add(Me.Iconwar_partylevel)
        Me.Controls.Add(Me.valu_dragon)
        Me.Controls.Add(Me.Panel_description)
        Me.Controls.Add(Me.Icon_dragon)
        Me.Controls.Add(Me.Group_party)
        Me.Controls.Add(Me.Panel_partylevel)
        Me.Controls.Add(Me.Panel_partyworld)
        Me.Controls.Add(Me.Icon_menu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSE_party"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSE_party"
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MSE_header.ResumeLayout(False)
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_partylevel.ResumeLayout(False)
        CType(Me.valu_level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Iconwar_partylevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_partyworld.ResumeLayout(False)
        CType(Me.valu_world, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_party.ResumeLayout(False)
        CType(Me.valu_party, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icon_party, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_dragon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_description.ResumeLayout(False)
        CType(Me.valu_dragon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Icon_menu As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_save As Label
    Friend WithEvents MSE_header As Panel
    Friend WithEvents MSE_title As PictureBox
    Friend WithEvents Icon_minimize As PictureBox
    Friend WithEvents Icon_close As PictureBox
    Friend WithEvents MSE_logo As PictureBox
    Friend WithEvents Panel_partylevel As GroupBox
    Friend WithEvents Iconwar_partylevel As PictureBox
    Friend WithEvents valu_level As NumericUpDown
    Friend WithEvents Panel_partyworld As GroupBox
    Friend WithEvents valu_world As NumericUpDown
    Friend WithEvents Select_world As ComboBox
    Friend WithEvents Group_party As GroupBox
    Friend WithEvents valu_party As NumericUpDown
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents icon_party As PictureBox
    Friend WithEvents Icon_dragon As PictureBox
    Friend WithEvents Panel_description As Panel
    Friend WithEvents Text_description As Label
    Friend WithEvents valu_dragon As NumericUpDown
End Class
