<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuratJalan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuratJalan))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TotKirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.tglSj = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.txtNamaCustomer = New System.Windows.Forms.TextBox
        Me.txtNoSo = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.txtNomorRef = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit
        Me.Label9 = New System.Windows.Forms.Label
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtKd_Customer = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.DXEP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnl.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.tglSj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.txtNoSo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        CType(Me.txtNomorRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel15.SuspendLayout()
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
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(50, 16)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(923, 525)
        Me.pnl.TabIndex = 0
        '
        'gc
        '
        Me.gc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 79)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repBarang})
        Me.gc.Size = New System.Drawing.Size(921, 352)
        Me.gc.TabIndex = 3
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
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
        Me.gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gv.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.VertLine.Options.UseBackColor = True
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.Kd_stok, Me.Qty, Me.Qty_kirim, Me.Kd_satuan, Me.Keterangan, Me.TotKirim})
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
        Me.No_seq.AppearanceCell.Options.UseTextOptions = True
        Me.No_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.No_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.No_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.No_seq.Caption = "No"
        Me.No_seq.FieldName = "no_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.OptionsColumn.AllowFocus = False
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 42
        '
        'Kd_stok
        '
        Me.Kd_stok.Caption = "Barang"
        Me.Kd_stok.ColumnEdit = Me.repBarang
        Me.Kd_stok.FieldName = "Kd_stok"
        Me.Kd_stok.Name = "Kd_stok"
        Me.Kd_stok.OptionsColumn.AllowEdit = False
        Me.Kd_stok.OptionsColumn.AllowFocus = False
        Me.Kd_stok.Visible = True
        Me.Kd_stok.VisibleIndex = 1
        Me.Kd_stok.Width = 519
        '
        'repBarang
        '
        Me.repBarang.AutoHeight = False
        Me.repBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Name19")})
        Me.repBarang.DisplayMember = "Nama_Barang"
        Me.repBarang.Name = "repBarang"
        Me.repBarang.NullText = ""
        Me.repBarang.ValueMember = "Kode_Barang"
        '
        'Qty
        '
        Me.Qty.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty.AppearanceCell.Options.UseFont = True
        Me.Qty.AppearanceCell.Options.UseTextOptions = True
        Me.Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.AllowEdit = False
        Me.Qty.OptionsColumn.AllowFocus = False
        Me.Qty.Width = 58
        '
        'Qty_kirim
        '
        Me.Qty_kirim.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_kirim.AppearanceCell.Options.UseFont = True
        Me.Qty_kirim.AppearanceCell.Options.UseTextOptions = True
        Me.Qty_kirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_kirim.AppearanceHeader.Options.UseFont = True
        Me.Qty_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_kirim.Caption = "Kirim"
        Me.Qty_kirim.FieldName = "Qty_kirim"
        Me.Qty_kirim.Name = "Qty_kirim"
        Me.Qty_kirim.Visible = True
        Me.Qty_kirim.VisibleIndex = 3
        Me.Qty_kirim.Width = 60
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
        Me.Kd_satuan.Width = 71
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.OptionsColumn.AllowEdit = False
        Me.Keterangan.OptionsColumn.AllowFocus = False
        Me.Keterangan.Width = 230
        '
        'TotKirim
        '
        Me.TotKirim.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotKirim.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.TotKirim.AppearanceCell.Options.UseFont = True
        Me.TotKirim.AppearanceCell.Options.UseForeColor = True
        Me.TotKirim.AppearanceCell.Options.UseTextOptions = True
        Me.TotKirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotKirim.AppearanceHeader.Options.UseTextOptions = True
        Me.TotKirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotKirim.Caption = "Total Kirim"
        Me.TotKirim.Name = "TotKirim"
        Me.TotKirim.OptionsColumn.AllowEdit = False
        Me.TotKirim.OptionsColumn.AllowFocus = False
        Me.TotKirim.Width = 65
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(921, 42)
        Me.Panel3.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.tglSj)
        Me.Panel7.Controls.Add(Me.txtNomor)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(756, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(165, 42)
        Me.Panel7.TabIndex = 8
        '
        'tglSj
        '
        Me.tglSj.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglSj.Location = New System.Drawing.Point(0, 20)
        Me.tglSj.Name = "tglSj"
        Me.tglSj.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglSj.Properties.Appearance.Options.UseBackColor = True
        Me.tglSj.Properties.Appearance.Options.UseTextOptions = True
        Me.tglSj.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tglSj.Size = New System.Drawing.Size(165, 20)
        Me.tglSj.TabIndex = 1
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNomor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(165, 20)
        Me.txtNomor.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(612, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(144, 42)
        Me.Panel6.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel16)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(120, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(492, 42)
        Me.Panel5.TabIndex = 1
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.Controls.Add(Me.txtNamaCustomer)
        Me.Panel12.Controls.Add(Me.txtNoSo)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 21)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(492, 21)
        Me.Panel12.TabIndex = 9
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNamaCustomer.Location = New System.Drawing.Point(206, 0)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.Size = New System.Drawing.Size(286, 21)
        Me.txtNamaCustomer.TabIndex = 2
        '
        'txtNoSo
        '
        Me.txtNoSo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNoSo.Location = New System.Drawing.Point(0, 0)
        Me.txtNoSo.Name = "txtNoSo"
        Me.txtNoSo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtNoSo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtNoSo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNoSo.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtNoSo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNoSo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNoSo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sp", 75, "Nomor SP"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 200, "Customer")})
        Me.txtNoSo.Properties.DisplayMember = "no_sp"
        Me.txtNoSo.Properties.NullText = ""
        Me.txtNoSo.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.txtNoSo.Properties.PopupFormMinSize = New System.Drawing.Size(450, 0)
        Me.txtNoSo.Properties.ValueMember = "no_sp"
        Me.txtNoSo.Size = New System.Drawing.Size(206, 20)
        Me.txtNoSo.TabIndex = 0
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Transparent
        Me.Panel16.Controls.Add(Me.txtNomorRef)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(492, 21)
        Me.Panel16.TabIndex = 7
        '
        'txtNomorRef
        '
        Me.txtNomorRef.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNomorRef.Location = New System.Drawing.Point(0, 0)
        Me.txtNomorRef.Name = "txtNomorRef"
        Me.txtNomorRef.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtNomorRef.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomorRef.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtNomorRef.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomorRef.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtNomorRef.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNomorRef.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNomorRef.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_dpb", 100, "Nomor DPB")})
        Me.txtNomorRef.Properties.DisplayMember = "no_dpb"
        Me.txtNomorRef.Properties.NullText = ""
        Me.txtNomorRef.Properties.ValueMember = "no_dpb"
        Me.txtNomorRef.Size = New System.Drawing.Size(206, 20)
        Me.txtNomorRef.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(120, 42)
        Me.Panel4.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nomor SP : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Nomor DPB : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel15)
        Me.Panel2.Controls.Add(Me.tab)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 92)
        Me.Panel2.TabIndex = 1
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Transparent
        Me.Panel15.Controls.Add(Me.txtKeterangan)
        Me.Panel15.Controls.Add(Me.Label9)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(556, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(365, 92)
        Me.Panel15.TabIndex = 1
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 25)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtKeterangan.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtKeterangan.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtKeterangan.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtKeterangan.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtKeterangan.Size = New System.Drawing.Size(365, 67)
        Me.txtKeterangan.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(365, 25)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Keterangan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.txtAlamatAgent.Location = New System.Drawing.Point(0, 20)
        Me.txtAlamatAgent.Name = "txtAlamatAgent"
        Me.txtAlamatAgent.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtAlamatAgent.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatAgent.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtAlamatAgent.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAlamatAgent.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtAlamatAgent.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtAlamatAgent.Size = New System.Drawing.Size(400, 44)
        Me.txtAlamatAgent.TabIndex = 2
        '
        'txtNamaAgent
        '
        Me.txtNamaAgent.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNamaAgent.Location = New System.Drawing.Point(0, 0)
        Me.txtNamaAgent.Name = "txtNamaAgent"
        Me.txtNamaAgent.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtNamaAgent.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaAgent.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtNamaAgent.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNamaAgent.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtNamaAgent.Properties.AppearanceFocused.Options.UseForeColor = True
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
        Me.txtKetKernet.Location = New System.Drawing.Point(291, 0)
        Me.txtKetKernet.Name = "txtKetKernet"
        Me.txtKetKernet.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtKetKernet.Properties.Appearance.Options.UseBackColor = True
        Me.txtKetKernet.Size = New System.Drawing.Size(109, 20)
        Me.txtKetKernet.TabIndex = 3
        '
        'txtKernet
        '
        Me.txtKernet.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKernet.Location = New System.Drawing.Point(0, 0)
        Me.txtKernet.Name = "txtKernet"
        Me.txtKernet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKernet.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sopir", "Name6", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", 200, "Nama")})
        Me.txtKernet.Properties.DisplayMember = "Nama_Sopir"
        Me.txtKernet.Properties.NullText = ""
        Me.txtKernet.Properties.ReadOnly = True
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
        Me.txtKetSopir.Location = New System.Drawing.Point(291, 0)
        Me.txtKetSopir.Name = "txtKetSopir"
        Me.txtKetSopir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtKetSopir.Properties.Appearance.Options.UseBackColor = True
        Me.txtKetSopir.Size = New System.Drawing.Size(109, 20)
        Me.txtKetSopir.TabIndex = 3
        '
        'txtSopir
        '
        Me.txtSopir.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSopir.Location = New System.Drawing.Point(0, 0)
        Me.txtSopir.Name = "txtSopir"
        Me.txtSopir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSopir.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sopir", "Name4", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", 200, "Sopir")})
        Me.txtSopir.Properties.DisplayMember = "Nama_Sopir"
        Me.txtSopir.Properties.NullText = ""
        Me.txtSopir.Properties.ReadOnly = True
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
        Me.txtketKendaraan.Location = New System.Drawing.Point(291, 0)
        Me.txtketKendaraan.Name = "txtketKendaraan"
        Me.txtketKendaraan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtketKendaraan.Properties.Appearance.Options.UseBackColor = True
        Me.txtketKendaraan.Size = New System.Drawing.Size(109, 20)
        Me.txtketKendaraan.TabIndex = 3
        '
        'txtKendaraan
        '
        Me.txtKendaraan.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKendaraan.Location = New System.Drawing.Point(0, 0)
        Me.txtKendaraan.Name = "txtKendaraan"
        Me.txtKendaraan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKendaraan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Kendaraan", "Kode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kendaraan", 200, "Nama")})
        Me.txtKendaraan.Properties.DisplayMember = "Nama_Kendaraan"
        Me.txtKendaraan.Properties.NullText = ""
        Me.txtKendaraan.Properties.ReadOnly = True
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
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.txtKd_Customer)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 37)
        Me.Panel1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(44, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(152, 37)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "  SURAT JALAN"
        '
        'txtKd_Customer
        '
        Me.txtKd_Customer.Location = New System.Drawing.Point(804, 10)
        Me.txtKd_Customer.Name = "txtKd_Customer"
        Me.txtKd_Customer.Size = New System.Drawing.Size(100, 21)
        Me.txtKd_Customer.TabIndex = 1
        Me.txtKd_Customer.Visible = False
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
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'DXEP
        '
        Me.DXEP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.DXEP.ContainerControl = Me
        '
        'frmSuratJalan
        '
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 554)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmSuratJalan"
        Me.Text = "frmSuratJalan"
        Me.pnl.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.tglSj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.txtNoSo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        CType(Me.txtNomorRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
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
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents tglSj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents txtNoSo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents txtNomorRef As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents txtNamaCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtKd_Customer As System.Windows.Forms.TextBox
    Friend WithEvents repBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents DXEP As System.Windows.Forms.ErrorProvider
End Class
