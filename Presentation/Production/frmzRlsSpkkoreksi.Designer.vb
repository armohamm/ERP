﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmzRlsSpkkoreksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmzRlsSpkkoreksi))
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nama_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cltipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clkain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_realisasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_kerja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_koreksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_rework = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_delay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.indeks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlahk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtJam = New DevExpress.XtraEditors.LookUpEdit
        Me.txtJadwal = New DevExpress.XtraEditors.LookUpEdit
        Me.txtMesin = New DevExpress.XtraEditors.LookUpEdit
        Me.txtPegawai = New DevExpress.XtraEditors.LookUpEdit
        Me.txtGroup = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.txtkgtn = New DevExpress.XtraEditors.LookUpEdit
        Me.txtKegiatan = New DevExpress.XtraEditors.LookUpEdit
        Me.lkspk = New DevExpress.XtraEditors.LookUpEdit
        Me.lkspkreal = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlbawah = New System.Windows.Forms.Panel
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtJam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJadwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPegawai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtkgtn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKegiatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkspk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkspkreal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Controls.Add(Me.pnlbawah)
        Me.pnl.Location = New System.Drawing.Point(7, 26)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(928, 402)
        Me.pnl.TabIndex = 1
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(926, 353)
        Me.pnlTengah.TabIndex = 1
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 107)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(926, 246)
        Me.gc.TabIndex = 7
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gv.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.Empty.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.EvenRow.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.Options.UseForeColor = True
        Me.gv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gv.Appearance.FixedLine.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gv.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupButton.Options.UseBackColor = True
        Me.gv.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gv.Appearance.GroupButton.Options.UseForeColor = True
        Me.gv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gv.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gv.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupRow.Options.UseBackColor = True
        Me.gv.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gv.Appearance.GroupRow.Options.UseFont = True
        Me.gv.Appearance.GroupRow.Options.UseForeColor = True
        Me.gv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gv.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gv.Appearance.HorzLine.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.OddRow.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.Options.UseForeColor = True
        Me.gv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.Appearance.Preview.Options.UseBackColor = True
        Me.gv.Appearance.Preview.Options.UseForeColor = True
        Me.gv.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.Row.Options.UseBackColor = True
        Me.gv.Appearance.Row.Options.UseForeColor = True
        Me.gv.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gv.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gv.Appearance.VertLine.Options.UseBackColor = True
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nama_barang, Me.kd_barang, Me.cltipe, Me.clkain, Me.clukuran, Me.jumlah_realisasi, Me.jumlah_kerja, Me.jumlah_koreksi, Me.jumlah_rework, Me.jumlah_delay, Me.jumlah_sisa, Me.indeks, Me.jumlahk})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsView.EnableAppearanceEvenRow = True
        Me.gv.OptionsView.EnableAppearanceOddRow = True
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.PaintStyleName = "Skin"
        Me.gv.ViewCaption = "DAFTAR PRODUKSI"
        '
        'nama_barang
        '
        Me.nama_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_barang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.nama_barang.Caption = "Barang"
        Me.nama_barang.FieldName = "Nama_Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.OptionsColumn.AllowEdit = False
        Me.nama_barang.Visible = True
        Me.nama_barang.VisibleIndex = 0
        Me.nama_barang.Width = 211
        '
        'kd_barang
        '
        Me.kd_barang.Caption = "Kd Barang"
        Me.kd_barang.FieldName = "kd_barang"
        Me.kd_barang.Name = "kd_barang"
        Me.kd_barang.OptionsColumn.AllowEdit = False
        '
        'cltipe
        '
        Me.cltipe.AppearanceHeader.Options.UseTextOptions = True
        Me.cltipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cltipe.Caption = "Tipe"
        Me.cltipe.FieldName = "Nama_Tipe"
        Me.cltipe.Name = "cltipe"
        Me.cltipe.OptionsColumn.AllowEdit = False
        Me.cltipe.Visible = True
        Me.cltipe.VisibleIndex = 1
        '
        'clkain
        '
        Me.clkain.AppearanceHeader.Options.UseTextOptions = True
        Me.clkain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clkain.Caption = "Kain"
        Me.clkain.FieldName = "Merk_Kain"
        Me.clkain.Name = "clkain"
        Me.clkain.OptionsColumn.AllowEdit = False
        Me.clkain.Visible = True
        Me.clkain.VisibleIndex = 2
        '
        'clukuran
        '
        Me.clukuran.AppearanceHeader.Options.UseTextOptions = True
        Me.clukuran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clukuran.Caption = "Ukuran"
        Me.clukuran.FieldName = "Nama_Ukuran"
        Me.clukuran.Name = "clukuran"
        Me.clukuran.OptionsColumn.AllowEdit = False
        Me.clukuran.Visible = True
        Me.clukuran.VisibleIndex = 3
        '
        'jumlah_realisasi
        '
        Me.jumlah_realisasi.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah_realisasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah_realisasi.Caption = "Jumlah"
        Me.jumlah_realisasi.FieldName = "jumlah_realisasi"
        Me.jumlah_realisasi.Name = "jumlah_realisasi"
        Me.jumlah_realisasi.OptionsColumn.AllowEdit = False
        Me.jumlah_realisasi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'jumlah_kerja
        '
        Me.jumlah_kerja.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah_kerja.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah_kerja.Caption = "Kerja"
        Me.jumlah_kerja.FieldName = "jumlah_kerja"
        Me.jumlah_kerja.Name = "jumlah_kerja"
        Me.jumlah_kerja.OptionsColumn.AllowEdit = False
        Me.jumlah_kerja.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah_kerja.Visible = True
        Me.jumlah_kerja.VisibleIndex = 4
        '
        'jumlah_koreksi
        '
        Me.jumlah_koreksi.Caption = "Jumlah Koreksi"
        Me.jumlah_koreksi.DisplayFormat.FormatString = "0"
        Me.jumlah_koreksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah_koreksi.FieldName = "jumlah_koreksi"
        Me.jumlah_koreksi.Name = "jumlah_koreksi"
        Me.jumlah_koreksi.Visible = True
        Me.jumlah_koreksi.VisibleIndex = 5
        '
        'jumlah_rework
        '
        Me.jumlah_rework.Caption = "Rework"
        Me.jumlah_rework.FieldName = "jumlah_rework"
        Me.jumlah_rework.Name = "jumlah_rework"
        Me.jumlah_rework.OptionsColumn.AllowEdit = False
        Me.jumlah_rework.Visible = True
        Me.jumlah_rework.VisibleIndex = 6
        '
        'jumlah_delay
        '
        Me.jumlah_delay.Caption = "Delay"
        Me.jumlah_delay.FieldName = "jumlah_delay"
        Me.jumlah_delay.Name = "jumlah_delay"
        Me.jumlah_delay.OptionsColumn.AllowEdit = False
        Me.jumlah_delay.Visible = True
        Me.jumlah_delay.VisibleIndex = 7
        '
        'jumlah_sisa
        '
        Me.jumlah_sisa.Caption = "Sisa"
        Me.jumlah_sisa.FieldName = "jumlah_sisa"
        Me.jumlah_sisa.Name = "jumlah_sisa"
        '
        'indeks
        '
        Me.indeks.Caption = "Indeks"
        Me.indeks.FieldName = "indeks"
        Me.indeks.Name = "indeks"
        Me.indeks.OptionsColumn.AllowEdit = False
        Me.indeks.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'jumlahk
        '
        Me.jumlahk.Caption = "GridColumn1"
        Me.jumlahk.FieldName = "jumlahk"
        Me.jumlahk.Name = "jumlahk"
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
        Me.Panel1.Size = New System.Drawing.Size(926, 107)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtJam)
        Me.Panel3.Controls.Add(Me.txtJadwal)
        Me.Panel3.Controls.Add(Me.txtMesin)
        Me.Panel3.Controls.Add(Me.txtPegawai)
        Me.Panel3.Controls.Add(Me.txtGroup)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(649, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 107)
        Me.Panel3.TabIndex = 9
        '
        'txtJam
        '
        Me.txtJam.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtJam.Location = New System.Drawing.Point(0, 80)
        Me.txtJam.Name = "txtJam"
        Me.txtJam.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtJam.Properties.Appearance.Options.UseBackColor = True
        Me.txtJam.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJam.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Jadwal"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Kd_Jadwal", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.txtJam.Properties.DisplayMember = "Desc_Data"
        Me.txtJam.Properties.NullText = "[Pilih Jam Kerja]"
        Me.txtJam.Properties.ReadOnly = True
        Me.txtJam.Properties.ShowHeader = False
        Me.txtJam.Properties.ValueMember = "Id_Data"
        Me.txtJam.Size = New System.Drawing.Size(264, 20)
        Me.txtJam.TabIndex = 12
        '
        'txtJadwal
        '
        Me.txtJadwal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtJadwal.Location = New System.Drawing.Point(0, 60)
        Me.txtJadwal.Name = "txtJadwal"
        Me.txtJadwal.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtJadwal.Properties.Appearance.Options.UseBackColor = True
        Me.txtJadwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJadwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Jadwal"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Kd_Jadwal", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.txtJadwal.Properties.DisplayMember = "Desc_Data"
        Me.txtJadwal.Properties.NullText = "[Pilih Jadwal Kerja]"
        Me.txtJadwal.Properties.ReadOnly = True
        Me.txtJadwal.Properties.ShowHeader = False
        Me.txtJadwal.Properties.ValueMember = "Id_Data"
        Me.txtJadwal.Size = New System.Drawing.Size(264, 20)
        Me.txtJadwal.TabIndex = 5
        '
        'txtMesin
        '
        Me.txtMesin.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtMesin.Location = New System.Drawing.Point(0, 40)
        Me.txtMesin.Name = "txtMesin"
        Me.txtMesin.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMesin.Properties.Appearance.Options.UseBackColor = True
        Me.txtMesin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMesin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_mesin", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("deskripsi", "Mesin")})
        Me.txtMesin.Properties.DisplayMember = "deskripsi"
        Me.txtMesin.Properties.NullText = "[Pilih Mesin]"
        Me.txtMesin.Properties.ReadOnly = True
        Me.txtMesin.Properties.ValueMember = "kd_mesin"
        Me.txtMesin.Size = New System.Drawing.Size(264, 20)
        Me.txtMesin.TabIndex = 9
        '
        'txtPegawai
        '
        Me.txtPegawai.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtPegawai.Location = New System.Drawing.Point(0, 20)
        Me.txtPegawai.Name = "txtPegawai"
        Me.txtPegawai.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPegawai.Properties.Appearance.Options.UseBackColor = True
        Me.txtPegawai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPegawai.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Pegawai", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama")})
        Me.txtPegawai.Properties.DisplayMember = "Nama_Pegawai"
        Me.txtPegawai.Properties.NullText = "[Pilih Pegawai]"
        Me.txtPegawai.Properties.ReadOnly = True
        Me.txtPegawai.Properties.ValueMember = "Kode_Pegawai"
        Me.txtPegawai.Size = New System.Drawing.Size(264, 20)
        Me.txtPegawai.TabIndex = 11
        '
        'txtGroup
        '
        Me.txtGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtGroup.Location = New System.Drawing.Point(0, 0)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGroup.Properties.Appearance.Options.UseBackColor = True
        Me.txtGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGroup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Group")})
        Me.txtGroup.Properties.DisplayMember = "Desc_Data"
        Me.txtGroup.Properties.NullText = "[Pilih Group Kerja]"
        Me.txtGroup.Properties.ReadOnly = True
        Me.txtGroup.Properties.ShowHeader = False
        Me.txtGroup.Properties.ValueMember = "Id_Data"
        Me.txtGroup.Size = New System.Drawing.Size(264, 20)
        Me.txtGroup.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(458, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 107)
        Me.Panel2.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Location = New System.Drawing.Point(0, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(191, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Jam Kerja :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(0, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Jadwal Kerja :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Location = New System.Drawing.Point(0, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nama Mesin :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Location = New System.Drawing.Point(0, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Pegawai  :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Group Kerja : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TextEdit1)
        Me.Panel7.Controls.Add(Me.txtkgtn)
        Me.Panel7.Controls.Add(Me.txtKegiatan)
        Me.Panel7.Controls.Add(Me.lkspk)
        Me.Panel7.Controls.Add(Me.lkspkreal)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(267, 107)
        Me.Panel7.TabIndex = 7
        '
        'TextEdit1
        '
        Me.TextEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(0, 80)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.NullText = "[Pilih No SPK]"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(267, 20)
        Me.TextEdit1.TabIndex = 15
        '
        'txtkgtn
        '
        Me.txtkgtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtkgtn.Location = New System.Drawing.Point(0, 60)
        Me.txtkgtn.Name = "txtkgtn"
        Me.txtkgtn.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtkgtn.Properties.Appearance.Options.UseBackColor = True
        Me.txtkgtn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtkgtn.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Kegiatan SPK")})
        Me.txtkgtn.Properties.DisplayMember = "Desc_Data"
        Me.txtkgtn.Properties.NullText = "[Pilih Kegiatan Spk]"
        Me.txtkgtn.Properties.ReadOnly = True
        Me.txtkgtn.Properties.ShowHeader = False
        Me.txtkgtn.Properties.ValueMember = "Id_Data"
        Me.txtkgtn.Size = New System.Drawing.Size(267, 20)
        Me.txtkgtn.TabIndex = 11
        '
        'txtKegiatan
        '
        Me.txtKegiatan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKegiatan.Location = New System.Drawing.Point(0, 40)
        Me.txtKegiatan.Name = "txtKegiatan"
        Me.txtKegiatan.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtKegiatan.Properties.Appearance.Options.UseBackColor = True
        Me.txtKegiatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKegiatan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Desc_Data")})
        Me.txtKegiatan.Properties.DisplayMember = "Desc_Data"
        Me.txtKegiatan.Properties.NullText = "[Pilih kegiatan]"
        Me.txtKegiatan.Properties.ReadOnly = True
        Me.txtKegiatan.Properties.ShowHeader = False
        Me.txtKegiatan.Properties.ValueMember = "Id_Data"
        Me.txtKegiatan.Size = New System.Drawing.Size(267, 20)
        Me.txtKegiatan.TabIndex = 10
        '
        'lkspk
        '
        Me.lkspk.Dock = System.Windows.Forms.DockStyle.Top
        Me.lkspk.Location = New System.Drawing.Point(0, 20)
        Me.lkspk.Name = "lkspk"
        Me.lkspk.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.lkspk.Properties.Appearance.Options.UseBackColor = True
        Me.lkspk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkspk.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_spk_man", "no_spk_man")})
        Me.lkspk.Properties.DisplayMember = "no_spk_man"
        Me.lkspk.Properties.NullText = "[Pilih No SPK ]"
        Me.lkspk.Properties.ReadOnly = True
        Me.lkspk.Properties.ValueMember = "no_spk_man"
        Me.lkspk.Size = New System.Drawing.Size(267, 20)
        Me.lkspk.TabIndex = 13
        '
        'lkspkreal
        '
        Me.lkspkreal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lkspkreal.Location = New System.Drawing.Point(0, 0)
        Me.lkspkreal.Name = "lkspkreal"
        Me.lkspkreal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkspkreal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_spk_man_rls")})
        Me.lkspkreal.Properties.DisplayMember = "no_spk_man_rls"
        Me.lkspkreal.Properties.NullText = "[Pilih No SPK Realisasi]"
        Me.lkspkreal.Properties.ValueMember = "no_spk_man_rls"
        Me.lkspkreal.Size = New System.Drawing.Size(267, 20)
        Me.lkspkreal.TabIndex = 14
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 107)
        Me.Panel6.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "No Spk Realisasi Koreksi : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Kegiatan SPK : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Kegiatan  : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "No Spk :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "No SPK Realisasi : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlAtas.Size = New System.Drawing.Size(926, 31)
        Me.pnlAtas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(441, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "REALISASI SPK KOREKSI"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlbawah
        '
        Me.pnlbawah.BackColor = System.Drawing.Color.Maroon
        Me.pnlbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbawah.Location = New System.Drawing.Point(0, 384)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(926, 16)
        Me.pnlbawah.TabIndex = 2
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Location = New System.Drawing.Point(612, -2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "New"
        Me.btnNew.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(693, -2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Edit"
        Me.SimpleButton1.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Location = New System.Drawing.Point(774, -2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "Cancel"
        Me.SimpleButton2.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Location = New System.Drawing.Point(855, -2)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 5
        Me.SimpleButton3.Text = "Delete"
        Me.SimpleButton3.Visible = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Location = New System.Drawing.Point(531, -2)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 11
        Me.SimpleButton4.Text = "Save"
        Me.SimpleButton4.Visible = False
        '
        'frmzRlsSpkkoreksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 436)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmzRlsSpkkoreksi"
        Me.Text = "frmzRlsSpkInsentif"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtJam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJadwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPegawai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtkgtn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKegiatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkspk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkspkreal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nama_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cltipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clkain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_realisasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_kerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents indeks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKegiatan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents kd_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_rework As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtkgtn As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents jumlah_delay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtJam As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtJadwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMesin As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtPegawai As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkspk As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkspkreal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents jumlah_koreksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlahk As DevExpress.XtraGrid.Columns.GridColumn
End Class
