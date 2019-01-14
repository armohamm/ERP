<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormMonNeraca
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormMonNeraca))
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.pnlBawah = New DevExpress.XtraEditors.PanelControl
        Me.gcAktiva = New DevExpress.XtraGrid.GridControl
        Me.gvAktiva = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.gridKeterangan = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.nm_buku_besar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gridTahunSblm = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.saldo_awal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gridPenyusutan = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.januari = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.februari = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.maret = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.april = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.mei = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.juni = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.juli = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.agustus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.september = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.oktober = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.november = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.desember = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gridTahunIni = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.saldo_akhir = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.pnlAtas = New DevExpress.XtraEditors.PanelControl
        Me.pnlRefresh = New DevExpress.XtraEditors.PanelControl
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.pnlFilter = New DevExpress.XtraEditors.PanelControl
        Me.pnlTahun = New DevExpress.XtraEditors.PanelControl
        Me.lckTahun = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.kd_buku_besar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.pnlBawah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBawah.SuspendLayout()
        CType(Me.gcAktiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAktiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlAtas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAtas.SuspendLayout()
        CType(Me.pnlRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRefresh.SuspendLayout()
        CType(Me.pnlFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter.SuspendLayout()
        CType(Me.pnlTahun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTahun.SuspendLayout()
        CType(Me.lckTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlBawah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(984, 742)
        Me.pnl.TabIndex = 0
        '
        'pnlBawah
        '
        Me.pnlBawah.Controls.Add(Me.gcAktiva)
        Me.pnlBawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBawah.Location = New System.Drawing.Point(2, 97)
        Me.pnlBawah.Name = "pnlBawah"
        Me.pnlBawah.Size = New System.Drawing.Size(980, 618)
        Me.pnlBawah.TabIndex = 1
        '
        'gcAktiva
        '
        Me.gcAktiva.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAktiva.Location = New System.Drawing.Point(2, 2)
        Me.gcAktiva.MainView = Me.gvAktiva
        Me.gcAktiva.Name = "gcAktiva"
        Me.gcAktiva.Size = New System.Drawing.Size(976, 614)
        Me.gcAktiva.TabIndex = 0
        Me.gcAktiva.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAktiva, Me.GridView1, Me.AdvBandedGridView1})
        '
        'gvAktiva
        '
        Me.gvAktiva.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvAktiva.Appearance.BandPanel.Options.UseFont = True
        Me.gvAktiva.Appearance.BandPanel.Options.UseTextOptions = True
        Me.gvAktiva.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvAktiva.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvAktiva.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvAktiva.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvAktiva.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvAktiva.AppearancePrint.BandPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gvAktiva.AppearancePrint.BandPanel.Options.UseFont = True
        Me.gvAktiva.AppearancePrint.BandPanel.Options.UseTextOptions = True
        Me.gvAktiva.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvAktiva.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.gvAktiva.AppearancePrint.EvenRow.Options.UseFont = True
        Me.gvAktiva.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold)
        Me.gvAktiva.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.gvAktiva.AppearancePrint.OddRow.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.gvAktiva.AppearancePrint.OddRow.Options.UseFont = True
        Me.gvAktiva.AppearancePrint.Row.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.gvAktiva.AppearancePrint.Row.Options.UseFont = True
        Me.gvAktiva.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridKeterangan, Me.gridTahunSblm, Me.gridPenyusutan, Me.gridTahunIni})
        Me.gvAktiva.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gvAktiva.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.kd_buku_besar, Me.nm_buku_besar, Me.saldo_awal, Me.januari, Me.februari, Me.maret, Me.april, Me.mei, Me.juni, Me.juli, Me.agustus, Me.september, Me.oktober, Me.november, Me.desember, Me.saldo_akhir})
        Me.gvAktiva.CustomizationFormBounds = New System.Drawing.Rectangle(810, 455, 223, 215)
        Me.gvAktiva.GridControl = Me.gcAktiva
        Me.gvAktiva.GroupFormat = ""
        Me.gvAktiva.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.gvAktiva.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvAktiva.Name = "gvAktiva"
        Me.gvAktiva.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvAktiva.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvAktiva.OptionsBehavior.Editable = False
        Me.gvAktiva.OptionsBehavior.ReadOnly = True
        Me.gvAktiva.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gvAktiva.OptionsCustomization.AllowBandMoving = False
        Me.gvAktiva.OptionsCustomization.AllowGroup = False
        Me.gvAktiva.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvAktiva.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.gvAktiva.OptionsPrint.EnableAppearanceEvenRow = True
        Me.gvAktiva.OptionsPrint.EnableAppearanceOddRow = True
        Me.gvAktiva.OptionsPrint.PrintPreview = True
        Me.gvAktiva.OptionsPrint.UsePrintStyles = True
        Me.gvAktiva.OptionsSelection.MultiSelect = True
        Me.gvAktiva.OptionsSelection.UseIndicatorForSelection = False
        Me.gvAktiva.OptionsView.ColumnAutoWidth = False
        Me.gvAktiva.OptionsView.EnableAppearanceEvenRow = True
        Me.gvAktiva.OptionsView.EnableAppearanceOddRow = True
        Me.gvAktiva.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.gvAktiva.OptionsView.RowAutoHeight = True
        Me.gvAktiva.OptionsView.ShowDetailButtons = False
        Me.gvAktiva.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvAktiva.OptionsView.ShowFooter = True
        Me.gvAktiva.OptionsView.ShowGroupPanel = False
        Me.gvAktiva.OptionsView.ShowIndicator = False
        Me.gvAktiva.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'gridKeterangan
        '
        Me.gridKeterangan.Caption = "Keterangan"
        Me.gridKeterangan.Columns.Add(Me.kd_buku_besar)
        Me.gridKeterangan.Columns.Add(Me.nm_buku_besar)
        Me.gridKeterangan.MinWidth = 20
        Me.gridKeterangan.Name = "gridKeterangan"
        Me.gridKeterangan.OptionsBand.AllowMove = False
        Me.gridKeterangan.Width = 189
        '
        'nm_buku_besar
        '
        Me.nm_buku_besar.Caption = "Perkiraan"
        Me.nm_buku_besar.FieldName = "nm_buku_besar"
        Me.nm_buku_besar.Name = "nm_buku_besar"
        Me.nm_buku_besar.Visible = True
        Me.nm_buku_besar.Width = 110
        '
        'gridTahunSblm
        '
        Me.gridTahunSblm.Caption = "Tahun Sebelum"
        Me.gridTahunSblm.Columns.Add(Me.saldo_awal)
        Me.gridTahunSblm.MinWidth = 20
        Me.gridTahunSblm.Name = "gridTahunSblm"
        Me.gridTahunSblm.OptionsBand.AllowMove = False
        Me.gridTahunSblm.Width = 124
        '
        'saldo_awal
        '
        Me.saldo_awal.Caption = "Saldo"
        Me.saldo_awal.DisplayFormat.FormatString = "n2"
        Me.saldo_awal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_awal.FieldName = "saldo_awal"
        Me.saldo_awal.Name = "saldo_awal"
        Me.saldo_awal.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_awal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_awal.Visible = True
        Me.saldo_awal.Width = 124
        '
        'gridPenyusutan
        '
        Me.gridPenyusutan.Caption = "Saldo per Bulan"
        Me.gridPenyusutan.Columns.Add(Me.januari)
        Me.gridPenyusutan.Columns.Add(Me.februari)
        Me.gridPenyusutan.Columns.Add(Me.maret)
        Me.gridPenyusutan.Columns.Add(Me.april)
        Me.gridPenyusutan.Columns.Add(Me.mei)
        Me.gridPenyusutan.Columns.Add(Me.juni)
        Me.gridPenyusutan.Columns.Add(Me.juli)
        Me.gridPenyusutan.Columns.Add(Me.agustus)
        Me.gridPenyusutan.Columns.Add(Me.september)
        Me.gridPenyusutan.Columns.Add(Me.oktober)
        Me.gridPenyusutan.Columns.Add(Me.november)
        Me.gridPenyusutan.Columns.Add(Me.desember)
        Me.gridPenyusutan.MinWidth = 20
        Me.gridPenyusutan.Name = "gridPenyusutan"
        Me.gridPenyusutan.OptionsBand.AllowMove = False
        Me.gridPenyusutan.Width = 900
        '
        'januari
        '
        Me.januari.Caption = "Januari"
        Me.januari.DisplayFormat.FormatString = "n2"
        Me.januari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.januari.FieldName = "januari"
        Me.januari.Name = "januari"
        Me.januari.SummaryItem.DisplayFormat = "{0:n2}"
        Me.januari.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.januari.Visible = True
        '
        'februari
        '
        Me.februari.Caption = "Februari"
        Me.februari.DisplayFormat.FormatString = "n2"
        Me.februari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.februari.FieldName = "februari"
        Me.februari.Name = "februari"
        Me.februari.SummaryItem.DisplayFormat = "{0:n2}"
        Me.februari.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.februari.Visible = True
        '
        'maret
        '
        Me.maret.Caption = "Maret"
        Me.maret.DisplayFormat.FormatString = "n2"
        Me.maret.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.maret.FieldName = "maret"
        Me.maret.Name = "maret"
        Me.maret.SummaryItem.DisplayFormat = "{0:n2}"
        Me.maret.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.maret.Visible = True
        '
        'april
        '
        Me.april.Caption = "April"
        Me.april.DisplayFormat.FormatString = "n2"
        Me.april.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.april.FieldName = "april"
        Me.april.Name = "april"
        Me.april.SummaryItem.DisplayFormat = "{0:n2}"
        Me.april.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.april.Visible = True
        '
        'mei
        '
        Me.mei.Caption = "Mei"
        Me.mei.DisplayFormat.FormatString = "n2"
        Me.mei.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.mei.FieldName = "mei"
        Me.mei.Name = "mei"
        Me.mei.SummaryItem.DisplayFormat = "{0:n2}"
        Me.mei.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.mei.Visible = True
        '
        'juni
        '
        Me.juni.Caption = "Juni"
        Me.juni.DisplayFormat.FormatString = "n2"
        Me.juni.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.juni.FieldName = "juni"
        Me.juni.Name = "juni"
        Me.juni.SummaryItem.DisplayFormat = "{0:n2}"
        Me.juni.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.juni.Visible = True
        '
        'juli
        '
        Me.juli.Caption = "Juli"
        Me.juli.DisplayFormat.FormatString = "n2"
        Me.juli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.juli.FieldName = "juli"
        Me.juli.Name = "juli"
        Me.juli.SummaryItem.DisplayFormat = "{0:n2}"
        Me.juli.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.juli.Visible = True
        '
        'agustus
        '
        Me.agustus.Caption = "Agustus"
        Me.agustus.DisplayFormat.FormatString = "n2"
        Me.agustus.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.agustus.FieldName = "agustus"
        Me.agustus.Name = "agustus"
        Me.agustus.SummaryItem.DisplayFormat = "{0:n2}"
        Me.agustus.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.agustus.Visible = True
        '
        'september
        '
        Me.september.Caption = "September"
        Me.september.DisplayFormat.FormatString = "n2"
        Me.september.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.september.FieldName = "september"
        Me.september.Name = "september"
        Me.september.SummaryItem.DisplayFormat = "{0:n2}"
        Me.september.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.september.Visible = True
        '
        'oktober
        '
        Me.oktober.Caption = "Oktober"
        Me.oktober.DisplayFormat.FormatString = "n2"
        Me.oktober.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.oktober.FieldName = "oktober"
        Me.oktober.Name = "oktober"
        Me.oktober.SummaryItem.DisplayFormat = "{0:n2}"
        Me.oktober.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.oktober.Visible = True
        '
        'november
        '
        Me.november.Caption = "November"
        Me.november.DisplayFormat.FormatString = "n2"
        Me.november.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.november.FieldName = "november"
        Me.november.Name = "november"
        Me.november.SummaryItem.DisplayFormat = "{0:n2}"
        Me.november.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.november.Visible = True
        '
        'desember
        '
        Me.desember.Caption = "Desember"
        Me.desember.DisplayFormat.FormatString = "n2"
        Me.desember.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.desember.FieldName = "desember"
        Me.desember.Name = "desember"
        Me.desember.SummaryItem.DisplayFormat = "{0:n2}"
        Me.desember.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.desember.Visible = True
        '
        'gridTahunIni
        '
        Me.gridTahunIni.Caption = "Tahun Ini"
        Me.gridTahunIni.Columns.Add(Me.saldo_akhir)
        Me.gridTahunIni.MinWidth = 20
        Me.gridTahunIni.Name = "gridTahunIni"
        Me.gridTahunIni.OptionsBand.AllowMove = False
        Me.gridTahunIni.Width = 75
        '
        'saldo_akhir
        '
        Me.saldo_akhir.Caption = "Saldo"
        Me.saldo_akhir.DisplayFormat.FormatString = "n2"
        Me.saldo_akhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_akhir.FieldName = "saldo_akhir"
        Me.saldo_akhir.Name = "saldo_akhir"
        Me.saldo_akhir.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_akhir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_akhir.Visible = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcAktiva
        Me.GridView1.Name = "GridView1"
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.AdvBandedGridView1.GridControl = Me.gcAktiva
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand2"
        Me.GridBand2.Name = "GridBand2"
        '
        'pnlAtas
        '
        Me.pnlAtas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlAtas.Controls.Add(Me.pnlRefresh)
        Me.pnlAtas.Controls.Add(Me.pnlFilter)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(2, 37)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(980, 60)
        Me.pnlAtas.TabIndex = 7
        '
        'pnlRefresh
        '
        Me.pnlRefresh.Controls.Add(Me.btnRefresh)
        Me.pnlRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRefresh.Location = New System.Drawing.Point(400, 0)
        Me.pnlRefresh.Name = "pnlRefresh"
        Me.pnlRefresh.Size = New System.Drawing.Size(146, 60)
        Me.pnlRefresh.TabIndex = 5
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(2, 2)
        Me.btnRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(142, 56)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnRefresh.ToolTipTitle = "RELOAD"
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.pnlTahun)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(400, 60)
        Me.pnlFilter.TabIndex = 4
        '
        'pnlTahun
        '
        Me.pnlTahun.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlTahun.Controls.Add(Me.lckTahun)
        Me.pnlTahun.Controls.Add(Me.LabelControl2)
        Me.pnlTahun.Controls.Add(Me.LabelControl1)
        Me.pnlTahun.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTahun.Location = New System.Drawing.Point(2, 2)
        Me.pnlTahun.Name = "pnlTahun"
        Me.pnlTahun.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.pnlTahun.Size = New System.Drawing.Size(396, 30)
        Me.pnlTahun.TabIndex = 2
        '
        'lckTahun
        '
        Me.lckTahun.Dock = System.Windows.Forms.DockStyle.Left
        Me.lckTahun.EnterMoveNextControl = True
        Me.lckTahun.Location = New System.Drawing.Point(60, 5)
        Me.lckTahun.Name = "lckTahun"
        Me.lckTahun.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckTahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckTahun.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("thn_buku", "Name1")})
        Me.lckTahun.Properties.NullText = ""
        Me.lckTahun.Properties.ShowFooter = False
        Me.lckTahun.Properties.ShowHeader = False
        Me.lckTahun.Properties.ShowLines = False
        Me.lckTahun.Properties.ShowPopupShadow = False
        Me.lckTahun.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckTahun.Properties.ValidateOnEnterKey = True
        Me.lckTahun.Size = New System.Drawing.Size(100, 20)
        Me.lckTahun.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(50, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
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
        Me.LabelControl1.Location = New System.Drawing.Point(0, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.LabelControl1.Size = New System.Drawing.Size(50, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tahun"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 715)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 25)
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
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 35)
        Me.Panel1.TabIndex = 5
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(350, 33)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "LAPORAN NERACA"
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
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gcAktiva
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(10, 10, 10, 30)
        Me.PrintableComponentLink1.MinMargins = New System.Drawing.Printing.Margins(5, 5, 5, 5)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.Caption = "Kode"
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.Width = 79
        '
        'aFormMonNeraca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 742)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormMonNeraca"
        Me.Text = "aFormMonAktiva"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.pnlBawah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBawah.ResumeLayout(False)
        CType(Me.gcAktiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAktiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlAtas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.pnlRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRefresh.ResumeLayout(False)
        CType(Me.pnlFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter.ResumeLayout(False)
        CType(Me.pnlTahun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTahun.ResumeLayout(False)
        CType(Me.lckTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlAtas As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlRefresh As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlFilter As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlTahun As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lckTahun As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlBawah As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcAktiva As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAktiva As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents nm_buku_besar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents saldo_awal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents januari As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents februari As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents maret As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents april As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents mei As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents juni As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents juli As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents agustus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents september As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents oktober As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents november As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents desember As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents saldo_akhir As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridKeterangan As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridTahunSblm As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridPenyusutan As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridTahunIni As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
