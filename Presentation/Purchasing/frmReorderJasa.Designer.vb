<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReorderJasa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReorderJasa))
        Me.Pnl = New System.Windows.Forms.Panel
        Me.txtTerm = New System.Windows.Forms.TextBox
        Me.dtBayar = New DevExpress.XtraEditors.DateEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.CEPPN = New DevExpress.XtraEditors.CheckEdit
        Me.txtJmlDiskon = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtJmlTotal = New DevExpress.XtraEditors.TextEdit
        Me.txtJmlPPN = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tglkirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Reptglkirim = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.DtTanggalgrid = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.txtstatus = New DevExpress.XtraEditors.TextEdit
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.dtKirim = New DevExpress.XtraEditors.DateEdit
        Me.txtkurs = New DevExpress.XtraEditors.TextEdit
        Me.LEValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.PnlSpaceAtas = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.LESupllier = New DevExpress.XtraEditors.LookUpEdit
        Me.LEPR = New DevExpress.XtraEditors.LookUpEdit
        Me.dtTanggal = New DevExpress.XtraEditors.DateEdit
        Me.txtNoPO = New DevExpress.XtraEditors.TextEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.Pnl.SuspendLayout()
        CType(Me.dtBayar.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlDiskon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reptglkirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reptglkirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        CType(Me.txtstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtkurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LESupllier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEPR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl
        '
        Me.Pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pnl.Controls.Add(Me.txtTerm)
        Me.Pnl.Controls.Add(Me.dtBayar)
        Me.Pnl.Controls.Add(Me.Label17)
        Me.Pnl.Controls.Add(Me.Label13)
        Me.Pnl.Controls.Add(Me.CEPPN)
        Me.Pnl.Controls.Add(Me.txtJmlDiskon)
        Me.Pnl.Controls.Add(Me.Label11)
        Me.Pnl.Controls.Add(Me.SimpleButton1)
        Me.Pnl.Controls.Add(Me.btSimpan)
        Me.Pnl.Controls.Add(Me.txtSubTotal)
        Me.Pnl.Controls.Add(Me.Label15)
        Me.Pnl.Controls.Add(Me.txtJmlTotal)
        Me.Pnl.Controls.Add(Me.txtJmlPPN)
        Me.Pnl.Controls.Add(Me.Label14)
        Me.Pnl.Controls.Add(Me.Label12)
        Me.Pnl.Controls.Add(Me.GC)
        Me.Pnl.Controls.Add(Me.pnlTengahAtas)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(6, 6)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(923, 538)
        Me.Pnl.TabIndex = 0
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(143, 440)
        Me.txtTerm.Multiline = True
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(247, 62)
        Me.txtTerm.TabIndex = 92
        '
        'dtBayar
        '
        Me.dtBayar.EditValue = New Date(2011, 4, 14, 14, 33, 22, 762)
        Me.dtBayar.Location = New System.Drawing.Point(143, 419)
        Me.dtBayar.Name = "dtBayar"
        Me.dtBayar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBayar.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtBayar.Size = New System.Drawing.Size(127, 20)
        Me.dtBayar.TabIndex = 91
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(-1, 439)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(142, 20)
        Me.Label17.TabIndex = 90
        Me.Label17.Text = "Term Bayar :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 418)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 20)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Tanggal Bayar :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CEPPN
        '
        Me.CEPPN.Location = New System.Drawing.Point(719, 463)
        Me.CEPPN.Name = "CEPPN"
        Me.CEPPN.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEPPN.Properties.Appearance.Options.UseForeColor = True
        Me.CEPPN.Properties.Caption = "NON PPN"
        Me.CEPPN.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CEPPN.Properties.DisplayValueChecked = "PPN"
        Me.CEPPN.Properties.DisplayValueUnchecked = "NON PPN"
        Me.CEPPN.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CEPPN.Properties.NullText = "NON PPN"
        Me.CEPPN.Properties.ValueChecked = "Y"
        Me.CEPPN.Properties.ValueUnchecked = "T"
        Me.CEPPN.Size = New System.Drawing.Size(62, 22)
        Me.CEPPN.TabIndex = 83
        '
        'txtJmlDiskon
        '
        Me.txtJmlDiskon.EditValue = "0,00"
        Me.txtJmlDiskon.Location = New System.Drawing.Point(719, 440)
        Me.txtJmlDiskon.Name = "txtJmlDiskon"
        Me.txtJmlDiskon.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtJmlDiskon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtJmlDiskon.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlDiskon.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlDiskon.Properties.Appearance.Options.UseFont = True
        Me.txtJmlDiskon.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlDiskon.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJmlDiskon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJmlDiskon.Properties.DisplayFormat.FormatString = "n2"
        Me.txtJmlDiskon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlDiskon.Properties.Mask.BeepOnError = True
        Me.txtJmlDiskon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtJmlDiskon.Size = New System.Drawing.Size(190, 21)
        Me.txtJmlDiskon.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(573, 418)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 20)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Jumlah Diskon :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(449, 584)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 80
        Me.SimpleButton1.Text = "Edit"
        Me.SimpleButton1.Visible = False
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(344, 584)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btSimpan.TabIndex = 79
        Me.btSimpan.Text = "Simpan"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.EditValue = "0,00"
        Me.txtSubTotal.Location = New System.Drawing.Point(719, 418)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSubTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSubTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubTotal.Properties.Appearance.Options.UseFont = True
        Me.txtSubTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtSubTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSubTotal.Properties.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(190, 21)
        Me.txtSubTotal.TabIndex = 78
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(572, 438)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 20)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Sub Total :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtJmlTotal
        '
        Me.txtJmlTotal.EditValue = "0,00"
        Me.txtJmlTotal.Location = New System.Drawing.Point(719, 484)
        Me.txtJmlTotal.Name = "txtJmlTotal"
        Me.txtJmlTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtJmlTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtJmlTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlTotal.Properties.Appearance.Options.UseFont = True
        Me.txtJmlTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJmlTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJmlTotal.Properties.ReadOnly = True
        Me.txtJmlTotal.Size = New System.Drawing.Size(190, 21)
        Me.txtJmlTotal.TabIndex = 76
        '
        'txtJmlPPN
        '
        Me.txtJmlPPN.EditValue = "0,00"
        Me.txtJmlPPN.Location = New System.Drawing.Point(787, 462)
        Me.txtJmlPPN.Name = "txtJmlPPN"
        Me.txtJmlPPN.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtJmlPPN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtJmlPPN.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlPPN.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlPPN.Properties.Appearance.Options.UseFont = True
        Me.txtJmlPPN.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlPPN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJmlPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJmlPPN.Properties.ReadOnly = True
        Me.txtJmlPPN.Size = New System.Drawing.Size(122, 21)
        Me.txtJmlPPN.TabIndex = 75
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(573, 482)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 20)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Jumlah Total :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(573, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Flag PPN :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GC
        '
        Me.GC.Location = New System.Drawing.Point(11, 162)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpStatus, Me.DtTanggalgrid, Me.repBrg, Me.Reptglkirim})
        Me.GC.Size = New System.Drawing.Size(909, 251)
        Me.GC.TabIndex = 11
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.Satuan, Me.harga, Me.qty, Me.total, Me.tglkirim, Me.Keterangan})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.EnableMasterViewMode = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'no_seq
        '
        Me.no_seq.AppearanceCell.Options.UseTextOptions = True
        Me.no_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_seq.AppearanceHeader.Options.UseFont = True
        Me.no_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.Caption = "No"
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.AllowFocus = False
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 37
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Nama Barang"
        Me.kd_stok.ColumnEdit = Me.repBrg
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 287
        '
        'repBrg
        '
        Me.repBrg.AutoHeight = False
        Me.repBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", "Satuan")})
        Me.repBrg.DisplayMember = "Nama_Barang"
        Me.repBrg.HideSelection = False
        Me.repBrg.Name = "repBrg"
        Me.repBrg.NullText = "[Pilih Barang]"
        Me.repBrg.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repBrg.ValueMember = "Kode_Barang"
        '
        'Satuan
        '
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "kd_satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.OptionsColumn.AllowEdit = False
        Me.Satuan.OptionsColumn.AllowFocus = False
        Me.Satuan.Visible = True
        Me.Satuan.VisibleIndex = 2
        Me.Satuan.Width = 108
        '
        'harga
        '
        Me.harga.Caption = "Harga"
        Me.harga.DisplayFormat.FormatString = "n2"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 3
        Me.harga.Width = 92
        '
        'qty
        '
        Me.qty.Caption = "QTY"
        Me.qty.FieldName = "qty"
        Me.qty.Name = "qty"
        Me.qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty.Visible = True
        Me.qty.VisibleIndex = 4
        Me.qty.Width = 70
        '
        'total
        '
        Me.total.Caption = "Total"
        Me.total.DisplayFormat.FormatString = "n2"
        Me.total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.total.FieldName = "total"
        Me.total.Name = "total"
        Me.total.OptionsColumn.AllowEdit = False
        Me.total.OptionsColumn.AllowFocus = False
        Me.total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.total.Visible = True
        Me.total.VisibleIndex = 5
        Me.total.Width = 102
        '
        'tglkirim
        '
        Me.tglkirim.Caption = "Tgl.Kirim"
        Me.tglkirim.ColumnEdit = Me.Reptglkirim
        Me.tglkirim.FieldName = "tgl_kirim"
        Me.tglkirim.Name = "tglkirim"
        Me.tglkirim.Visible = True
        Me.tglkirim.VisibleIndex = 6
        '
        'Reptglkirim
        '
        Me.Reptglkirim.AutoHeight = False
        Me.Reptglkirim.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Reptglkirim.Name = "Reptglkirim"
        Me.Reptglkirim.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 7
        Me.Keterangan.Width = 213
        '
        'rpStatus
        '
        Me.rpStatus.AutoHeight = False
        Me.rpStatus.AutoWidth = True
        Me.rpStatus.Caption = "TIDAK AKTIF"
        Me.rpStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.rpStatus.DisplayValueChecked = "AKTIF"
        Me.rpStatus.DisplayValueUnchecked = "TIDAK AKTIF"
        Me.rpStatus.FullFocusRect = True
        Me.rpStatus.Name = "rpStatus"
        Me.rpStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.rpStatus.NullText = "TIDAK AKTIF"
        Me.rpStatus.ValueChecked = "Y"
        Me.rpStatus.ValueUnchecked = "T"
        '
        'DtTanggalgrid
        '
        Me.DtTanggalgrid.AutoHeight = False
        Me.DtTanggalgrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTanggalgrid.Name = "DtTanggalgrid"
        Me.DtTanggalgrid.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.txtstatus)
        Me.pnlTengahAtas.Controls.Add(Me.txtKeterangan)
        Me.pnlTengahAtas.Controls.Add(Me.dtKirim)
        Me.pnlTengahAtas.Controls.Add(Me.txtkurs)
        Me.pnlTengahAtas.Controls.Add(Me.LEValuta)
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.PnlSpaceAtas)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Controls.Add(Me.Panel4)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 34)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(923, 119)
        Me.pnlTengahAtas.TabIndex = 10
        '
        'txtstatus
        '
        Me.txtstatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtstatus.Location = New System.Drawing.Point(713, 100)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtstatus.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtstatus.Properties.Appearance.Options.UseBackColor = True
        Me.txtstatus.Properties.Appearance.Options.UseForeColor = True
        Me.txtstatus.Properties.ReadOnly = True
        Me.txtstatus.Size = New System.Drawing.Size(210, 20)
        Me.txtstatus.TabIndex = 14
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKeterangan.Location = New System.Drawing.Point(713, 60)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(210, 40)
        Me.txtKeterangan.TabIndex = 13
        '
        'dtKirim
        '
        Me.dtKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtKirim.EditValue = New Date(2011, 4, 14, 14, 49, 19, 0)
        Me.dtKirim.Location = New System.Drawing.Point(713, 40)
        Me.dtKirim.Name = "dtKirim"
        Me.dtKirim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtKirim.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtKirim.Size = New System.Drawing.Size(210, 20)
        Me.dtKirim.TabIndex = 9
        '
        'txtkurs
        '
        Me.txtkurs.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtkurs.Location = New System.Drawing.Point(713, 20)
        Me.txtkurs.Name = "txtkurs"
        Me.txtkurs.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtkurs.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtkurs.Properties.Appearance.Options.UseBackColor = True
        Me.txtkurs.Properties.Appearance.Options.UseForeColor = True
        Me.txtkurs.Size = New System.Drawing.Size(210, 20)
        Me.txtkurs.TabIndex = 8
        '
        'LEValuta
        '
        Me.LEValuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.LEValuta.Location = New System.Drawing.Point(713, 0)
        Me.LEValuta.Name = "LEValuta"
        Me.LEValuta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LEValuta.Properties.Appearance.Options.UseBackColor = True
        Me.LEValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Valuta")})
        Me.LEValuta.Properties.DisplayMember = "Nama_Valuta"
        Me.LEValuta.Properties.NullText = "[Valuta]"
        Me.LEValuta.Properties.ValueMember = "Kode_Valuta"
        Me.LEValuta.Size = New System.Drawing.Size(210, 20)
        Me.LEValuta.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(574, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(139, 119)
        Me.Panel3.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 20)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Status :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 40)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Keterangan :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Tanggal Janji Kirim :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Kurs :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Valuta :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlSpaceAtas
        '
        Me.PnlSpaceAtas.BackColor = System.Drawing.Color.Transparent
        Me.PnlSpaceAtas.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlSpaceAtas.Location = New System.Drawing.Point(369, 0)
        Me.PnlSpaceAtas.Name = "PnlSpaceAtas"
        Me.PnlSpaceAtas.Size = New System.Drawing.Size(205, 119)
        Me.PnlSpaceAtas.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TextEdit1)
        Me.Panel5.Controls.Add(Me.LESupllier)
        Me.Panel5.Controls.Add(Me.LEPR)
        Me.Panel5.Controls.Add(Me.dtTanggal)
        Me.Panel5.Controls.Add(Me.txtNoPO)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(142, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(227, 119)
        Me.Panel5.TabIndex = 3
        '
        'TextEdit1
        '
        Me.TextEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextEdit1.Location = New System.Drawing.Point(0, 80)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(227, 20)
        Me.TextEdit1.TabIndex = 10
        '
        'LESupllier
        '
        Me.LESupllier.Dock = System.Windows.Forms.DockStyle.Top
        Me.LESupllier.Location = New System.Drawing.Point(0, 60)
        Me.LESupllier.Name = "LESupllier"
        Me.LESupllier.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LESupllier.Properties.Appearance.Options.UseBackColor = True
        Me.LESupllier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LESupllier.Properties.DisplayMember = "Nama_Supplier"
        Me.LESupllier.Properties.NullText = "[Pilih Supplier]"
        Me.LESupllier.Properties.ReadOnly = True
        Me.LESupllier.Properties.ValueMember = "Kode_Supplier"
        Me.LESupllier.Size = New System.Drawing.Size(227, 20)
        Me.LESupllier.TabIndex = 9
        '
        'LEPR
        '
        Me.LEPR.Dock = System.Windows.Forms.DockStyle.Top
        Me.LEPR.Location = New System.Drawing.Point(0, 40)
        Me.LEPR.Name = "LEPR"
        Me.LEPR.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LEPR.Properties.Appearance.Options.UseBackColor = True
        Me.LEPR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEPR.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_po", "NO PO", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[True])})
        Me.LEPR.Properties.DisplayMember = "no_po"
        Me.LEPR.Properties.NullText = "[Pilih NO PO]"
        Me.LEPR.Properties.ValueMember = "no_po"
        Me.LEPR.Size = New System.Drawing.Size(227, 20)
        Me.LEPR.TabIndex = 0
        '
        'dtTanggal
        '
        Me.dtTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtTanggal.EditValue = New Date(2011, 4, 14, 14, 33, 22, 762)
        Me.dtTanggal.Location = New System.Drawing.Point(0, 20)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtTanggal.Size = New System.Drawing.Size(227, 20)
        Me.dtTanggal.TabIndex = 5
        '
        'txtNoPO
        '
        Me.txtNoPO.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNoPO.Location = New System.Drawing.Point(0, 0)
        Me.txtNoPO.Name = "txtNoPO"
        Me.txtNoPO.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoPO.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoPO.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoPO.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoPO.Properties.ReadOnly = True
        Me.txtNoPO.Size = New System.Drawing.Size(227, 20)
        Me.txtNoPO.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 119)
        Me.Panel4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Supplier :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No PR :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tanggal :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "No PO :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(923, 34)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " FORM  REORDER JASA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'frmReorderJasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 613)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmReorderJasa"
        Me.Text = "FORM REORDER JASA"
        Me.Pnl.ResumeLayout(False)
        Me.Pnl.PerformLayout()
        CType(Me.dtBayar.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlDiskon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reptglkirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reptglkirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.pnlTengahAtas.PerformLayout()
        CType(Me.txtstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtkurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LESupllier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEPR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents LEValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PnlSpaceAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNoPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DtTanggalgrid As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtkurs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtKirim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtJmlPPN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtJmlTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LEPR As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LESupllier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtstatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtJmlDiskon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CEPPN As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents repBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents dtBayar As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tglkirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Reptglkirim As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
