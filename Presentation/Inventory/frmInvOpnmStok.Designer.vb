<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvOpnmStok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvOpnmStok))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GcOpnStok = New DevExpress.XtraGrid.GridControl
        Me.GvOpnStok = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.spek_brg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLookupJenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_jns_persd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLookupPersd = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.qty_data = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_opname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_selisih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.persen_selisih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_gudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLookupGudang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.lblNmBrg = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.txbKdBrg = New System.Windows.Forms.TextBox
        Me.txbLokasi = New System.Windows.Forms.TextBox
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txbNoTrans = New System.Windows.Forms.TextBox
        Me.LU_Gudang = New DevExpress.XtraEditors.LookUpEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.pnl_namabrg = New System.Windows.Forms.Panel
        Me.txtcari = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LookupPersd = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.GcOpnStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvOpnStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLookupJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLookupPersd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLookupGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LU_Gudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_namabrg.SuspendLayout()
        CType(Me.LookupPersd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel6)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 430)
        Me.pnl.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GcOpnStok)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 131)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(792, 261)
        Me.Panel6.TabIndex = 3
        '
        'GcOpnStok
        '
        Me.GcOpnStok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcOpnStok.Location = New System.Drawing.Point(0, 0)
        Me.GcOpnStok.MainView = Me.GvOpnStok
        Me.GcOpnStok.Name = "GcOpnStok"
        Me.GcOpnStok.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepLookupStok, Me.RepLookupGudang, Me.RepLookupJenis, Me.RepLookupPersd})
        Me.GcOpnStok.Size = New System.Drawing.Size(792, 261)
        Me.GcOpnStok.TabIndex = 154
        Me.GcOpnStok.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvOpnStok})
        '
        'GvOpnStok
        '
        Me.GvOpnStok.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.kd_stok, Me.kd_satuan, Me.spek_brg, Me.kd_jenis, Me.kd_jns_persd, Me.qty_data, Me.qty_opname, Me.qty_selisih, Me.persen_selisih, Me.keterangan, Me.kd_gudang})
        Me.GvOpnStok.GridControl = Me.GcOpnStok
        Me.GvOpnStok.Name = "GvOpnStok"
        Me.GvOpnStok.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvOpnStok.OptionsView.RowAutoHeight = True
        Me.GvOpnStok.OptionsView.ShowFooter = True
        '
        'nomer
        '
        Me.nomer.Caption = "No"
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.AllowEdit = False
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 20
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.RepLookupStok
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 137
        '
        'RepLookupStok
        '
        Me.RepLookupStok.AutoHeight = False
        Me.RepLookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLookupStok.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.RepLookupStok.Name = "RepLookupStok"
        Me.RepLookupStok.NullText = ""
        '
        'kd_satuan
        '
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.ReadOnly = True
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 3
        Me.kd_satuan.Width = 36
        '
        'spek_brg
        '
        Me.spek_brg.Caption = "Spek Barang"
        Me.spek_brg.FieldName = "spek_brg"
        Me.spek_brg.Name = "spek_brg"
        Me.spek_brg.OptionsColumn.AllowEdit = False
        Me.spek_brg.OptionsColumn.ReadOnly = True
        Me.spek_brg.Visible = True
        Me.spek_brg.VisibleIndex = 2
        Me.spek_brg.Width = 60
        '
        'kd_jenis
        '
        Me.kd_jenis.Caption = "Jenis Barang"
        Me.kd_jenis.ColumnEdit = Me.RepLookupJenis
        Me.kd_jenis.FieldName = "kd_jenis"
        Me.kd_jenis.Name = "kd_jenis"
        Me.kd_jenis.OptionsColumn.AllowEdit = False
        Me.kd_jenis.OptionsColumn.ReadOnly = True
        Me.kd_jenis.Visible = True
        Me.kd_jenis.VisibleIndex = 6
        Me.kd_jenis.Width = 61
        '
        'RepLookupJenis
        '
        Me.RepLookupJenis.AutoHeight = False
        Me.RepLookupJenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLookupJenis.Name = "RepLookupJenis"
        Me.RepLookupJenis.NullText = ""
        '
        'kd_jns_persd
        '
        Me.kd_jns_persd.Caption = "Jenis Persediaan"
        Me.kd_jns_persd.ColumnEdit = Me.RepLookupPersd
        Me.kd_jns_persd.FieldName = "kd_jns_persd"
        Me.kd_jns_persd.Name = "kd_jns_persd"
        Me.kd_jns_persd.OptionsColumn.AllowEdit = False
        Me.kd_jns_persd.OptionsColumn.ReadOnly = True
        Me.kd_jns_persd.Visible = True
        Me.kd_jns_persd.VisibleIndex = 5
        Me.kd_jns_persd.Width = 77
        '
        'RepLookupPersd
        '
        Me.RepLookupPersd.AutoHeight = False
        Me.RepLookupPersd.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLookupPersd.Name = "RepLookupPersd"
        Me.RepLookupPersd.NullText = ""
        '
        'qty_data
        '
        Me.qty_data.Caption = "Qty Data"
        Me.qty_data.FieldName = "qty_data"
        Me.qty_data.Name = "qty_data"
        Me.qty_data.OptionsColumn.AllowEdit = False
        Me.qty_data.OptionsColumn.ReadOnly = True
        Me.qty_data.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_data.Visible = True
        Me.qty_data.VisibleIndex = 7
        Me.qty_data.Width = 49
        '
        'qty_opname
        '
        Me.qty_opname.Caption = "Qty Manual"
        Me.qty_opname.FieldName = "qty_opname"
        Me.qty_opname.Name = "qty_opname"
        Me.qty_opname.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_opname.Visible = True
        Me.qty_opname.VisibleIndex = 8
        Me.qty_opname.Width = 61
        '
        'qty_selisih
        '
        Me.qty_selisih.Caption = "Selisih"
        Me.qty_selisih.FieldName = "qty_selisih"
        Me.qty_selisih.Name = "qty_selisih"
        Me.qty_selisih.OptionsColumn.AllowEdit = False
        Me.qty_selisih.OptionsColumn.ReadOnly = True
        Me.qty_selisih.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_selisih.Visible = True
        Me.qty_selisih.VisibleIndex = 9
        Me.qty_selisih.Width = 36
        '
        'persen_selisih
        '
        Me.persen_selisih.Caption = "Prosentase (%)"
        Me.persen_selisih.FieldName = "persen_selisih"
        Me.persen_selisih.Name = "persen_selisih"
        Me.persen_selisih.OptionsColumn.AllowEdit = False
        Me.persen_selisih.OptionsColumn.ReadOnly = True
        Me.persen_selisih.Visible = True
        Me.persen_selisih.VisibleIndex = 10
        Me.persen_selisih.Width = 62
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.AllowEdit = False
        Me.keterangan.OptionsColumn.ReadOnly = True
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 11
        Me.keterangan.Width = 109
        '
        'kd_gudang
        '
        Me.kd_gudang.Caption = "Gudang"
        Me.kd_gudang.FieldName = "kd_gudang"
        Me.kd_gudang.Name = "kd_gudang"
        Me.kd_gudang.OptionsColumn.AllowEdit = False
        Me.kd_gudang.OptionsColumn.ReadOnly = True
        Me.kd_gudang.Visible = True
        Me.kd_gudang.VisibleIndex = 4
        Me.kd_gudang.Width = 63
        '
        'RepLookupGudang
        '
        Me.RepLookupGudang.AutoHeight = False
        Me.RepLookupGudang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLookupGudang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Nama Gudang")})
        Me.RepLookupGudang.Name = "RepLookupGudang"
        Me.RepLookupGudang.NullText = ""
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 392)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 38)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.txbLokasi)
        Me.Panel5.Controls.Add(Me.btnLoad)
        Me.Panel5.Controls.Add(Me.btnSelect)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(792, 38)
        Me.Panel5.TabIndex = 144
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Black
        Me.Panel10.Controls.Add(Me.lblNmBrg)
        Me.Panel10.Controls.Add(Me.lblStatus)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(255, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(537, 38)
        Me.Panel10.TabIndex = 169
        '
        'lblNmBrg
        '
        Me.lblNmBrg.AutoSize = True
        Me.lblNmBrg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNmBrg.ForeColor = System.Drawing.Color.Yellow
        Me.lblNmBrg.Location = New System.Drawing.Point(393, 12)
        Me.lblNmBrg.Name = "lblNmBrg"
        Me.lblNmBrg.Size = New System.Drawing.Size(0, 15)
        Me.lblNmBrg.TabIndex = 157
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Yellow
        Me.lblStatus.Location = New System.Drawing.Point(17, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 156
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Maroon
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.txbKdBrg)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(255, 38)
        Me.Panel8.TabIndex = 167
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Kode Barang :"
        '
        'txbKdBrg
        '
        Me.txbKdBrg.Location = New System.Drawing.Point(102, 10)
        Me.txbKdBrg.Name = "txbKdBrg"
        Me.txbKdBrg.Size = New System.Drawing.Size(150, 20)
        Me.txbKdBrg.TabIndex = 168
        '
        'txbLokasi
        '
        Me.txbLokasi.Location = New System.Drawing.Point(402, 7)
        Me.txbLokasi.Name = "txbLokasi"
        Me.txbLokasi.Size = New System.Drawing.Size(231, 20)
        Me.txbLokasi.TabIndex = 166
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLoad.Location = New System.Drawing.Point(735, 5)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(52, 22)
        Me.btnLoad.TabIndex = 165
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSelect.Location = New System.Drawing.Point(639, 6)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(70, 22)
        Me.btnSelect.TabIndex = 164
        Me.btnSelect.Text = "Select File"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(307, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Load Text file :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 88)
        Me.Panel2.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lookupBulanAwal)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.txbNoTrans)
        Me.Panel7.Controls.Add(Me.LU_Gudang)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.cmdClear)
        Me.Panel7.Controls.Add(Me.pnl_namabrg)
        Me.Panel7.Controls.Add(Me.cmdRefresh)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.LookupPersd)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(792, 88)
        Me.Panel7.TabIndex = 0
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(102, 9)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(171, 20)
        Me.lookupBulanAwal.TabIndex = 188
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(391, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 187
        Me.Label3.Text = "No Transaksi :"
        '
        'txbNoTrans
        '
        Me.txbNoTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbNoTrans.Location = New System.Drawing.Point(492, 11)
        Me.txbNoTrans.Name = "txbNoTrans"
        Me.txbNoTrans.Size = New System.Drawing.Size(212, 20)
        Me.txbNoTrans.TabIndex = 186
        '
        'LU_Gudang
        '
        Me.LU_Gudang.Location = New System.Drawing.Point(492, 37)
        Me.LU_Gudang.Name = "LU_Gudang"
        Me.LU_Gudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LU_Gudang.Properties.NullText = "[klik disini]"
        Me.LU_Gudang.Size = New System.Drawing.Size(118, 20)
        Me.LU_Gudang.TabIndex = 185
        Me.LU_Gudang.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(423, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Gudang :"
        Me.Label8.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(329, 7)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(35, 30)
        Me.cmdClear.TabIndex = 171
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'pnl_namabrg
        '
        Me.pnl_namabrg.BackColor = System.Drawing.Color.Black
        Me.pnl_namabrg.Controls.Add(Me.txtcari)
        Me.pnl_namabrg.Controls.Add(Me.Label6)
        Me.pnl_namabrg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_namabrg.Location = New System.Drawing.Point(0, 63)
        Me.pnl_namabrg.Name = "pnl_namabrg"
        Me.pnl_namabrg.Size = New System.Drawing.Size(792, 25)
        Me.pnl_namabrg.TabIndex = 183
        '
        'txtcari
        '
        Me.txtcari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtcari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtcari.BackColor = System.Drawing.Color.White
        Me.txtcari.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtcari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtcari.Location = New System.Drawing.Point(123, 0)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(669, 20)
        Me.txtcari.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cari Nama Barang :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(285, 7)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 30)
        Me.cmdRefresh.TabIndex = 170
        Me.cmdRefresh.Text = "c"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "Periode :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Persediaan :"
        '
        'LookupPersd
        '
        Me.LookupPersd.Location = New System.Drawing.Point(102, 36)
        Me.LookupPersd.Name = "LookupPersd"
        Me.LookupPersd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupPersd.Properties.NullText = "[klik disini]"
        Me.LookupPersd.Size = New System.Drawing.Size(118, 20)
        Me.LookupPersd.TabIndex = 168
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 43)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Maroon
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(792, 43)
        Me.Panel4.TabIndex = 143
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 41)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          Form Stok Opname Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmInvOpnmStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 430)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmInvOpnmStok"
        Me.Text = "frmInvMutasiStok"
        Me.pnl.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.GcOpnStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvOpnStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLookupJenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLookupPersd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLookupGudang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LU_Gudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_namabrg.ResumeLayout(False)
        Me.pnl_namabrg.PerformLayout()
        CType(Me.LookupPersd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GcOpnStok As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvOpnStok As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepLookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_data As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_opname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepLookupGudang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents txbLokasi As System.Windows.Forms.TextBox
    Friend WithEvents spek_brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepLookupJenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_jns_persd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepLookupPersd As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txbKdBrg As System.Windows.Forms.TextBox
    Friend WithEvents qty_selisih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents pnl_namabrg As System.Windows.Forms.Panel
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LookupPersd As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNmBrg As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents kd_gudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LU_Gudang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents persen_selisih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txbNoTrans As System.Windows.Forms.TextBox
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
End Class
