<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSE_loading
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSE_loading))
        Me.MSE_loading_logo = New System.Windows.Forms.PictureBox()
        Me.MSE_loading_text = New System.Windows.Forms.Label()
        CType(Me.MSE_loading_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSE_loading_logo
        '
        Me.MSE_loading_logo.Image = Global.Miitopia_Save_Editor_Switch_Version.My.Resources.Resources.MSE_logo
        Me.MSE_loading_logo.Location = New System.Drawing.Point(113, 58)
        Me.MSE_loading_logo.Name = "MSE_loading_logo"
        Me.MSE_loading_logo.Size = New System.Drawing.Size(120, 100)
        Me.MSE_loading_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.MSE_loading_logo.TabIndex = 0
        Me.MSE_loading_logo.TabStop = False
        '
        'MSE_loading_text
        '
        Me.MSE_loading_text.Location = New System.Drawing.Point(72, 161)
        Me.MSE_loading_text.Name = "MSE_loading_text"
        Me.MSE_loading_text.Size = New System.Drawing.Size(203, 20)
        Me.MSE_loading_text.TabIndex = 1
        Me.MSE_loading_text.Text = "Starting Miitopia Save Editor ..."
        Me.MSE_loading_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSE_loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 238)
        Me.ControlBox = False
        Me.Controls.Add(Me.MSE_loading_text)
        Me.Controls.Add(Me.MSE_loading_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MSE_loading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.MSE_loading_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSE_loading_logo As PictureBox
    Friend WithEvents MSE_loading_text As Label
End Class
