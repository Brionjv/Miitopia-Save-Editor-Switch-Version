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
        Me.Icon_import = New System.Windows.Forms.PictureBox()
        Me.Icon_extract = New System.Windows.Forms.PictureBox()
        Me.Panel_description = New System.Windows.Forms.Panel()
        Me.Text_description = New System.Windows.Forms.Label()
        Me.Select_Mii = New System.Windows.Forms.ComboBox()
        Me.Text_MiiData_1 = New System.Windows.Forms.TextBox()
        Me.Text_MiiData_2 = New System.Windows.Forms.TextBox()
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_import, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_extract, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_description.SuspendLayout()
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
        'Icon_import
        '
        Me.Icon_import.BackColor = System.Drawing.Color.Transparent
        Me.Icon_import.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_import.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_import
        Me.Icon_import.Location = New System.Drawing.Point(591, 162)
        Me.Icon_import.Name = "Icon_import"
        Me.Icon_import.Size = New System.Drawing.Size(50, 41)
        Me.Icon_import.TabIndex = 36
        Me.Icon_import.TabStop = False
        '
        'Icon_extract
        '
        Me.Icon_extract.BackColor = System.Drawing.Color.Transparent
        Me.Icon_extract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_extract.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.icon_extract
        Me.Icon_extract.Location = New System.Drawing.Point(190, 162)
        Me.Icon_extract.Name = "Icon_extract"
        Me.Icon_extract.Size = New System.Drawing.Size(50, 41)
        Me.Icon_extract.TabIndex = 35
        Me.Icon_extract.TabStop = False
        '
        'Panel_description
        '
        Me.Panel_description.BackColor = System.Drawing.Color.Transparent
        Me.Panel_description.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_description
        Me.Panel_description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_description.Controls.Add(Me.Text_description)
        Me.Panel_description.Location = New System.Drawing.Point(0, 270)
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
        'Select_Mii
        '
        Me.Select_Mii.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Select_Mii.DropDownHeight = 80
        Me.Select_Mii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_Mii.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_Mii.FormattingEnabled = True
        Me.Select_Mii.IntegralHeight = False
        Me.Select_Mii.Items.AddRange(New Object() {"Mii 1", "Mii 2", "Mii 3", "Mii 4", "Mii 5", "Mii 6", "Mii 7", "Mii 8", "Mii 9", "Mii 10", "Mii 11", "Mii 12", "Mii 13", "Mii 14", "Mii 15", "Mii 16", "Mii 17", "Mii 18", "Mii 19", "Mii 20", "Mii 21", "Mii 22", "Mii 23", "Mii 24", "Mii 25", "Mii 26", "Mii 27", "Mii 28", "Mii 29", "Mii 30", "Mii 31", "Mii 32", "Mii 33", "Mii 34", "Mii 35", "Mii 36", "Mii 37", "Mii 38", "Mii 39", "Mii 40", "Mii 41", "Mii 42", "Mii 43", "Mii 44", "Mii 45", "Mii 46", "Mii 47", "Mii 48", "Mii 49", "Mii 50", "Mii 51", "Mii 52", "Mii 53", "Mii 54", "Mii 55", "Mii 56", "Mii 57", "Mii 58", "Mii 59", "Mii 60", "Mii 61", "Mii 62", "Mii 63", "Mii 64", "Mii 65", "Mii 66", "Mii 67", "Mii 68", "Mii 69", "Mii 70", "Mii 71", "Mii 72", "Mii 73", "Mii 74", "Mii 75", "Mii 76", "Mii 77", "Mii 78", "Mii 79", "Mii 80", "Mii 81", "Mii 82", "Mii 83", "Mii 84", "Mii 85", "Mii 86", "Mii 87", "Mii 88", "Mii 89", "Mii 90", "Mii 91", "Mii 92", "Mii 93", "Mii 94", "Mii 95", "Mii 96", "Mii 97", "Mii 98", "Mii 99", "Mii 100"})
        Me.Select_Mii.Location = New System.Drawing.Point(12, 119)
        Me.Select_Mii.Name = "Select_Mii"
        Me.Select_Mii.Size = New System.Drawing.Size(149, 21)
        Me.Select_Mii.TabIndex = 38
        '
        'Text_MiiData_1
        '
        Me.Text_MiiData_1.Location = New System.Drawing.Point(246, 97)
        Me.Text_MiiData_1.MaxLength = 32767695
        Me.Text_MiiData_1.Multiline = True
        Me.Text_MiiData_1.Name = "Text_MiiData_1"
        Me.Text_MiiData_1.Size = New System.Drawing.Size(181, 122)
        Me.Text_MiiData_1.TabIndex = 39
        Me.Text_MiiData_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text_MiiData_1.Visible = False
        '
        'Text_MiiData_2
        '
        Me.Text_MiiData_2.Location = New System.Drawing.Point(647, 97)
        Me.Text_MiiData_2.MaxLength = 32767695
        Me.Text_MiiData_2.Multiline = True
        Me.Text_MiiData_2.Name = "Text_MiiData_2"
        Me.Text_MiiData_2.Size = New System.Drawing.Size(181, 122)
        Me.Text_MiiData_2.TabIndex = 40
        Me.Text_MiiData_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Text_MiiData_2.Visible = False
        '
        'MSE_transferMii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_lightgreen
        Me.ClientSize = New System.Drawing.Size(830, 311)
        Me.Controls.Add(Me.Text_MiiData_2)
        Me.Controls.Add(Me.Text_MiiData_1)
        Me.Controls.Add(Me.Select_Mii)
        Me.Controls.Add(Me.Panel_description)
        Me.Controls.Add(Me.Icon_import)
        Me.Controls.Add(Me.Icon_extract)
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
        CType(Me.Icon_import, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_extract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_description.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Icon_menu As PictureBox
    Friend WithEvents MSE_header As Panel
    Friend WithEvents MSE_title As PictureBox
    Friend WithEvents Icon_minimize As PictureBox
    Friend WithEvents Icon_close As PictureBox
    Friend WithEvents MSE_logo As PictureBox
    Friend WithEvents Icon_import As PictureBox
    Friend WithEvents Icon_extract As PictureBox
    Friend WithEvents Panel_description As Panel
    Friend WithEvents Text_description As Label
    Friend WithEvents Select_Mii As ComboBox
    Friend WithEvents Text_MiiData_1 As TextBox
    Friend WithEvents Text_MiiData_2 As TextBox
End Class
