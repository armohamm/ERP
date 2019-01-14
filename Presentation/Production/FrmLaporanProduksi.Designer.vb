<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLaporanProduksi
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLaporanProduksi))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExe = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.LE_Kegiatan = New DevExpress.XtraEditors.LookUpEdit
        Me.LE_RPH2 = New DevExpress.XtraEditors.LookUpEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.LE_RPH1 = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cmbJenis_Laporan = New DevExpress.XtraEditors.ComboBoxEdit
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.LE_Kegiatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LE_RPH2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LE_RPH1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbJenis_Laporan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(310, 232)
        Me.pnl.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cmbJenis_Laporan)
        Me.Panel3.Controls.Add(Me.LabelControl3)
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.cmdClear)
        Me.Panel3.Controls.Add(Me.cmdExe)
        Me.Panel3.Controls.Add(Me.cmdPrint)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(310, 142)
        Me.Panel3.TabIndex = 27
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Maroon
        Me.Panel11.Controls.Add(Me.lblError)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 99)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(310, 43)
        Me.Panel11.TabIndex = 12
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(12, 8)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 16)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "..."
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(138, 49)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(44, 38)
        Me.cmdClear.TabIndex = 6
        '
        'cmdExe
        '
        Me.cmdExe.Image = CType(resources.GetObject("cmdExe.Image"), System.Drawing.Image)
        Me.cmdExe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExe.Location = New System.Drawing.Point(88, 49)
        Me.cmdExe.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdExe.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExe.Name = "cmdExe"
        Me.cmdExe.Size = New System.Drawing.Size(44, 38)
        Me.cmdExe.TabIndex = 10
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(188, 49)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(44, 38)
        Me.cmdPrint.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 93)
        Me.Panel2.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.LE_Kegiatan)
        Me.Panel6.Controls.Add(Me.LE_RPH2)
        Me.Panel6.Controls.Add(Me.SimpleButton1)
        Me.Panel6.Controls.Add(Me.LE_RPH1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(104, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(445, 93)
        Me.Panel6.TabIndex = 5
        '
        'LE_Kegiatan
        '
        Me.LE_Kegiatan.Location = New System.Drawing.Point(3, 23)
        Me.LE_Kegiatan.Name = "LE_Kegiatan"
        Me.LE_Kegiatan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LE_Kegiatan.Properties.Appearance.Options.UseBackColor = True
        Me.LE_Kegiatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LE_Kegiatan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_kegiatan_spk", "Kode Kegiatan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_data", "Kegiatan")})
        Me.LE_Kegiatan.Properties.NullText = ""
        Me.LE_Kegiatan.Size = New System.Drawing.Size(183, 20)
        Me.LE_Kegiatan.TabIndex = 30
        '
        'LE_RPH2
        '
        Me.LE_RPH2.Location = New System.Drawing.Point(235, 2)
        Me.LE_RPH2.Name = "LE_RPH2"
        Me.LE_RPH2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LE_RPH2.Properties.Appearance.Options.UseBackColor = True
        Me.LE_RPH2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LE_RPH2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_rph", "No RPH")})
        Me.LE_RPH2.Properties.NullText = ""
        Me.LE_RPH2.Size = New System.Drawing.Size(183, 20)
        Me.LE_RPH2.TabIndex = 29
        Me.LE_RPH2.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(189, 1)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(41, 20)
        Me.SimpleButton1.TabIndex = 28
        Me.SimpleButton1.Text = ">"
        Me.SimpleButton1.Visible = False
        '
        'LE_RPH1
        '
        Me.LE_RPH1.Location = New System.Drawing.Point(3, 2)
        Me.LE_RPH1.Name = "LE_RPH1"
        Me.LE_RPH1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LE_RPH1.Properties.Appearance.Options.UseBackColor = True
        Me.LE_RPH1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LE_RPH1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_rph", "No RPH")})
        Me.LE_RPH1.Properties.NullText = ""
        Me.LE_RPH1.Size = New System.Drawing.Size(183, 20)
        Me.LE_RPH1.TabIndex = 27
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.LabelControl1)
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(104, 93)
        Me.Panel7.TabIndex = 9
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(0, 21)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 20)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "KEGIATAN : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(95, 20)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "NO. TRANS  : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 37)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(350, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "LAPORAN PRODUKSI"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(56, 4)
        Me.LabelControl3.LookAndFeel.SkinName = "Black"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 20)
        Me.LabelControl3.TabIndex = 31
        Me.LabelControl3.Text = "JENIS LAPORAN : "
        '
        'cmbJenis_Laporan
        '
        Me.cmbJenis_Laporan.EditValue = "Rekap"
        Me.cmbJenis_Laporan.EnterMoveNextControl = True
        Me.cmbJenis_Laporan.Location = New System.Drawing.Point(157, 4)
        Me.cmbJenis_Laporan.Name = "cmbJenis_Laporan"
        Me.cmbJenis_Laporan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbJenis_Laporan.Properties.Items.AddRange(New Object() {"Rekap", "Rinci"})
        Me.cmbJenis_Laporan.Properties.ShowPopupShadow = False
        Me.cmbJenis_Laporan.Properties.UseCtrlScroll = True
        Me.cmbJenis_Laporan.Properties.ValidateOnEnterKey = True
        Me.cmbJenis_Laporan.Size = New System.Drawing.Size(100, 20)
        Me.cmbJenis_Laporan.TabIndex = 32
        '
        'FrmLaporanProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 301)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmLaporanProduksi"
        Me.Text = "FrmLaporanProduksi"
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.LE_Kegiatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LE_RPH2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LE_RPH1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbJenis_Laporan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LE_RPH1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LE_RPH2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LE_Kegiatan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbJenis_Laporan As DevExpress.XtraEditors.ComboBoxEdit
End Class
