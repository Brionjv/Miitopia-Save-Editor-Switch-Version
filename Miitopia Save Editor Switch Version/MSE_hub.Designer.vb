﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MSE_logo_update = New System.Windows.Forms.PictureBox()
        Me.valu_checkMSEupdate = New System.Windows.Forms.NumericUpDown()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_inventory.SuspendLayout()
        Me.Panel_description.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.MSE_logo_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valu_checkMSEupdate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Menu_inventory.Location = New System.Drawing.Point(113, 146)
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
        Me.Panel_description.Location = New System.Drawing.Point(0, 342)
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
        Me.MSE_version.Location = New System.Drawing.Point(730, 360)
        Me.MSE_version.Name = "MSE_version"
        Me.MSE_version.Size = New System.Drawing.Size(100, 23)
        Me.MSE_version.TabIndex = 4
        Me.MSE_version.Text = "Version 1.1.0"
        Me.MSE_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_unlockable_off
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(335, 146)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 120)
        Me.Panel3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 120)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unlockable"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.menu_success_off
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Enabled = False
        Me.Panel4.Location = New System.Drawing.Point(557, 146)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 120)
        Me.Panel4.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 120)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Success"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'MSE_hub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_green
        Me.ClientSize = New System.Drawing.Size(830, 383)
        Me.Controls.Add(Me.valu_checkMSEupdate)
        Me.Controls.Add(Me.MSE_logo_update)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Text_filepath)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MSE_version)
        Me.Controls.Add(Me.Menu_inventory)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo)
        Me.Controls.Add(Me.Panel_description)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.MSE_logo_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valu_checkMSEupdate, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents MSE_logo_update As PictureBox
    Friend WithEvents valu_checkMSEupdate As NumericUpDown
End Class