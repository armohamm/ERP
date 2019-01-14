<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuratJalanBalik
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuratJalanBalik))
        Me.GVTarik = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoBalik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok_Balik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_Tarik_Balik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_satuanB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keteranganB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_balikB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TotKirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_balik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kirim_Ulang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repKirimUlang = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Me.Qty_batal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qtyy = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Desc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.popBiaya = New DevExpress.XtraEditors.PopupContainerControl
        Me.GC_Biaya = New DevExpress.XtraGrid.GridControl
        Me.GV_Biaya = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNum = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.tglSj = New DevExpress.XtraEditors.TextEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.txtBiayaKirim = New DevExpress.XtraEditors.SpinEdit
        Me.jamTerima = New DevExpress.XtraEditors.TimeEdit
        Me.tglTerima = New DevExpress.XtraEditors.DateEdit
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.txtNamaCustomer = New DevExpress.XtraEditors.TextEdit
        Me.txtNoSo = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.lblJenisSj = New System.Windows.Forms.Label
        Me.txtNoSj = New DevExpress.XtraEditors.TextEdit
        Me.txtNomorRef = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit
        Me.tab = New DevExpress.XtraTab.XtraTabControl
        Me.tabAlamat = New DevExpress.XtraTab.XtraTabPage
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.txtAlamatAgent = New DevExpress.XtraEditors.MemoEdit
        Me.txtNamaAgent = New DevExpress.XtraEditors.TextEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tabSopir = New DevExpress.XtraTab.XtraTabPage
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.txtKetKernet = New DevExpress.XtraEditors.TextEdit
        Me.txtKernet = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.txtKetSopir = New DevExpress.XtraEditors.TextEdit
        Me.txtSopir = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.txtketKendaraan = New DevExpress.XtraEditors.TextEdit
        Me.txtKendaraan = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GVTarik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKirimUlang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.popBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popBiaya.SuspendLayout()
        CType(Me.GC_Biaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Biaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.tglSj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.txtBiayaKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jamTerima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglTerima.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglTerima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.txtNamaCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        CType(Me.txtNoSj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomorRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel20.SuspendLayout()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        Me.tabAlamat.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.txtAlamatAgent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaAgent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.tabSopir.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.txtKetKernet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKernet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.txtKetSopir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSopir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        CType(Me.txtketKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVTarik
        '
        Me.GVTarik.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVTarik.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVTarik.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVTarik.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVTarik.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVTarik.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVTarik.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GVTarik.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVTarik.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVTarik.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVTarik.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVTarik.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVTarik.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVTarik.Appearance.Empty.Options.UseBackColor = True
        Me.GVTarik.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVTarik.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVTarik.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVTarik.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVTarik.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVTarik.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVTarik.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVTarik.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVTarik.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVTarik.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVTarik.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVTarik.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVTarik.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVTarik.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVTarik.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVTarik.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVTarik.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVTarik.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVTarik.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVTarik.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVTarik.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVTarik.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVTarik.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVTarik.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVTarik.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVTarik.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVTarik.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVTarik.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVTarik.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVTarik.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVTarik.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVTarik.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVTarik.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVTarik.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVTarik.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVTarik.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVTarik.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVTarik.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVTarik.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVTarik.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVTarik.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVTarik.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVTarik.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVTarik.Appearance.GroupRow.Options.UseFont = True
        Me.GVTarik.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVTarik.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVTarik.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVTarik.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVTarik.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVTarik.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVTarik.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVTarik.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVTarik.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVTarik.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVTarik.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVTarik.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVTarik.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVTarik.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVTarik.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.OddRow.Options.UseBackColor = True
        Me.GVTarik.Appearance.OddRow.Options.UseForeColor = True
        Me.GVTarik.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVTarik.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVTarik.Appearance.Preview.Options.UseBackColor = True
        Me.GVTarik.Appearance.Preview.Options.UseForeColor = True
        Me.GVTarik.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVTarik.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVTarik.Appearance.Row.Options.UseBackColor = True
        Me.GVTarik.Appearance.Row.Options.UseForeColor = True
        Me.GVTarik.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVTarik.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVTarik.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVTarik.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVTarik.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVTarik.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVTarik.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVTarik.Appearance.VertLine.Options.UseBackColor = True
        Me.GVTarik.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoBalik, Me.kd_stok_Balik, Me.GridColumn3, Me.Qty_Tarik_Balik, Me.kd_satuanB, Me.keteranganB, Me.Qty_balikB})
        Me.GVTarik.GridControl = Me.gc
        Me.GVTarik.Name = "GVTarik"
        Me.GVTarik.OptionsCustomization.AllowColumnMoving = False
        Me.GVTarik.OptionsCustomization.AllowFilter = False
        Me.GVTarik.OptionsCustomization.AllowGroup = False
        Me.GVTarik.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVTarik.OptionsCustomization.AllowSort = False
        Me.GVTarik.OptionsView.EnableAppearanceEvenRow = True
        Me.GVTarik.OptionsView.EnableAppearanceOddRow = True
        Me.GVTarik.OptionsView.ShowGroupPanel = False
        '
        'NoBalik
        '
        Me.NoBalik.Caption = "No"
        Me.NoBalik.FieldName = "no_seq"
        Me.NoBalik.Name = "NoBalik"
        Me.NoBalik.OptionsColumn.AllowEdit = False
        Me.NoBalik.OptionsColumn.AllowFocus = False
        Me.NoBalik.Visible = True
        Me.NoBalik.VisibleIndex = 0
        Me.NoBalik.Width = 50
        '
        'kd_stok_Balik
        '
        Me.kd_stok_Balik.Caption = "Deskripsi"
        Me.kd_stok_Balik.ColumnEdit = Me.repbarang
        Me.kd_stok_Balik.FieldName = "Kd_stok"
        Me.kd_stok_Balik.Name = "kd_stok_Balik"
        Me.kd_stok_Balik.OptionsColumn.AllowEdit = False
        Me.kd_stok_Balik.OptionsColumn.AllowFocus = False
        Me.kd_stok_Balik.Visible = True
        Me.kd_stok_Balik.VisibleIndex = 1
        Me.kd_stok_Balik.Width = 399
        '
        'repbarang
        '
        Me.repbarang.AutoHeight = False
        Me.repbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Name8"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Name9")})
        Me.repbarang.DisplayMember = "Nama_Barang"
        Me.repbarang.Name = "repbarang"
        Me.repbarang.NullText = ""
        Me.repbarang.ValueMember = "Kode_Barang"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.FieldName = "Qty"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'Qty_Tarik_Balik
        '
        Me.Qty_Tarik_Balik.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_Tarik_Balik.AppearanceCell.Options.UseFont = True
        Me.Qty_Tarik_Balik.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_Tarik_Balik.AppearanceHeader.Options.UseFont = True
        Me.Qty_Tarik_Balik.Caption = "Qty Tarik"
        Me.Qty_Tarik_Balik.FieldName = "Qty_kirim"
        Me.Qty_Tarik_Balik.Name = "Qty_Tarik_Balik"
        Me.Qty_Tarik_Balik.OptionsColumn.AllowEdit = False
        Me.Qty_Tarik_Balik.OptionsColumn.AllowFocus = False
        Me.Qty_Tarik_Balik.Visible = True
        Me.Qty_Tarik_Balik.VisibleIndex = 3
        Me.Qty_Tarik_Balik.Width = 72
        '
        'kd_satuanB
        '
        Me.kd_satuanB.Caption = "Satuan"
        Me.kd_satuanB.FieldName = "Kd_satuan"
        Me.kd_satuanB.Name = "kd_satuanB"
        Me.kd_satuanB.OptionsColumn.AllowEdit = False
        Me.kd_satuanB.OptionsColumn.AllowFocus = False
        Me.kd_satuanB.Visible = True
        Me.kd_satuanB.VisibleIndex = 2
        Me.kd_satuanB.Width = 56
        '
        'keteranganB
        '
        Me.keteranganB.Caption = "Keterangan"
        Me.keteranganB.FieldName = "Keterangan"
        Me.keteranganB.Name = "keteranganB"
        Me.keteranganB.Visible = True
        Me.keteranganB.VisibleIndex = 5
        Me.keteranganB.Width = 342
        '
        'Qty_balikB
        '
        Me.Qty_balikB.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_balikB.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.Qty_balikB.AppearanceCell.Options.UseFont = True
        Me.Qty_balikB.AppearanceCell.Options.UseForeColor = True
        Me.Qty_balikB.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_balikB.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.Qty_balikB.AppearanceHeader.Options.UseFont = True
        Me.Qty_balikB.AppearanceHeader.Options.UseForeColor = True
        Me.Qty_balikB.Caption = "Qty Balik"
        Me.Qty_balikB.FieldName = "Qty_balik"
        Me.Qty_balikB.Name = "Qty_balikB"
        Me.Qty_balikB.Visible = True
        Me.Qty_balikB.VisibleIndex = 4
        Me.Qty_balikB.Width = 70
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVTarik
        GridLevelNode1.RelationName = "Level1"
        Me.gc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gc.Location = New System.Drawing.Point(0, 122)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repbarang, Me.repKirimUlang})
        Me.gc.Size = New System.Drawing.Size(973, 340)
        Me.gc.TabIndex = 3
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv, Me.GVTarik})
        '
        'gv
        '
        Me.gv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gv.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.Empty.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.EvenRow.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.Options.UseForeColor = True
        Me.gv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.gv.Appearance.FixedLine.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.gv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gv.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupButton.Options.UseBackColor = True
        Me.gv.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gv.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gv.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupRow.Options.UseBackColor = True
        Me.gv.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gv.Appearance.GroupRow.Options.UseForeColor = True
        Me.gv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gv.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.HorzLine.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gv.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.OddRow.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.Options.UseForeColor = True
        Me.gv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.gv.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.gv.Appearance.Preview.Options.UseBackColor = True
        Me.gv.Appearance.Preview.Options.UseFont = True
        Me.gv.Appearance.Preview.Options.UseForeColor = True
        Me.gv.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gv.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gv.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.Row.Options.UseBackColor = True
        Me.gv.Appearance.Row.Options.UseBorderColor = True
        Me.gv.Appearance.Row.Options.UseForeColor = True
        Me.gv.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.gv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.VertLine.Options.UseBackColor = True
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.Kd_stok, Me.Qty, Me.Qty_kirim, Me.Kd_satuan, Me.Keterangan, Me.TotKirim, Me.Qty_balik, Me.Kirim_Ulang, Me.Qty_batal, Me.Qtyy, Me.Desc})
        Me.gv.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsView.EnableAppearanceEvenRow = True
        Me.gv.OptionsView.EnableAppearanceOddRow = True
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.OptionsView.ShowHorzLines = False
        Me.gv.OptionsView.ShowIndicator = False
        Me.gv.OptionsView.ShowVertLines = False
        '
        'No_seq
        '
        Me.No_seq.Caption = "No"
        Me.No_seq.FieldName = "no_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.OptionsColumn.AllowFocus = False
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 52
        '
        'Kd_stok
        '
        Me.Kd_stok.Caption = "Barang"
        Me.Kd_stok.FieldName = "Kd_stok"
        Me.Kd_stok.Name = "Kd_stok"
        Me.Kd_stok.OptionsColumn.AllowFocus = False
        Me.Kd_stok.Width = 300
        '
        'Qty
        '
        Me.Qty.AppearanceCell.Options.UseTextOptions = True
        Me.Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.AllowEdit = False
        Me.Qty.OptionsColumn.AllowFocus = False
        Me.Qty.Width = 67
        '
        'Qty_kirim
        '
        Me.Qty_kirim.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Qty_kirim.AppearanceCell.Options.UseFont = True
        Me.Qty_kirim.AppearanceCell.Options.UseTextOptions = True
        Me.Qty_kirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Qty_kirim.AppearanceHeader.Options.UseFont = True
        Me.Qty_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_kirim.Caption = "Qty Kirim"
        Me.Qty_kirim.FieldName = "Qty_kirim"
        Me.Qty_kirim.Name = "Qty_kirim"
        Me.Qty_kirim.OptionsColumn.AllowEdit = False
        Me.Qty_kirim.OptionsColumn.AllowFocus = False
        Me.Qty_kirim.Width = 76
        '
        'Kd_satuan
        '
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "Kd_satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.OptionsColumn.AllowEdit = False
        Me.Kd_satuan.OptionsColumn.AllowFocus = False
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 2
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 5
        Me.Keterangan.Width = 255
        '
        'TotKirim
        '
        Me.TotKirim.AppearanceCell.Options.UseTextOptions = True
        Me.TotKirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotKirim.AppearanceHeader.Options.UseTextOptions = True
        Me.TotKirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotKirim.Caption = "Total Kirim"
        Me.TotKirim.FieldName = "TotKirim"
        Me.TotKirim.Name = "TotKirim"
        Me.TotKirim.OptionsColumn.AllowEdit = False
        Me.TotKirim.OptionsColumn.AllowFocus = False
        '
        'Qty_balik
        '
        Me.Qty_balik.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Qty_balik.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.Qty_balik.AppearanceCell.Options.UseFont = True
        Me.Qty_balik.AppearanceCell.Options.UseForeColor = True
        Me.Qty_balik.AppearanceCell.Options.UseTextOptions = True
        Me.Qty_balik.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_balik.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Qty_balik.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.Qty_balik.AppearanceHeader.Options.UseFont = True
        Me.Qty_balik.AppearanceHeader.Options.UseForeColor = True
        Me.Qty_balik.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_balik.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_balik.Caption = "Qty Balik"
        Me.Qty_balik.FieldName = "Qty_balik"
        Me.Qty_balik.Name = "Qty_balik"
        Me.Qty_balik.Visible = True
        Me.Qty_balik.VisibleIndex = 4
        Me.Qty_balik.Width = 68
        '
        'Kirim_Ulang
        '
        Me.Kirim_Ulang.AppearanceHeader.Options.UseFont = True
        Me.Kirim_Ulang.Caption = "Kirim Ulang"
        Me.Kirim_Ulang.ColumnEdit = Me.repKirimUlang
        Me.Kirim_Ulang.FieldName = "Kirim_Ulang"
        Me.Kirim_Ulang.Name = "Kirim_Ulang"
        Me.Kirim_Ulang.Width = 111
        '
        'repKirimUlang
        '
        Me.repKirimUlang.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("T", "Tidak"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Y", "Ya")})
        Me.repKirimUlang.Name = "repKirimUlang"
        '
        'Qty_batal
        '
        Me.Qty_batal.Caption = "Batal"
        Me.Qty_batal.FieldName = "Qty_batal"
        Me.Qty_batal.Name = "Qty_batal"
        '
        'Qtyy
        '
        Me.Qtyy.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Qtyy.AppearanceCell.Options.UseFont = True
        Me.Qtyy.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Qtyy.AppearanceHeader.Options.UseFont = True
        Me.Qtyy.Caption = "Qty kirim"
        Me.Qtyy.FieldName = "GridColumn2"
        Me.Qtyy.Name = "Qtyy"
        Me.Qtyy.UnboundExpression = "[Qty_kirim]-[Qty_batal]"
        Me.Qtyy.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.Qtyy.Visible = True
        Me.Qtyy.VisibleIndex = 3
        Me.Qtyy.Width = 68
        '
        'Desc
        '
        Me.Desc.Caption = "Deskripsi"
        Me.Desc.FieldName = "deskripsi"
        Me.Desc.Name = "Desc"
        Me.Desc.Visible = True
        Me.Desc.VisibleIndex = 1
        Me.Desc.Width = 451
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.popBiaya)
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(973, 554)
        Me.pnl.TabIndex = 0
        '
        'popBiaya
        '
        Me.popBiaya.Controls.Add(Me.GC_Biaya)
        Me.popBiaya.Location = New System.Drawing.Point(287, 199)
        Me.popBiaya.LookAndFeel.SkinName = "Money Twins"
        Me.popBiaya.Name = "popBiaya"
        Me.popBiaya.Padding = New System.Windows.Forms.Padding(2)
        Me.popBiaya.Size = New System.Drawing.Size(398, 156)
        Me.popBiaya.TabIndex = 14
        '
        'GC_Biaya
        '
        Me.GC_Biaya.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Biaya.Location = New System.Drawing.Point(2, 2)
        Me.GC_Biaya.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC_Biaya.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC_Biaya.MainView = Me.GV_Biaya
        Me.GC_Biaya.Name = "GC_Biaya"
        Me.GC_Biaya.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repBiaya, Me.repNum})
        Me.GC_Biaya.Size = New System.Drawing.Size(394, 152)
        Me.GC_Biaya.TabIndex = 0
        Me.GC_Biaya.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Biaya})
        '
        'GV_Biaya
        '
        Me.GV_Biaya.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.Empty.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_Biaya.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GV_Biaya.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GV_Biaya.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GV_Biaya.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GV_Biaya.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GV_Biaya.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_Biaya.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GV_Biaya.Appearance.Preview.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.Preview.Options.UseFont = True
        Me.GV_Biaya.Appearance.Preview.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_Biaya.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_Biaya.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.Row.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.Row.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.Row.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GV_Biaya.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_Biaya.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_biaya, Me.biaya})
        Me.GV_Biaya.GridControl = Me.GC_Biaya
        Me.GV_Biaya.Name = "GV_Biaya"
        Me.GV_Biaya.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Biaya.OptionsView.EnableAppearanceOddRow = True
        Me.GV_Biaya.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Biaya.OptionsView.ShowFooter = True
        Me.GV_Biaya.OptionsView.ShowGroupPanel = False
        Me.GV_Biaya.OptionsView.ShowHorzLines = False
        Me.GV_Biaya.OptionsView.ShowVertLines = False
        '
        'kd_biaya
        '
        Me.kd_biaya.Caption = "Nama Biaya"
        Me.kd_biaya.ColumnEdit = Me.repBiaya
        Me.kd_biaya.FieldName = "kd_biaya"
        Me.kd_biaya.Name = "kd_biaya"
        Me.kd_biaya.Visible = True
        Me.kd_biaya.VisibleIndex = 0
        Me.kd_biaya.Width = 244
        '
        'repBiaya
        '
        Me.repBiaya.AutoHeight = False
        Me.repBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("deskripsi", "Biaya")})
        Me.repBiaya.DisplayMember = "deskripsi"
        Me.repBiaya.Name = "repBiaya"
        Me.repBiaya.NullText = ""
        Me.repBiaya.ValueMember = "kd_biaya"
        '
        'biaya
        '
        Me.biaya.Caption = "Besar Biaya"
        Me.biaya.ColumnEdit = Me.repNum
        Me.biaya.DisplayFormat.FormatString = "n2"
        Me.biaya.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.biaya.FieldName = "biaya"
        Me.biaya.Name = "biaya"
        Me.biaya.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.biaya.Visible = True
        Me.biaya.VisibleIndex = 1
        Me.biaya.Width = 133
        '
        'repNum
        '
        Me.repNum.AutoHeight = False
        Me.repNum.DisplayFormat.FormatString = "n2"
        Me.repNum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.EditFormat.FormatString = "n2"
        Me.repNum.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.Name = "repNum"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(973, 85)
        Me.Panel3.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(708, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(113, 85)
        Me.Panel6.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal SJ : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.tglSj)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(821, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(152, 85)
        Me.Panel7.TabIndex = 8
        '
        'tglSj
        '
        Me.tglSj.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglSj.Enabled = False
        Me.tglSj.Location = New System.Drawing.Point(0, 0)
        Me.tglSj.Name = "tglSj"
        Me.tglSj.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglSj.Properties.Appearance.Options.UseBackColor = True
        Me.tglSj.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglSj.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.tglSj.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.tglSj.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.tglSj.Size = New System.Drawing.Size(152, 20)
        Me.tglSj.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel18)
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel16)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(121, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(562, 85)
        Me.Panel5.TabIndex = 1
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.txtBiayaKirim)
        Me.Panel18.Controls.Add(Me.jamTerima)
        Me.Panel18.Controls.Add(Me.tglTerima)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 42)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(562, 40)
        Me.Panel18.TabIndex = 10
        '
        'txtBiayaKirim
        '
        Me.txtBiayaKirim.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBiayaKirim.Location = New System.Drawing.Point(0, 21)
        Me.txtBiayaKirim.Name = "txtBiayaKirim"
        Me.txtBiayaKirim.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtBiayaKirim.Properties.Appearance.Options.UseBackColor = True
        Me.txtBiayaKirim.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBiayaKirim.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtBiayaKirim.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtBiayaKirim.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtBiayaKirim.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBiayaKirim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBiayaKirim.Properties.EditFormat.FormatString = "n2"
        Me.txtBiayaKirim.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBiayaKirim.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtBiayaKirim.Size = New System.Drawing.Size(134, 20)
        Me.txtBiayaKirim.TabIndex = 14
        '
        'jamTerima
        '
        Me.jamTerima.Dock = System.Windows.Forms.DockStyle.Left
        Me.jamTerima.EditValue = New Date(2011, 5, 31, 0, 0, 0, 0)
        Me.jamTerima.Location = New System.Drawing.Point(134, 0)
        Me.jamTerima.Name = "jamTerima"
        Me.jamTerima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.jamTerima.Size = New System.Drawing.Size(64, 20)
        Me.jamTerima.TabIndex = 4
        '
        'tglTerima
        '
        Me.tglTerima.Dock = System.Windows.Forms.DockStyle.Left
        Me.tglTerima.EditValue = Nothing
        Me.tglTerima.Location = New System.Drawing.Point(0, 0)
        Me.tglTerima.Name = "tglTerima"
        Me.tglTerima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglTerima.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglTerima.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglTerima.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglTerima.Size = New System.Drawing.Size(134, 20)
        Me.tglTerima.TabIndex = 2
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.txtNamaCustomer)
        Me.Panel12.Controls.Add(Me.txtNoSo)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 21)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(562, 21)
        Me.Panel12.TabIndex = 9
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNamaCustomer.Enabled = False
        Me.txtNamaCustomer.Location = New System.Drawing.Point(198, 0)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtNamaCustomer.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaCustomer.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNamaCustomer.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNamaCustomer.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNamaCustomer.Size = New System.Drawing.Size(364, 20)
        Me.txtNamaCustomer.TabIndex = 11
        '
        'txtNoSo
        '
        Me.txtNoSo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNoSo.Location = New System.Drawing.Point(0, 0)
        Me.txtNoSo.Name = "txtNoSo"
        Me.txtNoSo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNoSo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sp", 50, "Nomor SP"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", "Name2", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 200, "Customer")})
        Me.txtNoSo.Properties.DisplayMember = "no_sp"
        Me.txtNoSo.Properties.NullText = "[Pilih Pelanggan]"
        Me.txtNoSo.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.txtNoSo.Properties.PopupFormMinSize = New System.Drawing.Size(450, 0)
        Me.txtNoSo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtNoSo.Properties.ValueMember = "no_sp"
        Me.txtNoSo.Size = New System.Drawing.Size(198, 20)
        Me.txtNoSo.TabIndex = 0
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.lblJenisSj)
        Me.Panel16.Controls.Add(Me.txtNoSj)
        Me.Panel16.Controls.Add(Me.txtNomorRef)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(562, 21)
        Me.Panel16.TabIndex = 7
        '
        'lblJenisSj
        '
        Me.lblJenisSj.Location = New System.Drawing.Point(338, 0)
        Me.lblJenisSj.Name = "lblJenisSj"
        Me.lblJenisSj.Size = New System.Drawing.Size(173, 20)
        Me.lblJenisSj.TabIndex = 9
        Me.lblJenisSj.Text = ")"
        Me.lblJenisSj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoSj
        '
        Me.txtNoSj.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNoSj.Enabled = False
        Me.txtNoSj.Location = New System.Drawing.Point(198, 0)
        Me.txtNoSj.Name = "txtNoSj"
        Me.txtNoSj.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoSj.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoSj.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoSj.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNoSj.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNoSj.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNoSj.Size = New System.Drawing.Size(134, 20)
        Me.txtNoSj.TabIndex = 10
        '
        'txtNomorRef
        '
        Me.txtNomorRef.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNomorRef.Location = New System.Drawing.Point(0, 0)
        Me.txtNomorRef.Name = "txtNomorRef"
        Me.txtNomorRef.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNomorRef.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_dpb", 100, "Nomor DPB"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sj", "Surat Jalan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("No_sp", "Nomor SP")})
        Me.txtNomorRef.Properties.DisplayMember = "no_dpb"
        Me.txtNomorRef.Properties.NullText = "[Nomor Referensi]"
        Me.txtNomorRef.Properties.PopupWidth = 250
        Me.txtNomorRef.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtNomorRef.Properties.ValueMember = "no_dpb"
        Me.txtNomorRef.Size = New System.Drawing.Size(198, 20)
        Me.txtNomorRef.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(121, 85)
        Me.Panel4.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(0, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Biaya Pengiriman : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Location = New System.Drawing.Point(0, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 20)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Tanggal Terima : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nomor SP : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Nomor DPB : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel15)
        Me.Panel2.Controls.Add(Me.tab)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 462)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(973, 92)
        Me.Panel2.TabIndex = 1
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Transparent
        Me.Panel15.Controls.Add(Me.Panel20)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(556, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(417, 92)
        Me.Panel15.TabIndex = 1
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel20.Controls.Add(Me.Label1)
        Me.Panel20.Controls.Add(Me.txtKeterangan)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(417, 92)
        Me.Panel20.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Keterangan :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 25)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(417, 67)
        Me.txtKeterangan.TabIndex = 4
        '
        'tab
        '
        Me.tab.Dock = System.Windows.Forms.DockStyle.Left
        Me.tab.Location = New System.Drawing.Point(0, 0)
        Me.tab.LookAndFeel.SkinName = "Black"
        Me.tab.LookAndFeel.UseDefaultLookAndFeel = False
        Me.tab.Name = "tab"
        Me.tab.SelectedTabPage = Me.tabAlamat
        Me.tab.Size = New System.Drawing.Size(556, 92)
        Me.tab.TabIndex = 0
        Me.tab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabAlamat, Me.tabSopir})
        '
        'tabAlamat
        '
        Me.tabAlamat.Controls.Add(Me.Panel9)
        Me.tabAlamat.Controls.Add(Me.Panel8)
        Me.tabAlamat.Name = "tabAlamat"
        Me.tabAlamat.Size = New System.Drawing.Size(549, 64)
        Me.tabAlamat.Text = "Pengiriman"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtAlamatAgent)
        Me.Panel9.Controls.Add(Me.txtNamaAgent)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(149, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(400, 64)
        Me.Panel9.TabIndex = 1
        '
        'txtAlamatAgent
        '
        Me.txtAlamatAgent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlamatAgent.Enabled = False
        Me.txtAlamatAgent.Location = New System.Drawing.Point(0, 20)
        Me.txtAlamatAgent.Name = "txtAlamatAgent"
        Me.txtAlamatAgent.Size = New System.Drawing.Size(400, 44)
        Me.txtAlamatAgent.TabIndex = 2
        '
        'txtNamaAgent
        '
        Me.txtNamaAgent.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNamaAgent.Enabled = False
        Me.txtNamaAgent.Location = New System.Drawing.Point(0, 0)
        Me.txtNamaAgent.Name = "txtNamaAgent"
        Me.txtNamaAgent.Size = New System.Drawing.Size(400, 20)
        Me.txtNamaAgent.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.ForeColor = System.Drawing.Color.White
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(149, 64)
        Me.Panel8.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(0, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 44)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Alamat : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Agent : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabSopir
        '
        Me.tabSopir.Controls.Add(Me.Panel11)
        Me.tabSopir.Controls.Add(Me.Panel10)
        Me.tabSopir.Name = "tabSopir"
        Me.tabSopir.Size = New System.Drawing.Size(549, 64)
        Me.tabSopir.Text = "Sopir"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Controls.Add(Me.Panel14)
        Me.Panel11.Controls.Add(Me.Panel17)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(149, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(400, 64)
        Me.Panel11.TabIndex = 3
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.txtKetKernet)
        Me.Panel13.Controls.Add(Me.txtKernet)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 42)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(400, 21)
        Me.Panel13.TabIndex = 6
        '
        'txtKetKernet
        '
        Me.txtKetKernet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKetKernet.Enabled = False
        Me.txtKetKernet.Location = New System.Drawing.Point(291, 0)
        Me.txtKetKernet.Name = "txtKetKernet"
        Me.txtKetKernet.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKetKernet.Properties.Appearance.Options.UseBackColor = True
        Me.txtKetKernet.Size = New System.Drawing.Size(109, 20)
        Me.txtKetKernet.TabIndex = 3
        '
        'txtKernet
        '
        Me.txtKernet.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKernet.Enabled = False
        Me.txtKernet.Location = New System.Drawing.Point(0, 0)
        Me.txtKernet.Name = "txtKernet"
        Me.txtKernet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKernet.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sopir", "Name6", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", 200, "Nama")})
        Me.txtKernet.Properties.DisplayMember = "Nama_Sopir"
        Me.txtKernet.Properties.NullText = "[Pilih Pelanggan]"
        Me.txtKernet.Properties.ValueMember = "Kode_Sopir"
        Me.txtKernet.Size = New System.Drawing.Size(291, 20)
        Me.txtKernet.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.txtKetSopir)
        Me.Panel14.Controls.Add(Me.txtSopir)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 21)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(400, 21)
        Me.Panel14.TabIndex = 5
        '
        'txtKetSopir
        '
        Me.txtKetSopir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKetSopir.Enabled = False
        Me.txtKetSopir.Location = New System.Drawing.Point(291, 0)
        Me.txtKetSopir.Name = "txtKetSopir"
        Me.txtKetSopir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKetSopir.Properties.Appearance.Options.UseBackColor = True
        Me.txtKetSopir.Size = New System.Drawing.Size(109, 20)
        Me.txtKetSopir.TabIndex = 3
        '
        'txtSopir
        '
        Me.txtSopir.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSopir.Enabled = False
        Me.txtSopir.Location = New System.Drawing.Point(0, 0)
        Me.txtSopir.Name = "txtSopir"
        Me.txtSopir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSopir.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sopir", "Name4", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", 200, "Sopir")})
        Me.txtSopir.Properties.DisplayMember = "Nama_Sopir"
        Me.txtSopir.Properties.NullText = "[Pilih Pelanggan]"
        Me.txtSopir.Properties.ValueMember = "Kode_Sopir"
        Me.txtSopir.Size = New System.Drawing.Size(291, 20)
        Me.txtSopir.TabIndex = 0
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.txtketKendaraan)
        Me.Panel17.Controls.Add(Me.txtKendaraan)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(400, 21)
        Me.Panel17.TabIndex = 4
        '
        'txtketKendaraan
        '
        Me.txtketKendaraan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtketKendaraan.Enabled = False
        Me.txtketKendaraan.Location = New System.Drawing.Point(291, 0)
        Me.txtketKendaraan.Name = "txtketKendaraan"
        Me.txtketKendaraan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtketKendaraan.Properties.Appearance.Options.UseBackColor = True
        Me.txtketKendaraan.Size = New System.Drawing.Size(109, 20)
        Me.txtketKendaraan.TabIndex = 3
        '
        'txtKendaraan
        '
        Me.txtKendaraan.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKendaraan.Enabled = False
        Me.txtKendaraan.Location = New System.Drawing.Point(0, 0)
        Me.txtKendaraan.Name = "txtKendaraan"
        Me.txtKendaraan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKendaraan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Kendaraan", "Kode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kendaraan", 200, "Nama")})
        Me.txtKendaraan.Properties.DisplayMember = "Nama_Kendaraan"
        Me.txtKendaraan.Properties.NullText = "[Pilih Pelanggan]"
        Me.txtKendaraan.Properties.ValueMember = "Kode_Kendaraan"
        Me.txtKendaraan.Size = New System.Drawing.Size(291, 20)
        Me.txtKendaraan.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Controls.Add(Me.Label7)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.ForeColor = System.Drawing.Color.White
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(149, 64)
        Me.Panel10.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Location = New System.Drawing.Point(0, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Kernet : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sopir : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Kendaraan : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 37)
        Me.Panel1.TabIndex = 0
        '
        'lblJudul
        '
        Me.lblJudul.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblJudul.Appearance.Options.UseFont = True
        Me.lblJudul.Appearance.Options.UseForeColor = True
        Me.lblJudul.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblJudul.Location = New System.Drawing.Point(44, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(426, 37)
        Me.lblJudul.TabIndex = 4
        Me.lblJudul.Text = "  SURAT JALAN KEMBALI"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmSuratJalanBalik
        '
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 554)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmSuratJalanBalik"
        Me.Text = "frmSJBatalMuat"
        CType(Me.GVTarik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKirimUlang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.popBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popBiaya.ResumeLayout(False)
        CType(Me.GC_Biaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Biaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.tglSj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        CType(Me.txtBiayaKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jamTerima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglTerima.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglTerima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.txtNamaCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        CType(Me.txtNoSj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomorRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        Me.tabAlamat.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.txtAlamatAgent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaAgent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.tabSopir.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        CType(Me.txtKetKernet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKernet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        CType(Me.txtKetSopir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSopir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        CType(Me.txtketKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabAlamat As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabSopir As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAlamatAgent As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtNamaAgent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents repbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents txtKetKernet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKernet As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents txtKetSopir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSopir As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents txtketKendaraan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKendaraan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TotKirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_balik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kirim_Ulang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repKirimUlang As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents GVTarik As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoBalik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok_Balik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_Tarik_Balik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_satuanB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keteranganB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_balikB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblJenisSj As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents tglSj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents jamTerima As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents tglTerima As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents txtNamaCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoSo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents txtNoSj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomorRef As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents popBiaya As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GC_Biaya As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Biaya As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repNum As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Qty_batal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qtyy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBiayaKirim As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
