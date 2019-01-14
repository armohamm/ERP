<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormMonGiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormMonGiro))
        Me.gvGiroTrans = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tgl_trans1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deTgl = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.kd_bank1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupBank = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_trans1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcGiro = New DevExpress.XtraGrid.GridControl
        Me.gvGiro = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.divisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupDivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_jth_tempo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupValuta = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_bank = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jns_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.btnToday = New DevExpress.XtraEditors.SimpleButton
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.pnlFull = New System.Windows.Forms.Panel
        Me.chkMax7 = New DevExpress.XtraEditors.CheckEdit
        Me.Panel38 = New System.Windows.Forms.Panel
        Me.chkMin7 = New DevExpress.XtraEditors.CheckEdit
        Me.Panel39 = New System.Windows.Forms.Panel
        Me.chkJt = New DevExpress.XtraEditors.CheckEdit
        Me.Panel40 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.pnlJns = New System.Windows.Forms.Panel
        Me.cmbJenis = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.pnlTglAkhir = New System.Windows.Forms.Panel
        Me.deTglAkhir = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.pnlTglAwal = New System.Windows.Forms.Panel
        Me.deTglAwal = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
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
        CType(Me.gvGiroTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTgl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcGiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvGiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupValuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.pnlFull.SuspendLayout()
        CType(Me.chkMax7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMin7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkJt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.pnlJns.SuspendLayout()
        CType(Me.cmbJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlTglAkhir.SuspendLayout()
        CType(Me.deTglAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlTglAwal.SuspendLayout()
        CType(Me.deTglAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'gvGiroTrans
        '
        Me.gvGiroTrans.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.BurlyWood
        Me.gvGiroTrans.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.gvGiroTrans.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.BurlyWood
        Me.gvGiroTrans.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.gvGiroTrans.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvGiroTrans.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.gvGiroTrans.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.gvGiroTrans.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.gvGiroTrans.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.gvGiroTrans.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvGiroTrans.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiroTrans.Appearance.Empty.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvGiroTrans.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.gvGiroTrans.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvGiroTrans.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvGiroTrans.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gvGiroTrans.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvGiroTrans.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.FilterPanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.gvGiroTrans.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvGiroTrans.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvGiroTrans.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gvGiroTrans.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.gvGiroTrans.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy
        Me.gvGiroTrans.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvGiroTrans.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvGiroTrans.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.FooterPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.gvGiroTrans.Appearance.FooterPanel.BorderColor = System.Drawing.Color.BurlyWood
        Me.gvGiroTrans.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvGiroTrans.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvGiroTrans.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvGiroTrans.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvGiroTrans.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvGiroTrans.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvGiroTrans.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.gvGiroTrans.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.gvGiroTrans.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvGiroTrans.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvGiroTrans.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.GroupPanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.gvGiroTrans.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvGiroTrans.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvGiroTrans.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.gvGiroTrans.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.GroupPanel.Options.UseFont = True
        Me.gvGiroTrans.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.GroupRow.BackColor = System.Drawing.Color.PeachPuff
        Me.gvGiroTrans.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvGiroTrans.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.HeaderPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.gvGiroTrans.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.BurlyWood
        Me.gvGiroTrans.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvGiroTrans.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvGiroTrans.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvGiroTrans.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvGiroTrans.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.gvGiroTrans.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvGiroTrans.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.gvGiroTrans.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.Preview.BackColor = System.Drawing.Color.White
        Me.gvGiroTrans.Appearance.Preview.ForeColor = System.Drawing.Color.SaddleBrown
        Me.gvGiroTrans.Appearance.Preview.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.Preview.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.Row.BackColor = System.Drawing.Color.OldLace
        Me.gvGiroTrans.Appearance.Row.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gvGiroTrans.Appearance.Row.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.Row.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvGiroTrans.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiroTrans.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gvGiroTrans.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvGiroTrans.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gvGiroTrans.Appearance.TopNewRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.gvGiroTrans.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvGiroTrans.Appearance.TopNewRow.Options.UseForeColor = True
        Me.gvGiroTrans.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.gvGiroTrans.Appearance.VertLine.Options.UseBackColor = True
        Me.gvGiroTrans.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tgl_trans1, Me.kd_bank1, Me.jml_trans1, Me.status1})
        Me.gvGiroTrans.GridControl = Me.gcGiro
        Me.gvGiroTrans.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.gvGiroTrans.Name = "gvGiroTrans"
        Me.gvGiroTrans.OptionsBehavior.Editable = False
        Me.gvGiroTrans.OptionsView.ShowFooter = True
        Me.gvGiroTrans.PaintStyleName = "Office2003"
        '
        'tgl_trans1
        '
        Me.tgl_trans1.Caption = "Tanggal Transaksi"
        Me.tgl_trans1.ColumnEdit = Me.deTgl
        Me.tgl_trans1.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_trans1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans1.FieldName = "tgl_trans"
        Me.tgl_trans1.Name = "tgl_trans1"
        Me.tgl_trans1.Visible = True
        Me.tgl_trans1.VisibleIndex = 0
        '
        'deTgl
        '
        Me.deTgl.AutoHeight = False
        Me.deTgl.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTgl.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.deTgl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTgl.EditFormat.FormatString = "dd MMMM yyyy"
        Me.deTgl.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTgl.Mask.EditMask = "d MMMM yyyy"
        Me.deTgl.Mask.UseMaskAsDisplayFormat = True
        Me.deTgl.Name = "deTgl"
        Me.deTgl.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'kd_bank1
        '
        Me.kd_bank1.Caption = "Bank"
        Me.kd_bank1.ColumnEdit = Me.lookupBank
        Me.kd_bank1.FieldName = "kd_bank"
        Me.kd_bank1.Name = "kd_bank1"
        Me.kd_bank1.Visible = True
        Me.kd_bank1.VisibleIndex = 1
        '
        'lookupBank
        '
        Me.lookupBank.AutoHeight = False
        Me.lookupBank.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBank.Name = "lookupBank"
        Me.lookupBank.NullText = "[Kosong]"
        '
        'jml_trans1
        '
        Me.jml_trans1.Caption = "Jumlah"
        Me.jml_trans1.DisplayFormat.FormatString = "n2"
        Me.jml_trans1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans1.FieldName = "jml_trans"
        Me.jml_trans1.Name = "jml_trans1"
        Me.jml_trans1.Visible = True
        Me.jml_trans1.VisibleIndex = 2
        '
        'status1
        '
        Me.status1.Caption = "Status"
        Me.status1.FieldName = "status"
        Me.status1.Name = "status1"
        Me.status1.Visible = True
        Me.status1.VisibleIndex = 3
        '
        'gcGiro
        '
        Me.gcGiro.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvGiroTrans
        GridLevelNode1.RelationName = "lvlDetil"
        Me.gcGiro.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcGiro.Location = New System.Drawing.Point(0, 138)
        Me.gcGiro.MainView = Me.gvGiro
        Me.gcGiro.Name = "gcGiro"
        Me.gcGiro.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupKartu, Me.lookupBank, Me.lookupValuta, Me.deTgl, Me.lookupDivisi})
        Me.gcGiro.Size = New System.Drawing.Size(932, 263)
        Me.gcGiro.TabIndex = 150
        Me.gcGiro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvGiro, Me.gvGiroTrans})
        '
        'gvGiro
        '
        Me.gvGiro.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.gvGiro.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvGiro.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvGiro.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvGiro.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvGiro.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White
        Me.gvGiro.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvGiro.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White
        Me.gvGiro.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvGiro.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvGiro.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvGiro.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvGiro.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvGiro.Appearance.Empty.Options.UseBackColor = True
        Me.gvGiro.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvGiro.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvGiro.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.gvGiro.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvGiro.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvGiro.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvGiro.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.gvGiro.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvGiro.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvGiro.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvGiro.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.gvGiro.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvGiro.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.gvGiro.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvGiro.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvGiro.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.gvGiro.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvGiro.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvGiro.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvGiro.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvGiro.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvGiro.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvGiro.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvGiro.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvGiro.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvGiro.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvGiro.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvGiro.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvGiro.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvGiro.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.gvGiro.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvGiro.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvGiro.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvGiro.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gvGiro.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvGiro.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvGiro.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvGiro.Appearance.GroupRow.Options.UseFont = True
        Me.gvGiro.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvGiro.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.gvGiro.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.gvGiro.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvGiro.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvGiro.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvGiro.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvGiro.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gvGiro.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.gvGiro.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvGiro.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvGiro.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvGiro.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvGiro.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvGiro.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.OddRow.Options.UseBackColor = True
        Me.gvGiro.Appearance.OddRow.Options.UseForeColor = True
        Me.gvGiro.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.gvGiro.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.gvGiro.Appearance.Preview.Options.UseBackColor = True
        Me.gvGiro.Appearance.Preview.Options.UseForeColor = True
        Me.gvGiro.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvGiro.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.Row.Options.UseBackColor = True
        Me.gvGiro.Appearance.Row.Options.UseForeColor = True
        Me.gvGiro.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvGiro.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvGiro.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.gvGiro.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gvGiro.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvGiro.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvGiro.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gvGiro.Appearance.VertLine.Options.UseBackColor = True
        Me.gvGiro.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomor, Me.divisi, Me.tgl_trans, Me.tgl_jth_tempo, Me.kartu, Me.kd_valuta, Me.kd_bank, Me.jml_trans, Me.status, Me.jns_trans})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Tomato
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "GetDate(Now()) >= [tgl_jth_tempo] "
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Khaki
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "GetDate(Now()) < [tgl_jth_tempo] And GetDate(Now()) >= GetDate(AddDays([tgl_jth_t" & _
            "empo], -7))"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.PaleGreen
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "GetDate(Now()) < GetDate(AddDays([tgl_jth_tempo], -7))"
        Me.gvGiro.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.gvGiro.GridControl = Me.gcGiro
        Me.gvGiro.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.gvGiro.Name = "gvGiro"
        Me.gvGiro.OptionsBehavior.Editable = False
        Me.gvGiro.OptionsView.EnableAppearanceEvenRow = True
        Me.gvGiro.OptionsView.EnableAppearanceOddRow = True
        Me.gvGiro.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvGiro.OptionsView.ShowFooter = True
        Me.gvGiro.PaintStyleName = "WindowsXP"
        '
        'nomor
        '
        Me.nomor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nomor.AppearanceHeader.Options.UseFont = True
        Me.nomor.AppearanceHeader.Options.UseTextOptions = True
        Me.nomor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nomor.Caption = "No. Giro"
        Me.nomor.FieldName = "nomor"
        Me.nomor.Name = "nomor"
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 0
        Me.nomor.Width = 101
        '
        'divisi
        '
        Me.divisi.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.divisi.AppearanceHeader.Options.UseFont = True
        Me.divisi.AppearanceHeader.Options.UseTextOptions = True
        Me.divisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.divisi.Caption = "Divisi"
        Me.divisi.ColumnEdit = Me.lookupDivisi
        Me.divisi.FieldName = "divisi"
        Me.divisi.Name = "divisi"
        Me.divisi.Width = 101
        '
        'lookupDivisi
        '
        Me.lookupDivisi.AutoHeight = False
        Me.lookupDivisi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupDivisi.Name = "lookupDivisi"
        Me.lookupDivisi.NullText = "[Kosong]"
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_trans.AppearanceHeader.Options.UseFont = True
        Me.tgl_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans.Caption = "Tanggal Giro"
        Me.tgl_trans.ColumnEdit = Me.deTgl
        Me.tgl_trans.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 101
        '
        'tgl_jth_tempo
        '
        Me.tgl_jth_tempo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseFont = True
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_jth_tempo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_jth_tempo.Caption = "Tgl Jth Tempo"
        Me.tgl_jth_tempo.ColumnEdit = Me.deTgl
        Me.tgl_jth_tempo.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_jth_tempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_jth_tempo.FieldName = "tgl_jth_tempo"
        Me.tgl_jth_tempo.Name = "tgl_jth_tempo"
        Me.tgl_jth_tempo.Visible = True
        Me.tgl_jth_tempo.VisibleIndex = 2
        Me.tgl_jth_tempo.Width = 101
        '
        'kartu
        '
        Me.kartu.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kartu.AppearanceHeader.Options.UseFont = True
        Me.kartu.AppearanceHeader.Options.UseTextOptions = True
        Me.kartu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kartu.Caption = "Nama"
        Me.kartu.ColumnEdit = Me.lookupKartu
        Me.kartu.FieldName = "kartu"
        Me.kartu.Name = "kartu"
        Me.kartu.Visible = True
        Me.kartu.VisibleIndex = 3
        Me.kartu.Width = 102
        '
        'lookupKartu
        '
        Me.lookupKartu.AutoHeight = False
        Me.lookupKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupKartu.Name = "lookupKartu"
        Me.lookupKartu.NullText = "[Kosong]"
        '
        'kd_valuta
        '
        Me.kd_valuta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_valuta.AppearanceHeader.Options.UseFont = True
        Me.kd_valuta.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_valuta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.ColumnEdit = Me.lookupValuta
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 4
        Me.kd_valuta.Width = 71
        '
        'lookupValuta
        '
        Me.lookupValuta.AutoHeight = False
        Me.lookupValuta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupValuta.Name = "lookupValuta"
        Me.lookupValuta.NullText = "[Kosong]"
        '
        'kd_bank
        '
        Me.kd_bank.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_bank.AppearanceHeader.Options.UseFont = True
        Me.kd_bank.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_bank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_bank.Caption = "Bank"
        Me.kd_bank.ColumnEdit = Me.lookupBank
        Me.kd_bank.FieldName = "kd_bank"
        Me.kd_bank.Name = "kd_bank"
        Me.kd_bank.Visible = True
        Me.kd_bank.VisibleIndex = 5
        Me.kd_bank.Width = 101
        '
        'jml_trans
        '
        Me.jml_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_trans.Caption = "Jumlah"
        Me.jml_trans.DisplayFormat.FormatString = "n2"
        Me.jml_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_trans.Visible = True
        Me.jml_trans.VisibleIndex = 6
        Me.jml_trans.Width = 101
        '
        'status
        '
        Me.status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.status.AppearanceHeader.Options.UseFont = True
        Me.status.AppearanceHeader.Options.UseTextOptions = True
        Me.status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.status.Caption = "Status"
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 7
        Me.status.Width = 136
        '
        'jns_trans
        '
        Me.jns_trans.Caption = "GridColumn1"
        Me.jns_trans.FieldName = "jns_trans"
        Me.jns_trans.Name = "jns_trans"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gcGiro)
        Me.pnl.Controls.Add(Me.Panel14)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(932, 451)
        Me.pnl.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.btnToday)
        Me.Panel14.Controls.Add(Me.btnRefresh)
        Me.Panel14.Controls.Add(Me.pnlFull)
        Me.Panel14.Controls.Add(Me.Panel19)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 34)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(932, 104)
        Me.Panel14.TabIndex = 149
        '
        'btnToday
        '
        Me.btnToday.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnToday.Appearance.Options.UseFont = True
        Me.btnToday.Location = New System.Drawing.Point(741, 30)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(125, 50)
        Me.btnToday.TabIndex = 177
        Me.btnToday.Text = "Transaksi Hari Ini"
        Me.btnToday.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(585, 25)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 50)
        Me.btnRefresh.TabIndex = 4
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
        Me.pnlFull.Location = New System.Drawing.Point(351, 0)
        Me.pnlFull.Name = "pnlFull"
        Me.pnlFull.Size = New System.Drawing.Size(210, 104)
        Me.pnlFull.TabIndex = 176
        '
        'chkMax7
        '
        Me.chkMax7.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkMax7.Location = New System.Drawing.Point(0, 80)
        Me.chkMax7.Name = "chkMax7"
        Me.chkMax7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkMax7.Properties.Appearance.Options.UseFont = True
        Me.chkMax7.Properties.AutoHeight = False
        Me.chkMax7.Properties.Caption = "Jatuh tempo > 7 hari"
        Me.chkMax7.Size = New System.Drawing.Size(210, 20)
        Me.chkMax7.TabIndex = 160
        '
        'Panel38
        '
        Me.Panel38.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel38.Location = New System.Drawing.Point(0, 75)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(210, 5)
        Me.Panel38.TabIndex = 159
        '
        'chkMin7
        '
        Me.chkMin7.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkMin7.Location = New System.Drawing.Point(0, 55)
        Me.chkMin7.Name = "chkMin7"
        Me.chkMin7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkMin7.Properties.Appearance.Options.UseFont = True
        Me.chkMin7.Properties.AutoHeight = False
        Me.chkMin7.Properties.Caption = "Jatuh tempo <= 7 hari"
        Me.chkMin7.Size = New System.Drawing.Size(210, 20)
        Me.chkMin7.TabIndex = 158
        '
        'Panel39
        '
        Me.Panel39.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel39.Location = New System.Drawing.Point(0, 50)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(210, 5)
        Me.Panel39.TabIndex = 157
        '
        'chkJt
        '
        Me.chkJt.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkJt.Location = New System.Drawing.Point(0, 30)
        Me.chkJt.Name = "chkJt"
        Me.chkJt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkJt.Properties.Appearance.Options.UseFont = True
        Me.chkJt.Properties.AutoHeight = False
        Me.chkJt.Properties.Caption = "Nota jatuh tempo"
        Me.chkJt.Size = New System.Drawing.Size(210, 20)
        Me.chkJt.TabIndex = 156
        '
        'Panel40
        '
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel40.Location = New System.Drawing.Point(0, 25)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(210, 5)
        Me.Panel40.TabIndex = 155
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(0, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(210, 25)
        Me.Label25.TabIndex = 154
        Me.Label25.Text = "Filter View"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel19.Location = New System.Drawing.Point(341, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(10, 104)
        Me.Panel19.TabIndex = 173
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 104)
        Me.Panel2.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.pnlJns)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 55)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(341, 20)
        Me.Panel11.TabIndex = 169
        '
        'pnlJns
        '
        Me.pnlJns.Controls.Add(Me.cmbJenis)
        Me.pnlJns.Controls.Add(Me.Label7)
        Me.pnlJns.Controls.Add(Me.Label8)
        Me.pnlJns.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlJns.Location = New System.Drawing.Point(0, 0)
        Me.pnlJns.Name = "pnlJns"
        Me.pnlJns.Size = New System.Drawing.Size(200, 20)
        Me.pnlJns.TabIndex = 152
        '
        'cmbJenis
        '
        Me.cmbJenis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbJenis.EnterMoveNextControl = True
        Me.cmbJenis.Location = New System.Drawing.Point(110, 0)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbJenis.Properties.Items.AddRange(New Object() {"Jual", "Beli"})
        Me.cmbJenis.Size = New System.Drawing.Size(90, 20)
        Me.cmbJenis.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
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
        Me.Label8.Text = "Jenis Transaksi"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 50)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(341, 5)
        Me.Panel9.TabIndex = 161
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.pnlTglAkhir)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(341, 20)
        Me.Panel6.TabIndex = 160
        '
        'pnlTglAkhir
        '
        Me.pnlTglAkhir.Controls.Add(Me.deTglAkhir)
        Me.pnlTglAkhir.Controls.Add(Me.Label2)
        Me.pnlTglAkhir.Controls.Add(Me.Label5)
        Me.pnlTglAkhir.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTglAkhir.Location = New System.Drawing.Point(0, 0)
        Me.pnlTglAkhir.Name = "pnlTglAkhir"
        Me.pnlTglAkhir.Size = New System.Drawing.Size(250, 20)
        Me.pnlTglAkhir.TabIndex = 153
        '
        'deTglAkhir
        '
        Me.deTglAkhir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deTglAkhir.EditValue = Nothing
        Me.deTglAkhir.EnterMoveNextControl = True
        Me.deTglAkhir.Location = New System.Drawing.Point(110, 0)
        Me.deTglAkhir.Name = "deTglAkhir"
        Me.deTglAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglAkhir.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.deTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglAkhir.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.deTglAkhir.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deTglAkhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglAkhir.Size = New System.Drawing.Size(140, 20)
        Me.deTglAkhir.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(100, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ":"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Akhir"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 25)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(341, 5)
        Me.Panel8.TabIndex = 159
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.pnlTglAwal)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(341, 20)
        Me.Panel4.TabIndex = 158
        '
        'pnlTglAwal
        '
        Me.pnlTglAwal.Controls.Add(Me.deTglAwal)
        Me.pnlTglAwal.Controls.Add(Me.Label3)
        Me.pnlTglAwal.Controls.Add(Me.Label1)
        Me.pnlTglAwal.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTglAwal.Location = New System.Drawing.Point(0, 0)
        Me.pnlTglAwal.Name = "pnlTglAwal"
        Me.pnlTglAwal.Size = New System.Drawing.Size(250, 20)
        Me.pnlTglAwal.TabIndex = 152
        '
        'deTglAwal
        '
        Me.deTglAwal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deTglAwal.EditValue = Nothing
        Me.deTglAwal.EnterMoveNextControl = True
        Me.deTglAwal.Location = New System.Drawing.Point(110, 0)
        Me.deTglAwal.Name = "deTglAwal"
        Me.deTglAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglAwal.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.deTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglAwal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.deTglAwal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deTglAwal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglAwal.Size = New System.Drawing.Size(140, 20)
        Me.deTglAwal.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
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
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(341, 5)
        Me.Panel7.TabIndex = 157
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel22)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 401)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 50)
        Me.Panel1.TabIndex = 148
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.Panel36)
        Me.Panel22.Controls.Add(Me.Panel25)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(504, 48)
        Me.Panel22.TabIndex = 149
        '
        'Panel36
        '
        Me.Panel36.Controls.Add(Me.Panel37)
        Me.Panel36.Controls.Add(Me.Panel35)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel36.Location = New System.Drawing.Point(100, 0)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(404, 48)
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
        Me.Panel25.Size = New System.Drawing.Size(100, 48)
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
        Me.Panel5.Size = New System.Drawing.Size(932, 34)
        Me.Panel5.TabIndex = 147
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
        Me.Label4.Size = New System.Drawing.Size(336, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "         MONITORING GIRO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gcGiro
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
        'aFormMonGiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 451)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormMonGiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Monitoring Giro"
        CType(Me.gvGiroTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTgl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcGiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvGiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupValuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.pnlFull.ResumeLayout(False)
        CType(Me.chkMax7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMin7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkJt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.pnlJns.ResumeLayout(False)
        CType(Me.cmbJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlTglAkhir.ResumeLayout(False)
        CType(Me.deTglAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.pnlTglAwal.ResumeLayout(False)
        CType(Me.deTglAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents pnlJns As System.Windows.Forms.Panel
    Friend WithEvents cmbJenis As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pnlTglAkhir As System.Windows.Forms.Panel
    Friend WithEvents deTglAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlTglAwal As System.Windows.Forms.Panel
    Friend WithEvents deTglAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents gcGiro As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvGiroTrans As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tgl_trans1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deTgl As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents kd_bank1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupBank As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jml_trans1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvGiro As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_jth_tempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupValuta As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_bank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Panel36 As System.Windows.Forms.Panel
    Friend WithEvents Panel37 As System.Windows.Forms.Panel
    Friend WithEvents Panel32 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel33 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel34 As System.Windows.Forms.Panel
    Friend WithEvents Panel35 As System.Windows.Forms.Panel
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel30 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel31 As System.Windows.Forms.Panel
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnlFull As System.Windows.Forms.Panel
    Friend WithEvents chkMax7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel38 As System.Windows.Forms.Panel
    Friend WithEvents chkMin7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel39 As System.Windows.Forms.Panel
    Friend WithEvents chkJt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel40 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnToday As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents jns_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents divisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupDivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
