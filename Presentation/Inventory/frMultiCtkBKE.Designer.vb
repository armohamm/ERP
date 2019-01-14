<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMultiCtkBKE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frMultiCtkBKE))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.cetak_ke = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sudah_sj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.CE_ctk_ulang = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.GcMultiBKE = New DevExpress.XtraGrid.GridControl
        Me.GvMultiBKE = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Created_By = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_Polisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Sopir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Kenek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cetak_ulang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Update_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_deselect = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Btn_pilih = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblJudul = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl = New System.Windows.Forms.Panel
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcMultiBKE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMultiBKE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'cetak_ke
        '
        Me.cetak_ke.AppearanceCell.Options.UseTextOptions = True
        Me.cetak_ke.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.cetak_ke.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cetak_ke.AppearanceHeader.Options.UseFont = True
        Me.cetak_ke.AppearanceHeader.Options.UseTextOptions = True
        Me.cetak_ke.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cetak_ke.Caption = "Jml Ctk"
        Me.cetak_ke.FieldName = "cetak_ke"
        Me.cetak_ke.Name = "cetak_ke"
        Me.cetak_ke.OptionsColumn.AllowEdit = False
        Me.cetak_ke.OptionsColumn.ReadOnly = True
        Me.cetak_ke.Visible = True
        Me.cetak_ke.VisibleIndex = 7
        Me.cetak_ke.Width = 60
        '
        'sudah_sj
        '
        Me.sudah_sj.AppearanceCell.Options.UseTextOptions = True
        Me.sudah_sj.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sudah_sj.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sudah_sj.AppearanceHeader.Options.UseFont = True
        Me.sudah_sj.AppearanceHeader.Options.UseTextOptions = True
        Me.sudah_sj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sudah_sj.Caption = "SJ"
        Me.sudah_sj.FieldName = "sudah_sj"
        Me.sudah_sj.Name = "sudah_sj"
        Me.sudah_sj.OptionsColumn.AllowEdit = False
        Me.sudah_sj.OptionsColumn.ReadOnly = True
        Me.sudah_sj.Visible = True
        Me.sudah_sj.VisibleIndex = 6
        Me.sudah_sj.Width = 40
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = ""
        '
        'CE_ctk_ulang
        '
        Me.CE_ctk_ulang.AutoHeight = False
        Me.CE_ctk_ulang.Name = "CE_ctk_ulang"
        Me.CE_ctk_ulang.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CE_ctk_ulang.ValueChecked = "Y"
        Me.CE_ctk_ulang.ValueGrayed = "T"
        Me.CE_ctk_ulang.ValueUnchecked = "T"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcMultiBKE
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
        'GcMultiBKE
        '
        Me.GcMultiBKE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMultiBKE.Location = New System.Drawing.Point(0, 79)
        Me.GcMultiBKE.LookAndFeel.SkinName = "The Asphalt World"
        Me.GcMultiBKE.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GcMultiBKE.MainView = Me.GvMultiBKE
        Me.GcMultiBKE.Name = "GcMultiBKE"
        Me.GcMultiBKE.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.CE_ctk_ulang})
        Me.GcMultiBKE.Size = New System.Drawing.Size(792, 298)
        Me.GcMultiBKE.TabIndex = 7
        Me.GcMultiBKE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMultiBKE})
        '
        'GvMultiBKE
        '
        Me.GvMultiBKE.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMultiBKE.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMultiBKE.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvMultiBKE.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMultiBKE.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GvMultiBKE.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMultiBKE.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMultiBKE.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvMultiBKE.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GvMultiBKE.Appearance.Empty.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMultiBKE.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMultiBKE.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvMultiBKE.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvMultiBKE.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GvMultiBKE.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GvMultiBKE.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvMultiBKE.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GvMultiBKE.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvMultiBKE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMultiBKE.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMultiBKE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvMultiBKE.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMultiBKE.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMultiBKE.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvMultiBKE.Appearance.GroupButton.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMultiBKE.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMultiBKE.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvMultiBKE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvMultiBKE.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMultiBKE.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMultiBKE.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GvMultiBKE.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvMultiBKE.Appearance.GroupRow.Options.UseFont = True
        Me.GvMultiBKE.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMultiBKE.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMultiBKE.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMultiBKE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvMultiBKE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMultiBKE.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMultiBKE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvMultiBKE.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GvMultiBKE.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.OddRow.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.OddRow.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMultiBKE.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvMultiBKE.Appearance.Preview.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.Preview.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GvMultiBKE.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvMultiBKE.Appearance.Row.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.Row.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GvMultiBKE.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GvMultiBKE.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvMultiBKE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvMultiBKE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvMultiBKE.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvMultiBKE.Appearance.VertLine.Options.UseBackColor = True
        Me.GvMultiBKE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.tgl_trans, Me.no_trans, Me.no_ref, Me.Last_Created_By, Me.No_Polisi, Me.Nama_Sopir, Me.Nama_Kenek, Me.sudah_sj, Me.cetak_ke, Me.cetak_ulang, Me.Last_Update_Date})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[sudah_sj]  = 'NOT'"
        Me.GvMultiBKE.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GvMultiBKE.GridControl = Me.GcMultiBKE
        Me.GvMultiBKE.Name = "GvMultiBKE"
        Me.GvMultiBKE.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMultiBKE.OptionsView.EnableAppearanceOddRow = True
        Me.GvMultiBKE.OptionsView.ShowFooter = True
        Me.GvMultiBKE.OptionsView.ShowViewCaption = True
        Me.GvMultiBKE.ViewCaption = "CETAK ULANG DAFTAR PENGIRIMAN BARANG"
        '
        'nomer
        '
        Me.nomer.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nomer.AppearanceHeader.Options.UseFont = True
        Me.nomer.AppearanceHeader.Options.UseTextOptions = True
        Me.nomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.AllowEdit = False
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Width = 36
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceCell.Options.UseTextOptions = True
        Me.tgl_trans.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_trans.AppearanceHeader.Options.UseFont = True
        Me.tgl_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans.Caption = "Tgl Trans"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 0
        Me.tgl_trans.Width = 54
        '
        'no_trans
        '
        Me.no_trans.AppearanceCell.Options.UseTextOptions = True
        Me.no_trans.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_trans.AppearanceHeader.Options.UseFont = True
        Me.no_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.no_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_trans.Caption = "No Trans"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.AllowEdit = False
        Me.no_trans.OptionsColumn.ReadOnly = True
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 1
        Me.no_trans.Width = 90
        '
        'no_ref
        '
        Me.no_ref.AppearanceCell.Options.UseTextOptions = True
        Me.no_ref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_ref.AppearanceHeader.Options.UseFont = True
        Me.no_ref.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref.Caption = "No Kirim"
        Me.no_ref.FieldName = "no_ref"
        Me.no_ref.Name = "no_ref"
        Me.no_ref.OptionsColumn.AllowEdit = False
        Me.no_ref.OptionsColumn.ReadOnly = True
        Me.no_ref.Visible = True
        Me.no_ref.VisibleIndex = 2
        Me.no_ref.Width = 90
        '
        'Last_Created_By
        '
        Me.Last_Created_By.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Last_Created_By.AppearanceHeader.Options.UseFont = True
        Me.Last_Created_By.AppearanceHeader.Options.UseTextOptions = True
        Me.Last_Created_By.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Last_Created_By.Caption = "Nama User"
        Me.Last_Created_By.FieldName = "Last_Created_By"
        Me.Last_Created_By.Name = "Last_Created_By"
        Me.Last_Created_By.OptionsColumn.AllowEdit = False
        Me.Last_Created_By.OptionsColumn.ReadOnly = True
        Me.Last_Created_By.Visible = True
        Me.Last_Created_By.VisibleIndex = 9
        Me.Last_Created_By.Width = 80
        '
        'No_Polisi
        '
        Me.No_Polisi.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.No_Polisi.AppearanceHeader.Options.UseFont = True
        Me.No_Polisi.AppearanceHeader.Options.UseTextOptions = True
        Me.No_Polisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_Polisi.Caption = "No Polisi"
        Me.No_Polisi.FieldName = "No_Polisi"
        Me.No_Polisi.Name = "No_Polisi"
        Me.No_Polisi.OptionsColumn.AllowEdit = False
        Me.No_Polisi.OptionsColumn.ReadOnly = True
        Me.No_Polisi.Visible = True
        Me.No_Polisi.VisibleIndex = 3
        Me.No_Polisi.Width = 80
        '
        'Nama_Sopir
        '
        Me.Nama_Sopir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Nama_Sopir.AppearanceHeader.Options.UseFont = True
        Me.Nama_Sopir.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Sopir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Sopir.Caption = "Sopir"
        Me.Nama_Sopir.FieldName = "Nama_Sopir"
        Me.Nama_Sopir.Name = "Nama_Sopir"
        Me.Nama_Sopir.OptionsColumn.AllowEdit = False
        Me.Nama_Sopir.OptionsColumn.ReadOnly = True
        Me.Nama_Sopir.Visible = True
        Me.Nama_Sopir.VisibleIndex = 4
        Me.Nama_Sopir.Width = 80
        '
        'Nama_Kenek
        '
        Me.Nama_Kenek.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Nama_Kenek.AppearanceHeader.Options.UseFont = True
        Me.Nama_Kenek.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Kenek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Kenek.Caption = "Kerani"
        Me.Nama_Kenek.FieldName = "Nama_Kenek"
        Me.Nama_Kenek.Name = "Nama_Kenek"
        Me.Nama_Kenek.OptionsColumn.AllowEdit = False
        Me.Nama_Kenek.OptionsColumn.ReadOnly = True
        Me.Nama_Kenek.Visible = True
        Me.Nama_Kenek.VisibleIndex = 5
        Me.Nama_Kenek.Width = 80
        '
        'cetak_ulang
        '
        Me.cetak_ulang.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cetak_ulang.AppearanceHeader.Options.UseFont = True
        Me.cetak_ulang.AppearanceHeader.Options.UseTextOptions = True
        Me.cetak_ulang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cetak_ulang.Caption = "Ctk Ulang"
        Me.cetak_ulang.ColumnEdit = Me.CE_ctk_ulang
        Me.cetak_ulang.FieldName = "cetak_ulang"
        Me.cetak_ulang.Name = "cetak_ulang"
        Me.cetak_ulang.Visible = True
        Me.cetak_ulang.VisibleIndex = 8
        Me.cetak_ulang.Width = 50
        '
        'Last_Update_Date
        '
        Me.Last_Update_Date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Last_Update_Date.AppearanceHeader.Options.UseFont = True
        Me.Last_Update_Date.AppearanceHeader.Options.UseTextOptions = True
        Me.Last_Update_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Last_Update_Date.Caption = "Tgl Cetak"
        Me.Last_Update_Date.DisplayFormat.FormatString = "dd/MMM/yyyy hh:mm tt"
        Me.Last_Update_Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Last_Update_Date.FieldName = "Last_Update_Date"
        Me.Last_Update_Date.Name = "Last_Update_Date"
        Me.Last_Update_Date.OptionsColumn.AllowEdit = False
        Me.Last_Update_Date.Visible = True
        Me.Last_Update_Date.VisibleIndex = 10
        Me.Last_Update_Date.Width = 67
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.tglsampai)
        Me.Panel6.Controls.Add(Me.tglDari)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(121, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(299, 42)
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
        Me.Panel3.Size = New System.Drawing.Size(792, 42)
        Me.Panel3.TabIndex = 5
        '
        'btn_deselect
        '
        Me.btn_deselect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_deselect.ImageIndex = 0
        Me.btn_deselect.ImageList = Me.img
        Me.btn_deselect.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btn_deselect.Location = New System.Drawing.Point(574, 0)
        Me.btn_deselect.LookAndFeel.SkinName = "The Asphalt World"
        Me.btn_deselect.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_deselect.Name = "btn_deselect"
        Me.btn_deselect.Size = New System.Drawing.Size(109, 42)
        Me.btn_deselect.TabIndex = 39
        Me.btn_deselect.Text = "Deselect All"
        Me.btn_deselect.ToolTip = "Celar Filter"
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
        'Btn_pilih
        '
        Me.Btn_pilih.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_pilih.ImageIndex = 3
        Me.Btn_pilih.ImageList = Me.img
        Me.Btn_pilih.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Btn_pilih.Location = New System.Drawing.Point(683, 0)
        Me.Btn_pilih.LookAndFeel.SkinName = "The Asphalt World"
        Me.Btn_pilih.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Btn_pilih.Name = "Btn_pilih"
        Me.Btn_pilih.Size = New System.Drawing.Size(109, 42)
        Me.Btn_pilih.TabIndex = 38
        Me.Btn_pilih.Text = "Select All"
        Me.Btn_pilih.ToolTip = "Celar Filter"
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(469, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 37
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(420, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
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
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(465, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MULTI CETAK DAFTAR PENGIRIMAN BARANG"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel2.Size = New System.Drawing.Size(792, 37)
        Me.Panel2.TabIndex = 4
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
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMultiBKE)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 377)
        Me.pnl.TabIndex = 6
        '
        'frMultiCtkBKE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 377)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frMultiCtkBKE"
        Me.Text = "frMultiCtkBME"
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcMultiBKE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMultiBKE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Created_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cetak_ulang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CE_ctk_ulang As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GcMultiBKE As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMultiBKE As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cetak_ke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents no_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Btn_pilih As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_deselect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Last_Update_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sudah_sj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_Polisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Sopir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Kenek As DevExpress.XtraGrid.Columns.GridColumn
End Class
