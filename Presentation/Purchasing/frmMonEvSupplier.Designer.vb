<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonEvSupplier
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
        Me.components = New System.ComponentModel.Container
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonEvSupplier))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tgl_janji_krm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_act_krm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dayact = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_pass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_unpass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sts_qc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_term_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcEvSupplier = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.lblHasil = New System.Windows.Forms.Label
        Me.lblRekomendasi = New System.Windows.Forms.Label
        Me.btn_unapprove = New System.Windows.Forms.Button
        Me.btn_approve = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl_unapprove = New System.Windows.Forms.Label
        Me.lbl_approve = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lckPeriodeAkhir = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lckPeriodeAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.txtSupplier = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.XGB = New DevExpress.XtraGrid.Blending.XtraGridBlending
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcEvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.lckPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.lckPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView2.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GridView2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseFont = True
        Me.GridView2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView2.Appearance.Preview.Options.UseBackColor = True
        Me.GridView2.Appearance.Preview.Options.UseForeColor = True
        Me.GridView2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.Row.Options.UseBackColor = True
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.no_po, Me.kd_stok, Me.tgl_janji_krm, Me.tgl_act_krm, Me.dayact, Me.nilai_1, Me.qty_order, Me.qty_kirim, Me.nilai_2, Me.qty_pass, Me.qty_unpass, Me.sts_qc, Me.nilai_3, Me.tgl_bayar, Me.tgl_term_bayar, Me.nilai_4, Me.total})
        Me.GridView2.GridControl = Me.GcEvSupplier
        Me.GridView2.GroupPanelText = "Geser nama kolom kemari untuk mengelompokan data berdasarkan kolom tersebut"
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowFilterEditor = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'no_seq
        '
        Me.no_seq.AppearanceCell.Options.UseTextOptions = True
        Me.no_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.no_seq.AppearanceHeader.Options.UseFont = True
        Me.no_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.Caption = "NO."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 40
        '
        'no_po
        '
        Me.no_po.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.no_po.AppearanceHeader.Options.UseFont = True
        Me.no_po.AppearanceHeader.Options.UseTextOptions = True
        Me.no_po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_po.Caption = "NO.PO"
        Me.no_po.FieldName = "no_po"
        Me.no_po.Name = "no_po"
        Me.no_po.OptionsColumn.AllowEdit = False
        Me.no_po.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.no_po.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.no_po.OptionsColumn.ReadOnly = True
        Me.no_po.Visible = True
        Me.no_po.VisibleIndex = 1
        Me.no_po.Width = 130
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.kd_stok.AppearanceHeader.Options.UseFont = True
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "ITEM"
        Me.kd_stok.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.kd_stok.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 2
        Me.kd_stok.Width = 129
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "[Tidak ada data]"
        '
        'tgl_janji_krm
        '
        Me.tgl_janji_krm.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tgl_janji_krm.AppearanceHeader.Options.UseFont = True
        Me.tgl_janji_krm.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_janji_krm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_janji_krm.Caption = "TGL. JANJI KIRIM"
        Me.tgl_janji_krm.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_janji_krm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_janji_krm.FieldName = "tgl_janji_krm"
        Me.tgl_janji_krm.Name = "tgl_janji_krm"
        Me.tgl_janji_krm.OptionsColumn.AllowEdit = False
        Me.tgl_janji_krm.OptionsColumn.ReadOnly = True
        Me.tgl_janji_krm.Visible = True
        Me.tgl_janji_krm.VisibleIndex = 3
        Me.tgl_janji_krm.Width = 112
        '
        'tgl_act_krm
        '
        Me.tgl_act_krm.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tgl_act_krm.AppearanceHeader.Options.UseFont = True
        Me.tgl_act_krm.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_act_krm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_act_krm.Caption = "TGL. KIRIM AKTUAL"
        Me.tgl_act_krm.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_act_krm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_act_krm.FieldName = "tgl_act_krm"
        Me.tgl_act_krm.Name = "tgl_act_krm"
        Me.tgl_act_krm.OptionsColumn.AllowEdit = False
        Me.tgl_act_krm.OptionsColumn.ReadOnly = True
        Me.tgl_act_krm.Visible = True
        Me.tgl_act_krm.VisibleIndex = 4
        Me.tgl_act_krm.Width = 104
        '
        'dayact
        '
        Me.dayact.Caption = "dayact"
        Me.dayact.FieldName = "dayact"
        Me.dayact.Name = "dayact"
        Me.dayact.OptionsColumn.AllowEdit = False
        Me.dayact.OptionsColumn.ReadOnly = True
        '
        'nilai_1
        '
        Me.nilai_1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.nilai_1.AppearanceHeader.Options.UseFont = True
        Me.nilai_1.AppearanceHeader.Options.UseTextOptions = True
        Me.nilai_1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.nilai_1.Caption = "NILAI"
        Me.nilai_1.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.nilai_1.FieldName = "nilai_1"
        Me.nilai_1.Name = "nilai_1"
        Me.nilai_1.OptionsColumn.AllowEdit = False
        Me.nilai_1.OptionsColumn.ReadOnly = True
        Me.nilai_1.UnboundExpression = "Iif([dayact]< 5  And   [dayact]  >= 0,'30','0')"
        Me.nilai_1.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.nilai_1.Visible = True
        Me.nilai_1.VisibleIndex = 5
        Me.nilai_1.Width = 53
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "N2"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "N2"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'qty_order
        '
        Me.qty_order.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.qty_order.AppearanceHeader.Options.UseFont = True
        Me.qty_order.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.qty_order.Caption = "QTY ORDER"
        Me.qty_order.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.qty_order.DisplayFormat.FormatString = "N2"
        Me.qty_order.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.OptionsColumn.ReadOnly = True
        Me.qty_order.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 6
        Me.qty_order.Width = 76
        '
        'qty_kirim
        '
        Me.qty_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.qty_kirim.AppearanceHeader.Options.UseFont = True
        Me.qty_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.qty_kirim.Caption = "QTY KIRIM"
        Me.qty_kirim.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.qty_kirim.DisplayFormat.FormatString = "N2"
        Me.qty_kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_kirim.FieldName = "qty_kirim"
        Me.qty_kirim.Name = "qty_kirim"
        Me.qty_kirim.OptionsColumn.AllowEdit = False
        Me.qty_kirim.OptionsColumn.ReadOnly = True
        Me.qty_kirim.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.qty_kirim.Visible = True
        Me.qty_kirim.VisibleIndex = 7
        Me.qty_kirim.Width = 73
        '
        'nilai_2
        '
        Me.nilai_2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.nilai_2.AppearanceHeader.Options.UseFont = True
        Me.nilai_2.AppearanceHeader.Options.UseTextOptions = True
        Me.nilai_2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.nilai_2.Caption = "NILAI"
        Me.nilai_2.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.nilai_2.FieldName = "nilai_2"
        Me.nilai_2.Name = "nilai_2"
        Me.nilai_2.OptionsColumn.AllowEdit = False
        Me.nilai_2.OptionsColumn.ReadOnly = True
        Me.nilai_2.Visible = True
        Me.nilai_2.VisibleIndex = 8
        Me.nilai_2.Width = 45
        '
        'qty_pass
        '
        Me.qty_pass.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.qty_pass.AppearanceHeader.Options.UseFont = True
        Me.qty_pass.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_pass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.qty_pass.Caption = "QTY PASS"
        Me.qty_pass.DisplayFormat.FormatString = "n3"
        Me.qty_pass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_pass.FieldName = "qty_pass"
        Me.qty_pass.Name = "qty_pass"
        Me.qty_pass.OptionsColumn.AllowEdit = False
        Me.qty_pass.OptionsColumn.ReadOnly = True
        Me.qty_pass.Visible = True
        Me.qty_pass.VisibleIndex = 9
        '
        'qty_unpass
        '
        Me.qty_unpass.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.qty_unpass.AppearanceHeader.Options.UseFont = True
        Me.qty_unpass.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_unpass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.qty_unpass.Caption = "QTY UNPASS"
        Me.qty_unpass.DisplayFormat.FormatString = "n3"
        Me.qty_unpass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_unpass.FieldName = "qty_unpass"
        Me.qty_unpass.Name = "qty_unpass"
        Me.qty_unpass.OptionsColumn.AllowEdit = False
        Me.qty_unpass.OptionsColumn.ReadOnly = True
        Me.qty_unpass.Visible = True
        Me.qty_unpass.VisibleIndex = 10
        '
        'sts_qc
        '
        Me.sts_qc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.sts_qc.AppearanceHeader.Options.UseFont = True
        Me.sts_qc.AppearanceHeader.Options.UseTextOptions = True
        Me.sts_qc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sts_qc.Caption = "STATUS QA"
        Me.sts_qc.FieldName = "sts_qc"
        Me.sts_qc.Name = "sts_qc"
        Me.sts_qc.OptionsColumn.AllowEdit = False
        Me.sts_qc.OptionsColumn.ReadOnly = True
        Me.sts_qc.Visible = True
        Me.sts_qc.VisibleIndex = 11
        Me.sts_qc.Width = 68
        '
        'nilai_3
        '
        Me.nilai_3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.nilai_3.AppearanceHeader.Options.UseFont = True
        Me.nilai_3.AppearanceHeader.Options.UseTextOptions = True
        Me.nilai_3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.nilai_3.Caption = "NILAI"
        Me.nilai_3.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.nilai_3.FieldName = "nilai_3"
        Me.nilai_3.Name = "nilai_3"
        Me.nilai_3.OptionsColumn.AllowEdit = False
        Me.nilai_3.OptionsColumn.ReadOnly = True
        Me.nilai_3.Visible = True
        Me.nilai_3.VisibleIndex = 12
        Me.nilai_3.Width = 57
        '
        'tgl_bayar
        '
        Me.tgl_bayar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tgl_bayar.AppearanceHeader.Options.UseFont = True
        Me.tgl_bayar.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_bayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_bayar.Caption = "TGL.BAYAR"
        Me.tgl_bayar.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_bayar.FieldName = "tgl_bayar"
        Me.tgl_bayar.Name = "tgl_bayar"
        Me.tgl_bayar.OptionsColumn.AllowEdit = False
        Me.tgl_bayar.OptionsColumn.ReadOnly = True
        Me.tgl_bayar.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.tgl_bayar.Visible = True
        Me.tgl_bayar.VisibleIndex = 13
        Me.tgl_bayar.Width = 64
        '
        'tgl_term_bayar
        '
        Me.tgl_term_bayar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tgl_term_bayar.AppearanceHeader.Options.UseFont = True
        Me.tgl_term_bayar.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_term_bayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_term_bayar.Caption = "TERM BAYAR"
        Me.tgl_term_bayar.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_term_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_term_bayar.FieldName = "tgl_term_bayar"
        Me.tgl_term_bayar.Name = "tgl_term_bayar"
        Me.tgl_term_bayar.OptionsColumn.AllowEdit = False
        Me.tgl_term_bayar.OptionsColumn.ReadOnly = True
        Me.tgl_term_bayar.Visible = True
        Me.tgl_term_bayar.VisibleIndex = 14
        Me.tgl_term_bayar.Width = 73
        '
        'nilai_4
        '
        Me.nilai_4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.nilai_4.AppearanceHeader.Options.UseFont = True
        Me.nilai_4.AppearanceHeader.Options.UseTextOptions = True
        Me.nilai_4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.nilai_4.Caption = "NILAI"
        Me.nilai_4.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.nilai_4.FieldName = "nilai_4"
        Me.nilai_4.Name = "nilai_4"
        Me.nilai_4.OptionsColumn.AllowEdit = False
        Me.nilai_4.OptionsColumn.ReadOnly = True
        Me.nilai_4.Visible = True
        Me.nilai_4.VisibleIndex = 15
        Me.nilai_4.Width = 53
        '
        'total
        '
        Me.total.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.total.AppearanceHeader.Options.UseFont = True
        Me.total.AppearanceHeader.Options.UseTextOptions = True
        Me.total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.total.Caption = "NILAI TOTAL"
        Me.total.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.total.FieldName = "total"
        Me.total.Name = "total"
        Me.total.OptionsColumn.AllowEdit = False
        Me.total.OptionsColumn.ReadOnly = True
        Me.total.SummaryItem.DisplayFormat = "{0:n2}"
        Me.total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average
        Me.total.Visible = True
        Me.total.VisibleIndex = 16
        Me.total.Width = 79
        '
        'GcEvSupplier
        '
        Me.GcEvSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "Level1"
        Me.GcEvSupplier.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcEvSupplier.Location = New System.Drawing.Point(0, 78)
        Me.GcEvSupplier.MainView = Me.GridView1
        Me.GcEvSupplier.Name = "GcEvSupplier"
        Me.GcEvSupplier.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1, Me.RepositoryItemLookUpEdit1})
        Me.GcEvSupplier.Size = New System.Drawing.Size(1335, 373)
        Me.GcEvSupplier.TabIndex = 8
        Me.GcEvSupplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GcEvSupplier
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "No. Trans"
        Me.GridColumn1.FieldName = "no_trans"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Periode"
        Me.GridColumn2.FieldName = "periode1"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Periode 2"
        Me.GridColumn3.FieldName = "periode2"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Peiode PO"
        Me.GridColumn4.FieldName = "periode"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Total Nilai Evaluasi"
        Me.GridColumn5.DisplayFormat.FormatString = "N2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "nilai"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcEvSupplier)
        Me.pnl.Controls.Add(Me.Panel9)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1335, 525)
        Me.pnl.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel9.Controls.Add(Me.lblHasil)
        Me.Panel9.Controls.Add(Me.lblRekomendasi)
        Me.Panel9.Controls.Add(Me.btn_unapprove)
        Me.Panel9.Controls.Add(Me.btn_approve)
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.lbl_unapprove)
        Me.Panel9.Controls.Add(Me.lbl_approve)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 451)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1335, 74)
        Me.Panel9.TabIndex = 6
        '
        'lblHasil
        '
        Me.lblHasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasil.ForeColor = System.Drawing.Color.White
        Me.lblHasil.Location = New System.Drawing.Point(829, 12)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(203, 20)
        Me.lblHasil.TabIndex = 15
        Me.lblHasil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRekomendasi
        '
        Me.lblRekomendasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRekomendasi.ForeColor = System.Drawing.Color.White
        Me.lblRekomendasi.Location = New System.Drawing.Point(613, 12)
        Me.lblRekomendasi.Name = "lblRekomendasi"
        Me.lblRekomendasi.Size = New System.Drawing.Size(203, 20)
        Me.lblRekomendasi.TabIndex = 13
        Me.lblRekomendasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_unapprove
        '
        Me.btn_unapprove.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_unapprove.ForeColor = System.Drawing.Color.Red
        Me.btn_unapprove.Location = New System.Drawing.Point(197, 30)
        Me.btn_unapprove.Name = "btn_unapprove"
        Me.btn_unapprove.Size = New System.Drawing.Size(91, 23)
        Me.btn_unapprove.TabIndex = 12
        Me.btn_unapprove.Text = "UNAPPROVE"
        Me.btn_unapprove.UseVisualStyleBackColor = True
        Me.btn_unapprove.Visible = False
        '
        'btn_approve
        '
        Me.btn_approve.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_approve.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_approve.Location = New System.Drawing.Point(111, 30)
        Me.btn_approve.Name = "btn_approve"
        Me.btn_approve.Size = New System.Drawing.Size(75, 23)
        Me.btn_approve.TabIndex = 11
        Me.btn_approve.Text = "APPROVE"
        Me.btn_approve.UseVisualStyleBackColor = True
        Me.btn_approve.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Action :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_unapprove
        '
        Me.lbl_unapprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unapprove.ForeColor = System.Drawing.Color.Red
        Me.lbl_unapprove.Location = New System.Drawing.Point(193, 4)
        Me.lbl_unapprove.Name = "lbl_unapprove"
        Me.lbl_unapprove.Size = New System.Drawing.Size(114, 20)
        Me.lbl_unapprove.TabIndex = 9
        Me.lbl_unapprove.Text = "(UNAPPROVED)"
        Me.lbl_unapprove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_unapprove.Visible = False
        '
        'lbl_approve
        '
        Me.lbl_approve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_approve.ForeColor = System.Drawing.Color.Lime
        Me.lbl_approve.Location = New System.Drawing.Point(113, 4)
        Me.lbl_approve.Name = "lbl_approve"
        Me.lbl_approve.Size = New System.Drawing.Size(102, 20)
        Me.lbl_approve.TabIndex = 8
        Me.lbl_approve.Text = "APPROVED"
        Me.lbl_approve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_approve.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hasil Evaluasi :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1335, 41)
        Me.Panel2.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(664, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(208, 41)
        Me.Panel8.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.SimpleButton1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(568, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(96, 41)
        Me.Panel5.TabIndex = 17
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(20, 1)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(57, 40)
        Me.SimpleButton1.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lckPeriodeAkhir)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(378, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(190, 41)
        Me.Panel7.TabIndex = 16
        '
        'lckPeriodeAkhir
        '
        Me.lckPeriodeAkhir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lckPeriodeAkhir.Location = New System.Drawing.Point(0, 21)
        Me.lckPeriodeAkhir.Name = "lckPeriodeAkhir"
        Me.lckPeriodeAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckPeriodeAkhir.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Name1")})
        Me.lckPeriodeAkhir.Properties.NullText = ""
        Me.lckPeriodeAkhir.Properties.ShowFooter = False
        Me.lckPeriodeAkhir.Properties.ShowHeader = False
        Me.lckPeriodeAkhir.Properties.ShowPopupShadow = False
        Me.lckPeriodeAkhir.Size = New System.Drawing.Size(190, 20)
        Me.lckPeriodeAkhir.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(323, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(55, 41)
        Me.Panel6.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "s/d"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lckPeriodeAwal)
        Me.Panel4.Controls.Add(Me.txtSupplier)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(102, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(221, 41)
        Me.Panel4.TabIndex = 13
        '
        'lckPeriodeAwal
        '
        Me.lckPeriodeAwal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lckPeriodeAwal.Location = New System.Drawing.Point(0, 20)
        Me.lckPeriodeAwal.Name = "lckPeriodeAwal"
        Me.lckPeriodeAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckPeriodeAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Name1")})
        Me.lckPeriodeAwal.Properties.NullText = ""
        Me.lckPeriodeAwal.Properties.ShowFooter = False
        Me.lckPeriodeAwal.Properties.ShowHeader = False
        Me.lckPeriodeAwal.Properties.ShowPopupShadow = False
        Me.lckPeriodeAwal.Size = New System.Drawing.Size(221, 20)
        Me.lckPeriodeAwal.TabIndex = 2
        '
        'txtSupplier
        '
        Me.txtSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSupplier.Location = New System.Drawing.Point(0, 0)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSupplier.Properties.Appearance.Options.UseBackColor = True
        Me.txtSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Supplier", 50, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", 150, "Nama")})
        Me.txtSupplier.Properties.DisplayMember = "Nama_Supplier"
        Me.txtSupplier.Properties.HideSelection = False
        Me.txtSupplier.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtSupplier.Properties.NullText = "[Pilih Supplier]"
        Me.txtSupplier.Properties.PopupWidth = 300
        Me.txtSupplier.Properties.ShowHeader = False
        Me.txtSupplier.Properties.ValueMember = "Kode_Supplier"
        Me.txtSupplier.Size = New System.Drawing.Size(221, 20)
        Me.txtSupplier.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(102, 41)
        Me.Panel3.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Periode :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Supplier :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel1.Size = New System.Drawing.Size(1335, 37)
        Me.Panel1.TabIndex = 3
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(529, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITORING EVALUASI SUPPLIER"
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
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 100
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.ActiveCaptionText
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'XGB
        '
        Me.XGB.AlphaStyles.AddReplace("OddRow", 159)
        Me.XGB.AlphaStyles.AddReplace("EvenRow", 177)
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcEvSupplier
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(0, 0, 10, 40)
        Me.PrintableComponentLink1.MinMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(Nothing, New DevExpress.XtraPrinting.PageFooterArea(New String(-1) {}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far))
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'GridColumn6
        '
        Me.GridColumn6.Name = "GridColumn6"
        '
        'frmMonEvSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 525)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmMonEvSupplier"
        Me.Text = "MONITORING EVALUASI SUPPLIER"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcEvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.lckPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.lckPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents XGB As DevExpress.XtraGrid.Blending.XtraGridBlending
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btn_unapprove As System.Windows.Forms.Button
    Friend WithEvents btn_approve As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_unapprove As System.Windows.Forms.Label
    Friend WithEvents lbl_approve As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents lblHasil As System.Windows.Forms.Label
    Friend WithEvents lblRekomendasi As System.Windows.Forms.Label
    Friend WithEvents lckPeriodeAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lckPeriodeAkhir As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GcEvSupplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_janji_krm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_act_krm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dayact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_pass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_unpass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sts_qc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_term_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents total As DevExpress.XtraGrid.Columns.GridColumn
End Class
