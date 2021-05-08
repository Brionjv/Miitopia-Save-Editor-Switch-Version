<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Miitopia_Save_Editor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Miitopia_Save_Editor))
        Me.MSE_logo = New System.Windows.Forms.PictureBox()
        Me.MSE_header = New System.Windows.Forms.Panel()
        Me.Icon_close = New System.Windows.Forms.PictureBox()
        Me.Icon_minimize = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.valu_MiitopiaG = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.valu_HPbanana = New System.Windows.Forms.NumericUpDown()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.valu_MPcandy = New System.Windows.Forms.NumericUpDown()
        Me.Button_open = New System.Windows.Forms.Button()
        Me.Button_save = New System.Windows.Forms.Button()
        Me.MSE_version = New System.Windows.Forms.Label()
        Me.MSE_logo_update = New System.Windows.Forms.PictureBox()
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSE_header.SuspendLayout()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.valu_MiitopiaG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.valu_HPbanana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.valu_MPcandy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSE_logo_update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSE_logo
        '
        Me.MSE_logo.Image = CType(resources.GetObject("MSE_logo.Image"), System.Drawing.Image)
        Me.MSE_logo.Location = New System.Drawing.Point(0, 0)
        Me.MSE_logo.Name = "MSE_logo"
        Me.MSE_logo.Size = New System.Drawing.Size(120, 100)
        Me.MSE_logo.TabIndex = 0
        Me.MSE_logo.TabStop = False
        '
        'MSE_header
        '
        Me.MSE_header.BackColor = System.Drawing.Color.White
        Me.MSE_header.Controls.Add(Me.Icon_close)
        Me.MSE_header.Controls.Add(Me.Icon_minimize)
        Me.MSE_header.Controls.Add(Me.Label1)
        Me.MSE_header.Location = New System.Drawing.Point(120, 0)
        Me.MSE_header.Name = "MSE_header"
        Me.MSE_header.Size = New System.Drawing.Size(680, 50)
        Me.MSE_header.TabIndex = 1
        '
        'Icon_close
        '
        Me.Icon_close.Image = CType(resources.GetObject("Icon_close.Image"), System.Drawing.Image)
        Me.Icon_close.Location = New System.Drawing.Point(620, 0)
        Me.Icon_close.Name = "Icon_close"
        Me.Icon_close.Size = New System.Drawing.Size(60, 50)
        Me.Icon_close.TabIndex = 2
        Me.Icon_close.TabStop = False
        '
        'Icon_minimize
        '
        Me.Icon_minimize.Image = CType(resources.GetObject("Icon_minimize.Image"), System.Drawing.Image)
        Me.Icon_minimize.Location = New System.Drawing.Point(560, 0)
        Me.Icon_minimize.Name = "Icon_minimize"
        Me.Icon_minimize.Size = New System.Drawing.Size(60, 50)
        Me.Icon_minimize.TabIndex = 1
        Me.Icon_minimize.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(160, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Miitopia Save Editor (Switch Version)"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Controls.Add(Me.valu_MiitopiaG)
        Me.Panel2.Location = New System.Drawing.Point(107, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(135, 136)
        Me.Panel2.TabIndex = 2
        '
        'valu_MiitopiaG
        '
        Me.valu_MiitopiaG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_MiitopiaG.Location = New System.Drawing.Point(35, 70)
        Me.valu_MiitopiaG.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.valu_MiitopiaG.Name = "valu_MiitopiaG"
        Me.valu_MiitopiaG.Size = New System.Drawing.Size(88, 19)
        Me.valu_MiitopiaG.TabIndex = 0
        Me.valu_MiitopiaG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Controls.Add(Me.valu_HPbanana)
        Me.Panel3.Location = New System.Drawing.Point(333, 129)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(135, 136)
        Me.Panel3.TabIndex = 3
        '
        'valu_HPbanana
        '
        Me.valu_HPbanana.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_HPbanana.Location = New System.Drawing.Point(29, 70)
        Me.valu_HPbanana.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.valu_HPbanana.Name = "valu_HPbanana"
        Me.valu_HPbanana.Size = New System.Drawing.Size(88, 19)
        Me.valu_HPbanana.TabIndex = 1
        Me.valu_HPbanana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel4.Controls.Add(Me.valu_MPcandy)
        Me.Panel4.Location = New System.Drawing.Point(559, 129)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(135, 136)
        Me.Panel4.TabIndex = 4
        '
        'valu_MPcandy
        '
        Me.valu_MPcandy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_MPcandy.Location = New System.Drawing.Point(29, 70)
        Me.valu_MPcandy.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.valu_MPcandy.Name = "valu_MPcandy"
        Me.valu_MPcandy.Size = New System.Drawing.Size(88, 19)
        Me.valu_MPcandy.TabIndex = 1
        Me.valu_MPcandy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_open
        '
        Me.Button_open.BackColor = System.Drawing.Color.White
        Me.Button_open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_open.Location = New System.Drawing.Point(124, 55)
        Me.Button_open.Name = "Button_open"
        Me.Button_open.Size = New System.Drawing.Size(118, 44)
        Me.Button_open.TabIndex = 5
        Me.Button_open.Text = "Open"
        Me.Button_open.UseVisualStyleBackColor = False
        '
        'Button_save
        '
        Me.Button_save.BackColor = System.Drawing.Color.White
        Me.Button_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_save.Location = New System.Drawing.Point(248, 55)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(118, 44)
        Me.Button_save.TabIndex = 6
        Me.Button_save.Text = "Save"
        Me.Button_save.UseVisualStyleBackColor = False
        '
        'MSE_version
        '
        Me.MSE_version.BackColor = System.Drawing.Color.Transparent
        Me.MSE_version.Location = New System.Drawing.Point(680, 318)
        Me.MSE_version.Name = "MSE_version"
        Me.MSE_version.Size = New System.Drawing.Size(120, 21)
        Me.MSE_version.TabIndex = 7
        Me.MSE_version.Text = "Version 1.0.0"
        Me.MSE_version.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'MSE_logo_update
        '
        Me.MSE_logo_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSE_logo_update.Image = CType(resources.GetObject("MSE_logo_update.Image"), System.Drawing.Image)
        Me.MSE_logo_update.Location = New System.Drawing.Point(0, 0)
        Me.MSE_logo_update.Name = "MSE_logo_update"
        Me.MSE_logo_update.Size = New System.Drawing.Size(120, 100)
        Me.MSE_logo_update.TabIndex = 8
        Me.MSE_logo_update.TabStop = False
        Me.MSE_logo_update.Visible = False
        '
        'Miitopia_Save_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 340)
        Me.Controls.Add(Me.MSE_version)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(Me.Button_open)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MSE_header)
        Me.Controls.Add(Me.MSE_logo_update)
        Me.Controls.Add(Me.MSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Miitopia_Save_Editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Miitopia Save Editor (switch version)"
        CType(Me.MSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSE_header.ResumeLayout(False)
        Me.MSE_header.PerformLayout()
        CType(Me.Icon_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.valu_MiitopiaG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.valu_HPbanana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.valu_MPcandy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSE_logo_update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MSE_logo As PictureBox
    Friend WithEvents MSE_header As Panel
    Friend WithEvents Icon_close As PictureBox
    Friend WithEvents Icon_minimize As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents valu_MiitopiaG As NumericUpDown
    Friend WithEvents valu_HPbanana As NumericUpDown
    Friend WithEvents valu_MPcandy As NumericUpDown
    Friend WithEvents Button_open As Button
    Friend WithEvents Button_save As Button
    Friend WithEvents MSE_version As Label
    Friend WithEvents MSE_logo_update As PictureBox
End Class
