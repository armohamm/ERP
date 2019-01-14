<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdMonBooked
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
        Me.colNoTrans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNoSP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNamaJenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtyOrder = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtNama_Barang = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtNama_Barang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gc.Location = New System.Drawing.Point(0, 42)
        Me.gc.MainView = Me.gvMain
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(959, 409)
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
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoTrans, Me.colTanggal, Me.colNoSP, Me.colNamaJenis, Me.colSatuan, Me.colQtyOrder})
        Me.gvMain.GridControl = Me.gc
        Me.gvMain.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvMain.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvMain.OptionsView.EnableAppearanceEvenRow = True
        Me.gvMain.OptionsView.EnableAppearanceOddRow = True
        Me.gvMain.OptionsView.ShowFooter = True
        Me.gvMain.OptionsView.ShowGroupPanel = False
        Me.gvMain.PaintStyleName = "Skin"
        '
        'colNoTrans
        '
        Me.colNoTrans.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoTrans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoTrans.Caption = "No. Trans"
        Me.colNoTrans.FieldName = "no_trans"
        Me.colNoTrans.Name = "colNoTrans"
        Me.colNoTrans.OptionsColumn.AllowEdit = False
        Me.colNoTrans.OptionsColumn.ReadOnly = True
        Me.colNoTrans.Visible = True
        Me.colNoTrans.VisibleIndex = 0
        '
        'colTanggal
        '
        Me.colTanggal.AppearanceHeader.Options.UseTextOptions = True
        Me.colTanggal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTanggal.Caption = "Tanggal"
        Me.colTanggal.FieldName = "tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.OptionsColumn.AllowEdit = False
        Me.colTanggal.OptionsColumn.ReadOnly = True
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 1
        '
        'colNoSP
        '
        Me.colNoSP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoSP.Caption = "No. SP"
        Me.colNoSP.FieldName = "No_sp"
        Me.colNoSP.Name = "colNoSP"
        Me.colNoSP.OptionsColumn.AllowEdit = False
        Me.colNoSP.OptionsColumn.ReadOnly = True
        Me.colNoSP.Visible = True
        Me.colNoSP.VisibleIndex = 2
        '
        'colNamaJenis
        '
        Me.colNamaJenis.AppearanceHeader.Options.UseTextOptions = True
        Me.colNamaJenis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNamaJenis.Caption = "Nama Jenis"
        Me.colNamaJenis.FieldName = "Nama_Jenis"
        Me.colNamaJenis.Name = "colNamaJenis"
        Me.colNamaJenis.OptionsColumn.AllowEdit = False
        Me.colNamaJenis.OptionsColumn.ReadOnly = True
        Me.colNamaJenis.Visible = True
        Me.colNamaJenis.VisibleIndex = 3
        '
        'colSatuan
        '
        Me.colSatuan.AppearanceHeader.Options.UseTextOptions = True
        Me.colSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSatuan.Caption = "Satuan"
        Me.colSatuan.FieldName = "Nama_Satuan"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.OptionsColumn.AllowEdit = False
        Me.colSatuan.OptionsColumn.ReadOnly = True
        Me.colSatuan.Visible = True
        Me.colSatuan.VisibleIndex = 4
        '
        'colQtyOrder
        '
        Me.colQtyOrder.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtyOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtyOrder.Caption = "Jml. Book"
        Me.colQtyOrder.FieldName = "Qty_Booked_Akhir"
        Me.colQtyOrder.Name = "colQtyOrder"
        Me.colQtyOrder.OptionsColumn.AllowEdit = False
        Me.colQtyOrder.OptionsColumn.ReadOnly = True
        Me.colQtyOrder.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtyOrder.Visible = True
        Me.colQtyOrder.VisibleIndex = 5
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(961, 484)
        Me.pnl.TabIndex = 2
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(959, 451)
        Me.pnlTengah.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 40)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(537, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 40)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtNama_Barang)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(191, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 40)
        Me.Panel2.TabIndex = 6
        '
        'txtNama_Barang
        '
        Me.txtNama_Barang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNama_Barang.Location = New System.Drawing.Point(0, 0)
        Me.txtNama_Barang.Name = "txtNama_Barang"
        Me.txtNama_Barang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNama_Barang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama_Barang")})
        Me.txtNama_Barang.Properties.NullText = "[Pilih Barang]"
        Me.txtNama_Barang.Size = New System.Drawing.Size(346, 20)
        Me.txtNama_Barang.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(768, 40)
        Me.Panel7.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 40)
        Me.Panel6.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nama Barang : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlAtas.Size = New System.Drawing.Size(959, 31)
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
        Me.LabelControl1.Text = "   MONITORING BOOKING"
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
        'frmProdMonBooked
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 508)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmProdMonBooked"
        Me.Text = "frmProdMonBooked"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtNama_Barang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents colNoTrans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaJenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtNama_Barang As DevExpress.XtraEditors.LookUpEdit
End Class
