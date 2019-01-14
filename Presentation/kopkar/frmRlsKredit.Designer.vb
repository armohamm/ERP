<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRlsKredit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRlsKredit))
        Me.gv_detil = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nasabah_id2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.catatan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_ke2 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
        Me.catatan3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_ke3 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
        Me.catatan4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_ke4 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
        Me.Nama1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RLnama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.note_kabagSP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_kabag = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
        Me.GcINV_Ret = New DevExpress.XtraGrid.GridControl
        Me.GV_RLSKRD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_PINJAMAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LAMA_ANGS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_bbj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_POKOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_BUNGA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_PROVISI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_TERIMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stat_rls = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bbj_lama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Cb_Approve = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RL_note_ke1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Btn_pilih = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label37 = New System.Windows.Forms.Label
        Me.dt_tgl = New DevExpress.XtraEditors.DateEdit
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        CType(Me.gv_detil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_ke2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_ke3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_ke4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_kabag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cb_Approve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_note_ke1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dt_tgl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv_detil
        '
        Me.gv_detil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nasabah_id2, Me.tgl_trans2, Me.no_trans2, Me.catatan2, Me.catatan3, Me.catatan4, Me.Nama1, Me.note_kabagSP})
        Me.gv_detil.GridControl = Me.GcINV_Ret
        Me.gv_detil.Name = "gv_detil"
        Me.gv_detil.OptionsNavigation.EnterMoveNextColumn = True
        Me.gv_detil.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.gv_detil.OptionsView.ShowGroupPanel = False
        '
        'nasabah_id2
        '
        Me.nasabah_id2.Caption = "NIP"
        Me.nasabah_id2.FieldName = "nasabah_id"
        Me.nasabah_id2.Name = "nasabah_id2"
        Me.nasabah_id2.Width = 29
        '
        'tgl_trans2
        '
        Me.tgl_trans2.Caption = "Tgl Trans"
        Me.tgl_trans2.FieldName = "tgl_trans"
        Me.tgl_trans2.Name = "tgl_trans2"
        Me.tgl_trans2.Width = 58
        '
        'no_trans2
        '
        Me.no_trans2.Caption = "No Trans"
        Me.no_trans2.FieldName = "no_trans"
        Me.no_trans2.Name = "no_trans2"
        Me.no_trans2.Width = 38
        '
        'catatan2
        '
        Me.catatan2.Caption = "Note Menejer 2"
        Me.catatan2.ColumnEdit = Me.RL_ke2
        Me.catatan2.FieldName = "catatan2"
        Me.catatan2.Name = "catatan2"
        Me.catatan2.Visible = True
        Me.catatan2.VisibleIndex = 1
        Me.catatan2.Width = 177
        '
        'RL_ke2
        '
        Me.RL_ke2.Name = "RL_ke2"
        '
        'catatan3
        '
        Me.catatan3.Caption = "Note Menejer 3"
        Me.catatan3.ColumnEdit = Me.RL_ke3
        Me.catatan3.FieldName = "catatan3"
        Me.catatan3.Name = "catatan3"
        Me.catatan3.Visible = True
        Me.catatan3.VisibleIndex = 2
        Me.catatan3.Width = 192
        '
        'RL_ke3
        '
        Me.RL_ke3.Name = "RL_ke3"
        '
        'catatan4
        '
        Me.catatan4.Caption = "Note Menejer 4"
        Me.catatan4.ColumnEdit = Me.RL_ke4
        Me.catatan4.FieldName = "catatan4"
        Me.catatan4.Name = "catatan4"
        Me.catatan4.Visible = True
        Me.catatan4.VisibleIndex = 3
        Me.catatan4.Width = 478
        '
        'RL_ke4
        '
        Me.RL_ke4.Name = "RL_ke4"
        '
        'Nama1
        '
        Me.Nama1.Caption = "Nama"
        Me.Nama1.ColumnEdit = Me.RLnama
        Me.Nama1.FieldName = "nasabah_id"
        Me.Nama1.Name = "Nama1"
        Me.Nama1.Visible = True
        Me.Nama1.VisibleIndex = 0
        Me.Nama1.Width = 108
        '
        'RLnama
        '
        Me.RLnama.AutoHeight = False
        Me.RLnama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RLnama.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RLnama.Name = "RLnama"
        Me.RLnama.NullText = ""
        '
        'note_kabagSP
        '
        Me.note_kabagSP.Caption = "Kabag SP"
        Me.note_kabagSP.ColumnEdit = Me.RL_kabag
        Me.note_kabagSP.FieldName = "note_kabagSP"
        Me.note_kabagSP.Name = "note_kabagSP"
        Me.note_kabagSP.Visible = True
        Me.note_kabagSP.VisibleIndex = 4
        Me.note_kabagSP.Width = 115
        '
        'RL_kabag
        '
        Me.RL_kabag.Name = "RL_kabag"
        '
        'GcINV_Ret
        '
        Me.GcINV_Ret.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gv_detil
        GridLevelNode1.RelationName = "Level1"
        Me.GcINV_Ret.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcINV_Ret.Location = New System.Drawing.Point(0, 0)
        Me.GcINV_Ret.MainView = Me.GV_RLSKRD
        Me.GcINV_Ret.Name = "GcINV_Ret"
        Me.GcINV_Ret.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Cb_Approve, Me.RLnama, Me.RL_note_ke1, Me.RL_kabag, Me.RL_ke2, Me.RL_ke3, Me.RL_ke4})
        Me.GcINV_Ret.Size = New System.Drawing.Size(1091, 458)
        Me.GcINV_Ret.TabIndex = 6
        Me.GcINV_Ret.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_RLSKRD, Me.gv_detil})
        '
        'GV_RLSKRD
        '
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.Empty.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_RLSKRD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseFont = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Preview.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.Preview.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.Row.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.Row.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV_RLSKRD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_RLSKRD.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tgl_trans, Me.nasabah_id, Me.JML_PINJAMAN, Me.Nama, Me.LAMA_ANGS, Me.no_trans, Me.tgl_debet, Me.rec_bbj, Me.JML_POKOK, Me.JML_BUNGA, Me.JML_PROVISI, Me.JML_TERIMA, Me.stat_rls, Me.bbj_lama})
        Me.GV_RLSKRD.GridControl = Me.GcINV_Ret
        Me.GV_RLSKRD.Name = "GV_RLSKRD"
        Me.GV_RLSKRD.OptionsCustomization.AllowColumnMoving = False
        Me.GV_RLSKRD.OptionsCustomization.AllowFilter = False
        Me.GV_RLSKRD.OptionsCustomization.AllowGroup = False
        Me.GV_RLSKRD.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_RLSKRD.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_RLSKRD.OptionsView.EnableAppearanceOddRow = True
        Me.GV_RLSKRD.OptionsView.RowAutoHeight = True
        Me.GV_RLSKRD.OptionsView.ShowFooter = True
        Me.GV_RLSKRD.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GV_RLSKRD.OptionsView.ShowGroupPanel = False
        Me.GV_RLSKRD.ViewCaption = "REALISASI PENGAJUAN"
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_trans.AppearanceHeader.Options.UseFont = True
        Me.tgl_trans.Caption = "Tgl Tran"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 31
        '
        'nasabah_id
        '
        Me.nasabah_id.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nasabah_id.AppearanceHeader.Options.UseFont = True
        Me.nasabah_id.Caption = "NIP"
        Me.nasabah_id.FieldName = "nasabah_id"
        Me.nasabah_id.Name = "nasabah_id"
        Me.nasabah_id.OptionsColumn.AllowEdit = False
        Me.nasabah_id.OptionsColumn.ReadOnly = True
        Me.nasabah_id.Visible = True
        Me.nasabah_id.VisibleIndex = 2
        Me.nasabah_id.Width = 25
        '
        'JML_PINJAMAN
        '
        Me.JML_PINJAMAN.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JML_PINJAMAN.AppearanceHeader.Options.UseFont = True
        Me.JML_PINJAMAN.Caption = "JML PINJAMAN"
        Me.JML_PINJAMAN.DisplayFormat.FormatString = "n0"
        Me.JML_PINJAMAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_PINJAMAN.FieldName = "JML_PINJAMAN"
        Me.JML_PINJAMAN.Name = "JML_PINJAMAN"
        Me.JML_PINJAMAN.OptionsColumn.AllowEdit = False
        Me.JML_PINJAMAN.OptionsColumn.ReadOnly = True
        Me.JML_PINJAMAN.Visible = True
        Me.JML_PINJAMAN.VisibleIndex = 4
        Me.JML_PINJAMAN.Width = 137
        '
        'Nama
        '
        Me.Nama.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.AppearanceHeader.Options.UseFont = True
        Me.Nama.Caption = "Nama"
        Me.Nama.ColumnEdit = Me.RLnama
        Me.Nama.FieldName = "nasabah_id"
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.ReadOnly = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 3
        Me.Nama.Width = 139
        '
        'LAMA_ANGS
        '
        Me.LAMA_ANGS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAMA_ANGS.AppearanceHeader.Options.UseFont = True
        Me.LAMA_ANGS.Caption = "Tempo"
        Me.LAMA_ANGS.FieldName = "LAMA_ANGS"
        Me.LAMA_ANGS.Name = "LAMA_ANGS"
        Me.LAMA_ANGS.OptionsColumn.AllowEdit = False
        Me.LAMA_ANGS.OptionsColumn.ReadOnly = True
        Me.LAMA_ANGS.Visible = True
        Me.LAMA_ANGS.VisibleIndex = 5
        Me.LAMA_ANGS.Width = 39
        '
        'no_trans
        '
        Me.no_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_trans.AppearanceHeader.Options.UseFont = True
        Me.no_trans.Caption = "No Trans"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.AllowEdit = False
        Me.no_trans.OptionsColumn.ReadOnly = True
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 0
        Me.no_trans.Width = 34
        '
        'tgl_debet
        '
        Me.tgl_debet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_debet.AppearanceHeader.Options.UseFont = True
        Me.tgl_debet.Caption = "tgl debet"
        Me.tgl_debet.FieldName = "tgl_debet"
        Me.tgl_debet.Name = "tgl_debet"
        Me.tgl_debet.Visible = True
        Me.tgl_debet.VisibleIndex = 6
        Me.tgl_debet.Width = 51
        '
        'rec_bbj
        '
        Me.rec_bbj.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rec_bbj.AppearanceHeader.Options.UseFont = True
        Me.rec_bbj.Caption = "Bunga Berjalan Baru"
        Me.rec_bbj.DisplayFormat.FormatString = "n2"
        Me.rec_bbj.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rec_bbj.FieldName = "rec_bbj"
        Me.rec_bbj.Name = "rec_bbj"
        Me.rec_bbj.SummaryItem.DisplayFormat = "{0:n2}"
        Me.rec_bbj.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rec_bbj.Visible = True
        Me.rec_bbj.VisibleIndex = 10
        Me.rec_bbj.Width = 126
        '
        'JML_POKOK
        '
        Me.JML_POKOK.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JML_POKOK.AppearanceHeader.Options.UseFont = True
        Me.JML_POKOK.Caption = "POKOK"
        Me.JML_POKOK.DisplayFormat.FormatString = "n2"
        Me.JML_POKOK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_POKOK.FieldName = "JML_POKOK"
        Me.JML_POKOK.Name = "JML_POKOK"
        Me.JML_POKOK.Visible = True
        Me.JML_POKOK.VisibleIndex = 7
        Me.JML_POKOK.Width = 85
        '
        'JML_BUNGA
        '
        Me.JML_BUNGA.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JML_BUNGA.AppearanceHeader.Options.UseFont = True
        Me.JML_BUNGA.Caption = "Bunga"
        Me.JML_BUNGA.DisplayFormat.FormatString = "n2"
        Me.JML_BUNGA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_BUNGA.FieldName = "JML_BUNGA"
        Me.JML_BUNGA.Name = "JML_BUNGA"
        Me.JML_BUNGA.Visible = True
        Me.JML_BUNGA.VisibleIndex = 8
        Me.JML_BUNGA.Width = 42
        '
        'JML_PROVISI
        '
        Me.JML_PROVISI.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JML_PROVISI.AppearanceHeader.Options.UseFont = True
        Me.JML_PROVISI.Caption = "Provisi"
        Me.JML_PROVISI.DisplayFormat.FormatString = "n2"
        Me.JML_PROVISI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_PROVISI.FieldName = "JML_PROVISI"
        Me.JML_PROVISI.Name = "JML_PROVISI"
        Me.JML_PROVISI.Visible = True
        Me.JML_PROVISI.VisibleIndex = 11
        Me.JML_PROVISI.Width = 50
        '
        'JML_TERIMA
        '
        Me.JML_TERIMA.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JML_TERIMA.AppearanceHeader.Options.UseFont = True
        Me.JML_TERIMA.Caption = "Jml Terima"
        Me.JML_TERIMA.DisplayFormat.FormatString = "n2"
        Me.JML_TERIMA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_TERIMA.FieldName = "JML_TERIMA"
        Me.JML_TERIMA.Name = "JML_TERIMA"
        Me.JML_TERIMA.Visible = True
        Me.JML_TERIMA.VisibleIndex = 12
        Me.JML_TERIMA.Width = 121
        '
        'stat_rls
        '
        Me.stat_rls.AppearanceCell.BackColor = System.Drawing.Color.DarkGreen
        Me.stat_rls.AppearanceCell.Options.UseBackColor = True
        Me.stat_rls.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stat_rls.AppearanceHeader.Options.UseFont = True
        Me.stat_rls.Caption = "Realisasi"
        Me.stat_rls.FieldName = "stat_rls"
        Me.stat_rls.Name = "stat_rls"
        Me.stat_rls.Visible = True
        Me.stat_rls.VisibleIndex = 13
        Me.stat_rls.Width = 59
        '
        'bbj_lama
        '
        Me.bbj_lama.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbj_lama.AppearanceHeader.Options.UseFont = True
        Me.bbj_lama.Caption = "Bunga Berjalan Lama"
        Me.bbj_lama.DisplayFormat.FormatString = "n2"
        Me.bbj_lama.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.bbj_lama.FieldName = "bbj_lama"
        Me.bbj_lama.Name = "bbj_lama"
        Me.bbj_lama.Visible = True
        Me.bbj_lama.VisibleIndex = 9
        Me.bbj_lama.Width = 131
        '
        'Cb_Approve
        '
        Me.Cb_Approve.AutoHeight = False
        Me.Cb_Approve.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cb_Approve.Items.AddRange(New Object() {"SETUJU", "TOLAK"})
        Me.Cb_Approve.Name = "Cb_Approve"
        '
        'RL_note_ke1
        '
        Me.RL_note_ke1.Name = "RL_note_ke1"
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         REALISASI PENGAJUAN KREDIT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel1.Size = New System.Drawing.Size(1091, 38)
        Me.Panel1.TabIndex = 151
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcINV_Ret)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 46)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1091, 458)
        Me.Panel5.TabIndex = 2
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1091, 504)
        Me.pnl.TabIndex = 153
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1091, 46)
        Me.Panel3.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmdRefresh)
        Me.Panel6.Controls.Add(Me.Btn_pilih)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1091, 46)
        Me.Panel6.TabIndex = 1
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdRefresh.Location = New System.Drawing.Point(955, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(107, 43)
        Me.cmdRefresh.TabIndex = 34
        Me.cmdRefresh.Text = "Refresh"
        '
        'Btn_pilih
        '
        Me.Btn_pilih.ImageIndex = 3
        Me.Btn_pilih.ImageList = Me.img
        Me.Btn_pilih.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Btn_pilih.Location = New System.Drawing.Point(810, 0)
        Me.Btn_pilih.LookAndFeel.SkinName = "The Asphalt World"
        Me.Btn_pilih.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Btn_pilih.Name = "Btn_pilih"
        Me.Btn_pilih.Size = New System.Drawing.Size(109, 43)
        Me.Btn_pilih.TabIndex = 41
        Me.Btn_pilih.Text = "Approve ALL"
        Me.Btn_pilih.ToolTip = "Celar Filter"
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
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label37)
        Me.Panel7.Controls.Add(Me.dt_tgl)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(565, 46)
        Me.Panel7.TabIndex = 0
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(28, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(57, 15)
        Me.Label37.TabIndex = 281
        Me.Label37.Text = "Tanggal: "
        '
        'dt_tgl
        '
        Me.dt_tgl.EditValue = Nothing
        Me.dt_tgl.Location = New System.Drawing.Point(113, 11)
        Me.dt_tgl.Name = "dt_tgl"
        Me.dt_tgl.Properties.Appearance.BackColor = System.Drawing.Color.Green
        Me.dt_tgl.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_tgl.Properties.Appearance.Options.UseBackColor = True
        Me.dt_tgl.Properties.Appearance.Options.UseFont = True
        Me.dt_tgl.Properties.Appearance.Options.UseTextOptions = True
        Me.dt_tgl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dt_tgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_tgl.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dt_tgl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_tgl.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.dt_tgl.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.dt_tgl.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dt_tgl.Size = New System.Drawing.Size(194, 20)
        Me.dt_tgl.TabIndex = 280
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'frmRlsKredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 542)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRlsKredit"
        Me.Text = "frmRlsKredit"
        CType(Me.gv_detil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_ke2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_ke3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_ke4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_kabag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cb_Approve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_note_ke1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.dt_tgl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GV_RLSKRD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GcINV_Ret As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Cb_Approve As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RLnama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gv_detil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nasabah_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nasabah_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents catatan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents catatan3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents catatan4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_PINJAMAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LAMA_ANGS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents note_kabagSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Btn_pilih As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents RL_note_ke1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents RL_ke2 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents RL_ke3 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents RL_ke4 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents RL_kabag As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents dt_tgl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tgl_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rec_bbj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_POKOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_BUNGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_PROVISI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_TERIMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stat_rls As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbj_lama As DevExpress.XtraGrid.Columns.GridColumn
End Class
