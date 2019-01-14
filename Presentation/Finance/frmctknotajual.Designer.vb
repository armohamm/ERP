<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmctknotajual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmctknotajual))
        Me.gvdetailSJ = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lookupbrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_balik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcInvoice = New DevExpress.XtraGrid.GridControl
        Me.Gvheader = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lookupcust = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_sopir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupsopir = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Keterangan1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sts_nota = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gvdetailSP = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_satuan1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.potongan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnDel = New System.Windows.Forms.Button
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlBwh = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.ckcetak = New DevExpress.XtraEditors.CheckEdit
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.gvdetailSJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookupbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gvheader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookupcust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupsopir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvdetailSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlBwh.SuspendLayout()
        CType(Me.ckcetak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvdetailSJ
        '
        Me.gvdetailSJ.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gvdetailSJ.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSJ.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvdetailSJ.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.gvdetailSJ.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.gvdetailSJ.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.gvdetailSJ.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSJ.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvdetailSJ.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvdetailSJ.Appearance.Empty.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gvdetailSJ.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSJ.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvdetailSJ.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.gvdetailSJ.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvdetailSJ.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.gvdetailSJ.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvdetailSJ.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gvdetailSJ.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvdetailSJ.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gvdetailSJ.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSJ.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvdetailSJ.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvdetailSJ.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvdetailSJ.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvdetailSJ.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvdetailSJ.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvdetailSJ.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvdetailSJ.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvdetailSJ.Appearance.GroupFooter.Options.UseFont = True
        Me.gvdetailSJ.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.gvdetailSJ.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvdetailSJ.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvdetailSJ.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvdetailSJ.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvdetailSJ.Appearance.GroupRow.Options.UseFont = True
        Me.gvdetailSJ.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gvdetailSJ.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvdetailSJ.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSJ.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvdetailSJ.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gvdetailSJ.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gvdetailSJ.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvdetailSJ.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvdetailSJ.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gvdetailSJ.Appearance.Preview.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.Preview.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvdetailSJ.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSJ.Appearance.Row.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.Row.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvdetailSJ.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.gvdetailSJ.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvdetailSJ.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvdetailSJ.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvdetailSJ.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvdetailSJ.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvdetailSJ.Appearance.VertLine.Options.UseBackColor = True
        Me.gvdetailSJ.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.gvdetailSJ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.Kd_stok, Me.Kd_satuan, Me.Qty_kirim, Me.Qty_balik, Me.Keterangan})
        Me.gvdetailSJ.GridControl = Me.GcInvoice
        Me.gvdetailSJ.Name = "gvdetailSJ"
        Me.gvdetailSJ.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvdetailSJ.OptionsCustomization.AllowColumnMoving = False
        Me.gvdetailSJ.OptionsCustomization.AllowColumnResizing = False
        Me.gvdetailSJ.OptionsCustomization.AllowFilter = False
        Me.gvdetailSJ.OptionsCustomization.AllowGroup = False
        Me.gvdetailSJ.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvdetailSJ.OptionsCustomization.AllowSort = False
        Me.gvdetailSJ.OptionsView.EnableAppearanceEvenRow = True
        Me.gvdetailSJ.OptionsView.ShowGroupPanel = False
        Me.gvdetailSJ.OptionsView.ShowIndicator = False
        Me.gvdetailSJ.PaintStyleName = "Style3D"
        '
        'No_seq
        '
        Me.No_seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_seq.AppearanceHeader.Options.UseFont = True
        Me.No_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.No_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_seq.Caption = "Nomor"
        Me.No_seq.FieldName = "no_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.OptionsColumn.ReadOnly = True
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 54
        '
        'Kd_stok
        '
        Me.Kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kd_stok.AppearanceHeader.Options.UseFont = True
        Me.Kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_stok.Caption = "Nama Barang"
        Me.Kd_stok.ColumnEdit = Me.Lookupbrg
        Me.Kd_stok.FieldName = "Kd_stok"
        Me.Kd_stok.Name = "Kd_stok"
        Me.Kd_stok.OptionsColumn.AllowEdit = False
        Me.Kd_stok.OptionsColumn.ReadOnly = True
        Me.Kd_stok.Visible = True
        Me.Kd_stok.VisibleIndex = 1
        Me.Kd_stok.Width = 251
        '
        'Lookupbrg
        '
        Me.Lookupbrg.AutoHeight = False
        Me.Lookupbrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookupbrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama_Barang")})
        Me.Lookupbrg.Name = "Lookupbrg"
        Me.Lookupbrg.NullText = "[Pilih Disini]"
        '
        'Kd_satuan
        '
        Me.Kd_satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kd_satuan.AppearanceHeader.Options.UseFont = True
        Me.Kd_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "Kd_satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.OptionsColumn.AllowEdit = False
        Me.Kd_satuan.OptionsColumn.ReadOnly = True
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 2
        Me.Kd_satuan.Width = 88
        '
        'Qty_kirim
        '
        Me.Qty_kirim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Qty_kirim.AppearanceCell.Options.UseBackColor = True
        Me.Qty_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_kirim.AppearanceHeader.Options.UseFont = True
        Me.Qty_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty_kirim.Caption = "Qty Kirim"
        Me.Qty_kirim.FieldName = "kirim"
        Me.Qty_kirim.Name = "Qty_kirim"
        Me.Qty_kirim.OptionsColumn.AllowEdit = False
        Me.Qty_kirim.OptionsColumn.ReadOnly = True
        Me.Qty_kirim.Visible = True
        Me.Qty_kirim.VisibleIndex = 3
        Me.Qty_kirim.Width = 100
        '
        'Qty_balik
        '
        Me.Qty_balik.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Qty_balik.AppearanceCell.Options.UseBackColor = True
        Me.Qty_balik.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_balik.AppearanceHeader.Options.UseFont = True
        Me.Qty_balik.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_balik.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty_balik.Caption = "Qty Balik"
        Me.Qty_balik.FieldName = "balik"
        Me.Qty_balik.Name = "Qty_balik"
        Me.Qty_balik.OptionsColumn.AllowEdit = False
        Me.Qty_balik.OptionsColumn.ReadOnly = True
        Me.Qty_balik.Visible = True
        Me.Qty_balik.VisibleIndex = 4
        Me.Qty_balik.Width = 107
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.OptionsColumn.AllowEdit = False
        Me.Keterangan.OptionsColumn.ReadOnly = True
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 5
        Me.Keterangan.Width = 353
        '
        'GcInvoice
        '
        Me.GcInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvdetailSJ
        GridLevelNode1.RelationName = "Level1"
        Me.GcInvoice.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcInvoice.Location = New System.Drawing.Point(0, 34)
        Me.GcInvoice.MainView = Me.Gvheader
        Me.GcInvoice.Name = "GcInvoice"
        Me.GcInvoice.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Lookupbrg, Me.Lookupcust, Me.CekStat, Me.lookupsopir})
        Me.GcInvoice.Size = New System.Drawing.Size(974, 316)
        Me.GcInvoice.TabIndex = 29
        Me.GcInvoice.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gvheader, Me.gvdetailSP, Me.gvdetailSJ})
        '
        'Gvheader
        '
        Me.Gvheader.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Gvheader.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Gvheader.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Gvheader.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Gvheader.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Gvheader.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Gvheader.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.Empty.Options.UseBackColor = True
        Me.Gvheader.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.EvenRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.EvenRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Gvheader.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Gvheader.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.Gvheader.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Gvheader.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Gvheader.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Gvheader.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Gvheader.Appearance.FixedLine.Options.UseBackColor = True
        Me.Gvheader.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Gvheader.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Gvheader.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Gvheader.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Gvheader.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Gvheader.Appearance.FooterPanel.Options.UseForeColor = True
        Me.Gvheader.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.GroupButton.Options.UseBackColor = True
        Me.Gvheader.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Gvheader.Appearance.GroupButton.Options.UseForeColor = True
        Me.Gvheader.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Gvheader.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Gvheader.Appearance.GroupFooter.Options.UseForeColor = True
        Me.Gvheader.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Gvheader.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Gvheader.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Gvheader.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Gvheader.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.GroupRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.GroupRow.Options.UseBorderColor = True
        Me.Gvheader.Appearance.GroupRow.Options.UseFont = True
        Me.Gvheader.Appearance.GroupRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Gvheader.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Gvheader.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.Gvheader.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Gvheader.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Gvheader.Appearance.HorzLine.Options.UseBackColor = True
        Me.Gvheader.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.OddRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.OddRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvheader.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Gvheader.Appearance.Preview.Options.UseBackColor = True
        Me.Gvheader.Appearance.Preview.Options.UseForeColor = True
        Me.Gvheader.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.Row.Options.UseBackColor = True
        Me.Gvheader.Appearance.Row.Options.UseForeColor = True
        Me.Gvheader.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Gvheader.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Gvheader.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.SelectedRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Gvheader.Appearance.VertLine.Options.UseBackColor = True
        Me.Gvheader.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sj, Me.no_sp, Me.tgl_order, Me.tgl_kirim, Me.kd_customer, Me.kd_sopir, Me.Keterangan1, Me.sts_nota, Me.tipe_trans})
        Me.Gvheader.GridControl = Me.GcInvoice
        Me.Gvheader.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.Gvheader.Name = "Gvheader"
        Me.Gvheader.OptionsDetail.AllowExpandEmptyDetails = True
        Me.Gvheader.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.Gvheader.OptionsView.EnableAppearanceEvenRow = True
        Me.Gvheader.OptionsView.EnableAppearanceOddRow = True
        Me.Gvheader.OptionsView.RowAutoHeight = True
        Me.Gvheader.OptionsView.ShowFooter = True
        Me.Gvheader.PaintStyleName = "WindowsXP"
        '
        'no_sj
        '
        Me.no_sj.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.no_sj.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_sj.AppearanceHeader.Options.UseBackColor = True
        Me.no_sj.AppearanceHeader.Options.UseFont = True
        Me.no_sj.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sj.Caption = "No. Surat Jalan"
        Me.no_sj.FieldName = "no_sj"
        Me.no_sj.Name = "no_sj"
        Me.no_sj.OptionsColumn.ReadOnly = True
        Me.no_sj.SummaryItem.DisplayFormat = "Jumlah SJ : {0}"
        Me.no_sj.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.no_sj.Visible = True
        Me.no_sj.VisibleIndex = 0
        Me.no_sj.Width = 111
        '
        'no_sp
        '
        Me.no_sp.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.no_sp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_sp.AppearanceHeader.Options.UseBackColor = True
        Me.no_sp.AppearanceHeader.Options.UseFont = True
        Me.no_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.Caption = "No. Order/SP"
        Me.no_sp.FieldName = "No_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.OptionsColumn.ReadOnly = True
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 1
        Me.no_sp.Width = 122
        '
        'tgl_order
        '
        Me.tgl_order.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tgl_order.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_order.AppearanceHeader.Options.UseBackColor = True
        Me.tgl_order.AppearanceHeader.Options.UseFont = True
        Me.tgl_order.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_order.Caption = "Tgl. Order"
        Me.tgl_order.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_order.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_order.FieldName = "tgl_order"
        Me.tgl_order.Name = "tgl_order"
        Me.tgl_order.OptionsColumn.AllowEdit = False
        Me.tgl_order.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.tgl_order.OptionsColumn.ReadOnly = True
        Me.tgl_order.Visible = True
        Me.tgl_order.VisibleIndex = 2
        Me.tgl_order.Width = 91
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tgl_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_kirim.AppearanceHeader.Options.UseBackColor = True
        Me.tgl_kirim.AppearanceHeader.Options.UseFont = True
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.Caption = "Tgl. SJ"
        Me.tgl_kirim.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_kirim.FieldName = "TglSJ"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.OptionsColumn.AllowEdit = False
        Me.tgl_kirim.OptionsColumn.ReadOnly = True
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 3
        Me.tgl_kirim.Width = 89
        '
        'kd_customer
        '
        Me.kd_customer.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kd_customer.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_customer.AppearanceHeader.Options.UseBackColor = True
        Me.kd_customer.AppearanceHeader.Options.UseFont = True
        Me.kd_customer.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_customer.Caption = "Customer"
        Me.kd_customer.ColumnEdit = Me.Lookupcust
        Me.kd_customer.FieldName = "kd_customer"
        Me.kd_customer.Name = "kd_customer"
        Me.kd_customer.OptionsColumn.AllowEdit = False
        Me.kd_customer.OptionsColumn.ReadOnly = True
        Me.kd_customer.Visible = True
        Me.kd_customer.VisibleIndex = 4
        Me.kd_customer.Width = 172
        '
        'Lookupcust
        '
        Me.Lookupcust.AutoHeight = False
        Me.Lookupcust.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookupcust.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Nama")})
        Me.Lookupcust.Name = "Lookupcust"
        Me.Lookupcust.NullText = "[Pilih Disini]"
        '
        'kd_sopir
        '
        Me.kd_sopir.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kd_sopir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_sopir.AppearanceHeader.Options.UseBackColor = True
        Me.kd_sopir.AppearanceHeader.Options.UseFont = True
        Me.kd_sopir.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_sopir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_sopir.Caption = "Nama Sopir"
        Me.kd_sopir.ColumnEdit = Me.lookupsopir
        Me.kd_sopir.FieldName = "Kd_sopir"
        Me.kd_sopir.Name = "kd_sopir"
        Me.kd_sopir.OptionsColumn.AllowEdit = False
        Me.kd_sopir.OptionsColumn.ReadOnly = True
        Me.kd_sopir.Visible = True
        Me.kd_sopir.VisibleIndex = 6
        Me.kd_sopir.Width = 146
        '
        'lookupsopir
        '
        Me.lookupsopir.AutoHeight = False
        Me.lookupsopir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupsopir.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", "Nama_Sopir")})
        Me.lookupsopir.Name = "lookupsopir"
        Me.lookupsopir.NullText = "[Pilih Disini]"
        '
        'Keterangan1
        '
        Me.Keterangan1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Keterangan1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keterangan1.AppearanceHeader.Options.UseBackColor = True
        Me.Keterangan1.AppearanceHeader.Options.UseFont = True
        Me.Keterangan1.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan1.Caption = "Keterangan"
        Me.Keterangan1.FieldName = "Keterangan"
        Me.Keterangan1.Name = "Keterangan1"
        Me.Keterangan1.OptionsColumn.AllowEdit = False
        Me.Keterangan1.OptionsColumn.ReadOnly = True
        Me.Keterangan1.Visible = True
        Me.Keterangan1.VisibleIndex = 5
        Me.Keterangan1.Width = 174
        '
        'sts_nota
        '
        Me.sts_nota.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sts_nota.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sts_nota.AppearanceHeader.Options.UseBackColor = True
        Me.sts_nota.AppearanceHeader.Options.UseFont = True
        Me.sts_nota.AppearanceHeader.Options.UseTextOptions = True
        Me.sts_nota.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sts_nota.Caption = "Cetak"
        Me.sts_nota.ColumnEdit = Me.CekStat
        Me.sts_nota.FieldName = "sts_nota"
        Me.sts_nota.Name = "sts_nota"
        Me.sts_nota.Visible = True
        Me.sts_nota.VisibleIndex = 7
        Me.sts_nota.Width = 48
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CekStat.Caption = ""
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CekStat.ValueChecked = "NOTA"
        Me.CekStat.ValueUnchecked = Nothing
        '
        'tipe_trans
        '
        Me.tipe_trans.Caption = "GridColumn1"
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        '
        'gvdetailSP
        '
        Me.gvdetailSP.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.gvdetailSP.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSP.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvdetailSP.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White
        Me.gvdetailSP.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvdetailSP.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White
        Me.gvdetailSP.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSP.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvdetailSP.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvdetailSP.Appearance.Empty.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.gvdetailSP.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSP.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvdetailSP.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.gvdetailSP.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvdetailSP.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.gvdetailSP.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.gvdetailSP.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.gvdetailSP.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSP.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvdetailSP.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvdetailSP.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvdetailSP.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvdetailSP.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvdetailSP.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvdetailSP.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvdetailSP.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.gvdetailSP.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvdetailSP.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvdetailSP.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvdetailSP.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvdetailSP.Appearance.GroupRow.Options.UseFont = True
        Me.gvdetailSP.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.gvdetailSP.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvdetailSP.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvdetailSP.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvdetailSP.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gvdetailSP.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.gvdetailSP.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvdetailSP.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvdetailSP.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.OddRow.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.OddRow.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.gvdetailSP.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.gvdetailSP.Appearance.Preview.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.Preview.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvdetailSP.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.Row.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.Row.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvdetailSP.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.gvdetailSP.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gvdetailSP.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvdetailSP.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvdetailSP.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvdetailSP.Appearance.VertLine.Options.UseBackColor = True
        Me.gvdetailSP.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.gvdetailSP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq1, Me.Kd_Stok1, Me.Kd_satuan1, Me.Qty, Me.harga, Me.potongan, Me.total})
        Me.gvdetailSP.GridControl = Me.GcInvoice
        Me.gvdetailSP.Name = "gvdetailSP"
        Me.gvdetailSP.OptionsCustomization.AllowColumnMoving = False
        Me.gvdetailSP.OptionsCustomization.AllowColumnResizing = False
        Me.gvdetailSP.OptionsCustomization.AllowFilter = False
        Me.gvdetailSP.OptionsCustomization.AllowGroup = False
        Me.gvdetailSP.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvdetailSP.OptionsCustomization.AllowSort = False
        Me.gvdetailSP.OptionsView.EnableAppearanceEvenRow = True
        Me.gvdetailSP.OptionsView.EnableAppearanceOddRow = True
        Me.gvdetailSP.OptionsView.ShowFooter = True
        Me.gvdetailSP.OptionsView.ShowGroupPanel = False
        Me.gvdetailSP.OptionsView.ShowIndicator = False
        Me.gvdetailSP.PaintStyleName = "Style3D"
        '
        'No_seq1
        '
        Me.No_seq1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_seq1.AppearanceHeader.Options.UseFont = True
        Me.No_seq1.AppearanceHeader.Options.UseTextOptions = True
        Me.No_seq1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_seq1.Caption = "Nomor"
        Me.No_seq1.FieldName = "No_seq"
        Me.No_seq1.Name = "No_seq1"
        Me.No_seq1.OptionsColumn.AllowEdit = False
        Me.No_seq1.Visible = True
        Me.No_seq1.VisibleIndex = 0
        Me.No_seq1.Width = 65
        '
        'Kd_Stok1
        '
        Me.Kd_Stok1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kd_Stok1.AppearanceHeader.Options.UseFont = True
        Me.Kd_Stok1.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_Stok1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_Stok1.Caption = "Nama Barang"
        Me.Kd_Stok1.ColumnEdit = Me.Lookupbrg
        Me.Kd_Stok1.FieldName = "Kd_Stok"
        Me.Kd_Stok1.Name = "Kd_Stok1"
        Me.Kd_Stok1.OptionsColumn.AllowEdit = False
        Me.Kd_Stok1.Visible = True
        Me.Kd_Stok1.VisibleIndex = 1
        Me.Kd_Stok1.Width = 293
        '
        'Kd_satuan1
        '
        Me.Kd_satuan1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kd_satuan1.AppearanceHeader.Options.UseFont = True
        Me.Kd_satuan1.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_satuan1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_satuan1.Caption = "Satuan"
        Me.Kd_satuan1.FieldName = "Kd_satuan"
        Me.Kd_satuan1.Name = "Kd_satuan1"
        Me.Kd_satuan1.OptionsColumn.AllowEdit = False
        Me.Kd_satuan1.Visible = True
        Me.Kd_satuan1.VisibleIndex = 2
        Me.Kd_satuan1.Width = 56
        '
        'Qty
        '
        Me.Qty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty.AppearanceHeader.Options.UseFont = True
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty.Caption = "Quantity"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.AllowEdit = False
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 3
        Me.Qty.Width = 66
        '
        'harga
        '
        Me.harga.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.AppearanceHeader.Options.UseFont = True
        Me.harga.AppearanceHeader.Options.UseTextOptions = True
        Me.harga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.harga.Caption = "Harga"
        Me.harga.DisplayFormat.FormatString = "n2"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.OptionsColumn.AllowEdit = False
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 4
        Me.harga.Width = 148
        '
        'potongan
        '
        Me.potongan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.potongan.AppearanceHeader.Options.UseFont = True
        Me.potongan.AppearanceHeader.Options.UseTextOptions = True
        Me.potongan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.potongan.Caption = "Potongan"
        Me.potongan.DisplayFormat.FormatString = "n2"
        Me.potongan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.potongan.FieldName = "potongan"
        Me.potongan.Name = "potongan"
        Me.potongan.OptionsColumn.AllowEdit = False
        Me.potongan.Visible = True
        Me.potongan.VisibleIndex = 5
        Me.potongan.Width = 128
        '
        'total
        '
        Me.total.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.total.AppearanceCell.Options.UseBackColor = True
        Me.total.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.AppearanceHeader.Options.UseFont = True
        Me.total.AppearanceHeader.Options.UseTextOptions = True
        Me.total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.total.Caption = "Total"
        Me.total.DisplayFormat.FormatString = "n2"
        Me.total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.total.FieldName = "total"
        Me.total.Name = "total"
        Me.total.OptionsColumn.AllowEdit = False
        Me.total.SummaryItem.DisplayFormat = "{0:n2}"
        Me.total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.total.SummaryItem.Tag = 1
        Me.total.Visible = True
        Me.total.VisibleIndex = 6
        Me.total.Width = 203
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(482, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        Me.btnDel.Visible = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcInvoice)
        Me.pnl.Controls.Add(Me.pnlBwh)
        Me.pnl.Controls.Add(Me.pnlTop)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(974, 385)
        Me.pnl.TabIndex = 1
        '
        'pnlBwh
        '
        Me.pnlBwh.BackColor = System.Drawing.Color.DarkGray
        Me.pnlBwh.Controls.Add(Me.btnRefresh)
        Me.pnlBwh.Controls.Add(Me.ckcetak)
        Me.pnlBwh.Controls.Add(Me.btnDel)
        Me.pnlBwh.Controls.Add(Me.btnExit)
        Me.pnlBwh.Controls.Add(Me.cmdSimpan)
        Me.pnlBwh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBwh.Location = New System.Drawing.Point(0, 350)
        Me.pnlBwh.Name = "pnlBwh"
        Me.pnlBwh.Size = New System.Drawing.Size(974, 35)
        Me.pnlBwh.TabIndex = 28
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(336, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 23)
        Me.btnRefresh.TabIndex = 29
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.ToolTip = "Load ulang data"
        '
        'ckcetak
        '
        Me.ckcetak.Dock = System.Windows.Forms.DockStyle.Right
        Me.ckcetak.Location = New System.Drawing.Point(885, 0)
        Me.ckcetak.Name = "ckcetak"
        Me.ckcetak.Properties.Caption = "Cetak semua"
        Me.ckcetak.Size = New System.Drawing.Size(89, 19)
        Me.ckcetak.TabIndex = 28
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(600, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(26, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(145, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Proses + Cetak Inv"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        Me.cmdSimpan.Visible = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Maroon
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(974, 34)
        Me.pnlTop.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          CETAK INVOICE PENJUALAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmctknotajual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 385)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmctknotajual"
        Me.Text = "Cetak Nota Penjualan"
        CType(Me.gvdetailSJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookupbrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gvheader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookupcust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupsopir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvdetailSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlBwh.ResumeLayout(False)
        CType(Me.ckcetak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Keterangan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvdetailSJ As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lookupbrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lookupcust As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Qty_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_balik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GcInvoice As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gvheader As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_sopir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sts_nota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlBwh As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gvdetailSP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_seq1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_satuan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents potongan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupsopir As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ckcetak As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
End Class
