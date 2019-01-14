<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonTransKasBon
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonTransKasBon))
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_jur2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVrekening = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_buku_pusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVpusat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.saldo_val_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_jur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVkartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LOVtipeTrans = New DevExpress.XtraEditors.LookUpEdit
        Me.tglSampaiX = New DevExpress.XtraEditors.DateEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.ResetCmd = New DevExpress.XtraEditors.SimpleButton
        Me.Allcmd = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.CCKBOXSetting = New System.Windows.Forms.CheckBox
        Me.cmdExe = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CENoPost = New DevExpress.XtraEditors.CheckEdit
        Me.LOVvaluta = New DevExpress.XtraEditors.LookUpEdit
        Me.CEPost = New DevExpress.XtraEditors.CheckEdit
        Me.LOVjurnal = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtSaldoAwal = New DevExpress.XtraEditors.TextEdit
        Me.tglDariX = New DevExpress.XtraEditors.DateEdit
        Me.CBEtipeTrans = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lblError1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.pnlGridLeft = New System.Windows.Forms.Panel
        Me.CCKListBoxKolom = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVrekening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVpusat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVkartu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.LOVtipeTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSampaiX.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSampaiX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CENoPost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVvaluta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEPost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVjurnal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtSaldoAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDariX.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDariX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBEtipeTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrid.SuspendLayout()
        Me.pnlGridLeft.SuspendLayout()
        CType(Me.CCKListBoxKolom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV2
        '
        Me.GV2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV2.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.Empty.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupRow.Options.UseFont = True
        Me.GV2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.OddRow.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.Options.UseForeColor = True
        Me.GV2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.Preview.Options.UseBackColor = True
        Me.GV2.Appearance.Preview.Options.UseForeColor = True
        Me.GV2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.Row.Options.UseBackColor = True
        Me.GV2.Appearance.Row.Options.UseForeColor = True
        Me.GV2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV2.Appearance.VertLine.Options.UseBackColor = True
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_jur2, Me.kd_buku_besar, Me.kd_buku_pusat, Me.saldo_val_debet, Me.saldo_val_kredit, Me.saldo_rp_debet, Me.saldo_rp_kredit, Me.keterangan2, Me.status})
        Me.GV2.GridControl = Me.GC1
        Me.GV2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo_val_debet", Me.saldo_val_debet, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo_val_kredit", Me.saldo_val_kredit, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo_rp_debet", Me.saldo_rp_debet, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo_rp_kredit", Me.saldo_rp_kredit, "")})
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.Editable = False
        Me.GV2.OptionsBehavior.ReadOnly = True
        Me.GV2.OptionsView.EnableAppearanceEvenRow = True
        Me.GV2.OptionsView.EnableAppearanceOddRow = True
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowViewCaption = True
        Me.GV2.PaintStyleName = "WindowsXP"
        Me.GV2.ViewCaption = "JURNAL DETAIL"
        '
        'no_jur2
        '
        Me.no_jur2.Caption = "No. Jurnal"
        Me.no_jur2.FieldName = "no_jur"
        Me.no_jur2.Name = "no_jur2"
        Me.no_jur2.Visible = True
        Me.no_jur2.VisibleIndex = 7
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.Caption = "Rekening"
        Me.kd_buku_besar.ColumnEdit = Me.LOVrekening
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 0
        '
        'LOVrekening
        '
        Me.LOVrekening.AutoHeight = False
        Me.LOVrekening.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVrekening.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.LOVrekening.Name = "LOVrekening"
        '
        'kd_buku_pusat
        '
        Me.kd_buku_pusat.Caption = "Pusta Biaya"
        Me.kd_buku_pusat.ColumnEdit = Me.LOVpusat
        Me.kd_buku_pusat.FieldName = "kd_buku_pusat"
        Me.kd_buku_pusat.Name = "kd_buku_pusat"
        Me.kd_buku_pusat.Visible = True
        Me.kd_buku_pusat.VisibleIndex = 1
        '
        'LOVpusat
        '
        Me.LOVpusat.AutoHeight = False
        Me.LOVpusat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVpusat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.LOVpusat.Name = "LOVpusat"
        '
        'saldo_val_debet
        '
        Me.saldo_val_debet.Caption = "Val Debet"
        Me.saldo_val_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_val_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_debet.FieldName = "saldo_val_debet"
        Me.saldo_val_debet.Name = "saldo_val_debet"
        Me.saldo_val_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_debet.Visible = True
        Me.saldo_val_debet.VisibleIndex = 2
        '
        'saldo_val_kredit
        '
        Me.saldo_val_kredit.Caption = "Val Kredit"
        Me.saldo_val_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_val_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_kredit.FieldName = "saldo_val_kredit"
        Me.saldo_val_kredit.Name = "saldo_val_kredit"
        Me.saldo_val_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_kredit.Visible = True
        Me.saldo_val_kredit.VisibleIndex = 3
        '
        'saldo_rp_debet
        '
        Me.saldo_rp_debet.Caption = "Rp Debet"
        Me.saldo_rp_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_rp_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_rp_debet.FieldName = "saldo_rp_debet"
        Me.saldo_rp_debet.Name = "saldo_rp_debet"
        Me.saldo_rp_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_rp_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_rp_debet.Visible = True
        Me.saldo_rp_debet.VisibleIndex = 4
        '
        'saldo_rp_kredit
        '
        Me.saldo_rp_kredit.Caption = "Rp Kredit"
        Me.saldo_rp_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_rp_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_rp_kredit.FieldName = "saldo_rp_kredit"
        Me.saldo_rp_kredit.Name = "saldo_rp_kredit"
        Me.saldo_rp_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_rp_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_rp_kredit.Visible = True
        Me.saldo_rp_kredit.VisibleIndex = 5
        '
        'keterangan2
        '
        Me.keterangan2.Caption = "Keterangan"
        Me.keterangan2.FieldName = "keterangan"
        Me.keterangan2.Name = "keterangan2"
        Me.keterangan2.Visible = True
        Me.keterangan2.VisibleIndex = 6
        '
        'status
        '
        Me.status.Caption = "Status"
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 8
        '
        'GC1
        '
        Me.GC1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV2
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.RelationName = "Level2"
        Me.GC1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GC1.Location = New System.Drawing.Point(136, 0)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVkartu, Me.LOVrekening, Me.LOVpusat})
        Me.GC1.Size = New System.Drawing.Size(973, 403)
        Me.GC1.TabIndex = 1
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GV2})
        '
        'GV1
        '
        Me.GV1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.GV1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.GV1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.GV1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.GV1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.GV1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.GV1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV1.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GV1.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.GV1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GV1.Appearance.Empty.Options.UseBackColor = True
        Me.GV1.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.GV1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.GV1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GV1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.GV1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.GV1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV1.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.GV1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.GV1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV1.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GV1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV1.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.GV1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV1.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV1.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.GV1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.GV1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV1.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.GV1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.GV1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV1.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.GV1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.GV1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV1.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.GV1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GV1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV1.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.GV1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV1.Appearance.GroupRow.Options.UseFont = True
        Me.GV1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.GV1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.GV1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.GV1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV1.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.GV1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV1.Appearance.OddRow.Options.UseBackColor = True
        Me.GV1.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.GV1.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.GV1.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.GV1.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GV1.Appearance.Preview.Options.UseBackColor = True
        Me.GV1.Appearance.Preview.Options.UseFont = True
        Me.GV1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV1.Appearance.Row.Options.UseBackColor = True
        Me.GV1.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GV1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV1.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.GV1.Appearance.VertLine.Options.UseBackColor = True
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no, Me.tipe_trans, Me.no_jur, Me.tgl_trans, Me.tgl_posting, Me.no_ref1, Me.no_ref3, Me.kd_kartu, Me.nama, Me.keterangan, Me.jml_val_trans, Me.jml_rp_trans, Me.Debet, Me.Kredit})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsBehavior.ReadOnly = True
        Me.GV1.OptionsView.EnableAppearanceEvenRow = True
        Me.GV1.OptionsView.EnableAppearanceOddRow = True
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowViewCaption = True
        Me.GV1.PaintStyleName = "WindowsXP"
        Me.GV1.ViewCaption = "JURNAL"
        '
        'no
        '
        Me.no.Caption = "no"
        Me.no.FieldName = "no"
        Me.no.Name = "no"
        Me.no.Visible = True
        Me.no.VisibleIndex = 0
        '
        'tipe_trans
        '
        Me.tipe_trans.Caption = "Tipe Trans"
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 1
        '
        'no_jur
        '
        Me.no_jur.Caption = "No. Jurnal"
        Me.no_jur.FieldName = "no_jur"
        Me.no_jur.Name = "no_jur"
        Me.no_jur.Visible = True
        Me.no_jur.VisibleIndex = 2
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tgl. Trans"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 3
        '
        'tgl_posting
        '
        Me.tgl_posting.Caption = "Tgl. Posting"
        Me.tgl_posting.FieldName = "tgl_posting"
        Me.tgl_posting.Name = "tgl_posting"
        '
        'no_ref1
        '
        Me.no_ref1.Caption = "No Ref 1"
        Me.no_ref1.FieldName = "no_ref1"
        Me.no_ref1.Name = "no_ref1"
        '
        'no_ref3
        '
        Me.no_ref3.Caption = "No. Ref 3"
        Me.no_ref3.FieldName = "no_ref3"
        Me.no_ref3.Name = "no_ref3"
        Me.no_ref3.Visible = True
        Me.no_ref3.VisibleIndex = 4
        '
        'kd_kartu
        '
        Me.kd_kartu.Caption = "Kartu"
        Me.kd_kartu.ColumnEdit = Me.LOVkartu
        Me.kd_kartu.FieldName = "kd_kartu"
        Me.kd_kartu.Name = "kd_kartu"
        Me.kd_kartu.Visible = True
        Me.kd_kartu.VisibleIndex = 5
        '
        'LOVkartu
        '
        Me.LOVkartu.AutoHeight = False
        Me.LOVkartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVkartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.LOVkartu.Name = "LOVkartu"
        '
        'nama
        '
        Me.nama.Caption = "Nama"
        Me.nama.FieldName = "nama"
        Me.nama.Name = "nama"
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 6
        '
        'jml_val_trans
        '
        Me.jml_val_trans.Caption = "Jml. Val"
        Me.jml_val_trans.DisplayFormat.FormatString = "n2"
        Me.jml_val_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_val_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'jml_rp_trans
        '
        Me.jml_rp_trans.Caption = "Jml. Rp"
        Me.jml_rp_trans.DisplayFormat.FormatString = "n2"
        Me.jml_rp_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_rp_trans.FieldName = "jml_rp_trans"
        Me.jml_rp_trans.Name = "jml_rp_trans"
        Me.jml_rp_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'Debet
        '
        Me.Debet.Caption = "Debet (Permohonan)"
        Me.Debet.FieldName = "debet"
        Me.Debet.Name = "Debet"
        Me.Debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Debet.Visible = True
        Me.Debet.VisibleIndex = 7
        '
        'Kredit
        '
        Me.Kredit.Caption = "Kredit (Pelunasan)"
        Me.Kredit.FieldName = "kredit"
        Me.Kredit.Name = "Kredit"
        Me.Kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Kredit.Visible = True
        Me.Kredit.VisibleIndex = 8
        '
        'DefaultToolTipController1
        '
        '
        '
        '
        Me.DefaultToolTipController1.DefaultController.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DefaultToolTipController1.DefaultController.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseBackColor = True
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseFont = True
        Me.DefaultToolTipController1.DefaultController.Rounded = True
        Me.DefaultToolTipController1.DefaultController.ShowBeak = True
        Me.DefaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.Standard
        '
        'Panel3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel3.Controls.Add(Me.LabelControl1)
        Me.Panel3.Controls.Add(Me.LOVtipeTrans)
        Me.Panel3.Controls.Add(Me.tglSampaiX)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(353, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(291, 91)
        Me.Panel3.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(-2, 1)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 21)
        Me.LabelControl1.TabIndex = 28
        Me.LabelControl1.Text = "s/d"
        '
        'LOVtipeTrans
        '
        Me.LOVtipeTrans.Location = New System.Drawing.Point(33, 24)
        Me.LOVtipeTrans.Name = "LOVtipeTrans"
        Me.LOVtipeTrans.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVtipeTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVtipeTrans.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_trans", "Name115"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_desc", "Name116"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_subsis", "Name117"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_jurnal", "Name118")})
        Me.LOVtipeTrans.Properties.NullText = ""
        Me.LOVtipeTrans.Size = New System.Drawing.Size(208, 20)
        Me.LOVtipeTrans.TabIndex = 27
        Me.LOVtipeTrans.Visible = False
        '
        'tglSampaiX
        '
        Me.tglSampaiX.EditValue = Nothing
        Me.tglSampaiX.Location = New System.Drawing.Point(33, 2)
        Me.tglSampaiX.Name = "tglSampaiX"
        Me.tglSampaiX.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglSampaiX.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglSampaiX.Properties.Appearance.Options.UseBackColor = True
        Me.tglSampaiX.Properties.Appearance.Options.UseFont = True
        Me.tglSampaiX.Properties.Appearance.Options.UseTextOptions = True
        Me.tglSampaiX.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglSampaiX.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglSampaiX.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglSampaiX.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglSampaiX.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglSampaiX.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglSampaiX.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglSampaiX.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglSampaiX.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglSampaiX.Size = New System.Drawing.Size(208, 20)
        Me.tglSampaiX.TabIndex = 23
        '
        'Panel8
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel8, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 128)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1109, 32)
        Me.Panel8.TabIndex = 7
        '
        'Panel11
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel11, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel11.BackColor = System.Drawing.Color.Maroon
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(202, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(907, 32)
        Me.Panel11.TabIndex = 5
        '
        'Panel9
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel9, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel9.BackColor = System.Drawing.Color.Maroon
        Me.Panel9.Controls.Add(Me.ResetCmd)
        Me.Panel9.Controls.Add(Me.Allcmd)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1109, 32)
        Me.Panel9.TabIndex = 4
        '
        'ResetCmd
        '
        Me.ResetCmd.Location = New System.Drawing.Point(46, 3)
        Me.ResetCmd.Name = "ResetCmd"
        Me.ResetCmd.Size = New System.Drawing.Size(37, 23)
        Me.ResetCmd.TabIndex = 1
        Me.ResetCmd.Text = "N"
        '
        'Allcmd
        '
        Me.Allcmd.Location = New System.Drawing.Point(3, 3)
        Me.Allcmd.Name = "Allcmd"
        Me.Allcmd.Size = New System.Drawing.Size(37, 23)
        Me.Allcmd.TabIndex = 30
        Me.Allcmd.Text = "A"
        '
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Controls.Add(Me.cmdRefresh)
        Me.Panel4.Controls.Add(Me.cmdClear)
        Me.Panel4.Controls.Add(Me.cmdPrint)
        Me.Panel4.Controls.Add(Me.CCKBOXSetting)
        Me.Panel4.Controls.Add(Me.cmdExe)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(644, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(225, 91)
        Me.Panel4.TabIndex = 2
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(151, 3)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 38)
        Me.cmdRefresh.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.cmdRefresh, "Reset Data")
        Me.cmdRefresh.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdRefresh.ToolTipTitle = "RELOAD"
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(107, 3)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 12
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(63, 3)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 11
        Me.cmdPrint.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdPrint.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdPrint.ToolTipTitle = "PRINT"
        '
        'CCKBOXSetting
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.CCKBOXSetting, DevExpress.Utils.DefaultBoolean.[Default])
        Me.CCKBOXSetting.AutoSize = True
        Me.CCKBOXSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCKBOXSetting.ForeColor = System.Drawing.Color.White
        Me.CCKBOXSetting.Location = New System.Drawing.Point(19, 67)
        Me.CCKBOXSetting.Name = "CCKBOXSetting"
        Me.CCKBOXSetting.Size = New System.Drawing.Size(101, 17)
        Me.CCKBOXSetting.TabIndex = 0
        Me.CCKBOXSetting.Text = "Show Setting"
        Me.CCKBOXSetting.UseVisualStyleBackColor = True
        '
        'cmdExe
        '
        Me.cmdExe.Image = CType(resources.GetObject("cmdExe.Image"), System.Drawing.Image)
        Me.cmdExe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExe.Location = New System.Drawing.Point(19, 3)
        Me.cmdExe.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdExe.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExe.Name = "cmdExe"
        Me.cmdExe.Size = New System.Drawing.Size(38, 38)
        Me.cmdExe.TabIndex = 10
        Me.cmdExe.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdExe.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdExe.ToolTipTitle = "SEARCH"
        '
        'Panel2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.CENoPost)
        Me.Panel2.Controls.Add(Me.LOVvaluta)
        Me.Panel2.Controls.Add(Me.CEPost)
        Me.Panel2.Controls.Add(Me.LOVjurnal)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 91)
        Me.Panel2.TabIndex = 5
        '
        'CENoPost
        '
        Me.CENoPost.Location = New System.Drawing.Point(877, 24)
        Me.CENoPost.Name = "CENoPost"
        Me.CENoPost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CENoPost.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CENoPost.Properties.Appearance.Options.UseFont = True
        Me.CENoPost.Properties.Appearance.Options.UseForeColor = True
        Me.CENoPost.Properties.Caption = "Belum Diposting"
        Me.CENoPost.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CENoPost.Size = New System.Drawing.Size(127, 19)
        Me.CENoPost.TabIndex = 25
        Me.CENoPost.Visible = False
        '
        'LOVvaluta
        '
        Me.LOVvaluta.Location = New System.Drawing.Point(875, 67)
        Me.LOVvaluta.Name = "LOVvaluta"
        Me.LOVvaluta.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVvaluta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVvaluta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Valuta", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama")})
        Me.LOVvaluta.Properties.NullText = ""
        Me.LOVvaluta.Size = New System.Drawing.Size(208, 20)
        Me.LOVvaluta.TabIndex = 25
        Me.LOVvaluta.Visible = False
        '
        'CEPost
        '
        Me.CEPost.EditValue = True
        Me.CEPost.Location = New System.Drawing.Point(875, 1)
        Me.CEPost.Name = "CEPost"
        Me.CEPost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPost.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEPost.Properties.Appearance.Options.UseFont = True
        Me.CEPost.Properties.Appearance.Options.UseForeColor = True
        Me.CEPost.Properties.Caption = "Sudah Diposting"
        Me.CEPost.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEPost.Size = New System.Drawing.Size(127, 19)
        Me.CEPost.TabIndex = 24
        Me.CEPost.Visible = False
        '
        'LOVjurnal
        '
        Me.LOVjurnal.Location = New System.Drawing.Point(875, 45)
        Me.LOVjurnal.Name = "LOVjurnal"
        Me.LOVjurnal.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVjurnal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVjurnal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Nama")})
        Me.LOVjurnal.Properties.NullText = ""
        Me.LOVjurnal.Size = New System.Drawing.Size(208, 20)
        Me.LOVjurnal.TabIndex = 24
        Me.LOVjurnal.Visible = False
        '
        'Panel6
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel6, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel6.Controls.Add(Me.txtSaldoAwal)
        Me.Panel6.Controls.Add(Me.tglDariX)
        Me.Panel6.Controls.Add(Me.CBEtipeTrans)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(214, 91)
        Me.Panel6.TabIndex = 5
        '
        'txtSaldoAwal
        '
        Me.txtSaldoAwal.Location = New System.Drawing.Point(3, 64)
        Me.txtSaldoAwal.Name = "txtSaldoAwal"
        Me.txtSaldoAwal.Properties.Mask.BeepOnError = True
        Me.txtSaldoAwal.Properties.Mask.EditMask = "d"
        Me.txtSaldoAwal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSaldoAwal.Properties.ReadOnly = True
        Me.txtSaldoAwal.Size = New System.Drawing.Size(205, 20)
        Me.txtSaldoAwal.TabIndex = 29
        '
        'tglDariX
        '
        Me.tglDariX.EditValue = Nothing
        Me.tglDariX.Location = New System.Drawing.Point(3, 2)
        Me.tglDariX.Name = "tglDariX"
        Me.tglDariX.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglDariX.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDariX.Properties.Appearance.Options.UseBackColor = True
        Me.tglDariX.Properties.Appearance.Options.UseFont = True
        Me.tglDariX.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDariX.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDariX.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDariX.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglDariX.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDariX.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglDariX.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDariX.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDariX.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDariX.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDariX.Size = New System.Drawing.Size(208, 20)
        Me.tglDariX.TabIndex = 23
        '
        'CBEtipeTrans
        '
        Me.CBEtipeTrans.Location = New System.Drawing.Point(3, 24)
        Me.CBEtipeTrans.Name = "CBEtipeTrans"
        Me.CBEtipeTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBEtipeTrans.Properties.Items.AddRange(New Object() {"Pelunasan", "Permohonan"})
        Me.CBEtipeTrans.Properties.PopupSizeable = True
        Me.CBEtipeTrans.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CBEtipeTrans.Size = New System.Drawing.Size(208, 20)
        Me.CBEtipeTrans.TabIndex = 28
        '
        'Panel7
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel7, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel7.Controls.Add(Me.LabelControl4)
        Me.Panel7.Controls.Add(Me.LabelControl3)
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 91)
        Me.Panel7.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(59, 65)
        Me.LabelControl4.LookAndFeel.SkinName = "Black"
        Me.LabelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(77, 18)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Saldo Awal : "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(3, 22)
        Me.LabelControl3.LookAndFeel.SkinName = "Black"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(133, 21)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Tipe Transaksi : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(3, 1)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(133, 21)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Tanggal : "
        '
        'Panel12
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel12, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel12.BackColor = System.Drawing.Color.Maroon
        Me.Panel12.Controls.Add(Me.lblError1)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(932, 29)
        Me.Panel12.TabIndex = 14
        '
        'lblError1
        '
        Me.lblError1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError1.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError1.Appearance.Options.UseFont = True
        Me.lblError1.Appearance.Options.UseForeColor = True
        Me.lblError1.Location = New System.Drawing.Point(12, 6)
        Me.lblError1.Name = "lblError1"
        Me.lblError1.Size = New System.Drawing.Size(12, 16)
        Me.lblError1.TabIndex = 13
        Me.lblError1.Text = "..."
        '
        'Panel1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 37)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.lblJudul, DevExpress.Utils.DefaultBoolean.[Default])
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(459, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITORING TRANSAKSI KAS BON"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PictureBox1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnlGrid
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlGrid, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlGrid.BackColor = System.Drawing.Color.Maroon
        Me.pnlGrid.Controls.Add(Me.GC1)
        Me.pnlGrid.Controls.Add(Me.pnlGridLeft)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 160)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1109, 403)
        Me.pnlGrid.TabIndex = 8
        '
        'pnlGridLeft
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlGridLeft, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlGridLeft.Controls.Add(Me.CCKListBoxKolom)
        Me.pnlGridLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlGridLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlGridLeft.Name = "pnlGridLeft"
        Me.pnlGridLeft.Size = New System.Drawing.Size(136, 403)
        Me.pnlGridLeft.TabIndex = 0
        '
        'CCKListBoxKolom
        '
        Me.CCKListBoxKolom.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.CCKListBoxKolom.Appearance.ForeColor = System.Drawing.Color.White
        Me.CCKListBoxKolom.Appearance.Options.UseBackColor = True
        Me.CCKListBoxKolom.Appearance.Options.UseForeColor = True
        Me.CCKListBoxKolom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CCKListBoxKolom.Location = New System.Drawing.Point(0, 0)
        Me.CCKListBoxKolom.Name = "CCKListBoxKolom"
        Me.CCKListBoxKolom.Size = New System.Drawing.Size(136, 403)
        Me.CCKListBoxKolom.TabIndex = 28
        '
        'pnl
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnl, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnl.Controls.Add(Me.pnlGrid)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.Panel8)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1109, 592)
        Me.pnl.TabIndex = 5
        '
        'pnlFooter
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlFooter, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.Panel12)
        Me.pnlFooter.Controls.Add(Me.Panel10)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 563)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1109, 29)
        Me.pnlFooter.TabIndex = 2
        '
        'Panel10
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel10, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel10.BackColor = System.Drawing.Color.Maroon
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(932, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(177, 29)
        Me.Panel10.TabIndex = 13
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMonTransKasBon
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 592)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonTransKasBon"
        Me.Text = "frmMonTransKasBon"
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVrekening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVpusat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVkartu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.LOVtipeTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSampaiX.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSampaiX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.CENoPost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVvaluta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEPost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVjurnal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtSaldoAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDariX.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDariX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBEtipeTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGridLeft.ResumeLayout(False)
        CType(Me.CCKListBoxKolom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CENoPost As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEPost As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tglSampaiX As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents ResetCmd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Allcmd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CCKBOXSetting As System.Windows.Forms.CheckBox
    Friend WithEvents cmdExe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LOVvaluta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LOVjurnal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tglDariX As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lblError1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_jur2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVrekening As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_buku_pusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVpusat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents saldo_val_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_jur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVkartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlGridLeft As System.Windows.Forms.Panel
    Friend WithEvents CCKListBoxKolom As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LOVtipeTrans As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CBEtipeTrans As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoAwal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kredit As DevExpress.XtraGrid.Columns.GridColumn
End Class
