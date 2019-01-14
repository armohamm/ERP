<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormBarangGudang
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
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormBarangGudang))
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.pnlFill = New System.Windows.Forms.Panel
        Me.sccBarangGudang = New DevExpress.XtraEditors.SplitContainerControl
        Me.gcStokSaldo = New DevExpress.XtraGrid.GridControl
        Me.gvStokSaldo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookSatuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookUkuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.awal_booked = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAngka = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.qty_booked_in = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_booked_out = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_booked = New DevExpress.XtraGrid.Columns.GridColumn
        Me.awal_qty_onstok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_onstok_in = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_onstok_out = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_qty_onstok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_available = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_nilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_rata = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcStokGudang = New DevExpress.XtraGrid.GridControl
        Me.gvStokGudang = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_stokGudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookStok2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kode_gudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookGudang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.awal_qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAngka2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.qty_in = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_out = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.awal_nilai = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlFill.SuspendLayout()
        CType(Me.sccBarangGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sccBarangGudang.SuspendLayout()
        CType(Me.gcStokSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStokSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUkuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcStokGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStokGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookStok2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAngka2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlFill)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(966, 626)
        Me.pnl.TabIndex = 0
        '
        'pnlFill
        '
        Me.pnlFill.Controls.Add(Me.sccBarangGudang)
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFill.Location = New System.Drawing.Point(2, 37)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(962, 562)
        Me.pnlFill.TabIndex = 24
        '
        'sccBarangGudang
        '
        Me.sccBarangGudang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sccBarangGudang.Horizontal = False
        Me.sccBarangGudang.Location = New System.Drawing.Point(0, 0)
        Me.sccBarangGudang.Name = "sccBarangGudang"
        Me.sccBarangGudang.Panel1.Controls.Add(Me.gcStokSaldo)
        Me.sccBarangGudang.Panel1.Text = "pnlStokSaldo"
        Me.sccBarangGudang.Panel2.Controls.Add(Me.gcStokGudang)
        Me.sccBarangGudang.Panel2.Text = "pnlStokGudang"
        Me.sccBarangGudang.Size = New System.Drawing.Size(962, 562)
        Me.sccBarangGudang.SplitterPosition = 262
        Me.sccBarangGudang.TabIndex = 0
        Me.sccBarangGudang.Text = "SplitContainerControl1"
        '
        'gcStokSaldo
        '
        Me.gcStokSaldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcStokSaldo.Location = New System.Drawing.Point(0, 0)
        Me.gcStokSaldo.MainView = Me.gvStokSaldo
        Me.gcStokSaldo.Name = "gcStokSaldo"
        Me.gcStokSaldo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAngka, Me.lookStok, Me.lookUkuran, Me.lookSatuan})
        Me.gcStokSaldo.Size = New System.Drawing.Size(962, 262)
        Me.gcStokSaldo.TabIndex = 0
        Me.gcStokSaldo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStokSaldo})
        '
        'gvStokSaldo
        '
        Me.gvStokSaldo.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvStokSaldo.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvStokSaldo.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvStokSaldo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvStokSaldo.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvStokSaldo.Appearance.ViewCaption.Options.UseFont = True
        Me.gvStokSaldo.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gvStokSaldo.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvStokSaldo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_stok, Me.kd_satuan, Me.kd_ukuran, Me.awal_booked, Me.qty_booked_in, Me.qty_booked_out, Me.akhir_booked, Me.awal_qty_onstok, Me.qty_onstok_in, Me.qty_onstok_out, Me.akhir_qty_onstok, Me.qty_available, Me.awal_nilai, Me.akhir_nilai, Me.nilai_rata})
        Me.gvStokSaldo.GridControl = Me.gcStokSaldo
        Me.gvStokSaldo.Name = "gvStokSaldo"
        Me.gvStokSaldo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvStokSaldo.OptionsView.ColumnAutoWidth = False
        Me.gvStokSaldo.OptionsView.EnableAppearanceEvenRow = True
        Me.gvStokSaldo.OptionsView.EnableAppearanceOddRow = True
        Me.gvStokSaldo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvStokSaldo.OptionsView.ShowGroupPanel = False
        Me.gvStokSaldo.OptionsView.ShowViewCaption = True
        Me.gvStokSaldo.ViewCaption = "STOK SALDO"
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Nama Stok"
        Me.kd_stok.ColumnEdit = Me.lookStok
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 0
        '
        'lookStok
        '
        Me.lookStok.AutoHeight = False
        Me.lookStok.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject7, "", Nothing, Nothing, True)})
        Me.lookStok.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Name1")})
        Me.lookStok.Name = "lookStok"
        Me.lookStok.NullText = "[Kosong]"
        Me.lookStok.ShowFooter = False
        Me.lookStok.ShowHeader = False
        Me.lookStok.ShowPopupShadow = False
        Me.lookStok.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookStok.ValidateOnEnterKey = True
        '
        'kd_satuan
        '
        Me.kd_satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_satuan.AppearanceHeader.Options.UseFont = True
        Me.kd_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.ColumnEdit = Me.lookSatuan
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 1
        '
        'lookSatuan
        '
        Me.lookSatuan.AutoHeight = False
        Me.lookSatuan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookSatuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookSatuan.Name = "lookSatuan"
        Me.lookSatuan.NullText = "[Kosong]"
        Me.lookSatuan.ShowFooter = False
        Me.lookSatuan.ShowHeader = False
        Me.lookSatuan.ShowPopupShadow = False
        Me.lookSatuan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookSatuan.ValidateOnEnterKey = True
        '
        'kd_ukuran
        '
        Me.kd_ukuran.Caption = "Ukuran"
        Me.kd_ukuran.ColumnEdit = Me.lookUkuran
        Me.kd_ukuran.FieldName = "kd_ukuran"
        Me.kd_ukuran.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.kd_ukuran.Name = "kd_ukuran"
        Me.kd_ukuran.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.kd_ukuran.Visible = True
        Me.kd_ukuran.VisibleIndex = 2
        '
        'lookUkuran
        '
        Me.lookUkuran.AutoHeight = False
        Me.lookUkuran.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookUkuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject8, "", Nothing, Nothing, True)})
        Me.lookUkuran.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", "Name2")})
        Me.lookUkuran.Name = "lookUkuran"
        Me.lookUkuran.NullText = "[Kosong]"
        Me.lookUkuran.ShowFooter = False
        Me.lookUkuran.ShowHeader = False
        Me.lookUkuran.ShowPopupShadow = False
        Me.lookUkuran.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookUkuran.ValidateOnEnterKey = True
        '
        'awal_booked
        '
        Me.awal_booked.Caption = "Awal Booked"
        Me.awal_booked.ColumnEdit = Me.txtAngka
        Me.awal_booked.FieldName = "awal_booked"
        Me.awal_booked.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.awal_booked.Name = "awal_booked"
        Me.awal_booked.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.awal_booked.Visible = True
        Me.awal_booked.VisibleIndex = 3
        '
        'txtAngka
        '
        Me.txtAngka.AutoHeight = False
        Me.txtAngka.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, "", Nothing, Nothing, True)})
        Me.txtAngka.DisplayFormat.FormatString = "n0"
        Me.txtAngka.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAngka.EditFormat.FormatString = "n0"
        Me.txtAngka.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAngka.Name = "txtAngka"
        Me.txtAngka.ValidateOnEnterKey = True
        '
        'qty_booked_in
        '
        Me.qty_booked_in.Caption = "Booked In"
        Me.qty_booked_in.ColumnEdit = Me.txtAngka
        Me.qty_booked_in.FieldName = "qty_booked_in"
        Me.qty_booked_in.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.qty_booked_in.Name = "qty_booked_in"
        Me.qty_booked_in.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.qty_booked_in.Visible = True
        Me.qty_booked_in.VisibleIndex = 4
        '
        'qty_booked_out
        '
        Me.qty_booked_out.Caption = "Booked Out"
        Me.qty_booked_out.ColumnEdit = Me.txtAngka
        Me.qty_booked_out.FieldName = "qty_booked_out"
        Me.qty_booked_out.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.qty_booked_out.Name = "qty_booked_out"
        Me.qty_booked_out.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.qty_booked_out.Visible = True
        Me.qty_booked_out.VisibleIndex = 5
        '
        'akhir_booked
        '
        Me.akhir_booked.Caption = "Akhir Booked"
        Me.akhir_booked.ColumnEdit = Me.txtAngka
        Me.akhir_booked.FieldName = "akhir_booked"
        Me.akhir_booked.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.akhir_booked.Name = "akhir_booked"
        Me.akhir_booked.OptionsColumn.AllowFocus = False
        Me.akhir_booked.OptionsColumn.ReadOnly = True
        Me.akhir_booked.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.akhir_booked.Visible = True
        Me.akhir_booked.VisibleIndex = 6
        '
        'awal_qty_onstok
        '
        Me.awal_qty_onstok.Caption = "Awal Stok"
        Me.awal_qty_onstok.ColumnEdit = Me.txtAngka
        Me.awal_qty_onstok.FieldName = "awal_qty_onstok"
        Me.awal_qty_onstok.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.awal_qty_onstok.Name = "awal_qty_onstok"
        Me.awal_qty_onstok.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.awal_qty_onstok.Visible = True
        Me.awal_qty_onstok.VisibleIndex = 7
        '
        'qty_onstok_in
        '
        Me.qty_onstok_in.Caption = "Stok In"
        Me.qty_onstok_in.ColumnEdit = Me.txtAngka
        Me.qty_onstok_in.FieldName = "qty_onstok_in"
        Me.qty_onstok_in.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.qty_onstok_in.Name = "qty_onstok_in"
        Me.qty_onstok_in.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.qty_onstok_in.Visible = True
        Me.qty_onstok_in.VisibleIndex = 8
        '
        'qty_onstok_out
        '
        Me.qty_onstok_out.Caption = "Stok Out"
        Me.qty_onstok_out.ColumnEdit = Me.txtAngka
        Me.qty_onstok_out.FieldName = "qty_onstok_out"
        Me.qty_onstok_out.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.qty_onstok_out.Name = "qty_onstok_out"
        Me.qty_onstok_out.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.qty_onstok_out.Visible = True
        Me.qty_onstok_out.VisibleIndex = 9
        '
        'akhir_qty_onstok
        '
        Me.akhir_qty_onstok.Caption = "Akhir Stok"
        Me.akhir_qty_onstok.ColumnEdit = Me.txtAngka
        Me.akhir_qty_onstok.FieldName = "akhir_qty_onstok"
        Me.akhir_qty_onstok.Name = "akhir_qty_onstok"
        Me.akhir_qty_onstok.OptionsColumn.ReadOnly = True
        Me.akhir_qty_onstok.Visible = True
        Me.akhir_qty_onstok.VisibleIndex = 10
        '
        'qty_available
        '
        Me.qty_available.Caption = "Available"
        Me.qty_available.ColumnEdit = Me.txtAngka
        Me.qty_available.FieldName = "qty_available"
        Me.qty_available.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.qty_available.Name = "qty_available"
        Me.qty_available.OptionsColumn.ReadOnly = True
        Me.qty_available.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.qty_available.Visible = True
        Me.qty_available.VisibleIndex = 11
        '
        'akhir_nilai
        '
        Me.akhir_nilai.Caption = "Nilai Akhir"
        Me.akhir_nilai.FieldName = "akhir_nilai"
        Me.akhir_nilai.Name = "akhir_nilai"
        Me.akhir_nilai.Visible = True
        Me.akhir_nilai.VisibleIndex = 13
        '
        'nilai_rata
        '
        Me.nilai_rata.Caption = "Nilai Rata"
        Me.nilai_rata.FieldName = "nilai_rata"
        Me.nilai_rata.Name = "nilai_rata"
        Me.nilai_rata.Visible = True
        Me.nilai_rata.VisibleIndex = 14
        '
        'gcStokGudang
        '
        Me.gcStokGudang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcStokGudang.Location = New System.Drawing.Point(0, 0)
        Me.gcStokGudang.MainView = Me.gvStokGudang
        Me.gcStokGudang.Name = "gcStokGudang"
        Me.gcStokGudang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAngka2, Me.lookStok2, Me.lookGudang})
        Me.gcStokGudang.Size = New System.Drawing.Size(962, 294)
        Me.gcStokGudang.TabIndex = 1
        Me.gcStokGudang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStokGudang})
        '
        'gvStokGudang
        '
        Me.gvStokGudang.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvStokGudang.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvStokGudang.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvStokGudang.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvStokGudang.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvStokGudang.Appearance.ViewCaption.Options.UseFont = True
        Me.gvStokGudang.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gvStokGudang.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvStokGudang.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_stokGudang, Me.kode_gudang, Me.awal_qty, Me.qty_in, Me.qty_out, Me.akhir_qty})
        Me.gvStokGudang.GridControl = Me.gcStokGudang
        Me.gvStokGudang.Name = "gvStokGudang"
        Me.gvStokGudang.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvStokGudang.OptionsCustomization.AllowColumnResizing = False
        Me.gvStokGudang.OptionsView.EnableAppearanceEvenRow = True
        Me.gvStokGudang.OptionsView.EnableAppearanceOddRow = True
        Me.gvStokGudang.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvStokGudang.OptionsView.ShowGroupPanel = False
        Me.gvStokGudang.OptionsView.ShowViewCaption = True
        Me.gvStokGudang.ViewCaption = "STOK GUDANG"
        '
        'kd_stokGudang
        '
        Me.kd_stokGudang.Caption = "Nama Stok"
        Me.kd_stokGudang.ColumnEdit = Me.lookStok2
        Me.kd_stokGudang.FieldName = "kd_stok"
        Me.kd_stokGudang.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.kd_stokGudang.Name = "kd_stokGudang"
        Me.kd_stokGudang.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.kd_stokGudang.Visible = True
        Me.kd_stokGudang.VisibleIndex = 0
        '
        'lookStok2
        '
        Me.lookStok2.AutoHeight = False
        Me.lookStok2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookStok2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject10, "", Nothing, Nothing, True)})
        Me.lookStok2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Name1")})
        Me.lookStok2.Name = "lookStok2"
        Me.lookStok2.NullText = "[Kosong]"
        Me.lookStok2.ShowFooter = False
        Me.lookStok2.ShowHeader = False
        Me.lookStok2.ShowPopupShadow = False
        Me.lookStok2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookStok2.ValidateOnEnterKey = True
        '
        'kode_gudang
        '
        Me.kode_gudang.Caption = "Gudang"
        Me.kode_gudang.ColumnEdit = Me.lookGudang
        Me.kode_gudang.FieldName = "kode_gudang"
        Me.kode_gudang.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.kode_gudang.Name = "kode_gudang"
        Me.kode_gudang.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.kode_gudang.Visible = True
        Me.kode_gudang.VisibleIndex = 1
        '
        'lookGudang
        '
        Me.lookGudang.AutoHeight = False
        Me.lookGudang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookGudang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject11, "", Nothing, Nothing, True)})
        Me.lookGudang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Name3")})
        Me.lookGudang.Name = "lookGudang"
        Me.lookGudang.NullText = "[Kosong]"
        Me.lookGudang.ShowFooter = False
        Me.lookGudang.ShowHeader = False
        Me.lookGudang.ShowPopupShadow = False
        Me.lookGudang.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookGudang.ValidateOnEnterKey = True
        '
        'awal_qty
        '
        Me.awal_qty.Caption = "Qty Awal"
        Me.awal_qty.ColumnEdit = Me.txtAngka2
        Me.awal_qty.FieldName = "awal_qty"
        Me.awal_qty.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.awal_qty.Name = "awal_qty"
        Me.awal_qty.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.awal_qty.Visible = True
        Me.awal_qty.VisibleIndex = 2
        '
        'txtAngka2
        '
        Me.txtAngka2.AutoHeight = False
        Me.txtAngka2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject12, "", Nothing, Nothing, True)})
        Me.txtAngka2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAngka2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAngka2.Name = "txtAngka2"
        Me.txtAngka2.ValidateOnEnterKey = True
        '
        'qty_in
        '
        Me.qty_in.Caption = "Qty In"
        Me.qty_in.ColumnEdit = Me.txtAngka2
        Me.qty_in.FieldName = "qty_in"
        Me.qty_in.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.qty_in.Name = "qty_in"
        Me.qty_in.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.qty_in.Visible = True
        Me.qty_in.VisibleIndex = 3
        '
        'qty_out
        '
        Me.qty_out.Caption = "Qty Out"
        Me.qty_out.ColumnEdit = Me.txtAngka2
        Me.qty_out.FieldName = "qty_out"
        Me.qty_out.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.qty_out.Name = "qty_out"
        Me.qty_out.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.qty_out.Visible = True
        Me.qty_out.VisibleIndex = 4
        '
        'akhir_qty
        '
        Me.akhir_qty.Caption = "Qty Akhir"
        Me.akhir_qty.ColumnEdit = Me.txtAngka2
        Me.akhir_qty.FieldName = "akhir_qty"
        Me.akhir_qty.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.akhir_qty.Name = "akhir_qty"
        Me.akhir_qty.OptionsColumn.AllowFocus = False
        Me.akhir_qty.OptionsColumn.ReadOnly = True
        Me.akhir_qty.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.akhir_qty.Visible = True
        Me.akhir_qty.VisibleIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 35)
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(38, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MAINTENANCE BARANG DAN GUDANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 599)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(962, 25)
        Me.Panel2.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl1.Size = New System.Drawing.Size(962, 25)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "NB: Klik indikator 1x pada kotak pojok kiri tabel untuk memilih dan menekan tombo" & _
            "l Delete dibawah untuk menghapus Data yang sudah dipilih."
        '
        'awal_nilai
        '
        Me.awal_nilai.Caption = "Nilai Awal"
        Me.awal_nilai.ColumnEdit = Me.txtAngka
        Me.awal_nilai.FieldName = "awal_nilai"
        Me.awal_nilai.Name = "awal_nilai"
        Me.awal_nilai.Visible = True
        Me.awal_nilai.VisibleIndex = 12
        '
        'aFormBarangGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 626)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormBarangGudang"
        Me.Text = "aFormBarangGudang"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlFill.ResumeLayout(False)
        CType(Me.sccBarangGudang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sccBarangGudang.ResumeLayout(False)
        CType(Me.gcStokSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStokSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUkuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcStokGudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStokGudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookStok2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookGudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAngka2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlFill As System.Windows.Forms.Panel
    Friend WithEvents sccBarangGudang As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents gcStokSaldo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvStokSaldo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents awal_booked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_booked_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_booked_out As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_booked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents awal_qty_onstok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_onstok_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_onstok_out As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_qty_onstok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_available As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAngka As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents lookStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookUkuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gcStokGudang As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvStokGudang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_stokGudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookStok2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kode_gudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookGudang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents awal_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAngka2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents qty_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_out As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_nilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_rata As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookSatuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents awal_nilai As DevExpress.XtraGrid.Columns.GridColumn
End Class
