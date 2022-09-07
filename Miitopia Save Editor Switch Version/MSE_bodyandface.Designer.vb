<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSE_bodyandface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_bodyandface))
        Me.Icon_menu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_save = New System.Windows.Forms.Label()
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.MSE_title = New System.Windows.Forms.PictureBox()
        Me.Icon_minimize = New System.Windows.Forms.PictureBox()
        Me.Icon_close = New System.Windows.Forms.PictureBox()
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.Text_Miieditname = New System.Windows.Forms.Label()
        Me.Select_Mii = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Icon_menu.TabIndex = 81
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
        Me.Panel2.TabIndex = 80
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
        Me.MSE_header.TabIndex = 79
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
        Me.MSE_logo.TabIndex = 78
        Me.MSE_logo.TabStop = False
        '
        'Text_Miieditname
        '
        Me.Text_Miieditname.BackColor = System.Drawing.Color.Transparent
        Me.Text_Miieditname.Location = New System.Drawing.Point(202, 129)
        Me.Text_Miieditname.Name = "Text_Miieditname"
        Me.Text_Miieditname.Size = New System.Drawing.Size(111, 21)
        Me.Text_Miieditname.TabIndex = 83
        Me.Text_Miieditname.Text = "Mii"
        Me.Text_Miieditname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Select_Mii
        '
        Me.Select_Mii.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Select_Mii.DropDownHeight = 80
        Me.Select_Mii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_Mii.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_Mii.FormattingEnabled = True
        Me.Select_Mii.IntegralHeight = False
        Me.Select_Mii.Items.AddRange(New Object() {"Mii 1", "Mii 2", "Mii 3", "Mii 4", "Mii 5", "Mii 6", "Mii 7", "Mii 8", "Mii 9", "Mii 10", "Mii 11", "Mii 12", "Mii 13", "Mii 14", "Mii 15", "Mii 16", "Mii 17", "Mii 18", "Mii 19", "Mii 20", "Mii 21", "Mii 22", "Mii 23", "Mii 24", "Mii 25", "Mii 26", "Mii 27", "Mii 28", "Mii 29", "Mii 30", "Mii 31", "Mii 32", "Mii 33", "Mii 34", "Mii 35", "Mii 36", "Mii 37", "Mii 38", "Mii 39", "Mii 40", "Mii 41", "Mii 42", "Mii 43", "Mii 44", "Mii 45", "Mii 46", "Mii 47", "Mii 48", "Mii 49", "Mii 50", "Mii 51", "Mii 52", "Mii 53", "Mii 54", "Mii 55", "Mii 56", "Mii 57", "Mii 58", "Mii 59", "Mii 60", "Mii 61", "Mii 62", "Mii 63", "Mii 64", "Mii 65", "Mii 66", "Mii 67", "Mii 68", "Mii 69", "Mii 70", "Mii 71", "Mii 72", "Mii 73", "Mii 74", "Mii 75", "Mii 76", "Mii 77", "Mii 78", "Mii 79", "Mii 80", "Mii 81", "Mii 82", "Mii 83", "Mii 84", "Mii 85", "Mii 86", "Mii 87", "Mii 88", "Mii 89", "Mii 90", "Mii 91", "Mii 92", "Mii 93", "Mii 94", "Mii 95", "Mii 96", "Mii 97", "Mii 98", "Mii 99", "Mii 100"})
        Me.Select_Mii.Location = New System.Drawing.Point(53, 129)
        Me.Select_Mii.Name = "Select_Mii"
        Me.Select_Mii.Size = New System.Drawing.Size(142, 21)
        Me.Select_Mii.TabIndex = 82
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_selectmii
        Me.PictureBox1.Location = New System.Drawing.Point(12, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 38)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(224, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Favorite color"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown1.Location = New System.Drawing.Point(242, 231)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(74, 16)
        Me.NumericUpDown1.TabIndex = 86
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(44, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 21)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Mii name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(44, 231)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 13)
        Me.TextBox1.TabIndex = 88
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown2.Location = New System.Drawing.Point(392, 231)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(74, 16)
        Me.NumericUpDown2.TabIndex = 90
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(374, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Gender"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown3.Location = New System.Drawing.Point(696, 232)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(74, 16)
        Me.NumericUpDown3.TabIndex = 94
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(678, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 21)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Body : size"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown4.Location = New System.Drawing.Point(542, 232)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(74, 16)
        Me.NumericUpDown4.TabIndex = 92
        Me.NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(524, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 21)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Body : height"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown5.Location = New System.Drawing.Point(542, 309)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(74, 16)
        Me.NumericUpDown5.TabIndex = 102
        Me.NumericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(524, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Makeup"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown6.Location = New System.Drawing.Point(392, 309)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(74, 16)
        Me.NumericUpDown6.TabIndex = 100
        Me.NumericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(374, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 21)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Wrinkles"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown7.Location = New System.Drawing.Point(242, 309)
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(74, 16)
        Me.NumericUpDown7.TabIndex = 98
        Me.NumericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(224, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 21)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Face color"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown8.Location = New System.Drawing.Point(92, 309)
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(74, 16)
        Me.NumericUpDown8.TabIndex = 96
        Me.NumericUpDown8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(74, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 21)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Face"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSE_bodyandface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_miibodyandface
        Me.ClientSize = New System.Drawing.Size(830, 469)
        Me.Controls.Add(Me.NumericUpDown5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumericUpDown8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text_Miieditname)
        Me.Controls.Add(Me.Select_Mii)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Icon_menu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSE_bodyandface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSE_bodyandface"
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MSE_header.ResumeLayout(False)
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Text_Miieditname As Label
    Friend WithEvents Select_Mii As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents Label9 As Label
End Class
