<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonKasBon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonKasBon))
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.lblJudul = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlGcMaster = New System.Windows.Forms.Panel
        Me.SplitContainerControlMaster = New DevExpress.XtraEditors.SplitContainerControl
        Me.pnlGC1 = New System.Windows.Forms.Panel
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nokas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlGC2 = New DevExpress.XtraEditors.PanelControl
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_trans2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prev_nomor2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nomor2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rekening2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVRekBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pusat_biaya2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVPusBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.keterangan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_trans2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.minusplus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CEGV2 = New DevExpress.XtraEditors.CheckEdit
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.CEGV1 = New DevExpress.XtraEditors.CheckEdit
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.CEPPOutStanding = New DevExpress.XtraEditors.CheckEdit
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.CEPPAll = New DevExpress.XtraEditors.CheckEdit
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Kartu = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.dteAkhir = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.dteAwal = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintableComponentLink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlGcMaster.SuspendLayout()
        CType(Me.SplitContainerControlMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControlMaster.SuspendLayout()
        Me.pnlGC1.SuspendLayout()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlGC2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGC2.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVRekBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVPusBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.CEGV2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEGV1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.CEPPOutStanding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEPPAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.Kartu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.dteAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.dteAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultToolTipController1
        '
        '
        '
        '
        Me.DefaultToolTipController1.DefaultController.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DefaultToolTipController1.DefaultController.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseBackColor = True
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseFont = True
        Me.DefaultToolTipController1.DefaultController.Rounded = True
        Me.DefaultToolTipController1.DefaultController.ShowBeak = True
        Me.DefaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.Standard
        '
        'lblJudul
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.lblJudul, DevExpress.Utils.DefaultBoolean.[Default])
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(522, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITOR KARTU KAS BON"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 37)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PictureBox1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnl
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnl, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnl.Controls.Add(Me.pnlGcMaster)
        Me.pnl.Controls.Add(Me.Panel8)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(986, 571)
        Me.pnl.TabIndex = 5
        '
        'pnlGcMaster
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlGcMaster, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlGcMaster.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlGcMaster.Controls.Add(Me.SplitContainerControlMaster)
        Me.pnlGcMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGcMaster.Location = New System.Drawing.Point(0, 157)
        Me.pnlGcMaster.Name = "pnlGcMaster"
        Me.pnlGcMaster.Size = New System.Drawing.Size(986, 414)
        Me.pnlGcMaster.TabIndex = 8
        '
        'SplitContainerControlMaster
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.SplitContainerControlMaster, DevExpress.Utils.DefaultBoolean.[Default])
        Me.SplitContainerControlMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControlMaster.Horizontal = False
        Me.SplitContainerControlMaster.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControlMaster.Name = "SplitContainerControlMaster"
        Me.SplitContainerControlMaster.Panel1.Controls.Add(Me.pnlGC1)
        Me.SplitContainerControlMaster.Panel1.Text = "Panel1"
        Me.SplitContainerControlMaster.Panel2.Controls.Add(Me.pnlGC2)
        Me.SplitContainerControlMaster.Panel2.Text = "Panel2"
        Me.SplitContainerControlMaster.Size = New System.Drawing.Size(986, 414)
        Me.SplitContainerControlMaster.SplitterPosition = 231
        Me.SplitContainerControlMaster.TabIndex = 4
        Me.SplitContainerControlMaster.Text = "SplitContainerControl2"
        '
        'pnlGC1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlGC1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlGC1.BackColor = System.Drawing.Color.White
        Me.pnlGC1.Controls.Add(Me.GC1)
        Me.pnlGC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGC1.Location = New System.Drawing.Point(0, 0)
        Me.pnlGC1.Name = "pnlGC1"
        Me.pnlGC1.Size = New System.Drawing.Size(986, 231)
        Me.pnlGC1.TabIndex = 0
        '
        'GC1
        '
        Me.GC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC1.Location = New System.Drawing.Point(0, 0)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVKartu})
        Me.GC1.Size = New System.Drawing.Size(986, 231)
        Me.GC1.TabIndex = 3
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GV1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no, Me.seq, Me.nokas, Me.nomor, Me.tipe_trans, Me.tgl_trans, Me.kd_kartu, Me.keterangan, Me.jml_trans, Me.jml_bayar, Me.jml_akhir})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsBehavior.ReadOnly = True
        Me.GV1.OptionsPrint.ExpandAllGroups = False
        Me.GV1.OptionsPrint.PrintGroupFooter = False
        Me.GV1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowViewCaption = True
        Me.GV1.ViewCaption = "KAS BON"
        '
        'no
        '
        Me.no.AppearanceCell.Options.UseTextOptions = True
        Me.no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no.Caption = "No."
        Me.no.FieldName = "no"
        Me.no.Name = "no"
        '
        'seq
        '
        Me.seq.Caption = "No. Kas Bon"
        Me.seq.FieldName = "seq"
        Me.seq.Name = "seq"
        Me.seq.Visible = True
        Me.seq.VisibleIndex = 0
        '
        'nokas
        '
        Me.nokas.Caption = "Periode"
        Me.nokas.FieldName = "nokas"
        Me.nokas.Name = "nokas"
        '
        'nomor
        '
        Me.nomor.Caption = "No. Kas Bon"
        Me.nomor.FieldName = "nomor"
        Me.nomor.Name = "nomor"
        '
        'tipe_trans
        '
        Me.tipe_trans.Caption = "Tipe Trans"
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        '
        'kd_kartu
        '
        Me.kd_kartu.Caption = "Nama"
        Me.kd_kartu.ColumnEdit = Me.LOVKartu
        Me.kd_kartu.FieldName = "kd_kartu"
        Me.kd_kartu.Name = "kd_kartu"
        Me.kd_kartu.Visible = True
        Me.kd_kartu.VisibleIndex = 2
        '
        'LOVKartu
        '
        Me.LOVKartu.AutoHeight = False
        Me.LOVKartu.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVKartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.LOVKartu.Name = "LOVKartu"
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 3
        '
        'jml_trans
        '
        Me.jml_trans.Caption = "Jml. Pinjaman"
        Me.jml_trans.DisplayFormat.FormatString = "n2"
        Me.jml_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_trans.Visible = True
        Me.jml_trans.VisibleIndex = 4
        '
        'jml_bayar
        '
        Me.jml_bayar.Caption = "Jml. Pelunasan"
        Me.jml_bayar.DisplayFormat.FormatString = "n2"
        Me.jml_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar.FieldName = "jml_bayar"
        Me.jml_bayar.Name = "jml_bayar"
        Me.jml_bayar.Visible = True
        Me.jml_bayar.VisibleIndex = 5
        '
        'jml_akhir
        '
        Me.jml_akhir.Caption = "Saldo Pinjaman"
        Me.jml_akhir.DisplayFormat.FormatString = "n2"
        Me.jml_akhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_akhir.FieldName = "jml_akhir"
        Me.jml_akhir.Name = "jml_akhir"
        Me.jml_akhir.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_akhir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_akhir.Visible = True
        Me.jml_akhir.VisibleIndex = 6
        '
        'pnlGC2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlGC2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlGC2.Controls.Add(Me.GC2)
        Me.pnlGC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGC2.Location = New System.Drawing.Point(0, 0)
        Me.pnlGC2.Name = "pnlGC2"
        Me.pnlGC2.Size = New System.Drawing.Size(986, 177)
        Me.pnlGC2.TabIndex = 1
        '
        'GC2
        '
        Me.GC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC2.Location = New System.Drawing.Point(2, 2)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVRekBiaya, Me.LOVPusBiaya})
        Me.GC2.Size = New System.Drawing.Size(982, 173)
        Me.GC2.TabIndex = 0
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2, Me.GridView1, Me.GridView2})
        '
        'GV2
        '
        Me.GV2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV2.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.Empty.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupRow.Options.UseFont = True
        Me.GV2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GV2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.OddRow.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.Options.UseForeColor = True
        Me.GV2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.Preview.Options.UseBackColor = True
        Me.GV2.Appearance.Preview.Options.UseForeColor = True
        Me.GV2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GV2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.Row.Options.UseBackColor = True
        Me.GV2.Appearance.Row.Options.UseFont = True
        Me.GV2.Appearance.Row.Options.UseForeColor = True
        Me.GV2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV2.Appearance.VertLine.Options.UseBackColor = True
        Me.GV2.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GV2.Appearance.ViewCaption.Options.UseFont = True
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no2, Me.tipe_trans2, Me.prev_nomor2, Me.nomor2, Me.tgl_trans2, Me.rekening2, Me.pusat_biaya2, Me.keterangan2, Me.jml_trans2, Me.minusplus})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.Editable = False
        Me.GV2.OptionsBehavior.ReadOnly = True
        Me.GV2.OptionsView.EnableAppearanceEvenRow = True
        Me.GV2.OptionsView.EnableAppearanceOddRow = True
        Me.GV2.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowViewCaption = True
        Me.GV2.PaintStyleName = "WindowsXP"
        Me.GV2.ViewCaption = "PELUNASAN KAS BON"
        '
        'no2
        '
        Me.no2.AppearanceCell.Options.UseTextOptions = True
        Me.no2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no2.Caption = "No"
        Me.no2.FieldName = "no"
        Me.no2.Name = "no2"
        '
        'tipe_trans2
        '
        Me.tipe_trans2.Caption = "Tipe Trans"
        Me.tipe_trans2.FieldName = "tipe_trans"
        Me.tipe_trans2.Name = "tipe_trans2"
        '
        'prev_nomor2
        '
        Me.prev_nomor2.Caption = "Prev. Nomor"
        Me.prev_nomor2.FieldName = "prev_nomor"
        Me.prev_nomor2.Name = "prev_nomor2"
        '
        'nomor2
        '
        Me.nomor2.Caption = "No. Trans"
        Me.nomor2.FieldName = "nomor"
        Me.nomor2.Name = "nomor2"
        Me.nomor2.Visible = True
        Me.nomor2.VisibleIndex = 0
        '
        'tgl_trans2
        '
        Me.tgl_trans2.Caption = "Tgl. Trans"
        Me.tgl_trans2.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_trans2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans2.FieldName = "tgl_trans"
        Me.tgl_trans2.Name = "tgl_trans2"
        Me.tgl_trans2.Visible = True
        Me.tgl_trans2.VisibleIndex = 1
        '
        'rekening2
        '
        Me.rekening2.Caption = "Rek. Biaya"
        Me.rekening2.ColumnEdit = Me.LOVRekBiaya
        Me.rekening2.FieldName = "rekening"
        Me.rekening2.Name = "rekening2"
        Me.rekening2.Visible = True
        Me.rekening2.VisibleIndex = 2
        '
        'LOVRekBiaya
        '
        Me.LOVRekBiaya.AutoHeight = False
        Me.LOVRekBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVRekBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.LOVRekBiaya.Name = "LOVRekBiaya"
        '
        'pusat_biaya2
        '
        Me.pusat_biaya2.Caption = "Pusat Biaya"
        Me.pusat_biaya2.ColumnEdit = Me.LOVPusBiaya
        Me.pusat_biaya2.FieldName = "pusat_biaya"
        Me.pusat_biaya2.Name = "pusat_biaya2"
        Me.pusat_biaya2.Visible = True
        Me.pusat_biaya2.VisibleIndex = 3
        '
        'LOVPusBiaya
        '
        Me.LOVPusBiaya.AutoHeight = False
        Me.LOVPusBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVPusBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.LOVPusBiaya.Name = "LOVPusBiaya"
        '
        'keterangan2
        '
        Me.keterangan2.Caption = "Keterangan"
        Me.keterangan2.FieldName = "keterangan"
        Me.keterangan2.Name = "keterangan2"
        Me.keterangan2.Visible = True
        Me.keterangan2.VisibleIndex = 4
        '
        'jml_trans2
        '
        Me.jml_trans2.Caption = "Jml. Trans"
        Me.jml_trans2.DisplayFormat.FormatString = "n2"
        Me.jml_trans2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans2.FieldName = "jml_trans"
        Me.jml_trans2.Name = "jml_trans2"
        Me.jml_trans2.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_trans2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_trans2.Visible = True
        Me.jml_trans2.VisibleIndex = 5
        '
        'minusplus
        '
        Me.minusplus.Caption = "(+ / -)"
        Me.minusplus.DisplayFormat.FormatString = "n2"
        Me.minusplus.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.minusplus.FieldName = "minusplus"
        Me.minusplus.Name = "minusplus"
        Me.minusplus.Visible = True
        Me.minusplus.VisibleIndex = 6
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GC2
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GC2
        Me.GridView2.Name = "GridView2"
        '
        'Panel8
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel8, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 137)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(986, 20)
        Me.Panel8.TabIndex = 7
        '
        'Panel2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 100)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel3.Controls.Add(Me.CEGV2)
        Me.Panel3.Controls.Add(Me.Panel19)
        Me.Panel3.Controls.Add(Me.CEGV1)
        Me.Panel3.Controls.Add(Me.Panel18)
        Me.Panel3.Controls.Add(Me.Panel17)
        Me.Panel3.Controls.Add(Me.Panel14)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(667, 100)
        Me.Panel3.TabIndex = 1
        '
        'CEGV2
        '
        Me.CEGV2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CEGV2.Location = New System.Drawing.Point(508, 29)
        Me.CEGV2.Name = "CEGV2"
        Me.CEGV2.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEGV2.Properties.Appearance.Options.UseForeColor = True
        Me.CEGV2.Properties.Caption = "Data Pelunasan Kas Bon"
        Me.CEGV2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEGV2.Size = New System.Drawing.Size(159, 19)
        Me.CEGV2.TabIndex = 23
        '
        'Panel19
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel19, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(508, 24)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(159, 5)
        Me.Panel19.TabIndex = 22
        '
        'CEGV1
        '
        Me.CEGV1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CEGV1.EditValue = True
        Me.CEGV1.Location = New System.Drawing.Point(508, 5)
        Me.CEGV1.Name = "CEGV1"
        Me.CEGV1.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEGV1.Properties.Appearance.Options.UseForeColor = True
        Me.CEGV1.Properties.Caption = "Data Kasbon"
        Me.CEGV1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEGV1.Size = New System.Drawing.Size(159, 19)
        Me.CEGV1.TabIndex = 21
        '
        'Panel18
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel18, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(508, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(159, 5)
        Me.Panel18.TabIndex = 20
        '
        'Panel17
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel17, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(493, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(15, 100)
        Me.Panel17.TabIndex = 19
        '
        'Panel14
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel14, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel14.Controls.Add(Me.Panel13)
        Me.Panel14.Controls.Add(Me.CEPPOutStanding)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Controls.Add(Me.CEPPAll)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(365, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(128, 100)
        Me.Panel14.TabIndex = 18
        '
        'Panel13
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel13, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel13.Controls.Add(Me.cmdRefresh)
        Me.Panel13.Controls.Add(Me.Panel12)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(0, 48)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(128, 52)
        Me.Panel13.TabIndex = 19
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdRefresh.Appearance.Options.UseFont = True
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(0, 5)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(128, 47)
        Me.cmdRefresh.TabIndex = 19
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.ToolTip = "Reset Data"
        Me.cmdRefresh.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdRefresh.ToolTipTitle = "RELOAD"
        '
        'Panel12
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel12, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(128, 5)
        Me.Panel12.TabIndex = 18
        '
        'CEPPOutStanding
        '
        Me.CEPPOutStanding.Dock = System.Windows.Forms.DockStyle.Top
        Me.CEPPOutStanding.Location = New System.Drawing.Point(0, 29)
        Me.CEPPOutStanding.Name = "CEPPOutStanding"
        Me.CEPPOutStanding.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEPPOutStanding.Properties.Appearance.Options.UseForeColor = True
        Me.CEPPOutStanding.Properties.Caption = "OutStanding"
        Me.CEPPOutStanding.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEPPOutStanding.Size = New System.Drawing.Size(128, 19)
        Me.CEPPOutStanding.TabIndex = 18
        '
        'Panel16
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel16, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 24)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(128, 5)
        Me.Panel16.TabIndex = 17
        '
        'CEPPAll
        '
        Me.CEPPAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.CEPPAll.EditValue = True
        Me.CEPPAll.Location = New System.Drawing.Point(0, 5)
        Me.CEPPAll.Name = "CEPPAll"
        Me.CEPPAll.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEPPAll.Properties.Appearance.Options.UseForeColor = True
        Me.CEPPAll.Properties.Caption = "Semua"
        Me.CEPPAll.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEPPAll.Size = New System.Drawing.Size(128, 19)
        Me.CEPPAll.TabIndex = 16
        '
        'Panel15
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel15, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(128, 5)
        Me.Panel15.TabIndex = 3
        '
        'Panel7
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel7, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(15, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(350, 100)
        Me.Panel7.TabIndex = 3
        '
        'Panel10
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel10, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel10.Controls.Add(Me.Kartu)
        Me.Panel10.Controls.Add(Me.LabelControl7)
        Me.Panel10.Controls.Add(Me.LabelControl8)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 50)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(350, 20)
        Me.Panel10.TabIndex = 6
        '
        'Kartu
        '
        Me.Kartu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Kartu.Location = New System.Drawing.Point(93, 0)
        Me.Kartu.Name = "Kartu"
        Me.Kartu.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Kartu.Properties.Appearance.Options.UseBackColor = True
        Me.Kartu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Kartu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("stat", "Name4")})
        Me.Kartu.Properties.NullText = ""
        Me.Kartu.Size = New System.Drawing.Size(233, 20)
        Me.Kartu.TabIndex = 31
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl7.Location = New System.Drawing.Point(83, 0)
        Me.LabelControl7.LookAndFeel.SkinName = "Black"
        Me.LabelControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.LabelControl7.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl7.TabIndex = 25
        Me.LabelControl7.Text = ":"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl8.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl8.LookAndFeel.SkinName = "Black"
        Me.LabelControl8.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "Kartu"
        '
        'Panel11
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel11, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 45)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(350, 5)
        Me.Panel11.TabIndex = 4
        '
        'Panel6
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel6, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel6.Controls.Add(Me.dteAkhir)
        Me.Panel6.Controls.Add(Me.LabelControl4)
        Me.Panel6.Controls.Add(Me.LabelControl6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 25)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(350, 20)
        Me.Panel6.TabIndex = 3
        '
        'dteAkhir
        '
        Me.dteAkhir.Dock = System.Windows.Forms.DockStyle.Left
        Me.dteAkhir.EditValue = Nothing
        Me.dteAkhir.Location = New System.Drawing.Point(93, 0)
        Me.dteAkhir.Name = "dteAkhir"
        Me.dteAkhir.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteAkhir.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteAkhir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteAkhir.Properties.Appearance.Options.UseBackColor = True
        Me.dteAkhir.Properties.Appearance.Options.UseFont = True
        Me.dteAkhir.Properties.Appearance.Options.UseTextOptions = True
        Me.dteAkhir.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dteAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteAkhir.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dteAkhir.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteAkhir.Properties.ValidateOnEnterKey = True
        Me.dteAkhir.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.dteAkhir.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteAkhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dteAkhir.Size = New System.Drawing.Size(175, 20)
        Me.dteAkhir.TabIndex = 26
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(83, 0)
        Me.LabelControl4.LookAndFeel.SkinName = "Black"
        Me.LabelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.LabelControl4.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = ":"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl6.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl6.LookAndFeel.SkinName = "Black"
        Me.LabelControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Tanggal Akhir"
        '
        'Panel9
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel9, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 20)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(350, 5)
        Me.Panel9.TabIndex = 2
        '
        'Panel5
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel5, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel5.Controls.Add(Me.dteAwal)
        Me.Panel5.Controls.Add(Me.LabelControl3)
        Me.Panel5.Controls.Add(Me.LabelControl2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(350, 20)
        Me.Panel5.TabIndex = 1
        '
        'dteAwal
        '
        Me.dteAwal.Dock = System.Windows.Forms.DockStyle.Left
        Me.dteAwal.EditValue = Nothing
        Me.dteAwal.Location = New System.Drawing.Point(93, 0)
        Me.dteAwal.Name = "dteAwal"
        Me.dteAwal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteAwal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteAwal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteAwal.Properties.Appearance.Options.UseBackColor = True
        Me.dteAwal.Properties.Appearance.Options.UseFont = True
        Me.dteAwal.Properties.Appearance.Options.UseTextOptions = True
        Me.dteAwal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dteAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteAwal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dteAwal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteAwal.Properties.ValidateOnEnterKey = True
        Me.dteAwal.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.dteAwal.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteAwal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dteAwal.Size = New System.Drawing.Size(175, 20)
        Me.dteAwal.TabIndex = 26
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(83, 0)
        Me.LabelControl3.LookAndFeel.SkinName = "Black"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.LabelControl3.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = ":"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl2.TabIndex = 24
        Me.LabelControl2.Text = "Tanggal Awal"
        '
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(15, 100)
        Me.Panel4.TabIndex = 2
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1, Me.PrintableComponentLink2})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GC1
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(20, 20, 20, 20)
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'PrintableComponentLink2
        '
        Me.PrintableComponentLink2.Component = Me.GC2
        '
        '
        '
        Me.PrintableComponentLink2.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink2.Landscape = True
        Me.PrintableComponentLink2.Margins = New System.Drawing.Printing.Margins(20, 20, 20, 20)
        Me.PrintableComponentLink2.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink2.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmMonKasBon
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 571)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonKasBon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMonKasBon"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlGcMaster.ResumeLayout(False)
        CType(Me.SplitContainerControlMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControlMaster.ResumeLayout(False)
        Me.pnlGC1.ResumeLayout(False)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlGC2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGC2.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVRekBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVPusBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.CEGV2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEGV1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        CType(Me.CEPPOutStanding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEPPAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.Kartu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.dteAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dteAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlGcMaster As System.Windows.Forms.Panel
    Friend WithEvents SplitContainerControlMaster As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlGC1 As System.Windows.Forms.Panel
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nokas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_akhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlGC2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_trans2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prev_nomor2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomor2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rekening2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVRekBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pusat_biaya2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVPusBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents keterangan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_trans2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents minusplus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents CEPPOutStanding As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents CEPPAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Kartu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents dteAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dteAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents CEGV2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents CEGV1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintableComponentLink2 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
