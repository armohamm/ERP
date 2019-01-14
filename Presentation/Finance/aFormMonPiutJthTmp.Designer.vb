<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormMonPiutJthTmp
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormMonPiutJthTmp))
        Me.gvNotaDetil = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tot_diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNota = New DevExpress.XtraGrid.GridControl
        Me.gvNota = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupCust = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.alamat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupAlamat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_jth_tempo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deTglJthTempo = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.pnlFilter = New System.Windows.Forms.Panel
        Me.pnlFull = New System.Windows.Forms.Panel
        Me.chkMax7 = New DevExpress.XtraEditors.CheckEdit
        Me.Panel38 = New System.Windows.Forms.Panel
        Me.chkMin7 = New DevExpress.XtraEditors.CheckEdit
        Me.Panel39 = New System.Windows.Forms.Panel
        Me.chkJt = New DevExpress.XtraEditors.CheckEdit
        Me.Panel40 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        Me.Panel41 = New System.Windows.Forms.Panel
        Me.pnlTglJthTmp = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.pnlJthTmpAkhir = New System.Windows.Forms.Panel
        Me.deTglJthTmpAkhir = New DevExpress.XtraEditors.DateEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.pnlJthTmpAwal = New System.Windows.Forms.Panel
        Me.deTglJthTmpAwal = New DevExpress.XtraEditors.DateEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.pnlTglNota = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.pnlCust = New System.Windows.Forms.Panel
        Me.lookupCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.pnlNotaAkhir = New System.Windows.Forms.Panel
        Me.deTglNotaAkhir = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.pnlNotaAwal = New System.Windows.Forms.Panel
        Me.deTglNotaAwal = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.Panel36 = New System.Windows.Forms.Panel
        Me.Panel37 = New System.Windows.Forms.Panel
        Me.Panel32 = New System.Windows.Forms.Panel
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Panel33 = New System.Windows.Forms.Panel
        Me.Label24 = New System.Windows.Forms.Label
        Me.Panel34 = New System.Windows.Forms.Panel
        Me.Panel35 = New System.Windows.Forms.Panel
        Me.Panel29 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel30 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Panel31 = New System.Windows.Forms.Panel
        Me.Panel26 = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel28 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Panel27 = New System.Windows.Forms.Panel
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gvNotaDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupAlamat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglJthTempo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglJthTempo.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.pnlFull.SuspendLayout()
        CType(Me.chkMax7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMin7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkJt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTglJthTmp.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.pnlJthTmpAkhir.SuspendLayout()
        CType(Me.deTglJthTmpAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglJthTmpAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel21.SuspendLayout()
        Me.pnlJthTmpAwal.SuspendLayout()
        CType(Me.deTglJthTmpAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglJthTmpAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTglNota.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.pnlCust.SuspendLayout()
        CType(Me.lookupCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlNotaAkhir.SuspendLayout()
        CType(Me.deTglNotaAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglNotaAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlNotaAwal.SuspendLayout()
        CType(Me.deTglNotaAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglNotaAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.Panel37.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.Panel35.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvNotaDetil
        '
        Me.gvNotaDetil.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNotaDetil.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.Empty.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gvNotaDetil.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNotaDetil.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.gvNotaDetil.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.gvNotaDetil.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gvNotaDetil.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gvNotaDetil.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNotaDetil.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvNotaDetil.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.GroupFooter.Options.UseFont = True
        Me.gvNotaDetil.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvNotaDetil.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.GroupRow.Options.UseFont = True
        Me.gvNotaDetil.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gvNotaDetil.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gvNotaDetil.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNotaDetil.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gvNotaDetil.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gvNotaDetil.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvNotaDetil.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvNotaDetil.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gvNotaDetil.Appearance.Preview.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.Preview.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.Row.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.Row.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.gvNotaDetil.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvNotaDetil.Appearance.VertLine.Options.UseBackColor = True
        Me.gvNotaDetil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_stok, Me.Qty, Me.satuan, Me.harga, Me.tot_diskon, Me.jml_rp_trans})
        Me.gvNotaDetil.GridControl = Me.gcNota
        Me.gvNotaDetil.Name = "gvNotaDetil"
        Me.gvNotaDetil.OptionsBehavior.Editable = False
        Me.gvNotaDetil.OptionsView.EnableAppearanceEvenRow = True
        Me.gvNotaDetil.OptionsView.ShowFooter = True
        Me.gvNotaDetil.PaintStyleName = "Office2003"
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Nama Barang"
        Me.kd_stok.ColumnEdit = Me.lookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 0
        Me.kd_stok.Width = 229
        '
        'lookupBarang
        '
        Me.lookupBarang.AutoHeight = False
        Me.lookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBarang.Name = "lookupBarang"
        Me.lookupBarang.NullText = "[Kosong]"
        '
        'Qty
        '
        Me.Qty.Caption = "Kuantitas"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 1
        Me.Qty.Width = 61
        '
        'satuan
        '
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 2
        Me.satuan.Width = 72
        '
        'harga
        '
        Me.harga.Caption = "Harga Satuan"
        Me.harga.DisplayFormat.FormatString = "n2"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 3
        Me.harga.Width = 150
        '
        'tot_diskon
        '
        Me.tot_diskon.Caption = "Potongan"
        Me.tot_diskon.DisplayFormat.FormatString = "n2"
        Me.tot_diskon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tot_diskon.FieldName = "tot_diskon"
        Me.tot_diskon.Name = "tot_diskon"
        Me.tot_diskon.Visible = True
        Me.tot_diskon.VisibleIndex = 4
        Me.tot_diskon.Width = 150
        '
        'jml_rp_trans
        '
        Me.jml_rp_trans.Caption = "Jumlah Total"
        Me.jml_rp_trans.DisplayFormat.FormatString = "n2"
        Me.jml_rp_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_rp_trans.FieldName = "jml_rp_trans"
        Me.jml_rp_trans.Name = "jml_rp_trans"
        Me.jml_rp_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_rp_trans.Visible = True
        Me.jml_rp_trans.VisibleIndex = 5
        Me.jml_rp_trans.Width = 158
        '
        'gcNota
        '
        Me.gcNota.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvNotaDetil
        GridLevelNode1.RelationName = "lvlDetil"
        Me.gcNota.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcNota.Location = New System.Drawing.Point(0, 0)
        Me.gcNota.MainView = Me.gvNota
        Me.gcNota.Name = "gcNota"
        Me.gcNota.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupCust, Me.lookupBarang, Me.lookupAlamat, Me.deTglJthTempo})
        Me.gcNota.Size = New System.Drawing.Size(841, 260)
        Me.gcNota.TabIndex = 0
        Me.gcNota.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNota, Me.gvNotaDetil})
        '
        'gvNota
        '
        Me.gvNota.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvNota.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNota.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvNota.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvNota.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvNota.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvNota.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvNota.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvNota.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNota.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvNota.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvNota.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvNota.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvNota.Appearance.Empty.Options.UseBackColor = True
        Me.gvNota.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvNota.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvNota.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvNota.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNota.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvNota.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvNota.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvNota.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvNota.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvNota.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvNota.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvNota.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvNota.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvNota.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvNota.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvNota.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvNota.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvNota.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvNota.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvNota.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvNota.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvNota.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNota.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvNota.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvNota.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvNota.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvNota.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvNota.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvNota.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvNota.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvNota.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvNota.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvNota.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvNota.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvNota.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvNota.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvNota.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvNota.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvNota.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvNota.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvNota.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvNota.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvNota.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvNota.Appearance.GroupRow.Options.UseFont = True
        Me.gvNota.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvNota.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvNota.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvNota.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvNota.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvNota.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvNota.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvNota.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvNota.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvNota.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvNota.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvNota.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvNota.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvNota.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvNota.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.OddRow.Options.UseBackColor = True
        Me.gvNota.Appearance.OddRow.Options.UseForeColor = True
        Me.gvNota.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvNota.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvNota.Appearance.Preview.Options.UseBackColor = True
        Me.gvNota.Appearance.Preview.Options.UseForeColor = True
        Me.gvNota.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvNota.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvNota.Appearance.Row.Options.UseBackColor = True
        Me.gvNota.Appearance.Row.Options.UseForeColor = True
        Me.gvNota.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvNota.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvNota.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvNota.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvNota.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvNota.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvNota.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvNota.Appearance.VertLine.Options.UseBackColor = True
        Me.gvNota.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_inv, Me.tgl_inv, Me.kd_cust, Me.alamat, Me.keterangan, Me.tgl_jth_tempo, Me.jml_tagihan})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Tomato
        StyleFormatCondition1.Appearance.Options.HighPriority = True
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "GetDate(Now()) >= [tgl_jth_tempo]"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Khaki
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Black
        StyleFormatCondition2.Appearance.Options.HighPriority = True
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "GetDate(Now()) < [tgl_jth_tempo] And GetDate(Now()) >= GetDate(AddDays([tgl_jth_t" & _
            "empo], -7))"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.PaleGreen
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Black
        StyleFormatCondition3.Appearance.Options.HighPriority = True
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "GetDate(Now()) < GetDate(AddDays([tgl_jth_tempo], -7))"
        Me.gvNota.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.gvNota.GridControl = Me.gcNota
        Me.gvNota.Name = "gvNota"
        Me.gvNota.OptionsBehavior.Editable = False
        Me.gvNota.OptionsView.EnableAppearanceEvenRow = True
        Me.gvNota.OptionsView.EnableAppearanceOddRow = True
        Me.gvNota.OptionsView.ShowFooter = True
        Me.gvNota.PaintStyleName = "Office2003"
        '
        'no_inv
        '
        Me.no_inv.Caption = "No. Nota"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 0
        '
        'tgl_inv
        '
        Me.tgl_inv.Caption = "Tanggal Nota"
        Me.tgl_inv.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_inv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 1
        '
        'kd_cust
        '
        Me.kd_cust.Caption = "Customer"
        Me.kd_cust.ColumnEdit = Me.lookupCust
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        Me.kd_cust.Visible = True
        Me.kd_cust.VisibleIndex = 2
        '
        'lookupCust
        '
        Me.lookupCust.AutoHeight = False
        Me.lookupCust.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupCust.Name = "lookupCust"
        Me.lookupCust.NullText = "[Kosong]"
        '
        'alamat
        '
        Me.alamat.Caption = "Alamat"
        Me.alamat.ColumnEdit = Me.lookupAlamat
        Me.alamat.FieldName = "kd_cust"
        Me.alamat.Name = "alamat"
        Me.alamat.Visible = True
        Me.alamat.VisibleIndex = 3
        '
        'lookupAlamat
        '
        Me.lookupAlamat.AutoHeight = False
        Me.lookupAlamat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupAlamat.Name = "lookupAlamat"
        Me.lookupAlamat.NullText = "[Kosong]"
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 4
        '
        'tgl_jth_tempo
        '
        Me.tgl_jth_tempo.Caption = "Tanggal Jatuh Tempo"
        Me.tgl_jth_tempo.ColumnEdit = Me.deTglJthTempo
        Me.tgl_jth_tempo.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_jth_tempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_jth_tempo.FieldName = "tgl_jth_tempo"
        Me.tgl_jth_tempo.Name = "tgl_jth_tempo"
        Me.tgl_jth_tempo.Visible = True
        Me.tgl_jth_tempo.VisibleIndex = 5
        '
        'deTglJthTempo
        '
        Me.deTglJthTempo.AutoHeight = False
        Me.deTglJthTempo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTglJthTempo.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.deTglJthTempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglJthTempo.EditFormat.FormatString = "dd MMMM yyyy"
        Me.deTglJthTempo.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglJthTempo.Mask.EditMask = "dd MMMM yyyy"
        Me.deTglJthTempo.Mask.UseMaskAsDisplayFormat = True
        Me.deTglJthTempo.Name = "deTglJthTempo"
        Me.deTglJthTempo.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'jml_tagihan
        '
        Me.jml_tagihan.Caption = "Jumlah Tagihan"
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 6
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.pnlGrid)
        Me.pnl.Controls.Add(Me.Panel14)
        Me.pnl.Controls.Add(Me.pnlFilter)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(841, 474)
        Me.pnl.TabIndex = 147
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.gcNota)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 164)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(841, 260)
        Me.pnlGrid.TabIndex = 173
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.Control
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 154)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(841, 10)
        Me.Panel14.TabIndex = 172
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.SystemColors.Control
        Me.pnlFilter.Controls.Add(Me.pnlFull)
        Me.pnlFilter.Controls.Add(Me.Panel41)
        Me.pnlFilter.Controls.Add(Me.pnlTglJthTmp)
        Me.pnlFilter.Controls.Add(Me.Panel19)
        Me.pnlFilter.Controls.Add(Me.pnlTglNota)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 34)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(841, 120)
        Me.pnlFilter.TabIndex = 171
        '
        'pnlFull
        '
        Me.pnlFull.Controls.Add(Me.chkMax7)
        Me.pnlFull.Controls.Add(Me.Panel38)
        Me.pnlFull.Controls.Add(Me.chkMin7)
        Me.pnlFull.Controls.Add(Me.Panel39)
        Me.pnlFull.Controls.Add(Me.chkJt)
        Me.pnlFull.Controls.Add(Me.Panel40)
        Me.pnlFull.Controls.Add(Me.Label25)
        Me.pnlFull.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFull.Location = New System.Drawing.Point(620, 0)
        Me.pnlFull.Name = "pnlFull"
        Me.pnlFull.Size = New System.Drawing.Size(160, 120)
        Me.pnlFull.TabIndex = 175
        '
        'chkMax7
        '
        Me.chkMax7.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkMax7.Location = New System.Drawing.Point(0, 85)
        Me.chkMax7.Name = "chkMax7"
        Me.chkMax7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkMax7.Properties.Appearance.Options.UseFont = True
        Me.chkMax7.Properties.AutoHeight = False
        Me.chkMax7.Properties.Caption = "Jatuh tempo > 7 hari"
        Me.chkMax7.Size = New System.Drawing.Size(160, 20)
        Me.chkMax7.TabIndex = 160
        '
        'Panel38
        '
        Me.Panel38.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel38.Location = New System.Drawing.Point(0, 80)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(160, 5)
        Me.Panel38.TabIndex = 159
        '
        'chkMin7
        '
        Me.chkMin7.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkMin7.Location = New System.Drawing.Point(0, 60)
        Me.chkMin7.Name = "chkMin7"
        Me.chkMin7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkMin7.Properties.Appearance.Options.UseFont = True
        Me.chkMin7.Properties.AutoHeight = False
        Me.chkMin7.Properties.Caption = "Jatuh tempo <= 7 hari"
        Me.chkMin7.Size = New System.Drawing.Size(160, 20)
        Me.chkMin7.TabIndex = 158
        '
        'Panel39
        '
        Me.Panel39.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel39.Location = New System.Drawing.Point(0, 55)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(160, 5)
        Me.Panel39.TabIndex = 157
        '
        'chkJt
        '
        Me.chkJt.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkJt.Location = New System.Drawing.Point(0, 35)
        Me.chkJt.Name = "chkJt"
        Me.chkJt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkJt.Properties.Appearance.Options.UseFont = True
        Me.chkJt.Properties.AutoHeight = False
        Me.chkJt.Properties.Caption = "Nota jatuh tempo"
        Me.chkJt.Size = New System.Drawing.Size(160, 20)
        Me.chkJt.TabIndex = 156
        '
        'Panel40
        '
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel40.Location = New System.Drawing.Point(0, 30)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(160, 5)
        Me.Panel40.TabIndex = 155
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Maroon
        Me.Label25.Location = New System.Drawing.Point(0, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(160, 30)
        Me.Label25.TabIndex = 154
        Me.Label25.Text = "Filter View"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel41
        '
        Me.Panel41.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel41.Location = New System.Drawing.Point(610, 0)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(10, 120)
        Me.Panel41.TabIndex = 174
        '
        'pnlTglJthTmp
        '
        Me.pnlTglJthTmp.Controls.Add(Me.Panel13)
        Me.pnlTglJthTmp.Controls.Add(Me.Panel12)
        Me.pnlTglJthTmp.Controls.Add(Me.Panel10)
        Me.pnlTglJthTmp.Controls.Add(Me.Panel15)
        Me.pnlTglJthTmp.Controls.Add(Me.Panel16)
        Me.pnlTglJthTmp.Controls.Add(Me.Label15)
        Me.pnlTglJthTmp.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTglJthTmp.Location = New System.Drawing.Point(310, 0)
        Me.pnlTglJthTmp.Name = "pnlTglJthTmp"
        Me.pnlTglJthTmp.Size = New System.Drawing.Size(300, 120)
        Me.pnlTglJthTmp.TabIndex = 173
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 117)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(300, 2)
        Me.Panel13.TabIndex = 171
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.btnRefresh)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 92)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(300, 25)
        Me.Panel12.TabIndex = 170
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Location = New System.Drawing.Point(200, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 25)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh Data"
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 90)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(300, 2)
        Me.Panel10.TabIndex = 168
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 85)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(300, 5)
        Me.Panel15.TabIndex = 167
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Panel18)
        Me.Panel16.Controls.Add(Me.Panel20)
        Me.Panel16.Controls.Add(Me.Panel21)
        Me.Panel16.Controls.Add(Me.Panel23)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 30)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(300, 55)
        Me.Panel16.TabIndex = 150
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 50)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(300, 5)
        Me.Panel17.TabIndex = 166
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.pnlJthTmpAkhir)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 30)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(300, 20)
        Me.Panel18.TabIndex = 165
        '
        'pnlJthTmpAkhir
        '
        Me.pnlJthTmpAkhir.Controls.Add(Me.deTglJthTmpAkhir)
        Me.pnlJthTmpAkhir.Controls.Add(Me.Label11)
        Me.pnlJthTmpAkhir.Controls.Add(Me.Label12)
        Me.pnlJthTmpAkhir.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlJthTmpAkhir.Location = New System.Drawing.Point(0, 0)
        Me.pnlJthTmpAkhir.Name = "pnlJthTmpAkhir"
        Me.pnlJthTmpAkhir.Size = New System.Drawing.Size(250, 20)
        Me.pnlJthTmpAkhir.TabIndex = 159
        '
        'deTglJthTmpAkhir
        '
        Me.deTglJthTmpAkhir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deTglJthTmpAkhir.EditValue = Nothing
        Me.deTglJthTmpAkhir.EnterMoveNextControl = True
        Me.deTglJthTmpAkhir.Location = New System.Drawing.Point(110, 0)
        Me.deTglJthTmpAkhir.Name = "deTglJthTmpAkhir"
        Me.deTglJthTmpAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglJthTmpAkhir.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.deTglJthTmpAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglJthTmpAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglJthTmpAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglJthTmpAkhir.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.deTglJthTmpAkhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglJthTmpAkhir.Size = New System.Drawing.Size(140, 20)
        Me.deTglJthTmpAkhir.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(100, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = ":"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Tanggal Akhir"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel20
        '
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(0, 25)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(300, 5)
        Me.Panel20.TabIndex = 164
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.pnlJthTmpAwal)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(0, 5)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(300, 20)
        Me.Panel21.TabIndex = 163
        '
        'pnlJthTmpAwal
        '
        Me.pnlJthTmpAwal.Controls.Add(Me.deTglJthTmpAwal)
        Me.pnlJthTmpAwal.Controls.Add(Me.Label13)
        Me.pnlJthTmpAwal.Controls.Add(Me.Label14)
        Me.pnlJthTmpAwal.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlJthTmpAwal.Location = New System.Drawing.Point(0, 0)
        Me.pnlJthTmpAwal.Name = "pnlJthTmpAwal"
        Me.pnlJthTmpAwal.Size = New System.Drawing.Size(250, 20)
        Me.pnlJthTmpAwal.TabIndex = 150
        '
        'deTglJthTmpAwal
        '
        Me.deTglJthTmpAwal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deTglJthTmpAwal.EditValue = Nothing
        Me.deTglJthTmpAwal.EnterMoveNextControl = True
        Me.deTglJthTmpAwal.Location = New System.Drawing.Point(110, 0)
        Me.deTglJthTmpAwal.Name = "deTglJthTmpAwal"
        Me.deTglJthTmpAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglJthTmpAwal.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.deTglJthTmpAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglJthTmpAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglJthTmpAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglJthTmpAwal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.deTglJthTmpAwal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglJthTmpAwal.Size = New System.Drawing.Size(140, 20)
        Me.deTglJthTmpAwal.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(100, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 20)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = ":"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Tanggal Awal"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel23
        '
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(0, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(300, 5)
        Me.Panel23.TabIndex = 162
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(300, 30)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Tanggal Jatuh Tempo"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel19.Location = New System.Drawing.Point(300, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(10, 120)
        Me.Panel19.TabIndex = 172
        '
        'pnlTglNota
        '
        Me.pnlTglNota.Controls.Add(Me.Panel11)
        Me.pnlTglNota.Controls.Add(Me.Panel9)
        Me.pnlTglNota.Controls.Add(Me.Panel2)
        Me.pnlTglNota.Controls.Add(Me.Label2)
        Me.pnlTglNota.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTglNota.Location = New System.Drawing.Point(0, 0)
        Me.pnlTglNota.Name = "pnlTglNota"
        Me.pnlTglNota.Size = New System.Drawing.Size(300, 120)
        Me.pnlTglNota.TabIndex = 149
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.pnlCust)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 90)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(300, 20)
        Me.Panel11.TabIndex = 168
        '
        'pnlCust
        '
        Me.pnlCust.Controls.Add(Me.lookupCustomer)
        Me.pnlCust.Controls.Add(Me.Label7)
        Me.pnlCust.Controls.Add(Me.Label8)
        Me.pnlCust.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCust.Location = New System.Drawing.Point(0, 0)
        Me.pnlCust.Name = "pnlCust"
        Me.pnlCust.Size = New System.Drawing.Size(250, 20)
        Me.pnlCust.TabIndex = 152
        '
        'lookupCustomer
        '
        Me.lookupCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lookupCustomer.EnterMoveNextControl = True
        Me.lookupCustomer.Location = New System.Drawing.Point(110, 0)
        Me.lookupCustomer.Name = "lookupCustomer"
        Me.lookupCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Nama")})
        Me.lookupCustomer.Properties.NullText = "[Kosong]"
        Me.lookupCustomer.Size = New System.Drawing.Size(140, 20)
        Me.lookupCustomer.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(100, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = ":"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Customer"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 85)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(300, 5)
        Me.Panel9.TabIndex = 167
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 55)
        Me.Panel2.TabIndex = 150
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 50)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(300, 5)
        Me.Panel7.TabIndex = 166
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.pnlNotaAkhir)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 20)
        Me.Panel6.TabIndex = 165
        '
        'pnlNotaAkhir
        '
        Me.pnlNotaAkhir.Controls.Add(Me.deTglNotaAkhir)
        Me.pnlNotaAkhir.Controls.Add(Me.Label5)
        Me.pnlNotaAkhir.Controls.Add(Me.Label6)
        Me.pnlNotaAkhir.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNotaAkhir.Location = New System.Drawing.Point(0, 0)
        Me.pnlNotaAkhir.Name = "pnlNotaAkhir"
        Me.pnlNotaAkhir.Size = New System.Drawing.Size(250, 20)
        Me.pnlNotaAkhir.TabIndex = 159
        '
        'deTglNotaAkhir
        '
        Me.deTglNotaAkhir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deTglNotaAkhir.EditValue = Nothing
        Me.deTglNotaAkhir.EnterMoveNextControl = True
        Me.deTglNotaAkhir.Location = New System.Drawing.Point(110, 0)
        Me.deTglNotaAkhir.Name = "deTglNotaAkhir"
        Me.deTglNotaAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglNotaAkhir.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.deTglNotaAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglNotaAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglNotaAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglNotaAkhir.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.deTglNotaAkhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglNotaAkhir.Size = New System.Drawing.Size(140, 20)
        Me.deTglNotaAkhir.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(100, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tanggal Akhir"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 5)
        Me.Panel3.TabIndex = 164
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.pnlNotaAwal)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 20)
        Me.Panel4.TabIndex = 163
        '
        'pnlNotaAwal
        '
        Me.pnlNotaAwal.Controls.Add(Me.deTglNotaAwal)
        Me.pnlNotaAwal.Controls.Add(Me.Label3)
        Me.pnlNotaAwal.Controls.Add(Me.Label1)
        Me.pnlNotaAwal.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNotaAwal.Location = New System.Drawing.Point(0, 0)
        Me.pnlNotaAwal.Name = "pnlNotaAwal"
        Me.pnlNotaAwal.Size = New System.Drawing.Size(250, 20)
        Me.pnlNotaAwal.TabIndex = 150
        '
        'deTglNotaAwal
        '
        Me.deTglNotaAwal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deTglNotaAwal.EditValue = Nothing
        Me.deTglNotaAwal.EnterMoveNextControl = True
        Me.deTglNotaAwal.Location = New System.Drawing.Point(110, 0)
        Me.deTglNotaAwal.Name = "deTglNotaAwal"
        Me.deTglNotaAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglNotaAwal.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.deTglNotaAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglNotaAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglNotaAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.deTglNotaAwal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.deTglNotaAwal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deTglNotaAwal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglNotaAwal.Size = New System.Drawing.Size(140, 20)
        Me.deTglNotaAwal.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(100, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ":"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tanggal Awal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(300, 5)
        Me.Panel8.TabIndex = 162
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal Nota"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel22)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 424)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 50)
        Me.Panel1.TabIndex = 147
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.Panel36)
        Me.Panel22.Controls.Add(Me.Panel25)
        Me.Panel22.Location = New System.Drawing.Point(8, 4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(504, 40)
        Me.Panel22.TabIndex = 148
        '
        'Panel36
        '
        Me.Panel36.Controls.Add(Me.Panel37)
        Me.Panel36.Controls.Add(Me.Panel35)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel36.Location = New System.Drawing.Point(100, 0)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(404, 40)
        Me.Panel36.TabIndex = 154
        '
        'Panel37
        '
        Me.Panel37.Controls.Add(Me.Panel32)
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel37.Location = New System.Drawing.Point(0, 20)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(404, 20)
        Me.Panel37.TabIndex = 155
        '
        'Panel32
        '
        Me.Panel32.Controls.Add(Me.Label23)
        Me.Panel32.Controls.Add(Me.Label22)
        Me.Panel32.Controls.Add(Me.Panel33)
        Me.Panel32.Controls.Add(Me.Label24)
        Me.Panel32.Controls.Add(Me.Panel34)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(200, 20)
        Me.Panel32.TabIndex = 152
        '
        'Label23
        '
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(40, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(160, 20)
        Me.Label23.TabIndex = 156
        Me.Label23.Text = "Jatuh Tempo <=7 hari"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(30, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 20)
        Me.Label22.TabIndex = 155
        Me.Label22.Text = ":"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel33
        '
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel33.Location = New System.Drawing.Point(25, 0)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(5, 20)
        Me.Panel33.TabIndex = 153
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Khaki
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(5, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 20)
        Me.Label24.TabIndex = 152
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel34
        '
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel34.Location = New System.Drawing.Point(0, 0)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(5, 20)
        Me.Panel34.TabIndex = 151
        '
        'Panel35
        '
        Me.Panel35.Controls.Add(Me.Panel29)
        Me.Panel35.Controls.Add(Me.Panel26)
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel35.Location = New System.Drawing.Point(0, 0)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(404, 20)
        Me.Panel35.TabIndex = 153
        '
        'Panel29
        '
        Me.Panel29.Controls.Add(Me.Label20)
        Me.Panel29.Controls.Add(Me.Label19)
        Me.Panel29.Controls.Add(Me.Panel30)
        Me.Panel29.Controls.Add(Me.Label21)
        Me.Panel29.Controls.Add(Me.Panel31)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel29.Location = New System.Drawing.Point(200, 0)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(200, 20)
        Me.Panel29.TabIndex = 151
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(40, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(160, 20)
        Me.Label20.TabIndex = 157
        Me.Label20.Text = "Jatuh Tempo >7 hari"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(30, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 20)
        Me.Label19.TabIndex = 156
        Me.Label19.Text = ":"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel30
        '
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel30.Location = New System.Drawing.Point(25, 0)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(5, 20)
        Me.Panel30.TabIndex = 153
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.PaleGreen
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(20, 20)
        Me.Label21.TabIndex = 152
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel31
        '
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel31.Location = New System.Drawing.Point(0, 0)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(5, 20)
        Me.Panel31.TabIndex = 151
        '
        'Panel26
        '
        Me.Panel26.Controls.Add(Me.Label18)
        Me.Panel26.Controls.Add(Me.Label17)
        Me.Panel26.Controls.Add(Me.Panel28)
        Me.Panel26.Controls.Add(Me.Label16)
        Me.Panel26.Controls.Add(Me.Panel27)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(200, 20)
        Me.Panel26.TabIndex = 150
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(40, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(160, 20)
        Me.Label18.TabIndex = 155
        Me.Label18.Text = "Nota Telah Jatuh Tempo"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(30, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 20)
        Me.Label17.TabIndex = 154
        Me.Label17.Text = ":"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel28
        '
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel28.Location = New System.Drawing.Point(25, 0)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(5, 20)
        Me.Panel28.TabIndex = 153
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Tomato
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 20)
        Me.Label16.TabIndex = 152
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(5, 20)
        Me.Panel27.TabIndex = 151
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.Panel24)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(100, 40)
        Me.Panel25.TabIndex = 151
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.Label10)
        Me.Panel24.Controls.Add(Me.Label9)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(100, 20)
        Me.Panel24.TabIndex = 150
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(90, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 20)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = ":"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Keterangan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(841, 34)
        Me.Panel5.TabIndex = 146
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "        MONITORING PIUTANG JATUH TEMPO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gcNota
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(5, 5, 5, 5)
        Me.PrintableComponentLink1.MinMargins = New System.Drawing.Printing.Margins(5, 5, 5, 5)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'aFormMonPiutJthTmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 474)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormMonPiutJthTmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Monitoring Piutang Jatuh Tempo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gvNotaDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupAlamat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglJthTempo.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglJthTempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFull.ResumeLayout(False)
        CType(Me.chkMax7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMin7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkJt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTglJthTmp.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.pnlJthTmpAkhir.ResumeLayout(False)
        CType(Me.deTglJthTmpAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglJthTmpAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel21.ResumeLayout(False)
        Me.pnlJthTmpAwal.ResumeLayout(False)
        CType(Me.deTglJthTmpAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglJthTmpAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTglNota.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.pnlCust.ResumeLayout(False)
        CType(Me.lookupCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.pnlNotaAkhir.ResumeLayout(False)
        CType(Me.deTglNotaAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglNotaAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.pnlNotaAwal.ResumeLayout(False)
        CType(Me.deTglNotaAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglNotaAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel36.ResumeLayout(False)
        Me.Panel37.ResumeLayout(False)
        Me.Panel32.ResumeLayout(False)
        Me.Panel35.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents pnlTglJthTmp As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents pnlJthTmpAkhir As System.Windows.Forms.Panel
    Friend WithEvents deTglJthTmpAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents pnlJthTmpAwal As System.Windows.Forms.Panel
    Friend WithEvents deTglJthTmpAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents pnlTglNota As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents pnlCust As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pnlNotaAkhir As System.Windows.Forms.Panel
    Friend WithEvents deTglNotaAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlNotaAwal As System.Windows.Forms.Panel
    Friend WithEvents deTglNotaAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents gcNota As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNotaDetil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tot_diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvNota As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupCust As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents alamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_jth_tempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupAlamat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookupCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents deTglJthTempo As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel36 As System.Windows.Forms.Panel
    Friend WithEvents Panel37 As System.Windows.Forms.Panel
    Friend WithEvents Panel32 As System.Windows.Forms.Panel
    Friend WithEvents Panel33 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel34 As System.Windows.Forms.Panel
    Friend WithEvents Panel35 As System.Windows.Forms.Panel
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Panel30 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel31 As System.Windows.Forms.Panel
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents pnlFull As System.Windows.Forms.Panel
    Friend WithEvents chkMax7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel38 As System.Windows.Forms.Panel
    Friend WithEvents chkMin7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel39 As System.Windows.Forms.Panel
    Friend WithEvents chkJt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel40 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel41 As System.Windows.Forms.Panel
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
