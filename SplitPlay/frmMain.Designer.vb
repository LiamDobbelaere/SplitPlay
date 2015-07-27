<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrCapture = New System.Windows.Forms.Timer(Me.components)
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.lblDestip = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblQuality = New System.Windows.Forms.Label()
        Me.txtQuality = New System.Windows.Forms.TextBox()
        Me.chkXbox = New System.Windows.Forms.CheckBox()
        Me.tmrKeycap = New System.Windows.Forms.Timer(Me.components)
        Me.txtPortKey = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVid = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.White
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnSend.Location = New System.Drawing.Point(16, 242)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(150, 28)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Create"
        Me.btnSend.UseCompatibleTextRendering = True
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnReceive
        '
        Me.btnReceive.BackColor = System.Drawing.Color.White
        Me.btnReceive.FlatAppearance.BorderSize = 0
        Me.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceive.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnReceive.Location = New System.Drawing.Point(179, 242)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(150, 28)
        Me.btnReceive.TabIndex = 1
        Me.btnReceive.Text = "Join"
        Me.btnReceive.UseCompatibleTextRendering = True
        Me.btnReceive.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(16, 303)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(313, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'tmrCapture
        '
        Me.tmrCapture.Interval = 33
        '
        'txtIP
        '
        Me.txtIP.BackColor = System.Drawing.Color.White
        Me.txtIP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtIP.Location = New System.Drawing.Point(16, 35)
        Me.txtIP.Margin = New System.Windows.Forms.Padding(0)
        Me.txtIP.MaxLength = 15
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(135, 29)
        Me.txtIP.TabIndex = 4
        Me.txtIP.Text = "1.2.3.4"
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtPort.Location = New System.Drawing.Point(16, 90)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(10)
        Me.txtPort.MaxLength = 5
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(61, 29)
        Me.txtPort.TabIndex = 5
        Me.txtPort.Text = "25566"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDestip
        '
        Me.lblDestip.AutoSize = True
        Me.lblDestip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestip.ForeColor = System.Drawing.Color.White
        Me.lblDestip.Location = New System.Drawing.Point(12, 14)
        Me.lblDestip.Name = "lblDestip"
        Me.lblDestip.Size = New System.Drawing.Size(81, 21)
        Me.lblDestip.TabIndex = 6
        Me.lblDestip.Text = "Other's IP:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.ForeColor = System.Drawing.Color.White
        Me.lblPort.Location = New System.Drawing.Point(12, 67)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(84, 21)
        Me.lblPort.TabIndex = 7
        Me.lblPort.Text = "Port setup:"
        '
        'lblQuality
        '
        Me.lblQuality.AutoSize = True
        Me.lblQuality.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuality.ForeColor = System.Drawing.Color.White
        Me.lblQuality.Location = New System.Drawing.Point(12, 148)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(214, 21)
        Me.lblQuality.TabIndex = 8
        Me.lblQuality.Text = "JPG quality in % (Create only)"
        '
        'txtQuality
        '
        Me.txtQuality.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtQuality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtQuality.Location = New System.Drawing.Point(16, 172)
        Me.txtQuality.MaxLength = 3
        Me.txtQuality.Name = "txtQuality"
        Me.txtQuality.Size = New System.Drawing.Size(38, 29)
        Me.txtQuality.TabIndex = 9
        Me.txtQuality.Text = "15"
        '
        'chkXbox
        '
        Me.chkXbox.AutoSize = True
        Me.chkXbox.FlatAppearance.BorderSize = 5
        Me.chkXbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkXbox.ForeColor = System.Drawing.Color.White
        Me.chkXbox.Location = New System.Drawing.Point(16, 207)
        Me.chkXbox.Name = "chkXbox"
        Me.chkXbox.Size = New System.Drawing.Size(269, 25)
        Me.chkXbox.TabIndex = 10
        Me.chkXbox.Text = "Use xbox 360 controller (Join only)"
        Me.chkXbox.UseVisualStyleBackColor = True
        '
        'tmrKeycap
        '
        Me.tmrKeycap.Interval = 10
        '
        'txtPortKey
        '
        Me.txtPortKey.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPortKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtPortKey.Location = New System.Drawing.Point(90, 90)
        Me.txtPortKey.MaxLength = 5
        Me.txtPortKey.Name = "txtPortKey"
        Me.txtPortKey.Size = New System.Drawing.Size(61, 29)
        Me.txtPortKey.TabIndex = 11
        Me.txtPortKey.Text = "25565"
        Me.txtPortKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.SplitPlay.My.Resources.Resources.splogo
        Me.PictureBox2.Location = New System.Drawing.Point(-10, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(365, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSize)
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Controls.Add(Me.lblPreview)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblVid)
        Me.Panel1.Controls.Add(Me.lblDestip)
        Me.Panel1.Controls.Add(Me.txtIP)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.chkXbox)
        Me.Panel1.Controls.Add(Me.btnReceive)
        Me.Panel1.Controls.Add(Me.txtPortKey)
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Controls.Add(Me.txtQuality)
        Me.Panel1.Controls.Add(Me.lblPort)
        Me.Panel1.Controls.Add(Me.lblQuality)
        Me.Panel1.Controls.Add(Me.txtPort)
        Me.Panel1.Location = New System.Drawing.Point(0, 83)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel1.Size = New System.Drawing.Size(355, 453)
        Me.Panel1.TabIndex = 13
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(238, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblVersion.Size = New System.Drawing.Size(98, 21)
        Me.lblVersion.TabIndex = 15
        Me.lblVersion.Text = "v. 0.0 build 0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.ForeColor = System.Drawing.Color.White
        Me.lblPreview.Location = New System.Drawing.Point(12, 279)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(215, 21)
        Me.lblPreview.TabIndex = 14
        Me.lblPreview.Text = "Stream preview (Create only):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(92, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Controls"
        '
        'lblVid
        '
        Me.lblVid.AutoSize = True
        Me.lblVid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVid.ForeColor = System.Drawing.Color.White
        Me.lblVid.Location = New System.Drawing.Point(26, 120)
        Me.lblVid.Name = "lblVid"
        Me.lblVid.Size = New System.Drawing.Size(42, 17)
        Me.lblVid.TabIndex = 12
        Me.lblVid.Text = "Video"
        '
        'lblSize
        '
        Me.lblSize.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.ForeColor = System.Drawing.Color.White
        Me.lblSize.Location = New System.Drawing.Point(16, 414)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(28, 21)
        Me.lblSize.TabIndex = 16
        Me.lblSize.Text = "0B"
        Me.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(345, 533)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "SplitPlay"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnReceive As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCapture As System.Windows.Forms.Timer
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents lblDestip As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents lblQuality As System.Windows.Forms.Label
    Friend WithEvents txtQuality As System.Windows.Forms.TextBox
    Friend WithEvents chkXbox As System.Windows.Forms.CheckBox
    Friend WithEvents tmrKeycap As System.Windows.Forms.Timer
    Friend WithEvents txtPortKey As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblVid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPreview As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label

End Class
