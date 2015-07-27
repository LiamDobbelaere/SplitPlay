<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameView))
        Me.pbxGameview = New System.Windows.Forms.PictureBox()
        CType(Me.pbxGameview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxGameview
        '
        Me.pbxGameview.BackColor = System.Drawing.Color.Black
        Me.pbxGameview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxGameview.Location = New System.Drawing.Point(0, 0)
        Me.pbxGameview.Name = "pbxGameview"
        Me.pbxGameview.Size = New System.Drawing.Size(624, 442)
        Me.pbxGameview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxGameview.TabIndex = 0
        Me.pbxGameview.TabStop = False
        '
        'frmGameView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.pbxGameview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGameView"
        Me.Text = "[SplitPlay Session]"
        CType(Me.pbxGameview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxGameview As System.Windows.Forms.PictureBox
End Class
