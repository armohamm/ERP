<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenHppSpkOrangCentian
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenHppSpkOrangCentian))
        Me.GV_Barang = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_kerja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcMultiBME = New DevExpress.XtraGrid.GridControl
        Me.GV_SP = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Departemen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_RPH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_SPK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_SPK_Rls = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KEGIATAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_kegiatan_spk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KEGIATAN_SPK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PEGAWAI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GROUP_KERJA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MESIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsts_hpp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CE_ctk_ulang = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.LookupBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.btn_deselect = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Btn_pilih = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.lblJudul = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.deTglSelesai = New DevExpress.XtraEditors.DateEdit
        Me.deTglMulai = New DevExpress.XtraEditors.DateEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl = New System.Windows.Forms.Panel
        CType(Me.GV_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcMultiBME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_SP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.deTglSelesai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglSelesai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV_Barang
        '
        Me.GV_Barang.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.nm_barang, Me.jumlah_kerja})
        Me.GV_Barang.GridControl = Me.GcMultiBME
        Me.GV_Barang.Name = "GV_Barang"
        Me.GV_Barang.OptionsView.ShowGroupPanel = False
        Me.GV_Barang.ViewCaption = "Detail Realisasi"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "No Realisasi"
        Me.GridColumn1.FieldName = "no_spk_man_rls"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "No_Urut"
        Me.GridColumn2.FieldName = "no_urut"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'nm_barang
        '
        Me.nm_barang.Caption = "Nama Barang"
        Me.nm_barang.FieldName = "Nama_Barang"
        Me.nm_barang.Name = "nm_barang"
        Me.nm_barang.OptionsColumn.ReadOnly = True
        Me.nm_barang.Visible = True
        Me.nm_barang.VisibleIndex = 3
        '
        'jumlah_kerja
        '
        Me.jumlah_kerja.Caption = "Jumlah Kerja"
        Me.jumlah_kerja.FieldName = "jumlah_kerja"
        Me.jumlah_kerja.Name = "jumlah_kerja"
        Me.jumlah_kerja.OptionsColumn.ReadOnly = True
        Me.jumlah_kerja.Visible = True
        Me.jumlah_kerja.VisibleIndex = 2
        '
        'GcMultiBME
        '
        Me.GcMultiBME.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV_Barang
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.GV_SP
        GridLevelNode2.RelationName = "Level2"
        Me.GcMultiBME.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GcMultiBME.Location = New System.Drawing.Point(0, 61)
        Me.GcMultiBME.LookAndFeel.SkinName = "The Asphalt World"
        Me.GcMultiBME.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GcMultiBME.MainView = Me.Gv
        Me.GcMultiBME.Name = "GcMultiBME"
        Me.GcMultiBME.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBrg, Me.CE_ctk_ulang})
        Me.GcMultiBME.Size = New System.Drawing.Size(951, 444)
        Me.GcMultiBME.TabIndex = 7
        Me.GcMultiBME.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_SP, Me.Gv, Me.GV_Barang})
        '
        'GV_SP
        '
        Me.GV_SP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn15, Me.GridColumn14, Me.GridColumn5, Me.GridColumn4, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
        Me.GV_SP.GridControl = Me.GcMultiBME
        Me.GV_SP.Name = "GV_SP"
        Me.GV_SP.ViewCaption = "Detail Realisasi Centian"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "No Realisa"
        Me.GridColumn3.FieldName = "no_spk_man_rls"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Kode Kegiatan"
        Me.GridColumn15.FieldName = "kd_kegiatan"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Kode Kegiatan SPK"
        Me.GridColumn14.FieldName = "kd_kegiatan_spk"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "No Urut"
        Me.GridColumn5.FieldName = "no_urut"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nama Barang Blok"
        Me.GridColumn4.FieldName = "Nama_Barang"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nama Barang SP"
        Me.GridColumn6.FieldName = "Nama_Barang_SP"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Satuan"
        Me.GridColumn7.FieldName = "kd_satuan"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tinggi"
        Me.GridColumn8.FieldName = "tinggi"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "lebar"
        Me.GridColumn9.FieldName = "lebar"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Panjang"
        Me.GridColumn10.FieldName = "panjang"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Jumlah Kerja"
        Me.GridColumn11.FieldName = "jumlah"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 8
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
        Me.Gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Departemen, Me.Tanggal, Me.NO_RPH, Me.No_SPK, Me.No_SPK_Rls, Me.GridColumn12, Me.KEGIATAN, Me.kd_kegiatan_spk, Me.KEGIATAN_SPK, Me.PEGAWAI, Me.GROUP_KERJA, Me.MESIN, Me.colsts_hpp, Me.no_posting, Me.rec_stat})
        Me.Gv.GridControl = Me.GcMultiBME
        Me.Gv.Name = "Gv"
        Me.Gv.OptionsView.EnableAppearanceEvenRow = True
        Me.Gv.OptionsView.EnableAppearanceOddRow = True
        Me.Gv.OptionsView.ShowFooter = True
        Me.Gv.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.Gv.OptionsView.ShowGroupPanel = False
        Me.Gv.ViewCaption = "CETAK ULANG SPK ORANG"
        '
        'Departemen
        '
        Me.Departemen.AppearanceHeader.Options.UseTextOptions = True
        Me.Departemen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Departemen.Caption = "Departemen"
        Me.Departemen.FieldName = "Nama_Departemen"
        Me.Departemen.Name = "Departemen"
        Me.Departemen.Visible = True
        Me.Departemen.VisibleIndex = 0
        Me.Departemen.Width = 78
        '
        'Tanggal
        '
        Me.Tanggal.AppearanceHeader.Options.UseTextOptions = True
        Me.Tanggal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Tanggal.Caption = "Tanggal"
        Me.Tanggal.FieldName = "Tanggal"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.OptionsColumn.AllowEdit = False
        Me.Tanggal.OptionsColumn.ReadOnly = True
        Me.Tanggal.Visible = True
        Me.Tanggal.VisibleIndex = 1
        Me.Tanggal.Width = 63
        '
        'NO_RPH
        '
        Me.NO_RPH.AppearanceHeader.Options.UseTextOptions = True
        Me.NO_RPH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NO_RPH.Caption = "RPH"
        Me.NO_RPH.FieldName = "NO_RPH"
        Me.NO_RPH.Name = "NO_RPH"
        Me.NO_RPH.OptionsColumn.ReadOnly = True
        Me.NO_RPH.Visible = True
        Me.NO_RPH.VisibleIndex = 2
        Me.NO_RPH.Width = 95
        '
        'No_SPK
        '
        Me.No_SPK.AppearanceHeader.Options.UseTextOptions = True
        Me.No_SPK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_SPK.Caption = "SPK"
        Me.No_SPK.FieldName = "No_SPK"
        Me.No_SPK.Name = "No_SPK"
        Me.No_SPK.OptionsColumn.ReadOnly = True
        Me.No_SPK.Visible = True
        Me.No_SPK.VisibleIndex = 3
        Me.No_SPK.Width = 94
        '
        'No_SPK_Rls
        '
        Me.No_SPK_Rls.AppearanceHeader.Options.UseTextOptions = True
        Me.No_SPK_Rls.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_SPK_Rls.Caption = "Realisasi"
        Me.No_SPK_Rls.FieldName = "No_SPK_Rls"
        Me.No_SPK_Rls.Name = "No_SPK_Rls"
        Me.No_SPK_Rls.OptionsColumn.ReadOnly = True
        Me.No_SPK_Rls.Visible = True
        Me.No_SPK_Rls.VisibleIndex = 4
        Me.No_SPK_Rls.Width = 88
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Kode Kegiatan"
        Me.GridColumn12.FieldName = "kd_kegiatan"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        '
        'KEGIATAN
        '
        Me.KEGIATAN.AppearanceHeader.Options.UseTextOptions = True
        Me.KEGIATAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.KEGIATAN.Caption = "Kegiatan"
        Me.KEGIATAN.FieldName = "KEGIATAN"
        Me.KEGIATAN.Name = "KEGIATAN"
        Me.KEGIATAN.OptionsColumn.AllowEdit = False
        Me.KEGIATAN.OptionsColumn.ReadOnly = True
        Me.KEGIATAN.Visible = True
        Me.KEGIATAN.VisibleIndex = 6
        Me.KEGIATAN.Width = 102
        '
        'kd_kegiatan_spk
        '
        Me.kd_kegiatan_spk.Caption = "Kd Kegiatan SPK"
        Me.kd_kegiatan_spk.FieldName = "kd_kegiatan_spk"
        Me.kd_kegiatan_spk.Name = "kd_kegiatan_spk"
        Me.kd_kegiatan_spk.OptionsColumn.AllowEdit = False
        Me.kd_kegiatan_spk.Visible = True
        Me.kd_kegiatan_spk.VisibleIndex = 7
        '
        'KEGIATAN_SPK
        '
        Me.KEGIATAN_SPK.AppearanceHeader.Options.UseTextOptions = True
        Me.KEGIATAN_SPK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.KEGIATAN_SPK.Caption = "Kegiatan SPK"
        Me.KEGIATAN_SPK.FieldName = "KEGIATAN_SPK"
        Me.KEGIATAN_SPK.Name = "KEGIATAN_SPK"
        Me.KEGIATAN_SPK.OptionsColumn.AllowEdit = False
        Me.KEGIATAN_SPK.OptionsColumn.ReadOnly = True
        Me.KEGIATAN_SPK.Visible = True
        Me.KEGIATAN_SPK.VisibleIndex = 8
        Me.KEGIATAN_SPK.Width = 89
        '
        'PEGAWAI
        '
        Me.PEGAWAI.AppearanceHeader.Options.UseTextOptions = True
        Me.PEGAWAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PEGAWAI.Caption = "Nama"
        Me.PEGAWAI.FieldName = "PEGAWAI"
        Me.PEGAWAI.Name = "PEGAWAI"
        Me.PEGAWAI.OptionsColumn.AllowEdit = False
        Me.PEGAWAI.OptionsColumn.ReadOnly = True
        Me.PEGAWAI.Visible = True
        Me.PEGAWAI.VisibleIndex = 10
        Me.PEGAWAI.Width = 85
        '
        'GROUP_KERJA
        '
        Me.GROUP_KERJA.AppearanceHeader.Options.UseTextOptions = True
        Me.GROUP_KERJA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GROUP_KERJA.Caption = "Group Kerja"
        Me.GROUP_KERJA.FieldName = "GROUP_KERJA"
        Me.GROUP_KERJA.Name = "GROUP_KERJA"
        Me.GROUP_KERJA.OptionsColumn.AllowEdit = False
        Me.GROUP_KERJA.OptionsColumn.ReadOnly = True
        Me.GROUP_KERJA.Visible = True
        Me.GROUP_KERJA.VisibleIndex = 9
        Me.GROUP_KERJA.Width = 78
        '
        'MESIN
        '
        Me.MESIN.AppearanceHeader.Options.UseTextOptions = True
        Me.MESIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MESIN.Caption = "Mesin"
        Me.MESIN.FieldName = "MESIN"
        Me.MESIN.Name = "MESIN"
        Me.MESIN.OptionsColumn.AllowEdit = False
        Me.MESIN.OptionsColumn.ReadOnly = True
        Me.MESIN.Visible = True
        Me.MESIN.VisibleIndex = 11
        Me.MESIN.Width = 56
        '
        'colsts_hpp
        '
        Me.colsts_hpp.Caption = "Status HPP"
        Me.colsts_hpp.FieldName = "status_hpp"
        Me.colsts_hpp.Name = "colsts_hpp"
        Me.colsts_hpp.OptionsColumn.AllowEdit = False
        Me.colsts_hpp.Visible = True
        Me.colsts_hpp.VisibleIndex = 12
        '
        'no_posting
        '
        Me.no_posting.AppearanceHeader.Options.UseTextOptions = True
        Me.no_posting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_posting.Caption = "Posting"
        Me.no_posting.FieldName = "no_posting"
        Me.no_posting.Name = "no_posting"
        Me.no_posting.OptionsColumn.AllowEdit = False
        Me.no_posting.OptionsColumn.ReadOnly = True
        Me.no_posting.Visible = True
        Me.no_posting.VisibleIndex = 13
        Me.no_posting.Width = 52
        '
        'rec_stat
        '
        Me.rec_stat.Caption = "Check"
        Me.rec_stat.ColumnEdit = Me.CE_ctk_ulang
        Me.rec_stat.FieldName = "rec_stat"
        Me.rec_stat.Name = "rec_stat"
        Me.rec_stat.UnboundExpression = "Iif([no_posting] <> '','Y'  , 'T')"
        Me.rec_stat.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.rec_stat.Visible = True
        Me.rec_stat.VisibleIndex = 14
        Me.rec_stat.Width = 50
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
        'LookupBrg
        '
        Me.LookupBrg.AutoHeight = False
        Me.LookupBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBrg.Name = "LookupBrg"
        Me.LookupBrg.NullText = ""
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
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "MONITORING INSPEKSI BARANG MASUK", ""}, New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), Nothing)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'btn_deselect
        '
        Me.btn_deselect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_deselect.ImageIndex = 0
        Me.btn_deselect.ImageList = Me.img
        Me.btn_deselect.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btn_deselect.Location = New System.Drawing.Point(682, 0)
        Me.btn_deselect.LookAndFeel.SkinName = "The Asphalt World"
        Me.btn_deselect.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_deselect.Name = "btn_deselect"
        Me.btn_deselect.Size = New System.Drawing.Size(109, 59)
        Me.btn_deselect.TabIndex = 43
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
        Me.Btn_pilih.Location = New System.Drawing.Point(791, 0)
        Me.Btn_pilih.LookAndFeel.SkinName = "The Asphalt World"
        Me.Btn_pilih.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Btn_pilih.Name = "Btn_pilih"
        Me.Btn_pilih.Size = New System.Drawing.Size(109, 59)
        Me.Btn_pilih.TabIndex = 42
        Me.Btn_pilih.Text = "Select All"
        Me.Btn_pilih.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(900, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 59)
        Me.cmdRefresh.TabIndex = 33
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(237, 59)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "Generate HPP Per SPK Centian"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.deTglSelesai)
        Me.Panel2.Controls.Add(Me.deTglMulai)
        Me.Panel2.Controls.Add(Me.btn_deselect)
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.Btn_pilih)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(951, 61)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(370, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Tanggal Selesai : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(381, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Tanggal Mulai : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'deTglSelesai
        '
        Me.deTglSelesai.EditValue = Nothing
        Me.deTglSelesai.Location = New System.Drawing.Point(478, 32)
        Me.deTglSelesai.Name = "deTglSelesai"
        Me.deTglSelesai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.deTglSelesai.Properties.Appearance.Options.UseFont = True
        Me.deTglSelesai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTglSelesai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.deTglSelesai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglSelesai.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglSelesai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglSelesai.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.deTglSelesai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglSelesai.Size = New System.Drawing.Size(183, 20)
        Me.deTglSelesai.TabIndex = 47
        '
        'deTglMulai
        '
        Me.deTglMulai.EditValue = Nothing
        Me.deTglMulai.Location = New System.Drawing.Point(478, 3)
        Me.deTglMulai.Name = "deTglMulai"
        Me.deTglMulai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.deTglMulai.Properties.Appearance.Options.UseFont = True
        Me.deTglMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTglMulai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.deTglMulai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglMulai.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglMulai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglMulai.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.deTglMulai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglMulai.Size = New System.Drawing.Size(183, 20)
        Me.deTglMulai.TabIndex = 44
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 59)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMultiBME)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(951, 505)
        Me.pnl.TabIndex = 6
        '
        'frmGenHppSpkOrangCentian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 505)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmGenHppSpkOrangCentian"
        CType(Me.GV_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcMultiBME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_SP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.deTglSelesai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglSelesai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LookupBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_SPK_Rls As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CE_ctk_ulang As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GcMultiBME As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents btn_deselect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Btn_pilih As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_SPK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GROUP_KERJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MESIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_RPH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KEGIATAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KEGIATAN_SPK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PEGAWAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Departemen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsts_hpp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents deTglSelesai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deTglMulai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents kd_kegiatan_spk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_Barang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nm_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_kerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_SP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class
