<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerivyRTL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerivyRTL))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GcINV_Ret = New DevExpress.XtraGrid.GridControl
        Me.GV_RLSKRD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_NoPengajuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RLnama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_PINJAMAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LAMA_ANGS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.approve1_by = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Cb_Approve = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.approve2_by = New DevExpress.XtraGrid.Columns.GridColumn
        Me.approve3_by = New DevExpress.XtraGrid.Columns.GridColumn
        Me.approve4_by = New DevExpress.XtraGrid.Columns.GridColumn
        Me.approve1_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.approve2_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.approve3_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.approve4_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LUE_RekeningRealisasi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.stat_cair_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Btn_pilih = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label33 = New System.Windows.Forms.Label
        Me.LUE_Bank = New DevExpress.XtraEditors.LookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cb_Approve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_RekeningRealisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.LUE_Bank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 296)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1036, 25)
        Me.Panel4.TabIndex = 1
        '
        'GcINV_Ret
        '
        Me.GcINV_Ret.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcINV_Ret.Location = New System.Drawing.Point(0, 0)
        Me.GcINV_Ret.MainView = Me.GV_RLSKRD
        Me.GcINV_Ret.Name = "GcINV_Ret"
        Me.GcINV_Ret.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Cb_Approve, Me.RLnama, Me.LUE_RekeningRealisasi})
        Me.GcINV_Ret.Size = New System.Drawing.Size(1036, 249)
        Me.GcINV_Ret.TabIndex = 6
        Me.GcINV_Ret.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_RLSKRD})
        '
        'GV_RLSKRD
        '
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.Empty.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GV_RLSKRD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GV_RLSKRD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GV_RLSKRD.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GV_RLSKRD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_RLSKRD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Preview.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.Preview.Options.UseFont = True
        Me.GV_RLSKRD.Appearance.Preview.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.Row.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.Row.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.Row.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GV_RLSKRD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_RLSKRD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GV_RLSKRD.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.Col_NoPengajuan, Me.tgl_trans, Me.nasabah_id, Me.Nama, Me.jenis, Me.JML_PINJAMAN, Me.LAMA_ANGS, Me.approve1_by, Me.approve2_by, Me.approve3_by, Me.approve4_by, Me.approve1_date, Me.approve2_date, Me.approve3_date, Me.approve4_date, Me.GridColumn1, Me.stat_cair_approve})
        Me.GV_RLSKRD.GridControl = Me.GcINV_Ret
        Me.GV_RLSKRD.Name = "GV_RLSKRD"
        Me.GV_RLSKRD.OptionsCustomization.AllowColumnMoving = False
        Me.GV_RLSKRD.OptionsCustomization.AllowGroup = False
        Me.GV_RLSKRD.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_RLSKRD.OptionsView.ColumnAutoWidth = False
        Me.GV_RLSKRD.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_RLSKRD.OptionsView.EnableAppearanceOddRow = True
        Me.GV_RLSKRD.OptionsView.RowAutoHeight = True
        Me.GV_RLSKRD.OptionsView.ShowFooter = True
        Me.GV_RLSKRD.OptionsView.ShowGroupPanel = False
        Me.GV_RLSKRD.OptionsView.ShowViewCaption = True
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
        Me.nomer.OptionsColumn.AllowEdit = False
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 34
        '
        'Col_NoPengajuan
        '
        Me.Col_NoPengajuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Col_NoPengajuan.AppearanceHeader.Options.UseFont = True
        Me.Col_NoPengajuan.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_NoPengajuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_NoPengajuan.Caption = "No. Pengajuan"
        Me.Col_NoPengajuan.FieldName = "no_trans"
        Me.Col_NoPengajuan.Name = "Col_NoPengajuan"
        Me.Col_NoPengajuan.OptionsColumn.AllowEdit = False
        Me.Col_NoPengajuan.Visible = True
        Me.Col_NoPengajuan.VisibleIndex = 1
        Me.Col_NoPengajuan.Width = 92
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
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 2
        Me.tgl_trans.Width = 64
        '
        'nasabah_id
        '
        Me.nasabah_id.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nasabah_id.AppearanceHeader.Options.UseFont = True
        Me.nasabah_id.AppearanceHeader.Options.UseTextOptions = True
        Me.nasabah_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nasabah_id.Caption = "ID Nasabah"
        Me.nasabah_id.FieldName = "nasabah_id"
        Me.nasabah_id.Name = "nasabah_id"
        Me.nasabah_id.OptionsColumn.AllowEdit = False
        Me.nasabah_id.OptionsColumn.ReadOnly = True
        Me.nasabah_id.Visible = True
        Me.nasabah_id.VisibleIndex = 3
        Me.nasabah_id.Width = 76
        '
        'Nama
        '
        Me.Nama.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Nama.AppearanceHeader.Options.UseFont = True
        Me.Nama.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama.Caption = "Nama"
        Me.Nama.ColumnEdit = Me.RLnama
        Me.Nama.FieldName = "nasabah_id"
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.ReadOnly = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 4
        Me.Nama.Width = 169
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
        Me.jenis.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jenis.AppearanceHeader.Options.UseFont = True
        Me.jenis.AppearanceHeader.Options.UseTextOptions = True
        Me.jenis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jenis.Caption = "Jenis"
        Me.jenis.FieldName = "jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.OptionsColumn.AllowEdit = False
        Me.jenis.OptionsColumn.ReadOnly = True
        Me.jenis.OptionsFilter.AllowFilter = False
        Me.jenis.Visible = True
        Me.jenis.VisibleIndex = 5
        Me.jenis.Width = 41
        '
        'JML_PINJAMAN
        '
        Me.JML_PINJAMAN.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JML_PINJAMAN.AppearanceHeader.Options.UseFont = True
        Me.JML_PINJAMAN.AppearanceHeader.Options.UseTextOptions = True
        Me.JML_PINJAMAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.JML_PINJAMAN.Caption = "Jml Pinjaman"
        Me.JML_PINJAMAN.DisplayFormat.FormatString = "N2"
        Me.JML_PINJAMAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_PINJAMAN.FieldName = "JML_PINJAMAN"
        Me.JML_PINJAMAN.Name = "JML_PINJAMAN"
        Me.JML_PINJAMAN.OptionsColumn.AllowEdit = False
        Me.JML_PINJAMAN.OptionsColumn.ReadOnly = True
        Me.JML_PINJAMAN.OptionsFilter.AllowFilter = False
        Me.JML_PINJAMAN.Visible = True
        Me.JML_PINJAMAN.VisibleIndex = 6
        Me.JML_PINJAMAN.Width = 101
        '
        'LAMA_ANGS
        '
        Me.LAMA_ANGS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LAMA_ANGS.AppearanceHeader.Options.UseFont = True
        Me.LAMA_ANGS.AppearanceHeader.Options.UseTextOptions = True
        Me.LAMA_ANGS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LAMA_ANGS.Caption = "Lama Angsuran"
        Me.LAMA_ANGS.FieldName = "LAMA_ANGS"
        Me.LAMA_ANGS.Name = "LAMA_ANGS"
        Me.LAMA_ANGS.OptionsColumn.AllowEdit = False
        Me.LAMA_ANGS.OptionsColumn.ReadOnly = True
        Me.LAMA_ANGS.OptionsFilter.AllowFilter = False
        Me.LAMA_ANGS.SummaryItem.FieldName = "rp_trans"
        Me.LAMA_ANGS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.LAMA_ANGS.Visible = True
        Me.LAMA_ANGS.VisibleIndex = 7
        Me.LAMA_ANGS.Width = 133
        '
        'approve1_by
        '
        Me.approve1_by.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.approve1_by.AppearanceHeader.Options.UseFont = True
        Me.approve1_by.AppearanceHeader.Options.UseTextOptions = True
        Me.approve1_by.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.approve1_by.Caption = "Approve 1"
        Me.approve1_by.ColumnEdit = Me.Cb_Approve
        Me.approve1_by.FieldName = "approve1_by"
        Me.approve1_by.Name = "approve1_by"
        Me.approve1_by.OptionsColumn.AllowEdit = False
        Me.approve1_by.OptionsFilter.AllowFilter = False
        Me.approve1_by.Width = 78
        '
        'Cb_Approve
        '
        Me.Cb_Approve.AutoHeight = False
        Me.Cb_Approve.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cb_Approve.Items.AddRange(New Object() {"APPROVE", "REJECT"})
        Me.Cb_Approve.Name = "Cb_Approve"
        '
        'approve2_by
        '
        Me.approve2_by.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.approve2_by.AppearanceHeader.Options.UseFont = True
        Me.approve2_by.AppearanceHeader.Options.UseTextOptions = True
        Me.approve2_by.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.approve2_by.Caption = "Approve 2"
        Me.approve2_by.ColumnEdit = Me.Cb_Approve
        Me.approve2_by.FieldName = "approve2_by"
        Me.approve2_by.Name = "approve2_by"
        Me.approve2_by.OptionsColumn.AllowEdit = False
        Me.approve2_by.OptionsFilter.AllowFilter = False
        Me.approve2_by.Width = 76
        '
        'approve3_by
        '
        Me.approve3_by.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.approve3_by.AppearanceHeader.Options.UseFont = True
        Me.approve3_by.AppearanceHeader.Options.UseTextOptions = True
        Me.approve3_by.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.approve3_by.Caption = "Approve 3"
        Me.approve3_by.ColumnEdit = Me.Cb_Approve
        Me.approve3_by.FieldName = "approve3_by"
        Me.approve3_by.Name = "approve3_by"
        Me.approve3_by.OptionsColumn.AllowEdit = False
        Me.approve3_by.OptionsFilter.AllowFilter = False
        '
        'approve4_by
        '
        Me.approve4_by.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.approve4_by.AppearanceHeader.Options.UseFont = True
        Me.approve4_by.AppearanceHeader.Options.UseTextOptions = True
        Me.approve4_by.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.approve4_by.Caption = "Approve 4"
        Me.approve4_by.ColumnEdit = Me.Cb_Approve
        Me.approve4_by.FieldName = "approve4_by"
        Me.approve4_by.Name = "approve4_by"
        Me.approve4_by.OptionsColumn.AllowEdit = False
        Me.approve4_by.OptionsFilter.AllowFilter = False
        Me.approve4_by.Width = 72
        '
        'approve1_date
        '
        Me.approve1_date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.approve1_date.AppearanceHeader.Options.UseFont = True
        Me.approve1_date.AppearanceHeader.Options.UseTextOptions = True
        Me.approve1_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.approve1_date.Caption = "Tgl Approve 1"
        Me.approve1_date.FieldName = "approve1_date"
        Me.approve1_date.Name = "approve1_date"
        Me.approve1_date.OptionsColumn.AllowEdit = False
        Me.approve1_date.OptionsFilter.AllowFilter = False
        Me.approve1_date.Width = 82
        '
        'approve2_date
        '
        Me.approve2_date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.approve2_date.AppearanceHeader.Options.UseFont = True
        Me.approve2_date.AppearanceHeader.Options.UseTextOptions = True
        Me.approve2_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.approve2_date.Caption = "Tgl Approve 2"
        Me.approve2_date.FieldName = "approve2_date"
        Me.approve2_date.Name = "approve2_date"
        Me.approve2_date.OptionsColumn.AllowEdit = False
        Me.approve2_date.OptionsFilter.AllowFilter = False
        Me.approve2_date.Width = 85
        '
        'approve3_date
        '
        Me.approve3_date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.approve3_date.AppearanceHeader.Options.UseFont = True
        Me.approve3_date.AppearanceHeader.Options.UseTextOptions = True
        Me.approve3_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.approve3_date.Caption = "Tgl Approve 3"
        Me.approve3_date.FieldName = "approve3_date"
        Me.approve3_date.Name = "approve3_date"
        Me.approve3_date.OptionsColumn.AllowEdit = False
        Me.approve3_date.OptionsFilter.AllowFilter = False
        Me.approve3_date.Width = 89
        '
        'approve4_date
        '
        Me.approve4_date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.approve4_date.AppearanceHeader.Options.UseFont = True
        Me.approve4_date.AppearanceHeader.Options.UseTextOptions = True
        Me.approve4_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.approve4_date.Caption = "Tgl Approve 4"
        Me.approve4_date.FieldName = "approve4_date"
        Me.approve4_date.Name = "approve4_date"
        Me.approve4_date.OptionsColumn.AllowEdit = False
        Me.approve4_date.OptionsFilter.AllowFilter = False
        Me.approve4_date.Width = 89
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Rekening Sumber Pencairan"
        Me.GridColumn1.ColumnEdit = Me.LUE_RekeningRealisasi
        Me.GridColumn1.FieldName = "rek_pencairan"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        Me.GridColumn1.Width = 170
        '
        'LUE_RekeningRealisasi
        '
        Me.LUE_RekeningRealisasi.AutoHeight = False
        Me.LUE_RekeningRealisasi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_RekeningRealisasi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode Buku Besar"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", 40, "Nama Buku Besar")})
        Me.LUE_RekeningRealisasi.DisplayMember = "nm_buku_besar"
        Me.LUE_RekeningRealisasi.Name = "LUE_RekeningRealisasi"
        Me.LUE_RekeningRealisasi.NullText = "[Pilih Rekening Bank]"
        Me.LUE_RekeningRealisasi.ValueMember = "kd_buku_besar"
        '
        'stat_cair_approve
        '
        Me.stat_cair_approve.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.stat_cair_approve.AppearanceHeader.Options.UseFont = True
        Me.stat_cair_approve.AppearanceHeader.Options.UseTextOptions = True
        Me.stat_cair_approve.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.stat_cair_approve.Caption = "Check Approve"
        Me.stat_cair_approve.FieldName = "stat_cair_approve"
        Me.stat_cair_approve.Name = "stat_cair_approve"
        Me.stat_cair_approve.OptionsFilter.AllowFilter = False
        Me.stat_cair_approve.Visible = True
        Me.stat_cair_approve.VisibleIndex = 9
        Me.stat_cair_approve.Width = 118
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcINV_Ret)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 47)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1036, 249)
        Me.Panel5.TabIndex = 2
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
        Me.Panel1.Size = New System.Drawing.Size(1036, 38)
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
        Me.Label1.Size = New System.Drawing.Size(718, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         VERIFIKASI BANK / KAS PENCAIRAN PINJAMAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
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
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SimpleButton1)
        Me.Panel3.Controls.Add(Me.Btn_pilih)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1036, 47)
        Me.Panel3.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton1.ImageIndex = 5
        Me.SimpleButton1.ImageList = Me.img
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton1.Location = New System.Drawing.Point(740, 0)
        Me.SimpleButton1.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(89, 47)
        Me.SimpleButton1.TabIndex = 44
        Me.SimpleButton1.Text = "REFRESH"
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
        'Btn_pilih
        '
        Me.Btn_pilih.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_pilih.ImageIndex = 3
        Me.Btn_pilih.ImageList = Me.img
        Me.Btn_pilih.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Btn_pilih.Location = New System.Drawing.Point(551, 0)
        Me.Btn_pilih.LookAndFeel.SkinName = "The Asphalt World"
        Me.Btn_pilih.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Btn_pilih.Name = "Btn_pilih"
        Me.Btn_pilih.Size = New System.Drawing.Size(189, 47)
        Me.Btn_pilih.TabIndex = 43
        Me.Btn_pilih.Text = "Approve All"
        Me.Btn_pilih.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.ImageIndex = 6
        Me.cmdRefresh.ImageList = Me.img
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdRefresh.Location = New System.Drawing.Point(404, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(147, 47)
        Me.cmdRefresh.TabIndex = 42
        Me.cmdRefresh.Text = "Set Bank"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.LUE_Bank)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 47)
        Me.Panel2.TabIndex = 41
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label33.Location = New System.Drawing.Point(162, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 13)
        Me.Label33.TabIndex = 51
        Me.Label33.Text = "BANK:"
        '
        'LUE_Bank
        '
        Me.LUE_Bank.Location = New System.Drawing.Point(205, 13)
        Me.LUE_Bank.Name = "LUE_Bank"
        Me.LUE_Bank.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LUE_Bank.Properties.Appearance.Options.UseBackColor = True
        Me.LUE_Bank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_Bank.Properties.NullText = "[klik disini]"
        Me.LUE_Bank.Size = New System.Drawing.Size(193, 20)
        Me.LUE_Bank.TabIndex = 50
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
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
        Me.pnl.Size = New System.Drawing.Size(1036, 321)
        Me.pnl.TabIndex = 158
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'frmVerivyRTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 359)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmVerivyRTL"
        Me.Text = "frmVerivyRTL"
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cb_Approve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_RekeningRealisasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.LUE_Bank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GcINV_Ret As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_RLSKRD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nasabah_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RLnama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_PINJAMAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LAMA_ANGS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents approve1_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cb_Approve As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents approve2_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents approve3_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents approve4_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents approve1_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents approve2_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents approve3_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents approve4_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents stat_cair_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NoPengajuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LUE_RekeningRealisasi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents Btn_pilih As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents LUE_Bank As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
