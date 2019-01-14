<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCetakProduksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCetakProduksi))
        Me.LookupBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.CE_ctk_ulang = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.GcMultiBME = New DevExpress.XtraGrid.GridControl
        Me.Gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_rph = New DevExpress.XtraGrid.Columns.GridColumn
        Me.desc_data = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sts_centi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cetak_ulang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.btn_deselect = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Btn_pilih = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.lblJudul = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.Nama_Departemen = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.LookupBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcMultiBME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'LookupBrg
        '
        Me.LookupBrg.AutoHeight = False
        Me.LookupBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBrg.Name = "LookupBrg"
        Me.LookupBrg.NullText = ""
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
        Me.PrintableComponentLink1.Component = Me.GcMultiBME
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
        'GcMultiBME
        '
        Me.GcMultiBME.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMultiBME.Location = New System.Drawing.Point(0, 59)
        Me.GcMultiBME.LookAndFeel.SkinName = "The Asphalt World"
        Me.GcMultiBME.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GcMultiBME.MainView = Me.Gv
        Me.GcMultiBME.Name = "GcMultiBME"
        Me.GcMultiBME.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBrg, Me.CE_ctk_ulang})
        Me.GcMultiBME.Size = New System.Drawing.Size(954, 429)
        Me.GcMultiBME.TabIndex = 7
        Me.GcMultiBME.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gv})
        '
        'Gv
        '
        Me.Gv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gv.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Gv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Gv.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Gv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gv.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Gv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Gv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Gv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Gv.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.Gv.Appearance.Empty.Options.UseBackColor = True
        Me.Gv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.EvenRow.Options.UseBackColor = True
        Me.Gv.Appearance.EvenRow.Options.UseForeColor = True
        Me.Gv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Gv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Gv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.Gv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Gv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.Gv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Gv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Gv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Gv.Appearance.FixedLine.Options.UseBackColor = True
        Me.Gv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.Gv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Gv.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Gv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Gv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Gv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Gv.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Gv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gv.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Gv.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Gv.Appearance.FooterPanel.Options.UseForeColor = True
        Me.Gv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gv.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.GroupButton.Options.UseBackColor = True
        Me.Gv.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Gv.Appearance.GroupButton.Options.UseForeColor = True
        Me.Gv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Gv.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Gv.Appearance.GroupFooter.Options.UseForeColor = True
        Me.Gv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Gv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Gv.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Gv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gv.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Gv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.GroupRow.Options.UseBackColor = True
        Me.Gv.Appearance.GroupRow.Options.UseBorderColor = True
        Me.Gv.Appearance.GroupRow.Options.UseFont = True
        Me.Gv.Appearance.GroupRow.Options.UseForeColor = True
        Me.Gv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gv.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Gv.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Gv.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.Gv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Gv.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Gv.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.Gv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Gv.Appearance.HorzLine.Options.UseBackColor = True
        Me.Gv.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.Gv.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.OddRow.Options.UseBackColor = True
        Me.Gv.Appearance.OddRow.Options.UseForeColor = True
        Me.Gv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Gv.Appearance.Preview.Options.UseBackColor = True
        Me.Gv.Appearance.Preview.Options.UseForeColor = True
        Me.Gv.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.Gv.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.Gv.Appearance.Row.Options.UseBackColor = True
        Me.Gv.Appearance.Row.Options.UseForeColor = True
        Me.Gv.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.Gv.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Gv.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.Gv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Gv.Appearance.SelectedRow.Options.UseForeColor = True
        Me.Gv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Gv.Appearance.VertLine.Options.UseBackColor = True
        Me.Gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nama_Departemen, Me.tanggal, Me.no_rph, Me.desc_data, Me.sts_centi, Me.cetak_ulang})
        Me.Gv.GridControl = Me.GcMultiBME
        Me.Gv.Name = "Gv"
        Me.Gv.OptionsView.EnableAppearanceEvenRow = True
        Me.Gv.OptionsView.EnableAppearanceOddRow = True
        Me.Gv.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.Gv.OptionsView.ShowGroupPanel = False
        '
        'tanggal
        '
        Me.tanggal.AppearanceHeader.Options.UseTextOptions = True
        Me.tanggal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tanggal.Caption = "Tanggal"
        Me.tanggal.FieldName = "tanggal"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.OptionsColumn.AllowEdit = False
        Me.tanggal.OptionsColumn.ReadOnly = True
        Me.tanggal.Visible = True
        Me.tanggal.VisibleIndex = 0
        Me.tanggal.Width = 139
        '
        'no_rph
        '
        Me.no_rph.AppearanceHeader.Options.UseTextOptions = True
        Me.no_rph.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_rph.Caption = "No Rph"
        Me.no_rph.FieldName = "no_rph"
        Me.no_rph.Name = "no_rph"
        Me.no_rph.OptionsColumn.AllowEdit = False
        Me.no_rph.OptionsColumn.ReadOnly = True
        Me.no_rph.Visible = True
        Me.no_rph.VisibleIndex = 2
        Me.no_rph.Width = 254
        '
        'desc_data
        '
        Me.desc_data.AppearanceHeader.Options.UseTextOptions = True
        Me.desc_data.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.desc_data.Caption = "Jadwal"
        Me.desc_data.FieldName = "desc_data"
        Me.desc_data.Name = "desc_data"
        Me.desc_data.OptionsColumn.AllowEdit = False
        Me.desc_data.OptionsColumn.ReadOnly = True
        Me.desc_data.Visible = True
        Me.desc_data.VisibleIndex = 3
        Me.desc_data.Width = 208
        '
        'sts_centi
        '
        Me.sts_centi.AppearanceHeader.Options.UseTextOptions = True
        Me.sts_centi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sts_centi.Caption = "Status"
        Me.sts_centi.FieldName = "sts_centi"
        Me.sts_centi.Name = "sts_centi"
        Me.sts_centi.OptionsColumn.AllowEdit = False
        Me.sts_centi.OptionsColumn.ReadOnly = True
        Me.sts_centi.Visible = True
        Me.sts_centi.VisibleIndex = 4
        Me.sts_centi.Width = 57
        '
        'cetak_ulang
        '
        Me.cetak_ulang.Caption = "Cetak Ulang"
        Me.cetak_ulang.ColumnEdit = Me.CE_ctk_ulang
        Me.cetak_ulang.FieldName = "cetak_ulang"
        Me.cetak_ulang.Name = "cetak_ulang"
        Me.cetak_ulang.Visible = True
        Me.cetak_ulang.VisibleIndex = 5
        Me.cetak_ulang.Width = 103
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(954, 22)
        Me.Panel3.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PLAN RPH", "RPH BARANG JADI", "RPH 1/2 JADI"})
        Me.ComboBox1.Location = New System.Drawing.Point(0, -2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(272, 24)
        Me.ComboBox1.TabIndex = 44
        '
        'btn_deselect
        '
        Me.btn_deselect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_deselect.ImageIndex = 0
        Me.btn_deselect.ImageList = Me.img
        Me.btn_deselect.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btn_deselect.Location = New System.Drawing.Point(852, 0)
        Me.btn_deselect.LookAndFeel.SkinName = "The Asphalt World"
        Me.btn_deselect.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_deselect.Name = "btn_deselect"
        Me.btn_deselect.Size = New System.Drawing.Size(100, 35)
        Me.btn_deselect.TabIndex = 34
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
        Me.Btn_pilih.Location = New System.Drawing.Point(746, 0)
        Me.Btn_pilih.LookAndFeel.SkinName = "The Asphalt World"
        Me.Btn_pilih.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Btn_pilih.Name = "Btn_pilih"
        Me.Btn_pilih.Size = New System.Drawing.Size(106, 35)
        Me.Btn_pilih.TabIndex = 35
        Me.Btn_pilih.Text = "Select All"
        Me.Btn_pilih.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(694, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(52, 35)
        Me.cmdRefresh.TabIndex = 42
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
        Me.lblJudul.Text = "FORM CETAK PRODUKSI"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.Btn_pilih)
        Me.Panel2.Controls.Add(Me.btn_deselect)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 37)
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
        Me.pnl.Controls.Add(Me.GcMultiBME)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(954, 488)
        Me.pnl.TabIndex = 6
        '
        'Nama_Departemen
        '
        Me.Nama_Departemen.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Departemen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Departemen.Caption = "Departemen"
        Me.Nama_Departemen.FieldName = "Nama_Departemen"
        Me.Nama_Departemen.Name = "Nama_Departemen"
        Me.Nama_Departemen.OptionsColumn.AllowEdit = False
        Me.Nama_Departemen.OptionsColumn.ReadOnly = True
        Me.Nama_Departemen.Visible = True
        Me.Nama_Departemen.VisibleIndex = 1
        Me.Nama_Departemen.Width = 172
        '
        'frmCetakProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 488)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmCetakProduksi"
        Me.Text = "FRMCTKPRODUKSI"
        CType(Me.LookupBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcMultiBME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sts_centi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents desc_data As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_rph As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cetak_ulang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CE_ctk_ulang As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GcMultiBME As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents btn_deselect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Btn_pilih As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Nama_Departemen As DevExpress.XtraGrid.Columns.GridColumn
End Class
