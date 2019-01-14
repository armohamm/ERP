<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRcnRph
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRcnRph))
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_NoSeq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_old_num = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC_TglSP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_wilayah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_area = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC_Ket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_Produksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColKetKirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_tglKirimSP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prioritas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Indeks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.GV_Centi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColTebal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPanjang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColLebar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MainGV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clJnsBrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clKapasitas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repJnsBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DT_Tgl_SP = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_gen_simulBahan = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtJadwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txt_tglRealisasi = New DevExpress.XtraEditors.DateEdit
        Me.txtDPB = New System.Windows.Forms.TextBox
        Me.txtTgl_Rph = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.UserCreate = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Centi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repJnsBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Tgl_SP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Tgl_SP.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtJadwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.txt_tglRealisasi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tglRealisasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl_Rph.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl_Rph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv
        '
        Me.gv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gv.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.Empty.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.EvenRow.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.Options.UseForeColor = True
        Me.gv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gv.Appearance.FixedLine.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gv.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupButton.Options.UseBackColor = True
        Me.gv.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gv.Appearance.GroupButton.Options.UseForeColor = True
        Me.gv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gv.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gv.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupRow.Options.UseBackColor = True
        Me.gv.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gv.Appearance.GroupRow.Options.UseFont = True
        Me.gv.Appearance.GroupRow.Options.UseForeColor = True
        Me.gv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gv.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gv.Appearance.HorzLine.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.OddRow.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.Options.UseForeColor = True
        Me.gv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.Appearance.Preview.Options.UseBackColor = True
        Me.gv.Appearance.Preview.Options.UseForeColor = True
        Me.gv.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.Row.Options.UseBackColor = True
        Me.gv.Appearance.Row.Options.UseForeColor = True
        Me.gv.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gv.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gv.Appearance.VertLine.Options.UseBackColor = True
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sp, Me.Col_NoSeq, Me.col_old_num, Me.GC_TglSP, Me.nama_customer, Me.nama_wilayah, Me.nama_area, Me.nama_barang, Me.GC_Ket, Me.qty, Me.Qty_Produksi, Me.ColKetKirim, Me.col_tglKirimSP, Me.tgl_kirim, Me.prioritas, Me.col_satuan, Me.Indeks, Me.Tipe_trans, Me.UserCreate})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsView.ColumnAutoWidth = False
        Me.gv.OptionsView.EnableAppearanceEvenRow = True
        Me.gv.OptionsView.EnableAppearanceOddRow = True
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowViewCaption = True
        Me.gv.PaintStyleName = "Skin"
        Me.gv.ViewCaption = "DAFTAR SALES ORDER"
        '
        'no_sp
        '
        Me.no_sp.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.no_sp.AppearanceCell.Options.UseBorderColor = True
        Me.no_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.no_sp.Caption = "No SP"
        Me.no_sp.FieldName = "no_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.OptionsColumn.ReadOnly = True
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 0
        Me.no_sp.Width = 134
        '
        'Col_NoSeq
        '
        Me.Col_NoSeq.Caption = "No_seq"
        Me.Col_NoSeq.FieldName = "No_seq"
        Me.Col_NoSeq.Name = "Col_NoSeq"
        Me.Col_NoSeq.OptionsColumn.AllowEdit = False
        '
        'col_old_num
        '
        Me.col_old_num.Caption = "Old No. SP"
        Me.col_old_num.FieldName = "old_num"
        Me.col_old_num.Name = "col_old_num"
        Me.col_old_num.OptionsColumn.AllowEdit = False
        Me.col_old_num.Visible = True
        Me.col_old_num.VisibleIndex = 1
        '
        'GC_TglSP
        '
        Me.GC_TglSP.Caption = "Tgl. SP"
        Me.GC_TglSP.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GC_TglSP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GC_TglSP.FieldName = "Tgl_SP"
        Me.GC_TglSP.MinWidth = 10
        Me.GC_TglSP.Name = "GC_TglSP"
        Me.GC_TglSP.OptionsColumn.AllowEdit = False
        Me.GC_TglSP.Visible = True
        Me.GC_TglSP.VisibleIndex = 12
        '
        'nama_customer
        '
        Me.nama_customer.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_customer.Caption = "Pelanggan"
        Me.nama_customer.FieldName = "Nama_Customer"
        Me.nama_customer.Name = "nama_customer"
        Me.nama_customer.OptionsColumn.AllowEdit = False
        Me.nama_customer.OptionsColumn.ReadOnly = True
        Me.nama_customer.Visible = True
        Me.nama_customer.VisibleIndex = 2
        Me.nama_customer.Width = 129
        '
        'nama_wilayah
        '
        Me.nama_wilayah.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_wilayah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_wilayah.Caption = "Wilayah"
        Me.nama_wilayah.FieldName = "Nama_Wilayah"
        Me.nama_wilayah.Name = "nama_wilayah"
        Me.nama_wilayah.OptionsColumn.AllowEdit = False
        Me.nama_wilayah.OptionsColumn.ReadOnly = True
        Me.nama_wilayah.Width = 66
        '
        'nama_area
        '
        Me.nama_area.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_area.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_area.Caption = "Area"
        Me.nama_area.FieldName = "Nama_Area"
        Me.nama_area.Name = "nama_area"
        Me.nama_area.OptionsColumn.AllowEdit = False
        Me.nama_area.OptionsColumn.ReadOnly = True
        Me.nama_area.Width = 79
        '
        'nama_barang
        '
        Me.nama_barang.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.nama_barang.AppearanceCell.Options.UseBorderColor = True
        Me.nama_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_barang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.nama_barang.Caption = "Barang"
        Me.nama_barang.FieldName = "Nama_Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.OptionsColumn.AllowEdit = False
        Me.nama_barang.OptionsColumn.ReadOnly = True
        Me.nama_barang.Visible = True
        Me.nama_barang.VisibleIndex = 3
        Me.nama_barang.Width = 271
        '
        'GC_Ket
        '
        Me.GC_Ket.Caption = "Keterangan"
        Me.GC_Ket.FieldName = "Keterangan"
        Me.GC_Ket.Name = "GC_Ket"
        Me.GC_Ket.OptionsColumn.AllowEdit = False
        Me.GC_Ket.Visible = True
        Me.GC_Ket.VisibleIndex = 4
        Me.GC_Ket.Width = 67
        '
        'qty
        '
        Me.qty.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.qty.AppearanceCell.Options.UseBorderColor = True
        Me.qty.AppearanceCell.Options.UseTextOptions = True
        Me.qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.qty.AppearanceHeader.Options.UseTextOptions = True
        Me.qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.qty.Caption = "Sisa"
        Me.qty.FieldName = "Sisa"
        Me.qty.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.qty.Name = "qty"
        Me.qty.OptionsColumn.AllowEdit = False
        Me.qty.OptionsColumn.ReadOnly = True
        Me.qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty.Visible = True
        Me.qty.VisibleIndex = 5
        Me.qty.Width = 52
        '
        'Qty_Produksi
        '
        Me.Qty_Produksi.AppearanceCell.Options.UseTextOptions = True
        Me.Qty_Produksi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_Produksi.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_Produksi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty_Produksi.Caption = "Jml Produksi"
        Me.Qty_Produksi.FieldName = "jumlah"
        Me.Qty_Produksi.Name = "Qty_Produksi"
        Me.Qty_Produksi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_Produksi.Visible = True
        Me.Qty_Produksi.VisibleIndex = 6
        Me.Qty_Produksi.Width = 82
        '
        'ColKetKirim
        '
        Me.ColKetKirim.Caption = "Keterangan Kirim"
        Me.ColKetKirim.FieldName = "keterangan_krm"
        Me.ColKetKirim.Name = "ColKetKirim"
        Me.ColKetKirim.OptionsColumn.AllowEdit = False
        Me.ColKetKirim.Visible = True
        Me.ColKetKirim.VisibleIndex = 7
        '
        'col_tglKirimSP
        '
        Me.col_tglKirimSP.Caption = "Tgl. Janji Kirim SP"
        Me.col_tglKirimSP.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.col_tglKirimSP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_tglKirimSP.FieldName = "tgl_kirim"
        Me.col_tglKirimSP.Name = "col_tglKirimSP"
        Me.col_tglKirimSP.OptionsColumn.AllowEdit = False
        Me.col_tglKirimSP.Visible = True
        Me.col_tglKirimSP.VisibleIndex = 8
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.tgl_kirim.AppearanceCell.Options.UseBorderColor = True
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tgl_kirim.Caption = "Tgl. Janji Kirim PPIC"
        Me.tgl_kirim.DisplayFormat.FormatString = "d"
        Me.tgl_kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_kirim.FieldName = "tgl_kirim_ppic"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.OptionsColumn.AllowEdit = False
        Me.tgl_kirim.OptionsColumn.ReadOnly = True
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 9
        '
        'prioritas
        '
        Me.prioritas.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.prioritas.AppearanceCell.Options.UseBorderColor = True
        Me.prioritas.AppearanceHeader.Options.UseTextOptions = True
        Me.prioritas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.prioritas.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.prioritas.Caption = "Prioritas"
        Me.prioritas.FieldName = "prioritas"
        Me.prioritas.Name = "prioritas"
        Me.prioritas.OptionsColumn.AllowEdit = False
        Me.prioritas.OptionsColumn.ReadOnly = True
        Me.prioritas.Visible = True
        Me.prioritas.VisibleIndex = 11
        Me.prioritas.Width = 50
        '
        'col_satuan
        '
        Me.col_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.col_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_satuan.Caption = "Satuan"
        Me.col_satuan.FieldName = "Nama_Satuan"
        Me.col_satuan.Name = "col_satuan"
        Me.col_satuan.OptionsColumn.AllowEdit = False
        Me.col_satuan.Visible = True
        Me.col_satuan.VisibleIndex = 10
        '
        'Indeks
        '
        Me.Indeks.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.Indeks.AppearanceCell.Options.UseBorderColor = True
        Me.Indeks.AppearanceHeader.Options.UseTextOptions = True
        Me.Indeks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Indeks.Caption = "Indeks"
        Me.Indeks.FieldName = "jml_indeks"
        Me.Indeks.Name = "Indeks"
        Me.Indeks.OptionsColumn.AllowEdit = False
        Me.Indeks.OptionsColumn.ReadOnly = True
        Me.Indeks.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Indeks.Visible = True
        Me.Indeks.VisibleIndex = 13
        Me.Indeks.Width = 87
        '
        'Tipe_trans
        '
        Me.Tipe_trans.Caption = "Tipe_trans"
        Me.Tipe_trans.FieldName = "Tipe_trans"
        Me.Tipe_trans.Name = "Tipe_trans"
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gv
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.GV_Centi
        GridLevelNode2.RelationName = "Level2"
        Me.gc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.gc.Location = New System.Drawing.Point(0, 65)
        Me.gc.MainView = Me.MainGV
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repJnsBrg, Me.DT_Tgl_SP})
        Me.gc.Size = New System.Drawing.Size(1002, 390)
        Me.gc.TabIndex = 0
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Centi, Me.MainGV, Me.gv})
        '
        'GV_Centi
        '
        Me.GV_Centi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColTebal, Me.ColPanjang, Me.ColLebar})
        Me.GV_Centi.GridControl = Me.gc
        Me.GV_Centi.Name = "GV_Centi"
        Me.GV_Centi.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Centi.OptionsView.EnableAppearanceOddRow = True
        Me.GV_Centi.OptionsView.ShowGroupPanel = False
        '
        'ColTebal
        '
        Me.ColTebal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTebal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTebal.Caption = "Tebal Busa"
        Me.ColTebal.FieldName = "tebal"
        Me.ColTebal.Name = "ColTebal"
        Me.ColTebal.Visible = True
        Me.ColTebal.VisibleIndex = 0
        '
        'ColPanjang
        '
        Me.ColPanjang.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPanjang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPanjang.Caption = "Panjang Busa"
        Me.ColPanjang.FieldName = "panjang"
        Me.ColPanjang.Name = "ColPanjang"
        Me.ColPanjang.Visible = True
        Me.ColPanjang.VisibleIndex = 1
        '
        'ColLebar
        '
        Me.ColLebar.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLebar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLebar.Caption = "Lebar Busa"
        Me.ColLebar.FieldName = "lebar"
        Me.ColLebar.Name = "ColLebar"
        Me.ColLebar.Visible = True
        Me.ColLebar.VisibleIndex = 2
        '
        'MainGV
        '
        Me.MainGV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clJnsBrg, Me.clKapasitas})
        Me.MainGV.GridControl = Me.gc
        Me.MainGV.Name = "MainGV"
        Me.MainGV.OptionsView.ShowGroupPanel = False
        Me.MainGV.OptionsView.ShowViewCaption = True
        Me.MainGV.ViewCaption = "Daftar Saler Order"
        '
        'clJnsBrg
        '
        Me.clJnsBrg.Caption = "Jenis Barang"
        Me.clJnsBrg.FieldName = "Nama_Jenis_Group"
        Me.clJnsBrg.Name = "clJnsBrg"
        Me.clJnsBrg.OptionsColumn.AllowEdit = False
        Me.clJnsBrg.Visible = True
        Me.clJnsBrg.VisibleIndex = 0
        Me.clJnsBrg.Width = 690
        '
        'clKapasitas
        '
        Me.clKapasitas.Caption = "Kapasitas"
        Me.clKapasitas.FieldName = "jml_kapasitas"
        Me.clKapasitas.Name = "clKapasitas"
        Me.clKapasitas.OptionsColumn.AllowEdit = False
        Me.clKapasitas.Visible = True
        Me.clKapasitas.VisibleIndex = 1
        Me.clKapasitas.Width = 248
        '
        'repJnsBrg
        '
        Me.repJnsBrg.AutoHeight = False
        Me.repJnsBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repJnsBrg.DisplayMember = "Nama_Barang"
        Me.repJnsBrg.Name = "repJnsBrg"
        Me.repJnsBrg.ValueMember = "Kd_Jenis"
        '
        'DT_Tgl_SP
        '
        Me.DT_Tgl_SP.AutoHeight = False
        Me.DT_Tgl_SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DT_Tgl_SP.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DT_Tgl_SP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DT_Tgl_SP.EditFormat.FormatString = "dd/MM/yyyy"
        Me.DT_Tgl_SP.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DT_Tgl_SP.Mask.EditMask = "dd/MM/yyyy"
        Me.DT_Tgl_SP.Name = "DT_Tgl_SP"
        Me.DT_Tgl_SP.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Location = New System.Drawing.Point(12, 9)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 488)
        Me.pnl.TabIndex = 0
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(1002, 455)
        Me.pnlTengah.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_gen_simulBahan)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 65)
        Me.Panel1.TabIndex = 0
        '
        'btn_gen_simulBahan
        '
        Me.btn_gen_simulBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_gen_simulBahan.ForeColor = System.Drawing.Color.Maroon
        Me.btn_gen_simulBahan.Location = New System.Drawing.Point(872, 14)
        Me.btn_gen_simulBahan.Name = "btn_gen_simulBahan"
        Me.btn_gen_simulBahan.Size = New System.Drawing.Size(154, 32)
        Me.btn_gen_simulBahan.TabIndex = 9
        Me.btn_gen_simulBahan.Text = "KALKULASI BAHAN"
        Me.btn_gen_simulBahan.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtJadwal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(572, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 65)
        Me.Panel3.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(121, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 37)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "ALL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(4, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "JENIS BARANG"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtJadwal
        '
        Me.txtJadwal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtJadwal.Location = New System.Drawing.Point(0, 0)
        Me.txtJadwal.Name = "txtJadwal"
        Me.txtJadwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJadwal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJadwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Jadwal")})
        Me.txtJadwal.Properties.DisplayMember = "Desc_Data"
        Me.txtJadwal.Properties.NullText = "[Pilih Jadwal Kerja]"
        Me.txtJadwal.Properties.ValueMember = "Id_Data"
        Me.txtJadwal.Size = New System.Drawing.Size(240, 20)
        Me.txtJadwal.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(425, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 65)
        Me.Panel2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mode Filter :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "* Jadwal Kerja :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txt_tglRealisasi)
        Me.Panel7.Controls.Add(Me.txtDPB)
        Me.Panel7.Controls.Add(Me.txtTgl_Rph)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(142, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(283, 65)
        Me.Panel7.TabIndex = 5
        '
        'txt_tglRealisasi
        '
        Me.txt_tglRealisasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_tglRealisasi.EditValue = Nothing
        Me.txt_tglRealisasi.Location = New System.Drawing.Point(0, 41)
        Me.txt_tglRealisasi.Name = "txt_tglRealisasi"
        Me.txt_tglRealisasi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_tglRealisasi.Properties.Appearance.Options.UseFont = True
        Me.txt_tglRealisasi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tglRealisasi.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txt_tglRealisasi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_tglRealisasi.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txt_tglRealisasi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_tglRealisasi.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txt_tglRealisasi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_tglRealisasi.Size = New System.Drawing.Size(283, 20)
        Me.txt_tglRealisasi.TabIndex = 7
        '
        'txtDPB
        '
        Me.txtDPB.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDPB.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDPB.Location = New System.Drawing.Point(0, 20)
        Me.txtDPB.Name = "txtDPB"
        Me.txtDPB.ReadOnly = True
        Me.txtDPB.Size = New System.Drawing.Size(283, 21)
        Me.txtDPB.TabIndex = 6
        '
        'txtTgl_Rph
        '
        Me.txtTgl_Rph.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTgl_Rph.EditValue = Nothing
        Me.txtTgl_Rph.Location = New System.Drawing.Point(0, 0)
        Me.txtTgl_Rph.Name = "txtTgl_Rph"
        Me.txtTgl_Rph.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTgl_Rph.Properties.Appearance.Options.UseFont = True
        Me.txtTgl_Rph.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTgl_Rph.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtTgl_Rph.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTgl_Rph.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txtTgl_Rph.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTgl_Rph.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtTgl_Rph.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTgl_Rph.Size = New System.Drawing.Size(283, 20)
        Me.txtTgl_Rph.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(142, 65)
        Me.Panel6.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "* Tanggal Realisasi : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. Transaksi : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "* Tanggal : "
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
        Me.pnlAtas.Size = New System.Drawing.Size(1002, 31)
        Me.pnlAtas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
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
        Me.LabelControl1.Text = "DRAFT RPH"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'UserCreate
        '
        Me.UserCreate.Caption = "Admin SP"
        Me.UserCreate.FieldName = "last_created_by"
        Me.UserCreate.Name = "UserCreate"
        Me.UserCreate.OptionsColumn.AllowEdit = False
        Me.UserCreate.Visible = True
        Me.UserCreate.VisibleIndex = 14
        '
        'frmRcnRph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 512)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRcnRph"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Centi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repJnsBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Tgl_SP.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Tgl_SP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtJadwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.txt_tglRealisasi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tglRealisasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl_Rph.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl_Rph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtTgl_Rph As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDPB As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJadwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Centi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColTebal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPanjang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLebar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prioritas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_Produksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Indeks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repJnsBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MainGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clJnsBrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clKapasitas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_gen_simulBahan As System.Windows.Forms.Button
    Friend WithEvents nama_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_wilayah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC_Ket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC_TglSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DT_Tgl_SP As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents col_tglKirimSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_old_num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Col_NoSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_tglRealisasi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColKetKirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserCreate As DevExpress.XtraGrid.Columns.GridColumn
End Class
