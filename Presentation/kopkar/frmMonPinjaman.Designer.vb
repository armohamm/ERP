﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonPinjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonPinjaman))
        Me.gv_tbh_krd = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.trans_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_nip = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gd_kd_krd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gd_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RLnama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gd_tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcINV_Ret = New DevExpress.XtraGrid.GridControl
        Me.GV_RLSKRD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_Jenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.JML_PINJAMAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_POKOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_BUNGA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KETERANGAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_pokok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_kd_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LAMA_ANGS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gd_pj_bg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_stat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.gc_dps = New DevExpress.XtraGrid.GridControl
        Me.Gv_dps = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_TABUNGAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SALDO_AWAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_bunga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_rek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_anggota = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TGL_REGISTRASI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lb1_sisa_pk = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Lue_SetPjm = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Lue_Nama = New DevExpress.XtraEditors.LookUpEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.lb_pilih_all = New System.Windows.Forms.Label
        Me.cb_all = New System.Windows.Forms.CheckBox
        Me.LUE_Kartu = New DevExpress.XtraEditors.LookUpEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintableComponentLink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.CompositeLink1 = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.gv_tbh_krd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_Jenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_stat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.gc_dps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gv_dps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Lue_SetPjm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.Lue_Nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_Kartu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositeLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv_tbh_krd
        '
        Me.gv_tbh_krd.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.trans_tbh, Me.no_ref, Me.rp_tbh, Me.gc_nip, Me.gd_kd_krd, Me.gd_jenis, Me.gc_nama, Me.gd_tgl_trans})
        Me.gv_tbh_krd.GridControl = Me.GcINV_Ret
        Me.gv_tbh_krd.Name = "gv_tbh_krd"
        Me.gv_tbh_krd.OptionsView.ShowFooter = True
        '
        'trans_tbh
        '
        Me.trans_tbh.Caption = "no_trans"
        Me.trans_tbh.FieldName = "no_trans"
        Me.trans_tbh.Name = "trans_tbh"
        Me.trans_tbh.Width = 239
        '
        'no_ref
        '
        Me.no_ref.Caption = "No Form"
        Me.no_ref.FieldName = "no_ref"
        Me.no_ref.Name = "no_ref"
        Me.no_ref.Visible = True
        Me.no_ref.VisibleIndex = 3
        Me.no_ref.Width = 172
        '
        'rp_tbh
        '
        Me.rp_tbh.Caption = "Potongan"
        Me.rp_tbh.DisplayFormat.FormatString = "n0"
        Me.rp_tbh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rp_tbh.FieldName = "nilai"
        Me.rp_tbh.Name = "rp_tbh"
        Me.rp_tbh.SummaryItem.DisplayFormat = "{0:n0}"
        Me.rp_tbh.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_tbh.Visible = True
        Me.rp_tbh.VisibleIndex = 6
        Me.rp_tbh.Width = 166
        '
        'gc_nip
        '
        Me.gc_nip.Caption = "NIP"
        Me.gc_nip.FieldName = "nasabah_id"
        Me.gc_nip.Name = "gc_nip"
        Me.gc_nip.Visible = True
        Me.gc_nip.VisibleIndex = 1
        Me.gc_nip.Width = 82
        '
        'gd_kd_krd
        '
        Me.gd_kd_krd.Caption = "Produk"
        Me.gd_kd_krd.FieldName = "kd_kredit"
        Me.gd_kd_krd.Name = "gd_kd_krd"
        Me.gd_kd_krd.Visible = True
        Me.gd_kd_krd.VisibleIndex = 4
        Me.gd_kd_krd.Width = 146
        '
        'gd_jenis
        '
        Me.gd_jenis.Caption = "Jenis"
        Me.gd_jenis.FieldName = "jenis"
        Me.gd_jenis.Name = "gd_jenis"
        Me.gd_jenis.Visible = True
        Me.gd_jenis.VisibleIndex = 5
        Me.gd_jenis.Width = 145
        '
        'gc_nama
        '
        Me.gc_nama.Caption = "Nama"
        Me.gc_nama.ColumnEdit = Me.RLnama
        Me.gc_nama.FieldName = "nasabah_id"
        Me.gc_nama.Name = "gc_nama"
        Me.gc_nama.Visible = True
        Me.gc_nama.VisibleIndex = 2
        Me.gc_nama.Width = 254
        '
        'RLnama
        '
        Me.RLnama.AutoHeight = False
        Me.RLnama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RLnama.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RLnama.Name = "RLnama"
        Me.RLnama.NullText = ""
        '
        'gd_tgl_trans
        '
        Me.gd_tgl_trans.Caption = "tgl_trans"
        Me.gd_tgl_trans.FieldName = "tgl_trans"
        Me.gd_tgl_trans.Name = "gd_tgl_trans"
        Me.gd_tgl_trans.Visible = True
        Me.gd_tgl_trans.VisibleIndex = 0
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
        Me.GcINV_Ret.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RLnama, Me.RL_stat, Me.RL_Jenis})
        Me.GcINV_Ret.Size = New System.Drawing.Size(1295, 274)
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
        Me.GV_RLSKRD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.no_trans, Me.tgl_trans, Me.nasabah_id, Me.Nama, Me.jenis, Me.JML_PINJAMAN, Me.JML_POKOK, Me.JML_BUNGA, Me.sisa_angs, Me.KETERANGAN, Me.gc_angs, Me.sisa_pokok, Me.gc_kd_kredit, Me.LAMA_ANGS, Me.gd_pj_bg})
        Me.GV_RLSKRD.GridControl = Me.GcINV_Ret
        Me.GV_RLSKRD.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JML_PINJAMAN", Me.JML_PINJAMAN, "{0:c2}")})
        Me.GV_RLSKRD.Name = "GV_RLSKRD"
        Me.GV_RLSKRD.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_RLSKRD.OptionsView.ColumnAutoWidth = False
        Me.GV_RLSKRD.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_RLSKRD.OptionsView.EnableAppearanceOddRow = True
        Me.GV_RLSKRD.OptionsView.RowAutoHeight = True
        Me.GV_RLSKRD.OptionsView.ShowFooter = True
        Me.GV_RLSKRD.OptionsView.ShowViewCaption = True
        Me.GV_RLSKRD.ViewCaption = "Monitoring Outstanding Kartu Piutang Anggota"
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
        Me.nomer.Width = 34
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
        Me.no_trans.Width = 66
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
        Me.tgl_trans.Width = 70
        '
        'nasabah_id
        '
        Me.nasabah_id.Caption = "NIP"
        Me.nasabah_id.FieldName = "nasabah_id"
        Me.nasabah_id.Name = "nasabah_id"
        Me.nasabah_id.OptionsColumn.AllowEdit = False
        Me.nasabah_id.OptionsColumn.ReadOnly = True
        Me.nasabah_id.Visible = True
        Me.nasabah_id.VisibleIndex = 4
        Me.nasabah_id.Width = 66
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
        Me.Nama.Width = 126
        '
        'jenis
        '
        Me.jenis.Caption = "Jenis"
        Me.jenis.ColumnEdit = Me.RL_Jenis
        Me.jenis.FieldName = "jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.OptionsColumn.AllowEdit = False
        Me.jenis.OptionsColumn.ReadOnly = True
        Me.jenis.Visible = True
        Me.jenis.VisibleIndex = 2
        Me.jenis.Width = 172
        '
        'RL_Jenis
        '
        Me.RL_Jenis.AutoHeight = False
        Me.RL_Jenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_Jenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RL_Jenis.Name = "RL_Jenis"
        Me.RL_Jenis.NullText = ""
        '
        'JML_PINJAMAN
        '
        Me.JML_PINJAMAN.Caption = "Jml Pinjaman"
        Me.JML_PINJAMAN.DisplayFormat.FormatString = "n0"
        Me.JML_PINJAMAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_PINJAMAN.FieldName = "JML_PINJAMAN"
        Me.JML_PINJAMAN.Name = "JML_PINJAMAN"
        Me.JML_PINJAMAN.OptionsColumn.AllowEdit = False
        Me.JML_PINJAMAN.OptionsColumn.ReadOnly = True
        Me.JML_PINJAMAN.SummaryItem.DisplayFormat = "{0:n2}"
        Me.JML_PINJAMAN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_PINJAMAN.Visible = True
        Me.JML_PINJAMAN.VisibleIndex = 6
        Me.JML_PINJAMAN.Width = 110
        '
        'JML_POKOK
        '
        Me.JML_POKOK.Caption = "Jml Pokok"
        Me.JML_POKOK.DisplayFormat.FormatString = "n0"
        Me.JML_POKOK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_POKOK.FieldName = "JML_POKOK"
        Me.JML_POKOK.Name = "JML_POKOK"
        Me.JML_POKOK.OptionsColumn.AllowEdit = False
        Me.JML_POKOK.OptionsColumn.ReadOnly = True
        Me.JML_POKOK.SummaryItem.DisplayFormat = "{0:n2}"
        Me.JML_POKOK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_POKOK.Visible = True
        Me.JML_POKOK.VisibleIndex = 10
        Me.JML_POKOK.Width = 98
        '
        'JML_BUNGA
        '
        Me.JML_BUNGA.Caption = "Jml Bunga"
        Me.JML_BUNGA.DisplayFormat.FormatString = "n0"
        Me.JML_BUNGA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_BUNGA.FieldName = "JML_BUNGA"
        Me.JML_BUNGA.Name = "JML_BUNGA"
        Me.JML_BUNGA.OptionsColumn.AllowEdit = False
        Me.JML_BUNGA.OptionsColumn.ReadOnly = True
        Me.JML_BUNGA.SummaryItem.DisplayFormat = "{0:n2}"
        Me.JML_BUNGA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_BUNGA.Visible = True
        Me.JML_BUNGA.VisibleIndex = 11
        Me.JML_BUNGA.Width = 81
        '
        'sisa_angs
        '
        Me.sisa_angs.Caption = "Sisa Angs"
        Me.sisa_angs.FieldName = "sisa_angs"
        Me.sisa_angs.Name = "sisa_angs"
        Me.sisa_angs.SummaryItem.DisplayFormat = "{0:c2}"
        Me.sisa_angs.SummaryItem.FieldName = "JML_ADMIN"
        Me.sisa_angs.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.sisa_angs.Visible = True
        Me.sisa_angs.VisibleIndex = 12
        Me.sisa_angs.Width = 82
        '
        'KETERANGAN
        '
        Me.KETERANGAN.Caption = "Keterangan"
        Me.KETERANGAN.FieldName = "KETERANGAN"
        Me.KETERANGAN.Name = "KETERANGAN"
        Me.KETERANGAN.OptionsColumn.AllowEdit = False
        Me.KETERANGAN.OptionsColumn.ReadOnly = True
        Me.KETERANGAN.Width = 77
        '
        'gc_angs
        '
        Me.gc_angs.Caption = "Angsuran"
        Me.gc_angs.DisplayFormat.FormatString = "n0"
        Me.gc_angs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_angs.FieldName = "angsuran"
        Me.gc_angs.Name = "gc_angs"
        Me.gc_angs.OptionsColumn.AllowEdit = False
        Me.gc_angs.OptionsColumn.ReadOnly = True
        Me.gc_angs.SummaryItem.DisplayFormat = "{0:n0}"
        Me.gc_angs.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.gc_angs.Visible = True
        Me.gc_angs.VisibleIndex = 8
        Me.gc_angs.Width = 73
        '
        'sisa_pokok
        '
        Me.sisa_pokok.Caption = "Sisa Pokok"
        Me.sisa_pokok.DisplayFormat.FormatString = "n0"
        Me.sisa_pokok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sisa_pokok.FieldName = "sisa_pokok"
        Me.sisa_pokok.Name = "sisa_pokok"
        Me.sisa_pokok.OptionsColumn.AllowEdit = False
        Me.sisa_pokok.OptionsColumn.ReadOnly = True
        Me.sisa_pokok.SummaryItem.DisplayFormat = "{0:n0}"
        Me.sisa_pokok.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.sisa_pokok.Visible = True
        Me.sisa_pokok.VisibleIndex = 13
        Me.sisa_pokok.Width = 108
        '
        'gc_kd_kredit
        '
        Me.gc_kd_kredit.Caption = "Type"
        Me.gc_kd_kredit.FieldName = "kd_kredit"
        Me.gc_kd_kredit.Name = "gc_kd_kredit"
        Me.gc_kd_kredit.OptionsColumn.AllowEdit = False
        Me.gc_kd_kredit.OptionsColumn.ReadOnly = True
        Me.gc_kd_kredit.Width = 36
        '
        'LAMA_ANGS
        '
        Me.LAMA_ANGS.Caption = "Tenor"
        Me.LAMA_ANGS.FieldName = "LAMA_ANGS"
        Me.LAMA_ANGS.Name = "LAMA_ANGS"
        Me.LAMA_ANGS.Visible = True
        Me.LAMA_ANGS.VisibleIndex = 7
        Me.LAMA_ANGS.Width = 40
        '
        'gd_pj_bg
        '
        Me.gd_pj_bg.Caption = "Pinj+Bunga"
        Me.gd_pj_bg.DisplayFormat.FormatString = "n0"
        Me.gd_pj_bg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gd_pj_bg.FieldName = "pj_bg"
        Me.gd_pj_bg.Name = "gd_pj_bg"
        Me.gd_pj_bg.OptionsColumn.AllowEdit = False
        Me.gd_pj_bg.OptionsColumn.ReadOnly = True
        Me.gd_pj_bg.SummaryItem.DisplayFormat = "{0:n0}"
        Me.gd_pj_bg.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.gd_pj_bg.Visible = True
        Me.gd_pj_bg.VisibleIndex = 9
        Me.gd_pj_bg.Width = 105
        '
        'RL_stat
        '
        Me.RL_stat.AutoHeight = False
        Me.RL_stat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_stat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("keterangan", "keterangan")})
        Me.RL_stat.Name = "RL_stat"
        Me.RL_stat.NullText = ""
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.gc_dps)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 353)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1295, 166)
        Me.Panel4.TabIndex = 1
        '
        'gc_dps
        '
        Me.gc_dps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_dps.Location = New System.Drawing.Point(0, 0)
        Me.gc_dps.MainView = Me.Gv_dps
        Me.gc_dps.Name = "gc_dps"
        Me.gc_dps.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.gc_dps.Size = New System.Drawing.Size(1295, 166)
        Me.gc_dps.TabIndex = 7
        Me.gc_dps.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gv_dps})
        '
        'Gv_dps
        '
        Me.Gv_dps.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Gv_dps.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Gv_dps.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_dps.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_dps.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Gv_dps.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Gv_dps.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_dps.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.Gv_dps.Appearance.Empty.Options.UseBackColor = True
        Me.Gv_dps.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Gv_dps.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Gv_dps.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.EvenRow.Options.UseBackColor = True
        Me.Gv_dps.Appearance.EvenRow.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.EvenRow.Options.UseForeColor = True
        Me.Gv_dps.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Gv_dps.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.Gv_dps.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_dps.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.Gv_dps.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Gv_dps.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Gv_dps.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Gv_dps.Appearance.FixedLine.Options.UseBackColor = True
        Me.Gv_dps.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.Gv_dps.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Gv_dps.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Gv_dps.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Gv_dps.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Gv_dps.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Gv_dps.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Gv_dps.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Gv_dps.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Gv_dps.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.FooterPanel.Options.UseForeColor = True
        Me.Gv_dps.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.GroupButton.Options.UseBackColor = True
        Me.Gv_dps.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.GroupButton.Options.UseForeColor = True
        Me.Gv_dps.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_dps.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_dps.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Gv_dps.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.GroupFooter.Options.UseForeColor = True
        Me.Gv_dps.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_dps.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.Gv_dps.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Gv_dps.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Gv_dps.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_dps.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_dps.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.GroupRow.Options.UseBackColor = True
        Me.Gv_dps.Appearance.GroupRow.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.GroupRow.Options.UseForeColor = True
        Me.Gv_dps.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Gv_dps.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Gv_dps.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Gv_dps.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.Gv_dps.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Gv_dps.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.Gv_dps.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Gv_dps.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.Gv_dps.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.HorzLine.Options.UseBackColor = True
        Me.Gv_dps.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_dps.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_dps.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.OddRow.Options.UseBackColor = True
        Me.Gv_dps.Appearance.OddRow.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.OddRow.Options.UseForeColor = True
        Me.Gv_dps.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Gv_dps.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Gv_dps.Appearance.Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Gv_dps.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Gv_dps.Appearance.Preview.Options.UseBackColor = True
        Me.Gv_dps.Appearance.Preview.Options.UseBorderColor = True
        Me.Gv_dps.Appearance.Preview.Options.UseFont = True
        Me.Gv_dps.Appearance.Preview.Options.UseForeColor = True
        Me.Gv_dps.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Gv_dps.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.Gv_dps.Appearance.Row.Options.UseBackColor = True
        Me.Gv_dps.Appearance.Row.Options.UseForeColor = True
        Me.Gv_dps.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_dps.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.Gv_dps.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Gv_dps.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Gv_dps.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Gv_dps.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.Gv_dps.Appearance.TopNewRow.Options.UseBackColor = True
        Me.Gv_dps.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_dps.Appearance.VertLine.Options.UseBackColor = True
        Me.Gv_dps.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.NO_TABUNGAN, Me.GridColumn4, Me.GridColumn5, Me.SALDO_AWAL, Me.gc_bunga, Me.no_rek, Me.status_anggota, Me.TGL_REGISTRASI, Me.nm})
        Me.Gv_dps.GridControl = Me.gc_dps
        Me.Gv_dps.Name = "Gv_dps"
        Me.Gv_dps.OptionsCustomization.AllowGroup = False
        Me.Gv_dps.OptionsNavigation.EnterMoveNextColumn = True
        Me.Gv_dps.OptionsView.EnableAppearanceEvenRow = True
        Me.Gv_dps.OptionsView.EnableAppearanceOddRow = True
        Me.Gv_dps.OptionsView.RowAutoHeight = True
        Me.Gv_dps.OptionsView.ShowFooter = True
        Me.Gv_dps.OptionsView.ShowPreview = True
        Me.Gv_dps.OptionsView.ShowViewCaption = True
        Me.Gv_dps.ViewCaption = "MONITORING PENEMPATAN DEPOSITO AKTIF"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "No."
        Me.GridColumn3.FieldName = "nomer"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 57
        '
        'NO_TABUNGAN
        '
        Me.NO_TABUNGAN.Caption = "No BILYET"
        Me.NO_TABUNGAN.FieldName = "NO_TABUNGAN"
        Me.NO_TABUNGAN.Name = "NO_TABUNGAN"
        Me.NO_TABUNGAN.OptionsColumn.AllowEdit = False
        Me.NO_TABUNGAN.OptionsColumn.ReadOnly = True
        Me.NO_TABUNGAN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.NO_TABUNGAN.Visible = True
        Me.NO_TABUNGAN.VisibleIndex = 1
        Me.NO_TABUNGAN.Width = 56
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "NIP"
        Me.GridColumn4.FieldName = "NASABAH_ID"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 73
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Nama"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn5.FieldName = "NASABAH_ID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 174
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'SALDO_AWAL
        '
        Me.SALDO_AWAL.Caption = "Nilai"
        Me.SALDO_AWAL.DisplayFormat.FormatString = "{0:c2}"
        Me.SALDO_AWAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SALDO_AWAL.FieldName = "SALDO_AWAL"
        Me.SALDO_AWAL.Name = "SALDO_AWAL"
        Me.SALDO_AWAL.OptionsColumn.AllowEdit = False
        Me.SALDO_AWAL.OptionsColumn.ReadOnly = True
        Me.SALDO_AWAL.SummaryItem.DisplayFormat = "{0:c2}"
        Me.SALDO_AWAL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SALDO_AWAL.Visible = True
        Me.SALDO_AWAL.VisibleIndex = 7
        Me.SALDO_AWAL.Width = 143
        '
        'gc_bunga
        '
        Me.gc_bunga.Caption = "Bunga"
        Me.gc_bunga.FieldName = "bunga"
        Me.gc_bunga.Name = "gc_bunga"
        Me.gc_bunga.OptionsColumn.AllowEdit = False
        Me.gc_bunga.OptionsColumn.ReadOnly = True
        Me.gc_bunga.Visible = True
        Me.gc_bunga.VisibleIndex = 8
        Me.gc_bunga.Width = 40
        '
        'no_rek
        '
        Me.no_rek.Caption = "No Rek"
        Me.no_rek.FieldName = "no_rek"
        Me.no_rek.Name = "no_rek"
        Me.no_rek.Visible = True
        Me.no_rek.VisibleIndex = 4
        Me.no_rek.Width = 84
        '
        'status_anggota
        '
        Me.status_anggota.Caption = "Status Anggota"
        Me.status_anggota.FieldName = "status_anggota"
        Me.status_anggota.Name = "status_anggota"
        Me.status_anggota.OptionsColumn.AllowEdit = False
        Me.status_anggota.OptionsColumn.ReadOnly = True
        Me.status_anggota.Visible = True
        Me.status_anggota.VisibleIndex = 6
        Me.status_anggota.Width = 84
        '
        'TGL_REGISTRASI
        '
        Me.TGL_REGISTRASI.Caption = "TGL REGISTRASI"
        Me.TGL_REGISTRASI.FieldName = "TGL_REGISTRASI"
        Me.TGL_REGISTRASI.Name = "TGL_REGISTRASI"
        Me.TGL_REGISTRASI.Visible = True
        Me.TGL_REGISTRASI.VisibleIndex = 5
        Me.TGL_REGISTRASI.Width = 104
        '
        'nm
        '
        Me.nm.Caption = "Nama"
        Me.nm.FieldName = "nm"
        Me.nm.Name = "nm"
        Me.nm.Visible = True
        Me.nm.VisibleIndex = 3
        Me.nm.Width = 146
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("keterangan", "keterangan")})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
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
        Me.Panel1.Size = New System.Drawing.Size(1295, 38)
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
        Me.Label1.Size = New System.Drawing.Size(472, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         MONITORING OUTSTANDING PINJAMAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcINV_Ret)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 79)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1295, 274)
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
        Me.Panel3.Size = New System.Drawing.Size(1295, 79)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lb1_sisa_pk)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Lue_SetPjm)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1295, 79)
        Me.Panel2.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(758, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 355
        Me.Label12.Text = "<Rp>"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(758, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 354
        Me.Label11.Text = "<Rp>"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(758, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 353
        Me.Label10.Text = "<Rp>"
        '
        'lb1_sisa_pk
        '
        Me.lb1_sisa_pk.AutoSize = True
        Me.lb1_sisa_pk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1_sisa_pk.ForeColor = System.Drawing.Color.Gold
        Me.lb1_sisa_pk.Location = New System.Drawing.Point(758, 3)
        Me.lb1_sisa_pk.Name = "lb1_sisa_pk"
        Me.lb1_sisa_pk.Size = New System.Drawing.Size(37, 13)
        Me.lb1_sisa_pk.TabIndex = 352
        Me.lb1_sisa_pk.Text = "<Rp>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(601, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 351
        Me.Label8.Text = "Saldo Tab Qurban"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(601, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 350
        Me.Label7.Text = "Saldo Tab Qurban"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(601, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 13)
        Me.Label5.TabIndex = 349
        Me.Label5.Text = "Saldo Simpanan Sukarela"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(601, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 348
        Me.Label3.Text = "Saldo Simpanan Wajib"
        '
        'Lue_SetPjm
        '
        Me.Lue_SetPjm.Location = New System.Drawing.Point(1105, 6)
        Me.Lue_SetPjm.Name = "Lue_SetPjm"
        Me.Lue_SetPjm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lue_SetPjm.Properties.Appearance.Options.UseBackColor = True
        Me.Lue_SetPjm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue_SetPjm.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Jenis Kredit")})
        Me.Lue_SetPjm.Properties.NullText = "[klik disini]"
        Me.Lue_SetPjm.Size = New System.Drawing.Size(178, 20)
        Me.Lue_SetPjm.TabIndex = 351
        Me.Lue_SetPjm.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1054, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 350
        Me.Label2.Text = "Jenis  :"
        Me.Label2.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Lue_Nama)
        Me.Panel6.Controls.Add(Me.SimpleButton1)
        Me.Panel6.Controls.Add(Me.SimpleButton2)
        Me.Panel6.Controls.Add(Me.SimpleButton3)
        Me.Panel6.Controls.Add(Me.lb_pilih_all)
        Me.Panel6.Controls.Add(Me.cb_all)
        Me.Panel6.Controls.Add(Me.LUE_Kartu)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(102, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(493, 79)
        Me.Panel6.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 356
        Me.Label9.Text = "Nama  :"
        '
        'Lue_Nama
        '
        Me.Lue_Nama.Location = New System.Drawing.Point(73, 29)
        Me.Lue_Nama.Name = "Lue_Nama"
        Me.Lue_Nama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue_Nama.Properties.NullText = "[Pilih]"
        Me.Lue_Nama.Size = New System.Drawing.Size(191, 20)
        Me.Lue_Nama.TabIndex = 355
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton1.Image = Global.Presentation.My.Resources.Resources.printer2
        Me.SimpleButton1.ImageIndex = 10
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(276, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(73, 79)
        Me.SimpleButton1.TabIndex = 354
        Me.SimpleButton1.Text = "Cetak"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(349, 0)
        Me.SimpleButton2.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 79)
        Me.SimpleButton2.TabIndex = 353
        Me.SimpleButton2.Text = "Clear Filter"
        Me.SimpleButton2.ToolTip = "Celar Filter"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(424, 0)
        Me.SimpleButton3.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(69, 79)
        Me.SimpleButton3.TabIndex = 352
        Me.SimpleButton3.Text = "Refresh"
        '
        'lb_pilih_all
        '
        Me.lb_pilih_all.AutoSize = True
        Me.lb_pilih_all.ForeColor = System.Drawing.Color.Lime
        Me.lb_pilih_all.Location = New System.Drawing.Point(77, 52)
        Me.lb_pilih_all.Name = "lb_pilih_all"
        Me.lb_pilih_all.Size = New System.Drawing.Size(105, 13)
        Me.lb_pilih_all.TabIndex = 349
        Me.lb_pilih_all.Text = "Pilih Semua Anggota"
        Me.lb_pilih_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_all
        '
        Me.cb_all.AutoSize = True
        Me.cb_all.Location = New System.Drawing.Point(67, 51)
        Me.cb_all.Name = "cb_all"
        Me.cb_all.Size = New System.Drawing.Size(15, 14)
        Me.cb_all.TabIndex = 348
        Me.cb_all.UseVisualStyleBackColor = True
        '
        'LUE_Kartu
        '
        Me.LUE_Kartu.Location = New System.Drawing.Point(73, 6)
        Me.LUE_Kartu.Name = "LUE_Kartu"
        Me.LUE_Kartu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_Kartu.Properties.NullText = "[Pilih]"
        Me.LUE_Kartu.Size = New System.Drawing.Size(191, 20)
        Me.LUE_Kartu.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "NIP  :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 79)
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
        Me.pnl.Size = New System.Drawing.Size(1295, 519)
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
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1, Me.PrintableComponentLink2, Me.CompositeLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcINV_Ret
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.ImageCollection.Images.SetKeyName(0, "LOGO_MSBCA1.png")
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(10, 10, 100, 10)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[Image 0]", "MONITORING  OUTSTANDING", ""}, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Tanggal Cetak: [Date Printed] --SISKOP--", "", "Hal: [Page # of Pages #] " & Global.Microsoft.VisualBasic.ChrW(9)}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'PrintableComponentLink2
        '
        Me.PrintableComponentLink2.Component = Me.gc_dps
        '
        '
        '
        Me.PrintableComponentLink2.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink2.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink2.PrintingSystemBase = Me.PrintingSystem1
        '
        'CompositeLink1
        '
        '
        '
        '
        Me.CompositeLink1.ImageCollection.ImageStream = CType(resources.GetObject("CompositeLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.CompositeLink1.ImageCollection.Images.SetKeyName(0, "LOGO_MSBCA1.png")
        Me.CompositeLink1.Landscape = True
        Me.CompositeLink1.Links.AddRange(New Object() {Me.PrintableComponentLink1, Me.PrintableComponentLink2})
        Me.CompositeLink1.Margins = New System.Drawing.Printing.Margins(20, 20, 100, 20)
        Me.CompositeLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[Image 0]", "MONITORING OUTSTANDING", ""}, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Tanggal Cetak: [Date Printed] --SISKOP--", "", "Hal: [Page # of Pages #] " & Global.Microsoft.VisualBasic.ChrW(9)}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.CompositeLink1.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.CompositeLink1.PrintingSystem = Me.PrintingSystem1
        Me.CompositeLink1.PrintingSystemBase = Me.PrintingSystem1
        Me.CompositeLink1.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Exact
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
        'frmMonPinjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 557)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMonPinjaman"
        Me.Text = "frmMonPinjaman"
        CType(Me.gv_tbh_krd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_RLSKRD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_Jenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_stat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.gc_dps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gv_dps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Lue_SetPjm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.Lue_Nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_Kartu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositeLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents JML_PINJAMAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_POKOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_BUNGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KETERANGAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RL_stat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gv_tbh_krd As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents trans_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents LUE_Kartu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lb_pilih_all As System.Windows.Forms.Label
    Friend WithEvents cb_all As System.Windows.Forms.CheckBox
    Friend WithEvents sisa_pokok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_kd_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gd_kd_krd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gd_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LAMA_ANGS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gd_tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gd_pj_bg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_Jenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Lue_SetPjm As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gc_dps As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gv_dps As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_TABUNGAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SALDO_AWAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_bunga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_rek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status_anggota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TGL_REGISTRASI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrintableComponentLink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents CompositeLink1 As DevExpress.XtraPrintingLinks.CompositeLink
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Lue_Nama As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lb1_sisa_pk As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
