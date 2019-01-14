<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonSP_PPIC
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonSP_PPIC))
        Me.GV_Kirim = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColTglKirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColNoTrans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColJmlKirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_JumlahBalik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.GV_Produksi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColTanggalProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColNoProduksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColJmlProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GV_ProdCentian = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.KdBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tebal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.panjang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lebar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_prodcent = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GV_DetailSOBOX = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColTanggalProdCen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_no_Rph = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColQ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_Jml_Prod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gvDetail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColOld_Num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_wilayah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_area = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColKeterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColKetKirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColTglProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_Order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_Kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColBatal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Jml_Prod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nama_jenis1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_kapasitas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CEHijau = New DevExpress.XtraEditors.CheckEdit
        Me.CEMerah = New DevExpress.XtraEditors.CheckEdit
        Me.CEKuning = New DevExpress.XtraEditors.CheckEdit
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GV_Kirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Produksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_ProdCentian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DetailSOBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CEHijau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEMerah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEKuning.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV_Kirim
        '
        Me.GV_Kirim.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColTglKirim, Me.ColNoTrans, Me.ColJmlKirim, Me.Col_JumlahBalik})
        Me.GV_Kirim.GridControl = Me.gc
        Me.GV_Kirim.Name = "GV_Kirim"
        Me.GV_Kirim.OptionsBehavior.Editable = False
        Me.GV_Kirim.OptionsView.ShowGroupPanel = False
        '
        'ColTglKirim
        '
        Me.ColTglKirim.Caption = "Tanggal "
        Me.ColTglKirim.FieldName = "Tanggal"
        Me.ColTglKirim.Name = "ColTglKirim"
        Me.ColTglKirim.OptionsColumn.AllowEdit = False
        Me.ColTglKirim.Visible = True
        Me.ColTglKirim.VisibleIndex = 0
        '
        'ColNoTrans
        '
        Me.ColNoTrans.Caption = "No. Renacana Kirim"
        Me.ColNoTrans.FieldName = "no_trans"
        Me.ColNoTrans.Name = "ColNoTrans"
        Me.ColNoTrans.OptionsColumn.AllowEdit = False
        Me.ColNoTrans.Visible = True
        Me.ColNoTrans.VisibleIndex = 1
        '
        'ColJmlKirim
        '
        Me.ColJmlKirim.Caption = "Jumlah Rencana Kirim"
        Me.ColJmlKirim.FieldName = "jumlah"
        Me.ColJmlKirim.Name = "ColJmlKirim"
        Me.ColJmlKirim.OptionsColumn.AllowEdit = False
        Me.ColJmlKirim.Visible = True
        Me.ColJmlKirim.VisibleIndex = 2
        '
        'Col_JumlahBalik
        '
        Me.Col_JumlahBalik.Caption = "Jumlah Balik/Batal"
        Me.Col_JumlahBalik.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_JumlahBalik.FieldName = "jumlah_balik"
        Me.Col_JumlahBalik.Name = "Col_JumlahBalik"
        Me.Col_JumlahBalik.OptionsColumn.AllowEdit = False
        Me.Col_JumlahBalik.Visible = True
        Me.Col_JumlahBalik.VisibleIndex = 3
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.gc.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        GridLevelNode1.LevelTemplate = Me.GV_Kirim
        GridLevelNode1.RelationName = "Detail1"
        GridLevelNode2.LevelTemplate = Me.GV_Produksi
        GridLevelNode2.RelationName = "Detail2"
        GridLevelNode3.LevelTemplate = Me.GV_ProdCentian
        GridLevelNode3.RelationName = "Detail3"
        GridLevelNode4.LevelTemplate = Me.GV_DetailSOBOX
        GridLevelNode4.RelationName = "Level1"
        Me.gc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2, GridLevelNode3, GridLevelNode4})
        Me.gc.Location = New System.Drawing.Point(0, 48)
        Me.gc.MainView = Me.gvDetail
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(1005, 477)
        Me.gc.TabIndex = 7
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Produksi, Me.GV_ProdCentian, Me.GV_DetailSOBOX, Me.gvDetail, Me.gvMain, Me.GV_Kirim})
        '
        'GV_Produksi
        '
        Me.GV_Produksi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColTanggalProd, Me.ColNoProduksi, Me.ColJmlProd})
        Me.GV_Produksi.GridControl = Me.gc
        Me.GV_Produksi.Name = "GV_Produksi"
        Me.GV_Produksi.OptionsBehavior.Editable = False
        Me.GV_Produksi.OptionsView.ShowGroupPanel = False
        '
        'ColTanggalProd
        '
        Me.ColTanggalProd.Caption = "Tanggal"
        Me.ColTanggalProd.FieldName = "Tanggal"
        Me.ColTanggalProd.Name = "ColTanggalProd"
        Me.ColTanggalProd.OptionsColumn.AllowEdit = False
        Me.ColTanggalProd.Visible = True
        Me.ColTanggalProd.VisibleIndex = 0
        '
        'ColNoProduksi
        '
        Me.ColNoProduksi.Caption = "No. Rencana Produksi"
        Me.ColNoProduksi.FieldName = "no_rph"
        Me.ColNoProduksi.Name = "ColNoProduksi"
        Me.ColNoProduksi.Visible = True
        Me.ColNoProduksi.VisibleIndex = 1
        '
        'ColJmlProd
        '
        Me.ColJmlProd.Caption = "Jumlah Rencana Produksi"
        Me.ColJmlProd.FieldName = "jumlah"
        Me.ColJmlProd.Name = "ColJmlProd"
        Me.ColJmlProd.Visible = True
        Me.ColJmlProd.VisibleIndex = 2
        '
        'GV_ProdCentian
        '
        Me.GV_ProdCentian.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KdBarang, Me.tebal, Me.panjang, Me.lebar, Me.jml_prodcent})
        Me.GV_ProdCentian.GridControl = Me.gc
        Me.GV_ProdCentian.Name = "GV_ProdCentian"
        Me.GV_ProdCentian.OptionsBehavior.Editable = False
        Me.GV_ProdCentian.OptionsView.ShowGroupPanel = False
        '
        'KdBarang
        '
        Me.KdBarang.Caption = "Kode Barang"
        Me.KdBarang.FieldName = "kd_barang"
        Me.KdBarang.Name = "KdBarang"
        Me.KdBarang.Visible = True
        Me.KdBarang.VisibleIndex = 0
        '
        'tebal
        '
        Me.tebal.Caption = "Tebal"
        Me.tebal.FieldName = "tebal"
        Me.tebal.Name = "tebal"
        Me.tebal.Visible = True
        Me.tebal.VisibleIndex = 1
        '
        'panjang
        '
        Me.panjang.Caption = "Panjang"
        Me.panjang.FieldName = "panjang"
        Me.panjang.Name = "panjang"
        Me.panjang.Visible = True
        Me.panjang.VisibleIndex = 2
        '
        'lebar
        '
        Me.lebar.Caption = "Lebar"
        Me.lebar.FieldName = "lebar"
        Me.lebar.Name = "lebar"
        Me.lebar.Visible = True
        Me.lebar.VisibleIndex = 3
        '
        'jml_prodcent
        '
        Me.jml_prodcent.Caption = "Jumlah Produksi"
        Me.jml_prodcent.FieldName = "jumlah"
        Me.jml_prodcent.Name = "jml_prodcent"
        Me.jml_prodcent.Visible = True
        Me.jml_prodcent.VisibleIndex = 4
        '
        'GV_DetailSOBOX
        '
        Me.GV_DetailSOBOX.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColTanggalProdCen, Me.Col_no_Rph, Me.Kd_Stok, Me.ColT, Me.ColL, Me.ColP, Me.ColQ, Me.Col_Jml_Prod})
        Me.GV_DetailSOBOX.GridControl = Me.gc
        Me.GV_DetailSOBOX.Name = "GV_DetailSOBOX"
        Me.GV_DetailSOBOX.OptionsBehavior.Editable = False
        Me.GV_DetailSOBOX.OptionsView.ShowGroupPanel = False
        '
        'ColTanggalProdCen
        '
        Me.ColTanggalProdCen.Caption = "Tanggal"
        Me.ColTanggalProdCen.FieldName = "Tanggal"
        Me.ColTanggalProdCen.Name = "ColTanggalProdCen"
        Me.ColTanggalProdCen.OptionsColumn.AllowEdit = False
        Me.ColTanggalProdCen.Visible = True
        Me.ColTanggalProdCen.VisibleIndex = 0
        '
        'Col_no_Rph
        '
        Me.Col_no_Rph.Caption = "No. RPH"
        Me.Col_no_Rph.FieldName = "no_rph"
        Me.Col_no_Rph.Name = "Col_no_Rph"
        Me.Col_no_Rph.Visible = True
        Me.Col_no_Rph.VisibleIndex = 1
        Me.Col_no_Rph.Width = 182
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Kode Barang"
        Me.Kd_Stok.FieldName = "kd_barang"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 2
        Me.Kd_Stok.Width = 213
        '
        'ColT
        '
        Me.ColT.Caption = "Tebal"
        Me.ColT.FieldName = "tebal"
        Me.ColT.Name = "ColT"
        Me.ColT.Visible = True
        Me.ColT.VisibleIndex = 3
        Me.ColT.Width = 76
        '
        'ColL
        '
        Me.ColL.Caption = "Lebar"
        Me.ColL.FieldName = "lebar"
        Me.ColL.Name = "ColL"
        Me.ColL.Visible = True
        Me.ColL.VisibleIndex = 4
        Me.ColL.Width = 85
        '
        'ColP
        '
        Me.ColP.Caption = "Panjang"
        Me.ColP.FieldName = "panjang"
        Me.ColP.Name = "ColP"
        Me.ColP.Visible = True
        Me.ColP.VisibleIndex = 5
        Me.ColP.Width = 85
        '
        'ColQ
        '
        Me.ColQ.Caption = "Jumlah Order"
        Me.ColQ.FieldName = "Qty"
        Me.ColQ.Name = "ColQ"
        Me.ColQ.Visible = True
        Me.ColQ.VisibleIndex = 6
        Me.ColQ.Width = 98
        '
        'Col_Jml_Prod
        '
        Me.Col_Jml_Prod.Caption = "Jumlah Rencana Produksi"
        Me.Col_Jml_Prod.FieldName = "jumlah"
        Me.Col_Jml_Prod.Name = "Col_Jml_Prod"
        Me.Col_Jml_Prod.Visible = True
        Me.Col_Jml_Prod.VisibleIndex = 7
        Me.Col_Jml_Prod.Width = 245
        '
        'gvDetail
        '
        Me.gvDetail.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvDetail.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvDetail.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvDetail.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvDetail.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvDetail.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvDetail.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.Empty.Options.UseBackColor = True
        Me.gvDetail.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvDetail.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvDetail.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvDetail.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDetail.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvDetail.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvDetail.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvDetail.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvDetail.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvDetail.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvDetail.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvDetail.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvDetail.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvDetail.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvDetail.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvDetail.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvDetail.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvDetail.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvDetail.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvDetail.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvDetail.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDetail.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvDetail.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvDetail.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvDetail.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvDetail.Appearance.GroupRow.Options.UseFont = True
        Me.gvDetail.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvDetail.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvDetail.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvDetail.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvDetail.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvDetail.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvDetail.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.OddRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.OddRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDetail.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDetail.Appearance.Preview.Options.UseBackColor = True
        Me.gvDetail.Appearance.Preview.Options.UseForeColor = True
        Me.gvDetail.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.Row.Options.UseBackColor = True
        Me.gvDetail.Appearance.Row.Options.UseForeColor = True
        Me.gvDetail.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvDetail.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvDetail.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvDetail.Appearance.VertLine.Options.UseBackColor = True
        Me.gvDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sp, Me.ColOld_Num, Me.nama_customer, Me.nama_wilayah, Me.nama_area, Me.Nama_Barang, Me.ColKeterangan, Me.ColKetKirim, Me.nama_jenis, Me.tgl_kirim, Me.ColTglProd, Me.Qty_Order, Me.Qty_Kirim, Me.ColBatal, Me.Jml_Prod, Me.GridColumn1})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[qty_rcn_prod] > 0 And [qty_rcn_krm] = 0"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Yellow
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[qty_rcn_krm] > 0  And [qty_rcn_prod] = 0"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "[qty_rcn_krm] > 0  And [qty_rcn_prod]  > 0"
        Me.gvDetail.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.gvDetail.GridControl = Me.gc
        Me.gvDetail.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "jml", Nothing, "")})
        Me.gvDetail.Name = "gvDetail"
        Me.gvDetail.OptionsBehavior.Editable = False
        Me.gvDetail.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvDetail.OptionsView.ColumnAutoWidth = False
        Me.gvDetail.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDetail.OptionsView.ShowFooter = True
        Me.gvDetail.OptionsView.ShowViewCaption = True
        Me.gvDetail.PaintStyleName = "Skin"
        Me.gvDetail.ViewCaption = "DAFTAR SP"
        '
        'no_sp
        '
        Me.no_sp.AppearanceCell.Options.UseTextOptions = True
        Me.no_sp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.Caption = "No SP"
        Me.no_sp.FieldName = "No_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.no_sp.OptionsColumn.ReadOnly = True
        Me.no_sp.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 0
        Me.no_sp.Width = 108
        '
        'ColOld_Num
        '
        Me.ColOld_Num.AppearanceHeader.Options.UseTextOptions = True
        Me.ColOld_Num.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColOld_Num.Caption = "Old Num"
        Me.ColOld_Num.FieldName = "old_num"
        Me.ColOld_Num.Name = "ColOld_Num"
        Me.ColOld_Num.OptionsColumn.AllowEdit = False
        Me.ColOld_Num.Visible = True
        Me.ColOld_Num.VisibleIndex = 1
        '
        'nama_customer
        '
        Me.nama_customer.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.nama_customer.AppearanceCell.Options.UseBorderColor = True
        Me.nama_customer.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_customer.Caption = "Pelanggan"
        Me.nama_customer.FieldName = "Nama_Customer"
        Me.nama_customer.Name = "nama_customer"
        Me.nama_customer.OptionsColumn.AllowEdit = False
        Me.nama_customer.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.nama_customer.OptionsColumn.ReadOnly = True
        Me.nama_customer.Visible = True
        Me.nama_customer.VisibleIndex = 2
        Me.nama_customer.Width = 112
        '
        'nama_wilayah
        '
        Me.nama_wilayah.AppearanceCell.Options.UseTextOptions = True
        Me.nama_wilayah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_wilayah.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_wilayah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_wilayah.Caption = "Wilayah"
        Me.nama_wilayah.FieldName = "Nama_Wilayah"
        Me.nama_wilayah.Name = "nama_wilayah"
        Me.nama_wilayah.OptionsColumn.AllowEdit = False
        Me.nama_wilayah.Visible = True
        Me.nama_wilayah.VisibleIndex = 3
        Me.nama_wilayah.Width = 60
        '
        'nama_area
        '
        Me.nama_area.AppearanceCell.Options.UseTextOptions = True
        Me.nama_area.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_area.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_area.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_area.Caption = "Area"
        Me.nama_area.FieldName = "Nama_Area"
        Me.nama_area.Name = "nama_area"
        Me.nama_area.OptionsColumn.AllowEdit = False
        Me.nama_area.Visible = True
        Me.nama_area.VisibleIndex = 4
        Me.nama_area.Width = 60
        '
        'Nama_Barang
        '
        Me.Nama_Barang.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.Nama_Barang.AppearanceCell.Options.UseBorderColor = True
        Me.Nama_Barang.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Barang.Caption = "Nama Barang"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.OptionsColumn.AllowEdit = False
        Me.Nama_Barang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Nama_Barang.OptionsColumn.ReadOnly = True
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 5
        Me.Nama_Barang.Width = 231
        '
        'ColKeterangan
        '
        Me.ColKeterangan.Caption = "Keterangan"
        Me.ColKeterangan.FieldName = "Keterangan"
        Me.ColKeterangan.Name = "ColKeterangan"
        Me.ColKeterangan.OptionsColumn.AllowEdit = False
        Me.ColKeterangan.OptionsColumn.ReadOnly = True
        Me.ColKeterangan.Visible = True
        Me.ColKeterangan.VisibleIndex = 6
        Me.ColKeterangan.Width = 98
        '
        'ColKetKirim
        '
        Me.ColKetKirim.AppearanceHeader.Options.UseTextOptions = True
        Me.ColKetKirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColKetKirim.Caption = "Keterangan Kirim"
        Me.ColKetKirim.FieldName = "keterangan_krm"
        Me.ColKetKirim.Name = "ColKetKirim"
        Me.ColKetKirim.OptionsColumn.AllowEdit = False
        Me.ColKetKirim.Visible = True
        Me.ColKetKirim.VisibleIndex = 7
        '
        'nama_jenis
        '
        Me.nama_jenis.AppearanceCell.Options.UseTextOptions = True
        Me.nama_jenis.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_jenis.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_jenis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_jenis.Caption = "Jenis Barang"
        Me.nama_jenis.FieldName = "Nama_Jenis"
        Me.nama_jenis.Name = "nama_jenis"
        Me.nama_jenis.OptionsColumn.AllowEdit = False
        Me.nama_jenis.Visible = True
        Me.nama_jenis.VisibleIndex = 8
        Me.nama_jenis.Width = 106
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.tgl_kirim.AppearanceCell.Options.UseBorderColor = True
        Me.tgl_kirim.AppearanceCell.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.Caption = "Tgl Kirim"
        Me.tgl_kirim.FieldName = "Tgl_Kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.OptionsColumn.AllowEdit = False
        Me.tgl_kirim.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_kirim.OptionsColumn.ReadOnly = True
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 9
        Me.tgl_kirim.Width = 101
        '
        'ColTglProd
        '
        Me.ColTglProd.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTglProd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTglProd.Caption = "Tanggal Produksi"
        Me.ColTglProd.FieldName = "tanggal_prod"
        Me.ColTglProd.Name = "ColTglProd"
        Me.ColTglProd.OptionsColumn.AllowEdit = False
        Me.ColTglProd.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.ColTglProd.Visible = True
        Me.ColTglProd.VisibleIndex = 10
        '
        'Qty_Order
        '
        Me.Qty_Order.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.Qty_Order.AppearanceCell.Options.UseBorderColor = True
        Me.Qty_Order.AppearanceCell.Options.UseTextOptions = True
        Me.Qty_Order.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_Order.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_Order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty_Order.Caption = "Jumlah Order"
        Me.Qty_Order.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty_Order.FieldName = "qty_order"
        Me.Qty_Order.Name = "Qty_Order"
        Me.Qty_Order.OptionsColumn.AllowEdit = False
        Me.Qty_Order.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Qty_Order.OptionsColumn.ReadOnly = True
        Me.Qty_Order.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_Order.Visible = True
        Me.Qty_Order.VisibleIndex = 11
        Me.Qty_Order.Width = 62
        '
        'Qty_Kirim
        '
        Me.Qty_Kirim.AppearanceCell.Options.UseTextOptions = True
        Me.Qty_Kirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_Kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_Kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty_Kirim.Caption = "Jumlah Kirim"
        Me.Qty_Kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty_Kirim.FieldName = "qty_rcn_krm"
        Me.Qty_Kirim.Name = "Qty_Kirim"
        Me.Qty_Kirim.OptionsColumn.AllowEdit = False
        Me.Qty_Kirim.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Qty_Kirim.OptionsColumn.ReadOnly = True
        Me.Qty_Kirim.SummaryItem.FieldName = "jumlah"
        Me.Qty_Kirim.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_Kirim.Visible = True
        Me.Qty_Kirim.VisibleIndex = 12
        Me.Qty_Kirim.Width = 51
        '
        'ColBatal
        '
        Me.ColBatal.AppearanceCell.Options.UseTextOptions = True
        Me.ColBatal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBatal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColBatal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBatal.Caption = "Jumlah Balik"
        Me.ColBatal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColBatal.FieldName = "qty_balik"
        Me.ColBatal.Name = "ColBatal"
        Me.ColBatal.OptionsColumn.AllowEdit = False
        Me.ColBatal.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.ColBatal.OptionsColumn.ReadOnly = True
        Me.ColBatal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ColBatal.Visible = True
        Me.ColBatal.VisibleIndex = 13
        '
        'Jml_Prod
        '
        Me.Jml_Prod.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.Jml_Prod.AppearanceCell.Options.UseBorderColor = True
        Me.Jml_Prod.AppearanceHeader.Options.UseTextOptions = True
        Me.Jml_Prod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Jml_Prod.Caption = "Jumlah Produksi"
        Me.Jml_Prod.FieldName = "qty_rcn_prod"
        Me.Jml_Prod.Name = "Jml_Prod"
        Me.Jml_Prod.OptionsColumn.AllowEdit = False
        Me.Jml_Prod.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Jml_Prod.OptionsColumn.ReadOnly = True
        Me.Jml_Prod.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Jml_Prod.Visible = True
        Me.Jml_Prod.VisibleIndex = 14
        Me.Jml_Prod.Width = 70
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Admin SP"
        Me.GridColumn1.FieldName = "last_created_by"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 15
        '
        'gvMain
        '
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nama_jenis1, Me.jumlah_kapasitas})
        Me.gvMain.GridControl = Me.gc
        Me.gvMain.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvMain.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvMain.OptionsView.ShowGroupPanel = False
        '
        'nama_jenis1
        '
        Me.nama_jenis1.Caption = "Nama Jenis"
        Me.nama_jenis1.FieldName = "Nama_Jenis1"
        Me.nama_jenis1.Name = "nama_jenis1"
        Me.nama_jenis1.OptionsColumn.AllowEdit = False
        Me.nama_jenis1.OptionsColumn.ReadOnly = True
        Me.nama_jenis1.Visible = True
        Me.nama_jenis1.VisibleIndex = 0
        '
        'jumlah_kapasitas
        '
        Me.jumlah_kapasitas.Caption = "Kapasitas"
        Me.jumlah_kapasitas.FieldName = "jml_kapasitas"
        Me.jumlah_kapasitas.Name = "jumlah_kapasitas"
        Me.jumlah_kapasitas.Visible = True
        Me.jumlah_kapasitas.VisibleIndex = 1
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.ForeColor = System.Drawing.Color.Black
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1007, 558)
        Me.pnl.TabIndex = 3
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(1005, 525)
        Me.pnlTengah.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CEHijau)
        Me.Panel1.Controls.Add(Me.CEMerah)
        Me.Panel1.Controls.Add(Me.CEKuning)
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 48)
        Me.Panel1.TabIndex = 0
        '
        'CEHijau
        '
        Me.CEHijau.Location = New System.Drawing.Point(286, 12)
        Me.CEHijau.Name = "CEHijau"
        Me.CEHijau.Properties.Appearance.BackColor = System.Drawing.Color.Lime
        Me.CEHijau.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEHijau.Properties.Appearance.Options.UseBackColor = True
        Me.CEHijau.Properties.Appearance.Options.UseFont = True
        Me.CEHijau.Properties.Caption = "Proses Rencana Produksi"
        Me.CEHijau.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEHijau.Size = New System.Drawing.Size(269, 19)
        Me.CEHijau.TabIndex = 30
        '
        'CEMerah
        '
        Me.CEMerah.Location = New System.Drawing.Point(561, 12)
        Me.CEMerah.Name = "CEMerah"
        Me.CEMerah.Properties.Appearance.BackColor = System.Drawing.Color.Red
        Me.CEMerah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEMerah.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CEMerah.Properties.Appearance.Options.UseBackColor = True
        Me.CEMerah.Properties.Appearance.Options.UseFont = True
        Me.CEMerah.Properties.Appearance.Options.UseForeColor = True
        Me.CEMerah.Properties.Caption = "Proses Rencana Kirim + Rencana Produksi)"
        Me.CEMerah.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEMerah.Size = New System.Drawing.Size(269, 19)
        Me.CEMerah.TabIndex = 28
        '
        'CEKuning
        '
        Me.CEKuning.Location = New System.Drawing.Point(11, 12)
        Me.CEKuning.Name = "CEKuning"
        Me.CEKuning.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.CEKuning.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEKuning.Properties.Appearance.Options.UseBackColor = True
        Me.CEKuning.Properties.Appearance.Options.UseFont = True
        Me.CEKuning.Properties.Caption = "Proses Rencana Kirim"
        Me.CEKuning.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEKuning.Size = New System.Drawing.Size(269, 19)
        Me.CEKuning.TabIndex = 29
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(836, 4)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(71, 42)
        Me.cmdRefresh.TabIndex = 27
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Maroon
        Me.pnlAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtas.Controls.Add(Me.LabelControl1)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(1005, 31)
        Me.pnlAtas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(368, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "   MONITORING STATUS SP"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentation.My.Resources.Resources.note_view
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMonSP_PPIC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 558)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonSP_PPIC"
        Me.Text = "frmMonSP_PPIC"
        CType(Me.GV_Kirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Produksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_ProdCentian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DetailSOBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.CEHijau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEMerah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEKuning.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_wilayah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_Order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jml_Prod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_Kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nama_jenis1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_kapasitas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_Kirim As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNoTrans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColJmlKirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_Produksi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNoProduksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColJmlProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CEHijau As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEMerah As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEKuning As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GV_ProdCentian As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KdBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tebal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panjang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lebar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_prodcent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_DetailSOBOX As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Jml_Prod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_no_Rph As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColOld_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTglProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTglKirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTanggalProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTanggalProdCen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBatal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_JumlahBalik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColKetKirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
