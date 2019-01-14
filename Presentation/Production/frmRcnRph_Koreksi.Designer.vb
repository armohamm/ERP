<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRcnRph_Koreksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRcnRph_Koreksi))
        Me.pnl = New System.Windows.Forms.Panel
        Me.btnCetak = New System.Windows.Forms.Button
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.co_no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_tglKirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clKdBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clNmBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clSatuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clJumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_jmlKoreksi_maks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_koreksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_jml_koreksi2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rep_Barang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.pnl2 = New System.Windows.Forms.Panel
        Me.pnl22 = New System.Windows.Forms.Panel
        Me.pnl21 = New System.Windows.Forms.Panel
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.pnl12 = New System.Windows.Forms.Panel
        Me.txt_notrans_koreksi = New DevExpress.XtraEditors.TextEdit
        Me.txtNoTrans = New DevExpress.XtraEditors.LookUpEdit
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit
        Me.pnl11 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtKernet = New DevExpress.XtraEditors.LookUpEdit
        Me.txtSopir = New DevExpress.XtraEditors.LookUpEdit
        Me.txtKendaraan = New DevExpress.XtraEditors.LookUpEdit
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rep_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.pnl12.SuspendLayout()
        CType(Me.txt_notrans_koreksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl11.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKernet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSopir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.btnCetak)
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Controls.Add(Me.txtKernet)
        Me.pnl.Controls.Add(Me.txtSopir)
        Me.pnl.Controls.Add(Me.txtKendaraan)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(981, 488)
        Me.pnl.TabIndex = 0
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(235, 250)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 23)
        Me.btnCetak.TabIndex = 8
        Me.btnCetak.Text = "Button1"
        Me.btnCetak.UseVisualStyleBackColor = True
        Me.btnCetak.Visible = False
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 116)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Rep_Barang})
        Me.GC.Size = New System.Drawing.Size(981, 372)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
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
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.co_no_sp, Me.clNo, Me.col_customer, Me.col_tglKirim, Me.clKdBarang, Me.clNmBarang, Me.clSatuan, Me.clJumlah, Me.col_jmlKoreksi_maks, Me.col_koreksi, Me.col_jml_koreksi2})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.PaintStyleName = "Skin"
        '
        'co_no_sp
        '
        Me.co_no_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.co_no_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.co_no_sp.Caption = "No SP"
        Me.co_no_sp.FieldName = "no_sp"
        Me.co_no_sp.Name = "co_no_sp"
        Me.co_no_sp.OptionsColumn.AllowEdit = False
        Me.co_no_sp.Visible = True
        Me.co_no_sp.VisibleIndex = 0
        Me.co_no_sp.Width = 144
        '
        'clNo
        '
        Me.clNo.AppearanceHeader.Options.UseTextOptions = True
        Me.clNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clNo.Caption = "No."
        Me.clNo.FieldName = "no_sp_dtl"
        Me.clNo.Name = "clNo"
        Me.clNo.OptionsColumn.AllowEdit = False
        Me.clNo.Width = 41
        '
        'col_customer
        '
        Me.col_customer.AppearanceHeader.Options.UseTextOptions = True
        Me.col_customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_customer.Caption = "Nama Customer"
        Me.col_customer.FieldName = "Nama_Customer"
        Me.col_customer.Name = "col_customer"
        Me.col_customer.OptionsColumn.AllowEdit = False
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 1
        Me.col_customer.Width = 222
        '
        'col_tglKirim
        '
        Me.col_tglKirim.AppearanceHeader.Options.UseTextOptions = True
        Me.col_tglKirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_tglKirim.Caption = "Tgl Kirim"
        Me.col_tglKirim.FieldName = "Tgl_Kirim"
        Me.col_tglKirim.Name = "col_tglKirim"
        Me.col_tglKirim.OptionsColumn.AllowEdit = False
        Me.col_tglKirim.Visible = True
        Me.col_tglKirim.VisibleIndex = 2
        Me.col_tglKirim.Width = 88
        '
        'clKdBarang
        '
        Me.clKdBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.clKdBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clKdBarang.Caption = "Kode Barang"
        Me.clKdBarang.FieldName = "Kd_Stok"
        Me.clKdBarang.Name = "clKdBarang"
        Me.clKdBarang.OptionsColumn.AllowEdit = False
        Me.clKdBarang.Width = 251
        '
        'clNmBarang
        '
        Me.clNmBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.clNmBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clNmBarang.Caption = "Nama Barang"
        Me.clNmBarang.FieldName = "Nama_Barang"
        Me.clNmBarang.Name = "clNmBarang"
        Me.clNmBarang.OptionsColumn.AllowEdit = False
        Me.clNmBarang.Visible = True
        Me.clNmBarang.VisibleIndex = 3
        Me.clNmBarang.Width = 290
        '
        'clSatuan
        '
        Me.clSatuan.AppearanceHeader.Options.UseTextOptions = True
        Me.clSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clSatuan.Caption = "Satuan"
        Me.clSatuan.FieldName = "Kd_Satuan"
        Me.clSatuan.Name = "clSatuan"
        Me.clSatuan.OptionsColumn.AllowEdit = False
        Me.clSatuan.Visible = True
        Me.clSatuan.VisibleIndex = 4
        Me.clSatuan.Width = 52
        '
        'clJumlah
        '
        Me.clJumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.clJumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clJumlah.Caption = "Jumlah"
        Me.clJumlah.DisplayFormat.FormatString = "N0"
        Me.clJumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clJumlah.FieldName = "jumlah"
        Me.clJumlah.Name = "clJumlah"
        Me.clJumlah.OptionsColumn.AllowEdit = False
        Me.clJumlah.Visible = True
        Me.clJumlah.VisibleIndex = 5
        Me.clJumlah.Width = 67
        '
        'col_jmlKoreksi_maks
        '
        Me.col_jmlKoreksi_maks.Caption = "Jumlah Koreksi Maks"
        Me.col_jmlKoreksi_maks.FieldName = "jumlah_koreksi_maks"
        Me.col_jmlKoreksi_maks.Name = "col_jmlKoreksi_maks"
        '
        'col_koreksi
        '
        Me.col_koreksi.AppearanceHeader.Options.UseTextOptions = True
        Me.col_koreksi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_koreksi.Caption = "Jumlah Koreksi"
        Me.col_koreksi.DisplayFormat.FormatString = "N0"
        Me.col_koreksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_koreksi.FieldName = "jumlah_koreksi"
        Me.col_koreksi.Name = "col_koreksi"
        Me.col_koreksi.Visible = True
        Me.col_koreksi.VisibleIndex = 6
        Me.col_koreksi.Width = 97
        '
        'col_jml_koreksi2
        '
        Me.col_jml_koreksi2.Caption = "Jumlah Sisa Kirim"
        Me.col_jml_koreksi2.FieldName = "jumlah_koreksi2"
        Me.col_jml_koreksi2.Name = "col_jml_koreksi2"
        '
        'Rep_Barang
        '
        Me.Rep_Barang.AutoHeight = False
        Me.Rep_Barang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Rep_Barang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "kd_barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Rep_Barang.DisplayMember = "Nama_Barang"
        Me.Rep_Barang.Name = "Rep_Barang"
        Me.Rep_Barang.ValueMember = "Kode_Barang"
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.pnl2)
        Me.pnlTools.Controls.Add(Me.pnl1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(981, 82)
        Me.pnlTools.TabIndex = 5
        '
        'pnl2
        '
        Me.pnl2.Controls.Add(Me.pnl22)
        Me.pnl2.Controls.Add(Me.pnl21)
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl2.Location = New System.Drawing.Point(456, 0)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(403, 82)
        Me.pnl2.TabIndex = 1
        '
        'pnl22
        '
        Me.pnl22.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl22.Location = New System.Drawing.Point(96, 0)
        Me.pnl22.Name = "pnl22"
        Me.pnl22.Size = New System.Drawing.Size(302, 82)
        Me.pnl22.TabIndex = 4
        '
        'pnl21
        '
        Me.pnl21.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl21.Location = New System.Drawing.Point(0, 0)
        Me.pnl21.Name = "pnl21"
        Me.pnl21.Size = New System.Drawing.Size(96, 82)
        Me.pnl21.TabIndex = 3
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.pnl12)
        Me.pnl1.Controls.Add(Me.pnl11)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(456, 82)
        Me.pnl1.TabIndex = 0
        '
        'pnl12
        '
        Me.pnl12.Controls.Add(Me.txt_notrans_koreksi)
        Me.pnl12.Controls.Add(Me.txtNoTrans)
        Me.pnl12.Controls.Add(Me.txtTanggal)
        Me.pnl12.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl12.Location = New System.Drawing.Point(158, 0)
        Me.pnl12.Name = "pnl12"
        Me.pnl12.Size = New System.Drawing.Size(298, 82)
        Me.pnl12.TabIndex = 3
        '
        'txt_notrans_koreksi
        '
        Me.txt_notrans_koreksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_notrans_koreksi.Location = New System.Drawing.Point(0, 40)
        Me.txt_notrans_koreksi.Name = "txt_notrans_koreksi"
        Me.txt_notrans_koreksi.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_notrans_koreksi.Properties.Appearance.Options.UseBackColor = True
        Me.txt_notrans_koreksi.Properties.ReadOnly = True
        Me.txt_notrans_koreksi.Size = New System.Drawing.Size(298, 20)
        Me.txt_notrans_koreksi.TabIndex = 15
        '
        'txtNoTrans
        '
        Me.txtNoTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNoTrans.Location = New System.Drawing.Point(0, 20)
        Me.txtNoTrans.Name = "txtNoTrans"
        Me.txtNoTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNoTrans.Properties.NullText = "[Pilih No Transaksi]"
        Me.txtNoTrans.Size = New System.Drawing.Size(298, 20)
        Me.txtNoTrans.TabIndex = 6
        '
        'txtTanggal
        '
        Me.txtTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTanggal.EditValue = Nothing
        Me.txtTanggal.Location = New System.Drawing.Point(0, 0)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTanggal.Properties.Appearance.Options.UseFont = True
        Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txtTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTanggal.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTanggal.Size = New System.Drawing.Size(298, 20)
        Me.txtTanggal.TabIndex = 5
        '
        'pnl11
        '
        Me.pnl11.Controls.Add(Me.Label2)
        Me.pnl11.Controls.Add(Me.Label6)
        Me.pnl11.Controls.Add(Me.Label1)
        Me.pnl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl11.Location = New System.Drawing.Point(0, 0)
        Me.pnl11.Name = "pnl11"
        Me.pnl11.Size = New System.Drawing.Size(158, 82)
        Me.pnl11.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "No. Koreksi RPH : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "* No. RPH : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "* Tanggal : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlTitle.Size = New System.Drawing.Size(981, 34)
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
        Me.lblTitle.Size = New System.Drawing.Size(454, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "KOREKSI DRAFT RPH"
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
        Me.txtKernet.Location = New System.Drawing.Point(305, 234)
        Me.txtKernet.Name = "txtKernet"
        Me.txtKernet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKernet.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sopir", "Name6", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", 200, "Nama")})
        Me.txtKernet.Properties.DisplayMember = "Nama_Sopir"
        Me.txtKernet.Properties.NullText = "[Pilih Kernet]"
        Me.txtKernet.Properties.ValueMember = "Kode_Sopir"
        Me.txtKernet.Size = New System.Drawing.Size(187, 20)
        Me.txtKernet.TabIndex = 19
        '
        'txtSopir
        '
        Me.txtSopir.Enabled = False
        Me.txtSopir.Location = New System.Drawing.Point(92, 234)
        Me.txtSopir.Name = "txtSopir"
        Me.txtSopir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSopir.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sopir", "Name4", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", 200, "Sopir")})
        Me.txtSopir.Properties.DisplayMember = "Nama_Sopir"
        Me.txtSopir.Properties.NullText = "[Pilih Sopir]"
        Me.txtSopir.Properties.ValueMember = "Kode_Sopir"
        Me.txtSopir.Size = New System.Drawing.Size(187, 20)
        Me.txtSopir.TabIndex = 18
        '
        'txtKendaraan
        '
        Me.txtKendaraan.Enabled = False
        Me.txtKendaraan.Location = New System.Drawing.Point(528, 234)
        Me.txtKendaraan.Name = "txtKendaraan"
        Me.txtKendaraan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKendaraan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("No_Polisi", "No Pol."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kendaraan", "Kendaraan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kapasitas", "Kapasitas", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.txtKendaraan.Properties.DisplayMember = "Nama_Kendaraan"
        Me.txtKendaraan.Properties.NullText = "[Pilih Kendaraan]"
        Me.txtKendaraan.Properties.ValueMember = "Kode_Kendaraan"
        Me.txtKendaraan.Size = New System.Drawing.Size(141, 20)
        Me.txtKendaraan.TabIndex = 17
        '
        'frmRcnRph_Koreksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 512)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmRcnRph_Koreksi"
        Me.Text = "frmGenDPB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rep_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.pnl2.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        Me.pnl12.ResumeLayout(False)
        CType(Me.txt_notrans_koreksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl11.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKernet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSopir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents pnl22 As System.Windows.Forms.Panel
    Friend WithEvents pnl21 As System.Windows.Forms.Panel
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents pnl12 As System.Windows.Forms.Panel
    Friend WithEvents pnl11 As System.Windows.Forms.Panel
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clKdBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clNmBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clJumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtKernet As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSopir As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtKendaraan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNoTrans As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents co_no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rep_Barang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txt_notrans_koreksi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents col_koreksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tglKirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_jml_koreksi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_jmlKoreksi_maks As DevExpress.XtraGrid.Columns.GridColumn
End Class
