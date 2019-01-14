<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApproveDPM1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApproveDPM1))
        Me.GcApprvDPM = New DevExpress.XtraGrid.GridControl
        Me.GVApprvDPM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Departemen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupDivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.No_DPM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_DPM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RBrecstat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.ket_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GCInfo = New DevExpress.XtraGrid.GridControl
        Me.GVInfo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlGrid2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlGrid1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExe = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LOVstatus = New DevExpress.XtraEditors.LookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        CType(Me.GcApprvDPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrid2.SuspendLayout()
        Me.pnlGrid1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.LOVstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GcApprvDPM
        '
        Me.GcApprvDPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcApprvDPM.Location = New System.Drawing.Point(0, 34)
        Me.GcApprvDPM.MainView = Me.GVApprvDPM
        Me.GcApprvDPM.Name = "GcApprvDPM"
        Me.GcApprvDPM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupDivisi, Me.RBrecstat})
        Me.GcApprvDPM.Size = New System.Drawing.Size(1005, 239)
        Me.GcApprvDPM.TabIndex = 137
        Me.GcApprvDPM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVApprvDPM})
        '
        'GVApprvDPM
        '
        Me.GVApprvDPM.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.Empty.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVApprvDPM.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVApprvDPM.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVApprvDPM.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseFont = True
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVApprvDPM.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVApprvDPM.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.OddRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.OddRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVApprvDPM.Appearance.Preview.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.Preview.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.Row.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.Row.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVApprvDPM.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVApprvDPM.Appearance.VertLine.Options.UseBackColor = True
        Me.GVApprvDPM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipe_trans, Me.Departemen, Me.No_DPM, Me.Tgl_DPM, Me.Keterangan, Me.rec_stat, Me.ket_approve})
        Me.GVApprvDPM.GridControl = Me.GcApprvDPM
        Me.GVApprvDPM.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVApprvDPM.Name = "GVApprvDPM"
        Me.GVApprvDPM.OptionsView.EnableAppearanceEvenRow = True
        Me.GVApprvDPM.OptionsView.EnableAppearanceOddRow = True
        Me.GVApprvDPM.OptionsView.RowAutoHeight = True
        Me.GVApprvDPM.OptionsView.ShowFooter = True
        Me.GVApprvDPM.OptionsView.ShowGroupPanel = False
        Me.GVApprvDPM.PaintStyleName = "Office2003"
        Me.GVApprvDPM.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_trans.Caption = "Jenis DPM"
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.OptionsColumn.AllowEdit = False
        Me.tipe_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 0
        Me.tipe_trans.Width = 91
        '
        'Departemen
        '
        Me.Departemen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departemen.AppearanceHeader.Options.UseFont = True
        Me.Departemen.AppearanceHeader.Options.UseTextOptions = True
        Me.Departemen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Departemen.Caption = "Divisi"
        Me.Departemen.ColumnEdit = Me.lookupDivisi
        Me.Departemen.FieldName = "Departemen"
        Me.Departemen.Name = "Departemen"
        Me.Departemen.OptionsColumn.AllowEdit = False
        Me.Departemen.Visible = True
        Me.Departemen.VisibleIndex = 1
        Me.Departemen.Width = 174
        '
        'lookupDivisi
        '
        Me.lookupDivisi.AutoHeight = False
        Me.lookupDivisi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupDivisi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Divisi")})
        Me.lookupDivisi.Name = "lookupDivisi"
        Me.lookupDivisi.NullText = "Klik disini"
        '
        'No_DPM
        '
        Me.No_DPM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_DPM.AppearanceHeader.Options.UseFont = True
        Me.No_DPM.AppearanceHeader.Options.UseTextOptions = True
        Me.No_DPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_DPM.Caption = "No DPM"
        Me.No_DPM.FieldName = "No_DPM"
        Me.No_DPM.Name = "No_DPM"
        Me.No_DPM.OptionsColumn.AllowEdit = False
        Me.No_DPM.Visible = True
        Me.No_DPM.VisibleIndex = 2
        Me.No_DPM.Width = 112
        '
        'Tgl_DPM
        '
        Me.Tgl_DPM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tgl_DPM.AppearanceHeader.Options.UseFont = True
        Me.Tgl_DPM.AppearanceHeader.Options.UseTextOptions = True
        Me.Tgl_DPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Tgl_DPM.Caption = "Tanggal"
        Me.Tgl_DPM.FieldName = "Tgl_DPM"
        Me.Tgl_DPM.Name = "Tgl_DPM"
        Me.Tgl_DPM.OptionsColumn.AllowEdit = False
        Me.Tgl_DPM.Visible = True
        Me.Tgl_DPM.VisibleIndex = 3
        Me.Tgl_DPM.Width = 77
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.OptionsColumn.AllowEdit = False
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 4
        Me.Keterangan.Width = 256
        '
        'rec_stat
        '
        Me.rec_stat.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.rec_stat.AppearanceCell.Options.UseBackColor = True
        Me.rec_stat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rec_stat.AppearanceHeader.Options.UseFont = True
        Me.rec_stat.AppearanceHeader.Options.UseTextOptions = True
        Me.rec_stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rec_stat.Caption = "Approval"
        Me.rec_stat.ColumnEdit = Me.RBrecstat
        Me.rec_stat.FieldName = "rec_stat"
        Me.rec_stat.Name = "rec_stat"
        Me.rec_stat.Visible = True
        Me.rec_stat.VisibleIndex = 5
        Me.rec_stat.Width = 101
        '
        'RBrecstat
        '
        Me.RBrecstat.AutoHeight = False
        Me.RBrecstat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RBrecstat.Items.AddRange(New Object() {"APPROVE", "REJECT"})
        Me.RBrecstat.Name = "RBrecstat"
        '
        'ket_approve
        '
        Me.ket_approve.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ket_approve.AppearanceHeader.Options.UseFont = True
        Me.ket_approve.AppearanceHeader.Options.UseTextOptions = True
        Me.ket_approve.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ket_approve.Caption = "Alasan Reject"
        Me.ket_approve.FieldName = "ket_approve"
        Me.ket_approve.MinWidth = 100
        Me.ket_approve.Name = "ket_approve"
        Me.ket_approve.Visible = True
        Me.ket_approve.VisibleIndex = 6
        Me.ket_approve.Width = 160
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GCInfo
        '
        Me.GCInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCInfo.Location = New System.Drawing.Point(0, 0)
        Me.GCInfo.MainView = Me.GVInfo
        Me.GCInfo.Name = "GCInfo"
        Me.GCInfo.Size = New System.Drawing.Size(1005, 173)
        Me.GCInfo.TabIndex = 0
        Me.GCInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVInfo})
        '
        'GVInfo
        '
        Me.GVInfo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVInfo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVInfo.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVInfo.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVInfo.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVInfo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVInfo.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GVInfo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVInfo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVInfo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVInfo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVInfo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVInfo.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVInfo.Appearance.Empty.Options.UseBackColor = True
        Me.GVInfo.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVInfo.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVInfo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVInfo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVInfo.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVInfo.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVInfo.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVInfo.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVInfo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVInfo.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVInfo.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVInfo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVInfo.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVInfo.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVInfo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVInfo.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVInfo.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVInfo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVInfo.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVInfo.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVInfo.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVInfo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVInfo.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVInfo.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVInfo.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVInfo.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVInfo.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVInfo.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVInfo.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVInfo.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVInfo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVInfo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVInfo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVInfo.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVInfo.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVInfo.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVInfo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVInfo.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVInfo.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVInfo.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVInfo.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVInfo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVInfo.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVInfo.Appearance.GroupRow.Options.UseFont = True
        Me.GVInfo.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVInfo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVInfo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVInfo.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVInfo.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVInfo.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVInfo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVInfo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVInfo.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVInfo.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVInfo.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVInfo.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVInfo.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVInfo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.OddRow.Options.UseBackColor = True
        Me.GVInfo.Appearance.OddRow.Options.UseForeColor = True
        Me.GVInfo.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVInfo.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVInfo.Appearance.Preview.Options.UseBackColor = True
        Me.GVInfo.Appearance.Preview.Options.UseForeColor = True
        Me.GVInfo.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVInfo.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVInfo.Appearance.Row.Options.UseBackColor = True
        Me.GVInfo.Appearance.Row.Options.UseForeColor = True
        Me.GVInfo.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVInfo.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVInfo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVInfo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVInfo.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVInfo.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVInfo.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVInfo.Appearance.VertLine.Options.UseBackColor = True
        Me.GVInfo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GVInfo.GridControl = Me.GCInfo
        Me.GVInfo.Name = "GVInfo"
        Me.GVInfo.OptionsBehavior.Editable = False
        Me.GVInfo.OptionsView.EnableAppearanceEvenRow = True
        Me.GVInfo.OptionsView.EnableAppearanceOddRow = True
        Me.GVInfo.OptionsView.ShowFooter = True
        Me.GVInfo.OptionsView.ShowGroupPanel = False
        Me.GVInfo.OptionsView.ShowViewCaption = True
        Me.GVInfo.ViewCaption = "Info Detail DPM"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "No"
        Me.GridColumn1.FieldName = "No_Seq"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 37
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Barang"
        Me.GridColumn2.FieldName = "Nama_Barang"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 255
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Spek"
        Me.GridColumn3.FieldName = "spek_brg"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 194
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Satuan"
        Me.GridColumn4.FieldName = "Satuan"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 67
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Jumlah"
        Me.GridColumn5.FieldName = "Qty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 77
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Keterangan"
        Me.GridColumn6.FieldName = "Keterangan"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 103
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Tanggal Perlu"
        Me.GridColumn7.FieldName = "Tgl_Diperlukan"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 105
        '
        'pnlGrid2
        '
        Me.pnlGrid2.BackColor = System.Drawing.Color.Transparent
        Me.pnlGrid2.Controls.Add(Me.GCInfo)
        Me.pnlGrid2.Controls.Add(Me.Panel1)
        Me.pnlGrid2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlGrid2.Location = New System.Drawing.Point(0, 307)
        Me.pnlGrid2.Name = "pnlGrid2"
        Me.pnlGrid2.Size = New System.Drawing.Size(1005, 207)
        Me.pnlGrid2.TabIndex = 138
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 173)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 34)
        Me.Panel1.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(44, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM APPROVAL DPM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlGrid1
        '
        Me.pnlGrid1.BackColor = System.Drawing.Color.Maroon
        Me.pnlGrid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGrid1.Controls.Add(Me.PictureBox1)
        Me.pnlGrid1.Controls.Add(Me.Label1)
        Me.pnlGrid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGrid1.Location = New System.Drawing.Point(0, 0)
        Me.pnlGrid1.Name = "pnlGrid1"
        Me.pnlGrid1.Size = New System.Drawing.Size(1005, 34)
        Me.pnlGrid1.TabIndex = 137
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GcApprvDPM)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1005, 273)
        Me.Panel3.TabIndex = 139
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.SimpleButton1)
        Me.Panel4.Controls.Add(Me.cmdExe)
        Me.Panel4.Controls.Add(Me.LabelControl1)
        Me.Panel4.Controls.Add(Me.LOVstatus)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1005, 34)
        Me.Panel4.TabIndex = 138
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(281, 2)
        Me.SimpleButton1.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(52, 28)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "Semua"
        Me.SimpleButton1.ToolTip = "Eksekusi Pencarian"
        Me.SimpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.SimpleButton1.ToolTipTitle = "SEARCH"
        '
        'cmdExe
        '
        Me.cmdExe.Image = CType(resources.GetObject("cmdExe.Image"), System.Drawing.Image)
        Me.cmdExe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExe.Location = New System.Drawing.Point(247, 2)
        Me.cmdExe.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdExe.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExe.Name = "cmdExe"
        Me.cmdExe.Size = New System.Drawing.Size(28, 28)
        Me.cmdExe.TabIndex = 11
        Me.cmdExe.ToolTip = "Eksekusi Pencarian"
        Me.cmdExe.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdExe.ToolTipTitle = "SEARCH"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Filter :"
        '
        'LOVstatus
        '
        Me.LOVstatus.Location = New System.Drawing.Point(49, 5)
        Me.LOVstatus.Name = "LOVstatus"
        Me.LOVstatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVstatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("rec_stat", "Status")})
        Me.LOVstatus.Properties.NullText = ""
        Me.LOVstatus.Size = New System.Drawing.Size(192, 20)
        Me.LOVstatus.TabIndex = 0
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.pnlGrid1)
        Me.pnl.Controls.Add(Me.pnlGrid2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1005, 514)
        Me.pnl.TabIndex = 1
        '
        'FrmApproveDPM1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 514)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmApproveDPM1"
        Me.Text = "FrmApproveDPM1"
        CType(Me.GcApprvDPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrid2.ResumeLayout(False)
        Me.pnlGrid1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.LOVstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GcApprvDPM As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVApprvDPM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Departemen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupDivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents No_DPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tgl_DPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RBrecstat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ket_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GCInfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVInfo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlGrid2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlGrid1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LOVstatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExe As DevExpress.XtraEditors.SimpleButton
End Class
