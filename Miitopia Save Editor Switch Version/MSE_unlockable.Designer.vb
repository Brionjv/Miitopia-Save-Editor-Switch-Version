<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MSE_unlockable
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_unlockable))
        Me.Icon_menu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_save = New System.Windows.Forms.Label()
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.MSE_title = New System.Windows.Forms.PictureBox()
        Me.Icon_minimize = New System.Windows.Forms.PictureBox()
        Me.Icon_close = New System.Windows.Forms.PictureBox()
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.Fea_unlock_classes = New System.Windows.Forms.Panel()
        Me.valu_unlock_classes = New System.Windows.Forms.NumericUpDown()
        Me.Fea_unlock_amiibo = New System.Windows.Forms.Panel()
        Me.valu_unlock_amiibo = New System.Windows.Forms.NumericUpDown()
        Me.Fea_unlock_sprinkles = New System.Windows.Forms.Panel()
        Me.valu_unlock_sprinkles = New System.Windows.Forms.NumericUpDown()
        Me.Panel_description = New System.Windows.Forms.Panel()
        Me.Text_description = New System.Windows.Forms.Label()
        Me.Fea_unlock_innoptions = New System.Windows.Forms.Panel()
        Me.valu_unlock_innoptions = New System.Windows.Forms.NumericUpDown()
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_unlock_classes.SuspendLayout()
        CType(Me.valu_unlock_classes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_unlock_amiibo.SuspendLayout()
        CType(Me.valu_unlock_amiibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_unlock_sprinkles.SuspendLayout()
        CType(Me.valu_unlock_sprinkles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_description.SuspendLayout()
        Me.Fea_unlock_innoptions.SuspendLayout()
        CType(Me.valu_unlock_innoptions, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Icon_menu.TabIndex = 15
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
        Me.Panel2.TabIndex = 14
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
        Me.MSE_header.TabIndex = 13
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
        Me.MSE_logo.TabIndex = 12
        Me.MSE_logo.TabStop = False
        '
        'Fea_unlock_classes
        '
        Me.Fea_unlock_classes.BackColor = System.Drawing.Color.Transparent
        Me.Fea_unlock_classes.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_unlockallclasses
        Me.Fea_unlock_classes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Fea_unlock_classes.Controls.Add(Me.valu_unlock_classes)
        Me.Fea_unlock_classes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_unlock_classes.Location = New System.Drawing.Point(64, 135)
        Me.Fea_unlock_classes.Name = "Fea_unlock_classes"
        Me.Fea_unlock_classes.Size = New System.Drawing.Size(150, 150)
        Me.Fea_unlock_classes.TabIndex = 16
        '
        'valu_unlock_classes
        '
        Me.valu_unlock_classes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.valu_unlock_classes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_unlock_classes.Cursor = System.Windows.Forms.Cursors.Default
        Me.valu_unlock_classes.Hexadecimal = True
        Me.valu_unlock_classes.Location = New System.Drawing.Point(3, 131)
        Me.valu_unlock_classes.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.valu_unlock_classes.Name = "valu_unlock_classes"
        Me.valu_unlock_classes.Size = New System.Drawing.Size(77, 16)
        Me.valu_unlock_classes.TabIndex = 2
        Me.valu_unlock_classes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_unlock_classes.Visible = False
        '
        'Fea_unlock_amiibo
        '
        Me.Fea_unlock_amiibo.BackColor = System.Drawing.Color.Transparent
        Me.Fea_unlock_amiibo.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_unloclallamiibo
        Me.Fea_unlock_amiibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Fea_unlock_amiibo.Controls.Add(Me.valu_unlock_amiibo)
        Me.Fea_unlock_amiibo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_unlock_amiibo.Location = New System.Drawing.Point(248, 135)
        Me.Fea_unlock_amiibo.Name = "Fea_unlock_amiibo"
        Me.Fea_unlock_amiibo.Size = New System.Drawing.Size(150, 150)
        Me.Fea_unlock_amiibo.TabIndex = 17
        '
        'valu_unlock_amiibo
        '
        Me.valu_unlock_amiibo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.valu_unlock_amiibo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_unlock_amiibo.Cursor = System.Windows.Forms.Cursors.Default
        Me.valu_unlock_amiibo.Hexadecimal = True
        Me.valu_unlock_amiibo.Location = New System.Drawing.Point(3, 131)
        Me.valu_unlock_amiibo.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
        Me.valu_unlock_amiibo.Name = "valu_unlock_amiibo"
        Me.valu_unlock_amiibo.Size = New System.Drawing.Size(77, 16)
        Me.valu_unlock_amiibo.TabIndex = 2
        Me.valu_unlock_amiibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_unlock_amiibo.Visible = False
        '
        'Fea_unlock_sprinkles
        '
        Me.Fea_unlock_sprinkles.BackColor = System.Drawing.Color.Transparent
        Me.Fea_unlock_sprinkles.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_unlocksprinkles
        Me.Fea_unlock_sprinkles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Fea_unlock_sprinkles.Controls.Add(Me.valu_unlock_sprinkles)
        Me.Fea_unlock_sprinkles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_unlock_sprinkles.Location = New System.Drawing.Point(432, 135)
        Me.Fea_unlock_sprinkles.Name = "Fea_unlock_sprinkles"
        Me.Fea_unlock_sprinkles.Size = New System.Drawing.Size(150, 150)
        Me.Fea_unlock_sprinkles.TabIndex = 18
        '
        'valu_unlock_sprinkles
        '
        Me.valu_unlock_sprinkles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.valu_unlock_sprinkles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_unlock_sprinkles.Cursor = System.Windows.Forms.Cursors.Default
        Me.valu_unlock_sprinkles.Hexadecimal = True
        Me.valu_unlock_sprinkles.Location = New System.Drawing.Point(3, 131)
        Me.valu_unlock_sprinkles.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.valu_unlock_sprinkles.Name = "valu_unlock_sprinkles"
        Me.valu_unlock_sprinkles.Size = New System.Drawing.Size(77, 16)
        Me.valu_unlock_sprinkles.TabIndex = 2
        Me.valu_unlock_sprinkles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_unlock_sprinkles.Visible = False
        '
        'Panel_description
        '
        Me.Panel_description.BackColor = System.Drawing.Color.Transparent
        Me.Panel_description.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_description
        Me.Panel_description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_description.Controls.Add(Me.Text_description)
        Me.Panel_description.Location = New System.Drawing.Point(0, 332)
        Me.Panel_description.Name = "Panel_description"
        Me.Panel_description.Size = New System.Drawing.Size(830, 40)
        Me.Panel_description.TabIndex = 19
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
        'Fea_unlock_innoptions
        '
        Me.Fea_unlock_innoptions.BackColor = System.Drawing.Color.Transparent
        Me.Fea_unlock_innoptions.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_unlockinnoptions
        Me.Fea_unlock_innoptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Fea_unlock_innoptions.Controls.Add(Me.valu_unlock_innoptions)
        Me.Fea_unlock_innoptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_unlock_innoptions.Location = New System.Drawing.Point(616, 135)
        Me.Fea_unlock_innoptions.Name = "Fea_unlock_innoptions"
        Me.Fea_unlock_innoptions.Size = New System.Drawing.Size(150, 150)
        Me.Fea_unlock_innoptions.TabIndex = 20
        '
        'valu_unlock_innoptions
        '
        Me.valu_unlock_innoptions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.valu_unlock_innoptions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_unlock_innoptions.Cursor = System.Windows.Forms.Cursors.Default
        Me.valu_unlock_innoptions.Hexadecimal = True
        Me.valu_unlock_innoptions.Location = New System.Drawing.Point(3, 131)
        Me.valu_unlock_innoptions.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
        Me.valu_unlock_innoptions.Name = "valu_unlock_innoptions"
        Me.valu_unlock_innoptions.Size = New System.Drawing.Size(77, 16)
        Me.valu_unlock_innoptions.TabIndex = 2
        Me.valu_unlock_innoptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_unlock_innoptions.Visible = False
        '
        'MSE_unlockable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_unlockable
        Me.ClientSize = New System.Drawing.Size(830, 373)
        Me.Controls.Add(Me.Fea_unlock_innoptions)
        Me.Controls.Add(Me.Panel_description)
        Me.Controls.Add(Me.Fea_unlock_sprinkles)
        Me.Controls.Add(Me.Fea_unlock_amiibo)
        Me.Controls.Add(Me.Fea_unlock_classes)
        Me.Controls.Add(Me.Icon_menu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSE_unlockable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSE_unlockable"
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MSE_header.ResumeLayout(False)
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_unlock_classes.ResumeLayout(False)
        CType(Me.valu_unlock_classes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_unlock_amiibo.ResumeLayout(False)
        CType(Me.valu_unlock_amiibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_unlock_sprinkles.ResumeLayout(False)
        CType(Me.valu_unlock_sprinkles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_description.ResumeLayout(False)
        Me.Fea_unlock_innoptions.ResumeLayout(False)
        CType(Me.valu_unlock_innoptions, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Fea_unlock_classes As Panel
    Friend WithEvents valu_unlock_classes As NumericUpDown
    Friend WithEvents Fea_unlock_amiibo As Panel
    Friend WithEvents valu_unlock_amiibo As NumericUpDown
    Friend WithEvents Fea_unlock_sprinkles As Panel
    Friend WithEvents valu_unlock_sprinkles As NumericUpDown
    Friend WithEvents Panel_description As Panel
    Friend WithEvents Text_description As Label
    Friend WithEvents Fea_unlock_innoptions As Panel
    Friend WithEvents valu_unlock_innoptions As NumericUpDown
End Class
