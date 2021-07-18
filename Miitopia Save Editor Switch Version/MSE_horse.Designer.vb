<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSE_horse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_horse))
        Me.Icon_menu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_save = New System.Windows.Forms.Label()
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.MSE_title = New System.Windows.Forms.PictureBox()
        Me.Icon_minimize = New System.Windows.Forms.PictureBox()
        Me.Icon_close = New System.Windows.Forms.PictureBox()
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Text_horsename = New System.Windows.Forms.TextBox()
        Me.Title_horsename = New System.Windows.Forms.Label()
        Me.Icon_extract = New System.Windows.Forms.PictureBox()
        Me.Panel_description = New System.Windows.Forms.Panel()
        Me.Text_description = New System.Windows.Forms.Label()
        Me.Icon_gender_boy = New System.Windows.Forms.PictureBox()
        Me.Icon_gender_girl = New System.Windows.Forms.PictureBox()
        Me.valu_gender = New System.Windows.Forms.NumericUpDown()
        Me.Text_Ho_appearance = New System.Windows.Forms.TextBox()
        Me.Icon_import = New System.Windows.Forms.PictureBox()
        Me.Text_globalhorse = New System.Windows.Forms.TextBox()
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Icon_extract, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_description.SuspendLayout()
        CType(Me.Icon_gender_boy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_gender_girl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valu_gender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_import, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_horsename
        Me.Panel1.Controls.Add(Me.Text_horsename)
        Me.Panel1.Controls.Add(Me.Title_horsename)
        Me.Panel1.Location = New System.Drawing.Point(300, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 50)
        Me.Panel1.TabIndex = 20
        '
        'Text_horsename
        '
        Me.Text_horsename.Location = New System.Drawing.Point(35, 24)
        Me.Text_horsename.MaxLength = 10
        Me.Text_horsename.Name = "Text_horsename"
        Me.Text_horsename.Size = New System.Drawing.Size(161, 20)
        Me.Text_horsename.TabIndex = 1
        Me.Text_horsename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Title_horsename
        '
        Me.Title_horsename.ForeColor = System.Drawing.Color.White
        Me.Title_horsename.Location = New System.Drawing.Point(0, 0)
        Me.Title_horsename.Name = "Title_horsename"
        Me.Title_horsename.Size = New System.Drawing.Size(230, 18)
        Me.Title_horsename.TabIndex = 0
        Me.Title_horsename.Text = "Horse name"
        Me.Title_horsename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Icon_extract
        '
        Me.Icon_extract.BackColor = System.Drawing.Color.Transparent
        Me.Icon_extract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_extract.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_extract
        Me.Icon_extract.Location = New System.Drawing.Point(22, 261)
        Me.Icon_extract.Name = "Icon_extract"
        Me.Icon_extract.Size = New System.Drawing.Size(50, 41)
        Me.Icon_extract.TabIndex = 21
        Me.Icon_extract.TabStop = False
        '
        'Panel_description
        '
        Me.Panel_description.BackColor = System.Drawing.Color.Transparent
        Me.Panel_description.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_description
        Me.Panel_description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_description.Controls.Add(Me.Text_description)
        Me.Panel_description.Location = New System.Drawing.Point(0, 308)
        Me.Panel_description.Name = "Panel_description"
        Me.Panel_description.Size = New System.Drawing.Size(830, 40)
        Me.Panel_description.TabIndex = 29
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
        'Icon_gender_boy
        '
        Me.Icon_gender_boy.BackColor = System.Drawing.Color.Transparent
        Me.Icon_gender_boy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_gender_boy.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_horse_boy
        Me.Icon_gender_boy.Location = New System.Drawing.Point(208, 186)
        Me.Icon_gender_boy.Name = "Icon_gender_boy"
        Me.Icon_gender_boy.Size = New System.Drawing.Size(100, 100)
        Me.Icon_gender_boy.TabIndex = 30
        Me.Icon_gender_boy.TabStop = False
        '
        'Icon_gender_girl
        '
        Me.Icon_gender_girl.BackColor = System.Drawing.Color.Transparent
        Me.Icon_gender_girl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_gender_girl.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_horse_girl
        Me.Icon_gender_girl.Location = New System.Drawing.Point(522, 186)
        Me.Icon_gender_girl.Name = "Icon_gender_girl"
        Me.Icon_gender_girl.Size = New System.Drawing.Size(100, 100)
        Me.Icon_gender_girl.TabIndex = 31
        Me.Icon_gender_girl.TabStop = False
        '
        'valu_gender
        '
        Me.valu_gender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_gender.Location = New System.Drawing.Point(387, 186)
        Me.valu_gender.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.valu_gender.Name = "valu_gender"
        Me.valu_gender.Size = New System.Drawing.Size(36, 16)
        Me.valu_gender.TabIndex = 32
        Me.valu_gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_gender.Value = New Decimal(New Integer() {3, 0, 0, 0})
        Me.valu_gender.Visible = False
        '
        'Text_Ho_appearance
        '
        Me.Text_Ho_appearance.Location = New System.Drawing.Point(21, 133)
        Me.Text_Ho_appearance.MaxLength = 32767695
        Me.Text_Ho_appearance.Multiline = True
        Me.Text_Ho_appearance.Name = "Text_Ho_appearance"
        Me.Text_Ho_appearance.Size = New System.Drawing.Size(181, 122)
        Me.Text_Ho_appearance.TabIndex = 33
        Me.Text_Ho_appearance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text_Ho_appearance.Visible = False
        '
        'Icon_import
        '
        Me.Icon_import.BackColor = System.Drawing.Color.Transparent
        Me.Icon_import.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_import.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_import
        Me.Icon_import.Location = New System.Drawing.Point(759, 261)
        Me.Icon_import.Name = "Icon_import"
        Me.Icon_import.Size = New System.Drawing.Size(50, 41)
        Me.Icon_import.TabIndex = 34
        Me.Icon_import.TabStop = False
        '
        'Text_globalhorse
        '
        Me.Text_globalhorse.Location = New System.Drawing.Point(628, 133)
        Me.Text_globalhorse.MaxLength = 32767695
        Me.Text_globalhorse.Multiline = True
        Me.Text_globalhorse.Name = "Text_globalhorse"
        Me.Text_globalhorse.Size = New System.Drawing.Size(181, 122)
        Me.Text_globalhorse.TabIndex = 35
        Me.Text_globalhorse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text_globalhorse.Visible = False
        '
        'MSE_horse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_pink
        Me.ClientSize = New System.Drawing.Size(830, 349)
        Me.Controls.Add(Me.Text_globalhorse)
        Me.Controls.Add(Me.Icon_import)
        Me.Controls.Add(Me.Text_Ho_appearance)
        Me.Controls.Add(Me.valu_gender)
        Me.Controls.Add(Me.Icon_gender_girl)
        Me.Controls.Add(Me.Icon_gender_boy)
        Me.Controls.Add(Me.Panel_description)
        Me.Controls.Add(Me.Icon_extract)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Icon_menu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSE_horse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSE_horse"
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MSE_header.ResumeLayout(False)
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Icon_extract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_description.ResumeLayout(False)
        CType(Me.Icon_gender_boy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_gender_girl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valu_gender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_import, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Icon_menu As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_save As Label
    Friend WithEvents MSE_header As Panel
    Friend WithEvents MSE_title As PictureBox
    Friend WithEvents Icon_minimize As PictureBox
    Friend WithEvents Icon_close As PictureBox
    Friend WithEvents MSE_logo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Text_horsename As TextBox
    Friend WithEvents Title_horsename As Label
    Friend WithEvents Icon_extract As PictureBox
    Friend WithEvents Panel_description As Panel
    Friend WithEvents Text_description As Label
    Friend WithEvents Icon_gender_boy As PictureBox
    Friend WithEvents Icon_gender_girl As PictureBox
    Friend WithEvents valu_gender As NumericUpDown
    Friend WithEvents Text_Ho_appearance As TextBox
    Friend WithEvents Icon_import As PictureBox
    Friend WithEvents Text_globalhorse As TextBox
End Class
