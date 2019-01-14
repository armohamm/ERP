<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDpsCair
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDpsCair))
        Me.RL_kdTrans = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RLnama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Gc_nabung = New DevExpress.XtraGrid.GridControl
        Me.GV_nabung = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.URUTAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_TABUNGAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TGL_TRANS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KODE_TRANS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NASABAH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SALDO_AWAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SALDO_TRANS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SALDO_AKHIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_bunga_jln = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.lb1_bg_jln = New System.Windows.Forms.Label
        Me.cb_bg_jln = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.tx_TARIK = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.tx_nama = New System.Windows.Forms.TextBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lb_NIP = New System.Windows.Forms.Label
        Me.lb_NoTBG = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lb_nama = New System.Windows.Forms.Label
        Me.lb_saldo = New System.Windows.Forms.Label
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.de_tglCair = New DevExpress.XtraEditors.DateEdit
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.RL_kdTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_tglCair.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_tglCair.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RL_kdTrans
        '
        Me.RL_kdTrans.AutoHeight = False
        Me.RL_kdTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_kdTrans.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESKRIPSI_TRANS", "Transaksi")})
        Me.RL_kdTrans.Name = "RL_kdTrans"
        Me.RL_kdTrans.NullText = ""
        '
        'RLnama
        '
        Me.RLnama.AutoHeight = False
        Me.RLnama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RLnama.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RLnama.Name = "RLnama"
        Me.RLnama.NullText = ""
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1033, 348)
        Me.pnl.TabIndex = 164
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Gc_nabung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1033, 213)
        Me.Panel2.TabIndex = 3
        '
        'Gc_nabung
        '
        Me.Gc_nabung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_nabung.Location = New System.Drawing.Point(0, 0)
        Me.Gc_nabung.MainView = Me.GV_nabung
        Me.Gc_nabung.Name = "Gc_nabung"
        Me.Gc_nabung.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RLnama, Me.RL_kdTrans})
        Me.Gc_nabung.Size = New System.Drawing.Size(1033, 213)
        Me.Gc_nabung.TabIndex = 7
        Me.Gc_nabung.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_nabung})
        '
        'GV_nabung
        '
        Me.GV_nabung.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_nabung.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_nabung.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.Empty.Options.UseBackColor = True
        Me.GV_nabung.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV_nabung.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GV_nabung.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GV_nabung.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_nabung.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GV_nabung.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_nabung.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_nabung.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_nabung.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_nabung.Appearance.Preview.Options.UseFont = True
        Me.GV_nabung.Appearance.Preview.Options.UseForeColor = True
        Me.GV_nabung.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.Row.Options.UseBackColor = True
        Me.GV_nabung.Appearance.Row.Options.UseForeColor = True
        Me.GV_nabung.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_nabung.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_nabung.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_nabung.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.URUTAN, Me.NO_TABUNGAN, Me.TGL_TRANS, Me.KODE_TRANS, Me.NASABAH_ID, Me.Nama, Me.SALDO_AWAL, Me.SALDO_TRANS, Me.SALDO_AKHIR, Me.rp_bunga_jln})
        Me.GV_nabung.GridControl = Me.Gc_nabung
        Me.GV_nabung.Name = "GV_nabung"
        Me.GV_nabung.OptionsCustomization.AllowColumnMoving = False
        Me.GV_nabung.OptionsCustomization.AllowFilter = False
        Me.GV_nabung.OptionsCustomization.AllowGroup = False
        Me.GV_nabung.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_nabung.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_nabung.OptionsView.EnableAppearanceOddRow = True
        Me.GV_nabung.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_nabung.OptionsView.RowAutoHeight = True
        Me.GV_nabung.OptionsView.ShowFooter = True
        Me.GV_nabung.OptionsView.ShowGroupPanel = False
        Me.GV_nabung.OptionsView.ShowViewCaption = True
        Me.GV_nabung.ViewCaption = "PENARIKAN TABUNGAN"
        '
        'URUTAN
        '
        Me.URUTAN.Caption = "No"
        Me.URUTAN.FieldName = "URUTAN"
        Me.URUTAN.Name = "URUTAN"
        Me.URUTAN.Visible = True
        Me.URUTAN.VisibleIndex = 0
        Me.URUTAN.Width = 68
        '
        'NO_TABUNGAN
        '
        Me.NO_TABUNGAN.Caption = "No Tabungan"
        Me.NO_TABUNGAN.FieldName = "NO_TABUNGAN"
        Me.NO_TABUNGAN.Name = "NO_TABUNGAN"
        Me.NO_TABUNGAN.OptionsColumn.AllowEdit = False
        Me.NO_TABUNGAN.OptionsColumn.ReadOnly = True
        Me.NO_TABUNGAN.Visible = True
        Me.NO_TABUNGAN.VisibleIndex = 1
        Me.NO_TABUNGAN.Width = 80
        '
        'TGL_TRANS
        '
        Me.TGL_TRANS.Caption = "TGL TRANS"
        Me.TGL_TRANS.FieldName = "TGL_TRANS"
        Me.TGL_TRANS.Name = "TGL_TRANS"
        Me.TGL_TRANS.OptionsColumn.AllowEdit = False
        Me.TGL_TRANS.OptionsColumn.ReadOnly = True
        Me.TGL_TRANS.Visible = True
        Me.TGL_TRANS.VisibleIndex = 2
        Me.TGL_TRANS.Width = 69
        '
        'KODE_TRANS
        '
        Me.KODE_TRANS.Caption = "KODE TRANS"
        Me.KODE_TRANS.ColumnEdit = Me.RL_kdTrans
        Me.KODE_TRANS.FieldName = "KODE_TRANS"
        Me.KODE_TRANS.Name = "KODE_TRANS"
        Me.KODE_TRANS.OptionsColumn.AllowEdit = False
        Me.KODE_TRANS.OptionsColumn.ReadOnly = True
        Me.KODE_TRANS.Visible = True
        Me.KODE_TRANS.VisibleIndex = 3
        '
        'NASABAH_ID
        '
        Me.NASABAH_ID.Caption = "ID Nasabah"
        Me.NASABAH_ID.FieldName = "NASABAH_ID"
        Me.NASABAH_ID.Name = "NASABAH_ID"
        Me.NASABAH_ID.OptionsColumn.AllowEdit = False
        Me.NASABAH_ID.OptionsColumn.ReadOnly = True
        Me.NASABAH_ID.Visible = True
        Me.NASABAH_ID.VisibleIndex = 4
        Me.NASABAH_ID.Width = 77
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.ColumnEdit = Me.RLnama
        Me.Nama.FieldName = "NASABAH_ID"
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.ReadOnly = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 5
        Me.Nama.Width = 150
        '
        'SALDO_AWAL
        '
        Me.SALDO_AWAL.Caption = "SALDO AWAL"
        Me.SALDO_AWAL.DisplayFormat.FormatString = "c2"
        Me.SALDO_AWAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SALDO_AWAL.FieldName = "SALDO_AWAL"
        Me.SALDO_AWAL.Name = "SALDO_AWAL"
        Me.SALDO_AWAL.OptionsColumn.AllowEdit = False
        Me.SALDO_AWAL.OptionsColumn.ReadOnly = True
        Me.SALDO_AWAL.Visible = True
        Me.SALDO_AWAL.VisibleIndex = 6
        Me.SALDO_AWAL.Width = 66
        '
        'SALDO_TRANS
        '
        Me.SALDO_TRANS.Caption = "TRANSAKSI"
        Me.SALDO_TRANS.DisplayFormat.FormatString = "c2"
        Me.SALDO_TRANS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SALDO_TRANS.FieldName = "SALDO_TRANS"
        Me.SALDO_TRANS.Name = "SALDO_TRANS"
        Me.SALDO_TRANS.Visible = True
        Me.SALDO_TRANS.VisibleIndex = 8
        Me.SALDO_TRANS.Width = 126
        '
        'SALDO_AKHIR
        '
        Me.SALDO_AKHIR.Caption = "SALDO AKHIR"
        Me.SALDO_AKHIR.DisplayFormat.FormatString = "c2"
        Me.SALDO_AKHIR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SALDO_AKHIR.FieldName = "SALDO_AKHIR"
        Me.SALDO_AKHIR.Name = "SALDO_AKHIR"
        Me.SALDO_AKHIR.Visible = True
        Me.SALDO_AKHIR.VisibleIndex = 9
        Me.SALDO_AKHIR.Width = 220
        '
        'rp_bunga_jln
        '
        Me.rp_bunga_jln.Caption = "Bunga Berjalan"
        Me.rp_bunga_jln.DisplayFormat.FormatString = "c2"
        Me.rp_bunga_jln.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rp_bunga_jln.FieldName = "rp_bunga_jln"
        Me.rp_bunga_jln.Name = "rp_bunga_jln"
        Me.rp_bunga_jln.Visible = True
        Me.rp_bunga_jln.VisibleIndex = 7
        Me.rp_bunga_jln.Width = 81
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.de_tglCair)
        Me.Panel5.Controls.Add(Me.lb_saldo)
        Me.Panel5.Controls.Add(Me.lb_nama)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lb_NoTBG)
        Me.Panel5.Controls.Add(Me.lb_NIP)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.tglDari)
        Me.Panel5.Controls.Add(Me.lb1_bg_jln)
        Me.Panel5.Controls.Add(Me.cb_bg_jln)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.tx_TARIK)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.tx_nama)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1033, 135)
        Me.Panel5.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(689, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 306
        Me.Label4.Text = "Tgl Penempatan :"
        '
        'lb1_bg_jln
        '
        Me.lb1_bg_jln.AutoSize = True
        Me.lb1_bg_jln.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1_bg_jln.ForeColor = System.Drawing.Color.Gold
        Me.lb1_bg_jln.Location = New System.Drawing.Point(435, 75)
        Me.lb1_bg_jln.Name = "lb1_bg_jln"
        Me.lb1_bg_jln.Size = New System.Drawing.Size(37, 13)
        Me.lb1_bg_jln.TabIndex = 304
        Me.lb1_bg_jln.Text = "<Rp>"
        '
        'cb_bg_jln
        '
        Me.cb_bg_jln.AutoSize = True
        Me.cb_bg_jln.Location = New System.Drawing.Point(310, 74)
        Me.cb_bg_jln.Name = "cb_bg_jln"
        Me.cb_bg_jln.Size = New System.Drawing.Size(15, 14)
        Me.cb_bg_jln.TabIndex = 303
        Me.cb_bg_jln.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(328, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Bunga Berjalan :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(310, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 23)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Cairkan Deposito !"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(14, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Saldo Tabungan :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label33.Location = New System.Drawing.Point(689, 31)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 13)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "NIP Pegawai :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label34.Location = New System.Drawing.Point(14, 21)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 13)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "Nama :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label27.Location = New System.Drawing.Point(14, 71)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 13)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Tarikan :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(691, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "No Tabungan :"
        '
        'tx_TARIK
        '
        Me.tx_TARIK.Location = New System.Drawing.Point(132, 68)
        Me.tx_TARIK.Name = "tx_TARIK"
        Me.tx_TARIK.Size = New System.Drawing.Size(144, 20)
        Me.tx_TARIK.TabIndex = 47
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(317, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tx_nama
        '
        Me.tx_nama.Location = New System.Drawing.Point(132, 14)
        Me.tx_nama.Name = "tx_nama"
        Me.tx_nama.ReadOnly = True
        Me.tx_nama.Size = New System.Drawing.Size(170, 20)
        Me.tx_nama.TabIndex = 0
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
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
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
        Me.Panel1.Size = New System.Drawing.Size(1033, 38)
        Me.Panel1.TabIndex = 163
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
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(633, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          PENARIKAN TABUNGAN ANGGOTA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'lb_NIP
        '
        Me.lb_NIP.AutoSize = True
        Me.lb_NIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_NIP.ForeColor = System.Drawing.Color.Gold
        Me.lb_NIP.Location = New System.Drawing.Point(804, 32)
        Me.lb_NIP.Name = "lb_NIP"
        Me.lb_NIP.Size = New System.Drawing.Size(21, 13)
        Me.lb_NIP.TabIndex = 307
        Me.lb_NIP.Text = "<>"
        '
        'lb_NoTBG
        '
        Me.lb_NoTBG.AutoSize = True
        Me.lb_NoTBG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_NoTBG.ForeColor = System.Drawing.Color.Gold
        Me.lb_NoTBG.Location = New System.Drawing.Point(805, 77)
        Me.lb_NoTBG.Name = "lb_NoTBG"
        Me.lb_NoTBG.Size = New System.Drawing.Size(21, 13)
        Me.lb_NoTBG.TabIndex = 308
        Me.lb_NoTBG.Text = "<>"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(688, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 309
        Me.Label7.Text = "Nama Pegawai :"
        '
        'lb_nama
        '
        Me.lb_nama.AutoSize = True
        Me.lb_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nama.ForeColor = System.Drawing.Color.Gold
        Me.lb_nama.Location = New System.Drawing.Point(804, 8)
        Me.lb_nama.Name = "lb_nama"
        Me.lb_nama.Size = New System.Drawing.Size(21, 13)
        Me.lb_nama.TabIndex = 310
        Me.lb_nama.Text = "<>"
        '
        'lb_saldo
        '
        Me.lb_saldo.AutoSize = True
        Me.lb_saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_saldo.ForeColor = System.Drawing.Color.Gold
        Me.lb_saldo.Location = New System.Drawing.Point(129, 47)
        Me.lb_saldo.Name = "lb_saldo"
        Me.lb_saldo.Size = New System.Drawing.Size(37, 13)
        Me.lb_saldo.TabIndex = 311
        Me.lb_saldo.Text = "<Rp>"
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(807, 52)
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
        Me.tglDari.TabIndex = 305
        '
        'de_tglCair
        '
        Me.de_tglCair.EditValue = Nothing
        Me.de_tglCair.Location = New System.Drawing.Point(132, 99)
        Me.de_tglCair.Name = "de_tglCair"
        Me.de_tglCair.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.de_tglCair.Properties.Appearance.Options.UseFont = True
        Me.de_tglCair.Properties.Appearance.Options.UseTextOptions = True
        Me.de_tglCair.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.de_tglCair.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_tglCair.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.de_tglCair.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.de_tglCair.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.de_tglCair.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.de_tglCair.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.de_tglCair.Size = New System.Drawing.Size(144, 20)
        Me.de_tglCair.TabIndex = 312
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(14, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 313
        Me.Label10.Text = "Tanggal Cair :"
        '
        'frmDpsCair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 386)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDpsCair"
        Me.Text = "frmDpsCair"
        CType(Me.RL_kdTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_tglCair.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_tglCair.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RLnama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Gc_nabung As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_nabung As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents URUTAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_TABUNGAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TGL_TRANS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KODE_TRANS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_kdTrans As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents NASABAH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SALDO_AWAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SALDO_TRANS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SALDO_AKHIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tx_TARIK As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tx_nama As System.Windows.Forms.TextBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_bg_jln As System.Windows.Forms.CheckBox
    Friend WithEvents lb1_bg_jln As System.Windows.Forms.Label
    Friend WithEvents rp_bunga_jln As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lb_saldo As System.Windows.Forms.Label
    Friend WithEvents lb_nama As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lb_NoTBG As System.Windows.Forms.Label
    Friend WithEvents lb_NIP As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents de_tglCair As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
End Class
