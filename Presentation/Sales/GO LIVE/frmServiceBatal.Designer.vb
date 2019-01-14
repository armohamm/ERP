<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceBatal
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiceBatal))
        Me.pnl = New System.Windows.Forms.Panel
        Me.txtNamaCust = New System.Windows.Forms.TextBox
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtalasan = New System.Windows.Forms.TextBox
        Me.txtNoSP = New System.Windows.Forms.TextBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New DevExpress.XtraEditors.LabelControl
        Me.btnCari = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.txtNamaCust)
        Me.pnl.Controls.Add(Me.LabelControl3)
        Me.pnl.Controls.Add(Me.btnCari)
        Me.pnl.Controls.Add(Me.txtalasan)
        Me.pnl.Controls.Add(Me.txtNoSP)
        Me.pnl.Controls.Add(Me.LabelControl2)
        Me.pnl.Controls.Add(Me.LabelControl1)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(410, 164)
        Me.pnl.TabIndex = 0
        '
        'txtNamaCust
        '
        Me.txtNamaCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaCust.Enabled = False
        Me.txtNamaCust.Location = New System.Drawing.Point(134, 68)
        Me.txtNamaCust.Name = "txtNamaCust"
        Me.txtNamaCust.ReadOnly = True
        Me.txtNamaCust.Size = New System.Drawing.Size(271, 21)
        Me.txtNamaCust.TabIndex = 228
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl3.Location = New System.Drawing.Point(3, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(125, 20)
        Me.LabelControl3.TabIndex = 227
        Me.LabelControl3.Text = "Nama Customer : "
        '
        'txtalasan
        '
        Me.txtalasan.Location = New System.Drawing.Point(134, 95)
        Me.txtalasan.Multiline = True
        Me.txtalasan.Name = "txtalasan"
        Me.txtalasan.Size = New System.Drawing.Size(271, 55)
        Me.txtalasan.TabIndex = 225
        '
        'txtNoSP
        '
        Me.txtNoSP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoSP.Enabled = False
        Me.txtNoSP.Location = New System.Drawing.Point(134, 42)
        Me.txtNoSP.Name = "txtNoSP"
        Me.txtNoSP.ReadOnly = True
        Me.txtNoSP.Size = New System.Drawing.Size(237, 21)
        Me.txtNoSP.TabIndex = 224
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl2.Location = New System.Drawing.Point(3, 95)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(125, 55)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Alasan : "
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl1.Location = New System.Drawing.Point(3, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(125, 20)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Nomor Service : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 37)
        Me.Panel1.TabIndex = 2
        '
        'lblJudul
        '
        Me.lblJudul.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblJudul.Appearance.Options.UseFont = True
        Me.lblJudul.Appearance.Options.UseForeColor = True
        Me.lblJudul.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblJudul.Location = New System.Drawing.Point(44, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(275, 37)
        Me.lblJudul.TabIndex = 4
        Me.lblJudul.Text = " PEMBATALAN SERVICE"
        '
        'btnCari
        '
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.Location = New System.Drawing.Point(376, 42)
        Me.btnCari.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnCari.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(29, 20)
        Me.btnCari.TabIndex = 226
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmServiceBatal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 191)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmServiceBatal"
        Me.Text = "XtraForm1"
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCari As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtalasan As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSP As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaCust As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
