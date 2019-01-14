<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormTarifSupir
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormTarifSupir))
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.gcTarif = New DevExpress.XtraGrid.GridControl
        Me.gvTarif = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jns_kendaraan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckKendaraan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jarak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAngka = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.bensin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.solar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtNominal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.pnlTanggal = New System.Windows.Forms.Panel
        Me.dtpTanggal = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.gcTarif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTarif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNominal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTanggal.SuspendLayout()
        CType(Me.dtpTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlGrid)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.pnlTanggal)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(16, 24)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(960, 600)
        Me.pnl.TabIndex = 0
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.gcTarif)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 65)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(960, 510)
        Me.pnlGrid.TabIndex = 10
        '
        'gcTarif
        '
        Me.gcTarif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcTarif.Location = New System.Drawing.Point(0, 0)
        Me.gcTarif.MainView = Me.gvTarif
        Me.gcTarif.Name = "gcTarif"
        Me.gcTarif.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNominal, Me.lckKendaraan, Me.txtAngka})
        Me.gcTarif.Size = New System.Drawing.Size(960, 510)
        Me.gcTarif.TabIndex = 3
        Me.gcTarif.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTarif})
        '
        'gvTarif
        '
        Me.gvTarif.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.gvTarif.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.gvTarif.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvTarif.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvTarif.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvTarif.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.gvTarif.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.gvTarif.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvTarif.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvTarif.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvTarif.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.gvTarif.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvTarif.Appearance.Empty.Options.UseBackColor = True
        Me.gvTarif.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.gvTarif.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.gvTarif.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvTarif.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvTarif.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvTarif.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.gvTarif.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.gvTarif.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvTarif.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvTarif.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvTarif.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.gvTarif.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvTarif.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvTarif.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvTarif.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.gvTarif.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvTarif.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvTarif.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvTarif.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvTarif.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.gvTarif.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvTarif.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvTarif.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gvTarif.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvTarif.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gvTarif.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gvTarif.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvTarif.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvTarif.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvTarif.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.gvTarif.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.gvTarif.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvTarif.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvTarif.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.gvTarif.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.gvTarif.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvTarif.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvTarif.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvTarif.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.gvTarif.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvTarif.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvTarif.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvTarif.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.gvTarif.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.gvTarif.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvTarif.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvTarif.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvTarif.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gvTarif.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gvTarif.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvTarif.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvTarif.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvTarif.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.gvTarif.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.gvTarif.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvTarif.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.gvTarif.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvTarif.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gvTarif.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvTarif.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvTarif.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvTarif.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.OddRow.Options.UseBackColor = True
        Me.gvTarif.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvTarif.Appearance.OddRow.Options.UseForeColor = True
        Me.gvTarif.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvTarif.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvTarif.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.gvTarif.Appearance.Preview.Options.UseBackColor = True
        Me.gvTarif.Appearance.Preview.Options.UseFont = True
        Me.gvTarif.Appearance.Preview.Options.UseForeColor = True
        Me.gvTarif.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvTarif.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.Row.Options.UseBackColor = True
        Me.gvTarif.Appearance.Row.Options.UseForeColor = True
        Me.gvTarif.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.gvTarif.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvTarif.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvTarif.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvTarif.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.gvTarif.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gvTarif.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvTarif.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.gvTarif.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvTarif.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvTarif.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvTarif.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gvTarif.Appearance.VertLine.Options.UseBackColor = True
        Me.gvTarif.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kode, Me.nama, Me.jns_kendaraan, Me.jarak, Me.bensin, Me.solar, Me.jml_biaya, Me.Keterangan})
        Me.gvTarif.GridControl = Me.gcTarif
        Me.gvTarif.Name = "gvTarif"
        Me.gvTarif.NewItemRowText = "[Isi data baru disini...]"
        Me.gvTarif.OptionsBehavior.FocusLeaveOnTab = True
        Me.gvTarif.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gvTarif.OptionsCustomization.AllowColumnMoving = False
        Me.gvTarif.OptionsView.EnableAppearanceEvenRow = True
        Me.gvTarif.OptionsView.EnableAppearanceOddRow = True
        Me.gvTarif.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvTarif.OptionsView.ShowDetailButtons = False
        Me.gvTarif.OptionsView.ShowGroupPanel = False
        Me.gvTarif.OptionsView.ShowIndicator = False
        '
        'kode
        '
        Me.kode.Caption = "Kode"
        Me.kode.FieldName = "kode"
        Me.kode.Name = "kode"
        '
        'nama
        '
        Me.nama.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nama.AppearanceHeader.Options.UseFont = True
        Me.nama.AppearanceHeader.Options.UseTextOptions = True
        Me.nama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama.Caption = "Nama"
        Me.nama.FieldName = "nama"
        Me.nama.Name = "nama"
        Me.nama.Visible = True
        Me.nama.VisibleIndex = 0
        '
        'jns_kendaraan
        '
        Me.jns_kendaraan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jns_kendaraan.AppearanceHeader.Options.UseFont = True
        Me.jns_kendaraan.AppearanceHeader.Options.UseTextOptions = True
        Me.jns_kendaraan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jns_kendaraan.Caption = "Jenis Kendaraan"
        Me.jns_kendaraan.ColumnEdit = Me.lckKendaraan
        Me.jns_kendaraan.FieldName = "jns_kendaraan"
        Me.jns_kendaraan.Name = "jns_kendaraan"
        Me.jns_kendaraan.Visible = True
        Me.jns_kendaraan.VisibleIndex = 1
        '
        'lckKendaraan
        '
        Me.lckKendaraan.AutoHeight = False
        Me.lckKendaraan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckKendaraan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckKendaraan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Name4")})
        Me.lckKendaraan.Name = "lckKendaraan"
        Me.lckKendaraan.NullText = "[Kosong]"
        Me.lckKendaraan.ShowFooter = False
        Me.lckKendaraan.ShowHeader = False
        Me.lckKendaraan.ShowPopupShadow = False
        Me.lckKendaraan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckKendaraan.ValidateOnEnterKey = True
        '
        'jarak
        '
        Me.jarak.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jarak.AppearanceHeader.Options.UseFont = True
        Me.jarak.AppearanceHeader.Options.UseTextOptions = True
        Me.jarak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jarak.Caption = "Jarak"
        Me.jarak.ColumnEdit = Me.txtAngka
        Me.jarak.FieldName = "jarak"
        Me.jarak.Name = "jarak"
        Me.jarak.Visible = True
        Me.jarak.VisibleIndex = 2
        '
        'txtAngka
        '
        Me.txtAngka.AutoHeight = False
        Me.txtAngka.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtAngka.DisplayFormat.FormatString = "n2"
        Me.txtAngka.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAngka.EditFormat.FormatString = "n2"
        Me.txtAngka.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAngka.Mask.EditMask = "n2"
        Me.txtAngka.Mask.UseMaskAsDisplayFormat = True
        Me.txtAngka.Name = "txtAngka"
        '
        'bensin
        '
        Me.bensin.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bensin.AppearanceHeader.Options.UseFont = True
        Me.bensin.AppearanceHeader.Options.UseTextOptions = True
        Me.bensin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bensin.Caption = "Bensin"
        Me.bensin.ColumnEdit = Me.txtAngka
        Me.bensin.FieldName = "bensin"
        Me.bensin.Name = "bensin"
        Me.bensin.Visible = True
        Me.bensin.VisibleIndex = 3
        '
        'solar
        '
        Me.solar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.solar.AppearanceHeader.Options.UseFont = True
        Me.solar.AppearanceHeader.Options.UseTextOptions = True
        Me.solar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.solar.Caption = "Solar"
        Me.solar.ColumnEdit = Me.txtAngka
        Me.solar.FieldName = "solar"
        Me.solar.Name = "solar"
        Me.solar.Visible = True
        Me.solar.VisibleIndex = 4
        '
        'jml_biaya
        '
        Me.jml_biaya.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_biaya.AppearanceHeader.Options.UseFont = True
        Me.jml_biaya.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_biaya.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_biaya.Caption = "Jumlah Biaya"
        Me.jml_biaya.ColumnEdit = Me.txtAngka
        Me.jml_biaya.FieldName = "jml_biaya"
        Me.jml_biaya.Name = "jml_biaya"
        Me.jml_biaya.Visible = True
        Me.jml_biaya.VisibleIndex = 5
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 6
        '
        'txtNominal
        '
        Me.txtNominal.AutoHeight = False
        Me.txtNominal.DisplayFormat.FormatString = "n2"
        Me.txtNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtNominal.EditFormat.FormatString = "n2"
        Me.txtNominal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNominal.Mask.EditMask = "n2"
        Me.txtNominal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNominal.Mask.UseMaskAsDisplayFormat = True
        Me.txtNominal.Name = "txtNominal"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(960, 5)
        Me.Panel5.TabIndex = 9
        '
        'pnlTanggal
        '
        Me.pnlTanggal.Controls.Add(Me.dtpTanggal)
        Me.pnlTanggal.Controls.Add(Me.LabelControl2)
        Me.pnlTanggal.Controls.Add(Me.LabelControl1)
        Me.pnlTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTanggal.Location = New System.Drawing.Point(0, 40)
        Me.pnlTanggal.Name = "pnlTanggal"
        Me.pnlTanggal.Size = New System.Drawing.Size(960, 20)
        Me.pnlTanggal.TabIndex = 8
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpTanggal.EditValue = Nothing
        Me.dtpTanggal.EnterMoveNextControl = True
        Me.dtpTanggal.Location = New System.Drawing.Point(114, 0)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.dtpTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTanggal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dtpTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtpTanggal.Properties.ShowPopupShadow = False
        Me.dtpTanggal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtpTanggal.Properties.ValidateOnEnterKey = True
        Me.dtpTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpTanggal.Size = New System.Drawing.Size(165, 20)
        Me.dtpTanggal.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(104, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl2.TabIndex = 2
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
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl1.Size = New System.Drawing.Size(104, 20)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Tanggal Efektif"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 35)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(960, 5)
        Me.Panel4.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 575)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(960, 25)
        Me.Panel2.TabIndex = 6
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(442, 0)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Hapus"
        Me.SimpleButton2.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(312, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Simpan"
        Me.SimpleButton1.Visible = False
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
        Me.Panel1.Size = New System.Drawing.Size(960, 35)
        Me.Panel1.TabIndex = 5
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(40, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(459, 33)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "FORM TARIF BIAYA SOPIR"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 33)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'aFormTarifSupir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 626)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormTarifSupir"
        Me.Text = "aFormTarifSupir"
        Me.pnl.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.gcTarif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTarif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNominal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTanggal.ResumeLayout(False)
        CType(Me.dtpTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pnlTanggal As System.Windows.Forms.Panel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents gcTarif As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTarif As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jns_kendaraan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckKendaraan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jarak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bensin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents solar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNominal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAngka As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
