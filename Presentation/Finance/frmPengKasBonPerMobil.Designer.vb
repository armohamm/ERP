<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPengKasBonPerMobil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPengKasBonPerMobil))
        Me.txtketerangan = New DevExpress.XtraEditors.MemoEdit
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.TglPengajuan = New DevExpress.XtraEditors.DateEdit
        Me.cmdSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.txtNoCabang = New DevExpress.XtraEditors.TextEdit
        Me.lblState = New DevExpress.XtraEditors.LabelControl
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.lblJudul = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.LOVNoPol = New DevExpress.XtraEditors.LookUpEdit
        Me.TanggalCari = New DevExpress.XtraEditors.DateEdit
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVKartu2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kurs_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.PnlGridGC = New System.Windows.Forms.Panel
        Me.PnlNavKasBon = New System.Windows.Forms.Panel
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LOVTarifTujuan = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtNomorTrans = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtNilaiKasBon = New DevExpress.XtraEditors.TextEdit
        Me.txtTarifTujuan = New DevExpress.XtraEditors.TextEdit
        Me.PnlGridGCView = New DevExpress.XtraEditors.PanelControl
        Me.GCView = New DevExpress.XtraGrid.GridControl
        Me.GVView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomorV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_sj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_dpb = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.almt_agen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kota = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVKota = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.pnlTopScnd = New System.Windows.Forms.Panel
        Me.lblSopir = New DevExpress.XtraEditors.LabelControl
        Me.pnlTopMst = New System.Windows.Forms.Panel
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LOVSupir = New DevExpress.XtraEditors.LookUpEdit
        Me.LOVJnsKend = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtJmlTambahan = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtketerangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglPengajuan.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglPengajuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoCabang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.LOVNoPol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalCari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalCari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVKartu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PnlGridGC.SuspendLayout()
        Me.PnlNavKasBon.SuspendLayout()
        CType(Me.LOVTarifTujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.txtNilaiKasBon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTarifTujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnlGridGCView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGridGCView.SuspendLayout()
        CType(Me.GCView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVKota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.pnlTopScnd.SuspendLayout()
        Me.pnlTopMst.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.LOVSupir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVJnsKend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.txtJmlTambahan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(170, 115)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(245, 54)
        Me.txtketerangan.TabIndex = 5
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(891, 35)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(82, 23)
        Me.cmdDelete.TabIndex = 16
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.Visible = False
        '
        'TglPengajuan
        '
        Me.TglPengajuan.EditValue = Nothing
        Me.TglPengajuan.Location = New System.Drawing.Point(170, 25)
        Me.TglPengajuan.Name = "TglPengajuan"
        Me.TglPengajuan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TglPengajuan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglPengajuan.Properties.Appearance.Options.UseBackColor = True
        Me.TglPengajuan.Properties.Appearance.Options.UseFont = True
        Me.TglPengajuan.Properties.Appearance.Options.UseTextOptions = True
        Me.TglPengajuan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TglPengajuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglPengajuan.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.TglPengajuan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglPengajuan.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.TglPengajuan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglPengajuan.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.TglPengajuan.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.TglPengajuan.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TglPengajuan.Size = New System.Drawing.Size(245, 20)
        Me.TglPengajuan.TabIndex = 0
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(891, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(82, 23)
        Me.cmdSimpan.TabIndex = 14
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.Visible = False
        '
        'txtNoCabang
        '
        Me.txtNoCabang.Location = New System.Drawing.Point(386, 3)
        Me.txtNoCabang.Name = "txtNoCabang"
        Me.txtNoCabang.Properties.ReadOnly = True
        Me.txtNoCabang.Size = New System.Drawing.Size(29, 20)
        Me.txtNoCabang.TabIndex = 32
        '
        'lblState
        '
        Me.lblState.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblState.Appearance.Options.UseFont = True
        Me.lblState.Appearance.Options.UseForeColor = True
        Me.lblState.Location = New System.Drawing.Point(170, 175)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(15, 19)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "..."
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(170, 3)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(210, 20)
        Me.txtNomor.TabIndex = 0
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(48, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(459, 43)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "PENGAJUAN KAS BON PER MOBIL"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel1.Size = New System.Drawing.Size(981, 45)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(71, 24)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "No Polisi : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(73, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tanggal : "
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.LOVNoPol)
        Me.Panel6.Controls.Add(Me.TanggalCari)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(259, 49)
        Me.Panel6.TabIndex = 5
        '
        'LOVNoPol
        '
        Me.LOVNoPol.Location = New System.Drawing.Point(0, 23)
        Me.LOVNoPol.Name = "LOVNoPol"
        Me.LOVNoPol.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVNoPol.Properties.Appearance.Options.UseBackColor = True
        Me.LOVNoPol.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVNoPol.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_pol", "Nomor Polisi")})
        Me.LOVNoPol.Properties.NullText = ""
        Me.LOVNoPol.Size = New System.Drawing.Size(245, 20)
        Me.LOVNoPol.TabIndex = 33
        '
        'TanggalCari
        '
        Me.TanggalCari.EditValue = Nothing
        Me.TanggalCari.Location = New System.Drawing.Point(0, 3)
        Me.TanggalCari.Name = "TanggalCari"
        Me.TanggalCari.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TanggalCari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanggalCari.Properties.Appearance.Options.UseBackColor = True
        Me.TanggalCari.Properties.Appearance.Options.UseFont = True
        Me.TanggalCari.Properties.Appearance.Options.UseTextOptions = True
        Me.TanggalCari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TanggalCari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalCari.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.TanggalCari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalCari.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.TanggalCari.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TanggalCari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.TanggalCari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.TanggalCari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TanggalCari.Size = New System.Drawing.Size(245, 20)
        Me.TanggalCari.TabIndex = 1
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomor, Me.tgl_trans, Me.kd_kartu, Me.kd_valuta, Me.kurs_valuta, Me.keterangan, Me.jml_trans})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.ShowViewCaption = True
        Me.GV.ViewCaption = "MASTER KAS BON"
        '
        'nomor
        '
        Me.nomor.Caption = "Nomor"
        Me.nomor.FieldName = "nomor"
        Me.nomor.Name = "nomor"
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 0
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        '
        'kd_kartu
        '
        Me.kd_kartu.Caption = "Kartu"
        Me.kd_kartu.ColumnEdit = Me.LOVKartu2
        Me.kd_kartu.FieldName = "kd_kartu"
        Me.kd_kartu.Name = "kd_kartu"
        Me.kd_kartu.Visible = True
        Me.kd_kartu.VisibleIndex = 2
        '
        'LOVKartu2
        '
        Me.LOVKartu2.AutoHeight = False
        Me.LOVKartu2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVKartu2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.LOVKartu2.Name = "LOVKartu2"
        '
        'kd_valuta
        '
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 3
        '
        'kurs_valuta
        '
        Me.kurs_valuta.Caption = "Kurs"
        Me.kurs_valuta.FieldName = "kurs_valuta"
        Me.kurs_valuta.Name = "kurs_valuta"
        Me.kurs_valuta.Visible = True
        Me.kurs_valuta.VisibleIndex = 4
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 5
        '
        'jml_trans
        '
        Me.jml_trans.Caption = "Jml. Trans"
        Me.jml_trans.DisplayFormat.FormatString = "n2"
        Me.jml_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.Visible = True
        Me.jml_trans.VisibleIndex = 6
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVKartu2})
        Me.GC.Size = New System.Drawing.Size(981, 183)
        Me.GC.TabIndex = 0
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LabelControl8)
        Me.Panel3.Controls.Add(Me.LabelControl4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(398, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 49)
        Me.Panel3.TabIndex = 1
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(83, 23)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(46, 16)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "Sopir : "
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(10, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(119, 16)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "Jenis Kendaraan : "
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.PnlGridGCView)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.pnlTopScnd)
        Me.pnl.Controls.Add(Me.pnlTopMst)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(48, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(981, 722)
        Me.pnl.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(981, 383)
        Me.Panel2.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.PnlGridGC)
        Me.Panel8.Controls.Add(Me.PnlNavKasBon)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(981, 383)
        Me.Panel8.TabIndex = 34
        '
        'PnlGridGC
        '
        Me.PnlGridGC.Controls.Add(Me.GC)
        Me.PnlGridGC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGridGC.Location = New System.Drawing.Point(0, 200)
        Me.PnlGridGC.Name = "PnlGridGC"
        Me.PnlGridGC.Size = New System.Drawing.Size(981, 183)
        Me.PnlGridGC.TabIndex = 39
        '
        'PnlNavKasBon
        '
        Me.PnlNavKasBon.Controls.Add(Me.txtJmlTambahan)
        Me.PnlNavKasBon.Controls.Add(Me.LabelControl19)
        Me.PnlNavKasBon.Controls.Add(Me.LabelControl12)
        Me.PnlNavKasBon.Controls.Add(Me.LabelControl11)
        Me.PnlNavKasBon.Controls.Add(Me.LabelControl9)
        Me.PnlNavKasBon.Controls.Add(Me.LOVTarifTujuan)
        Me.PnlNavKasBon.Controls.Add(Me.Panel5)
        Me.PnlNavKasBon.Controls.Add(Me.txtketerangan)
        Me.PnlNavKasBon.Controls.Add(Me.txtNoCabang)
        Me.PnlNavKasBon.Controls.Add(Me.TglPengajuan)
        Me.PnlNavKasBon.Controls.Add(Me.cmdDelete)
        Me.PnlNavKasBon.Controls.Add(Me.cmdSimpan)
        Me.PnlNavKasBon.Controls.Add(Me.txtNilaiKasBon)
        Me.PnlNavKasBon.Controls.Add(Me.txtNomor)
        Me.PnlNavKasBon.Controls.Add(Me.txtTarifTujuan)
        Me.PnlNavKasBon.Controls.Add(Me.lblState)
        Me.PnlNavKasBon.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlNavKasBon.Location = New System.Drawing.Point(0, 0)
        Me.PnlNavKasBon.Name = "PnlNavKasBon"
        Me.PnlNavKasBon.Size = New System.Drawing.Size(981, 200)
        Me.PnlNavKasBon.TabIndex = 1
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(891, 149)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl19.TabIndex = 46
        Me.LabelControl19.Text = "*wajib diisi"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(418, 67)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl12.TabIndex = 45
        Me.LabelControl12.Text = "*"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(418, 45)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl11.TabIndex = 44
        Me.LabelControl11.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(418, 24)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl9.TabIndex = 43
        Me.LabelControl9.Text = "*"
        '
        'LOVTarifTujuan
        '
        Me.LOVTarifTujuan.Location = New System.Drawing.Point(170, 47)
        Me.LOVTarifTujuan.Name = "LOVTarifTujuan"
        Me.LOVTarifTujuan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVTarifTujuan.Properties.Appearance.Options.UseBackColor = True
        Me.LOVTarifTujuan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVTarifTujuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVTarifTujuan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Cabang", "Cabang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tgl_berlaku", "Tgl. Berlaku"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jns_kendaraan", "Jns. Kendaraan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jarak", "Jarak"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bensin", "Bensin"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("solar", "Solar"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_biaya", "Jml. Biaya"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Keterangan", "Keterangan")})
        Me.LOVTarifTujuan.Properties.NullText = ""
        Me.LOVTarifTujuan.Size = New System.Drawing.Size(245, 20)
        Me.LOVTarifTujuan.TabIndex = 34
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LabelControl13)
        Me.Panel5.Controls.Add(Me.LabelControl7)
        Me.Panel5.Controls.Add(Me.LabelControl5)
        Me.Panel5.Controls.Add(Me.LabelControl1)
        Me.Panel5.Controls.Add(Me.txtNomorTrans)
        Me.Panel5.Controls.Add(Me.LabelControl6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(164, 200)
        Me.Panel5.TabIndex = 42
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(52, 94)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(104, 16)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "Nilai Tambahan :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(71, 49)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(89, 16)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Tarif Tujuan : "
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(97, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Tanggal : "
        '
        'txtNomorTrans
        '
        Me.txtNomorTrans.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomorTrans.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtNomorTrans.Appearance.Options.UseFont = True
        Me.txtNomorTrans.Appearance.Options.UseForeColor = True
        Me.txtNomorTrans.Location = New System.Drawing.Point(106, 5)
        Me.txtNomorTrans.Name = "txtNomorTrans"
        Me.txtNomorTrans.Size = New System.Drawing.Size(54, 16)
        Me.txtNomorTrans.TabIndex = 3
        Me.txtNomorTrans.Text = "Nomor : "
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(67, 72)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "Nilai Kas Bon : "
        '
        'txtNilaiKasBon
        '
        Me.txtNilaiKasBon.Location = New System.Drawing.Point(170, 69)
        Me.txtNilaiKasBon.Name = "txtNilaiKasBon"
        Me.txtNilaiKasBon.Properties.DisplayFormat.FormatString = "n2"
        Me.txtNilaiKasBon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiKasBon.Properties.EditFormat.FormatString = "n2"
        Me.txtNilaiKasBon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiKasBon.Properties.Mask.BeepOnError = True
        Me.txtNilaiKasBon.Properties.Mask.EditMask = "n2"
        Me.txtNilaiKasBon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiKasBon.Size = New System.Drawing.Size(245, 20)
        Me.txtNilaiKasBon.TabIndex = 34
        '
        'txtTarifTujuan
        '
        Me.txtTarifTujuan.Location = New System.Drawing.Point(435, 47)
        Me.txtTarifTujuan.Name = "txtTarifTujuan"
        Me.txtTarifTujuan.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTarifTujuan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTarifTujuan.Properties.EditFormat.FormatString = "n2"
        Me.txtTarifTujuan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTarifTujuan.Properties.Mask.BeepOnError = True
        Me.txtTarifTujuan.Properties.Mask.EditMask = "n2"
        Me.txtTarifTujuan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifTujuan.Size = New System.Drawing.Size(231, 20)
        Me.txtTarifTujuan.TabIndex = 33
        Me.txtTarifTujuan.Visible = False
        '
        'PnlGridGCView
        '
        Me.PnlGridGCView.Appearance.BackColor = System.Drawing.Color.White
        Me.PnlGridGCView.Appearance.Options.UseBackColor = True
        Me.PnlGridGCView.Controls.Add(Me.GCView)
        Me.PnlGridGCView.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlGridGCView.Location = New System.Drawing.Point(0, 122)
        Me.PnlGridGCView.Name = "PnlGridGCView"
        Me.PnlGridGCView.Size = New System.Drawing.Size(981, 175)
        Me.PnlGridGCView.TabIndex = 8
        '
        'GCView
        '
        Me.GCView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCView.Location = New System.Drawing.Point(2, 2)
        Me.GCView.MainView = Me.GVView
        Me.GCView.Name = "GCView"
        Me.GCView.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepKartu, Me.LOVKota})
        Me.GCView.Size = New System.Drawing.Size(977, 171)
        Me.GCView.TabIndex = 0
        Me.GCView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVView})
        '
        'GVView
        '
        Me.GVView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomorV, Me.no_sj, Me.no_dpb, Me.kd_customer, Me.almt_agen, Me.kota})
        Me.GVView.GridControl = Me.GCView
        Me.GVView.Name = "GVView"
        Me.GVView.OptionsView.ShowViewCaption = True
        Me.GVView.ViewCaption = "KAS BON PER MOBIL"
        '
        'nomorV
        '
        Me.nomorV.Caption = "Nomor"
        Me.nomorV.FieldName = "nomor"
        Me.nomorV.Name = "nomorV"
        Me.nomorV.OptionsColumn.AllowEdit = False
        Me.nomorV.Visible = True
        Me.nomorV.VisibleIndex = 0
        '
        'no_sj
        '
        Me.no_sj.Caption = "No. SJ"
        Me.no_sj.FieldName = "no_sj"
        Me.no_sj.Name = "no_sj"
        Me.no_sj.Visible = True
        Me.no_sj.VisibleIndex = 1
        '
        'no_dpb
        '
        Me.no_dpb.Caption = "No. SP"
        Me.no_dpb.FieldName = "no_dpb"
        Me.no_dpb.Name = "no_dpb"
        Me.no_dpb.Visible = True
        Me.no_dpb.VisibleIndex = 2
        '
        'kd_customer
        '
        Me.kd_customer.Caption = "Customer"
        Me.kd_customer.ColumnEdit = Me.RepKartu
        Me.kd_customer.FieldName = "kd_customer"
        Me.kd_customer.Name = "kd_customer"
        Me.kd_customer.Visible = True
        Me.kd_customer.VisibleIndex = 3
        '
        'RepKartu
        '
        Me.RepKartu.AutoHeight = False
        Me.RepKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepKartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.RepKartu.Name = "RepKartu"
        '
        'almt_agen
        '
        Me.almt_agen.Caption = "Alamat Agen"
        Me.almt_agen.FieldName = "almt_agen"
        Me.almt_agen.Name = "almt_agen"
        Me.almt_agen.Visible = True
        Me.almt_agen.VisibleIndex = 4
        '
        'kota
        '
        Me.kota.Caption = "Kota"
        Me.kota.ColumnEdit = Me.LOVKota
        Me.kota.FieldName = "kota"
        Me.kota.Name = "kota"
        Me.kota.Visible = True
        Me.kota.VisibleIndex = 5
        '
        'LOVKota
        '
        Me.LOVKota.AutoHeight = False
        Me.LOVKota.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVKota.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Kota", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kota", "Nama")})
        Me.LOVKota.Name = "LOVKota"
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Maroon
        Me.pnlFooter.Controls.Add(Me.lblError)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 680)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(981, 42)
        Me.pnlFooter.TabIndex = 2
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(3, 23)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 16)
        Me.lblError.TabIndex = 13
        Me.lblError.Text = "..."
        '
        'pnlTopScnd
        '
        Me.pnlTopScnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTopScnd.Controls.Add(Me.lblSopir)
        Me.pnlTopScnd.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopScnd.Location = New System.Drawing.Point(0, 94)
        Me.pnlTopScnd.Name = "pnlTopScnd"
        Me.pnlTopScnd.Size = New System.Drawing.Size(981, 28)
        Me.pnlTopScnd.TabIndex = 7
        '
        'lblSopir
        '
        Me.lblSopir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSopir.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblSopir.Appearance.Options.UseFont = True
        Me.lblSopir.Appearance.Options.UseForeColor = True
        Me.lblSopir.Location = New System.Drawing.Point(527, 3)
        Me.lblSopir.Name = "lblSopir"
        Me.lblSopir.Size = New System.Drawing.Size(12, 16)
        Me.lblSopir.TabIndex = 14
        Me.lblSopir.Text = "..."
        '
        'pnlTopMst
        '
        Me.pnlTopMst.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTopMst.Controls.Add(Me.SimpleButton1)
        Me.pnlTopMst.Controls.Add(Me.cmdPrint)
        Me.pnlTopMst.Controls.Add(Me.cmdClear)
        Me.pnlTopMst.Controls.Add(Me.cmdRefresh)
        Me.pnlTopMst.Controls.Add(Me.Panel4)
        Me.pnlTopMst.Controls.Add(Me.Panel3)
        Me.pnlTopMst.Controls.Add(Me.Panel6)
        Me.pnlTopMst.Controls.Add(Me.Panel7)
        Me.pnlTopMst.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMst.Location = New System.Drawing.Point(0, 45)
        Me.pnlTopMst.Name = "pnlTopMst"
        Me.pnlTopMst.Size = New System.Drawing.Size(981, 49)
        Me.pnlTopMst.TabIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(803, 6)
        Me.SimpleButton1.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 38)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.SimpleButton1.ToolTipTitle = "SEARCH"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(891, 6)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 1
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(935, 6)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(847, 6)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 38)
        Me.cmdRefresh.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LabelControl10)
        Me.Panel4.Controls.Add(Me.LOVSupir)
        Me.Panel4.Controls.Add(Me.LOVJnsKend)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(527, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(269, 49)
        Me.Panel4.TabIndex = 2
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(248, 21)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl10.TabIndex = 36
        Me.LabelControl10.Text = "*"
        '
        'LOVSupir
        '
        Me.LOVSupir.Location = New System.Drawing.Point(0, 22)
        Me.LOVSupir.Name = "LOVSupir"
        Me.LOVSupir.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVSupir.Properties.Appearance.Options.UseBackColor = True
        Me.LOVSupir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVSupir.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sopir", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", "Nama")})
        Me.LOVSupir.Properties.NullText = ""
        Me.LOVSupir.Properties.ReadOnly = True
        Me.LOVSupir.Size = New System.Drawing.Size(245, 20)
        Me.LOVSupir.TabIndex = 35
        '
        'LOVJnsKend
        '
        Me.LOVJnsKend.Location = New System.Drawing.Point(0, 3)
        Me.LOVJnsKend.Name = "LOVJnsKend"
        Me.LOVJnsKend.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVJnsKend.Properties.Appearance.Options.UseBackColor = True
        Me.LOVJnsKend.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVJnsKend.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kendaraan", "Nama")})
        Me.LOVJnsKend.Properties.NullText = ""
        Me.LOVJnsKend.Properties.ReadOnly = True
        Me.LOVJnsKend.Size = New System.Drawing.Size(245, 20)
        Me.LOVJnsKend.TabIndex = 34
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.LabelControl3)
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 49)
        Me.Panel7.TabIndex = 9
        '
        'txtJmlTambahan
        '
        Me.txtJmlTambahan.EditValue = "0"
        Me.txtJmlTambahan.Location = New System.Drawing.Point(170, 92)
        Me.txtJmlTambahan.Name = "txtJmlTambahan"
        Me.txtJmlTambahan.Properties.DisplayFormat.FormatString = "n2"
        Me.txtJmlTambahan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlTambahan.Properties.EditFormat.FormatString = "n2"
        Me.txtJmlTambahan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlTambahan.Properties.Mask.BeepOnError = True
        Me.txtJmlTambahan.Properties.Mask.EditMask = "n2"
        Me.txtJmlTambahan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtJmlTambahan.Size = New System.Drawing.Size(245, 20)
        Me.txtJmlTambahan.TabIndex = 47
        Me.txtJmlTambahan.Visible = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(71, 118)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl13.TabIndex = 8
        Me.LabelControl13.Text = "Keterangan :"
        '
        'frmPengKasBonPerMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 746)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmPengKasBonPerMobil"
        Me.Text = "frmPengKasBonPerMobil"
        CType(Me.txtketerangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglPengajuan.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglPengajuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoCabang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.LOVNoPol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalCari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalCari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVKartu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.PnlGridGC.ResumeLayout(False)
        Me.PnlNavKasBon.ResumeLayout(False)
        Me.PnlNavKasBon.PerformLayout()
        CType(Me.LOVTarifTujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.txtNilaiKasBon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTarifTujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PnlGridGCView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGridGCView.ResumeLayout(False)
        CType(Me.GCView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVKota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.pnlTopScnd.ResumeLayout(False)
        Me.pnlTopScnd.PerformLayout()
        Me.pnlTopMst.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.LOVSupir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVJnsKend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.txtJmlTambahan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtketerangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TglPengajuan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNoCabang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblState As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents PnlGridGCView As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kurs_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlTopScnd As System.Windows.Forms.Panel
    Friend WithEvents pnlTopMst As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LOVSupir As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LOVJnsKend As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LOVNoPol As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TanggalCari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNomorTrans As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNilaiKasBon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTarifTujuan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PnlGridGC As System.Windows.Forms.Panel
    Friend WithEvents GCView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomorV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_sj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_dpb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents almt_agen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PnlNavKasBon As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LOVTarifTujuan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LOVKota As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LOVKartu2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lblSopir As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtJmlTambahan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
End Class
