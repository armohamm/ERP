﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransPlanProdUpd2
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.gvDetail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueNoSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.nama_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prioritas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_indeks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcData = New DevExpress.XtraGrid.GridControl
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nama_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.tboJadwal = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lueTrans = New DevExpress.XtraEditors.LookUpEdit
        Me.tboTanggal = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.gvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNoSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.lueTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvDetail
        '
        Me.gvDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sp, Me.nama_barang, Me.sisa, Me.tgl_kirim, Me.prioritas, Me.jumlah, Me.jml_indeks})
        Me.gvDetail.GridControl = Me.gcData
        Me.gvDetail.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "jml", Nothing, "")})
        Me.gvDetail.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvDetail.Name = "gvDetail"
        Me.gvDetail.NewItemRowText = "[Tambah Data]"
        Me.gvDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvDetail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvDetail.OptionsView.ShowFooter = True
        Me.gvDetail.OptionsView.ShowGroupPanel = False
        Me.gvDetail.OptionsView.ShowViewCaption = True
        Me.gvDetail.PaintStyleName = "Skin"
        Me.gvDetail.ViewCaption = "DAFTAR SISA BARANG"
        '
        'no_sp
        '
        Me.no_sp.Caption = "No SP"
        Me.no_sp.ColumnEdit = Me.lueNoSP
        Me.no_sp.FieldName = "no_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 0
        '
        'lueNoSP
        '
        Me.lueNoSP.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueNoSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNoSP.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sp", 100, "No SP"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_customer", "Nama Customer"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_barang", "Nama Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("qty_sisa", "Sisa"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tgl_kirim", "Tgl Kirim"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("prioritas", "Prioritas")})
        Me.lueNoSP.Name = "lueNoSP"
        '
        'nama_barang
        '
        Me.nama_barang.Caption = "Nama Barang"
        Me.nama_barang.ColumnEdit = Me.lueBarang
        Me.nama_barang.FieldName = "nama_barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Visible = True
        Me.nama_barang.VisibleIndex = 1
        '
        'lueBarang
        '
        Me.lueBarang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_barang", 150, "Nama Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sp", 100, "No. SP"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_customer", 150, "Nama Customer"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("qty_sisa", 100, "Sisa"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tgl_kirim", 100, "Tgl Kirim"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("prioritas", 100, "Prioritas")})
        Me.lueBarang.Name = "lueBarang"
        '
        'sisa
        '
        Me.sisa.Caption = "Sisa"
        Me.sisa.FieldName = "qty_sisa"
        Me.sisa.Name = "sisa"
        Me.sisa.OptionsColumn.AllowEdit = False
        Me.sisa.OptionsColumn.ReadOnly = True
        Me.sisa.Visible = True
        Me.sisa.VisibleIndex = 2
        '
        'tgl_kirim
        '
        Me.tgl_kirim.Caption = "Tgl Kirim"
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.OptionsColumn.AllowEdit = False
        Me.tgl_kirim.OptionsColumn.ReadOnly = True
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 3
        '
        'prioritas
        '
        Me.prioritas.Caption = "Prioritas"
        Me.prioritas.FieldName = "prioritas"
        Me.prioritas.Name = "prioritas"
        Me.prioritas.OptionsColumn.AllowEdit = False
        Me.prioritas.OptionsColumn.ReadOnly = True
        Me.prioritas.Visible = True
        Me.prioritas.VisibleIndex = 4
        '
        'jumlah
        '
        Me.jumlah.Caption = "Jml Prod"
        Me.jumlah.FieldName = "jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 5
        '
        'jml_indeks
        '
        Me.jml_indeks.Caption = "Indeks"
        Me.jml_indeks.FieldName = "jml_indeks"
        Me.jml_indeks.Name = "jml_indeks"
        Me.jml_indeks.OptionsColumn.AllowEdit = False
        Me.jml_indeks.OptionsColumn.ReadOnly = True
        Me.jml_indeks.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_indeks.Visible = True
        Me.jml_indeks.VisibleIndex = 6
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvDetail
        GridLevelNode1.RelationName = "Detail"
        Me.gcData.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcData.Location = New System.Drawing.Point(0, 60)
        Me.gcData.MainView = Me.gvMain
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueNoSP, Me.lueBarang})
        Me.gcData.Size = New System.Drawing.Size(959, 391)
        Me.gcData.TabIndex = 7
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain, Me.gvDetail})
        '
        'gvMain
        '
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nama_jenis})
        Me.gvMain.GridControl = Me.gcData
        Me.gvMain.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvMain.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvMain.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvMain.PaintStyleName = "Skin"
        '
        'nama_jenis
        '
        Me.nama_jenis.Caption = "Nama Jenis"
        Me.nama_jenis.FieldName = "Nama_Jenis"
        Me.nama_jenis.Name = "nama_jenis"
        Me.nama_jenis.OptionsColumn.AllowEdit = False
        Me.nama_jenis.OptionsColumn.ReadOnly = True
        Me.nama_jenis.Visible = True
        Me.nama_jenis.VisibleIndex = 0
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(961, 484)
        Me.pnl.TabIndex = 0
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gcData)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(959, 451)
        Me.pnlTengah.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 60)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tboJadwal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(594, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(164, 60)
        Me.Panel3.TabIndex = 8
        '
        'tboJadwal
        '
        Me.tboJadwal.BackColor = System.Drawing.Color.LightGreen
        Me.tboJadwal.Dock = System.Windows.Forms.DockStyle.Top
        Me.tboJadwal.Location = New System.Drawing.Point(0, 0)
        Me.tboJadwal.Name = "tboJadwal"
        Me.tboJadwal.ReadOnly = True
        Me.tboJadwal.Size = New System.Drawing.Size(164, 21)
        Me.tboJadwal.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(355, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 60)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Jadwal Kerja :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lueTrans)
        Me.Panel7.Controls.Add(Me.tboTanggal)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(164, 60)
        Me.Panel7.TabIndex = 5
        '
        'lueTrans
        '
        Me.lueTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.lueTrans.Location = New System.Drawing.Point(0, 20)
        Me.lueTrans.Name = "lueTrans"
        Me.lueTrans.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTrans.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_rph", "No RPH"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_data", "Jadwal")})
        Me.lueTrans.Properties.HideSelection = False
        Me.lueTrans.Properties.NullText = "[Pilih No Transaksi]"
        Me.lueTrans.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.lueTrans.Size = New System.Drawing.Size(164, 20)
        Me.lueTrans.TabIndex = 5
        '
        'tboTanggal
        '
        Me.tboTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.tboTanggal.EditValue = Nothing
        Me.tboTanggal.Location = New System.Drawing.Point(0, 0)
        Me.tboTanggal.Name = "tboTanggal"
        Me.tboTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tboTanggal.Properties.Appearance.Options.UseFont = True
        Me.tboTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tboTanggal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tboTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tboTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tboTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tboTanggal.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.tboTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tboTanggal.Size = New System.Drawing.Size(164, 20)
        Me.tboTanggal.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 60)
        Me.Panel6.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No. Transaksi : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tanggal : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Maroon
        Me.pnlAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtas.Controls.Add(Me.LabelControl1)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(959, 31)
        Me.pnlAtas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(368, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "   Trans Plan Prod Upd"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmTransPlanProdUpd2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 508)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmTransPlanProdUpd2"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNoSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.lueTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tboTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tboJadwal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lueTrans As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prioritas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_indeks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nama_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueNoSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
