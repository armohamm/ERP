<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSatpamSJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSatpamSJ))
        Me.pnl = New System.Windows.Forms.Panel
        Me.cmdSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblStatus = New System.Windows.Forms.Label
        Me.jamBalik = New DevExpress.XtraEditors.TextEdit
        Me.tglBalik = New DevExpress.XtraEditors.TextEdit
        Me.jamkirim = New DevExpress.XtraEditors.TextEdit
        Me.TglKirim = New DevExpress.XtraEditors.TextEdit
        Me.txtSopir = New DevExpress.XtraEditors.TextEdit
        Me.txtKendaraan = New DevExpress.XtraEditors.TextEdit
        Me.txtNoSJ = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.jamBalik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglBalik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jamkirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSopir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.Maroon
        Me.pnl.Controls.Add(Me.cmdSimpan)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(12, 29)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(524, 278)
        Me.pnl.TabIndex = 0
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSimpan.Appearance.Options.UseFont = True
        Me.cmdSimpan.Appearance.Options.UseForeColor = True
        Me.cmdSimpan.Image = CType(resources.GetObject("cmdSimpan.Image"), System.Drawing.Image)
        Me.cmdSimpan.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdSimpan.Location = New System.Drawing.Point(207, 231)
        Me.cmdSimpan.LookAndFeel.SkinName = "Money Twins"
        Me.cmdSimpan.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(118, 41)
        Me.cmdSimpan.TabIndex = 2
        Me.cmdSimpan.Text = "Simpan"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 188)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblStatus)
        Me.Panel4.Controls.Add(Me.jamBalik)
        Me.Panel4.Controls.Add(Me.tglBalik)
        Me.Panel4.Controls.Add(Me.jamkirim)
        Me.Panel4.Controls.Add(Me.TglKirim)
        Me.Panel4.Controls.Add(Me.txtSopir)
        Me.Panel4.Controls.Add(Me.txtKendaraan)
        Me.Panel4.Controls.Add(Me.txtNoSJ)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(158, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(366, 188)
        Me.Panel4.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(0, 152)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(366, 36)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Pengiriman Barang"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'jamBalik
        '
        Me.jamBalik.Dock = System.Windows.Forms.DockStyle.Top
        Me.jamBalik.EditValue = New Date(2011, 6, 1, 11, 50, 56, 468)
        Me.jamBalik.Enabled = False
        Me.jamBalik.Location = New System.Drawing.Point(0, 130)
        Me.jamBalik.Name = "jamBalik"
        Me.jamBalik.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.jamBalik.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jamBalik.Properties.Appearance.Options.UseBackColor = True
        Me.jamBalik.Properties.Appearance.Options.UseFont = True
        Me.jamBalik.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.jamBalik.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.jamBalik.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.jamBalik.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White
        Me.jamBalik.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.jamBalik.Properties.DisplayFormat.FormatString = "T"
        Me.jamBalik.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.jamBalik.Properties.ReadOnly = True
        Me.jamBalik.Size = New System.Drawing.Size(366, 22)
        Me.jamBalik.TabIndex = 7
        '
        'tglBalik
        '
        Me.tglBalik.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglBalik.EditValue = New Date(2011, 6, 1, 11, 50, 56, 468)
        Me.tglBalik.Location = New System.Drawing.Point(0, 108)
        Me.tglBalik.Name = "tglBalik"
        Me.tglBalik.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglBalik.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglBalik.Properties.Appearance.Options.UseBackColor = True
        Me.tglBalik.Properties.Appearance.Options.UseFont = True
        Me.tglBalik.Properties.DisplayFormat.FormatString = "d"
        Me.tglBalik.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglBalik.Properties.ReadOnly = True
        Me.tglBalik.Size = New System.Drawing.Size(366, 22)
        Me.tglBalik.TabIndex = 6
        '
        'jamkirim
        '
        Me.jamkirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.jamkirim.EditValue = New Date(2011, 6, 1, 11, 50, 46, 328)
        Me.jamkirim.Enabled = False
        Me.jamkirim.Location = New System.Drawing.Point(0, 86)
        Me.jamkirim.Name = "jamkirim"
        Me.jamkirim.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.jamkirim.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jamkirim.Properties.Appearance.Options.UseBackColor = True
        Me.jamkirim.Properties.Appearance.Options.UseFont = True
        Me.jamkirim.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.jamkirim.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.jamkirim.Properties.DisplayFormat.FormatString = "T"
        Me.jamkirim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.jamkirim.Properties.ReadOnly = True
        Me.jamkirim.Size = New System.Drawing.Size(366, 22)
        Me.jamkirim.TabIndex = 5
        '
        'TglKirim
        '
        Me.TglKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.TglKirim.EditValue = New Date(2011, 6, 1, 11, 50, 46, 328)
        Me.TglKirim.Enabled = False
        Me.TglKirim.Location = New System.Drawing.Point(0, 64)
        Me.TglKirim.Name = "TglKirim"
        Me.TglKirim.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TglKirim.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglKirim.Properties.Appearance.Options.UseBackColor = True
        Me.TglKirim.Properties.Appearance.Options.UseFont = True
        Me.TglKirim.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.TglKirim.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TglKirim.Properties.DisplayFormat.FormatString = "d"
        Me.TglKirim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglKirim.Properties.ReadOnly = True
        Me.TglKirim.Size = New System.Drawing.Size(366, 22)
        Me.TglKirim.TabIndex = 4
        '
        'txtSopir
        '
        Me.txtSopir.AllowDrop = True
        Me.txtSopir.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSopir.Location = New System.Drawing.Point(0, 42)
        Me.txtSopir.Name = "txtSopir"
        Me.txtSopir.Properties.AutoHeight = False
        Me.txtSopir.Size = New System.Drawing.Size(366, 22)
        Me.txtSopir.TabIndex = 2
        '
        'txtKendaraan
        '
        Me.txtKendaraan.AllowDrop = True
        Me.txtKendaraan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKendaraan.Location = New System.Drawing.Point(0, 20)
        Me.txtKendaraan.Name = "txtKendaraan"
        Me.txtKendaraan.Properties.AutoHeight = False
        Me.txtKendaraan.Size = New System.Drawing.Size(366, 22)
        Me.txtKendaraan.TabIndex = 1
        '
        'txtNoSJ
        '
        Me.txtNoSJ.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNoSJ.Location = New System.Drawing.Point(0, 0)
        Me.txtNoSJ.Name = "txtNoSJ"
        Me.txtNoSJ.Size = New System.Drawing.Size(366, 20)
        Me.txtNoSJ.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(158, 188)
        Me.Panel3.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Status : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jam Balik :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tgl Balik :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jam Kirim :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tgl Kirim :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sopir :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kendaraan :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* Nomor Surat Jalan :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 37)
        Me.Panel1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(44, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(281, 37)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "  CHECK CLOCK SURAT JALAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmSatpamSJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(866, 356)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmSatpamSJ"
        Me.Text = "frmSatpamSJ"
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.jamBalik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglBalik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jamkirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSopir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNoSJ As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jamBalik As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tglBalik As DevExpress.XtraEditors.TextEdit
    Friend WithEvents jamkirim As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TglKirim As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKendaraan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSopir As DevExpress.XtraEditors.TextEdit
End Class
