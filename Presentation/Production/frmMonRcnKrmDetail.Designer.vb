<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonRcnKrmDetail
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
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKodeBrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNoSP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColNmCust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColKetKrm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNamaBrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColKet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNoTrans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColNoGudOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Col_NoSJ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtyGudOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtyOrder = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtyKirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtyRcn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNamaJenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUkuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.deTglSelesai = New DevExpress.XtraEditors.DateEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lueNoTrans = New DevExpress.XtraEditors.LookUpEdit
        Me.deTglMulai = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.deTglSelesai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglSelesai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.lueNoTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc
        '
        Me.gc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gc.Location = New System.Drawing.Point(0, 47)
        Me.gc.LookAndFeel.SkinName = "Black"
        Me.gc.MainView = Me.gvMain
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gc.Size = New System.Drawing.Size(983, 428)
        Me.gc.TabIndex = 6
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvMain.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.Empty.Options.UseBackColor = True
        Me.gvMain.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvMain.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvMain.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvMain.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvMain.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvMain.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvMain.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvMain.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvMain.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvMain.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvMain.Appearance.GroupRow.Options.UseFont = True
        Me.gvMain.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvMain.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMain.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvMain.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvMain.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvMain.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvMain.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.OddRow.Options.UseBackColor = True
        Me.gvMain.Appearance.OddRow.Options.UseForeColor = True
        Me.gvMain.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMain.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvMain.Appearance.Preview.Options.UseBackColor = True
        Me.gvMain.Appearance.Preview.Options.UseForeColor = True
        Me.gvMain.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.Row.Options.UseBackColor = True
        Me.gvMain.Appearance.Row.Options.UseForeColor = True
        Me.gvMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvMain.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvMain.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvMain.Appearance.VertLine.Options.UseBackColor = True
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBrg, Me.colNoSP, Me.ColNmCust, Me.ColKetKrm, Me.colNamaBrg, Me.ColKet, Me.colSatuan, Me.colNoTrans, Me.colTanggal, Me.ColNoGudOut, Me.GridColumn1, Me.GridColumn2, Me.Col_NoSJ, Me.GridColumn3, Me.colQtyGudOut, Me.colQtyOrder, Me.colQtyKirim, Me.colQtyRcn, Me.colNamaJenis, Me.colTipe, Me.colUkuran})
        Me.gvMain.GridControl = Me.gc
        Me.gvMain.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvMain.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvMain.OptionsPrint.ExpandAllDetails = True
        Me.gvMain.OptionsPrint.PrintDetails = True
        Me.gvMain.OptionsPrint.UsePrintStyles = True
        Me.gvMain.OptionsView.ColumnAutoWidth = False
        Me.gvMain.OptionsView.EnableAppearanceEvenRow = True
        Me.gvMain.OptionsView.EnableAppearanceOddRow = True
        Me.gvMain.OptionsView.ShowFooter = True
        Me.gvMain.OptionsView.ShowViewCaption = True
        Me.gvMain.PaintStyleName = "Skin"
        Me.gvMain.ViewCaption = "DAFTAR PLANNING KIRIM"
        '
        'colKodeBrg
        '
        Me.colKodeBrg.Caption = "Kode Barang"
        Me.colKodeBrg.FieldName = "kode_barang"
        Me.colKodeBrg.Name = "colKodeBrg"
        Me.colKodeBrg.OptionsColumn.AllowEdit = False
        Me.colKodeBrg.OptionsColumn.ReadOnly = True
        '
        'colNoSP
        '
        Me.colNoSP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoSP.Caption = "No. SP"
        Me.colNoSP.FieldName = "no_sp"
        Me.colNoSP.Name = "colNoSP"
        Me.colNoSP.OptionsColumn.AllowEdit = False
        Me.colNoSP.OptionsColumn.ReadOnly = True
        Me.colNoSP.Visible = True
        Me.colNoSP.VisibleIndex = 0
        '
        'ColNmCust
        '
        Me.ColNmCust.Caption = "Nama Customer"
        Me.ColNmCust.FieldName = "Nama_Customer"
        Me.ColNmCust.Name = "ColNmCust"
        Me.ColNmCust.OptionsColumn.AllowEdit = False
        Me.ColNmCust.Visible = True
        Me.ColNmCust.VisibleIndex = 1
        '
        'ColKetKrm
        '
        Me.ColKetKrm.Caption = "Keterangan Kirim"
        Me.ColKetKrm.FieldName = "Keterangan_krm"
        Me.ColKetKrm.Name = "ColKetKrm"
        Me.ColKetKrm.OptionsColumn.AllowEdit = False
        Me.ColKetKrm.Visible = True
        Me.ColKetKrm.VisibleIndex = 2
        Me.ColKetKrm.Width = 100
        '
        'colNamaBrg
        '
        Me.colNamaBrg.AppearanceHeader.Options.UseTextOptions = True
        Me.colNamaBrg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNamaBrg.Caption = "Nama Barang"
        Me.colNamaBrg.FieldName = "Nama_Barang"
        Me.colNamaBrg.Name = "colNamaBrg"
        Me.colNamaBrg.OptionsColumn.AllowEdit = False
        Me.colNamaBrg.OptionsColumn.ReadOnly = True
        Me.colNamaBrg.Visible = True
        Me.colNamaBrg.VisibleIndex = 3
        '
        'ColKet
        '
        Me.ColKet.Caption = "Keterangan"
        Me.ColKet.FieldName = "Keterangan"
        Me.ColKet.Name = "ColKet"
        Me.ColKet.Visible = True
        Me.ColKet.VisibleIndex = 4
        '
        'colSatuan
        '
        Me.colSatuan.AppearanceHeader.Options.UseTextOptions = True
        Me.colSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSatuan.Caption = "Satuan"
        Me.colSatuan.FieldName = "nama_satuan"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.OptionsColumn.AllowEdit = False
        Me.colSatuan.OptionsColumn.ReadOnly = True
        Me.colSatuan.Visible = True
        Me.colSatuan.VisibleIndex = 5
        '
        'colNoTrans
        '
        Me.colNoTrans.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoTrans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoTrans.Caption = "No. Rencana Kirim"
        Me.colNoTrans.FieldName = "no_trans"
        Me.colNoTrans.Name = "colNoTrans"
        Me.colNoTrans.OptionsColumn.AllowEdit = False
        Me.colNoTrans.OptionsColumn.ReadOnly = True
        Me.colNoTrans.Visible = True
        Me.colNoTrans.VisibleIndex = 6
        '
        'colTanggal
        '
        Me.colTanggal.AppearanceHeader.Options.UseTextOptions = True
        Me.colTanggal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTanggal.Caption = "Tanggal Rencana Kirim"
        Me.colTanggal.FieldName = "tanggal_rcn_krm"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.OptionsColumn.AllowEdit = False
        Me.colTanggal.OptionsColumn.ReadOnly = True
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 7
        '
        'ColNoGudOut
        '
        Me.ColNoGudOut.Caption = "No Gudang Out"
        Me.ColNoGudOut.FieldName = "no_gudang_out"
        Me.ColNoGudOut.Name = "ColNoGudOut"
        Me.ColNoGudOut.Visible = True
        Me.ColNoGudOut.VisibleIndex = 8
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tanggal Gudang Out"
        Me.GridColumn1.FieldName = "tanggal_gudang_out"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 10
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Status Submit SJ"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn2.FieldName = "sudah_sj"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 11
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Col_NoSJ
        '
        Me.Col_NoSJ.Caption = "No. SJ"
        Me.Col_NoSJ.FieldName = "no_sj"
        Me.Col_NoSJ.Name = "Col_NoSJ"
        Me.Col_NoSJ.OptionsColumn.AllowEdit = False
        Me.Col_NoSJ.Visible = True
        Me.Col_NoSJ.VisibleIndex = 12
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tanggal SJ"
        Me.GridColumn3.FieldName = "tanggal_kirim_sj"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 13
        '
        'colQtyGudOut
        '
        Me.colQtyGudOut.Caption = "Qty Gudang Out"
        Me.colQtyGudOut.DisplayFormat.FormatString = "N0"
        Me.colQtyGudOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyGudOut.FieldName = "qty_gudang_out"
        Me.colQtyGudOut.Name = "colQtyGudOut"
        Me.colQtyGudOut.OptionsColumn.AllowEdit = False
        Me.colQtyGudOut.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtyGudOut.Visible = True
        Me.colQtyGudOut.VisibleIndex = 16
        '
        'colQtyOrder
        '
        Me.colQtyOrder.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyOrder.Caption = "Jml. Order"
        Me.colQtyOrder.FieldName = "qty_order"
        Me.colQtyOrder.Name = "colQtyOrder"
        Me.colQtyOrder.OptionsColumn.AllowEdit = False
        Me.colQtyOrder.OptionsColumn.ReadOnly = True
        Me.colQtyOrder.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtyOrder.Visible = True
        Me.colQtyOrder.VisibleIndex = 9
        '
        'colQtyKirim
        '
        Me.colQtyKirim.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyKirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyKirim.Caption = "Qty Rencana Kirim"
        Me.colQtyKirim.FieldName = "qty_rcn_kirim"
        Me.colQtyKirim.Name = "colQtyKirim"
        Me.colQtyKirim.OptionsColumn.AllowEdit = False
        Me.colQtyKirim.OptionsColumn.ReadOnly = True
        Me.colQtyKirim.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtyKirim.Visible = True
        Me.colQtyKirim.VisibleIndex = 14
        '
        'colQtyRcn
        '
        Me.colQtyRcn.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyRcn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyRcn.Caption = "Qty Kirim Surat Jalan"
        Me.colQtyRcn.FieldName = "qty_kirim_sj"
        Me.colQtyRcn.Name = "colQtyRcn"
        Me.colQtyRcn.OptionsColumn.AllowEdit = False
        Me.colQtyRcn.OptionsColumn.ReadOnly = True
        Me.colQtyRcn.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtyRcn.Visible = True
        Me.colQtyRcn.VisibleIndex = 15
        '
        'colNamaJenis
        '
        Me.colNamaJenis.AppearanceHeader.Options.UseTextOptions = True
        Me.colNamaJenis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNamaJenis.Caption = "Nama Jenis"
        Me.colNamaJenis.FieldName = "nama_jenis"
        Me.colNamaJenis.Name = "colNamaJenis"
        Me.colNamaJenis.OptionsColumn.AllowEdit = False
        Me.colNamaJenis.OptionsColumn.ReadOnly = True
        '
        'colTipe
        '
        Me.colTipe.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipe.Caption = "Tipe Barang"
        Me.colTipe.FieldName = "tipe_stok"
        Me.colTipe.Name = "colTipe"
        Me.colTipe.OptionsColumn.AllowEdit = False
        Me.colTipe.OptionsColumn.ReadOnly = True
        '
        'colUkuran
        '
        Me.colUkuran.AppearanceHeader.Options.UseTextOptions = True
        Me.colUkuran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUkuran.Caption = "Ukuran"
        Me.colUkuran.FieldName = "nama_ukuran"
        Me.colUkuran.Name = "colUkuran"
        Me.colUkuran.OptionsColumn.AllowEdit = False
        Me.colUkuran.OptionsColumn.ReadOnly = True
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
        Me.pnl.Size = New System.Drawing.Size(985, 508)
        Me.pnl.TabIndex = 2
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(983, 475)
        Me.pnlTengah.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 41)
        Me.Panel1.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(797, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 31)
        Me.btnRefresh.TabIndex = 148
        Me.btnRefresh.Text = "Refresh"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.deTglSelesai)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(551, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 41)
        Me.Panel3.TabIndex = 7
        '
        'deTglSelesai
        '
        Me.deTglSelesai.Dock = System.Windows.Forms.DockStyle.Top
        Me.deTglSelesai.EditValue = Nothing
        Me.deTglSelesai.Location = New System.Drawing.Point(0, 0)
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
        Me.deTglSelesai.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(374, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(177, 41)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tanggal Selesai : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lueNoTrans)
        Me.Panel7.Controls.Add(Me.deTglMulai)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(183, 41)
        Me.Panel7.TabIndex = 5
        '
        'lueNoTrans
        '
        Me.lueNoTrans.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lueNoTrans.Location = New System.Drawing.Point(0, 21)
        Me.lueNoTrans.Name = "lueNoTrans"
        Me.lueNoTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNoTrans.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_trans", "No. Trans")})
        Me.lueNoTrans.Properties.NullText = "[Pilih No. Transaksi]"
        Me.lueNoTrans.Size = New System.Drawing.Size(183, 20)
        Me.lueNoTrans.TabIndex = 5
        Me.lueNoTrans.Visible = False
        '
        'deTglMulai
        '
        Me.deTglMulai.Dock = System.Windows.Forms.DockStyle.Top
        Me.deTglMulai.EditValue = Nothing
        Me.deTglMulai.Location = New System.Drawing.Point(0, 0)
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
        Me.deTglMulai.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 41)
        Me.Panel6.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. Transaksi : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tanggal Mulai : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlAtas.Size = New System.Drawing.Size(983, 31)
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
        Me.LabelControl1.Text = "   MONITORING PLANNING KIRIM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMonRcnKrmDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 508)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonRcnKrmDetail"
        Me.Text = "frmMonRcnKrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.deTglSelesai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglSelesai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.lueNoTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents deTglMulai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents deTglSelesai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colNoTrans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodeBrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaJenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUkuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyKirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyRcn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueNoTrans As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ColNmCust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNoGudOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyGudOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Col_NoSJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColKetKrm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColKet As DevExpress.XtraGrid.Columns.GridColumn
End Class
