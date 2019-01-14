<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonQC
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonQC))
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcMonQC = New DevExpress.XtraGrid.GridControl
        Me.GvMonQC = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_NoSJ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_pass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.hold_history = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_unpass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Created_By = New DevExpress.XtraGrid.Columns.GridColumn
        Me.hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.pnl.SuspendLayout()
        CType(Me.GcMonQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMonQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "s/d"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMonQC)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(979, 373)
        Me.pnl.TabIndex = 3
        '
        'GcMonQC
        '
        Me.GcMonQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMonQC.Location = New System.Drawing.Point(0, 79)
        Me.GcMonQC.LookAndFeel.SkinName = "The Asphalt World"
        Me.GcMonQC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GcMonQC.MainView = Me.GvMonQC
        Me.GcMonQC.Name = "GcMonQC"
        Me.GcMonQC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang})
        Me.GcMonQC.Size = New System.Drawing.Size(979, 294)
        Me.GcMonQC.TabIndex = 7
        Me.GcMonQC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMonQC})
        '
        'GvMonQC
        '
        Me.GvMonQC.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMonQC.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvMonQC.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvMonQC.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.Empty.Options.UseBackColor = True
        Me.GvMonQC.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMonQC.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMonQC.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvMonQC.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GvMonQC.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GvMonQC.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMonQC.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMonQC.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvMonQC.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMonQC.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMonQC.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvMonQC.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.GroupButton.Options.UseForeColor = True
        Me.GvMonQC.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMonQC.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMonQC.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvMonQC.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvMonQC.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvMonQC.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvMonQC.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvMonQC.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMonQC.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMonQC.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GvMonQC.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.GroupRow.Options.UseFont = True
        Me.GvMonQC.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMonQC.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMonQC.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvMonQC.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvMonQC.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMonQC.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvMonQC.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvMonQC.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.OddRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.OddRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvMonQC.Appearance.Preview.Options.UseBackColor = True
        Me.GvMonQC.Appearance.Preview.Options.UseForeColor = True
        Me.GvMonQC.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.Row.Options.UseBackColor = True
        Me.GvMonQC.Appearance.Row.Options.UseForeColor = True
        Me.GvMonQC.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvMonQC.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GvMonQC.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvMonQC.Appearance.VertLine.Options.UseBackColor = True
        Me.GvMonQC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.nama_jenis, Me.tgl_trans, Me.no_trans, Me.no_ref, Me.col_NoSJ, Me.kd_stok, Me.kd_satuan, Me.qty_order, Me.qty_qc_pass, Me.hold_history, Me.qty_qc_unpass, Me.qty_sisa, Me.Last_Created_By, Me.hold, Me.Supplier, Me.Keterangan})
        Me.GvMonQC.GridControl = Me.GcMonQC
        Me.GvMonQC.Name = "GvMonQC"
        Me.GvMonQC.OptionsBehavior.Editable = False
        Me.GvMonQC.OptionsBehavior.ReadOnly = True
        Me.GvMonQC.OptionsPrint.UsePrintStyles = True
        Me.GvMonQC.OptionsView.ColumnAutoWidth = False
        Me.GvMonQC.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMonQC.OptionsView.EnableAppearanceOddRow = True
        Me.GvMonQC.OptionsView.ShowFooter = True
        Me.GvMonQC.OptionsView.ShowViewCaption = True
        Me.GvMonQC.ViewCaption = "MONITORING INSPEKSI BARANG MASUK"
        '
        'nomer
        '
        Me.nomer.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nomer.AppearanceHeader.Options.UseFont = True
        Me.nomer.AppearanceHeader.Options.UseTextOptions = True
        Me.nomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Width = 21
        '
        'nama_jenis
        '
        Me.nama_jenis.AppearanceCell.Options.UseTextOptions = True
        Me.nama_jenis.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_jenis.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nama_jenis.AppearanceHeader.Options.UseFont = True
        Me.nama_jenis.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_jenis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_jenis.Caption = "Jenis QC"
        Me.nama_jenis.FieldName = "nama_jenis"
        Me.nama_jenis.Name = "nama_jenis"
        Me.nama_jenis.Visible = True
        Me.nama_jenis.VisibleIndex = 0
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_trans.AppearanceHeader.Options.UseFont = True
        Me.tgl_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans.Caption = "Tgl Trans"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 39
        '
        'no_trans
        '
        Me.no_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_trans.AppearanceHeader.Options.UseFont = True
        Me.no_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.no_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_trans.Caption = "Nomor QC"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 2
        Me.no_trans.Width = 47
        '
        'no_ref
        '
        Me.no_ref.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_ref.AppearanceHeader.Options.UseFont = True
        Me.no_ref.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref.Caption = "Referensi"
        Me.no_ref.FieldName = "no_ref"
        Me.no_ref.Name = "no_ref"
        Me.no_ref.Visible = True
        Me.no_ref.VisibleIndex = 3
        Me.no_ref.Width = 53
        '
        'col_NoSJ
        '
        Me.col_NoSJ.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_NoSJ.AppearanceHeader.Options.UseFont = True
        Me.col_NoSJ.AppearanceHeader.Options.UseTextOptions = True
        Me.col_NoSJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_NoSJ.Caption = "No. SJ"
        Me.col_NoSJ.FieldName = "no_sj"
        Me.col_NoSJ.Name = "col_NoSJ"
        Me.col_NoSJ.OptionsColumn.ReadOnly = True
        Me.col_NoSJ.Visible = True
        Me.col_NoSJ.VisibleIndex = 5
        Me.col_NoSJ.Width = 44
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_stok.AppearanceHeader.Options.UseFont = True
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.LookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 7
        Me.kd_stok.Width = 125
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = ""
        '
        'kd_satuan
        '
        Me.kd_satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_satuan.AppearanceHeader.Options.UseFont = True
        Me.kd_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.ReadOnly = True
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 9
        Me.kd_satuan.Width = 37
        '
        'qty_order
        '
        Me.qty_order.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.qty_order.AppearanceHeader.Options.UseFont = True
        Me.qty_order.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_order.Caption = "Order"
        Me.qty_order.DisplayFormat.FormatString = "N2"
        Me.qty_order.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.OptionsColumn.ReadOnly = True
        Me.qty_order.SummaryItem.DisplayFormat = "{0:n3}"
        Me.qty_order.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 10
        Me.qty_order.Width = 53
        '
        'qty_qc_pass
        '
        Me.qty_qc_pass.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.qty_qc_pass.AppearanceHeader.Options.UseFont = True
        Me.qty_qc_pass.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_qc_pass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_qc_pass.Caption = "Qty Good"
        Me.qty_qc_pass.DisplayFormat.FormatString = "N2"
        Me.qty_qc_pass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_qc_pass.FieldName = "qty_qc_pass"
        Me.qty_qc_pass.Name = "qty_qc_pass"
        Me.qty_qc_pass.SummaryItem.DisplayFormat = "{0:n3}"
        Me.qty_qc_pass.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_qc_pass.Visible = True
        Me.qty_qc_pass.VisibleIndex = 11
        Me.qty_qc_pass.Width = 65
        '
        'hold_history
        '
        Me.hold_history.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.hold_history.AppearanceHeader.Options.UseFont = True
        Me.hold_history.AppearanceHeader.Options.UseTextOptions = True
        Me.hold_history.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.hold_history.Caption = "Hold"
        Me.hold_history.DisplayFormat.FormatString = "N2"
        Me.hold_history.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.hold_history.FieldName = "hold_history"
        Me.hold_history.Name = "hold_history"
        Me.hold_history.SummaryItem.DisplayFormat = "{0:n3}"
        Me.hold_history.SummaryItem.FieldName = "hold"
        Me.hold_history.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.hold_history.Visible = True
        Me.hold_history.VisibleIndex = 12
        Me.hold_history.Width = 53
        '
        'qty_qc_unpass
        '
        Me.qty_qc_unpass.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.qty_qc_unpass.AppearanceHeader.Options.UseFont = True
        Me.qty_qc_unpass.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_qc_unpass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_qc_unpass.Caption = "Qty Tolak"
        Me.qty_qc_unpass.DisplayFormat.FormatString = "N2"
        Me.qty_qc_unpass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_qc_unpass.FieldName = "qty_qc_unpass"
        Me.qty_qc_unpass.Name = "qty_qc_unpass"
        Me.qty_qc_unpass.OptionsColumn.ReadOnly = True
        Me.qty_qc_unpass.SummaryItem.DisplayFormat = "{0:n3}"
        Me.qty_qc_unpass.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_qc_unpass.Visible = True
        Me.qty_qc_unpass.VisibleIndex = 14
        Me.qty_qc_unpass.Width = 55
        '
        'qty_sisa
        '
        Me.qty_sisa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.qty_sisa.AppearanceHeader.Options.UseFont = True
        Me.qty_sisa.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_sisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_sisa.Caption = "Qty Sisa"
        Me.qty_sisa.DisplayFormat.FormatString = "N2"
        Me.qty_sisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_sisa.FieldName = "qty_sisa"
        Me.qty_sisa.Name = "qty_sisa"
        Me.qty_sisa.SummaryItem.DisplayFormat = "{0:n3}"
        Me.qty_sisa.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_sisa.Visible = True
        Me.qty_sisa.VisibleIndex = 15
        Me.qty_sisa.Width = 71
        '
        'Last_Created_By
        '
        Me.Last_Created_By.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Last_Created_By.AppearanceHeader.Options.UseFont = True
        Me.Last_Created_By.AppearanceHeader.Options.UseTextOptions = True
        Me.Last_Created_By.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Last_Created_By.Caption = "Petugas QC"
        Me.Last_Created_By.FieldName = "Last_Created_By"
        Me.Last_Created_By.Name = "Last_Created_By"
        Me.Last_Created_By.Visible = True
        Me.Last_Created_By.VisibleIndex = 4
        Me.Last_Created_By.Width = 46
        '
        'hold
        '
        Me.hold.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.hold.AppearanceHeader.Options.UseFont = True
        Me.hold.Caption = "Masih Hold"
        Me.hold.FieldName = "hold"
        Me.hold.Name = "hold"
        Me.hold.SummaryItem.DisplayFormat = "{0:n3}"
        Me.hold.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.hold.Visible = True
        Me.hold.VisibleIndex = 13
        Me.hold.Width = 59
        '
        'Supplier
        '
        Me.Supplier.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Supplier.AppearanceHeader.Options.UseFont = True
        Me.Supplier.Caption = "Supplier"
        Me.Supplier.FieldName = "Nama_Supplier"
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Visible = True
        Me.Supplier.VisibleIndex = 6
        Me.Supplier.Width = 64
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 8
        Me.Keterangan.Width = 70
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnprin)
        Me.Panel3.Controls.Add(Me.cmdClear)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(979, 42)
        Me.Panel3.TabIndex = 5
        '
        'btnprin
        '
        Me.btnprin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnprin.ImageIndex = 10
        Me.btnprin.ImageList = Me.img
        Me.btnprin.Location = New System.Drawing.Point(618, 0)
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(75, 42)
        Me.btnprin.TabIndex = 38
        Me.btnprin.Text = "Cetak"
        Me.btnprin.Visible = False
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "error.ico")
        Me.img.Images.SetKeyName(1, "insert.ico")
        Me.img.Images.SetKeyName(2, "edit2.ico")
        Me.img.Images.SetKeyName(3, "ok.ico")
        Me.img.Images.SetKeyName(4, "save.ico")
        Me.img.Images.SetKeyName(5, "reload.ico")
        Me.img.Images.SetKeyName(6, "gohome.ico")
        Me.img.Images.SetKeyName(7, "remove.ico")
        Me.img.Images.SetKeyName(8, "clean.ico")
        Me.img.Images.SetKeyName(9, "forward.ico")
        Me.img.Images.SetKeyName(10, "printer.ico")
        Me.img.Images.SetKeyName(11, "chart.ico")
        Me.img.Images.SetKeyName(12, "sale.ico")
        Me.img.Images.SetKeyName(13, "users.ico")
        Me.img.Images.SetKeyName(14, "cut.ico")
        Me.img.Images.SetKeyName(15, "log_out.png")
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(569, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 37
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(520, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lookupBulanAwal)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.tglsampai)
        Me.Panel6.Controls.Add(Me.tglDari)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(211, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(309, 42)
        Me.Panel6.TabIndex = 32
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(524, 12)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(171, 20)
        Me.lookupBulanAwal.TabIndex = 57
        Me.lookupBulanAwal.Visible = False
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(169, 12)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(116, 20)
        Me.tglsampai.TabIndex = 25
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(6, 12)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(125, 20)
        Me.tglDari.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 42)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(979, 37)
        Me.Panel2.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(365, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITORING INSPEKSI BARANG MASUK"
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
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcMonQC
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(70, 50, 50, 50)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "MONITORING INSPEKSI BARANG MASUK", ""}, New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), Nothing)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmMonQC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 373)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonQC"
        Me.Text = "frmMonQC"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcMonQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMonQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GcMonQC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMonQC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_pass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_unpass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Created_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents hold_history As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_NoSJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_jenis As DevExpress.XtraGrid.Columns.GridColumn
End Class
