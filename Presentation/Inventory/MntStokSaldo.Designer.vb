<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntStokSaldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntStokSaldo))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.txtcari = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txbKdBrg = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GcMonBM = New DevExpress.XtraGrid.GridControl
        Me.GvMonGdi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_in = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_out = New DevExpress.XtraGrid.Columns.GridColumn
        Me.balance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.awal_qty_onstok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupGudang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RL_GdgAsal = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RL_GdgTujuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lokasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel6.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GcMonBM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMonGdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Tanggal :"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.tglsampai)
        Me.Panel6.Controls.Add(Me.tglDari)
        Me.Panel6.Controls.Add(Me.lookupBulanAwal)
        Me.Panel6.Controls.Add(Me.txtcari)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.txbKdBrg)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(189, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(670, 52)
        Me.Panel6.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "s/d"
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(232, 28)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.tglsampai.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(117, 20)
        Me.tglsampai.TabIndex = 57
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(71, 28)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.tglDari.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(123, 20)
        Me.tglDari.TabIndex = 56
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(469, 29)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(187, 20)
        Me.lookupBulanAwal.TabIndex = 55
        '
        'txtcari
        '
        Me.txtcari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtcari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtcari.BackColor = System.Drawing.Color.White
        Me.txtcari.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcari.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(71, 3)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(437, 20)
        Me.txtcari.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(394, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "bulan tahun:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 5)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Nama Brg:"
        '
        'txbKdBrg
        '
        Me.txbKdBrg.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbKdBrg.Location = New System.Drawing.Point(551, 3)
        Me.txbKdBrg.Name = "txbKdBrg"
        Me.txbKdBrg.Size = New System.Drawing.Size(105, 20)
        Me.txbKdBrg.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(511, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Kode:"
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "error.ico")
        Me.img.Images.SetKeyName(1, "insert.ico")
        Me.img.Images.SetKeyName(2, "edit2.ico")
        Me.img.Images.SetKeyName(3, "ok.ico")
        Me.img.Images.SetKeyName(4, "save.ico")
        Me.img.Images.SetKeyName(5, "reload.ico")
        Me.img.Images.SetKeyName(6, "gohome.ico")
        Me.img.Images.SetKeyName(7, "remove.ico")
        Me.img.Images.SetKeyName(8, "clean.ico")
        Me.img.Images.SetKeyName(9, "forward.ico")
        Me.img.Images.SetKeyName(10, "printer.ico")
        Me.img.Images.SetKeyName(11, "chart.ico")
        Me.img.Images.SetKeyName(12, "sale.ico")
        Me.img.Images.SetKeyName(13, "users.ico")
        Me.img.Images.SetKeyName(14, "cut.ico")
        Me.img.Images.SetKeyName(15, "log_out.png")
        '
        'btnprin
        '
        Me.btnprin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnprin.ImageIndex = 10
        Me.btnprin.ImageList = Me.img
        Me.btnprin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnprin.Location = New System.Drawing.Point(865, 0)
        Me.btnprin.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnprin.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(53, 52)
        Me.btnprin.TabIndex = 41
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1016, 362)
        Me.pnl.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.GcMonBM)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 310)
        Me.Panel2.TabIndex = 3
        '
        'GcMonBM
        '
        Me.GcMonBM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMonBM.Location = New System.Drawing.Point(0, 0)
        Me.GcMonBM.LookAndFeel.SkinName = "The Asphalt World"
        Me.GcMonBM.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GcMonBM.MainView = Me.GvMonGdi
        Me.GcMonBM.Name = "GcMonBM"
        Me.GcMonBM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.LookupGudang, Me.RL_GdgAsal, Me.RL_GdgTujuan})
        Me.GcMonBM.Size = New System.Drawing.Size(1016, 310)
        Me.GcMonBM.TabIndex = 7
        Me.GcMonBM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMonGdi})
        '
        'GvMonGdi
        '
        Me.GvMonGdi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.kd_stok, Me.kd_satuan, Me.awal_qty_onstok, Me.no_trans, Me.tgl_trans, Me.keterangan, Me.qty_in, Me.qty_out, Me.balance, Me.lokasi})
        Me.GvMonGdi.GridControl = Me.GcMonBM
        Me.GvMonGdi.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.GvMonGdi.Name = "GvMonGdi"
        Me.GvMonGdi.OptionsBehavior.ReadOnly = True
        Me.GvMonGdi.OptionsPrint.UsePrintStyles = True
        Me.GvMonGdi.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMonGdi.OptionsView.EnableAppearanceOddRow = True
        Me.GvMonGdi.OptionsView.ShowFooter = True
        Me.GvMonGdi.ViewCaption = "MONITORING BARANG MASUK"
        '
        'nomer
        '
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 48
        '
        'no_trans
        '
        Me.no_trans.Caption = "Kode Bukti"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 4
        Me.no_trans.Width = 101
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 5
        Me.tgl_trans.Width = 82
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 6
        Me.keterangan.Width = 175
        '
        'qty_in
        '
        Me.qty_in.Caption = "Jumlah"
        Me.qty_in.DisplayFormat.FormatString = "n3"
        Me.qty_in.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_in.FieldName = "qty_in"
        Me.qty_in.Name = "qty_in"
        Me.qty_in.OptionsColumn.AllowEdit = False
        Me.qty_in.OptionsColumn.ReadOnly = True
        Me.qty_in.SummaryItem.DisplayFormat = "{0:n3}"
        Me.qty_in.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_in.Visible = True
        Me.qty_in.VisibleIndex = 7
        Me.qty_in.Width = 72
        '
        'qty_out
        '
        Me.qty_out.Caption = "qty_out"
        Me.qty_out.FieldName = "qty_out"
        Me.qty_out.Name = "qty_out"
        Me.qty_out.Visible = True
        Me.qty_out.VisibleIndex = 8
        Me.qty_out.Width = 82
        '
        'balance
        '
        Me.balance.Caption = "Balance"
        Me.balance.FieldName = "balance"
        Me.balance.Name = "balance"
        Me.balance.Visible = True
        Me.balance.VisibleIndex = 9
        Me.balance.Width = 93
        '
        'awal_qty_onstok
        '
        Me.awal_qty_onstok.Caption = "Saldo Awal"
        Me.awal_qty_onstok.FieldName = "awal_qty_onstok"
        Me.awal_qty_onstok.Name = "awal_qty_onstok"
        Me.awal_qty_onstok.Visible = True
        Me.awal_qty_onstok.VisibleIndex = 3
        Me.awal_qty_onstok.Width = 71
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = ""
        '
        'LookupGudang
        '
        Me.LookupGudang.AutoHeight = False
        Me.LookupGudang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupGudang.Name = "LookupGudang"
        '
        'RL_GdgAsal
        '
        Me.RL_GdgAsal.AutoHeight = False
        Me.RL_GdgAsal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_GdgAsal.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Gudang")})
        Me.RL_GdgAsal.Name = "RL_GdgAsal"
        Me.RL_GdgAsal.NullText = ""
        '
        'RL_GdgTujuan
        '
        Me.RL_GdgTujuan.AutoHeight = False
        Me.RL_GdgTujuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_GdgTujuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Gudang")})
        Me.RL_GdgTujuan.Name = "RL_GdgTujuan"
        Me.RL_GdgTujuan.NullText = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnprin)
        Me.Panel1.Controls.Add(Me.cmdClear)
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 52)
        Me.Panel1.TabIndex = 2
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(918, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 52)
        Me.cmdClear.TabIndex = 40
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(967, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 52)
        Me.cmdRefresh.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 52)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Monotoring KARTU STOK"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Nama Barang"
        Me.kd_stok.ColumnEdit = Me.LookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 213
        '
        'kd_satuan
        '
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 2
        Me.kd_satuan.Width = 58
        '
        'lokasi
        '
        Me.lokasi.Caption = "Gudang"
        Me.lokasi.ColumnEdit = Me.LookupGudang
        Me.lokasi.FieldName = "lokasi"
        Me.lokasi.Name = "lokasi"
        Me.lokasi.Visible = True
        Me.lokasi.VisibleIndex = 10
        '
        'MntStokSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 362)
        Me.Controls.Add(Me.pnl)
        Me.Name = "MntStokSaldo"
        Me.Text = "MntStokSaldo"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GcMonBM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMonGdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupGudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txbKdBrg As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GcMonBM As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMonGdi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_out As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_GdgAsal As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_GdgTujuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents balance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupGudang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents awal_qty_onstok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lokasi As DevExpress.XtraGrid.Columns.GridColumn
End Class
