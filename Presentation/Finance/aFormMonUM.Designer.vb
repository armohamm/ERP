<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormMonUM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormMonUM))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.pnl = New System.Windows.Forms.Panel
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.gcUM = New DevExpress.XtraGrid.GridControl
        Me.gvUM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tanggalGV1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupValuta = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcPelunasan = New DevExpress.XtraGrid.GridControl
        Me.gvPelunasan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prev_no_inv2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bayar2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVRekBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LOVPusBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.grpCetak = New DevExpress.XtraEditors.GroupControl
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnCetak = New DevExpress.XtraEditors.SimpleButton
        Me.chkLapRinci = New DevExpress.XtraEditors.CheckEdit
        Me.chkLapLunas = New DevExpress.XtraEditors.CheckEdit
        Me.chkLapUM = New DevExpress.XtraEditors.CheckEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.chkNonPosting = New DevExpress.XtraEditors.CheckEdit
        Me.chkPosting = New DevExpress.XtraEditors.CheckEdit
        Me.grpView = New DevExpress.XtraEditors.GroupControl
        Me.chkOutStanding = New DevExpress.XtraEditors.CheckEdit
        Me.chkAll = New DevExpress.XtraEditors.CheckEdit
        Me.grpFilter = New DevExpress.XtraEditors.GroupControl
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.pnlKartu = New System.Windows.Forms.Panel
        Me.lckKartu = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.pnlTanggal = New System.Windows.Forms.Panel
        Me.dtpTanggal = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.pclUM = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.pclLunas = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.pclLengkap = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.pnl.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.gcUM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupValuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPelunasan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPelunasan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVRekBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVPusBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.grpCetak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCetak.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.chkLapRinci.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLapLunas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLapUM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkNonPosting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPosting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpView.SuspendLayout()
        CType(Me.chkOutStanding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilter.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlKartu.SuspendLayout()
        CType(Me.lckKartu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTanggal.SuspendLayout()
        CType(Me.dtpTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pclUM.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pclLunas.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pclLengkap.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.SplitContainerControl1)
        Me.pnl.Controls.Add(Me.pnlHeader)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1091, 623)
        Me.pnl.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 185)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcUM)
        Me.SplitContainerControl1.Panel1.Text = "pnlUM"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcPelunasan)
        Me.SplitContainerControl1.Panel2.Text = "pnlPelunasan"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1091, 413)
        Me.SplitContainerControl1.SplitterPosition = 209
        Me.SplitContainerControl1.TabIndex = 8
        '
        'gcUM
        '
        Me.gcUM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcUM.Location = New System.Drawing.Point(0, 0)
        Me.gcUM.MainView = Me.gvUM
        Me.gcUM.Name = "gcUM"
        Me.gcUM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupKartu, Me.lookupValuta})
        Me.gcUM.Size = New System.Drawing.Size(1091, 209)
        Me.gcUM.TabIndex = 5
        Me.gcUM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUM})
        '
        'gvUM
        '
        Me.gvUM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no, Me.nomor, Me.no_ref1, Me.tanggalGV1, Me.kd_kartu, Me.kd_valuta, Me.jml_tagihan, Me.jml_bayar, Me.jml_akhir})
        Me.gvUM.GridControl = Me.gcUM
        Me.gvUM.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.gvUM.Name = "gvUM"
        Me.gvUM.OptionsBehavior.Editable = False
        Me.gvUM.OptionsBehavior.ReadOnly = True
        Me.gvUM.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gvUM.OptionsView.EnableAppearanceEvenRow = True
        Me.gvUM.OptionsView.EnableAppearanceOddRow = True
        Me.gvUM.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.gvUM.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvUM.OptionsView.ShowFooter = True
        Me.gvUM.OptionsView.ShowIndicator = False
        Me.gvUM.ViewCaption = "UANG MUKA"
        '
        'no
        '
        Me.no.AppearanceCell.Options.UseTextOptions = True
        Me.no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no.AppearanceHeader.Options.UseFont = True
        Me.no.AppearanceHeader.Options.UseTextOptions = True
        Me.no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no.Caption = "No."
        Me.no.FieldName = "no"
        Me.no.Name = "no"
        Me.no.Visible = True
        Me.no.VisibleIndex = 0
        '
        'nomor
        '
        Me.nomor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nomor.AppearanceHeader.Options.UseFont = True
        Me.nomor.AppearanceHeader.Options.UseTextOptions = True
        Me.nomor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nomor.Caption = "No. UM"
        Me.nomor.FieldName = "nomor"
        Me.nomor.Name = "nomor"
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 1
        '
        'no_ref1
        '
        Me.no_ref1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_ref1.AppearanceHeader.Options.UseFont = True
        Me.no_ref1.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref1.Caption = "No. Referensi"
        Me.no_ref1.FieldName = "no_ref1"
        Me.no_ref1.Name = "no_ref1"
        Me.no_ref1.Visible = True
        Me.no_ref1.VisibleIndex = 2
        '
        'tanggalGV1
        '
        Me.tanggalGV1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tanggalGV1.AppearanceHeader.Options.UseFont = True
        Me.tanggalGV1.AppearanceHeader.Options.UseTextOptions = True
        Me.tanggalGV1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tanggalGV1.Caption = "Tanggal"
        Me.tanggalGV1.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tanggalGV1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tanggalGV1.FieldName = "tanggal"
        Me.tanggalGV1.Name = "tanggalGV1"
        Me.tanggalGV1.Visible = True
        Me.tanggalGV1.VisibleIndex = 3
        Me.tanggalGV1.Width = 124
        '
        'kd_kartu
        '
        Me.kd_kartu.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_kartu.AppearanceHeader.Options.UseFont = True
        Me.kd_kartu.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_kartu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_kartu.Caption = "Kartu"
        Me.kd_kartu.ColumnEdit = Me.lookupKartu
        Me.kd_kartu.FieldName = "kartu"
        Me.kd_kartu.Name = "kd_kartu"
        Me.kd_kartu.Visible = True
        Me.kd_kartu.VisibleIndex = 4
        Me.kd_kartu.Width = 124
        '
        'lookupKartu
        '
        Me.lookupKartu.AutoHeight = False
        Me.lookupKartu.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookupKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupKartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.lookupKartu.Name = "lookupKartu"
        Me.lookupKartu.NullText = "[Kosong]"
        Me.lookupKartu.ShowFooter = False
        Me.lookupKartu.ShowHeader = False
        Me.lookupKartu.ShowPopupShadow = False
        '
        'kd_valuta
        '
        Me.kd_valuta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_valuta.AppearanceHeader.Options.UseFont = True
        Me.kd_valuta.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_valuta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.ColumnEdit = Me.lookupValuta
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 5
        Me.kd_valuta.Width = 124
        '
        'lookupValuta
        '
        Me.lookupValuta.AutoHeight = False
        Me.lookupValuta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupValuta.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama")})
        Me.lookupValuta.Name = "lookupValuta"
        Me.lookupValuta.NullText = "[Kosong]"
        Me.lookupValuta.ShowFooter = False
        Me.lookupValuta.ShowHeader = False
        Me.lookupValuta.ShowPopupShadow = False
        '
        'jml_tagihan
        '
        Me.jml_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_tagihan.AppearanceHeader.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_tagihan.Caption = "Tagihan"
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_tagihan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 6
        '
        'jml_bayar
        '
        Me.jml_bayar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_bayar.AppearanceHeader.Options.UseFont = True
        Me.jml_bayar.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_bayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_bayar.Caption = "Bayar"
        Me.jml_bayar.DisplayFormat.FormatString = "n2"
        Me.jml_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar.FieldName = "jml_bayar"
        Me.jml_bayar.Name = "jml_bayar"
        Me.jml_bayar.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_bayar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar.Visible = True
        Me.jml_bayar.VisibleIndex = 7
        '
        'jml_akhir
        '
        Me.jml_akhir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_akhir.AppearanceHeader.Options.UseFont = True
        Me.jml_akhir.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_akhir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_akhir.Caption = "Akhir"
        Me.jml_akhir.DisplayFormat.FormatString = "n2"
        Me.jml_akhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_akhir.FieldName = "jml_akhir"
        Me.jml_akhir.Name = "jml_akhir"
        Me.jml_akhir.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_akhir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_akhir.Visible = True
        Me.jml_akhir.VisibleIndex = 8
        '
        'gcPelunasan
        '
        Me.gcPelunasan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPelunasan.Location = New System.Drawing.Point(0, 0)
        Me.gcPelunasan.MainView = Me.gvPelunasan
        Me.gcPelunasan.Name = "gcPelunasan"
        Me.gcPelunasan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVRekBiaya, Me.LOVPusBiaya})
        Me.gcPelunasan.Size = New System.Drawing.Size(1091, 198)
        Me.gcPelunasan.TabIndex = 2
        Me.gcPelunasan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPelunasan})
        '
        'gvPelunasan
        '
        Me.gvPelunasan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no2, Me.no_trans2, Me.tgl_trans2, Me.prev_no_inv2, Me.no_ref2, Me.keterangan2, Me.jml_bayar2})
        Me.gvPelunasan.GridControl = Me.gcPelunasan
        Me.gvPelunasan.Name = "gvPelunasan"
        Me.gvPelunasan.OptionsBehavior.Editable = False
        Me.gvPelunasan.OptionsBehavior.ReadOnly = True
        Me.gvPelunasan.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPelunasan.OptionsView.EnableAppearanceOddRow = True
        Me.gvPelunasan.OptionsView.ShowFooter = True
        Me.gvPelunasan.OptionsView.ShowIndicator = False
        Me.gvPelunasan.OptionsView.ShowViewCaption = True
        Me.gvPelunasan.ViewCaption = "PELUNASAN UANG MUKA"
        '
        'no2
        '
        Me.no2.AppearanceCell.Options.UseTextOptions = True
        Me.no2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no2.AppearanceHeader.Options.UseFont = True
        Me.no2.AppearanceHeader.Options.UseTextOptions = True
        Me.no2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no2.Caption = "No."
        Me.no2.FieldName = "no"
        Me.no2.Name = "no2"
        Me.no2.Visible = True
        Me.no2.VisibleIndex = 0
        '
        'no_trans2
        '
        Me.no_trans2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_trans2.AppearanceHeader.Options.UseFont = True
        Me.no_trans2.AppearanceHeader.Options.UseTextOptions = True
        Me.no_trans2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_trans2.Caption = "No. Trans"
        Me.no_trans2.FieldName = "no_trans"
        Me.no_trans2.Name = "no_trans2"
        Me.no_trans2.Visible = True
        Me.no_trans2.VisibleIndex = 1
        '
        'tgl_trans2
        '
        Me.tgl_trans2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_trans2.AppearanceHeader.Options.UseFont = True
        Me.tgl_trans2.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_trans2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans2.Caption = "Tanggal"
        Me.tgl_trans2.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_trans2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans2.FieldName = "tgl_trans"
        Me.tgl_trans2.Name = "tgl_trans2"
        Me.tgl_trans2.Visible = True
        Me.tgl_trans2.VisibleIndex = 4
        Me.tgl_trans2.Width = 170
        '
        'prev_no_inv2
        '
        Me.prev_no_inv2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.prev_no_inv2.AppearanceHeader.Options.UseFont = True
        Me.prev_no_inv2.AppearanceHeader.Options.UseTextOptions = True
        Me.prev_no_inv2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.prev_no_inv2.Caption = "No. Nota"
        Me.prev_no_inv2.FieldName = "prev_no_inv"
        Me.prev_no_inv2.Name = "prev_no_inv2"
        Me.prev_no_inv2.Visible = True
        Me.prev_no_inv2.VisibleIndex = 2
        '
        'no_ref2
        '
        Me.no_ref2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_ref2.AppearanceHeader.Options.UseFont = True
        Me.no_ref2.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref2.Caption = "No. Referensi"
        Me.no_ref2.FieldName = "no_ref2"
        Me.no_ref2.Name = "no_ref2"
        Me.no_ref2.Visible = True
        Me.no_ref2.VisibleIndex = 3
        '
        'keterangan2
        '
        Me.keterangan2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.keterangan2.AppearanceHeader.Options.UseFont = True
        Me.keterangan2.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan2.Caption = "Keterangan"
        Me.keterangan2.FieldName = "keterangan"
        Me.keterangan2.Name = "keterangan2"
        Me.keterangan2.Visible = True
        Me.keterangan2.VisibleIndex = 5
        '
        'jml_bayar2
        '
        Me.jml_bayar2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_bayar2.AppearanceHeader.Options.UseFont = True
        Me.jml_bayar2.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_bayar2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_bayar2.Caption = "Jumlah Bayar"
        Me.jml_bayar2.DisplayFormat.FormatString = "n2"
        Me.jml_bayar2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar2.FieldName = "jml_bayar"
        Me.jml_bayar2.Name = "jml_bayar2"
        Me.jml_bayar2.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_bayar2.SummaryItem.FieldName = "jml_trans"
        Me.jml_bayar2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar2.Visible = True
        Me.jml_bayar2.VisibleIndex = 6
        '
        'LOVRekBiaya
        '
        Me.LOVRekBiaya.AutoHeight = False
        Me.LOVRekBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVRekBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.LOVRekBiaya.Name = "LOVRekBiaya"
        '
        'LOVPusBiaya
        '
        Me.LOVPusBiaya.AutoHeight = False
        Me.LOVPusBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVPusBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.LOVPusBiaya.Name = "LOVPusBiaya"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.grpCetak)
        Me.pnlHeader.Controls.Add(Me.GroupControl1)
        Me.pnlHeader.Controls.Add(Me.grpView)
        Me.pnlHeader.Controls.Add(Me.grpFilter)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 35)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1091, 150)
        Me.pnlHeader.TabIndex = 7
        '
        'grpCetak
        '
        Me.grpCetak.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpCetak.AppearanceCaption.Options.UseFont = True
        Me.grpCetak.Controls.Add(Me.Panel5)
        Me.grpCetak.Controls.Add(Me.chkLapRinci)
        Me.grpCetak.Controls.Add(Me.chkLapLunas)
        Me.grpCetak.Controls.Add(Me.chkLapUM)
        Me.grpCetak.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpCetak.Location = New System.Drawing.Point(585, 0)
        Me.grpCetak.Name = "grpCetak"
        Me.grpCetak.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.grpCetak.Size = New System.Drawing.Size(150, 150)
        Me.grpCetak.TabIndex = 8
        Me.grpCetak.Text = "Cetak"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnCetak)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(7, 82)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(0, 5, 10, 5)
        Me.Panel5.Size = New System.Drawing.Size(141, 40)
        Me.Panel5.TabIndex = 15
        '
        'btnCetak
        '
        Me.btnCetak.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCetak.Appearance.Options.UseFont = True
        Me.btnCetak.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.Location = New System.Drawing.Point(56, 5)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 30)
        Me.btnCetak.TabIndex = 9
        Me.btnCetak.Text = "Cetak"
        '
        'chkLapRinci
        '
        Me.chkLapRinci.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkLapRinci.Location = New System.Drawing.Point(7, 63)
        Me.chkLapRinci.Name = "chkLapRinci"
        Me.chkLapRinci.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkLapRinci.Properties.Appearance.Options.UseFont = True
        Me.chkLapRinci.Properties.Caption = "Laporan Rinci"
        Me.chkLapRinci.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkLapRinci.Size = New System.Drawing.Size(141, 19)
        Me.chkLapRinci.TabIndex = 8
        '
        'chkLapLunas
        '
        Me.chkLapLunas.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkLapLunas.Location = New System.Drawing.Point(7, 44)
        Me.chkLapLunas.Name = "chkLapLunas"
        Me.chkLapLunas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkLapLunas.Properties.Appearance.Options.UseFont = True
        Me.chkLapLunas.Properties.Caption = "Laporan Pelunasan"
        Me.chkLapLunas.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkLapLunas.Size = New System.Drawing.Size(141, 19)
        Me.chkLapLunas.TabIndex = 7
        '
        'chkLapUM
        '
        Me.chkLapUM.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkLapUM.Location = New System.Drawing.Point(7, 25)
        Me.chkLapUM.Name = "chkLapUM"
        Me.chkLapUM.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkLapUM.Properties.Appearance.Options.UseFont = True
        Me.chkLapUM.Properties.Caption = "Laporan Uang Muka"
        Me.chkLapUM.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkLapUM.Size = New System.Drawing.Size(141, 19)
        Me.chkLapUM.TabIndex = 6
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.chkNonPosting)
        Me.GroupControl1.Controls.Add(Me.chkPosting)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(435, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GroupControl1.Size = New System.Drawing.Size(150, 150)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Status"
        '
        'chkNonPosting
        '
        Me.chkNonPosting.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkNonPosting.Location = New System.Drawing.Point(7, 44)
        Me.chkNonPosting.Name = "chkNonPosting"
        Me.chkNonPosting.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkNonPosting.Properties.Appearance.Options.UseFont = True
        Me.chkNonPosting.Properties.Caption = "Belum Posting"
        Me.chkNonPosting.Size = New System.Drawing.Size(141, 19)
        Me.chkNonPosting.TabIndex = 6
        '
        'chkPosting
        '
        Me.chkPosting.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkPosting.EditValue = True
        Me.chkPosting.Location = New System.Drawing.Point(7, 25)
        Me.chkPosting.Name = "chkPosting"
        Me.chkPosting.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkPosting.Properties.Appearance.Options.UseFont = True
        Me.chkPosting.Properties.Caption = "Posting"
        Me.chkPosting.Size = New System.Drawing.Size(141, 19)
        Me.chkPosting.TabIndex = 5
        '
        'grpView
        '
        Me.grpView.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpView.AppearanceCaption.Options.UseFont = True
        Me.grpView.Controls.Add(Me.chkOutStanding)
        Me.grpView.Controls.Add(Me.chkAll)
        Me.grpView.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpView.Location = New System.Drawing.Point(310, 0)
        Me.grpView.Name = "grpView"
        Me.grpView.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.grpView.Size = New System.Drawing.Size(125, 150)
        Me.grpView.TabIndex = 4
        Me.grpView.Text = "View"
        '
        'chkOutStanding
        '
        Me.chkOutStanding.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkOutStanding.Location = New System.Drawing.Point(7, 44)
        Me.chkOutStanding.Name = "chkOutStanding"
        Me.chkOutStanding.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkOutStanding.Properties.Appearance.Options.UseFont = True
        Me.chkOutStanding.Properties.Caption = "Outstanding"
        Me.chkOutStanding.Size = New System.Drawing.Size(116, 19)
        Me.chkOutStanding.TabIndex = 5
        '
        'chkAll
        '
        Me.chkAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkAll.EditValue = True
        Me.chkAll.Location = New System.Drawing.Point(7, 25)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkAll.Properties.Appearance.Options.UseFont = True
        Me.chkAll.Properties.Caption = "Semua"
        Me.chkAll.Size = New System.Drawing.Size(116, 19)
        Me.chkAll.TabIndex = 4
        '
        'grpFilter
        '
        Me.grpFilter.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpFilter.AppearanceCaption.Options.UseFont = True
        Me.grpFilter.Controls.Add(Me.Panel6)
        Me.grpFilter.Controls.Add(Me.Panel8)
        Me.grpFilter.Controls.Add(Me.pnlKartu)
        Me.grpFilter.Controls.Add(Me.Panel4)
        Me.grpFilter.Controls.Add(Me.pnlTanggal)
        Me.grpFilter.Controls.Add(Me.Panel3)
        Me.grpFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpFilter.Location = New System.Drawing.Point(0, 0)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(310, 150)
        Me.grpFilter.TabIndex = 3
        Me.grpFilter.Text = "Filter"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnRefresh)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(2, 83)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 5, 10, 5)
        Me.Panel6.Size = New System.Drawing.Size(306, 40)
        Me.Panel6.TabIndex = 10
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(221, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 30)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(2, 75)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(306, 8)
        Me.Panel8.TabIndex = 7
        '
        'pnlKartu
        '
        Me.pnlKartu.Controls.Add(Me.lckKartu)
        Me.pnlKartu.Controls.Add(Me.LabelControl3)
        Me.pnlKartu.Controls.Add(Me.LabelControl4)
        Me.pnlKartu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKartu.Location = New System.Drawing.Point(2, 55)
        Me.pnlKartu.Name = "pnlKartu"
        Me.pnlKartu.Size = New System.Drawing.Size(306, 20)
        Me.pnlKartu.TabIndex = 6
        '
        'lckKartu
        '
        Me.lckKartu.Dock = System.Windows.Forms.DockStyle.Left
        Me.lckKartu.EnterMoveNextControl = True
        Me.lckKartu.Location = New System.Drawing.Point(100, 0)
        Me.lckKartu.Name = "lckKartu"
        Me.lckKartu.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckKartu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckKartu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Name1")})
        Me.lckKartu.Properties.NullText = "[Pilih kartu disini]"
        Me.lckKartu.Properties.ShowFooter = False
        Me.lckKartu.Properties.ShowHeader = False
        Me.lckKartu.Properties.ShowPopupShadow = False
        Me.lckKartu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckKartu.Properties.ValidateOnEnterKey = True
        Me.lckKartu.Size = New System.Drawing.Size(190, 20)
        Me.lckKartu.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl4.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Kartu"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(2, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(306, 5)
        Me.Panel4.TabIndex = 5
        '
        'pnlTanggal
        '
        Me.pnlTanggal.Controls.Add(Me.dtpTanggal)
        Me.pnlTanggal.Controls.Add(Me.LabelControl2)
        Me.pnlTanggal.Controls.Add(Me.LabelControl1)
        Me.pnlTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTanggal.Location = New System.Drawing.Point(2, 30)
        Me.pnlTanggal.Name = "pnlTanggal"
        Me.pnlTanggal.Size = New System.Drawing.Size(306, 20)
        Me.pnlTanggal.TabIndex = 4
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpTanggal.EditValue = Nothing
        Me.dtpTanggal.EnterMoveNextControl = True
        Me.dtpTanggal.Location = New System.Drawing.Point(100, 0)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.dtpTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTanggal.Properties.Mask.EditMask = "d MMM yyyy"
        Me.dtpTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtpTanggal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtpTanggal.Properties.ValidateOnEnterKey = True
        Me.dtpTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpTanggal.Size = New System.Drawing.Size(125, 20)
        Me.dtpTanggal.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl1.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Per Tanggal"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(2, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(306, 5)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 598)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 25)
        Me.Panel2.TabIndex = 6
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
        Me.Panel1.Size = New System.Drawing.Size(1091, 35)
        Me.Panel1.TabIndex = 5
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(522, 33)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITOR UANG MUKA PIUTANG"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.pclUM, Me.pclLunas, Me.pclLengkap})
        '
        'pclUM
        '
        Me.pclUM.Component = Me.gcUM
        '
        '
        '
        Me.pclUM.ImageCollection.ImageStream = CType(resources.GetObject("pclUM.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.pclUM.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.pclUM.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.pclUM.PrintingSystem = Me.PrintingSystem1
        Me.pclUM.PrintingSystemBase = Me.PrintingSystem1
        '
        'pclLunas
        '
        Me.pclLunas.Component = Me.gcPelunasan
        '
        '
        '
        Me.pclLunas.ImageCollection.ImageStream = CType(resources.GetObject("pclLunas.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.pclLunas.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.pclLunas.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.pclLunas.PrintingSystem = Me.PrintingSystem1
        Me.pclLunas.PrintingSystemBase = Me.PrintingSystem1
        '
        'pclLengkap
        '
        '
        '
        '
        Me.pclLengkap.ImageCollection.ImageStream = CType(resources.GetObject("pclLengkap.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.pclLengkap.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.pclLengkap.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.pclLengkap.PrintingSystem = Me.PrintingSystem1
        Me.pclLengkap.PrintingSystemBase = Me.PrintingSystem1
        '
        'aFormMonUM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 623)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormMonUM"
        Me.Text = "aFormMonUM"
        Me.pnl.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.gcUM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupValuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPelunasan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPelunasan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVRekBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVPusBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.grpCetak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCetak.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.chkLapRinci.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLapLunas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLapUM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.chkNonPosting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPosting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpView.ResumeLayout(False)
        CType(Me.chkOutStanding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilter.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.pnlKartu.ResumeLayout(False)
        CType(Me.lckKartu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTanggal.ResumeLayout(False)
        CType(Me.dtpTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pclUM.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pclLunas.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pclLengkap.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcUM As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tanggalGV1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupValuta As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_akhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPelunasan As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPelunasan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prev_no_inv2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVRekBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LOVPusBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpView As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkOutStanding As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpFilter As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlKartu As System.Windows.Forms.Panel
    Friend WithEvents lckKartu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlTanggal As System.Windows.Forms.Panel
    Friend WithEvents dtpTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents pclUM As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents pclLunas As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents pclLengkap As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents grpCetak As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnCetak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkLapRinci As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkLapLunas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkLapUM As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkNonPosting As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPosting As DevExpress.XtraEditors.CheckEdit
End Class
