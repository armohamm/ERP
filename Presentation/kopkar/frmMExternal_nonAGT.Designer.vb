﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMExternal_nonAGT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMExternal_nonAGT))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Gc_nabung = New DevExpress.XtraGrid.GridControl
        Me.GV_export = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_grup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_rek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_PINJAMAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_angsuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_POKOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_BUNGA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_pokok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_sisa_pokok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LAMA_ANGS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_lunas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.STATUS_LUNAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CB_stat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RL_nama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.lb_kota = New System.Windows.Forms.Label
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.pnl = New System.Windows.Forms.Panel
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.stat_anggota = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_export, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_grup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CB_stat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_nama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1360, 38)
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
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(677, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          Maintenance Pinjaman dan Debet NON ANGGOTA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Gc_nabung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1360, 358)
        Me.Panel2.TabIndex = 3
        '
        'Gc_nabung
        '
        Me.Gc_nabung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_nabung.Location = New System.Drawing.Point(0, 0)
        Me.Gc_nabung.MainView = Me.GV_export
        Me.Gc_nabung.Name = "Gc_nabung"
        Me.Gc_nabung.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_grup, Me.RL_nama, Me.CB_stat})
        Me.Gc_nabung.Size = New System.Drawing.Size(1360, 358)
        Me.Gc_nabung.TabIndex = 7
        Me.Gc_nabung.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_export})
        '
        'GV_export
        '
        Me.GV_export.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GV_export.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_export.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_export.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_export.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_export.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_export.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_export.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_export.Appearance.Empty.Options.UseBackColor = True
        Me.GV_export.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_export.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_export.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GV_export.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_export.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_export.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_export.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_export.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_export.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_export.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV_export.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_export.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_export.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_export.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_export.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GV_export.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GV_export.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_export.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_export.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_export.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_export.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_export.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_export.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_export.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_export.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_export.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_export.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_export.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_export.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_export.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_export.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_export.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_export.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_export.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_export.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_export.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GV_export.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_export.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_export.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_export.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_export.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_export.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_export.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_export.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_export.Appearance.Preview.Options.UseFont = True
        Me.GV_export.Appearance.Preview.Options.UseForeColor = True
        Me.GV_export.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.Row.Options.UseBackColor = True
        Me.GV_export.Appearance.Row.Options.UseForeColor = True
        Me.GV_export.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_export.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_export.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_export.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_export.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_export.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_export.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_export.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_export.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_export.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.jenis, Me.Nama, Me.no_rek, Me.JML_PINJAMAN, Me.jml_angsuran, Me.JML_POKOK, Me.keterangan, Me.nasabah_id, Me.JML_BUNGA, Me.sisa_angs, Me.sisa_pokok, Me.gc_sisa_pokok, Me.LAMA_ANGS, Me.tgl_trans, Me.tgl_lunas, Me.STATUS_LUNAS, Me.stat_anggota})
        Me.GV_export.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GV_export.GridControl = Me.Gc_nabung
        Me.GV_export.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_debet", Me.jml_angsuran, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ke_koperasi", Me.JML_POKOK, "{0:c2}")})
        Me.GV_export.Name = "GV_export"
        Me.GV_export.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_export.OptionsPrint.PrintFooter = False
        Me.GV_export.OptionsPrint.PrintHeader = False
        Me.GV_export.OptionsView.ColumnAutoWidth = False
        Me.GV_export.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_export.OptionsView.EnableAppearanceOddRow = True
        Me.GV_export.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_export.OptionsView.RowAutoHeight = True
        Me.GV_export.OptionsView.ShowFooter = True
        Me.GV_export.OptionsView.ShowGroupedColumns = True
        '
        'jenis
        '
        Me.jenis.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.jenis.AppearanceHeader.Options.UseFont = True
        Me.jenis.Caption = "Jenis"
        Me.jenis.ColumnEdit = Me.RL_grup
        Me.jenis.FieldName = "jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.Visible = True
        Me.jenis.VisibleIndex = 0
        Me.jenis.Width = 109
        '
        'RL_grup
        '
        Me.RL_grup.AutoHeight = False
        Me.RL_grup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_grup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RL_grup.Name = "RL_grup"
        Me.RL_grup.NullText = ""
        '
        'Nama
        '
        Me.Nama.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Nama.AppearanceHeader.Options.UseFont = True
        Me.Nama.Caption = "Nama"
        Me.Nama.FieldName = "nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 4
        Me.Nama.Width = 133
        '
        'no_rek
        '
        Me.no_rek.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.no_rek.AppearanceHeader.Options.UseFont = True
        Me.no_rek.Caption = "Rek Debet"
        Me.no_rek.FieldName = "no_rek"
        Me.no_rek.Name = "no_rek"
        Me.no_rek.SummaryItem.FieldName = "no_trans"
        Me.no_rek.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.no_rek.Visible = True
        Me.no_rek.VisibleIndex = 2
        Me.no_rek.Width = 73
        '
        'JML_PINJAMAN
        '
        Me.JML_PINJAMAN.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.JML_PINJAMAN.AppearanceHeader.Options.UseFont = True
        Me.JML_PINJAMAN.Caption = "Jml Pinjam"
        Me.JML_PINJAMAN.DisplayFormat.FormatString = "n0"
        Me.JML_PINJAMAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_PINJAMAN.FieldName = "JML_PINJAMAN"
        Me.JML_PINJAMAN.Name = "JML_PINJAMAN"
        Me.JML_PINJAMAN.SummaryItem.DisplayFormat = "{0:n0}"
        Me.JML_PINJAMAN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_PINJAMAN.Visible = True
        Me.JML_PINJAMAN.VisibleIndex = 5
        Me.JML_PINJAMAN.Width = 102
        '
        'jml_angsuran
        '
        Me.jml_angsuran.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.jml_angsuran.AppearanceHeader.Options.UseFont = True
        Me.jml_angsuran.Caption = "Jml Angs"
        Me.jml_angsuran.DisplayFormat.FormatString = "n0"
        Me.jml_angsuran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_angsuran.FieldName = "jml_angsuran"
        Me.jml_angsuran.Name = "jml_angsuran"
        Me.jml_angsuran.SummaryItem.DisplayFormat = "{0:n0}"
        Me.jml_angsuran.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_angsuran.Visible = True
        Me.jml_angsuran.VisibleIndex = 6
        Me.jml_angsuran.Width = 95
        '
        'JML_POKOK
        '
        Me.JML_POKOK.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.JML_POKOK.AppearanceHeader.Options.UseFont = True
        Me.JML_POKOK.Caption = "Pokok"
        Me.JML_POKOK.DisplayFormat.FormatString = "n0"
        Me.JML_POKOK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_POKOK.FieldName = "JML_POKOK"
        Me.JML_POKOK.Name = "JML_POKOK"
        Me.JML_POKOK.SummaryItem.DisplayFormat = "{0:n0}"
        Me.JML_POKOK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_POKOK.Visible = True
        Me.JML_POKOK.VisibleIndex = 7
        Me.JML_POKOK.Width = 77
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "KETERANGAN"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 13
        Me.keterangan.Width = 246
        '
        'nasabah_id
        '
        Me.nasabah_id.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.nasabah_id.AppearanceHeader.Options.UseFont = True
        Me.nasabah_id.Caption = "NIP"
        Me.nasabah_id.FieldName = "nasabah_id"
        Me.nasabah_id.Name = "nasabah_id"
        Me.nasabah_id.Visible = True
        Me.nasabah_id.VisibleIndex = 3
        '
        'JML_BUNGA
        '
        Me.JML_BUNGA.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.JML_BUNGA.AppearanceHeader.Options.UseFont = True
        Me.JML_BUNGA.Caption = "Bunga"
        Me.JML_BUNGA.DisplayFormat.FormatString = "n0"
        Me.JML_BUNGA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_BUNGA.FieldName = "JML_BUNGA"
        Me.JML_BUNGA.Name = "JML_BUNGA"
        Me.JML_BUNGA.SummaryItem.DisplayFormat = "{0:n0}"
        Me.JML_BUNGA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'sisa_angs
        '
        Me.sisa_angs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.sisa_angs.AppearanceHeader.Options.UseFont = True
        Me.sisa_angs.Caption = "Sisa Angs"
        Me.sisa_angs.FieldName = "sisa_angs"
        Me.sisa_angs.Name = "sisa_angs"
        Me.sisa_angs.Visible = True
        Me.sisa_angs.VisibleIndex = 8
        Me.sisa_angs.Width = 66
        '
        'sisa_pokok
        '
        Me.sisa_pokok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.sisa_pokok.AppearanceHeader.Options.UseFont = True
        Me.sisa_pokok.Caption = "Sisa Pinj"
        Me.sisa_pokok.DisplayFormat.FormatString = "n0"
        Me.sisa_pokok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sisa_pokok.FieldName = "sisa_pokok"
        Me.sisa_pokok.Name = "sisa_pokok"
        Me.sisa_pokok.SummaryItem.DisplayFormat = "{0:n0}"
        Me.sisa_pokok.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.sisa_pokok.Visible = True
        Me.sisa_pokok.VisibleIndex = 9
        Me.sisa_pokok.Width = 59
        '
        'gc_sisa_pokok
        '
        Me.gc_sisa_pokok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gc_sisa_pokok.AppearanceHeader.Options.UseFont = True
        Me.gc_sisa_pokok.Caption = "Sisa Pinj"
        Me.gc_sisa_pokok.DisplayFormat.FormatString = "n0"
        Me.gc_sisa_pokok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_sisa_pokok.FieldName = "sisa_pokok"
        Me.gc_sisa_pokok.Name = "gc_sisa_pokok"
        '
        'LAMA_ANGS
        '
        Me.LAMA_ANGS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LAMA_ANGS.AppearanceHeader.Options.UseFont = True
        Me.LAMA_ANGS.Caption = "Tenor"
        Me.LAMA_ANGS.FieldName = "LAMA_ANGS"
        Me.LAMA_ANGS.Name = "LAMA_ANGS"
        Me.LAMA_ANGS.Width = 52
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_trans.AppearanceHeader.Options.UseFont = True
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 57
        '
        'tgl_lunas
        '
        Me.tgl_lunas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_lunas.AppearanceHeader.Options.UseFont = True
        Me.tgl_lunas.Caption = "Tgl Lunas"
        Me.tgl_lunas.FieldName = "tgl_lunas"
        Me.tgl_lunas.Name = "tgl_lunas"
        Me.tgl_lunas.Visible = True
        Me.tgl_lunas.VisibleIndex = 11
        '
        'STATUS_LUNAS
        '
        Me.STATUS_LUNAS.AppearanceCell.BackColor = System.Drawing.Color.Green
        Me.STATUS_LUNAS.AppearanceCell.Options.UseBackColor = True
        Me.STATUS_LUNAS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STATUS_LUNAS.AppearanceHeader.Options.UseFont = True
        Me.STATUS_LUNAS.Caption = "STATUS LUNAS"
        Me.STATUS_LUNAS.ColumnEdit = Me.CB_stat
        Me.STATUS_LUNAS.FieldName = "status_lunas"
        Me.STATUS_LUNAS.Name = "STATUS_LUNAS"
        Me.STATUS_LUNAS.Visible = True
        Me.STATUS_LUNAS.VisibleIndex = 10
        Me.STATUS_LUNAS.Width = 95
        '
        'CB_stat
        '
        Me.CB_stat.AutoHeight = False
        Me.CB_stat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CB_stat.Items.AddRange(New Object() {"BELUM", "LUNAS"})
        Me.CB_stat.Name = "CB_stat"
        '
        'RL_nama
        '
        Me.RL_nama.AutoHeight = False
        Me.RL_nama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_nama.Name = "RL_nama"
        Me.RL_nama.NullText = ""
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Controls.Add(Me.SimpleButton2)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.SimpleButton1)
        Me.Panel5.Controls.Add(Me.lb_kota)
        Me.Panel5.Controls.Add(Me.cmdRefresh)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1360, 77)
        Me.Panel5.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = Global.Presentation.My.Resources.Resources.del2
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(705, 21)
        Me.SimpleButton2.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(57, 50)
        Me.SimpleButton2.TabIndex = 310
        Me.SimpleButton2.Text = "REFRESH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(65, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(643, 13)
        Me.Label2.TabIndex = 309
        Me.Label2.Text = "*) Untuk Hapus, arahkan klik  pada baris, kemudian tekan tombol delete di Keyboar" & _
            "d, otomatis akan menghapus"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(1022, 6)
        Me.SimpleButton1.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(57, 50)
        Me.SimpleButton1.TabIndex = 308
        Me.SimpleButton1.Text = "REFRESH"
        '
        'lb_kota
        '
        Me.lb_kota.AutoSize = True
        Me.lb_kota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_kota.ForeColor = System.Drawing.Color.Gold
        Me.lb_kota.Location = New System.Drawing.Point(70, 5)
        Me.lb_kota.Name = "lb_kota"
        Me.lb_kota.Size = New System.Drawing.Size(395, 13)
        Me.lb_kota.TabIndex = 307
        Me.lb_kota.Text = "*) Untuk Koreksi, langsung  update angka/nilainya kemudian simpan"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = Global.Presentation.My.Resources.Resources.cara_del
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(7, 24)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(57, 50)
        Me.cmdRefresh.TabIndex = 195
        Me.cmdRefresh.Text = "REFRESH"
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
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1360, 435)
        Me.pnl.TabIndex = 164
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
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
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESKRIPSI_TRANS", "Transaksi")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'stat_anggota
        '
        Me.stat_anggota.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stat_anggota.AppearanceHeader.Options.UseFont = True
        Me.stat_anggota.Caption = "Stat Anggota"
        Me.stat_anggota.FieldName = "stat_anggota"
        Me.stat_anggota.Name = "stat_anggota"
        Me.stat_anggota.Visible = True
        Me.stat_anggota.VisibleIndex = 12
        Me.stat_anggota.Width = 87
        '
        'frmMExternal_nonAGT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 473)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMExternal_nonAGT"
        Me.Text = "frmMExternal_nonAGT"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_export, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_grup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CB_stat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_nama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl.ResumeLayout(False)
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Gc_nabung As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_export As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_rek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_PINJAMAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jml_angsuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_POKOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RL_grup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents nasabah_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_nama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents JML_BUNGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_pokok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lb_kota As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gc_sisa_pokok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LAMA_ANGS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_lunas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents STATUS_LUNAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CB_stat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents stat_anggota As DevExpress.XtraGrid.Columns.GridColumn
End Class