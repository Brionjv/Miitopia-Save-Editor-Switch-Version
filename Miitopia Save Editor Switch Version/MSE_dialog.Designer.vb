<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSE_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_dialog))
        Me.MSE_dialog_panelbuttons = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.text_dialog = New System.Windows.Forms.Label()
        Me.MSE_dialog_panelbuttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSE_dialog_panelbuttons
        '
        Me.MSE_dialog_panelbuttons.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MSE_dialog_panelbuttons.BackColor = System.Drawing.Color.Gold
        Me.MSE_dialog_panelbuttons.ColumnCount = 2
        Me.MSE_dialog_panelbuttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MSE_dialog_panelbuttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MSE_dialog_panelbuttons.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.MSE_dialog_panelbuttons.Controls.Add(Me.OK_Button, 0, 0)
        Me.MSE_dialog_panelbuttons.Location = New System.Drawing.Point(180, 172)
        Me.MSE_dialog_panelbuttons.Name = "MSE_dialog_panelbuttons"
        Me.MSE_dialog_panelbuttons.RowCount = 1
        Me.MSE_dialog_panelbuttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MSE_dialog_panelbuttons.Size = New System.Drawing.Size(146, 29)
        Me.MSE_dialog_panelbuttons.TabIndex = 0
        Me.MSE_dialog_panelbuttons.Visible = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.White
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.White
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'text_dialog
        '
        Me.text_dialog.BackColor = System.Drawing.Color.Transparent
        Me.text_dialog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.text_dialog.Location = New System.Drawing.Point(34, 49)
        Me.text_dialog.Name = "text_dialog"
        Me.text_dialog.Size = New System.Drawing.Size(442, 105)
        Me.text_dialog.TabIndex = 1
        Me.text_dialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSE_dialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.bg_fdialog
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(507, 204)
        Me.Controls.Add(Me.text_dialog)
        Me.Controls.Add(Me.MSE_dialog_panelbuttons)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MSE_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MSE_dialog"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.MSE_dialog_panelbuttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MSE_dialog_panelbuttons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents text_dialog As Label
End Class
