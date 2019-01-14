<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormMonNeracaSaldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormMonNeracaSaldo))
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.pnlFill = New DevExpress.XtraEditors.PanelControl
        Me.pnlBotttom = New DevExpress.XtraEditors.PanelControl
        Me.gcNeracaSaldo = New DevExpress.XtraGrid.GridControl
        Me.gvNeracaSaldo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookRek = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.awal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlTop = New DevExpress.XtraEditors.PanelControl
        Me.pnlRek = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lckRek = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.Rekening = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.pnlPeriode = New System.Windows.Forms.Panel
        Me.lckPeriode = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.pnlFill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFill.SuspendLayout()
        CType(Me.pnlBotttom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotttom.SuspendLayout()
        CType(Me.gcNeracaSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNeracaSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookRek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.pnlRek.SuspendLayout()
        CType(Me.lckRek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPeriode.SuspendLayout()
        CType(Me.lckPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlFill)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.pnlHeader)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(957, 475)
        Me.pnl.TabIndex = 0
        '
        'pnlFill
        '
        Me.pnlFill.Controls.Add(Me.pnlBotttom)
        Me.pnlFill.Controls.Add(Me.pnlTop)
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFill.Location = New System.Drawing.Point(2, 37)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(953, 411)
        Me.pnlFill.TabIndex = 3
        '
        'pnlBotttom
        '
        Me.pnlBotttom.Controls.Add(Me.gcNeracaSaldo)
        Me.pnlBotttom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBotttom.Location = New System.Drawing.Point(2, 57)
        Me.pnlBotttom.Name = "pnlBotttom"
        Me.pnlBotttom.Size = New System.Drawing.Size(949, 352)
        Me.pnlBotttom.TabIndex = 3
        '
        'gcNeracaSaldo
        '
        Me.gcNeracaSaldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcNeracaSaldo.Location = New System.Drawing.Point(2, 2)
        Me.gcNeracaSaldo.MainView = Me.gvNeracaSaldo
        Me.gcNeracaSaldo.Name = "gcNeracaSaldo"
        Me.gcNeracaSaldo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookRek, Me.lookKartu})
        Me.gcNeracaSaldo.Size = New System.Drawing.Size(945, 348)
        Me.gcNeracaSaldo.TabIndex = 0
        Me.gcNeracaSaldo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNeracaSaldo})
        '
        'gvNeracaSaldo
        '
        Me.gvNeracaSaldo.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvNeracaSaldo.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvNeracaSaldo.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvNeracaSaldo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvNeracaSaldo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.kd_buku_besar, Me.kartu, Me.awal, Me.debet, Me.kredit, Me.akhir})
        Me.gvNeracaSaldo.GridControl = Me.gcNeracaSaldo
        Me.gvNeracaSaldo.Name = "gvNeracaSaldo"
        Me.gvNeracaSaldo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvNeracaSaldo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvNeracaSaldo.OptionsBehavior.Editable = False
        Me.gvNeracaSaldo.OptionsBehavior.ReadOnly = True
        Me.gvNeracaSaldo.OptionsCustomization.AllowGroup = False
        Me.gvNeracaSaldo.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvNeracaSaldo.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvNeracaSaldo.OptionsView.EnableAppearanceEvenRow = True
        Me.gvNeracaSaldo.OptionsView.EnableAppearanceOddRow = True
        Me.gvNeracaSaldo.OptionsView.ShowDetailButtons = False
        Me.gvNeracaSaldo.OptionsView.ShowFooter = True
        Me.gvNeracaSaldo.OptionsView.ShowGroupPanel = False
        Me.gvNeracaSaldo.OptionsView.ShowIndicator = False
        '
        'nomer
        '
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.FixedWidth = True
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 30
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.Caption = "Rekening"
        Me.kd_buku_besar.ColumnEdit = Me.lookRek
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 1
        Me.kd_buku_besar.Width = 122
        '
        'lookRek
        '
        Me.lookRek.AutoHeight = False
        Me.lookRek.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookRek.Name = "lookRek"
        '
        'kartu
        '
        Me.kartu.Caption = "Kartu"
        Me.kartu.ColumnEdit = Me.lookKartu
        Me.kartu.FieldName = "kartu"
        Me.kartu.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.kartu.Name = "kartu"
        Me.kartu.Visible = True
        Me.kartu.VisibleIndex = 2
        Me.kartu.Width = 122
        '
        'lookKartu
        '
        Me.lookKartu.AutoHeight = False
        Me.lookKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookKartu.Name = "lookKartu"
        '
        'awal
        '
        Me.awal.Caption = "Saldo Awal"
        Me.awal.DisplayFormat.FormatString = "n2"
        Me.awal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.awal.FieldName = "awal"
        Me.awal.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.awal.Name = "awal"
        Me.awal.SummaryItem.DisplayFormat = "{0:n2}"
        Me.awal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.awal.Visible = True
        Me.awal.VisibleIndex = 3
        Me.awal.Width = 122
        '
        'debet
        '
        Me.debet.Caption = "Debet"
        Me.debet.DisplayFormat.FormatString = "n2"
        Me.debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.debet.FieldName = "debet"
        Me.debet.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.debet.Name = "debet"
        Me.debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.debet.Visible = True
        Me.debet.VisibleIndex = 4
        Me.debet.Width = 122
        '
        'kredit
        '
        Me.kredit.Caption = "Kredit"
        Me.kredit.DisplayFormat.FormatString = "n2"
        Me.kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.kredit.FieldName = "kredit"
        Me.kredit.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.kredit.Name = "kredit"
        Me.kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.kredit.Visible = True
        Me.kredit.VisibleIndex = 5
        Me.kredit.Width = 122
        '
        'akhir
        '
        Me.akhir.Caption = "Saldo Akhir"
        Me.akhir.DisplayFormat.FormatString = "n2"
        Me.akhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.akhir.FieldName = "akhir"
        Me.akhir.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.akhir.Name = "akhir"
        Me.akhir.SummaryItem.DisplayFormat = "{0:n2}"
        Me.akhir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.akhir.Visible = True
        Me.akhir.VisibleIndex = 6
        Me.akhir.Width = 131
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.pnlRek)
        Me.pnlTop.Controls.Add(Me.PanelControl2)
        Me.pnlTop.Controls.Add(Me.pnlPeriode)
        Me.pnlTop.Controls.Add(Me.PanelControl1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(2, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(949, 55)
        Me.pnlTop.TabIndex = 2
        '
        'pnlRek
        '
        Me.pnlRek.Controls.Add(Me.btnRefresh)
        Me.pnlRek.Controls.Add(Me.Panel1)
        Me.pnlRek.Controls.Add(Me.lckRek)
        Me.pnlRek.Controls.Add(Me.LabelControl3)
        Me.pnlRek.Controls.Add(Me.Rekening)
        Me.pnlRek.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRek.Location = New System.Drawing.Point(2, 32)
        Me.pnlRek.Name = "pnlRek"
        Me.pnlRek.Size = New System.Drawing.Size(945, 20)
        Me.pnlRek.TabIndex = 5
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.Location = New System.Drawing.Point(425, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 20)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(420, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 20)
        Me.Panel1.TabIndex = 3
        '
        'lckRek
        '
        Me.lckRek.Dock = System.Windows.Forms.DockStyle.Left
        Me.lckRek.EnterMoveNextControl = True
        Me.lckRek.Location = New System.Drawing.Point(70, 0)
        Me.lckRek.Name = "lckRek"
        Me.lckRek.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckRek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckRek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Rekening")})
        Me.lckRek.Properties.NullText = "[Kosong]"
        Me.lckRek.Properties.ShowFooter = False
        Me.lckRek.Properties.ShowHeader = False
        Me.lckRek.Properties.ShowPopupShadow = False
        Me.lckRek.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckRek.Properties.ValidateOnEnterKey = True
        Me.lckRek.Size = New System.Drawing.Size(350, 20)
        Me.lckRek.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(65, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(5, 20)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = ":"
        '
        'Rekening
        '
        Me.Rekening.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Rekening.Appearance.Options.UseFont = True
        Me.Rekening.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Rekening.Dock = System.Windows.Forms.DockStyle.Left
        Me.Rekening.Location = New System.Drawing.Point(0, 0)
        Me.Rekening.Name = "Rekening"
        Me.Rekening.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Rekening.Size = New System.Drawing.Size(65, 20)
        Me.Rekening.TabIndex = 0
        Me.Rekening.Text = "Rekening"
        '
        'PanelControl2
        '
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(2, 27)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(945, 5)
        Me.PanelControl2.TabIndex = 4
        '
        'pnlPeriode
        '
        Me.pnlPeriode.Controls.Add(Me.lckPeriode)
        Me.pnlPeriode.Controls.Add(Me.LabelControl2)
        Me.pnlPeriode.Controls.Add(Me.LabelControl1)
        Me.pnlPeriode.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPeriode.Location = New System.Drawing.Point(2, 7)
        Me.pnlPeriode.Name = "pnlPeriode"
        Me.pnlPeriode.Size = New System.Drawing.Size(945, 20)
        Me.pnlPeriode.TabIndex = 3
        '
        'lckPeriode
        '
        Me.lckPeriode.Dock = System.Windows.Forms.DockStyle.Left
        Me.lckPeriode.EnterMoveNextControl = True
        Me.lckPeriode.Location = New System.Drawing.Point(70, 0)
        Me.lckPeriode.Name = "lckPeriode"
        Me.lckPeriode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckPeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckPeriode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lckPeriode.Properties.NullText = "[Kosong]"
        Me.lckPeriode.Properties.ShowFooter = False
        Me.lckPeriode.Properties.ShowHeader = False
        Me.lckPeriode.Properties.ShowPopupShadow = False
        Me.lckPeriode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckPeriode.Properties.ValidateOnEnterKey = True
        Me.lckPeriode.Size = New System.Drawing.Size(180, 20)
        Me.lckPeriode.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(65, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(5, 20)
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
        Me.LabelControl1.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Periode"
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(945, 5)
        Me.PanelControl1.TabIndex = 2
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Maroon
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(2, 448)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(953, 25)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Maroon
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.pnlHeader.ForeColor = System.Drawing.Color.Gold
        Me.pnlHeader.Location = New System.Drawing.Point(2, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(953, 35)
        Me.pnlHeader.TabIndex = 0
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(459, 35)
        Me.lblJudul.TabIndex = 9
        Me.lblJudul.Text = "MONITORING REKENING NERACA SALDO"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'aFormMonNeracaSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 475)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormMonNeracaSaldo"
        Me.Text = "aFormMonNeracaSaldo"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.pnlFill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFill.ResumeLayout(False)
        CType(Me.pnlBotttom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotttom.ResumeLayout(False)
        CType(Me.gcNeracaSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNeracaSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookRek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlRek.ResumeLayout(False)
        CType(Me.lckRek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPeriode.ResumeLayout(False)
        CType(Me.lckPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents pnlFill As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlBotttom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcNeracaSaldo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNeracaSaldo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookRek As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents awal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlRek As System.Windows.Forms.Panel
    Friend WithEvents lckRek As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Rekening As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlPeriode As System.Windows.Forms.Panel
    Friend WithEvents lckPeriode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
