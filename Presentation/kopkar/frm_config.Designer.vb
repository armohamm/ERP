<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_config))
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GcINV_Ret = New DevExpress.XtraGrid.GridControl
        Me.GV_RLSKRD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.alamat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.telp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.web = New DevExpress.XtraGrid.Columns.GridColumn
        Me.norek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.level_apprv_realisasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_mainframe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.header1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ketua1_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_ketua1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ketua2_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_ketua2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ketua3_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_ketua3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ketua4_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_ketua4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.bendahara = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_bdhr = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kabag_sppj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_sp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kabag_keu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_keu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.bln_bns = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bln_thr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bln_tat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_ketua1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_ketua2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_ketua3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_ketua4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_bdhr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_sp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_keu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1370, 34)
        Me.Panel5.TabIndex = 2
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1370, 330)
        Me.pnl.TabIndex = 166
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GcINV_Ret)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 296)
        Me.Panel2.TabIndex = 3
        '
        'GcINV_Ret
        '
        Me.GcINV_Ret.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcINV_Ret.Location = New System.Drawing.Point(0, 0)
        Me.GcINV_Ret.MainView = Me.GV_RLSKRD
        Me.GcINV_Ret.Name = "GcINV_Ret"
        Me.GcINV_Ret.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_ketua1, Me.RL_ketua2, Me.RL_ketua3, Me.RL_ketua4, Me.RL_bdhr, Me.RL_sp, Me.RL_keu})
        Me.GcINV_Ret.Size = New System.Drawing.Size(1370, 296)
        Me.GcINV_Ret.TabIndex = 7
        Me.GcINV_Ret.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_RLSKRD})
        '
        'GV_RLSKRD
        '
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.Empty.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_RLSKRD.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_RLSKRD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseFont = True
        Me.GV_RLSKRD.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_RLSKRD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GV_RLSKRD.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV_RLSKRD.Appearance.Preview.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.Preview.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.Row.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.Row.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_RLSKRD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GV_RLSKRD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RLSKRD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_RLSKRD.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_RLSKRD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GV_RLSKRD.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_RLSKRD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nama, Me.alamat, Me.telp, Me.web, Me.norek, Me.level_apprv_realisasi, Me.no_mainframe, Me.header1, Me.ketua1_id, Me.ketua2_id, Me.ketua3_id, Me.ketua4_id, Me.bendahara, Me.kabag_sppj, Me.kabag_keu, Me.bln_bns, Me.bln_thr, Me.bln_tat})
        Me.GV_RLSKRD.GridControl = Me.GcINV_Ret
        Me.GV_RLSKRD.Name = "GV_RLSKRD"
        Me.GV_RLSKRD.OptionsCustomization.AllowColumnMoving = False
        Me.GV_RLSKRD.OptionsCustomization.AllowFilter = False
        Me.GV_RLSKRD.OptionsCustomization.AllowGroup = False
        Me.GV_RLSKRD.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_RLSKRD.OptionsView.ColumnAutoWidth = False
        Me.GV_RLSKRD.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_RLSKRD.OptionsView.EnableAppearanceOddRow = True
        Me.GV_RLSKRD.OptionsView.RowAutoHeight = True
        Me.GV_RLSKRD.OptionsView.ShowFooter = True
        Me.GV_RLSKRD.OptionsView.ShowGroupPanel = False
        Me.GV_RLSKRD.OptionsView.ShowViewCaption = True
        Me.GV_RLSKRD.ViewCaption = "KONFIGURASI APLIKASI"
        '
        'nama
        '
        Me.nama.Caption = "Nama"
        Me.nama.FieldName = "nama_perusahaan"
        Me.nama.Name = "nama"
        Me.nama.Visible = True
        Me.nama.VisibleIndex = 0
        '
        'alamat
        '
        Me.alamat.Caption = "Alamat"
        Me.alamat.FieldName = "alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.Visible = True
        Me.alamat.VisibleIndex = 1
        '
        'telp
        '
        Me.telp.Caption = "Telp"
        Me.telp.FieldName = "telp"
        Me.telp.Name = "telp"
        Me.telp.Visible = True
        Me.telp.VisibleIndex = 2
        '
        'web
        '
        Me.web.Caption = "Website"
        Me.web.FieldName = "web"
        Me.web.Name = "web"
        Me.web.Visible = True
        Me.web.VisibleIndex = 3
        '
        'norek
        '
        Me.norek.Caption = "No Rekening"
        Me.norek.FieldName = "norek"
        Me.norek.Name = "norek"
        Me.norek.Visible = True
        Me.norek.VisibleIndex = 4
        '
        'level_apprv_realisasi
        '
        Me.level_apprv_realisasi.Caption = "Approve Level"
        Me.level_apprv_realisasi.FieldName = "level_apprv_realisasi"
        Me.level_apprv_realisasi.Name = "level_apprv_realisasi"
        '
        'no_mainframe
        '
        Me.no_mainframe.Caption = "No MesinMainFrame"
        Me.no_mainframe.FieldName = "no_mainframe"
        Me.no_mainframe.Name = "no_mainframe"
        Me.no_mainframe.Visible = True
        Me.no_mainframe.VisibleIndex = 5
        Me.no_mainframe.Width = 107
        '
        'header1
        '
        Me.header1.Caption = "Header"
        Me.header1.FieldName = "header1"
        Me.header1.Name = "header1"
        Me.header1.Visible = True
        Me.header1.VisibleIndex = 6
        '
        'ketua1_id
        '
        Me.ketua1_id.Caption = "ketua1"
        Me.ketua1_id.ColumnEdit = Me.RL_ketua1
        Me.ketua1_id.FieldName = "ketua1_id"
        Me.ketua1_id.Name = "ketua1_id"
        Me.ketua1_id.Visible = True
        Me.ketua1_id.VisibleIndex = 7
        '
        'RL_ketua1
        '
        Me.RL_ketua1.AutoHeight = False
        Me.RL_ketua1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_ketua1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RL_ketua1.Name = "RL_ketua1"
        Me.RL_ketua1.NullText = ""
        '
        'ketua2_id
        '
        Me.ketua2_id.Caption = "Ketua 2"
        Me.ketua2_id.ColumnEdit = Me.RL_ketua2
        Me.ketua2_id.FieldName = "ketua2_id"
        Me.ketua2_id.Name = "ketua2_id"
        Me.ketua2_id.Visible = True
        Me.ketua2_id.VisibleIndex = 8
        '
        'RL_ketua2
        '
        Me.RL_ketua2.AutoHeight = False
        Me.RL_ketua2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_ketua2.Name = "RL_ketua2"
        Me.RL_ketua2.NullText = ""
        '
        'ketua3_id
        '
        Me.ketua3_id.Caption = "Ketua 3"
        Me.ketua3_id.ColumnEdit = Me.RL_ketua3
        Me.ketua3_id.FieldName = "ketua3_id"
        Me.ketua3_id.Name = "ketua3_id"
        Me.ketua3_id.Visible = True
        Me.ketua3_id.VisibleIndex = 9
        '
        'RL_ketua3
        '
        Me.RL_ketua3.AutoHeight = False
        Me.RL_ketua3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_ketua3.Name = "RL_ketua3"
        Me.RL_ketua3.NullText = ""
        '
        'ketua4_id
        '
        Me.ketua4_id.Caption = "Ketua 4"
        Me.ketua4_id.ColumnEdit = Me.RL_ketua4
        Me.ketua4_id.FieldName = "ketua4_id"
        Me.ketua4_id.Name = "ketua4_id"
        Me.ketua4_id.Visible = True
        Me.ketua4_id.VisibleIndex = 10
        '
        'RL_ketua4
        '
        Me.RL_ketua4.AutoHeight = False
        Me.RL_ketua4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_ketua4.Name = "RL_ketua4"
        Me.RL_ketua4.NullText = ""
        '
        'bendahara
        '
        Me.bendahara.Caption = "Bendahara"
        Me.bendahara.ColumnEdit = Me.RL_bdhr
        Me.bendahara.FieldName = "bendahara"
        Me.bendahara.Name = "bendahara"
        Me.bendahara.Visible = True
        Me.bendahara.VisibleIndex = 11
        '
        'RL_bdhr
        '
        Me.RL_bdhr.AutoHeight = False
        Me.RL_bdhr.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_bdhr.Name = "RL_bdhr"
        Me.RL_bdhr.NullText = ""
        '
        'kabag_sppj
        '
        Me.kabag_sppj.Caption = "Kabag Simpan Pinjam"
        Me.kabag_sppj.ColumnEdit = Me.RL_sp
        Me.kabag_sppj.FieldName = "kabag_sppj"
        Me.kabag_sppj.Name = "kabag_sppj"
        Me.kabag_sppj.Visible = True
        Me.kabag_sppj.VisibleIndex = 12
        '
        'RL_sp
        '
        Me.RL_sp.AutoHeight = False
        Me.RL_sp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_sp.Name = "RL_sp"
        Me.RL_sp.NullText = ""
        '
        'kabag_keu
        '
        Me.kabag_keu.Caption = "Kabag Keuangan"
        Me.kabag_keu.ColumnEdit = Me.RL_keu
        Me.kabag_keu.FieldName = "kabag_keu"
        Me.kabag_keu.Name = "kabag_keu"
        Me.kabag_keu.Visible = True
        Me.kabag_keu.VisibleIndex = 13
        '
        'RL_keu
        '
        Me.RL_keu.AutoHeight = False
        Me.RL_keu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_keu.Name = "RL_keu"
        Me.RL_keu.NullText = ""
        '
        'bln_bns
        '
        Me.bln_bns.Caption = "Bln Debet Bonus"
        Me.bln_bns.FieldName = "tgl_bns"
        Me.bln_bns.Name = "bln_bns"
        Me.bln_bns.Visible = True
        Me.bln_bns.VisibleIndex = 14
        Me.bln_bns.Width = 90
        '
        'bln_thr
        '
        Me.bln_thr.Caption = "bln Debet THR"
        Me.bln_thr.FieldName = "tgl_thr"
        Me.bln_thr.Name = "bln_thr"
        Me.bln_thr.Visible = True
        Me.bln_thr.VisibleIndex = 15
        Me.bln_thr.Width = 81
        '
        'bln_tat
        '
        Me.bln_tat.Caption = "bln debet TAT"
        Me.bln_tat.FieldName = "tgl_tat"
        Me.bln_tat.Name = "bln_tat"
        Me.bln_tat.Visible = True
        Me.bln_tat.VisibleIndex = 16
        Me.bln_tat.Width = 79
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 38)
        Me.Panel1.TabIndex = 165
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
        Me.Label1.Size = New System.Drawing.Size(633, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          KONFIGURASI APLIKASI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'frm_config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 368)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_config"
        Me.Text = "frm_config"
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_ketua1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_ketua2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_ketua3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_ketua4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_bdhr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_sp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_keu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GcINV_Ret As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_RLSKRD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents alamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents telp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents web As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents norek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents level_apprv_realisasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_mainframe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents header1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_ketua1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ketua1_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ketua2_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ketua3_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ketua4_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bendahara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kabag_sppj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kabag_keu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_ketua2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_ketua3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_ketua4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_bdhr As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_sp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_keu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bln_bns As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bln_thr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bln_tat As DevExpress.XtraGrid.Columns.GridColumn
End Class
