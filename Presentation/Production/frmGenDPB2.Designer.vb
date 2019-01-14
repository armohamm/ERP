<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenDPB2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenDPB2))
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dtKdBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtNamaBrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtKdSatuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtJumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pelanggan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_wilayah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_area = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_dpb = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.btnCetak = New System.Windows.Forms.Button
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.pnl2 = New System.Windows.Forms.Panel
        Me.pnl22 = New System.Windows.Forms.Panel
        Me.txt_KdKernet = New DevExpress.XtraEditors.TextEdit
        Me.txt_KdSopir = New DevExpress.XtraEditors.TextEdit
        Me.pnl21 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.pnl12 = New System.Windows.Forms.Panel
        Me.txt_kdKendaraan = New DevExpress.XtraEditors.TextEdit
        Me.txtNoTrans = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.pnl11 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtKernet = New DevExpress.XtraEditors.LookUpEdit
        Me.txtSopir = New DevExpress.XtraEditors.LookUpEdit
        Me.txtKendaraan = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTools.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.pnl22.SuspendLayout()
        CType(Me.txt_KdKernet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_KdSopir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl21.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.pnl12.SuspendLayout()
        CType(Me.txt_kdKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl11.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKernet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSopir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV_Detail
        '
        Me.GV_Detail.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Detail.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Detail.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_Detail.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_Detail.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_Detail.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Detail.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV_Detail.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Detail.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Detail.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_Detail.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_Detail.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_Detail.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_Detail.Appearance.Empty.Options.UseBackColor = True
        Me.GV_Detail.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_Detail.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_Detail.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Detail.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Detail.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_Detail.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_Detail.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_Detail.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_Detail.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_Detail.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_Detail.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_Detail.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV_Detail.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_Detail.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_Detail.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_Detail.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_Detail.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV_Detail.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_Detail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_Detail.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_Detail.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Detail.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Detail.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_Detail.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_Detail.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_Detail.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Detail.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Detail.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_Detail.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_Detail.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_Detail.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Detail.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Detail.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_Detail.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_Detail.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_Detail.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_Detail.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_Detail.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_Detail.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Detail.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Detail.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Detail.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_Detail.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_Detail.Appearance.GroupRow.Options.UseFont = True
        Me.GV_Detail.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_Detail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Detail.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Detail.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Detail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_Detail.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_Detail.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_Detail.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Detail.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_Detail.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_Detail.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_Detail.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_Detail.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_Detail.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_Detail.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_Detail.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_Detail.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Detail.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_Detail.Appearance.Preview.Options.UseBackColor = True
        Me.GV_Detail.Appearance.Preview.Options.UseForeColor = True
        Me.GV_Detail.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_Detail.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_Detail.Appearance.Row.Options.UseBackColor = True
        Me.GV_Detail.Appearance.Row.Options.UseForeColor = True
        Me.GV_Detail.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_Detail.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_Detail.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV_Detail.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_Detail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_Detail.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_Detail.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_Detail.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.dtKdBarang, Me.dtNamaBrg, Me.dtKdSatuan, Me.dtJumlah})
        Me.GV_Detail.GridControl = Me.GC
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsPrint.ExpandAllDetails = True
        Me.GV_Detail.OptionsPrint.PrintDetails = True
        Me.GV_Detail.OptionsPrint.PrintFilterInfo = True
        Me.GV_Detail.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Detail.OptionsView.EnableAppearanceOddRow = True
        Me.GV_Detail.OptionsView.ShowGroupPanel = False
        '
        'dtKdBarang
        '
        Me.dtKdBarang.AppearanceCell.Options.UseTextOptions = True
        Me.dtKdBarang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtKdBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.dtKdBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtKdBarang.Caption = "Kode Barang"
        Me.dtKdBarang.FieldName = "Kd_Stok"
        Me.dtKdBarang.Name = "dtKdBarang"
        Me.dtKdBarang.OptionsColumn.AllowEdit = False
        Me.dtKdBarang.OptionsColumn.FixedWidth = True
        Me.dtKdBarang.OptionsColumn.ReadOnly = True
        Me.dtKdBarang.Visible = True
        Me.dtKdBarang.VisibleIndex = 0
        '
        'dtNamaBrg
        '
        Me.dtNamaBrg.AppearanceCell.Options.UseTextOptions = True
        Me.dtNamaBrg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.dtNamaBrg.AppearanceHeader.Options.UseTextOptions = True
        Me.dtNamaBrg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtNamaBrg.Caption = "Nama Barang"
        Me.dtNamaBrg.FieldName = "Nama_Barang"
        Me.dtNamaBrg.Name = "dtNamaBrg"
        Me.dtNamaBrg.OptionsColumn.AllowEdit = False
        Me.dtNamaBrg.OptionsColumn.FixedWidth = True
        Me.dtNamaBrg.OptionsColumn.ReadOnly = True
        Me.dtNamaBrg.Visible = True
        Me.dtNamaBrg.VisibleIndex = 1
        '
        'dtKdSatuan
        '
        Me.dtKdSatuan.AppearanceCell.Options.UseTextOptions = True
        Me.dtKdSatuan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtKdSatuan.AppearanceHeader.Options.UseTextOptions = True
        Me.dtKdSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtKdSatuan.Caption = "Kode Satuan"
        Me.dtKdSatuan.FieldName = "Kd_Satuan"
        Me.dtKdSatuan.Name = "dtKdSatuan"
        Me.dtKdSatuan.OptionsColumn.AllowEdit = False
        Me.dtKdSatuan.OptionsColumn.FixedWidth = True
        Me.dtKdSatuan.OptionsColumn.ReadOnly = True
        Me.dtKdSatuan.Visible = True
        Me.dtKdSatuan.VisibleIndex = 2
        '
        'dtJumlah
        '
        Me.dtJumlah.AppearanceCell.Options.UseTextOptions = True
        Me.dtJumlah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtJumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.dtJumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtJumlah.Caption = "Jumlah"
        Me.dtJumlah.FieldName = "jumlah"
        Me.dtJumlah.Name = "dtJumlah"
        Me.dtJumlah.OptionsColumn.AllowEdit = False
        Me.dtJumlah.OptionsColumn.FixedWidth = True
        Me.dtJumlah.OptionsColumn.ReadOnly = True
        Me.dtJumlah.Visible = True
        Me.dtJumlah.VisibleIndex = 3
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV_Detail
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 93)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(925, 410)
        Me.GC.TabIndex = 14
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GV_Detail})
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseFont = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clNo, Me.no_sp, Me.Pelanggan, Me.nm_wilayah, Me.nm_area, Me.no_dpb})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.PaintStyleName = "Skin"
        '
        'clNo
        '
        Me.clNo.AppearanceCell.Options.UseTextOptions = True
        Me.clNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clNo.AppearanceHeader.Options.UseTextOptions = True
        Me.clNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clNo.Caption = "No."
        Me.clNo.FieldName = "no_sp_dtl"
        Me.clNo.Name = "clNo"
        Me.clNo.OptionsColumn.AllowEdit = False
        Me.clNo.Width = 109
        '
        'no_sp
        '
        Me.no_sp.AppearanceCell.Options.UseTextOptions = True
        Me.no_sp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.Caption = "No. SP"
        Me.no_sp.FieldName = "no_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 0
        Me.no_sp.Width = 191
        '
        'Pelanggan
        '
        Me.Pelanggan.AppearanceCell.Options.UseTextOptions = True
        Me.Pelanggan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.Pelanggan.AppearanceHeader.Options.UseTextOptions = True
        Me.Pelanggan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Pelanggan.Caption = "Nama Customer"
        Me.Pelanggan.FieldName = "Nama_Customer"
        Me.Pelanggan.Name = "Pelanggan"
        Me.Pelanggan.OptionsColumn.AllowEdit = False
        Me.Pelanggan.OptionsColumn.ReadOnly = True
        Me.Pelanggan.Visible = True
        Me.Pelanggan.VisibleIndex = 1
        Me.Pelanggan.Width = 235
        '
        'nm_wilayah
        '
        Me.nm_wilayah.AppearanceCell.Options.UseTextOptions = True
        Me.nm_wilayah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nm_wilayah.AppearanceHeader.Options.UseTextOptions = True
        Me.nm_wilayah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nm_wilayah.Caption = "Wilayah"
        Me.nm_wilayah.FieldName = "Nama_Wilayah"
        Me.nm_wilayah.Name = "nm_wilayah"
        Me.nm_wilayah.OptionsColumn.AllowEdit = False
        Me.nm_wilayah.OptionsColumn.ReadOnly = True
        Me.nm_wilayah.Visible = True
        Me.nm_wilayah.VisibleIndex = 2
        Me.nm_wilayah.Width = 123
        '
        'nm_area
        '
        Me.nm_area.AppearanceCell.Options.UseTextOptions = True
        Me.nm_area.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nm_area.AppearanceHeader.Options.UseTextOptions = True
        Me.nm_area.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nm_area.Caption = "Area"
        Me.nm_area.FieldName = "Nama_Area"
        Me.nm_area.Name = "nm_area"
        Me.nm_area.OptionsColumn.AllowEdit = False
        Me.nm_area.OptionsColumn.ReadOnly = True
        Me.nm_area.Visible = True
        Me.nm_area.VisibleIndex = 3
        Me.nm_area.Width = 112
        '
        'no_dpb
        '
        Me.no_dpb.AppearanceCell.Options.UseTextOptions = True
        Me.no_dpb.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.no_dpb.AppearanceHeader.Options.UseTextOptions = True
        Me.no_dpb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_dpb.Caption = "No. DPB"
        Me.no_dpb.FieldName = "no_dpb"
        Me.no_dpb.Name = "no_dpb"
        Me.no_dpb.OptionsColumn.AllowEdit = False
        Me.no_dpb.OptionsColumn.ReadOnly = True
        Me.no_dpb.Visible = True
        Me.no_dpb.VisibleIndex = 4
        Me.no_dpb.Width = 145
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.btnCetak)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Controls.Add(Me.txtKernet)
        Me.pnl.Controls.Add(Me.txtSopir)
        Me.pnl.Controls.Add(Me.txtKendaraan)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(927, 505)
        Me.pnl.TabIndex = 2
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(703, 122)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 23)
        Me.btnCetak.TabIndex = 8
        Me.btnCetak.Text = "Button1"
        Me.btnCetak.UseVisualStyleBackColor = True
        Me.btnCetak.Visible = False
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.pnl2)
        Me.pnlTools.Controls.Add(Me.pnl1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(925, 59)
        Me.pnlTools.TabIndex = 5
        '
        'pnl2
        '
        Me.pnl2.Controls.Add(Me.pnl22)
        Me.pnl2.Controls.Add(Me.pnl21)
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl2.Location = New System.Drawing.Point(406, 0)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(480, 59)
        Me.pnl2.TabIndex = 1
        '
        'pnl22
        '
        Me.pnl22.Controls.Add(Me.txt_KdKernet)
        Me.pnl22.Controls.Add(Me.txt_KdSopir)
        Me.pnl22.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl22.Location = New System.Drawing.Point(170, 0)
        Me.pnl22.Name = "pnl22"
        Me.pnl22.Size = New System.Drawing.Size(317, 59)
        Me.pnl22.TabIndex = 4
        '
        'txt_KdKernet
        '
        Me.txt_KdKernet.Location = New System.Drawing.Point(0, 22)
        Me.txt_KdKernet.Name = "txt_KdKernet"
        Me.txt_KdKernet.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_KdKernet.Properties.Appearance.Options.UseBackColor = True
        Me.txt_KdKernet.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_KdKernet.Properties.ReadOnly = True
        Me.txt_KdKernet.Size = New System.Drawing.Size(124, 20)
        Me.txt_KdKernet.TabIndex = 11
        '
        'txt_KdSopir
        '
        Me.txt_KdSopir.Location = New System.Drawing.Point(0, 1)
        Me.txt_KdSopir.Name = "txt_KdSopir"
        Me.txt_KdSopir.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_KdSopir.Properties.Appearance.Options.UseBackColor = True
        Me.txt_KdSopir.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_KdSopir.Properties.ReadOnly = True
        Me.txt_KdSopir.Size = New System.Drawing.Size(124, 20)
        Me.txt_KdSopir.TabIndex = 10
        '
        'pnl21
        '
        Me.pnl21.Controls.Add(Me.Label2)
        Me.pnl21.Controls.Add(Me.Label11)
        Me.pnl21.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl21.Location = New System.Drawing.Point(0, 0)
        Me.pnl21.Name = "pnl21"
        Me.pnl21.Size = New System.Drawing.Size(170, 59)
        Me.pnl21.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Kernet : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Sopir : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.pnl12)
        Me.pnl1.Controls.Add(Me.pnl11)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(406, 59)
        Me.pnl1.TabIndex = 0
        '
        'pnl12
        '
        Me.pnl12.Controls.Add(Me.txt_kdKendaraan)
        Me.pnl12.Controls.Add(Me.txtNoTrans)
        Me.pnl12.Controls.Add(Me.TextEdit1)
        Me.pnl12.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl12.Location = New System.Drawing.Point(141, 0)
        Me.pnl12.Name = "pnl12"
        Me.pnl12.Size = New System.Drawing.Size(301, 59)
        Me.pnl12.TabIndex = 3
        '
        'txt_kdKendaraan
        '
        Me.txt_kdKendaraan.Location = New System.Drawing.Point(1, 21)
        Me.txt_kdKendaraan.Name = "txt_kdKendaraan"
        Me.txt_kdKendaraan.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_kdKendaraan.Properties.Appearance.Options.UseBackColor = True
        Me.txt_kdKendaraan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_kdKendaraan.Properties.ReadOnly = True
        Me.txt_kdKendaraan.Size = New System.Drawing.Size(124, 20)
        Me.txt_kdKendaraan.TabIndex = 5
        '
        'txtNoTrans
        '
        Me.txtNoTrans.Location = New System.Drawing.Point(0, 0)
        Me.txtNoTrans.Name = "txtNoTrans"
        Me.txtNoTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNoTrans.Properties.NullText = "[Pilih No Transaksi]"
        Me.txtNoTrans.Size = New System.Drawing.Size(265, 20)
        Me.txtNoTrans.TabIndex = 0
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(0, 0)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Silver
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(265, 20)
        Me.TextEdit1.TabIndex = 12
        '
        'pnl11
        '
        Me.pnl11.Controls.Add(Me.Label12)
        Me.pnl11.Controls.Add(Me.Label6)
        Me.pnl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl11.Location = New System.Drawing.Point(0, 0)
        Me.pnl11.Name = "pnl11"
        Me.pnl11.Size = New System.Drawing.Size(141, 59)
        Me.pnl11.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Kendaraan : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "* No. Rencana Kirim : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlTitle.Size = New System.Drawing.Size(925, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(426, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "GENERATE DAFTAR PERMINTAAN BARANG"
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
        'txtKernet
        '
        Me.txtKernet.Enabled = False
        Me.txtKernet.Location = New System.Drawing.Point(318, 119)
        Me.txtKernet.Name = "txtKernet"
        Me.txtKernet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKernet.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sopir", "Name6", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", 200, "Nama")})
        Me.txtKernet.Properties.DisplayMember = "Nama_Sopir"
        Me.txtKernet.Properties.NullText = "[Pilih Kernet]"
        Me.txtKernet.Properties.ValueMember = "Kode_Sopir"
        Me.txtKernet.Size = New System.Drawing.Size(187, 20)
        Me.txtKernet.TabIndex = 13
        '
        'txtSopir
        '
        Me.txtSopir.Enabled = False
        Me.txtSopir.Location = New System.Drawing.Point(105, 119)
        Me.txtSopir.Name = "txtSopir"
        Me.txtSopir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSopir.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sopir", "Name4", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", 200, "Sopir")})
        Me.txtSopir.Properties.DisplayMember = "Nama_Sopir"
        Me.txtSopir.Properties.NullText = "[Pilih Sopir]"
        Me.txtSopir.Properties.ValueMember = "Kode_Sopir"
        Me.txtSopir.Size = New System.Drawing.Size(187, 20)
        Me.txtSopir.TabIndex = 12
        '
        'txtKendaraan
        '
        Me.txtKendaraan.Enabled = False
        Me.txtKendaraan.Location = New System.Drawing.Point(541, 119)
        Me.txtKendaraan.Name = "txtKendaraan"
        Me.txtKendaraan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKendaraan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("No_Polisi", "No Pol."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kendaraan", "Kendaraan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kapasitas", "Kapasitas", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.txtKendaraan.Properties.DisplayMember = "Nama_Kendaraan"
        Me.txtKendaraan.Properties.NullText = "[Pilih Kendaraan]"
        Me.txtKendaraan.Properties.ValueMember = "Kode_Kendaraan"
        Me.txtKendaraan.Size = New System.Drawing.Size(141, 20)
        Me.txtKendaraan.TabIndex = 6
        '
        'frmGenDPB2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 529)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmGenDPB2"
        Me.Text = "frmGenDPB2"
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTools.ResumeLayout(False)
        Me.pnl2.ResumeLayout(False)
        Me.pnl22.ResumeLayout(False)
        CType(Me.txt_KdKernet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_KdSopir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl21.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        Me.pnl12.ResumeLayout(False)
        CType(Me.txt_kdKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl11.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKernet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSopir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents pnl22 As System.Windows.Forms.Panel
    Friend WithEvents pnl21 As System.Windows.Forms.Panel
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents pnl12 As System.Windows.Forms.Panel
    Friend WithEvents txtNoTrans As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pnl11 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_kdKendaraan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_KdKernet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_KdSopir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKendaraan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtKernet As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSopir As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtKdBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtNamaBrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtKdSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtJumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pelanggan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_wilayah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_dpb As DevExpress.XtraGrid.Columns.GridColumn
End Class
