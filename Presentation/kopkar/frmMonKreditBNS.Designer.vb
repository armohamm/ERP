<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonKreditBNS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonKreditBNS))
        Me.gv_tbh_krd = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.trans_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jns_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_lama_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_sisa_pokok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcINV_Ret = New DevExpress.XtraGrid.GridControl
        Me.GV_RLSKRD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RLnama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stat_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_stat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.JML_PINJAMAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_POKOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_BUNGA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_ADMIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LAMA_ANGS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Created_By = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_rek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_rek2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_bbj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KETERANGAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.norek_cair = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pot_bns = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pot_thr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pot_tat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_prv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_TERIMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.gv_tbh_krd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_stat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv_tbh_krd
        '
        Me.gv_tbh_krd.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.trans_tbh, Me.no_tbh, Me.jns_tbh, Me.rp_tbh, Me.gc_lama_angs, Me.gc_sisa_pokok, Me.sisa_angs})
        Me.gv_tbh_krd.GridControl = Me.GcINV_Ret
        Me.gv_tbh_krd.Name = "gv_tbh_krd"
        Me.gv_tbh_krd.OptionsView.ColumnAutoWidth = False
        '
        'trans_tbh
        '
        Me.trans_tbh.Caption = "no_trans"
        Me.trans_tbh.FieldName = "no_trans"
        Me.trans_tbh.Name = "trans_tbh"
        Me.trans_tbh.Visible = True
        Me.trans_tbh.VisibleIndex = 1
        Me.trans_tbh.Width = 84
        '
        'no_tbh
        '
        Me.no_tbh.Caption = "No"
        Me.no_tbh.FieldName = "no_seq"
        Me.no_tbh.Name = "no_tbh"
        Me.no_tbh.Visible = True
        Me.no_tbh.VisibleIndex = 0
        Me.no_tbh.Width = 156
        '
        'jns_tbh
        '
        Me.jns_tbh.Caption = "Jenis"
        Me.jns_tbh.FieldName = "jenis"
        Me.jns_tbh.Name = "jns_tbh"
        Me.jns_tbh.Visible = True
        Me.jns_tbh.VisibleIndex = 2
        Me.jns_tbh.Width = 93
        '
        'rp_tbh
        '
        Me.rp_tbh.Caption = "Rp"
        Me.rp_tbh.DisplayFormat.FormatString = "n0"
        Me.rp_tbh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rp_tbh.FieldName = "nilai"
        Me.rp_tbh.Name = "rp_tbh"
        Me.rp_tbh.SummaryItem.DisplayFormat = "{0:n0}"
        Me.rp_tbh.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_tbh.Visible = True
        Me.rp_tbh.VisibleIndex = 3
        Me.rp_tbh.Width = 166
        '
        'gc_lama_angs
        '
        Me.gc_lama_angs.Caption = "Tenor POT"
        Me.gc_lama_angs.FieldName = "lama_angs"
        Me.gc_lama_angs.Name = "gc_lama_angs"
        Me.gc_lama_angs.Visible = True
        Me.gc_lama_angs.VisibleIndex = 4
        '
        'gc_sisa_pokok
        '
        Me.gc_sisa_pokok.Caption = "Total POT"
        Me.gc_sisa_pokok.DisplayFormat.FormatString = "n0"
        Me.gc_sisa_pokok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_sisa_pokok.FieldName = "sisa_pokok"
        Me.gc_sisa_pokok.Name = "gc_sisa_pokok"
        Me.gc_sisa_pokok.SummaryItem.DisplayFormat = "{0:n0}"
        Me.gc_sisa_pokok.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.gc_sisa_pokok.Visible = True
        Me.gc_sisa_pokok.VisibleIndex = 5
        '
        'sisa_angs
        '
        Me.sisa_angs.Caption = "sisa Tenor Pot"
        Me.sisa_angs.FieldName = "sisa_angs"
        Me.sisa_angs.Name = "sisa_angs"
        Me.sisa_angs.Visible = True
        Me.sisa_angs.VisibleIndex = 6
        '
        'GcINV_Ret
        '
        Me.GcINV_Ret.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gv_tbh_krd
        GridLevelNode1.RelationName = "Level1"
        Me.GcINV_Ret.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcINV_Ret.Location = New System.Drawing.Point(0, 0)
        Me.GcINV_Ret.MainView = Me.GV_RLSKRD
        Me.GcINV_Ret.Name = "GcINV_Ret"
        Me.GcINV_Ret.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RLnama, Me.RL_stat})
        Me.GcINV_Ret.Size = New System.Drawing.Size(1370, 251)
        Me.GcINV_Ret.TabIndex = 6
        Me.GcINV_Ret.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_RLSKRD, Me.gv_tbh_krd})
        '
        'GV_RLSKRD
        '
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.Empty.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GV_RLSKRD.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GV_RLSKRD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GV_RLSKRD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GV_RLSKRD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GV_RLSKRD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Preview.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.Preview.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.Preview.Options.UseFont = True
        Me.GV_RLSKRD.Appearance.Preview.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.Row.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.Row.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_RLSKRD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GV_RLSKRD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_RLSKRD.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.no_trans, Me.tgl_trans, Me.nasabah_id, Me.Nama, Me.jenis, Me.stat_approve, Me.JML_PINJAMAN, Me.JML_POKOK, Me.JML_BUNGA, Me.JML_ADMIN, Me.LAMA_ANGS, Me.Last_Created_By, Me.gc_stat, Me.no_rek, Me.no_rek2, Me.rec_bbj, Me.gc_angs, Me.KETERANGAN, Me.norek_cair, Me.pot_bns, Me.pot_thr, Me.pot_tat, Me.rec_prv, Me.JML_TERIMA})
        Me.GV_RLSKRD.GridControl = Me.GcINV_Ret
        Me.GV_RLSKRD.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JML_PINJAMAN", Me.JML_PINJAMAN, "{0:c2}")})
        Me.GV_RLSKRD.Name = "GV_RLSKRD"
        Me.GV_RLSKRD.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_RLSKRD.OptionsView.ColumnAutoWidth = False
        Me.GV_RLSKRD.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_RLSKRD.OptionsView.EnableAppearanceOddRow = True
        Me.GV_RLSKRD.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_RLSKRD.OptionsView.RowAutoHeight = True
        Me.GV_RLSKRD.OptionsView.ShowFooter = True
        Me.GV_RLSKRD.ViewCaption = "REALISASI PENGAJUAN (double klik utk lihat detail)"
        '
        'nomer
        '
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.AllowEdit = False
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 31
        '
        'no_trans
        '
        Me.no_trans.Caption = "No Trans"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.AllowEdit = False
        Me.no_trans.OptionsColumn.ReadOnly = True
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 1
        Me.no_trans.Width = 44
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tgl Trans"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 3
        Me.tgl_trans.Width = 45
        '
        'nasabah_id
        '
        Me.nasabah_id.Caption = "ID Nasabah"
        Me.nasabah_id.FieldName = "nasabah_id"
        Me.nasabah_id.Name = "nasabah_id"
        Me.nasabah_id.OptionsColumn.AllowEdit = False
        Me.nasabah_id.OptionsColumn.ReadOnly = True
        Me.nasabah_id.Visible = True
        Me.nasabah_id.VisibleIndex = 4
        Me.nasabah_id.Width = 52
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.ColumnEdit = Me.RLnama
        Me.Nama.FieldName = "nasabah_id"
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.ReadOnly = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 5
        Me.Nama.Width = 109
        '
        'RLnama
        '
        Me.RLnama.AutoHeight = False
        Me.RLnama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RLnama.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RLnama.Name = "RLnama"
        Me.RLnama.NullText = ""
        '
        'jenis
        '
        Me.jenis.Caption = "Jenis"
        Me.jenis.FieldName = "jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.OptionsColumn.AllowEdit = False
        Me.jenis.OptionsColumn.ReadOnly = True
        Me.jenis.Visible = True
        Me.jenis.VisibleIndex = 2
        Me.jenis.Width = 40
        '
        'stat_approve
        '
        Me.stat_approve.Caption = "Status"
        Me.stat_approve.ColumnEdit = Me.RL_stat
        Me.stat_approve.FieldName = "stat_approve"
        Me.stat_approve.Name = "stat_approve"
        Me.stat_approve.OptionsColumn.AllowEdit = False
        Me.stat_approve.OptionsColumn.ReadOnly = True
        Me.stat_approve.Visible = True
        Me.stat_approve.VisibleIndex = 10
        Me.stat_approve.Width = 80
        '
        'RL_stat
        '
        Me.RL_stat.AutoHeight = False
        Me.RL_stat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_stat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("keterangan", "keterangan")})
        Me.RL_stat.Name = "RL_stat"
        Me.RL_stat.NullText = ""
        '
        'JML_PINJAMAN
        '
        Me.JML_PINJAMAN.Caption = "Jml Pinjaman"
        Me.JML_PINJAMAN.DisplayFormat.FormatString = "n0"
        Me.JML_PINJAMAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_PINJAMAN.FieldName = "JML_PINJAMAN"
        Me.JML_PINJAMAN.Name = "JML_PINJAMAN"
        Me.JML_PINJAMAN.SummaryItem.DisplayFormat = "{0:n0}"
        Me.JML_PINJAMAN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_PINJAMAN.Visible = True
        Me.JML_PINJAMAN.VisibleIndex = 6
        Me.JML_PINJAMAN.Width = 73
        '
        'JML_POKOK
        '
        Me.JML_POKOK.Caption = "Jml Pokok"
        Me.JML_POKOK.DisplayFormat.FormatString = "n0"
        Me.JML_POKOK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_POKOK.FieldName = "JML_POKOK"
        Me.JML_POKOK.Name = "JML_POKOK"
        Me.JML_POKOK.SummaryItem.DisplayFormat = "{0:n0}"
        Me.JML_POKOK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_POKOK.Visible = True
        Me.JML_POKOK.VisibleIndex = 7
        '
        'JML_BUNGA
        '
        Me.JML_BUNGA.Caption = "Jml Bunga"
        Me.JML_BUNGA.DisplayFormat.FormatString = "n0"
        Me.JML_BUNGA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_BUNGA.FieldName = "JML_BUNGA"
        Me.JML_BUNGA.Name = "JML_BUNGA"
        Me.JML_BUNGA.SummaryItem.DisplayFormat = "{0:n0}"
        Me.JML_BUNGA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_BUNGA.Width = 60
        '
        'JML_ADMIN
        '
        Me.JML_ADMIN.Caption = "Admin"
        Me.JML_ADMIN.DisplayFormat.FormatString = "n0"
        Me.JML_ADMIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_ADMIN.FieldName = "JML_ADMIN"
        Me.JML_ADMIN.Name = "JML_ADMIN"
        Me.JML_ADMIN.SummaryItem.DisplayFormat = "{0:n0}"
        Me.JML_ADMIN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_ADMIN.Visible = True
        Me.JML_ADMIN.VisibleIndex = 13
        Me.JML_ADMIN.Width = 52
        '
        'LAMA_ANGS
        '
        Me.LAMA_ANGS.Caption = "Lama Angsuran"
        Me.LAMA_ANGS.FieldName = "LAMA_ANGS"
        Me.LAMA_ANGS.Name = "LAMA_ANGS"
        Me.LAMA_ANGS.SummaryItem.FieldName = "rp_trans"
        Me.LAMA_ANGS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.LAMA_ANGS.Width = 48
        '
        'Last_Created_By
        '
        Me.Last_Created_By.Caption = "Petugas"
        Me.Last_Created_By.FieldName = "Last_Created_By"
        Me.Last_Created_By.Name = "Last_Created_By"
        Me.Last_Created_By.Width = 54
        '
        'gc_stat
        '
        Me.gc_stat.Caption = "Status Kredit"
        Me.gc_stat.FieldName = "stat"
        Me.gc_stat.Name = "gc_stat"
        Me.gc_stat.Width = 55
        '
        'no_rek
        '
        Me.no_rek.Caption = "No Rek Debet"
        Me.no_rek.FieldName = "no_rek"
        Me.no_rek.Name = "no_rek"
        Me.no_rek.Visible = True
        Me.no_rek.VisibleIndex = 8
        Me.no_rek.Width = 78
        '
        'no_rek2
        '
        Me.no_rek2.Caption = "No Rek 2 Debet"
        Me.no_rek2.FieldName = "no_rek2"
        Me.no_rek2.Name = "no_rek2"
        Me.no_rek2.Width = 70
        '
        'rec_bbj
        '
        Me.rec_bbj.Caption = "Bg Berjalan"
        Me.rec_bbj.DisplayFormat.FormatString = "n0"
        Me.rec_bbj.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rec_bbj.FieldName = "rec_bbj"
        Me.rec_bbj.Name = "rec_bbj"
        Me.rec_bbj.SummaryItem.DisplayFormat = "{0:n0}"
        Me.rec_bbj.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rec_bbj.Visible = True
        Me.rec_bbj.VisibleIndex = 11
        Me.rec_bbj.Width = 66
        '
        'gc_angs
        '
        Me.gc_angs.Caption = "Angsuran"
        Me.gc_angs.DisplayFormat.FormatString = "n0"
        Me.gc_angs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_angs.FieldName = "angs"
        Me.gc_angs.Name = "gc_angs"
        Me.gc_angs.SummaryItem.DisplayFormat = "{0:n0}"
        Me.gc_angs.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.gc_angs.Width = 57
        '
        'KETERANGAN
        '
        Me.KETERANGAN.Caption = "Keterangan"
        Me.KETERANGAN.FieldName = "KETERANGAN"
        Me.KETERANGAN.Name = "KETERANGAN"
        Me.KETERANGAN.Visible = True
        Me.KETERANGAN.VisibleIndex = 15
        Me.KETERANGAN.Width = 196
        '
        'norek_cair
        '
        Me.norek_cair.Caption = "No Rek Cair"
        Me.norek_cair.FieldName = "norek_cair"
        Me.norek_cair.Name = "norek_cair"
        Me.norek_cair.Visible = True
        Me.norek_cair.VisibleIndex = 9
        Me.norek_cair.Width = 67
        '
        'pot_bns
        '
        Me.pot_bns.Caption = "Potong Bonus"
        Me.pot_bns.DisplayFormat.FormatString = "n0"
        Me.pot_bns.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pot_bns.FieldName = "pot_bns"
        Me.pot_bns.Name = "pot_bns"
        Me.pot_bns.SummaryItem.DisplayFormat = "{0:n0}"
        Me.pot_bns.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.pot_bns.Width = 78
        '
        'pot_thr
        '
        Me.pot_thr.Caption = "Potong THR"
        Me.pot_thr.DisplayFormat.FormatString = "n0"
        Me.pot_thr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pot_thr.FieldName = "pot_thr"
        Me.pot_thr.Name = "pot_thr"
        Me.pot_thr.SummaryItem.DisplayFormat = "{0:n0}"
        Me.pot_thr.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.pot_thr.Width = 69
        '
        'pot_tat
        '
        Me.pot_tat.Caption = "Potong TAT"
        Me.pot_tat.DisplayFormat.FormatString = "n0"
        Me.pot_tat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pot_tat.FieldName = "pot_tat"
        Me.pot_tat.Name = "pot_tat"
        Me.pot_tat.SummaryItem.DisplayFormat = "{0:n0}"
        Me.pot_tat.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.pot_tat.Width = 78
        '
        'rec_prv
        '
        Me.rec_prv.Caption = "Provisi"
        Me.rec_prv.DisplayFormat.FormatString = "n0"
        Me.rec_prv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rec_prv.FieldName = "JML_PROVISI"
        Me.rec_prv.Name = "rec_prv"
        Me.rec_prv.SummaryItem.DisplayFormat = "{0:n0}"
        Me.rec_prv.SummaryItem.FieldName = "rec_prv"
        Me.rec_prv.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rec_prv.Visible = True
        Me.rec_prv.VisibleIndex = 12
        Me.rec_prv.Width = 52
        '
        'JML_TERIMA
        '
        Me.JML_TERIMA.Caption = "Jumlah Terima"
        Me.JML_TERIMA.DisplayFormat.FormatString = "n0"
        Me.JML_TERIMA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_TERIMA.FieldName = "JML_TERIMA"
        Me.JML_TERIMA.Name = "JML_TERIMA"
        Me.JML_TERIMA.SummaryItem.DisplayFormat = "{0:n0}"
        Me.JML_TERIMA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_TERIMA.Visible = True
        Me.JML_TERIMA.VisibleIndex = 14
        Me.JML_TERIMA.Width = 80
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 293)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1370, 25)
        Me.Panel4.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 38)
        Me.Panel1.TabIndex = 157
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         MONITORING TRANSAKSI PINJAMAN BONUS DAN KHUSUS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcINV_Ret)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 42)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1370, 251)
        Me.Panel5.TabIndex = 2
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 42)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel2.Controls.Add(Me.btnprin)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 42)
        Me.Panel2.TabIndex = 7
        '
        'btnprin
        '
        Me.btnprin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnprin.ImageIndex = 10
        Me.btnprin.Location = New System.Drawing.Point(757, 0)
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(71, 42)
        Me.btnprin.TabIndex = 35
        Me.btnprin.Text = "Cetak"
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(708, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 34
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(659, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.tglsampai)
        Me.Panel6.Controls.Add(Me.tglDari)
        Me.Panel6.Controls.Add(Me.lookupBulanAwal)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(102, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(557, 42)
        Me.Panel6.TabIndex = 32
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
        Me.tglsampai.TabIndex = 58
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
        Me.tglDari.TabIndex = 57
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(379, 12)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(171, 20)
        Me.lookupBulanAwal.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(290, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Bulan Tahun :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "s/d"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 42)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Filter Tanggal : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1370, 318)
        Me.pnl.TabIndex = 158
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcINV_Ret
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
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
        'frmMonKreditBNS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 356)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMonKreditBNS"
        Me.Text = "frmMonKreditBNS"
        CType(Me.gv_tbh_krd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_stat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GcINV_Ret As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_RLSKRD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nasabah_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RLnama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stat_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_PINJAMAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_POKOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_BUNGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_ADMIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LAMA_ANGS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Created_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RL_stat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gv_tbh_krd As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents trans_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jns_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents gc_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_rek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_rek2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rec_bbj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KETERANGAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents norek_cair As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pot_bns As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pot_thr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pot_tat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents gc_lama_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_sisa_pokok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rec_prv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_TERIMA As DevExpress.XtraGrid.Columns.GridColumn
End Class
