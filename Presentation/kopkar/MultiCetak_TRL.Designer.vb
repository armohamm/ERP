<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiCetak_TRL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultiCetak_TRL))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.CE_ctk = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.NAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupNama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.TGL_REGISTRASI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_TABUNGAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NASABAH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SALDO_AKHIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.GcMultiBKE = New DevExpress.XtraGrid.GridControl
        Me.GvMultiBKE = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cetak_ke = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cetak_ulang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Update = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_deselect = New DevExpress.XtraEditors.SimpleButton
        Me.Btn_pilih = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        CType(Me.CE_ctk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupNama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcMultiBKE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMultiBKE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'CE_ctk
        '
        Me.CE_ctk.AutoHeight = False
        Me.CE_ctk.Name = "CE_ctk"
        Me.CE_ctk.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CE_ctk.ValueChecked = "Y"
        Me.CE_ctk.ValueGrayed = "T"
        Me.CE_ctk.ValueUnchecked = "T"
        '
        'NAMA
        '
        Me.NAMA.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NAMA.AppearanceHeader.Options.UseFont = True
        Me.NAMA.AppearanceHeader.Options.UseTextOptions = True
        Me.NAMA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NAMA.Caption = "Nama"
        Me.NAMA.ColumnEdit = Me.LookupNama
        Me.NAMA.FieldName = "NASABAH_ID"
        Me.NAMA.Name = "NAMA"
        Me.NAMA.OptionsColumn.AllowEdit = False
        Me.NAMA.OptionsColumn.ReadOnly = True
        Me.NAMA.Visible = True
        Me.NAMA.VisibleIndex = 3
        Me.NAMA.Width = 208
        '
        'LookupNama
        '
        Me.LookupNama.AutoHeight = False
        Me.LookupNama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupNama.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupNama.Name = "LookupNama"
        Me.LookupNama.NullText = ""
        '
        'TGL_REGISTRASI
        '
        Me.TGL_REGISTRASI.AppearanceCell.Options.UseTextOptions = True
        Me.TGL_REGISTRASI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TGL_REGISTRASI.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TGL_REGISTRASI.AppearanceHeader.Options.UseFont = True
        Me.TGL_REGISTRASI.AppearanceHeader.Options.UseTextOptions = True
        Me.TGL_REGISTRASI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TGL_REGISTRASI.Caption = "tgl Masuk"
        Me.TGL_REGISTRASI.FieldName = "TGL_REGISTRASI"
        Me.TGL_REGISTRASI.Name = "TGL_REGISTRASI"
        Me.TGL_REGISTRASI.OptionsColumn.AllowEdit = False
        Me.TGL_REGISTRASI.OptionsColumn.ReadOnly = True
        Me.TGL_REGISTRASI.Visible = True
        Me.TGL_REGISTRASI.VisibleIndex = 4
        Me.TGL_REGISTRASI.Width = 73
        '
        'NO_TABUNGAN
        '
        Me.NO_TABUNGAN.AppearanceCell.Options.UseTextOptions = True
        Me.NO_TABUNGAN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NO_TABUNGAN.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NO_TABUNGAN.AppearanceHeader.Options.UseFont = True
        Me.NO_TABUNGAN.AppearanceHeader.Options.UseTextOptions = True
        Me.NO_TABUNGAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NO_TABUNGAN.Caption = "No Tabungan"
        Me.NO_TABUNGAN.FieldName = "NO_TABUNGAN"
        Me.NO_TABUNGAN.Name = "NO_TABUNGAN"
        Me.NO_TABUNGAN.OptionsColumn.AllowEdit = False
        Me.NO_TABUNGAN.OptionsColumn.ReadOnly = True
        Me.NO_TABUNGAN.Visible = True
        Me.NO_TABUNGAN.VisibleIndex = 1
        Me.NO_TABUNGAN.Width = 138
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
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 55
        '
        'NASABAH_ID
        '
        Me.NASABAH_ID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NASABAH_ID.AppearanceHeader.Options.UseFont = True
        Me.NASABAH_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.NASABAH_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NASABAH_ID.Caption = "NIP"
        Me.NASABAH_ID.FieldName = "NASABAH_ID"
        Me.NASABAH_ID.Name = "NASABAH_ID"
        Me.NASABAH_ID.OptionsColumn.AllowEdit = False
        Me.NASABAH_ID.OptionsColumn.ReadOnly = True
        Me.NASABAH_ID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.NASABAH_ID.Visible = True
        Me.NASABAH_ID.VisibleIndex = 2
        Me.NASABAH_ID.Width = 59
        '
        'SALDO_AKHIR
        '
        Me.SALDO_AKHIR.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SALDO_AKHIR.AppearanceHeader.Options.UseFont = True
        Me.SALDO_AKHIR.AppearanceHeader.Options.UseTextOptions = True
        Me.SALDO_AKHIR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SALDO_AKHIR.Caption = "SALDO AKHIR"
        Me.SALDO_AKHIR.DisplayFormat.FormatString = "c2"
        Me.SALDO_AKHIR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SALDO_AKHIR.FieldName = "SALDO_AKHIR"
        Me.SALDO_AKHIR.Name = "SALDO_AKHIR"
        Me.SALDO_AKHIR.OptionsColumn.AllowEdit = False
        Me.SALDO_AKHIR.OptionsColumn.ReadOnly = True
        Me.SALDO_AKHIR.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SALDO_AKHIR.Visible = True
        Me.SALDO_AKHIR.VisibleIndex = 5
        Me.SALDO_AKHIR.Width = 166
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
        Me.GcMultiBKE.Location = New System.Drawing.Point(0, 92)
        Me.GcMultiBKE.LookAndFeel.SkinName = "The Asphalt World"
        Me.GcMultiBKE.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GcMultiBKE.MainView = Me.GvMultiBKE
        Me.GcMultiBKE.Name = "GcMultiBKE"
        Me.GcMultiBKE.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupNama, Me.CE_ctk})
        Me.GcMultiBKE.Size = New System.Drawing.Size(956, 260)
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
        Me.GvMultiBKE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.NO_TABUNGAN, Me.TGL_REGISTRASI, Me.NAMA, Me.NASABAH_ID, Me.SALDO_AKHIR, Me.cetak_ke, Me.cetak_ulang, Me.Last_Update})
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
        Me.GvMultiBKE.ViewCaption = "CETAK TABUNGAN WAJIB"
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
        Me.cetak_ke.VisibleIndex = 6
        Me.cetak_ke.Width = 86
        '
        'cetak_ulang
        '
        Me.cetak_ulang.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cetak_ulang.AppearanceHeader.Options.UseFont = True
        Me.cetak_ulang.AppearanceHeader.Options.UseTextOptions = True
        Me.cetak_ulang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cetak_ulang.Caption = "Ctk Ulang"
        Me.cetak_ulang.ColumnEdit = Me.CE_ctk
        Me.cetak_ulang.FieldName = "cetak_ulang"
        Me.cetak_ulang.Name = "cetak_ulang"
        Me.cetak_ulang.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.cetak_ulang.Visible = True
        Me.cetak_ulang.VisibleIndex = 7
        Me.cetak_ulang.Width = 72
        '
        'Last_Update
        '
        Me.Last_Update.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Last_Update.AppearanceHeader.Options.UseFont = True
        Me.Last_Update.AppearanceHeader.Options.UseTextOptions = True
        Me.Last_Update.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Last_Update.Caption = "Tgl Cetak"
        Me.Last_Update.DisplayFormat.FormatString = "dd/MMM/yyyy hh:mm tt"
        Me.Last_Update.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Last_Update.FieldName = "Last_Update"
        Me.Last_Update.Name = "Last_Update"
        Me.Last_Update.OptionsColumn.AllowEdit = False
        Me.Last_Update.Visible = True
        Me.Last_Update.VisibleIndex = 8
        Me.Last_Update.Width = 116
        '
        'btnprin
        '
        Me.btnprin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnprin.ImageIndex = 10
        Me.btnprin.ImageList = Me.img
        Me.btnprin.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnprin.Location = New System.Drawing.Point(667, 0)
        Me.btnprin.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnprin.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(71, 55)
        Me.btnprin.TabIndex = 42
        Me.btnprin.Text = "Cetak"
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnprin)
        Me.Panel3.Controls.Add(Me.btn_deselect)
        Me.Panel3.Controls.Add(Me.Btn_pilih)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(956, 55)
        Me.Panel3.TabIndex = 5
        '
        'btn_deselect
        '
        Me.btn_deselect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_deselect.ImageIndex = 0
        Me.btn_deselect.ImageList = Me.img
        Me.btn_deselect.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btn_deselect.Location = New System.Drawing.Point(738, 0)
        Me.btn_deselect.LookAndFeel.SkinName = "The Asphalt World"
        Me.btn_deselect.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_deselect.Name = "btn_deselect"
        Me.btn_deselect.Size = New System.Drawing.Size(109, 55)
        Me.btn_deselect.TabIndex = 39
        Me.btn_deselect.Text = "Deselect All"
        Me.btn_deselect.ToolTip = "Celar Filter"
        '
        'Btn_pilih
        '
        Me.Btn_pilih.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_pilih.ImageIndex = 3
        Me.Btn_pilih.ImageList = Me.img
        Me.Btn_pilih.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Btn_pilih.Location = New System.Drawing.Point(847, 0)
        Me.Btn_pilih.LookAndFeel.SkinName = "The Asphalt World"
        Me.Btn_pilih.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Btn_pilih.Name = "Btn_pilih"
        Me.Btn_pilih.Size = New System.Drawing.Size(109, 55)
        Me.Btn_pilih.TabIndex = 38
        Me.Btn_pilih.Text = "Select All"
        Me.Btn_pilih.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(332, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 55)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(121, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(211, 55)
        Me.Panel6.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 55)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "PERIODE : "
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
        Me.lblJudul.Text = "MULTI CETAK TABUNGAN SUKARELA BERJANGKA"
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
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Brown
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(956, 37)
        Me.Panel2.TabIndex = 4
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMultiBKE)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(956, 352)
        Me.pnl.TabIndex = 8
        '
        'MultiCetak_TRL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 352)
        Me.Controls.Add(Me.pnl)
        Me.Name = "MultiCetak_TRL"
        Me.Text = "c"
        CType(Me.CE_ctk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupNama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcMultiBKE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMultiBKE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CE_ctk As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents NAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupNama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TGL_REGISTRASI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_TABUNGAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NASABAH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SALDO_AKHIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GcMultiBKE As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMultiBKE As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cetak_ke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cetak_ulang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Update As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_deselect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Btn_pilih As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
End Class
