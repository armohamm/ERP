<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstAktiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstAktiva))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_cabang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_aktiva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.id_table = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_aktiva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_aktiva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kondisi_teknis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kondisi_ekonomis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_perolehan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga_perolehan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.masa_manfaat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_mulai_penyusutan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_penyusutan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.penyusutan_bulan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_buku = New DevExpress.XtraGrid.Columns.GridColumn
        Me.residu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akum_penyusutan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_aktiva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_penyusutan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_pusat_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.pnlTopScnd = New System.Windows.Forms.Panel
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.lblState = New DevExpress.XtraEditors.LabelControl
        Me.pnlTopMst = New System.Windows.Forms.Panel
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cmbStatus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.LOVRekPenyusutan = New DevExpress.XtraEditors.LookUpEdit
        Me.txtPenyusBulan = New DevExpress.XtraEditors.TextEdit
        Me.txtAkumPenyus = New DevExpress.XtraEditors.TextEdit
        Me.txtResidu = New DevExpress.XtraEditors.TextEdit
        Me.LOVBpusat = New DevExpress.XtraEditors.LookUpEdit
        Me.txtKdCabang = New DevExpress.XtraEditors.TextEdit
        Me.LOVBbiaya = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.tglMulaiPenyus = New DevExpress.XtraEditors.DateEdit
        Me.txtMasaMan = New DevExpress.XtraEditors.TextEdit
        Me.txtNilaiBuku = New DevExpress.XtraEditors.TextEdit
        Me.txtNilaiPenyus = New DevExpress.XtraEditors.TextEdit
        Me.txtHargaPero = New DevExpress.XtraEditors.TextEdit
        Me.tglPerolehan = New DevExpress.XtraEditors.DateEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit
        Me.txtKonEko = New DevExpress.XtraEditors.TextEdit
        Me.txtKonTek = New DevExpress.XtraEditors.TextEdit
        Me.txtNmAktiva = New DevExpress.XtraEditors.TextEdit
        Me.txtJmlAktiva = New DevExpress.XtraEditors.TextEdit
        Me.txtNoAktiva = New DevExpress.XtraEditors.TextEdit
        Me.LOVSatuan = New DevExpress.XtraEditors.LookUpEdit
        Me.txtIdTable = New DevExpress.XtraEditors.TextEdit
        Me.LOVRekAktiva = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.pnlTopScnd.SuspendLayout()
        Me.pnlTopMst.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVRekPenyusutan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPenyusBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkumPenyus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResidu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVBpusat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKdCabang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVBbiaya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglMulaiPenyus.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglMulaiPenyus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMasaMan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiBuku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiPenyus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaPero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglPerolehan.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglPerolehan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKonEko.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKonTek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNmAktiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlAktiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoAktiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdTable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVRekAktiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.pnlTopScnd)
        Me.pnl.Controls.Add(Me.pnlTopMst)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1049, 687)
        Me.pnl.TabIndex = 2
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 389)
        Me.GC.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(1049, 267)
        Me.GC.TabIndex = 0
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.ActiveFilterEnabled = False
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_cabang, Me.no_aktiva, Me.id_table, Me.nama_aktiva, Me.satuan, Me.jml_aktiva, Me.kondisi_teknis, Me.kondisi_ekonomis, Me.keterangan, Me.tgl_perolehan, Me.harga_perolehan, Me.masa_manfaat, Me.tgl_mulai_penyusutan, Me.nilai_penyusutan, Me.penyusutan_bulan, Me.nilai_buku, Me.residu, Me.akum_penyusutan, Me.rek_aktiva, Me.rek_penyusutan, Me.rek_biaya, Me.rek_pusat_biaya, Me.status})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowViewCaption = True
        Me.GV.ViewCaption = "MASTER AKTIVA"
        '
        'Kd_cabang
        '
        Me.Kd_cabang.Caption = "Kd. Cabang"
        Me.Kd_cabang.FieldName = "Kd_cabang"
        Me.Kd_cabang.Name = "Kd_cabang"
        Me.Kd_cabang.Visible = True
        Me.Kd_cabang.VisibleIndex = 0
        Me.Kd_cabang.Width = 48
        '
        'no_aktiva
        '
        Me.no_aktiva.Caption = "No. Aktiva"
        Me.no_aktiva.FieldName = "no_aktiva"
        Me.no_aktiva.Name = "no_aktiva"
        Me.no_aktiva.Visible = True
        Me.no_aktiva.VisibleIndex = 1
        Me.no_aktiva.Width = 48
        '
        'id_table
        '
        Me.id_table.Caption = "id. Table"
        Me.id_table.FieldName = "id_table"
        Me.id_table.Name = "id_table"
        Me.id_table.Visible = True
        Me.id_table.VisibleIndex = 2
        Me.id_table.Width = 48
        '
        'nama_aktiva
        '
        Me.nama_aktiva.Caption = "Nama Aktiva"
        Me.nama_aktiva.FieldName = "nama_aktiva"
        Me.nama_aktiva.Name = "nama_aktiva"
        Me.nama_aktiva.Visible = True
        Me.nama_aktiva.VisibleIndex = 3
        Me.nama_aktiva.Width = 48
        '
        'satuan
        '
        Me.satuan.Caption = "satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 4
        Me.satuan.Width = 48
        '
        'jml_aktiva
        '
        Me.jml_aktiva.Caption = "jml aktiva"
        Me.jml_aktiva.FieldName = "jml_aktiva"
        Me.jml_aktiva.Name = "jml_aktiva"
        Me.jml_aktiva.Visible = True
        Me.jml_aktiva.VisibleIndex = 5
        Me.jml_aktiva.Width = 48
        '
        'kondisi_teknis
        '
        Me.kondisi_teknis.Caption = "kondisi teknis"
        Me.kondisi_teknis.FieldName = "kondisi_teknis"
        Me.kondisi_teknis.Name = "kondisi_teknis"
        Me.kondisi_teknis.Visible = True
        Me.kondisi_teknis.VisibleIndex = 6
        Me.kondisi_teknis.Width = 48
        '
        'kondisi_ekonomis
        '
        Me.kondisi_ekonomis.Caption = "kondisi ekonomis"
        Me.kondisi_ekonomis.FieldName = "kondisi_ekonomis"
        Me.kondisi_ekonomis.Name = "kondisi_ekonomis"
        Me.kondisi_ekonomis.Visible = True
        Me.kondisi_ekonomis.VisibleIndex = 7
        Me.kondisi_ekonomis.Width = 48
        '
        'keterangan
        '
        Me.keterangan.Caption = "keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 8
        Me.keterangan.Width = 48
        '
        'tgl_perolehan
        '
        Me.tgl_perolehan.Caption = "tgl perolehan"
        Me.tgl_perolehan.FieldName = "tgl_perolehan"
        Me.tgl_perolehan.Name = "tgl_perolehan"
        Me.tgl_perolehan.Visible = True
        Me.tgl_perolehan.VisibleIndex = 9
        Me.tgl_perolehan.Width = 48
        '
        'harga_perolehan
        '
        Me.harga_perolehan.Caption = "harga perolehan"
        Me.harga_perolehan.FieldName = "harga_perolehan"
        Me.harga_perolehan.Name = "harga_perolehan"
        Me.harga_perolehan.Visible = True
        Me.harga_perolehan.VisibleIndex = 10
        Me.harga_perolehan.Width = 48
        '
        'masa_manfaat
        '
        Me.masa_manfaat.Caption = "masa manfaat"
        Me.masa_manfaat.FieldName = "masa_manfaat"
        Me.masa_manfaat.Name = "masa_manfaat"
        Me.masa_manfaat.Visible = True
        Me.masa_manfaat.VisibleIndex = 11
        Me.masa_manfaat.Width = 48
        '
        'tgl_mulai_penyusutan
        '
        Me.tgl_mulai_penyusutan.Caption = "tgl mulai penyusutan"
        Me.tgl_mulai_penyusutan.FieldName = "tgl_mulai_penyusutan"
        Me.tgl_mulai_penyusutan.Name = "tgl_mulai_penyusutan"
        Me.tgl_mulai_penyusutan.Visible = True
        Me.tgl_mulai_penyusutan.VisibleIndex = 12
        Me.tgl_mulai_penyusutan.Width = 48
        '
        'nilai_penyusutan
        '
        Me.nilai_penyusutan.Caption = "nilai penyusutan"
        Me.nilai_penyusutan.FieldName = "nilai_penyusutan"
        Me.nilai_penyusutan.Name = "nilai_penyusutan"
        Me.nilai_penyusutan.Visible = True
        Me.nilai_penyusutan.VisibleIndex = 13
        Me.nilai_penyusutan.Width = 48
        '
        'penyusutan_bulan
        '
        Me.penyusutan_bulan.Caption = "penyusutan bulan"
        Me.penyusutan_bulan.FieldName = "penyusutan_bulan"
        Me.penyusutan_bulan.Name = "penyusutan_bulan"
        Me.penyusutan_bulan.Visible = True
        Me.penyusutan_bulan.VisibleIndex = 14
        Me.penyusutan_bulan.Width = 48
        '
        'nilai_buku
        '
        Me.nilai_buku.Caption = "nilai buku"
        Me.nilai_buku.FieldName = "nilai_buku"
        Me.nilai_buku.Name = "nilai_buku"
        Me.nilai_buku.Visible = True
        Me.nilai_buku.VisibleIndex = 15
        Me.nilai_buku.Width = 48
        '
        'residu
        '
        Me.residu.Caption = "Residu"
        Me.residu.FieldName = "residu"
        Me.residu.Name = "residu"
        Me.residu.Visible = True
        Me.residu.VisibleIndex = 20
        '
        'akum_penyusutan
        '
        Me.akum_penyusutan.Caption = "Akum. Penyusutan"
        Me.akum_penyusutan.FieldName = "akum_penyusutan"
        Me.akum_penyusutan.Name = "akum_penyusutan"
        Me.akum_penyusutan.Visible = True
        Me.akum_penyusutan.VisibleIndex = 21
        '
        'rek_aktiva
        '
        Me.rek_aktiva.Caption = "rek aktiva"
        Me.rek_aktiva.FieldName = "rek_aktiva"
        Me.rek_aktiva.Name = "rek_aktiva"
        Me.rek_aktiva.Visible = True
        Me.rek_aktiva.VisibleIndex = 16
        Me.rek_aktiva.Width = 48
        '
        'rek_penyusutan
        '
        Me.rek_penyusutan.Caption = "Rek. Penyusutan"
        Me.rek_penyusutan.FieldName = "rek_penyusutan"
        Me.rek_penyusutan.Name = "rek_penyusutan"
        Me.rek_penyusutan.Visible = True
        Me.rek_penyusutan.VisibleIndex = 22
        '
        'rek_biaya
        '
        Me.rek_biaya.Caption = "Rek. Biaya"
        Me.rek_biaya.FieldName = "rek_biaya"
        Me.rek_biaya.Name = "rek_biaya"
        Me.rek_biaya.Visible = True
        Me.rek_biaya.VisibleIndex = 17
        Me.rek_biaya.Width = 104
        '
        'rek_pusat_biaya
        '
        Me.rek_pusat_biaya.Caption = "Rek. Pusat Biaya"
        Me.rek_pusat_biaya.FieldName = "rek_pusat_biaya"
        Me.rek_pusat_biaya.Name = "rek_pusat_biaya"
        Me.rek_pusat_biaya.Visible = True
        Me.rek_pusat_biaya.VisibleIndex = 18
        Me.rek_pusat_biaya.Width = 48
        '
        'status
        '
        Me.status.Caption = "status"
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 19
        Me.status.Width = 20
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Maroon
        Me.pnlFooter.Controls.Add(Me.lblError)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 656)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1049, 31)
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
        Me.pnlTopScnd.Controls.Add(Me.LabelControl14)
        Me.pnlTopScnd.Controls.Add(Me.lblState)
        Me.pnlTopScnd.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopScnd.Location = New System.Drawing.Point(0, 361)
        Me.pnlTopScnd.Name = "pnlTopScnd"
        Me.pnlTopScnd.Size = New System.Drawing.Size(1049, 28)
        Me.pnlTopScnd.TabIndex = 7
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(3, 9)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(166, 13)
        Me.LabelControl14.TabIndex = 3
        Me.LabelControl14.Text = "Pilih data di bawah untuk edit"
        '
        'lblState
        '
        Me.lblState.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblState.Appearance.Options.UseFont = True
        Me.lblState.Appearance.Options.UseForeColor = True
        Me.lblState.Location = New System.Drawing.Point(415, 4)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(15, 19)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "..."
        '
        'pnlTopMst
        '
        Me.pnlTopMst.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTopMst.Controls.Add(Me.LabelControl19)
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
        Me.pnlTopMst.Size = New System.Drawing.Size(1049, 316)
        Me.pnlTopMst.TabIndex = 5
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(833, 294)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl19.TabIndex = 20
        Me.LabelControl19.Text = "*wajib diisi"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(877, 3)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 1
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(833, 42)
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
        Me.cmdClear.Location = New System.Drawing.Point(921, 3)
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
        Me.cmdRefresh.Location = New System.Drawing.Point(833, 3)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 38)
        Me.cmdRefresh.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmbStatus)
        Me.Panel4.Controls.Add(Me.LabelControl21)
        Me.Panel4.Controls.Add(Me.LabelControl17)
        Me.Panel4.Controls.Add(Me.LabelControl16)
        Me.Panel4.Controls.Add(Me.LabelControl15)
        Me.Panel4.Controls.Add(Me.LOVRekPenyusutan)
        Me.Panel4.Controls.Add(Me.txtPenyusBulan)
        Me.Panel4.Controls.Add(Me.txtAkumPenyus)
        Me.Panel4.Controls.Add(Me.txtResidu)
        Me.Panel4.Controls.Add(Me.LOVBpusat)
        Me.Panel4.Controls.Add(Me.txtKdCabang)
        Me.Panel4.Controls.Add(Me.LOVBbiaya)
        Me.Panel4.Controls.Add(Me.LabelControl10)
        Me.Panel4.Controls.Add(Me.LabelControl9)
        Me.Panel4.Controls.Add(Me.tglMulaiPenyus)
        Me.Panel4.Controls.Add(Me.txtMasaMan)
        Me.Panel4.Controls.Add(Me.txtNilaiBuku)
        Me.Panel4.Controls.Add(Me.txtNilaiPenyus)
        Me.Panel4.Controls.Add(Me.txtHargaPero)
        Me.Panel4.Controls.Add(Me.tglPerolehan)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(580, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 316)
        Me.Panel4.TabIndex = 2
        '
        'cmbStatus
        '
        Me.cmbStatus.Location = New System.Drawing.Point(0, 232)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.Items.AddRange(New Object() {"AKTIF", "DEAKTIF"})
        Me.cmbStatus.Size = New System.Drawing.Size(205, 20)
        Me.cmbStatus.TabIndex = 51
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseForeColor = True
        Me.LabelControl21.Location = New System.Drawing.Point(207, 167)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl21.TabIndex = 49
        Me.LabelControl21.Text = "*"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(192, 252)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl17.TabIndex = 48
        Me.LabelControl17.Text = "*"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(207, 210)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl16.TabIndex = 47
        Me.LabelControl16.Text = "*"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(207, 188)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl15.TabIndex = 17
        Me.LabelControl15.Text = "*"
        '
        'LOVRekPenyusutan
        '
        Me.LOVRekPenyusutan.Location = New System.Drawing.Point(0, 169)
        Me.LOVRekPenyusutan.Name = "LOVRekPenyusutan"
        Me.LOVRekPenyusutan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LOVRekPenyusutan.Properties.Appearance.Options.UseBackColor = True
        Me.LOVRekPenyusutan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVRekPenyusutan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.LOVRekPenyusutan.Properties.NullText = ""
        Me.LOVRekPenyusutan.Size = New System.Drawing.Size(205, 20)
        Me.LOVRekPenyusutan.TabIndex = 8
        '
        'txtPenyusBulan
        '
        Me.txtPenyusBulan.EditValue = "0"
        Me.txtPenyusBulan.EnterMoveNextControl = True
        Me.txtPenyusBulan.Location = New System.Drawing.Point(0, 253)
        Me.txtPenyusBulan.Name = "txtPenyusBulan"
        Me.txtPenyusBulan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPenyusBulan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtPenyusBulan.Properties.Appearance.Options.UseBackColor = True
        Me.txtPenyusBulan.Properties.Appearance.Options.UseForeColor = True
        Me.txtPenyusBulan.Properties.Mask.BeepOnError = True
        Me.txtPenyusBulan.Properties.Mask.EditMask = "n2"
        Me.txtPenyusBulan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPenyusBulan.Size = New System.Drawing.Size(154, 20)
        Me.txtPenyusBulan.TabIndex = 12
        Me.txtPenyusBulan.Visible = False
        '
        'txtAkumPenyus
        '
        Me.txtAkumPenyus.EditValue = "0"
        Me.txtAkumPenyus.EnterMoveNextControl = True
        Me.txtAkumPenyus.Location = New System.Drawing.Point(0, 148)
        Me.txtAkumPenyus.Name = "txtAkumPenyus"
        Me.txtAkumPenyus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAkumPenyus.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtAkumPenyus.Properties.Appearance.Options.UseBackColor = True
        Me.txtAkumPenyus.Properties.Appearance.Options.UseForeColor = True
        Me.txtAkumPenyus.Properties.DisplayFormat.FormatString = "n2"
        Me.txtAkumPenyus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAkumPenyus.Properties.EditFormat.FormatString = "n2"
        Me.txtAkumPenyus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAkumPenyus.Properties.Mask.BeepOnError = True
        Me.txtAkumPenyus.Properties.Mask.EditMask = "n"
        Me.txtAkumPenyus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAkumPenyus.Properties.ReadOnly = True
        Me.txtAkumPenyus.Size = New System.Drawing.Size(205, 20)
        Me.txtAkumPenyus.TabIndex = 7
        '
        'txtResidu
        '
        Me.txtResidu.EditValue = "0"
        Me.txtResidu.EnterMoveNextControl = True
        Me.txtResidu.Location = New System.Drawing.Point(0, 127)
        Me.txtResidu.Name = "txtResidu"
        Me.txtResidu.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtResidu.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtResidu.Properties.Appearance.Options.UseBackColor = True
        Me.txtResidu.Properties.Appearance.Options.UseForeColor = True
        Me.txtResidu.Properties.DisplayFormat.FormatString = "n2"
        Me.txtResidu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtResidu.Properties.EditFormat.FormatString = "n2"
        Me.txtResidu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtResidu.Size = New System.Drawing.Size(154, 20)
        Me.txtResidu.TabIndex = 6
        '
        'LOVBpusat
        '
        Me.LOVBpusat.Location = New System.Drawing.Point(0, 211)
        Me.LOVBpusat.Name = "LOVBpusat"
        Me.LOVBpusat.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVBpusat.Properties.Appearance.Options.UseBackColor = True
        Me.LOVBpusat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVBpusat.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.LOVBpusat.Properties.NullText = ""
        Me.LOVBpusat.Size = New System.Drawing.Size(205, 20)
        Me.LOVBpusat.TabIndex = 10
        '
        'txtKdCabang
        '
        Me.txtKdCabang.Enabled = False
        Me.txtKdCabang.EnterMoveNextControl = True
        Me.txtKdCabang.Location = New System.Drawing.Point(0, 275)
        Me.txtKdCabang.Name = "txtKdCabang"
        Me.txtKdCabang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtKdCabang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKdCabang.Properties.Appearance.Options.UseBackColor = True
        Me.txtKdCabang.Properties.Appearance.Options.UseForeColor = True
        Me.txtKdCabang.Size = New System.Drawing.Size(57, 20)
        Me.txtKdCabang.TabIndex = 32
        Me.txtKdCabang.Visible = False
        '
        'LOVBbiaya
        '
        Me.LOVBbiaya.Location = New System.Drawing.Point(0, 190)
        Me.LOVBbiaya.Name = "LOVBbiaya"
        Me.LOVBbiaya.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVBbiaya.Properties.Appearance.Options.UseBackColor = True
        Me.LOVBbiaya.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVBbiaya.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.LOVBbiaya.Properties.NullText = ""
        Me.LOVBbiaya.Size = New System.Drawing.Size(205, 20)
        Me.LOVBbiaya.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(160, 256)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl10.TabIndex = 46
        Me.LabelControl10.Text = "Bulan"
        Me.LabelControl10.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(160, 45)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl9.TabIndex = 45
        Me.LabelControl9.Text = "Bulan"
        '
        'tglMulaiPenyus
        '
        Me.tglMulaiPenyus.EditValue = Nothing
        Me.tglMulaiPenyus.Location = New System.Drawing.Point(0, 64)
        Me.tglMulaiPenyus.Name = "tglMulaiPenyus"
        Me.tglMulaiPenyus.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglMulaiPenyus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglMulaiPenyus.Properties.Appearance.Options.UseBackColor = True
        Me.tglMulaiPenyus.Properties.Appearance.Options.UseFont = True
        Me.tglMulaiPenyus.Properties.Appearance.Options.UseTextOptions = True
        Me.tglMulaiPenyus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglMulaiPenyus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglMulaiPenyus.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tglMulaiPenyus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglMulaiPenyus.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglMulaiPenyus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglMulaiPenyus.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglMulaiPenyus.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglMulaiPenyus.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglMulaiPenyus.Size = New System.Drawing.Size(154, 20)
        Me.tglMulaiPenyus.TabIndex = 3
        '
        'txtMasaMan
        '
        Me.txtMasaMan.EditValue = "1"
        Me.txtMasaMan.EnterMoveNextControl = True
        Me.txtMasaMan.Location = New System.Drawing.Point(0, 43)
        Me.txtMasaMan.Name = "txtMasaMan"
        Me.txtMasaMan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMasaMan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtMasaMan.Properties.Appearance.Options.UseBackColor = True
        Me.txtMasaMan.Properties.Appearance.Options.UseForeColor = True
        Me.txtMasaMan.Properties.Mask.BeepOnError = True
        Me.txtMasaMan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMasaMan.Size = New System.Drawing.Size(154, 20)
        Me.txtMasaMan.TabIndex = 2
        '
        'txtNilaiBuku
        '
        Me.txtNilaiBuku.EditValue = "0"
        Me.txtNilaiBuku.EnterMoveNextControl = True
        Me.txtNilaiBuku.Location = New System.Drawing.Point(0, 106)
        Me.txtNilaiBuku.Name = "txtNilaiBuku"
        Me.txtNilaiBuku.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNilaiBuku.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNilaiBuku.Properties.Appearance.Options.UseBackColor = True
        Me.txtNilaiBuku.Properties.Appearance.Options.UseForeColor = True
        Me.txtNilaiBuku.Properties.DisplayFormat.FormatString = "n2"
        Me.txtNilaiBuku.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiBuku.Properties.EditFormat.FormatString = "n2"
        Me.txtNilaiBuku.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiBuku.Properties.Mask.BeepOnError = True
        Me.txtNilaiBuku.Properties.Mask.EditMask = "n"
        Me.txtNilaiBuku.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiBuku.Properties.ReadOnly = True
        Me.txtNilaiBuku.Size = New System.Drawing.Size(205, 20)
        Me.txtNilaiBuku.TabIndex = 5
        '
        'txtNilaiPenyus
        '
        Me.txtNilaiPenyus.EditValue = "0"
        Me.txtNilaiPenyus.EnterMoveNextControl = True
        Me.txtNilaiPenyus.Location = New System.Drawing.Point(0, 85)
        Me.txtNilaiPenyus.Name = "txtNilaiPenyus"
        Me.txtNilaiPenyus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNilaiPenyus.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNilaiPenyus.Properties.Appearance.Options.UseBackColor = True
        Me.txtNilaiPenyus.Properties.Appearance.Options.UseForeColor = True
        Me.txtNilaiPenyus.Properties.DisplayFormat.FormatString = "n2"
        Me.txtNilaiPenyus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiPenyus.Properties.EditFormat.FormatString = "n2"
        Me.txtNilaiPenyus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilaiPenyus.Properties.Mask.BeepOnError = True
        Me.txtNilaiPenyus.Properties.Mask.EditMask = "n"
        Me.txtNilaiPenyus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNilaiPenyus.Properties.ReadOnly = True
        Me.txtNilaiPenyus.Size = New System.Drawing.Size(205, 20)
        Me.txtNilaiPenyus.TabIndex = 4
        '
        'txtHargaPero
        '
        Me.txtHargaPero.EditValue = "0"
        Me.txtHargaPero.EnterMoveNextControl = True
        Me.txtHargaPero.Location = New System.Drawing.Point(0, 22)
        Me.txtHargaPero.Name = "txtHargaPero"
        Me.txtHargaPero.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtHargaPero.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtHargaPero.Properties.Appearance.Options.UseBackColor = True
        Me.txtHargaPero.Properties.Appearance.Options.UseForeColor = True
        Me.txtHargaPero.Properties.DisplayFormat.FormatString = "n2"
        Me.txtHargaPero.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaPero.Properties.EditFormat.FormatString = "n2"
        Me.txtHargaPero.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaPero.Properties.Mask.BeepOnError = True
        Me.txtHargaPero.Properties.Mask.EditMask = "n"
        Me.txtHargaPero.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtHargaPero.Size = New System.Drawing.Size(205, 20)
        Me.txtHargaPero.TabIndex = 1
        '
        'tglPerolehan
        '
        Me.tglPerolehan.EditValue = Nothing
        Me.tglPerolehan.Location = New System.Drawing.Point(0, 1)
        Me.tglPerolehan.Name = "tglPerolehan"
        Me.tglPerolehan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglPerolehan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglPerolehan.Properties.Appearance.Options.UseBackColor = True
        Me.tglPerolehan.Properties.Appearance.Options.UseFont = True
        Me.tglPerolehan.Properties.Appearance.Options.UseTextOptions = True
        Me.tglPerolehan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglPerolehan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglPerolehan.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tglPerolehan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglPerolehan.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglPerolehan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglPerolehan.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglPerolehan.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglPerolehan.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglPerolehan.Size = New System.Drawing.Size(154, 20)
        Me.tglPerolehan.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LabelControl13)
        Me.Panel3.Controls.Add(Me.LabelControl12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(415, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(165, 316)
        Me.Panel3.TabIndex = 1
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Appearance.Options.UseTextOptions = True
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl13.Location = New System.Drawing.Point(0, 273)
        Me.LabelControl13.LookAndFeel.SkinName = "Black"
        Me.LabelControl13.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(165, 20)
        Me.LabelControl13.TabIndex = 16
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Appearance.Options.UseTextOptions = True
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl12.Location = New System.Drawing.Point(0, 253)
        Me.LabelControl12.LookAndFeel.SkinName = "Black"
        Me.LabelControl12.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(165, 20)
        Me.LabelControl12.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Status : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(0, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(165, 21)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Rek. Pusat Biaya : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(165, 21)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Rek. Biaya : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 22)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Rek. Penyusutan : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Akumulasi Penyusutan : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 22)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Residu : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nilai Buku : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nilai Penyusutan / Bulan : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tgl. Mulai Penyusutan : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Masa Manfaat : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga / Nilai Perolehan : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl. Perolehan : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.LabelControl20)
        Me.Panel6.Controls.Add(Me.LabelControl18)
        Me.Panel6.Controls.Add(Me.txtKeterangan)
        Me.Panel6.Controls.Add(Me.txtKonEko)
        Me.Panel6.Controls.Add(Me.txtKonTek)
        Me.Panel6.Controls.Add(Me.txtNmAktiva)
        Me.Panel6.Controls.Add(Me.txtJmlAktiva)
        Me.Panel6.Controls.Add(Me.txtNoAktiva)
        Me.Panel6.Controls.Add(Me.LOVSatuan)
        Me.Panel6.Controls.Add(Me.txtIdTable)
        Me.Panel6.Controls.Add(Me.LOVRekAktiva)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(276, 316)
        Me.Panel6.TabIndex = 5
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(255, 22)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl20.TabIndex = 17
        Me.LabelControl20.Text = "*"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(256, 67)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl18.TabIndex = 16
        Me.LabelControl18.Text = "*"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.EnterMoveNextControl = True
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 264)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKeterangan.Properties.Appearance.Options.UseBackColor = True
        Me.txtKeterangan.Properties.Appearance.Options.UseForeColor = True
        Me.txtKeterangan.Properties.AutoHeight = False
        Me.txtKeterangan.Size = New System.Drawing.Size(253, 42)
        Me.txtKeterangan.TabIndex = 8
        '
        'txtKonEko
        '
        Me.txtKonEko.EnterMoveNextControl = True
        Me.txtKonEko.Location = New System.Drawing.Point(0, 220)
        Me.txtKonEko.Name = "txtKonEko"
        Me.txtKonEko.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtKonEko.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKonEko.Properties.Appearance.Options.UseBackColor = True
        Me.txtKonEko.Properties.Appearance.Options.UseForeColor = True
        Me.txtKonEko.Properties.AutoHeight = False
        Me.txtKonEko.Size = New System.Drawing.Size(253, 42)
        Me.txtKonEko.TabIndex = 7
        '
        'txtKonTek
        '
        Me.txtKonTek.EnterMoveNextControl = True
        Me.txtKonTek.Location = New System.Drawing.Point(0, 176)
        Me.txtKonTek.Name = "txtKonTek"
        Me.txtKonTek.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtKonTek.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKonTek.Properties.Appearance.Options.UseBackColor = True
        Me.txtKonTek.Properties.Appearance.Options.UseForeColor = True
        Me.txtKonTek.Properties.AutoHeight = False
        Me.txtKonTek.Size = New System.Drawing.Size(253, 42)
        Me.txtKonTek.TabIndex = 6
        '
        'txtNmAktiva
        '
        Me.txtNmAktiva.EnterMoveNextControl = True
        Me.txtNmAktiva.Location = New System.Drawing.Point(0, 67)
        Me.txtNmAktiva.Name = "txtNmAktiva"
        Me.txtNmAktiva.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNmAktiva.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNmAktiva.Properties.Appearance.Options.UseBackColor = True
        Me.txtNmAktiva.Properties.Appearance.Options.UseForeColor = True
        Me.txtNmAktiva.Properties.AutoHeight = False
        Me.txtNmAktiva.Size = New System.Drawing.Size(253, 64)
        Me.txtNmAktiva.TabIndex = 3
        '
        'txtJmlAktiva
        '
        Me.txtJmlAktiva.EditValue = "0"
        Me.txtJmlAktiva.EnterMoveNextControl = True
        Me.txtJmlAktiva.Location = New System.Drawing.Point(0, 154)
        Me.txtJmlAktiva.Name = "txtJmlAktiva"
        Me.txtJmlAktiva.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtJmlAktiva.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlAktiva.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlAktiva.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlAktiva.Properties.Mask.BeepOnError = True
        Me.txtJmlAktiva.Properties.Mask.EditMask = "n2"
        Me.txtJmlAktiva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtJmlAktiva.Size = New System.Drawing.Size(133, 20)
        Me.txtJmlAktiva.TabIndex = 5
        '
        'txtNoAktiva
        '
        Me.txtNoAktiva.Enabled = False
        Me.txtNoAktiva.EnterMoveNextControl = True
        Me.txtNoAktiva.Location = New System.Drawing.Point(0, 1)
        Me.txtNoAktiva.Name = "txtNoAktiva"
        Me.txtNoAktiva.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNoAktiva.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoAktiva.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoAktiva.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoAktiva.Size = New System.Drawing.Size(133, 20)
        Me.txtNoAktiva.TabIndex = 0
        '
        'LOVSatuan
        '
        Me.LOVSatuan.Location = New System.Drawing.Point(0, 132)
        Me.LOVSatuan.Name = "LOVSatuan"
        Me.LOVSatuan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVSatuan.Properties.Appearance.Options.UseBackColor = True
        Me.LOVSatuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVSatuan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode_satuan", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_satuan", "Nama")})
        Me.LOVSatuan.Properties.NullText = ""
        Me.LOVSatuan.Size = New System.Drawing.Size(253, 20)
        Me.LOVSatuan.TabIndex = 4
        '
        'txtIdTable
        '
        Me.txtIdTable.EditValue = "MASTER"
        Me.txtIdTable.Enabled = False
        Me.txtIdTable.EnterMoveNextControl = True
        Me.txtIdTable.Location = New System.Drawing.Point(0, 45)
        Me.txtIdTable.Name = "txtIdTable"
        Me.txtIdTable.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtIdTable.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtIdTable.Properties.Appearance.Options.UseBackColor = True
        Me.txtIdTable.Properties.Appearance.Options.UseForeColor = True
        Me.txtIdTable.Size = New System.Drawing.Size(133, 20)
        Me.txtIdTable.TabIndex = 2
        Me.txtIdTable.Visible = False
        '
        'LOVRekAktiva
        '
        Me.LOVRekAktiva.Location = New System.Drawing.Point(0, 23)
        Me.LOVRekAktiva.Name = "LOVRekAktiva"
        Me.LOVRekAktiva.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVRekAktiva.Properties.Appearance.Options.UseBackColor = True
        Me.LOVRekAktiva.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVRekAktiva.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama.")})
        Me.LOVRekAktiva.Properties.NullText = ""
        Me.LOVRekAktiva.Size = New System.Drawing.Size(253, 20)
        Me.LOVRekAktiva.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Controls.Add(Me.LabelControl8)
        Me.Panel7.Controls.Add(Me.LabelControl7)
        Me.Panel7.Controls.Add(Me.LabelControl6)
        Me.Panel7.Controls.Add(Me.LabelControl5)
        Me.Panel7.Controls.Add(Me.LabelControl4)
        Me.Panel7.Controls.Add(Me.LabelControl3)
        Me.Panel7.Controls.Add(Me.LabelControl11)
        Me.Panel7.Controls.Add(Me.LabelControl1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 316)
        Me.Panel7.TabIndex = 9
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
        Me.LabelControl2.Location = New System.Drawing.Point(0, 260)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(139, 44)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Keterangan : "
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl8.Location = New System.Drawing.Point(0, 216)
        Me.LabelControl8.LookAndFeel.SkinName = "Black"
        Me.LabelControl8.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(139, 44)
        Me.LabelControl8.TabIndex = 9
        Me.LabelControl8.Text = "Kondisi Ekonomis : "
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl7.Location = New System.Drawing.Point(0, 172)
        Me.LabelControl7.LookAndFeel.SkinName = "Black"
        Me.LabelControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(139, 44)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "Kondisi Teknis : "
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl6.Location = New System.Drawing.Point(0, 150)
        Me.LabelControl6.LookAndFeel.SkinName = "Black"
        Me.LabelControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(139, 22)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Jml. Aktiva : "
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
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl5.Location = New System.Drawing.Point(0, 128)
        Me.LabelControl5.LookAndFeel.SkinName = "Black"
        Me.LabelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(139, 22)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Satuan : "
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
        Me.LabelControl4.Location = New System.Drawing.Point(0, 64)
        Me.LabelControl4.LookAndFeel.SkinName = "Black"
        Me.LabelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(139, 64)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Nama Aktiva : "
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
        Me.LabelControl3.Location = New System.Drawing.Point(0, 46)
        Me.LabelControl3.LookAndFeel.SkinName = "Black"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(139, 18)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "---"
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
        Me.LabelControl11.Location = New System.Drawing.Point(0, 21)
        Me.LabelControl11.LookAndFeel.SkinName = "Black"
        Me.LabelControl11.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(139, 25)
        Me.LabelControl11.TabIndex = 11
        Me.LabelControl11.Text = "Rek Aktiva : "
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
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(139, 21)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "No. Aktiva : "
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
        Me.Panel1.Size = New System.Drawing.Size(1049, 45)
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
        Me.lblJudul.Text = "MASTER AKTIVA"
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
        'frmMstAktiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 687)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstAktiva"
        Me.Text = "frmMstAktiva"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.pnlTopScnd.ResumeLayout(False)
        Me.pnlTopScnd.PerformLayout()
        Me.pnlTopMst.ResumeLayout(False)
        Me.pnlTopMst.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVRekPenyusutan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPenyusBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkumPenyus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResidu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVBpusat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKdCabang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVBbiaya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglMulaiPenyus.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglMulaiPenyus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMasaMan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiBuku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiPenyus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaPero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglPerolehan.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglPerolehan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKonEko.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKonTek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNmAktiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlAktiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoAktiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdTable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVRekAktiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_cabang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_aktiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents id_table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_aktiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_aktiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kondisi_teknis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kondisi_ekonomis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_perolehan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga_perolehan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlTopScnd As System.Windows.Forms.Panel
    Friend WithEvents pnlTopMst As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tglPerolehan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LOVSatuan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LOVRekAktiva As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKdCabang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdTable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoAktiva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtJmlAktiva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNilaiPenyus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHargaPero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNilaiBuku As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPenyusBulan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tglMulaiPenyus As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtMasaMan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtKonEko As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKonTek As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNmAktiva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents masa_manfaat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_mulai_penyusutan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_penyusutan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents penyusutan_bulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_buku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_aktiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblState As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LOVBpusat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LOVBbiaya As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rek_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_pusat_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAkumPenyus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtResidu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LOVRekPenyusutan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents residu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akum_penyusutan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_penyusutan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.ComboBoxEdit
End Class
