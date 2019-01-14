<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdMasterBOMService1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdMasterBOMService1))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC_Bahan = New DevExpress.XtraGrid.GridControl
        Me.GV_BOMService = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_service = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_dokumen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.waktu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prioritas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ColToleransi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LE_Barang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Ck_Prioritas = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GC_Bahan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_BOMService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LE_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_Prioritas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(920, 432)
        Me.pnl.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.GC_Bahan)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 34)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(920, 398)
        Me.Panel5.TabIndex = 6
        '
        'GC_Bahan
        '
        Me.GC_Bahan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Bahan.Location = New System.Drawing.Point(0, 0)
        Me.GC_Bahan.MainView = Me.GV_BOMService
        Me.GC_Bahan.Name = "GC_Bahan"
        Me.GC_Bahan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LE_Barang, Me.RepStatus, Me.Ck_Prioritas})
        Me.GC_Bahan.Size = New System.Drawing.Size(920, 398)
        Me.GC_Bahan.TabIndex = 0
        Me.GC_Bahan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_BOMService})
        '
        'GV_BOMService
        '
        Me.GV_BOMService.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BOMService.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BOMService.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_BOMService.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_BOMService.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV_BOMService.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_BOMService.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BOMService.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_BOMService.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_BOMService.Appearance.Empty.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BOMService.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BOMService.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_BOMService.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_BOMService.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_BOMService.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV_BOMService.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_BOMService.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV_BOMService.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_BOMService.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BOMService.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BOMService.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_BOMService.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BOMService.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BOMService.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_BOMService.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BOMService.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BOMService.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_BOMService.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_BOMService.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BOMService.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BOMService.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_BOMService.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_BOMService.Appearance.GroupRow.Options.UseFont = True
        Me.GV_BOMService.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BOMService.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BOMService.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BOMService.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_BOMService.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BOMService.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_BOMService.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_BOMService.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_BOMService.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_BOMService.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_BOMService.Appearance.Preview.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.Preview.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_BOMService.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_BOMService.Appearance.Row.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.Row.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_BOMService.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV_BOMService.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_BOMService.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_BOMService.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_BOMService.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_BOMService.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_BOMService.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_service, Me.nama, Me.no_dokumen, Me.waktu, Me.prioritas, Me.ColToleransi})
        Me.GV_BOMService.GridControl = Me.GC_Bahan
        Me.GV_BOMService.Name = "GV_BOMService"
        Me.GV_BOMService.OptionsPrint.UsePrintStyles = True
        Me.GV_BOMService.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_BOMService.OptionsView.EnableAppearanceOddRow = True
        Me.GV_BOMService.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_BOMService.OptionsView.ShowGroupPanel = False
        Me.GV_BOMService.OptionsView.ShowViewCaption = True
        Me.GV_BOMService.ViewCaption = "BOM SERVICE"
        '
        'kd_service
        '
        Me.kd_service.AppearanceCell.Options.UseTextOptions = True
        Me.kd_service.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.kd_service.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_service.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_service.Caption = "Kode Service"
        Me.kd_service.FieldName = "kd_service"
        Me.kd_service.Name = "kd_service"
        Me.kd_service.OptionsColumn.AllowEdit = False
        Me.kd_service.Width = 185
        '
        'nama
        '
        Me.nama.AppearanceCell.Options.UseTextOptions = True
        Me.nama.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama.AppearanceHeader.Options.UseTextOptions = True
        Me.nama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama.Caption = "Nama Service"
        Me.nama.FieldName = "nama_service"
        Me.nama.Name = "nama"
        Me.nama.Visible = True
        Me.nama.VisibleIndex = 0
        Me.nama.Width = 312
        '
        'no_dokumen
        '
        Me.no_dokumen.AppearanceCell.Options.UseTextOptions = True
        Me.no_dokumen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.no_dokumen.AppearanceHeader.Options.UseTextOptions = True
        Me.no_dokumen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_dokumen.Caption = "No Dokumen"
        Me.no_dokumen.FieldName = "no_dokumen"
        Me.no_dokumen.Name = "no_dokumen"
        Me.no_dokumen.Visible = True
        Me.no_dokumen.VisibleIndex = 1
        Me.no_dokumen.Width = 180
        '
        'waktu
        '
        Me.waktu.AppearanceCell.Options.UseTextOptions = True
        Me.waktu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.waktu.AppearanceHeader.Options.UseTextOptions = True
        Me.waktu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.waktu.Caption = "Waktu"
        Me.waktu.DisplayFormat.FormatString = "N2"
        Me.waktu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.waktu.FieldName = "waktu"
        Me.waktu.Name = "waktu"
        Me.waktu.Visible = True
        Me.waktu.VisibleIndex = 2
        Me.waktu.Width = 154
        '
        'prioritas
        '
        Me.prioritas.AppearanceHeader.Options.UseTextOptions = True
        Me.prioritas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.prioritas.Caption = "Quality Concerns"
        Me.prioritas.ColumnEdit = Me.RepStatus
        Me.prioritas.FieldName = "QC"
        Me.prioritas.Name = "prioritas"
        Me.prioritas.Visible = True
        Me.prioritas.VisibleIndex = 3
        Me.prioritas.Width = 109
        '
        'RepStatus
        '
        Me.RepStatus.AutoHeight = False
        Me.RepStatus.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepStatus.DisplayValueChecked = "Y"
        Me.RepStatus.DisplayValueUnchecked = "T"
        Me.RepStatus.Name = "RepStatus"
        Me.RepStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepStatus.ValueChecked = "Y"
        Me.RepStatus.ValueUnchecked = "T"
        '
        'ColToleransi
        '
        Me.ColToleransi.AppearanceHeader.Options.UseTextOptions = True
        Me.ColToleransi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColToleransi.Caption = "Toleransi QC(Tahun)"
        Me.ColToleransi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColToleransi.FieldName = "toleransi"
        Me.ColToleransi.Name = "ColToleransi"
        Me.ColToleransi.Visible = True
        Me.ColToleransi.VisibleIndex = 4
        Me.ColToleransi.Width = 144
        '
        'LE_Barang
        '
        Me.LE_Barang.AutoHeight = False
        Me.LE_Barang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LE_Barang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LE_Barang.DisplayMember = "Nama_Barang"
        Me.LE_Barang.Name = "LE_Barang"
        Me.LE_Barang.NullText = "Nama Barang"
        Me.LE_Barang.ValueMember = "Kode_Barang"
        '
        'Ck_Prioritas
        '
        Me.Ck_Prioritas.AutoHeight = False
        Me.Ck_Prioritas.Name = "Ck_Prioritas"
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Maroon
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox1)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(920, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(271, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MASTER BOM SERVICE"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmProdMasterBOMService1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 456)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmProdMasterBOMService1"
        Me.pnl.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC_Bahan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_BOMService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LE_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_Prioritas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC_Bahan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_BOMService As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LE_Barang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_dokumen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents waktu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prioritas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ck_Prioritas As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColToleransi As DevExpress.XtraGrid.Columns.GridColumn
End Class
