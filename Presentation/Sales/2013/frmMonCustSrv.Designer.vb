<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonCustSrv
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonCustSrv))
        Me.Qty_balik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GVD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_pnrm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Alamat_Tarik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KOTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_Telp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_lahir_umum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lckBlnAkhir = New DevExpress.XtraEditors.LookUpEdit
        Me.lckBlnAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.lckBlnAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckBlnAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Qty_balik
        '
        Me.Qty_balik.Caption = "Qty Balik"
        Me.Qty_balik.FieldName = "Qty_balik"
        Me.Qty_balik.Name = "Qty_balik"
        Me.Qty_balik.Visible = True
        Me.Qty_balik.VisibleIndex = 3
        Me.Qty_balik.Width = 86
        '
        'GVD
        '
        Me.GVD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.Empty.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVD.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.OddRow.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.Options.UseForeColor = True
        Me.GVD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVD.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVD.Appearance.Preview.Options.UseBackColor = True
        Me.GVD.Appearance.Preview.Options.UseFont = True
        Me.GVD.Appearance.Preview.Options.UseForeColor = True
        Me.GVD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.Row.Options.UseBackColor = True
        Me.GVD.Appearance.Row.Options.UseBorderColor = True
        Me.GVD.Appearance.Row.Options.UseForeColor = True
        Me.GVD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.VertLine.Options.UseBackColor = True
        Me.GVD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_stok, Me.Qty_kirim, Me.Kd_satuan, Me.Qty_balik, Me.Keterangan})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.Qty_balik
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        Me.GVD.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GVD.GridControl = Me.GC
        Me.GVD.Name = "GVD"
        Me.GVD.OptionsBehavior.Editable = False
        Me.GVD.OptionsView.EnableAppearanceEvenRow = True
        Me.GVD.OptionsView.EnableAppearanceOddRow = True
        Me.GVD.OptionsView.ShowGroupPanel = False
        Me.GVD.OptionsView.ShowIndicator = False
        '
        'Kd_stok
        '
        Me.Kd_stok.Caption = "Barang"
        Me.Kd_stok.FieldName = "Nama_Barang"
        Me.Kd_stok.Name = "Kd_stok"
        Me.Kd_stok.Visible = True
        Me.Kd_stok.VisibleIndex = 0
        Me.Kd_stok.Width = 428
        '
        'Qty_kirim
        '
        Me.Qty_kirim.Caption = "Qty Kirim"
        Me.Qty_kirim.FieldName = "Qty_kirim"
        Me.Qty_kirim.Name = "Qty_kirim"
        Me.Qty_kirim.Visible = True
        Me.Qty_kirim.VisibleIndex = 2
        Me.Qty_kirim.Width = 80
        '
        'Kd_satuan
        '
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "Kd_satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 1
        Me.Kd_satuan.Width = 82
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 4
        Me.Keterangan.Width = 281
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 94)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(961, 173)
        Me.GC.TabIndex = 3
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GVD})
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
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_sp, Me.Nama_pnrm, Me.Alamat_Tarik, Me.KOTA, Me.No_Telp, Me.tgl_lahir_umum})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowIndicator = False
        '
        'No_sp
        '
        Me.No_sp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.No_sp.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.No_sp.AppearanceHeader.Options.UseFont = True
        Me.No_sp.AppearanceHeader.Options.UseForeColor = True
        Me.No_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.No_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_sp.Caption = "No SP"
        Me.No_sp.FieldName = "No_sp"
        Me.No_sp.Name = "No_sp"
        Me.No_sp.OptionsColumn.AllowEdit = False
        Me.No_sp.OptionsColumn.ReadOnly = True
        Me.No_sp.Visible = True
        Me.No_sp.VisibleIndex = 0
        '
        'Nama_pnrm
        '
        Me.Nama_pnrm.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Nama_pnrm.AppearanceHeader.Options.UseFont = True
        Me.Nama_pnrm.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_pnrm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_pnrm.Caption = "Nama Penerima"
        Me.Nama_pnrm.FieldName = "Nama_pnrm"
        Me.Nama_pnrm.Name = "Nama_pnrm"
        Me.Nama_pnrm.OptionsColumn.AllowEdit = False
        Me.Nama_pnrm.OptionsColumn.ReadOnly = True
        Me.Nama_pnrm.Visible = True
        Me.Nama_pnrm.VisibleIndex = 1
        '
        'Alamat_Tarik
        '
        Me.Alamat_Tarik.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Alamat_Tarik.AppearanceHeader.Options.UseFont = True
        Me.Alamat_Tarik.AppearanceHeader.Options.UseTextOptions = True
        Me.Alamat_Tarik.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Alamat_Tarik.Caption = "Alamat Tarik"
        Me.Alamat_Tarik.FieldName = "Alamat_Tarik"
        Me.Alamat_Tarik.Name = "Alamat_Tarik"
        Me.Alamat_Tarik.OptionsColumn.AllowEdit = False
        Me.Alamat_Tarik.OptionsColumn.ReadOnly = True
        Me.Alamat_Tarik.Visible = True
        Me.Alamat_Tarik.VisibleIndex = 2
        '
        'KOTA
        '
        Me.KOTA.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KOTA.AppearanceHeader.Options.UseFont = True
        Me.KOTA.AppearanceHeader.Options.UseTextOptions = True
        Me.KOTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.KOTA.Caption = "Kota"
        Me.KOTA.FieldName = "KOTA"
        Me.KOTA.Name = "KOTA"
        Me.KOTA.OptionsColumn.AllowEdit = False
        Me.KOTA.OptionsColumn.ReadOnly = True
        Me.KOTA.Visible = True
        Me.KOTA.VisibleIndex = 3
        '
        'No_Telp
        '
        Me.No_Telp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.No_Telp.AppearanceHeader.Options.UseFont = True
        Me.No_Telp.AppearanceHeader.Options.UseTextOptions = True
        Me.No_Telp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_Telp.Caption = "No Telp"
        Me.No_Telp.FieldName = "No_Telp"
        Me.No_Telp.Name = "No_Telp"
        Me.No_Telp.OptionsColumn.AllowEdit = False
        Me.No_Telp.OptionsColumn.ReadOnly = True
        Me.No_Telp.Visible = True
        Me.No_Telp.VisibleIndex = 4
        '
        'tgl_lahir_umum
        '
        Me.tgl_lahir_umum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_lahir_umum.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tgl_lahir_umum.AppearanceHeader.Options.UseFont = True
        Me.tgl_lahir_umum.AppearanceHeader.Options.UseForeColor = True
        Me.tgl_lahir_umum.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_lahir_umum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_lahir_umum.Caption = "Tanggal Lahir"
        Me.tgl_lahir_umum.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_lahir_umum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_lahir_umum.FieldName = "tgl_lahir_umum"
        Me.tgl_lahir_umum.Name = "tgl_lahir_umum"
        Me.tgl_lahir_umum.OptionsColumn.AllowEdit = False
        Me.tgl_lahir_umum.OptionsColumn.ReadOnly = True
        Me.tgl_lahir_umum.Visible = True
        Me.tgl_lahir_umum.VisibleIndex = 5
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(961, 267)
        Me.pnl.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.lckBlnAkhir)
        Me.Panel2.Controls.Add(Me.lckBlnAwal)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(961, 57)
        Me.Panel2.TabIndex = 4
        '
        'lckBlnAkhir
        '
        Me.lckBlnAkhir.EnterMoveNextControl = True
        Me.lckBlnAkhir.Location = New System.Drawing.Point(133, 32)
        Me.lckBlnAkhir.Name = "lckBlnAkhir"
        Me.lckBlnAkhir.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckBlnAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckBlnAkhir.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bulan", "Name2")})
        Me.lckBlnAkhir.Properties.ImmediatePopup = True
        Me.lckBlnAkhir.Properties.NullText = "[Pilih Bulan]"
        Me.lckBlnAkhir.Properties.ShowFooter = False
        Me.lckBlnAkhir.Properties.ShowHeader = False
        Me.lckBlnAkhir.Properties.ShowPopupShadow = False
        Me.lckBlnAkhir.Properties.ValidateOnEnterKey = True
        Me.lckBlnAkhir.Size = New System.Drawing.Size(100, 20)
        Me.lckBlnAkhir.TabIndex = 43
        '
        'lckBlnAwal
        '
        Me.lckBlnAwal.EnterMoveNextControl = True
        Me.lckBlnAwal.Location = New System.Drawing.Point(133, 6)
        Me.lckBlnAwal.Name = "lckBlnAwal"
        Me.lckBlnAwal.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckBlnAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckBlnAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bulan", "Name2")})
        Me.lckBlnAwal.Properties.ImmediatePopup = True
        Me.lckBlnAwal.Properties.NullText = "[Pilih Bulan]"
        Me.lckBlnAwal.Properties.ShowFooter = False
        Me.lckBlnAwal.Properties.ShowHeader = False
        Me.lckBlnAwal.Properties.ShowPopupShadow = False
        Me.lckBlnAwal.Properties.ValidateOnEnterKey = True
        Me.lckBlnAwal.Size = New System.Drawing.Size(100, 20)
        Me.lckBlnAwal.TabIndex = 42
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(243, 8)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(53, 41)
        Me.cmdRefresh.TabIndex = 41
        Me.cmdRefresh.ToolTip = "Refresh Data"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 57)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 37)
        Me.Panel1.TabIndex = 1
        '
        'lblJudul
        '
        Me.lblJudul.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblJudul.Appearance.Options.UseFont = True
        Me.lblJudul.Appearance.Options.UseForeColor = True
        Me.lblJudul.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblJudul.Location = New System.Drawing.Point(44, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(275, 37)
        Me.lblJudul.TabIndex = 4
        Me.lblJudul.Text = "  Monitoring Customer Service"
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
        'frmMonCustSrv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 267)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonCustSrv"
        Me.Text = "frmMonCustSrv"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.lckBlnAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckBlnAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_lahir_umum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_balik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_pnrm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alamat_Tarik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KOTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_Telp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lckBlnAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lckBlnAkhir As DevExpress.XtraEditors.LookUpEdit
End Class
