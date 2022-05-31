<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSE_hub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_hub))
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.MSE_title = New System.Windows.Forms.PictureBox()
        Me.Icon_minimize = New System.Windows.Forms.PictureBox()
        Me.Icon_close = New System.Windows.Forms.PictureBox()
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.Menu_inventory = New System.Windows.Forms.Panel()
        Me.Menu_text_inventory = New System.Windows.Forms.Label()
        Me.Panel_description = New System.Windows.Forms.Panel()
        Me.Text_description = New System.Windows.Forms.Label()
        Me.MSE_version = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_open = New System.Windows.Forms.Label()
        Me.Text_filepath = New System.Windows.Forms.TextBox()
        Me.Menu_unlockable = New System.Windows.Forms.Panel()
        Me.Menu_text_unlockable = New System.Windows.Forms.Label()
        Me.Menu_success = New System.Windows.Forms.Panel()
        Me.Menu_text_success = New System.Windows.Forms.Label()
        Me.MSE_logo_update = New System.Windows.Forms.PictureBox()
        Me.valu_checkMSEupdate = New System.Windows.Forms.NumericUpDown()
        Me.Menu_party = New System.Windows.Forms.Panel()
        Me.Menu_text_party = New System.Windows.Forms.Label()
        Me.Menu_horse = New System.Windows.Forms.Panel()
        Me.Menu_text_horse = New System.Windows.Forms.Label()
        Me.Menu_grubs = New System.Windows.Forms.Panel()
        Me.Menu_text_grubs = New System.Windows.Forms.Label()
        Me.Menu_transferMii = New System.Windows.Forms.Panel()
        Me.Menu_text_transferMii = New System.Windows.Forms.Label()
        Me.Menu_jobslevelsboosts = New System.Windows.Forms.Panel()
        Me.Menu_text_jobslevelsboosts = New System.Windows.Forms.Label()
        Me.Menu_catalog = New System.Windows.Forms.Panel()
        Me.Menu_text_catalog = New System.Windows.Forms.Label()
        Me.Menu_miiprofile = New System.Windows.Forms.Panel()
        Me.Menu_text_miiprofile = New System.Windows.Forms.Label()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_inventory.SuspendLayout()
        Me.Panel_description.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Menu_unlockable.SuspendLayout()
        Me.Menu_success.SuspendLayout()
        CType(Me.MSE_logo_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valu_checkMSEupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_party.SuspendLayout()
        Me.Menu_horse.SuspendLayout()
        Me.Menu_grubs.SuspendLayout()
        Me.Menu_transferMii.SuspendLayout()
        Me.Menu_jobslevelsboosts.SuspendLayout()
        Me.Menu_catalog.SuspendLayout()
        Me.Menu_miiprofile.SuspendLayout()
        Me.SuspendLayout()
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
        Me.MSE_header.TabIndex = 1
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
        Me.MSE_logo.TabIndex = 0
        Me.MSE_logo.TabStop = False
        '
        'Menu_inventory
        '
        Me.Menu_inventory.BackColor = System.Drawing.Color.Transparent
        Me.Menu_inventory.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_inventory_off
        Me.Menu_inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_inventory.Controls.Add(Me.Menu_text_inventory)
        Me.Menu_inventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_inventory.Location = New System.Drawing.Point(28, 121)
        Me.Menu_inventory.Name = "Menu_inventory"
        Me.Menu_inventory.Size = New System.Drawing.Size(160, 120)
        Me.Menu_inventory.TabIndex = 2
        '
        'Menu_text_inventory
        '
        Me.Menu_text_inventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_inventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_inventory.ForeColor = System.Drawing.Color.White
        Me.Menu_text_inventory.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_inventory.Name = "Menu_text_inventory"
        Me.Menu_text_inventory.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_inventory.TabIndex = 0
        Me.Menu_text_inventory.Text = "Inventory"
        Me.Menu_text_inventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_description
        '
        Me.Panel_description.BackColor = System.Drawing.Color.Transparent
        Me.Panel_description.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_description
        Me.Panel_description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_description.Controls.Add(Me.Text_description)
        Me.Panel_description.Location = New System.Drawing.Point(0, 519)
        Me.Panel_description.Name = "Panel_description"
        Me.Panel_description.Size = New System.Drawing.Size(830, 40)
        Me.Panel_description.TabIndex = 3
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
        'MSE_version
        '
        Me.MSE_version.BackColor = System.Drawing.Color.Transparent
        Me.MSE_version.Location = New System.Drawing.Point(730, 535)
        Me.MSE_version.Name = "MSE_version"
        Me.MSE_version.Size = New System.Drawing.Size(100, 23)
        Me.MSE_version.TabIndex = 4
        Me.MSE_version.Text = "Version 2.0.0"
        Me.MSE_version.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.button_open
        Me.Panel2.Controls.Add(Me.Button_open)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(717, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(110, 45)
        Me.Panel2.TabIndex = 5
        '
        'Button_open
        '
        Me.Button_open.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_open.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_open.ForeColor = System.Drawing.Color.White
        Me.Button_open.Location = New System.Drawing.Point(0, 0)
        Me.Button_open.Name = "Button_open"
        Me.Button_open.Size = New System.Drawing.Size(110, 45)
        Me.Button_open.TabIndex = 1
        Me.Button_open.Text = "Open"
        Me.Button_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_filepath
        '
        Me.Text_filepath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_filepath.Location = New System.Drawing.Point(136, 70)
        Me.Text_filepath.Name = "Text_filepath"
        Me.Text_filepath.Size = New System.Drawing.Size(348, 13)
        Me.Text_filepath.TabIndex = 6
        Me.Text_filepath.Visible = False
        '
        'Menu_unlockable
        '
        Me.Menu_unlockable.BackColor = System.Drawing.Color.Transparent
        Me.Menu_unlockable.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_unlockable_off
        Me.Menu_unlockable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_unlockable.Controls.Add(Me.Menu_text_unlockable)
        Me.Menu_unlockable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_unlockable.Location = New System.Drawing.Point(233, 121)
        Me.Menu_unlockable.Name = "Menu_unlockable"
        Me.Menu_unlockable.Size = New System.Drawing.Size(160, 120)
        Me.Menu_unlockable.TabIndex = 7
        '
        'Menu_text_unlockable
        '
        Me.Menu_text_unlockable.BackColor = System.Drawing.Color.Transparent
        Me.Menu_text_unlockable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_unlockable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_unlockable.ForeColor = System.Drawing.Color.White
        Me.Menu_text_unlockable.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_unlockable.Name = "Menu_text_unlockable"
        Me.Menu_text_unlockable.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_unlockable.TabIndex = 0
        Me.Menu_text_unlockable.Text = "Unlockable"
        Me.Menu_text_unlockable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_success
        '
        Me.Menu_success.BackColor = System.Drawing.Color.Transparent
        Me.Menu_success.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_success_off
        Me.Menu_success.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_success.Controls.Add(Me.Menu_text_success)
        Me.Menu_success.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_success.Location = New System.Drawing.Point(438, 121)
        Me.Menu_success.Name = "Menu_success"
        Me.Menu_success.Size = New System.Drawing.Size(160, 120)
        Me.Menu_success.TabIndex = 8
        '
        'Menu_text_success
        '
        Me.Menu_text_success.BackColor = System.Drawing.Color.Transparent
        Me.Menu_text_success.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_success.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_success.ForeColor = System.Drawing.Color.White
        Me.Menu_text_success.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_success.Name = "Menu_text_success"
        Me.Menu_text_success.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_success.TabIndex = 0
        Me.Menu_text_success.Text = "Success"
        Me.Menu_text_success.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSE_logo_update
        '
        Me.MSE_logo_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSE_logo_update.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.MSE_logo_update
        Me.MSE_logo_update.Location = New System.Drawing.Point(0, 0)
        Me.MSE_logo_update.Name = "MSE_logo_update"
        Me.MSE_logo_update.Size = New System.Drawing.Size(120, 100)
        Me.MSE_logo_update.TabIndex = 9
        Me.MSE_logo_update.TabStop = False
        Me.MSE_logo_update.Visible = False
        '
        'valu_checkMSEupdate
        '
        Me.valu_checkMSEupdate.Location = New System.Drawing.Point(120, 54)
        Me.valu_checkMSEupdate.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.valu_checkMSEupdate.Name = "valu_checkMSEupdate"
        Me.valu_checkMSEupdate.Size = New System.Drawing.Size(36, 20)
        Me.valu_checkMSEupdate.TabIndex = 10
        Me.valu_checkMSEupdate.Visible = False
        '
        'Menu_party
        '
        Me.Menu_party.BackColor = System.Drawing.Color.Transparent
        Me.Menu_party.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_party_off
        Me.Menu_party.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_party.Controls.Add(Me.Menu_text_party)
        Me.Menu_party.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_party.Location = New System.Drawing.Point(643, 121)
        Me.Menu_party.Name = "Menu_party"
        Me.Menu_party.Size = New System.Drawing.Size(160, 120)
        Me.Menu_party.TabIndex = 11
        '
        'Menu_text_party
        '
        Me.Menu_text_party.BackColor = System.Drawing.Color.Transparent
        Me.Menu_text_party.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_party.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_party.ForeColor = System.Drawing.Color.White
        Me.Menu_text_party.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_party.Name = "Menu_text_party"
        Me.Menu_text_party.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_party.TabIndex = 0
        Me.Menu_text_party.Text = "Party"
        Me.Menu_text_party.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_horse
        '
        Me.Menu_horse.BackColor = System.Drawing.Color.Transparent
        Me.Menu_horse.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_horse_off
        Me.Menu_horse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_horse.Controls.Add(Me.Menu_text_horse)
        Me.Menu_horse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_horse.Location = New System.Drawing.Point(28, 257)
        Me.Menu_horse.Name = "Menu_horse"
        Me.Menu_horse.Size = New System.Drawing.Size(160, 120)
        Me.Menu_horse.TabIndex = 12
        '
        'Menu_text_horse
        '
        Me.Menu_text_horse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_horse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_horse.ForeColor = System.Drawing.Color.White
        Me.Menu_text_horse.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_horse.Name = "Menu_text_horse"
        Me.Menu_text_horse.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_horse.TabIndex = 0
        Me.Menu_text_horse.Text = "Horse"
        Me.Menu_text_horse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_grubs
        '
        Me.Menu_grubs.BackColor = System.Drawing.Color.Transparent
        Me.Menu_grubs.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_grubs_off
        Me.Menu_grubs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_grubs.Controls.Add(Me.Menu_text_grubs)
        Me.Menu_grubs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_grubs.Location = New System.Drawing.Point(233, 257)
        Me.Menu_grubs.Name = "Menu_grubs"
        Me.Menu_grubs.Size = New System.Drawing.Size(160, 120)
        Me.Menu_grubs.TabIndex = 13
        '
        'Menu_text_grubs
        '
        Me.Menu_text_grubs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_grubs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_grubs.ForeColor = System.Drawing.Color.White
        Me.Menu_text_grubs.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_grubs.Name = "Menu_text_grubs"
        Me.Menu_text_grubs.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_grubs.TabIndex = 0
        Me.Menu_text_grubs.Text = "Grubs"
        Me.Menu_text_grubs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_transferMii
        '
        Me.Menu_transferMii.BackColor = System.Drawing.Color.Transparent
        Me.Menu_transferMii.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_Miitransfert_off
        Me.Menu_transferMii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_transferMii.Controls.Add(Me.Menu_text_transferMii)
        Me.Menu_transferMii.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_transferMii.Location = New System.Drawing.Point(438, 257)
        Me.Menu_transferMii.Name = "Menu_transferMii"
        Me.Menu_transferMii.Size = New System.Drawing.Size(160, 120)
        Me.Menu_transferMii.TabIndex = 14
        '
        'Menu_text_transferMii
        '
        Me.Menu_text_transferMii.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_transferMii.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_transferMii.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Menu_text_transferMii.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_transferMii.Name = "Menu_text_transferMii"
        Me.Menu_text_transferMii.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_transferMii.TabIndex = 0
        Me.Menu_text_transferMii.Text = "Transfer Mii"
        Me.Menu_text_transferMii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_jobslevelsboosts
        '
        Me.Menu_jobslevelsboosts.BackColor = System.Drawing.Color.Transparent
        Me.Menu_jobslevelsboosts.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.Menu_jobslevelboost_off
        Me.Menu_jobslevelsboosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_jobslevelsboosts.Controls.Add(Me.Menu_text_jobslevelsboosts)
        Me.Menu_jobslevelsboosts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_jobslevelsboosts.Location = New System.Drawing.Point(643, 257)
        Me.Menu_jobslevelsboosts.Name = "Menu_jobslevelsboosts"
        Me.Menu_jobslevelsboosts.Size = New System.Drawing.Size(160, 120)
        Me.Menu_jobslevelsboosts.TabIndex = 15
        '
        'Menu_text_jobslevelsboosts
        '
        Me.Menu_text_jobslevelsboosts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_jobslevelsboosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_jobslevelsboosts.ForeColor = System.Drawing.Color.White
        Me.Menu_text_jobslevelsboosts.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_jobslevelsboosts.Name = "Menu_text_jobslevelsboosts"
        Me.Menu_text_jobslevelsboosts.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_jobslevelsboosts.TabIndex = 0
        Me.Menu_text_jobslevelsboosts.Text = "Jobs levels / Boosts"
        Me.Menu_text_jobslevelsboosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_catalog
        '
        Me.Menu_catalog.BackColor = System.Drawing.Color.Transparent
        Me.Menu_catalog.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_catalog_off
        Me.Menu_catalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_catalog.Controls.Add(Me.Menu_text_catalog)
        Me.Menu_catalog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_catalog.Location = New System.Drawing.Point(28, 393)
        Me.Menu_catalog.Name = "Menu_catalog"
        Me.Menu_catalog.Size = New System.Drawing.Size(160, 120)
        Me.Menu_catalog.TabIndex = 16
        '
        'Menu_text_catalog
        '
        Me.Menu_text_catalog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_catalog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_catalog.ForeColor = System.Drawing.Color.White
        Me.Menu_text_catalog.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_catalog.Name = "Menu_text_catalog"
        Me.Menu_text_catalog.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_catalog.TabIndex = 0
        Me.Menu_text_catalog.Text = "Journal"
        Me.Menu_text_catalog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_miiprofile
        '
        Me.Menu_miiprofile.BackColor = System.Drawing.Color.Transparent
        Me.Menu_miiprofile.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_miiprofile_off
        Me.Menu_miiprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Menu_miiprofile.Controls.Add(Me.Menu_text_miiprofile)
        Me.Menu_miiprofile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_miiprofile.Location = New System.Drawing.Point(233, 393)
        Me.Menu_miiprofile.Name = "Menu_miiprofile"
        Me.Menu_miiprofile.Size = New System.Drawing.Size(160, 120)
        Me.Menu_miiprofile.TabIndex = 17
        '
        'Menu_text_miiprofile
        '
        Me.Menu_text_miiprofile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_text_miiprofile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_text_miiprofile.ForeColor = System.Drawing.Color.White
        Me.Menu_text_miiprofile.Location = New System.Drawing.Point(0, 0)
        Me.Menu_text_miiprofile.Name = "Menu_text_miiprofile"
        Me.Menu_text_miiprofile.Size = New System.Drawing.Size(160, 120)
        Me.Menu_text_miiprofile.TabIndex = 0
        Me.Menu_text_miiprofile.Text = "Mii profile"
        Me.Menu_text_miiprofile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSE_hub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_green
        Me.ClientSize = New System.Drawing.Size(830, 560)
        Me.Controls.Add(Me.Menu_miiprofile)
        Me.Controls.Add(Me.Panel_description)
        Me.Controls.Add(Me.Menu_catalog)
        Me.Controls.Add(Me.Menu_jobslevelsboosts)
        Me.Controls.Add(Me.Menu_transferMii)
        Me.Controls.Add(Me.Menu_grubs)
        Me.Controls.Add(Me.Menu_horse)
        Me.Controls.Add(Me.Menu_party)
        Me.Controls.Add(Me.valu_checkMSEupdate)
        Me.Controls.Add(Me.MSE_logo_update)
        Me.Controls.Add(Me.Menu_success)
        Me.Controls.Add(Me.Menu_unlockable)
        Me.Controls.Add(Me.Text_filepath)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MSE_version)
        Me.Controls.Add(Me.Menu_inventory)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSE_hub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Miitopia Save Editor"
        Me.MSE_header.ResumeLayout(False)
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_inventory.ResumeLayout(False)
        Me.Panel_description.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Menu_unlockable.ResumeLayout(False)
        Me.Menu_success.ResumeLayout(False)
        CType(Me.MSE_logo_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valu_checkMSEupdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_party.ResumeLayout(False)
        Me.Menu_horse.ResumeLayout(False)
        Me.Menu_grubs.ResumeLayout(False)
        Me.Menu_transferMii.ResumeLayout(False)
        Me.Menu_jobslevelsboosts.ResumeLayout(False)
        Me.Menu_catalog.ResumeLayout(False)
        Me.Menu_miiprofile.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSE_logo As PictureBox
    Friend WithEvents MSE_header As Panel
    Friend WithEvents Icon_close As PictureBox
    Friend WithEvents Icon_minimize As PictureBox
    Friend WithEvents MSE_title As PictureBox
    Friend WithEvents Menu_inventory As Panel
    Friend WithEvents Menu_text_inventory As Label
    Friend WithEvents Panel_description As Panel
    Friend WithEvents Text_description As Label
    Friend WithEvents MSE_version As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_open As Label
    Friend WithEvents Text_filepath As TextBox
    Friend WithEvents Menu_unlockable As Panel
    Friend WithEvents Menu_text_unlockable As Label
    Friend WithEvents Menu_success As Panel
    Friend WithEvents Menu_text_success As Label
    Friend WithEvents MSE_logo_update As PictureBox
    Friend WithEvents valu_checkMSEupdate As NumericUpDown
    Friend WithEvents Menu_party As Panel
    Friend WithEvents Menu_text_party As Label
    Friend WithEvents Menu_horse As Panel
    Friend WithEvents Menu_text_horse As Label
    Friend WithEvents Menu_grubs As Panel
    Friend WithEvents Menu_text_grubs As Label
    Friend WithEvents Menu_transferMii As Panel
    Friend WithEvents Menu_text_transferMii As Label
    Friend WithEvents Menu_jobslevelsboosts As Panel
    Friend WithEvents Menu_text_jobslevelsboosts As Label
    Friend WithEvents Menu_catalog As Panel
    Friend WithEvents Menu_text_catalog As Label
    Friend WithEvents Menu_miiprofile As Panel
    Friend WithEvents Menu_text_miiprofile As Label
End Class
