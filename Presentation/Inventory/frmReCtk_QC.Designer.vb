<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReCtk_QC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReCtk_QC))
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.GcMonQC = New DevExpress.XtraGrid.GridControl
        Me.GvMonQC = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_pass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_unpass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cetak_ke = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cetak_ulang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CE_ctk_ulang = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Last_Created_By = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.btn_deselect = New DevExpress.XtraEditors.SimpleButton
        Me.Btn_pilih = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GcMonQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMonQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(498, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 37
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'GcMonQC
        '
        Me.GcMonQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMonQC.Location = New System.Drawing.Point(0, 79)
        Me.GcMonQC.LookAndFeel.SkinName = "The Asphalt World"
        Me.GcMonQC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GcMonQC.MainView = Me.GvMonQC
        Me.GcMonQC.Name = "GcMonQC"
        Me.GcMonQC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.CE_ctk_ulang})
        Me.GcMonQC.Size = New System.Drawing.Size(1016, 311)
        Me.GcMonQC.TabIndex = 7
        Me.GcMonQC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMonQC})
        '
        'GvMonQC
        '
        Me.GvMonQC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.tgl_trans, Me.no_trans, Me.no_ref, Me.kd_stok, Me.kd_satuan, Me.qty_order, Me.qty_qc_pass, Me.qty_hold, Me.qty_qc_unpass, Me.cetak_ke, Me.cetak_ulang, Me.Last_Created_By})
        Me.GvMonQC.GridControl = Me.GcMonQC
        Me.GvMonQC.Name = "GvMonQC"
        Me.GvMonQC.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMonQC.OptionsView.EnableAppearanceOddRow = True
        Me.GvMonQC.OptionsView.ShowFooter = True
        Me.GvMonQC.OptionsView.ShowViewCaption = True
        Me.GvMonQC.ViewCaption = "CETAK ULANG INSPEKSI BARANG MASUK"
        '
        'nomer
        '
        Me.nomer.AppearanceHeader.Options.UseTextOptions = True
        Me.nomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.AllowEdit = False
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 33
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans.Caption = "Tgl Trans"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 59
        '
        'no_trans
        '
        Me.no_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.no_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_trans.Caption = "Nomor QC"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.AllowEdit = False
        Me.no_trans.OptionsColumn.ReadOnly = True
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 2
        Me.no_trans.Width = 70
        '
        'no_ref
        '
        Me.no_ref.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref.Caption = "Referensi"
        Me.no_ref.FieldName = "no_ref"
        Me.no_ref.Name = "no_ref"
        Me.no_ref.OptionsColumn.AllowEdit = False
        Me.no_ref.OptionsColumn.ReadOnly = True
        Me.no_ref.Visible = True
        Me.no_ref.VisibleIndex = 4
        Me.no_ref.Width = 79
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.LookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 5
        Me.kd_stok.Width = 241
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = ""
        '
        'kd_satuan
        '
        Me.kd_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.ReadOnly = True
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 6
        Me.kd_satuan.Width = 51
        '
        'qty_order
        '
        Me.qty_order.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_order.Caption = "Order"
        Me.qty_order.DisplayFormat.FormatString = "N2"
        Me.qty_order.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.OptionsColumn.ReadOnly = True
        Me.qty_order.SummaryItem.DisplayFormat = "{0:n2}"
        Me.qty_order.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 7
        Me.qty_order.Width = 74
        '
        'qty_qc_pass
        '
        Me.qty_qc_pass.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_qc_pass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_qc_pass.Caption = "Qty Good"
        Me.qty_qc_pass.DisplayFormat.FormatString = "N2"
        Me.qty_qc_pass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_qc_pass.FieldName = "qty_qc_pass"
        Me.qty_qc_pass.Name = "qty_qc_pass"
        Me.qty_qc_pass.OptionsColumn.AllowEdit = False
        Me.qty_qc_pass.OptionsColumn.ReadOnly = True
        Me.qty_qc_pass.SummaryItem.DisplayFormat = "{0:n2}"
        Me.qty_qc_pass.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_qc_pass.Visible = True
        Me.qty_qc_pass.VisibleIndex = 8
        Me.qty_qc_pass.Width = 89
        '
        'qty_hold
        '
        Me.qty_hold.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_hold.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_hold.Caption = "Qty Hold"
        Me.qty_hold.DisplayFormat.FormatString = "N2"
        Me.qty_hold.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_hold.FieldName = "hold"
        Me.qty_hold.Name = "qty_hold"
        Me.qty_hold.OptionsColumn.AllowEdit = False
        Me.qty_hold.OptionsColumn.ReadOnly = True
        Me.qty_hold.SummaryItem.DisplayFormat = "{0:n2}"
        Me.qty_hold.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_hold.Visible = True
        Me.qty_hold.VisibleIndex = 9
        Me.qty_hold.Width = 74
        '
        'qty_qc_unpass
        '
        Me.qty_qc_unpass.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_qc_unpass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_qc_unpass.Caption = "Qty Tolak"
        Me.qty_qc_unpass.DisplayFormat.FormatString = "N2"
        Me.qty_qc_unpass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_qc_unpass.FieldName = "qty_qc_unpass"
        Me.qty_qc_unpass.Name = "qty_qc_unpass"
        Me.qty_qc_unpass.OptionsColumn.AllowEdit = False
        Me.qty_qc_unpass.OptionsColumn.ReadOnly = True
        Me.qty_qc_unpass.SummaryItem.DisplayFormat = "{0:n2}"
        Me.qty_qc_unpass.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_qc_unpass.Visible = True
        Me.qty_qc_unpass.VisibleIndex = 10
        Me.qty_qc_unpass.Width = 73
        '
        'cetak_ke
        '
        Me.cetak_ke.Caption = "Jml Cetak"
        Me.cetak_ke.FieldName = "cetak_ke"
        Me.cetak_ke.Name = "cetak_ke"
        Me.cetak_ke.OptionsColumn.AllowEdit = False
        Me.cetak_ke.OptionsColumn.ReadOnly = True
        Me.cetak_ke.Visible = True
        Me.cetak_ke.VisibleIndex = 11
        '
        'cetak_ulang
        '
        Me.cetak_ulang.Caption = "Cetak Ulang"
        Me.cetak_ulang.ColumnEdit = Me.CE_ctk_ulang
        Me.cetak_ulang.FieldName = "cetak_ulang"
        Me.cetak_ulang.Name = "cetak_ulang"
        Me.cetak_ulang.Visible = True
        Me.cetak_ulang.VisibleIndex = 12
        '
        'CE_ctk_ulang
        '
        Me.CE_ctk_ulang.AutoHeight = False
        Me.CE_ctk_ulang.LookAndFeel.SkinName = "The Asphalt World"
        Me.CE_ctk_ulang.Name = "CE_ctk_ulang"
        Me.CE_ctk_ulang.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CE_ctk_ulang.ValueChecked = "Y"
        Me.CE_ctk_ulang.ValueGrayed = "T"
        Me.CE_ctk_ulang.ValueUnchecked = "T"
        '
        'Last_Created_By
        '
        Me.Last_Created_By.AppearanceHeader.Options.UseTextOptions = True
        Me.Last_Created_By.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Last_Created_By.Caption = "Petugas QC"
        Me.Last_Created_By.FieldName = "Last_Created_By"
        Me.Last_Created_By.Name = "Last_Created_By"
        Me.Last_Created_By.Visible = True
        Me.Last_Created_By.VisibleIndex = 3
        Me.Last_Created_By.Width = 69
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(449, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.tglsampai)
        Me.Panel6.Controls.Add(Me.tglDari)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(121, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(328, 42)
        Me.Panel6.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "s/d"
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(169, 12)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(116, 20)
        Me.tglsampai.TabIndex = 25
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(6, 12)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(125, 20)
        Me.tglDari.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_deselect)
        Me.Panel3.Controls.Add(Me.Btn_pilih)
        Me.Panel3.Controls.Add(Me.cmdClear)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1016, 42)
        Me.Panel3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 42)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(365, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "CETAK ULANG INSPEKSI BARANG MASUK"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcMonQC
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(70, 50, 50, 50)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "MONITORING INSPEKSI BARANG MASUK", ""}, New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), Nothing)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 37)
        Me.Panel2.TabIndex = 4
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMonQC)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1016, 390)
        Me.pnl.TabIndex = 4
        '
        'btn_deselect
        '
        Me.btn_deselect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_deselect.ImageIndex = 0
        Me.btn_deselect.ImageList = Me.img
        Me.btn_deselect.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btn_deselect.Location = New System.Drawing.Point(798, 0)
        Me.btn_deselect.LookAndFeel.SkinName = "The Asphalt World"
        Me.btn_deselect.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_deselect.Name = "btn_deselect"
        Me.btn_deselect.Size = New System.Drawing.Size(109, 42)
        Me.btn_deselect.TabIndex = 43
        Me.btn_deselect.Text = "Deselect All"
        Me.btn_deselect.ToolTip = "Celar Filter"
        '
        'Btn_pilih
        '
        Me.Btn_pilih.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_pilih.ImageIndex = 3
        Me.Btn_pilih.ImageList = Me.img
        Me.Btn_pilih.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Btn_pilih.Location = New System.Drawing.Point(907, 0)
        Me.Btn_pilih.LookAndFeel.SkinName = "The Asphalt World"
        Me.Btn_pilih.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Btn_pilih.Name = "Btn_pilih"
        Me.Btn_pilih.Size = New System.Drawing.Size(109, 42)
        Me.Btn_pilih.TabIndex = 42
        Me.Btn_pilih.Text = "Select All"
        Me.Btn_pilih.ToolTip = "Celar Filter"
        '
        'frmReCtk_QC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 390)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmReCtk_QC"
        Me.Text = "frmReCtk_QC"
        CType(Me.GcMonQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMonQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GcMonQC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMonQC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_pass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_unpass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Created_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents cetak_ke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cetak_ulang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CE_ctk_ulang As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btn_deselect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Btn_pilih As DevExpress.XtraEditors.SimpleButton
End Class
