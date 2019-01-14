<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBebanBiayaDmuka
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBebanBiayaDmuka))
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.rek_pusat_biaya2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLOVbukuPusat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.val_total2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.val_jumlah2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.val_bulanan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_val2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_awal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bln = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_pembebanan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVrekening = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.rek_pusat_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GCDet = New DevExpress.XtraGrid.GridControl
        Me.GVDet = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.rek_pusat_biaya3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepBukuPusat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.val_total3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.val_jumlah3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.val_bulanan3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_val3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.pnlTopScnd = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.lblState = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.pnlTopMst = New System.Windows.Forms.Panel
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LOVrekBiaya = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNilaiPembeban = New DevExpress.XtraEditors.TextEdit
        Me.LOVbukuPusat = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNilaiTotal = New DevExpress.XtraEditors.TextEdit
        Me.LOVstatus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtBulan = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtNama = New DevExpress.XtraEditors.TextEdit
        Me.txtKdCabang = New DevExpress.XtraEditors.TextEdit
        Me.tglBerakhir = New DevExpress.XtraEditors.DateEdit
        Me.tglBerlaku = New DevExpress.XtraEditors.DateEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLOVbukuPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVrekening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GCDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepBukuPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.pnlTopScnd.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopMst.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.LOVrekBiaya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiPembeban.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVbukuPusat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKdCabang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglBerakhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglBerakhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglBerlaku.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglBerlaku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.rek_pusat_biaya2, Me.val_total2, Me.val_jumlah2, Me.val_bulanan2, Me.sisa_val2})
        Me.GV2.GridControl = Me.GC
        Me.GV2.Name = "GV2"
        '
        'rek_pusat_biaya2
        '
        Me.rek_pusat_biaya2.Caption = "Pusat Rekening"
        Me.rek_pusat_biaya2.ColumnEdit = Me.RepLOVbukuPusat
        Me.rek_pusat_biaya2.FieldName = "rek_pusat_biaya"
        Me.rek_pusat_biaya2.Name = "rek_pusat_biaya2"
        Me.rek_pusat_biaya2.Visible = True
        Me.rek_pusat_biaya2.VisibleIndex = 0
        '
        'RepLOVbukuPusat
        '
        Me.RepLOVbukuPusat.AutoHeight = False
        Me.RepLOVbukuPusat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLOVbukuPusat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.RepLOVbukuPusat.Name = "RepLOVbukuPusat"
        '
        'val_total2
        '
        Me.val_total2.Caption = "Biaya Total"
        Me.val_total2.FieldName = "val_total"
        Me.val_total2.Name = "val_total2"
        Me.val_total2.Visible = True
        Me.val_total2.VisibleIndex = 1
        '
        'val_jumlah2
        '
        Me.val_jumlah2.Caption = "Jumlah"
        Me.val_jumlah2.FieldName = "val_jumlah"
        Me.val_jumlah2.Name = "val_jumlah2"
        Me.val_jumlah2.Visible = True
        Me.val_jumlah2.VisibleIndex = 2
        '
        'val_bulanan2
        '
        Me.val_bulanan2.Caption = "Biaya Bulanan"
        Me.val_bulanan2.FieldName = "val_bulanan"
        Me.val_bulanan2.Name = "val_bulanan2"
        Me.val_bulanan2.Visible = True
        Me.val_bulanan2.VisibleIndex = 3
        '
        'sisa_val2
        '
        Me.sisa_val2.Caption = "Sisa"
        Me.sisa_val2.FieldName = "sisa_val"
        Me.sisa_val2.Name = "sisa_val2"
        Me.sisa_val2.Visible = True
        Me.sisa_val2.VisibleIndex = 4
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV2
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.LOVrekening, Me.RepLOVbukuPusat})
        Me.GC.Size = New System.Drawing.Size(983, 247)
        Me.GC.TabIndex = 8
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GV2})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_trans, Me.tipe_trans, Me.nama_biaya, Me.tgl_awal, Me.tgl_akhir, Me.jml_bln, Me.nilai_total, Me.nilai_pembebanan, Me.keterangan, Me.rek_biaya, Me.rek_pusat_biaya, Me.status})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsView.ShowViewCaption = True
        Me.GV.ViewCaption = "DATA BEBAN BIAYA DIMUKA"
        '
        'no_trans
        '
        Me.no_trans.Caption = "No Trans"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 0
        '
        'tipe_trans
        '
        Me.tipe_trans.Caption = "Tipe Trans"
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 1
        '
        'nama_biaya
        '
        Me.nama_biaya.Caption = "Nama Beban"
        Me.nama_biaya.FieldName = "nama_biaya"
        Me.nama_biaya.Name = "nama_biaya"
        Me.nama_biaya.Visible = True
        Me.nama_biaya.VisibleIndex = 2
        '
        'tgl_awal
        '
        Me.tgl_awal.Caption = "Tgl. Awal"
        Me.tgl_awal.FieldName = "tgl_awal"
        Me.tgl_awal.Name = "tgl_awal"
        Me.tgl_awal.Visible = True
        Me.tgl_awal.VisibleIndex = 3
        '
        'tgl_akhir
        '
        Me.tgl_akhir.Caption = "Tgl. Akhir"
        Me.tgl_akhir.FieldName = "tgl_akhir"
        Me.tgl_akhir.Name = "tgl_akhir"
        Me.tgl_akhir.Visible = True
        Me.tgl_akhir.VisibleIndex = 4
        '
        'jml_bln
        '
        Me.jml_bln.Caption = "Jumlah Bulan"
        Me.jml_bln.FieldName = "jml_bln"
        Me.jml_bln.Name = "jml_bln"
        Me.jml_bln.Visible = True
        Me.jml_bln.VisibleIndex = 5
        '
        'nilai_total
        '
        Me.nilai_total.Caption = "Nilai Total"
        Me.nilai_total.FieldName = "nilai_total"
        Me.nilai_total.Name = "nilai_total"
        Me.nilai_total.Visible = True
        Me.nilai_total.VisibleIndex = 6
        '
        'nilai_pembebanan
        '
        Me.nilai_pembebanan.Caption = "Nilai Pembebanan"
        Me.nilai_pembebanan.FieldName = "nilai_pembebanan"
        Me.nilai_pembebanan.Name = "nilai_pembebanan"
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 7
        '
        'rek_biaya
        '
        Me.rek_biaya.Caption = "Rek. Biaya"
        Me.rek_biaya.ColumnEdit = Me.LOVrekening
        Me.rek_biaya.FieldName = "rek_biaya"
        Me.rek_biaya.Name = "rek_biaya"
        Me.rek_biaya.Visible = True
        Me.rek_biaya.VisibleIndex = 8
        '
        'LOVrekening
        '
        Me.LOVrekening.AutoHeight = False
        Me.LOVrekening.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVrekening.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.LOVrekening.Name = "LOVrekening"
        '
        'rek_pusat_biaya
        '
        Me.rek_pusat_biaya.Caption = "Rek. Pusat Biaya"
        Me.rek_pusat_biaya.ColumnEdit = Me.RepLOVbukuPusat
        Me.rek_pusat_biaya.FieldName = "rek_pusat_biaya"
        Me.rek_pusat_biaya.Name = "rek_pusat_biaya"
        '
        'status
        '
        Me.status.Caption = "Status"
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 9
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(464, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(94, 121)
        Me.Panel3.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Status : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rek. Biaya : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Total : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.pnlTopScnd)
        Me.pnl.Controls.Add(Me.pnlTopMst)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(983, 746)
        Me.pnl.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.SplitContainerControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(983, 471)
        Me.Panel2.TabIndex = 8
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GCDet)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GC)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(983, 471)
        Me.SplitContainerControl1.SplitterPosition = 218
        Me.SplitContainerControl1.TabIndex = 9
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GCDet
        '
        Me.GCDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCDet.Location = New System.Drawing.Point(0, 0)
        Me.GCDet.MainView = Me.GVDet
        Me.GCDet.Name = "GCDet"
        Me.GCDet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepBukuPusat})
        Me.GCDet.Size = New System.Drawing.Size(983, 218)
        Me.GCDet.TabIndex = 0
        Me.GCDet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDet})
        '
        'GVDet
        '
        Me.GVDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.rek_pusat_biaya3, Me.val_total3, Me.val_jumlah3, Me.val_bulanan3, Me.sisa_val3})
        Me.GVDet.GridControl = Me.GCDet
        Me.GVDet.Name = "GVDet"
        Me.GVDet.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GVDet.OptionsView.ShowViewCaption = True
        Me.GVDet.ViewCaption = "DETAIL"
        '
        'rek_pusat_biaya3
        '
        Me.rek_pusat_biaya3.Caption = "Pusat Rekening"
        Me.rek_pusat_biaya3.ColumnEdit = Me.RepBukuPusat
        Me.rek_pusat_biaya3.FieldName = "rek_pusat_biaya"
        Me.rek_pusat_biaya3.Name = "rek_pusat_biaya3"
        Me.rek_pusat_biaya3.Visible = True
        Me.rek_pusat_biaya3.VisibleIndex = 0
        '
        'RepBukuPusat
        '
        Me.RepBukuPusat.AutoHeight = False
        Me.RepBukuPusat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepBukuPusat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.RepBukuPusat.Name = "RepBukuPusat"
        '
        'val_total3
        '
        Me.val_total3.Caption = "Biaya Total"
        Me.val_total3.DisplayFormat.FormatString = "n2"
        Me.val_total3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.val_total3.FieldName = "val_total"
        Me.val_total3.Name = "val_total3"
        Me.val_total3.Visible = True
        Me.val_total3.VisibleIndex = 1
        '
        'val_jumlah3
        '
        Me.val_jumlah3.Caption = "Jumlah"
        Me.val_jumlah3.FieldName = "val_jumlah"
        Me.val_jumlah3.Name = "val_jumlah3"
        Me.val_jumlah3.Visible = True
        Me.val_jumlah3.VisibleIndex = 2
        '
        'val_bulanan3
        '
        Me.val_bulanan3.Caption = "Biaya Bulanan"
        Me.val_bulanan3.DisplayFormat.FormatString = "n2"
        Me.val_bulanan3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.val_bulanan3.FieldName = "val_bulanan"
        Me.val_bulanan3.Name = "val_bulanan3"
        Me.val_bulanan3.Visible = True
        Me.val_bulanan3.VisibleIndex = 3
        '
        'sisa_val3
        '
        Me.sisa_val3.Caption = "Sisa"
        Me.sisa_val3.DisplayFormat.FormatString = "n2"
        Me.sisa_val3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sisa_val3.FieldName = "sisa_val"
        Me.sisa_val3.Name = "sisa_val3"
        Me.sisa_val3.Visible = True
        Me.sisa_val3.VisibleIndex = 4
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Maroon
        Me.pnlFooter.Controls.Add(Me.lblError)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 713)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(983, 33)
        Me.pnlFooter.TabIndex = 2
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(12, 6)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 16)
        Me.lblError.TabIndex = 13
        Me.lblError.Text = "..."
        '
        'pnlTopScnd
        '
        Me.pnlTopScnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTopScnd.Controls.Add(Me.Panel5)
        Me.pnlTopScnd.Controls.Add(Me.LabelControl13)
        Me.pnlTopScnd.Controls.Add(Me.lblState)
        Me.pnlTopScnd.Controls.Add(Me.LabelControl14)
        Me.pnlTopScnd.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopScnd.Location = New System.Drawing.Point(0, 166)
        Me.pnlTopScnd.Name = "pnlTopScnd"
        Me.pnlTopScnd.Size = New System.Drawing.Size(983, 76)
        Me.pnlTopScnd.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LabelControl5)
        Me.Panel5.Controls.Add(Me.txtKeterangan)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(983, 35)
        Me.Panel5.TabIndex = 20
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(0, 3)
        Me.LabelControl5.LookAndFeel.SkinName = "Black"
        Me.LabelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(139, 25)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Keterangan : "
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(139, 6)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(832, 22)
        Me.txtKeterangan.TabIndex = 4
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(901, 54)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl13.TabIndex = 19
        Me.LabelControl13.Text = "*wajib diisi"
        '
        'lblState
        '
        Me.lblState.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblState.Appearance.Options.UseFont = True
        Me.lblState.Appearance.Options.UseForeColor = True
        Me.lblState.Location = New System.Drawing.Point(558, 51)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(15, 19)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "..."
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(7, 57)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(272, 13)
        Me.LabelControl14.TabIndex = 3
        Me.LabelControl14.Text = "Pilih data ditabel beban biaya dimuka untuk edit"
        '
        'pnlTopMst
        '
        Me.pnlTopMst.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTopMst.Controls.Add(Me.cmdPrint)
        Me.pnlTopMst.Controls.Add(Me.cmdSimpan)
        Me.pnlTopMst.Controls.Add(Me.cmdClear)
        Me.pnlTopMst.Controls.Add(Me.cmdRefresh)
        Me.pnlTopMst.Controls.Add(Me.Panel4)
        Me.pnlTopMst.Controls.Add(Me.Panel3)
        Me.pnlTopMst.Controls.Add(Me.Panel6)
        Me.pnlTopMst.Controls.Add(Me.Panel7)
        Me.pnlTopMst.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMst.Location = New System.Drawing.Point(0, 45)
        Me.pnlTopMst.Name = "pnlTopMst"
        Me.pnlTopMst.Size = New System.Drawing.Size(983, 121)
        Me.pnlTopMst.TabIndex = 5
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(863, 3)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 1
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(819, 44)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(82, 23)
        Me.cmdSimpan.TabIndex = 14
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(907, 3)
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
        Me.cmdRefresh.Location = New System.Drawing.Point(819, 3)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 38)
        Me.cmdRefresh.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LabelControl12)
        Me.Panel4.Controls.Add(Me.LOVrekBiaya)
        Me.Panel4.Controls.Add(Me.txtNilaiPembeban)
        Me.Panel4.Controls.Add(Me.LOVbukuPusat)
        Me.Panel4.Controls.Add(Me.txtNilaiTotal)
        Me.Panel4.Controls.Add(Me.LOVstatus)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(558, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 121)
        Me.Panel4.TabIndex = 2
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(224, 0)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl12.TabIndex = 17
        Me.LabelControl12.Text = "*"
        '
        'LOVrekBiaya
        '
        Me.LOVrekBiaya.Location = New System.Drawing.Point(0, 23)
        Me.LOVrekBiaya.Name = "LOVrekBiaya"
        Me.LOVrekBiaya.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVrekBiaya.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.LOVrekBiaya.Size = New System.Drawing.Size(221, 20)
        Me.LOVrekBiaya.TabIndex = 2
        '
        'txtNilaiPembeban
        '
        Me.txtNilaiPembeban.EditValue = "0"
        Me.txtNilaiPembeban.Location = New System.Drawing.Point(0, 71)
        Me.txtNilaiPembeban.Name = "txtNilaiPembeban"
        Me.txtNilaiPembeban.Properties.DisplayFormat.FormatString = "n2"
        Me.txtNilaiPembeban.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiPembeban.Properties.EditFormat.FormatString = "n2"
        Me.txtNilaiPembeban.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiPembeban.Properties.Mask.BeepOnError = True
        Me.txtNilaiPembeban.Properties.Mask.EditMask = "n2"
        Me.txtNilaiPembeban.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiPembeban.Properties.NullText = "0"
        Me.txtNilaiPembeban.Size = New System.Drawing.Size(109, 20)
        Me.txtNilaiPembeban.TabIndex = 1
        Me.txtNilaiPembeban.Visible = False
        '
        'LOVbukuPusat
        '
        Me.LOVbukuPusat.Location = New System.Drawing.Point(112, 71)
        Me.LOVbukuPusat.Name = "LOVbukuPusat"
        Me.LOVbukuPusat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVbukuPusat.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.LOVbukuPusat.Size = New System.Drawing.Size(109, 20)
        Me.LOVbukuPusat.TabIndex = 3
        Me.LOVbukuPusat.Visible = False
        '
        'txtNilaiTotal
        '
        Me.txtNilaiTotal.Location = New System.Drawing.Point(0, 1)
        Me.txtNilaiTotal.Name = "txtNilaiTotal"
        Me.txtNilaiTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txtNilaiTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiTotal.Properties.EditFormat.FormatString = "n2"
        Me.txtNilaiTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiTotal.Properties.Mask.BeepOnError = True
        Me.txtNilaiTotal.Properties.Mask.EditMask = "n2"
        Me.txtNilaiTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiTotal.Size = New System.Drawing.Size(221, 20)
        Me.txtNilaiTotal.TabIndex = 0
        '
        'LOVstatus
        '
        Me.LOVstatus.Location = New System.Drawing.Point(0, 45)
        Me.LOVstatus.Name = "LOVstatus"
        Me.LOVstatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVstatus.Properties.Items.AddRange(New Object() {"AKTIVE", "TIDAK AKTIVE"})
        Me.LOVstatus.Properties.NullText = "[EditValue is null]"
        Me.LOVstatus.Properties.PopupSizeable = True
        Me.LOVstatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.LOVstatus.Size = New System.Drawing.Size(221, 20)
        Me.LOVstatus.TabIndex = 16
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.LabelControl10)
        Me.Panel6.Controls.Add(Me.LabelControl9)
        Me.Panel6.Controls.Add(Me.txtBulan)
        Me.Panel6.Controls.Add(Me.LabelControl8)
        Me.Panel6.Controls.Add(Me.LabelControl7)
        Me.Panel6.Controls.Add(Me.LabelControl6)
        Me.Panel6.Controls.Add(Me.txtNama)
        Me.Panel6.Controls.Add(Me.txtKdCabang)
        Me.Panel6.Controls.Add(Me.tglBerakhir)
        Me.Panel6.Controls.Add(Me.tglBerlaku)
        Me.Panel6.Controls.Add(Me.txtNomor)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(325, 121)
        Me.Panel6.TabIndex = 5
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(284, 79)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl10.TabIndex = 11
        Me.LabelControl10.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(251, 84)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl9.TabIndex = 10
        Me.LabelControl9.Text = "Bulan"
        '
        'txtBulan
        '
        Me.txtBulan.EditValue = "0"
        Me.txtBulan.Location = New System.Drawing.Point(159, 81)
        Me.txtBulan.Name = "txtBulan"
        Me.txtBulan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBulan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBulan.Properties.NullText = "0"
        Me.txtBulan.Size = New System.Drawing.Size(86, 20)
        Me.txtBulan.TabIndex = 9
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(122, 91)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = "*"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(122, 69)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "*"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(235, 45)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "*"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(0, 47)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(233, 20)
        Me.txtNama.TabIndex = 6
        '
        'txtKdCabang
        '
        Me.txtKdCabang.Location = New System.Drawing.Point(0, 1)
        Me.txtKdCabang.Name = "txtKdCabang"
        Me.txtKdCabang.Size = New System.Drawing.Size(51, 20)
        Me.txtKdCabang.TabIndex = 5
        Me.txtKdCabang.Visible = False
        '
        'tglBerakhir
        '
        Me.tglBerakhir.EditValue = Nothing
        Me.tglBerakhir.Location = New System.Drawing.Point(0, 93)
        Me.tglBerakhir.Name = "tglBerakhir"
        Me.tglBerakhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglBerakhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglBerakhir.Size = New System.Drawing.Size(120, 20)
        Me.tglBerakhir.TabIndex = 3
        '
        'tglBerlaku
        '
        Me.tglBerlaku.EditValue = Nothing
        Me.tglBerlaku.Location = New System.Drawing.Point(0, 70)
        Me.tglBerlaku.Name = "tglBerlaku"
        Me.tglBerlaku.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglBerlaku.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglBerlaku.Size = New System.Drawing.Size(120, 20)
        Me.tglBerlaku.TabIndex = 2
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(0, 24)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(233, 20)
        Me.txtNomor.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.LabelControl4)
        Me.Panel7.Controls.Add(Me.LabelControl3)
        Me.Panel7.Controls.Add(Me.LabelControl11)
        Me.Panel7.Controls.Add(Me.LabelControl1)
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 121)
        Me.Panel7.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl4.Location = New System.Drawing.Point(0, 91)
        Me.LabelControl4.LookAndFeel.SkinName = "Black"
        Me.LabelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(139, 23)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Tgl. Berakhir : "
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
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl3.Location = New System.Drawing.Point(0, 67)
        Me.LabelControl3.LookAndFeel.SkinName = "Black"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(139, 24)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Tgl. Berlaku : "
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Appearance.Options.UseTextOptions = True
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl11.Location = New System.Drawing.Point(0, 46)
        Me.LabelControl11.LookAndFeel.SkinName = "Black"
        Me.LabelControl11.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(139, 21)
        Me.LabelControl11.TabIndex = 11
        Me.LabelControl11.Text = "Nama : "
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
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 23)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(139, 23)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Nomor : "
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
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(139, 23)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "--- "
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
        Me.Panel1.Size = New System.Drawing.Size(983, 45)
        Me.Panel1.TabIndex = 4
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
        Me.lblJudul.Text = "BEBAN BIAYA DIMUKA"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmBebanBiayaDmuka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 746)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmBebanBiayaDmuka"
        Me.Text = "frmBebanBiayaDmuka"
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLOVbukuPusat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVrekening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GCDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepBukuPusat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.pnlTopScnd.ResumeLayout(False)
        Me.pnlTopScnd.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopMst.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.LOVrekBiaya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiPembeban.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVbukuPusat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKdCabang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglBerakhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglBerakhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglBerlaku.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglBerlaku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlTopScnd As System.Windows.Forms.Panel
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlTopMst As System.Windows.Forms.Panel
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblState As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tglBerakhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglBerlaku As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LOVbukuPusat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LOVrekBiaya As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNilaiPembeban As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNilaiTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_awal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_akhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_pembebanan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_pusat_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtKdCabang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVstatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LOVrekening As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepLOVbukuPusat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rek_pusat_biaya2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents val_total2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents val_bulanan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_val2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCDet As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rek_pusat_biaya3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents val_total3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents val_bulanan3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_val3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepBukuPusat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents val_jumlah2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents val_jumlah3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBulan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents jml_bln As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
