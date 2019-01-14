<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstTipeTran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstTipeTran))
        Me.gvtran_d = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tipe_desc1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_bb_besar1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lookupbesar = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_bb_besar2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cekdebet = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cekstatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GcTipeTranKeu = New DevExpress.XtraGrid.GridControl
        Me.GvTipeTranKeu = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_subsis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_jurnal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_desc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.accronim_desc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.auto_manual = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbYN = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.auto_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.flag_pajak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.flag_materai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.attribut1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.attribut2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_Stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Lookuppusat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlBwh = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.gvtran_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookupbesar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cekdebet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cekstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcTipeTranKeu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvTipeTranKeu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbYN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookuppusat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlBwh.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvtran_d
        '
        Me.gvtran_d.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.gvtran_d.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.gvtran_d.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvtran_d.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvtran_d.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvtran_d.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.gvtran_d.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.gvtran_d.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.gvtran_d.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.gvtran_d.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvtran_d.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvtran_d.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvtran_d.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvtran_d.Appearance.Empty.Options.UseBackColor = True
        Me.gvtran_d.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.gvtran_d.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.gvtran_d.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvtran_d.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gvtran_d.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvtran_d.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvtran_d.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvtran_d.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gvtran_d.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvtran_d.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvtran_d.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gvtran_d.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvtran_d.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvtran_d.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvtran_d.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.gvtran_d.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvtran_d.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvtran_d.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gvtran_d.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvtran_d.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvtran_d.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.gvtran_d.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvtran_d.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gvtran_d.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvtran_d.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvtran_d.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvtran_d.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy
        Me.gvtran_d.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.gvtran_d.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvtran_d.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvtran_d.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvtran_d.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvtran_d.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvtran_d.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvtran_d.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvtran_d.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvtran_d.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvtran_d.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvtran_d.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvtran_d.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.gvtran_d.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.gvtran_d.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvtran_d.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvtran_d.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvtran_d.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvtran_d.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.gvtran_d.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvtran_d.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvtran_d.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.gvtran_d.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvtran_d.Appearance.GroupPanel.Options.UseFont = True
        Me.gvtran_d.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvtran_d.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray
        Me.gvtran_d.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvtran_d.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvtran_d.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvtran_d.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvtran_d.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvtran_d.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvtran_d.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvtran_d.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvtran_d.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.gvtran_d.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvtran_d.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvtran_d.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvtran_d.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvtran_d.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvtran_d.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.gvtran_d.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvtran_d.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.gvtran_d.Appearance.OddRow.Options.UseBackColor = True
        Me.gvtran_d.Appearance.OddRow.Options.UseForeColor = True
        Me.gvtran_d.Appearance.Preview.BackColor = System.Drawing.Color.White
        Me.gvtran_d.Appearance.Preview.ForeColor = System.Drawing.Color.Navy
        Me.gvtran_d.Appearance.Preview.Options.UseBackColor = True
        Me.gvtran_d.Appearance.Preview.Options.UseForeColor = True
        Me.gvtran_d.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvtran_d.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvtran_d.Appearance.Row.Options.UseBackColor = True
        Me.gvtran_d.Appearance.Row.Options.UseForeColor = True
        Me.gvtran_d.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvtran_d.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvtran_d.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvtran_d.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gvtran_d.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvtran_d.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvtran_d.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvtran_d.Appearance.VertLine.BackColor = System.Drawing.Color.Silver
        Me.gvtran_d.Appearance.VertLine.Options.UseBackColor = True
        Me.gvtran_d.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipe_desc1, Me.kd_bb_besar1, Me.kd_bb_besar2, Me.debet, Me.keterangan, Me.status})
        Me.gvtran_d.GridControl = Me.GcTipeTranKeu
        Me.gvtran_d.Name = "gvtran_d"
        Me.gvtran_d.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvtran_d.OptionsView.EnableAppearanceEvenRow = True
        Me.gvtran_d.OptionsView.EnableAppearanceOddRow = True
        Me.gvtran_d.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvtran_d.OptionsView.ShowGroupPanel = False
        Me.gvtran_d.PaintStyleName = "WindowsXP"
        '
        'tipe_desc1
        '
        Me.tipe_desc1.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_desc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_desc1.Caption = "Tipe Desc"
        Me.tipe_desc1.FieldName = "tipe_desc"
        Me.tipe_desc1.Name = "tipe_desc1"
        Me.tipe_desc1.Visible = True
        Me.tipe_desc1.VisibleIndex = 0
        '
        'kd_bb_besar1
        '
        Me.kd_bb_besar1.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_bb_besar1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_bb_besar1.Caption = "Rekening IDR"
        Me.kd_bb_besar1.ColumnEdit = Me.Lookupbesar
        Me.kd_bb_besar1.FieldName = "kd_bb_besar1"
        Me.kd_bb_besar1.Name = "kd_bb_besar1"
        Me.kd_bb_besar1.Visible = True
        Me.kd_bb_besar1.VisibleIndex = 1
        '
        'Lookupbesar
        '
        Me.Lookupbesar.AutoHeight = False
        Me.Lookupbesar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookupbesar.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama Rekening")})
        Me.Lookupbesar.Name = "Lookupbesar"
        Me.Lookupbesar.NullText = "klik disini"
        '
        'kd_bb_besar2
        '
        Me.kd_bb_besar2.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_bb_besar2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_bb_besar2.Caption = "Rekening USD"
        Me.kd_bb_besar2.ColumnEdit = Me.Lookupbesar
        Me.kd_bb_besar2.FieldName = "kd_bb_besar2"
        Me.kd_bb_besar2.Name = "kd_bb_besar2"
        Me.kd_bb_besar2.Visible = True
        Me.kd_bb_besar2.VisibleIndex = 2
        '
        'debet
        '
        Me.debet.AppearanceHeader.Options.UseTextOptions = True
        Me.debet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.debet.Caption = "D/K"
        Me.debet.ColumnEdit = Me.cekdebet
        Me.debet.FieldName = "D_K"
        Me.debet.Name = "debet"
        Me.debet.Visible = True
        Me.debet.VisibleIndex = 3
        '
        'cekdebet
        '
        Me.cekdebet.AutoHeight = False
        Me.cekdebet.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cekdebet.Items.AddRange(New Object() {"Debet", "Kredit"})
        Me.cekdebet.Name = "cekdebet"
        Me.cekdebet.NullText = "Pilih"
        Me.cekdebet.ValidateOnEnterKey = True
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 4
        '
        'status
        '
        Me.status.AppearanceHeader.Options.UseTextOptions = True
        Me.status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.status.Caption = "Status"
        Me.status.ColumnEdit = Me.cekstatus
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 5
        '
        'cekstatus
        '
        Me.cekstatus.AutoHeight = False
        Me.cekstatus.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cekstatus.Caption = "Y"
        Me.cekstatus.DisplayValueChecked = "Y"
        Me.cekstatus.DisplayValueUnchecked = "T"
        Me.cekstatus.Name = "cekstatus"
        Me.cekstatus.ValueChecked = "Y"
        Me.cekstatus.ValueUnchecked = "T"
        '
        'GcTipeTranKeu
        '
        Me.GcTipeTranKeu.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvtran_d
        GridLevelNode1.RelationName = "Level1"
        Me.GcTipeTranKeu.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcTipeTranKeu.Location = New System.Drawing.Point(0, 34)
        Me.GcTipeTranKeu.MainView = Me.GvTipeTranKeu
        Me.GcTipeTranKeu.Name = "GcTipeTranKeu"
        Me.GcTipeTranKeu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Lookupbesar, Me.Lookuppusat, Me.CekStat, Me.cekstatus, Me.cekdebet, Me.cbYN})
        Me.GcTipeTranKeu.Size = New System.Drawing.Size(1004, 242)
        Me.GcTipeTranKeu.TabIndex = 29
        Me.GcTipeTranKeu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvTipeTranKeu, Me.gvtran_d})
        '
        'GvTipeTranKeu
        '
        Me.GvTipeTranKeu.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvTipeTranKeu.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvTipeTranKeu.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvTipeTranKeu.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvTipeTranKeu.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GvTipeTranKeu.Appearance.Empty.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvTipeTranKeu.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvTipeTranKeu.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GvTipeTranKeu.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvTipeTranKeu.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvTipeTranKeu.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvTipeTranKeu.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvTipeTranKeu.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvTipeTranKeu.Appearance.GroupButton.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvTipeTranKeu.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GvTipeTranKeu.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvTipeTranKeu.Appearance.GroupRow.Options.UseFont = True
        Me.GvTipeTranKeu.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvTipeTranKeu.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvTipeTranKeu.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GvTipeTranKeu.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.OddRow.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.OddRow.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.Preview.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.Preview.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GvTipeTranKeu.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvTipeTranKeu.Appearance.Row.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.Row.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GvTipeTranKeu.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvTipeTranKeu.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvTipeTranKeu.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvTipeTranKeu.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvTipeTranKeu.Appearance.VertLine.Options.UseBackColor = True
        Me.GvTipeTranKeu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_subsis, Me.kd_jurnal, Me.tipe_trans, Me.tipe_desc, Me.accronim_desc, Me.auto_manual, Me.auto_posting, Me.flag_pajak, Me.flag_materai, Me.attribut1, Me.attribut2, Me.Rec_Stat})
        Me.GvTipeTranKeu.GridControl = Me.GcTipeTranKeu
        Me.GvTipeTranKeu.Name = "GvTipeTranKeu"
        Me.GvTipeTranKeu.OptionsCustomization.AllowColumnMoving = False
        Me.GvTipeTranKeu.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GvTipeTranKeu.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GvTipeTranKeu.OptionsDetail.EnableDetailToolTip = True
        Me.GvTipeTranKeu.OptionsView.EnableAppearanceEvenRow = True
        Me.GvTipeTranKeu.OptionsView.EnableAppearanceOddRow = True
        Me.GvTipeTranKeu.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvTipeTranKeu.OptionsView.RowAutoHeight = True
        Me.GvTipeTranKeu.OptionsView.ShowGroupPanel = False
        Me.GvTipeTranKeu.OptionsView.ShowViewCaption = True
        Me.GvTipeTranKeu.PaintStyleName = "WindowsXP"
        Me.GvTipeTranKeu.ViewCaption = "Data Setting Tipe Transaksi"
        '
        'kd_subsis
        '
        Me.kd_subsis.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_subsis.AppearanceHeader.Options.UseFont = True
        Me.kd_subsis.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_subsis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_subsis.Caption = "Kode Subsis"
        Me.kd_subsis.FieldName = "kd_subsis"
        Me.kd_subsis.Name = "kd_subsis"
        Me.kd_subsis.Visible = True
        Me.kd_subsis.VisibleIndex = 0
        Me.kd_subsis.Width = 69
        '
        'kd_jurnal
        '
        Me.kd_jurnal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_jurnal.AppearanceHeader.Options.UseFont = True
        Me.kd_jurnal.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_jurnal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_jurnal.Caption = "Kode Jurnal"
        Me.kd_jurnal.FieldName = "kd_jurnal"
        Me.kd_jurnal.Name = "kd_jurnal"
        Me.kd_jurnal.Visible = True
        Me.kd_jurnal.VisibleIndex = 1
        Me.kd_jurnal.Width = 74
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_trans.Caption = "Tipe Transaksi"
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 2
        Me.tipe_trans.Width = 84
        '
        'tipe_desc
        '
        Me.tipe_desc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipe_desc.AppearanceHeader.Options.UseFont = True
        Me.tipe_desc.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_desc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_desc.Caption = "Tipe Deskripsi"
        Me.tipe_desc.FieldName = "tipe_desc"
        Me.tipe_desc.Name = "tipe_desc"
        Me.tipe_desc.Visible = True
        Me.tipe_desc.VisibleIndex = 3
        Me.tipe_desc.Width = 181
        '
        'accronim_desc
        '
        Me.accronim_desc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accronim_desc.AppearanceHeader.Options.UseFont = True
        Me.accronim_desc.AppearanceHeader.Options.UseTextOptions = True
        Me.accronim_desc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.accronim_desc.Caption = "Acronim Desc"
        Me.accronim_desc.FieldName = "accronim_desc"
        Me.accronim_desc.Name = "accronim_desc"
        Me.accronim_desc.Visible = True
        Me.accronim_desc.VisibleIndex = 4
        Me.accronim_desc.Width = 106
        '
        'auto_manual
        '
        Me.auto_manual.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.auto_manual.AppearanceHeader.Options.UseFont = True
        Me.auto_manual.AppearanceHeader.Options.UseTextOptions = True
        Me.auto_manual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.auto_manual.Caption = "Auto Manual"
        Me.auto_manual.ColumnEdit = Me.cbYN
        Me.auto_manual.FieldName = "auto_manual"
        Me.auto_manual.Name = "auto_manual"
        Me.auto_manual.Visible = True
        Me.auto_manual.VisibleIndex = 5
        Me.auto_manual.Width = 70
        '
        'cbYN
        '
        Me.cbYN.AutoHeight = False
        Me.cbYN.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbYN.Items.AddRange(New Object() {"A", "M"})
        Me.cbYN.Name = "cbYN"
        '
        'auto_posting
        '
        Me.auto_posting.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.auto_posting.AppearanceHeader.Options.UseFont = True
        Me.auto_posting.AppearanceHeader.Options.UseTextOptions = True
        Me.auto_posting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.auto_posting.Caption = "Auto Posting"
        Me.auto_posting.ColumnEdit = Me.cbYN
        Me.auto_posting.FieldName = "auto_posting"
        Me.auto_posting.Name = "auto_posting"
        Me.auto_posting.Visible = True
        Me.auto_posting.VisibleIndex = 6
        Me.auto_posting.Width = 76
        '
        'flag_pajak
        '
        Me.flag_pajak.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flag_pajak.AppearanceHeader.Options.UseFont = True
        Me.flag_pajak.AppearanceHeader.Options.UseTextOptions = True
        Me.flag_pajak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.flag_pajak.Caption = "Flag Pajak"
        Me.flag_pajak.ColumnEdit = Me.cbYN
        Me.flag_pajak.FieldName = "flag_pajak"
        Me.flag_pajak.Name = "flag_pajak"
        Me.flag_pajak.Visible = True
        Me.flag_pajak.VisibleIndex = 7
        Me.flag_pajak.Width = 68
        '
        'flag_materai
        '
        Me.flag_materai.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flag_materai.AppearanceHeader.Options.UseFont = True
        Me.flag_materai.AppearanceHeader.Options.UseTextOptions = True
        Me.flag_materai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.flag_materai.Caption = "Flag Materai"
        Me.flag_materai.ColumnEdit = Me.cbYN
        Me.flag_materai.FieldName = "flag_materai"
        Me.flag_materai.Name = "flag_materai"
        Me.flag_materai.Visible = True
        Me.flag_materai.VisibleIndex = 8
        Me.flag_materai.Width = 73
        '
        'attribut1
        '
        Me.attribut1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attribut1.AppearanceHeader.Options.UseFont = True
        Me.attribut1.AppearanceHeader.Options.UseTextOptions = True
        Me.attribut1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.attribut1.Caption = "Atribut 1"
        Me.attribut1.FieldName = "attribut1"
        Me.attribut1.Name = "attribut1"
        Me.attribut1.Visible = True
        Me.attribut1.VisibleIndex = 9
        Me.attribut1.Width = 64
        '
        'attribut2
        '
        Me.attribut2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attribut2.AppearanceHeader.Options.UseFont = True
        Me.attribut2.AppearanceHeader.Options.UseTextOptions = True
        Me.attribut2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.attribut2.Caption = "Attribute 2"
        Me.attribut2.FieldName = "attribut2"
        Me.attribut2.Name = "attribut2"
        Me.attribut2.Visible = True
        Me.attribut2.VisibleIndex = 10
        Me.attribut2.Width = 68
        '
        'Rec_Stat
        '
        Me.Rec_Stat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_Stat.AppearanceHeader.Options.UseFont = True
        Me.Rec_Stat.AppearanceHeader.Options.UseTextOptions = True
        Me.Rec_Stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Rec_Stat.Caption = "Status"
        Me.Rec_Stat.ColumnEdit = Me.CekStat
        Me.Rec_Stat.FieldName = "status"
        Me.Rec_Stat.Name = "Rec_Stat"
        Me.Rec_Stat.Visible = True
        Me.Rec_Stat.VisibleIndex = 11
        Me.Rec_Stat.Width = 50
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = ""
        Me.CekStat.DisplayValueChecked = "Y"
        Me.CekStat.DisplayValueUnchecked = "T"
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CekStat.ValueChecked = "Y"
        Me.CekStat.ValueUnchecked = "T"
        '
        'Lookuppusat
        '
        Me.Lookuppusat.AutoHeight = False
        Me.Lookuppusat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookuppusat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Pusat Biaya")})
        Me.Lookuppusat.Name = "Lookuppusat"
        Me.Lookuppusat.NullText = "klik disini"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcTipeTranKeu)
        Me.pnl.Controls.Add(Me.pnlBwh)
        Me.pnl.Controls.Add(Me.pnlTop)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 313)
        Me.pnl.TabIndex = 0
        '
        'pnlBwh
        '
        Me.pnlBwh.BackColor = System.Drawing.Color.DarkGray
        Me.pnlBwh.Controls.Add(Me.btnDel)
        Me.pnlBwh.Controls.Add(Me.btnExit)
        Me.pnlBwh.Controls.Add(Me.cmdSimpan)
        Me.pnlBwh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBwh.Location = New System.Drawing.Point(0, 276)
        Me.pnlBwh.Name = "pnlBwh"
        Me.pnlBwh.Size = New System.Drawing.Size(1004, 37)
        Me.pnlBwh.TabIndex = 28
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(482, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(600, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(401, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(64, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
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
        Me.pnlTop.Size = New System.Drawing.Size(1004, 34)
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
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          TIPE TRANSAKSI DI KEUANGAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMstTipeTran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 313)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstTipeTran"
        Me.Text = "Form Tipe Transaksi"
        CType(Me.gvtran_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookupbesar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cekdebet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cekstatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcTipeTranKeu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvTipeTranKeu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbYN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookuppusat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlBwh.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcTipeTranKeu As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvTipeTranKeu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_subsis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_jurnal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents accronim_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents auto_manual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents auto_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents flag_pajak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents flag_materai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents attribut1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents attribut2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_Stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Lookupbesar As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lookuppusat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnlBwh As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gvtran_d As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tipe_desc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_bb_besar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_bb_besar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cekstatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cekdebet As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cbYN As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
