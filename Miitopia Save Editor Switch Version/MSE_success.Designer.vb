<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSE_success
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_success))
        Me.Icon_menu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_save = New System.Windows.Forms.Label()
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.MSE_title = New System.Windows.Forms.PictureBox()
        Me.Icon_minimize = New System.Windows.Forms.PictureBox()
        Me.Icon_close = New System.Windows.Forms.PictureBox()
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.Fea_miirescued = New System.Windows.Forms.Panel()
        Me.valu_miirescued = New System.Windows.Forms.NumericUpDown()
        Me.Text_miirescued = New System.Windows.Forms.Label()
        Me.Fea_HPbananaseaten = New System.Windows.Forms.Panel()
        Me.valu_HPbananaseaten = New System.Windows.Forms.NumericUpDown()
        Me.Fea_MPcandieseaten = New System.Windows.Forms.Panel()
        Me.valu_MPcandieseaten = New System.Windows.Forms.NumericUpDown()
        Me.Fea_chestsopened = New System.Windows.Forms.Panel()
        Me.valu_chestsopened = New System.Windows.Forms.NumericUpDown()
        Me.Fea_questscleared = New System.Windows.Forms.Panel()
        Me.valu_questscleared = New System.Windows.Forms.NumericUpDown()
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MSE_header.SuspendLayout()
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_miirescued.SuspendLayout()
        CType(Me.valu_miirescued, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_HPbananaseaten.SuspendLayout()
        CType(Me.valu_HPbananaseaten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_MPcandieseaten.SuspendLayout()
        CType(Me.valu_MPcandieseaten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_chestsopened.SuspendLayout()
        CType(Me.valu_chestsopened, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_questscleared.SuspendLayout()
        CType(Me.valu_questscleared, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Fea_miirescued
        '
        Me.Fea_miirescued.BackColor = System.Drawing.Color.Transparent
        Me.Fea_miirescued.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_rescued
        Me.Fea_miirescued.Controls.Add(Me.valu_miirescued)
        Me.Fea_miirescued.Controls.Add(Me.Text_miirescued)
        Me.Fea_miirescued.Location = New System.Drawing.Point(649, 333)
        Me.Fea_miirescued.Name = "Fea_miirescued"
        Me.Fea_miirescued.Size = New System.Drawing.Size(180, 36)
        Me.Fea_miirescued.TabIndex = 20
        '
        'valu_miirescued
        '
        Me.valu_miirescued.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_miirescued.Cursor = System.Windows.Forms.Cursors.Default
        Me.valu_miirescued.Location = New System.Drawing.Point(91, 8)
        Me.valu_miirescued.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.valu_miirescued.Name = "valu_miirescued"
        Me.valu_miirescued.Size = New System.Drawing.Size(77, 16)
        Me.valu_miirescued.TabIndex = 22
        Me.valu_miirescued.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Text_miirescued
        '
        Me.Text_miirescued.ForeColor = System.Drawing.Color.White
        Me.Text_miirescued.Location = New System.Drawing.Point(15, 5)
        Me.Text_miirescued.Name = "Text_miirescued"
        Me.Text_miirescued.Size = New System.Drawing.Size(74, 23)
        Me.Text_miirescued.TabIndex = 21
        Me.Text_miirescued.Text = "Rescued : "
        Me.Text_miirescued.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fea_HPbananaseaten
        '
        Me.Fea_HPbananaseaten.BackColor = System.Drawing.Color.Transparent
        Me.Fea_HPbananaseaten.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_hpbananaeat
        Me.Fea_HPbananaseaten.Controls.Add(Me.valu_HPbananaseaten)
        Me.Fea_HPbananaseaten.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_HPbananaseaten.Location = New System.Drawing.Point(91, 136)
        Me.Fea_HPbananaseaten.Name = "Fea_HPbananaseaten"
        Me.Fea_HPbananaseaten.Size = New System.Drawing.Size(120, 96)
        Me.Fea_HPbananaseaten.TabIndex = 21
        '
        'valu_HPbananaseaten
        '
        Me.valu_HPbananaseaten.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_HPbananaseaten.Cursor = System.Windows.Forms.Cursors.Default
        Me.valu_HPbananaseaten.Location = New System.Drawing.Point(33, 6)
        Me.valu_HPbananaseaten.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
        Me.valu_HPbananaseaten.Name = "valu_HPbananaseaten"
        Me.valu_HPbananaseaten.Size = New System.Drawing.Size(77, 16)
        Me.valu_HPbananaseaten.TabIndex = 1
        Me.valu_HPbananaseaten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fea_MPcandieseaten
        '
        Me.Fea_MPcandieseaten.BackColor = System.Drawing.Color.Transparent
        Me.Fea_MPcandieseaten.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_mpcandyeat
        Me.Fea_MPcandieseaten.Controls.Add(Me.valu_MPcandieseaten)
        Me.Fea_MPcandieseaten.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_MPcandieseaten.Location = New System.Drawing.Point(267, 136)
        Me.Fea_MPcandieseaten.Name = "Fea_MPcandieseaten"
        Me.Fea_MPcandieseaten.Size = New System.Drawing.Size(120, 96)
        Me.Fea_MPcandieseaten.TabIndex = 22
        '
        'valu_MPcandieseaten
        '
        Me.valu_MPcandieseaten.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_MPcandieseaten.Cursor = System.Windows.Forms.Cursors.Default
        Me.valu_MPcandieseaten.Location = New System.Drawing.Point(33, 6)
        Me.valu_MPcandieseaten.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
        Me.valu_MPcandieseaten.Name = "valu_MPcandieseaten"
        Me.valu_MPcandieseaten.Size = New System.Drawing.Size(77, 16)
        Me.valu_MPcandieseaten.TabIndex = 1
        Me.valu_MPcandieseaten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fea_chestsopened
        '
        Me.Fea_chestsopened.BackColor = System.Drawing.Color.Transparent
        Me.Fea_chestsopened.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_chestsopen
        Me.Fea_chestsopened.Controls.Add(Me.valu_chestsopened)
        Me.Fea_chestsopened.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_chestsopened.Location = New System.Drawing.Point(443, 136)
        Me.Fea_chestsopened.Name = "Fea_chestsopened"
        Me.Fea_chestsopened.Size = New System.Drawing.Size(120, 96)
        Me.Fea_chestsopened.TabIndex = 23
        '
        'valu_chestsopened
        '
        Me.valu_chestsopened.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_chestsopened.Cursor = System.Windows.Forms.Cursors.Default
        Me.valu_chestsopened.Location = New System.Drawing.Point(33, 6)
        Me.valu_chestsopened.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
        Me.valu_chestsopened.Name = "valu_chestsopened"
        Me.valu_chestsopened.Size = New System.Drawing.Size(77, 16)
        Me.valu_chestsopened.TabIndex = 1
        Me.valu_chestsopened.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fea_questscleared
        '
        Me.Fea_questscleared.BackColor = System.Drawing.Color.Transparent
        Me.Fea_questscleared.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_questscleared
        Me.Fea_questscleared.Controls.Add(Me.valu_questscleared)
        Me.Fea_questscleared.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_questscleared.Location = New System.Drawing.Point(619, 136)
        Me.Fea_questscleared.Name = "Fea_questscleared"
        Me.Fea_questscleared.Size = New System.Drawing.Size(120, 96)
        Me.Fea_questscleared.TabIndex = 24
        '
        'valu_questscleared
        '
        Me.valu_questscleared.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_questscleared.Cursor = System.Windows.Forms.Cursors.Default
        Me.valu_questscleared.Location = New System.Drawing.Point(33, 6)
        Me.valu_questscleared.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
        Me.valu_questscleared.Name = "valu_questscleared"
        Me.valu_questscleared.Size = New System.Drawing.Size(77, 16)
        Me.valu_questscleared.TabIndex = 1
        Me.valu_questscleared.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MSE_success
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_success
        Me.ClientSize = New System.Drawing.Size(830, 369)
        Me.Controls.Add(Me.Fea_questscleared)
        Me.Controls.Add(Me.Fea_chestsopened)
        Me.Controls.Add(Me.Fea_MPcandieseaten)
        Me.Controls.Add(Me.Fea_HPbananaseaten)
        Me.Controls.Add(Me.Fea_miirescued)
        Me.Controls.Add(Me.Icon_menu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSE_success"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSE_success"
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MSE_header.ResumeLayout(False)
        CType(Me.MSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_miirescued.ResumeLayout(False)
        CType(Me.valu_miirescued, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_HPbananaseaten.ResumeLayout(False)
        CType(Me.valu_HPbananaseaten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_MPcandieseaten.ResumeLayout(False)
        CType(Me.valu_MPcandieseaten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_chestsopened.ResumeLayout(False)
        CType(Me.valu_chestsopened, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_questscleared.ResumeLayout(False)
        CType(Me.valu_questscleared, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Fea_miirescued As Panel
    Friend WithEvents Text_miirescued As Label
    Friend WithEvents valu_miirescued As NumericUpDown
    Friend WithEvents Fea_HPbananaseaten As Panel
    Friend WithEvents valu_HPbananaseaten As NumericUpDown
    Friend WithEvents Fea_MPcandieseaten As Panel
    Friend WithEvents valu_MPcandieseaten As NumericUpDown
    Friend WithEvents Fea_chestsopened As Panel
    Friend WithEvents valu_chestsopened As NumericUpDown
    Friend WithEvents Fea_questscleared As Panel
    Friend WithEvents valu_questscleared As NumericUpDown
End Class
