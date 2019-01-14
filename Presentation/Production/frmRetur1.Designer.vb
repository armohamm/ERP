<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetur1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetur1))
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Jns_retur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repJNSRTR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Jns_alasan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repALSNRTR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Sts_ganti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repGanti = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repKeterangan = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.tglRetur = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtRef2 = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRef1 = New DevExpress.XtraEditors.TextEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.txtKodeSales = New DevExpress.XtraEditors.TextEdit
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlbawah = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repJNSRTR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repALSNRTR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repGanti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKeterangan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.tglRetur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.txtRef2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRef1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.txtKodeSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbawah.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Controls.Add(Me.pnlbawah)
        Me.pnl.Location = New System.Drawing.Point(47, 10)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(928, 404)
        Me.pnl.TabIndex = 0
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.GC)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 35)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(926, 290)
        Me.pnlTengah.TabIndex = 1
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 42)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repBarang, Me.repJNSRTR, Me.repALSNRTR, Me.repGanti, Me.repKeterangan})
        Me.GC.Size = New System.Drawing.Size(926, 248)
        Me.GC.TabIndex = 1
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.Kd_Stok, Me.Qty, Me.Kd_satuan, Me.Jns_retur, Me.Jns_alasan, Me.Sts_ganti, Me.Keterangan})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = "DAFTAR BARANG RETUR"
        Me.GV.Name = "GV"
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.ViewCaption = "DAFTAR BARANG RETUR"
        '
        'No_seq
        '
        Me.No_seq.Caption = "No"
        Me.No_seq.FieldName = "No_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 33
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Barang"
        Me.Kd_Stok.ColumnEdit = Me.repBarang
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 1
        Me.Kd_Stok.Width = 320
        '
        'repBarang
        '
        Me.repBarang.AutoHeight = False
        Me.repBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 300, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", 75, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_satuan", 75, "Satuan")})
        Me.repBarang.DisplayMember = "Nama_Barang"
        Me.repBarang.Name = "repBarang"
        Me.repBarang.NullText = "[Pilih Barang]"
        Me.repBarang.PopupWidth = 500
        Me.repBarang.ValueMember = "Kode_Barang"
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 2
        Me.Qty.Width = 53
        '
        'Kd_satuan
        '
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "Kd_satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.OptionsColumn.AllowEdit = False
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 3
        Me.Kd_satuan.Width = 64
        '
        'Jns_retur
        '
        Me.Jns_retur.Caption = "Jenis Retur"
        Me.Jns_retur.ColumnEdit = Me.repJNSRTR
        Me.Jns_retur.FieldName = "Jns_retur"
        Me.Jns_retur.Name = "Jns_retur"
        Me.Jns_retur.Visible = True
        Me.Jns_retur.VisibleIndex = 4
        Me.Jns_retur.Width = 94
        '
        'repJNSRTR
        '
        Me.repJNSRTR.AutoHeight = False
        Me.repJNSRTR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repJNSRTR.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Name28", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Jenis Retur")})
        Me.repJNSRTR.DisplayMember = "Desc_Data"
        Me.repJNSRTR.Name = "repJNSRTR"
        Me.repJNSRTR.ShowFooter = False
        Me.repJNSRTR.ShowHeader = False
        Me.repJNSRTR.ValueMember = "Id_Data"
        '
        'Jns_alasan
        '
        Me.Jns_alasan.Caption = "Alasan"
        Me.Jns_alasan.ColumnEdit = Me.repALSNRTR
        Me.Jns_alasan.FieldName = "Jns_alasan"
        Me.Jns_alasan.Name = "Jns_alasan"
        Me.Jns_alasan.Visible = True
        Me.Jns_alasan.VisibleIndex = 5
        Me.Jns_alasan.Width = 77
        '
        'repALSNRTR
        '
        Me.repALSNRTR.AutoHeight = False
        Me.repALSNRTR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repALSNRTR.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Name32", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", 300, "Name33")})
        Me.repALSNRTR.DisplayMember = "Desc_Data"
        Me.repALSNRTR.Name = "repALSNRTR"
        Me.repALSNRTR.PopupWidth = 300
        Me.repALSNRTR.ShowFooter = False
        Me.repALSNRTR.ShowHeader = False
        Me.repALSNRTR.ValueMember = "Id_Data"
        '
        'Sts_ganti
        '
        Me.Sts_ganti.Caption = "Ganti"
        Me.Sts_ganti.ColumnEdit = Me.repGanti
        Me.Sts_ganti.FieldName = "Sts_ganti"
        Me.Sts_ganti.Name = "Sts_ganti"
        Me.Sts_ganti.Visible = True
        Me.Sts_ganti.VisibleIndex = 6
        Me.Sts_ganti.Width = 72
        '
        'repGanti
        '
        Me.repGanti.AutoHeight = False
        Me.repGanti.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repGanti.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.repGanti.Name = "repGanti"
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.ColumnEdit = Me.repKeterangan
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 7
        Me.Keterangan.Width = 192
        '
        'repKeterangan
        '
        Me.repKeterangan.AutoHeight = False
        Me.repKeterangan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKeterangan.Name = "repKeterangan"
        Me.repKeterangan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 42)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tglRetur)
        Me.Panel3.Controls.Add(Me.txtNomor)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(751, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(175, 42)
        Me.Panel3.TabIndex = 7
        '
        'tglRetur
        '
        Me.tglRetur.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglRetur.Location = New System.Drawing.Point(0, 20)
        Me.tglRetur.Name = "tglRetur"
        Me.tglRetur.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglRetur.Properties.Appearance.Options.UseBackColor = True
        Me.tglRetur.Properties.Appearance.Options.UseTextOptions = True
        Me.tglRetur.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tglRetur.Size = New System.Drawing.Size(175, 20)
        Me.tglRetur.TabIndex = 1
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNomor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNomor.Size = New System.Drawing.Size(175, 20)
        Me.txtNomor.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(607, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(144, 42)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtRef2)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.txtRef1)
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(149, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(458, 42)
        Me.Panel7.TabIndex = 5
        '
        'txtRef2
        '
        Me.txtRef2.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtRef2.Location = New System.Drawing.Point(301, 21)
        Me.txtRef2.Name = "txtRef2"
        Me.txtRef2.Size = New System.Drawing.Size(157, 20)
        Me.txtRef2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(156, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No Referensi 2 :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRef1
        '
        Me.txtRef1.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtRef1.Location = New System.Drawing.Point(0, 21)
        Me.txtRef1.Name = "txtRef1"
        Me.txtRef1.Size = New System.Drawing.Size(156, 20)
        Me.txtRef1.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.txtKodeSales)
        Me.Panel11.Controls.Add(Me.txtCustomer)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(458, 21)
        Me.Panel11.TabIndex = 0
        '
        'txtKodeSales
        '
        Me.txtKodeSales.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKodeSales.Location = New System.Drawing.Point(301, 0)
        Me.txtKodeSales.Name = "txtKodeSales"
        Me.txtKodeSales.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtKodeSales.Properties.Appearance.Options.UseBackColor = True
        Me.txtKodeSales.Size = New System.Drawing.Size(203, 20)
        Me.txtKodeSales.TabIndex = 3
        '
        'txtCustomer
        '
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCustomer.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", 75, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 400, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Alamat1", 300, "Alamat")})
        Me.txtCustomer.Properties.NullText = "[Pilih Pelanggan]"
        Me.txtCustomer.Properties.PopupWidth = 700
        Me.txtCustomer.Size = New System.Drawing.Size(301, 20)
        Me.txtCustomer.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(149, 42)
        Me.Panel6.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No Referensi : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Pelanggan : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Maroon
        Me.pnlAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtas.Controls.Add(Me.LabelControl1)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(926, 35)
        Me.pnlAtas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(152, 33)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "   RETUR PENJUALAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 33)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlbawah
        '
        Me.pnlbawah.BackColor = System.Drawing.Color.Maroon
        Me.pnlbawah.Controls.Add(Me.Panel10)
        Me.pnlbawah.Controls.Add(Me.Panel9)
        Me.pnlbawah.Controls.Add(Me.Panel8)
        Me.pnlbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbawah.Location = New System.Drawing.Point(0, 325)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(926, 77)
        Me.pnlbawah.TabIndex = 2
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.MemoEdit2)
        Me.Panel10.Controls.Add(Me.Label9)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(486, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(477, 77)
        Me.Panel10.TabIndex = 8
        '
        'MemoEdit2
        '
        Me.MemoEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit2.Location = New System.Drawing.Point(0, 20)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Size = New System.Drawing.Size(475, 55)
        Me.MemoEdit2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(475, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Keterangan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.MemoEdit1)
        Me.Panel9.Controls.Add(Me.TextEdit5)
        Me.Panel9.Controls.Add(Me.DateEdit1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(149, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(337, 77)
        Me.Panel9.TabIndex = 7
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 40)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(337, 37)
        Me.MemoEdit1.TabIndex = 2
        '
        'TextEdit5
        '
        Me.TextEdit5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextEdit5.Location = New System.Drawing.Point(0, 20)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(337, 20)
        Me.TextEdit5.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(0, 0)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(337, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(149, 77)
        Me.Panel8.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 35)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Alamat Agen : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nama Agen : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tanggal Tarik : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmRetur1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 455)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRetur1"
        Me.Text = "frmRetur"
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repJNSRTR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repALSNRTR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repGanti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKeterangan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.tglRetur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.txtRef2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRef1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        CType(Me.txtKodeSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbawah.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jns_retur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jns_alasan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sts_ganti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tglRetur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRef2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRef1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents txtKodeSales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents repBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repJNSRTR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repALSNRTR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repGanti As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents repKeterangan As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
End Class
