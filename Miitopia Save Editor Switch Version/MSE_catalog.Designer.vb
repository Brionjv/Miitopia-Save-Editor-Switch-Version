<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSE_catalog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_catalog))
        Me.Icon_menu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_save = New System.Windows.Forms.Label()
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.MSE_title = New System.Windows.Forms.PictureBox()
        Me.Icon_minimize = New System.Windows.Forms.PictureBox()
        Me.Icon_close = New System.Windows.Forms.PictureBox()
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.Panel_description = New System.Windows.Forms.Panel()
        Me.Text_description = New System.Windows.Forms.Label()
        Me.Fea_catalog_weapons = New System.Windows.Forms.Panel()
        Me.Text_catalog_weapons = New System.Windows.Forms.TextBox()
        Me.Icon_catalog_weapons = New System.Windows.Forms.PictureBox()
        Me.Fea_catalog_clothes = New System.Windows.Forms.Panel()
        Me.Text_catalog_clothes = New System.Windows.Forms.TextBox()
        Me.Icon_catalog_clothes = New System.Windows.Forms.PictureBox()
        Me.Fea_catalog_grubs = New System.Windows.Forms.Panel()
        Me.Text_catalog_grubs = New System.Windows.Forms.TextBox()
        Me.Icon_catalog_grubs = New System.Windows.Forms.PictureBox()
        Me.Fea_catalog_monsters = New System.Windows.Forms.Panel()
        Me.Text_catalog_monsters = New System.Windows.Forms.TextBox()
        Me.Icon_catalog_monsters = New System.Windows.Forms.PictureBox()
        Me.Fea_catalog_musics = New System.Windows.Forms.Panel()
        Me.Text_catalog_musics = New System.Windows.Forms.TextBox()
        Me.Icon_catalog_musics = New System.Windows.Forms.PictureBox()
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_description.SuspendLayout()
        Me.Fea_catalog_weapons.SuspendLayout()
        CType(Me.Icon_catalog_weapons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_catalog_clothes.SuspendLayout()
        CType(Me.Icon_catalog_clothes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_catalog_grubs.SuspendLayout()
        CType(Me.Icon_catalog_grubs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_catalog_monsters.SuspendLayout()
        CType(Me.Icon_catalog_monsters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_catalog_musics.SuspendLayout()
        CType(Me.Icon_catalog_musics, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Icon_menu.TabIndex = 19
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
        Me.Panel2.TabIndex = 18
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
        Me.MSE_header.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_white
        Me.MSE_header.Controls.Add(Me.MSE_title)
        Me.MSE_header.Controls.Add(Me.Icon_minimize)
        Me.MSE_header.Controls.Add(Me.Icon_close)
        Me.MSE_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.MSE_header.Location = New System.Drawing.Point(120, 0)
        Me.MSE_header.Name = "MSE_header"
        Me.MSE_header.Size = New System.Drawing.Size(710, 50)
        Me.MSE_header.TabIndex = 17
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
        Me.MSE_logo.TabIndex = 16
        Me.MSE_logo.TabStop = False
        '
        'Panel_description
        '
        Me.Panel_description.BackColor = System.Drawing.Color.Transparent
        Me.Panel_description.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_description
        Me.Panel_description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_description.Controls.Add(Me.Text_description)
        Me.Panel_description.Location = New System.Drawing.Point(0, 290)
        Me.Panel_description.Name = "Panel_description"
        Me.Panel_description.Size = New System.Drawing.Size(830, 40)
        Me.Panel_description.TabIndex = 20
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
        'Fea_catalog_weapons
        '
        Me.Fea_catalog_weapons.BackColor = System.Drawing.Color.Transparent
        Me.Fea_catalog_weapons.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_catalog_weapons
        Me.Fea_catalog_weapons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Fea_catalog_weapons.Controls.Add(Me.Text_catalog_weapons)
        Me.Fea_catalog_weapons.Controls.Add(Me.Icon_catalog_weapons)
        Me.Fea_catalog_weapons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_catalog_weapons.Location = New System.Drawing.Point(495, 128)
        Me.Fea_catalog_weapons.Name = "Fea_catalog_weapons"
        Me.Fea_catalog_weapons.Size = New System.Drawing.Size(150, 150)
        Me.Fea_catalog_weapons.TabIndex = 24
        '
        'Text_catalog_weapons
        '
        Me.Text_catalog_weapons.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_catalog_weapons.Location = New System.Drawing.Point(2, 134)
        Me.Text_catalog_weapons.Name = "Text_catalog_weapons"
        Me.Text_catalog_weapons.Size = New System.Drawing.Size(147, 13)
        Me.Text_catalog_weapons.TabIndex = 28
        '
        'Icon_catalog_weapons
        '
        Me.Icon_catalog_weapons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Icon_catalog_weapons.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon_catalog_weapons.Enabled = False
        Me.Icon_catalog_weapons.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_medail
        Me.Icon_catalog_weapons.Location = New System.Drawing.Point(24, 29)
        Me.Icon_catalog_weapons.Name = "Icon_catalog_weapons"
        Me.Icon_catalog_weapons.Size = New System.Drawing.Size(32, 38)
        Me.Icon_catalog_weapons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_catalog_weapons.TabIndex = 27
        Me.Icon_catalog_weapons.TabStop = False
        Me.Icon_catalog_weapons.Visible = False
        '
        'Fea_catalog_clothes
        '
        Me.Fea_catalog_clothes.BackColor = System.Drawing.Color.Transparent
        Me.Fea_catalog_clothes.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_catalog_clothes
        Me.Fea_catalog_clothes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Fea_catalog_clothes.Controls.Add(Me.Text_catalog_clothes)
        Me.Fea_catalog_clothes.Controls.Add(Me.Icon_catalog_clothes)
        Me.Fea_catalog_clothes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_catalog_clothes.Location = New System.Drawing.Point(340, 128)
        Me.Fea_catalog_clothes.Name = "Fea_catalog_clothes"
        Me.Fea_catalog_clothes.Size = New System.Drawing.Size(150, 150)
        Me.Fea_catalog_clothes.TabIndex = 23
        '
        'Text_catalog_clothes
        '
        Me.Text_catalog_clothes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_catalog_clothes.Location = New System.Drawing.Point(2, 134)
        Me.Text_catalog_clothes.Name = "Text_catalog_clothes"
        Me.Text_catalog_clothes.Size = New System.Drawing.Size(147, 13)
        Me.Text_catalog_clothes.TabIndex = 28
        '
        'Icon_catalog_clothes
        '
        Me.Icon_catalog_clothes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Icon_catalog_clothes.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon_catalog_clothes.Enabled = False
        Me.Icon_catalog_clothes.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_medail
        Me.Icon_catalog_clothes.Location = New System.Drawing.Point(24, 29)
        Me.Icon_catalog_clothes.Name = "Icon_catalog_clothes"
        Me.Icon_catalog_clothes.Size = New System.Drawing.Size(32, 38)
        Me.Icon_catalog_clothes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_catalog_clothes.TabIndex = 27
        Me.Icon_catalog_clothes.TabStop = False
        Me.Icon_catalog_clothes.Visible = False
        '
        'Fea_catalog_grubs
        '
        Me.Fea_catalog_grubs.BackColor = System.Drawing.Color.Transparent
        Me.Fea_catalog_grubs.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_catalog_grubs
        Me.Fea_catalog_grubs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Fea_catalog_grubs.Controls.Add(Me.Text_catalog_grubs)
        Me.Fea_catalog_grubs.Controls.Add(Me.Icon_catalog_grubs)
        Me.Fea_catalog_grubs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_catalog_grubs.Location = New System.Drawing.Point(185, 128)
        Me.Fea_catalog_grubs.Name = "Fea_catalog_grubs"
        Me.Fea_catalog_grubs.Size = New System.Drawing.Size(150, 150)
        Me.Fea_catalog_grubs.TabIndex = 22
        '
        'Text_catalog_grubs
        '
        Me.Text_catalog_grubs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_catalog_grubs.Location = New System.Drawing.Point(2, 134)
        Me.Text_catalog_grubs.Name = "Text_catalog_grubs"
        Me.Text_catalog_grubs.Size = New System.Drawing.Size(147, 13)
        Me.Text_catalog_grubs.TabIndex = 28
        '
        'Icon_catalog_grubs
        '
        Me.Icon_catalog_grubs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Icon_catalog_grubs.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon_catalog_grubs.Enabled = False
        Me.Icon_catalog_grubs.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_medail
        Me.Icon_catalog_grubs.Location = New System.Drawing.Point(24, 29)
        Me.Icon_catalog_grubs.Name = "Icon_catalog_grubs"
        Me.Icon_catalog_grubs.Size = New System.Drawing.Size(32, 38)
        Me.Icon_catalog_grubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_catalog_grubs.TabIndex = 27
        Me.Icon_catalog_grubs.TabStop = False
        Me.Icon_catalog_grubs.Visible = False
        '
        'Fea_catalog_monsters
        '
        Me.Fea_catalog_monsters.BackColor = System.Drawing.Color.Transparent
        Me.Fea_catalog_monsters.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_catalog_monsters
        Me.Fea_catalog_monsters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Fea_catalog_monsters.Controls.Add(Me.Text_catalog_monsters)
        Me.Fea_catalog_monsters.Controls.Add(Me.Icon_catalog_monsters)
        Me.Fea_catalog_monsters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_catalog_monsters.Location = New System.Drawing.Point(30, 128)
        Me.Fea_catalog_monsters.Name = "Fea_catalog_monsters"
        Me.Fea_catalog_monsters.Size = New System.Drawing.Size(150, 150)
        Me.Fea_catalog_monsters.TabIndex = 21
        '
        'Text_catalog_monsters
        '
        Me.Text_catalog_monsters.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_catalog_monsters.Location = New System.Drawing.Point(2, 134)
        Me.Text_catalog_monsters.Name = "Text_catalog_monsters"
        Me.Text_catalog_monsters.Size = New System.Drawing.Size(147, 13)
        Me.Text_catalog_monsters.TabIndex = 27
        '
        'Icon_catalog_monsters
        '
        Me.Icon_catalog_monsters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Icon_catalog_monsters.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon_catalog_monsters.Enabled = False
        Me.Icon_catalog_monsters.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_medail
        Me.Icon_catalog_monsters.Location = New System.Drawing.Point(24, 29)
        Me.Icon_catalog_monsters.Name = "Icon_catalog_monsters"
        Me.Icon_catalog_monsters.Size = New System.Drawing.Size(32, 38)
        Me.Icon_catalog_monsters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_catalog_monsters.TabIndex = 26
        Me.Icon_catalog_monsters.TabStop = False
        Me.Icon_catalog_monsters.Visible = False
        '
        'Fea_catalog_musics
        '
        Me.Fea_catalog_musics.BackColor = System.Drawing.Color.Transparent
        Me.Fea_catalog_musics.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_catalog_musics
        Me.Fea_catalog_musics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Fea_catalog_musics.Controls.Add(Me.Text_catalog_musics)
        Me.Fea_catalog_musics.Controls.Add(Me.Icon_catalog_musics)
        Me.Fea_catalog_musics.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_catalog_musics.Location = New System.Drawing.Point(650, 128)
        Me.Fea_catalog_musics.Name = "Fea_catalog_musics"
        Me.Fea_catalog_musics.Size = New System.Drawing.Size(150, 150)
        Me.Fea_catalog_musics.TabIndex = 25
        '
        'Text_catalog_musics
        '
        Me.Text_catalog_musics.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_catalog_musics.Location = New System.Drawing.Point(2, 134)
        Me.Text_catalog_musics.Name = "Text_catalog_musics"
        Me.Text_catalog_musics.Size = New System.Drawing.Size(147, 13)
        Me.Text_catalog_musics.TabIndex = 28
        '
        'Icon_catalog_musics
        '
        Me.Icon_catalog_musics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Icon_catalog_musics.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon_catalog_musics.Enabled = False
        Me.Icon_catalog_musics.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_medail
        Me.Icon_catalog_musics.Location = New System.Drawing.Point(24, 29)
        Me.Icon_catalog_musics.Name = "Icon_catalog_musics"
        Me.Icon_catalog_musics.Size = New System.Drawing.Size(32, 38)
        Me.Icon_catalog_musics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_catalog_musics.TabIndex = 27
        Me.Icon_catalog_musics.TabStop = False
        Me.Icon_catalog_musics.Visible = False
        '
        'MSE_catalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_catalog
        Me.ClientSize = New System.Drawing.Size(830, 331)
        Me.Controls.Add(Me.Fea_catalog_musics)
        Me.Controls.Add(Me.Fea_catalog_weapons)
        Me.Controls.Add(Me.Fea_catalog_clothes)
        Me.Controls.Add(Me.Fea_catalog_grubs)
        Me.Controls.Add(Me.Fea_catalog_monsters)
        Me.Controls.Add(Me.Panel_description)
        Me.Controls.Add(Me.Icon_menu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSE_catalog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSE_catalog"
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MSE_header.ResumeLayout(False)
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_description.ResumeLayout(False)
        Me.Fea_catalog_weapons.ResumeLayout(False)
        Me.Fea_catalog_weapons.PerformLayout()
        CType(Me.Icon_catalog_weapons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_catalog_clothes.ResumeLayout(False)
        Me.Fea_catalog_clothes.PerformLayout()
        CType(Me.Icon_catalog_clothes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_catalog_grubs.ResumeLayout(False)
        Me.Fea_catalog_grubs.PerformLayout()
        CType(Me.Icon_catalog_grubs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_catalog_monsters.ResumeLayout(False)
        Me.Fea_catalog_monsters.PerformLayout()
        CType(Me.Icon_catalog_monsters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_catalog_musics.ResumeLayout(False)
        Me.Fea_catalog_musics.PerformLayout()
        CType(Me.Icon_catalog_musics, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel_description As Panel
    Friend WithEvents Text_description As Label
    Friend WithEvents Fea_catalog_weapons As Panel
    Friend WithEvents Fea_catalog_clothes As Panel
    Friend WithEvents Fea_catalog_grubs As Panel
    Friend WithEvents Fea_catalog_monsters As Panel
    Friend WithEvents Icon_catalog_monsters As PictureBox
    Friend WithEvents Fea_catalog_musics As Panel
    Friend WithEvents Text_catalog_weapons As TextBox
    Friend WithEvents Icon_catalog_weapons As PictureBox
    Friend WithEvents Text_catalog_clothes As TextBox
    Friend WithEvents Icon_catalog_clothes As PictureBox
    Friend WithEvents Text_catalog_grubs As TextBox
    Friend WithEvents Icon_catalog_grubs As PictureBox
    Friend WithEvents Text_catalog_monsters As TextBox
    Friend WithEvents Text_catalog_musics As TextBox
    Friend WithEvents Icon_catalog_musics As PictureBox
End Class
