<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKompensasiHutang
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKompensasiHutang))
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlNotaDetil = New System.Windows.Forms.Panel
        Me.gcNotaDetil = New DevExpress.XtraGrid.GridControl
        Me.gvNotaDetil = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prev_no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookUpNota = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookUpKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtNominal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.jml_piut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bb = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlKompensasi = New System.Windows.Forms.Panel
        Me.gcKompensasi = New DevExpress.XtraGrid.GridControl
        Me.gvKompensasi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupRekening = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_buku_pusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupPusatBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_bayar1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAngka = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.keterangan1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlNota = New System.Windows.Forms.Panel
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.pnlKet = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.txtKet = New DevExpress.XtraEditors.MemoEdit
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.pnlKurs = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.txtKurs = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.pnlValuta = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lookValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.pnlNoRef = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtNoRef = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.pnlTanggal = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.pnlNoTrans = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtNoTrans = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel44 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.jml_ppn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.biaya_lain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pendp_lain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.errData = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.pnl.SuspendLayout()
        Me.pnlNotaDetil.SuspendLayout()
        CType(Me.gcNotaDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNotaDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNominal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKompensasi.SuspendLayout()
        CType(Me.gcKompensasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvKompensasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupRekening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupPusatBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNota.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.pnlKet.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel20.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.pnlKurs.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlValuta.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.lookValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNoRef.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTanggal.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.deTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNoTrans.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 75)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(288, 5)
        Me.Panel14.TabIndex = 20
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.pnlNotaDetil)
        Me.pnl.Controls.Add(Me.pnlKompensasi)
        Me.pnl.Controls.Add(Me.pnlNota)
        Me.pnl.Controls.Add(Me.Panel44)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(990, 746)
        Me.pnl.TabIndex = 1
        '
        'pnlNotaDetil
        '
        Me.pnlNotaDetil.Controls.Add(Me.gcNotaDetil)
        Me.pnlNotaDetil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNotaDetil.Location = New System.Drawing.Point(0, 432)
        Me.pnlNotaDetil.Name = "pnlNotaDetil"
        Me.pnlNotaDetil.Size = New System.Drawing.Size(990, 284)
        Me.pnlNotaDetil.TabIndex = 106
        '
        'gcNotaDetil
        '
        Me.gcNotaDetil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcNotaDetil.Location = New System.Drawing.Point(0, 0)
        Me.gcNotaDetil.LookAndFeel.SkinName = "Blue"
        Me.gcNotaDetil.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.gcNotaDetil.MainView = Me.gvNotaDetil
        Me.gcNotaDetil.Name = "gcNotaDetil"
        Me.gcNotaDetil.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookUpNota, Me.txtNominal, Me.lookUpKartu})
        Me.gcNotaDetil.Size = New System.Drawing.Size(990, 284)
        Me.gcNotaDetil.TabIndex = 14
        Me.gcNotaDetil.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNotaDetil})
        '
        'gvNotaDetil
        '
        Me.gvNotaDetil.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvNotaDetil.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.Empty.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gvNotaDetil.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gvNotaDetil.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvNotaDetil.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.gvNotaDetil.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.gvNotaDetil.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.gvNotaDetil.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvNotaDetil.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.gvNotaDetil.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.gvNotaDetil.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gvNotaDetil.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvNotaDetil.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvNotaDetil.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.OddRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.OddRow.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gvNotaDetil.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gvNotaDetil.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvNotaDetil.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.gvNotaDetil.Appearance.Preview.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.Preview.Options.UseBorderColor = True
        Me.gvNotaDetil.Appearance.Preview.Options.UseFont = True
        Me.gvNotaDetil.Appearance.Preview.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gvNotaDetil.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvNotaDetil.Appearance.Row.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.Row.Options.UseForeColor = True
        Me.gvNotaDetil.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvNotaDetil.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.gvNotaDetil.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvNotaDetil.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvNotaDetil.Appearance.VertLine.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gvNotaDetil.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvNotaDetil.Appearance.ViewCaption.Options.UseBackColor = True
        Me.gvNotaDetil.Appearance.ViewCaption.Options.UseFont = True
        Me.gvNotaDetil.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gvNotaDetil.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvNotaDetil.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.gvNotaDetil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.prev_no_inv, Me.kd_kartu, Me.jml_tagihan, Me.jml_piut, Me.Keterangan, Me.jml_bayar, Me.bb})
        Me.gvNotaDetil.GridControl = Me.gcNotaDetil
        Me.gvNotaDetil.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.gvNotaDetil.Name = "gvNotaDetil"
        Me.gvNotaDetil.NewItemRowText = "[Tambah Data Baru Disini]"
        Me.gvNotaDetil.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvNotaDetil.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvNotaDetil.OptionsDetail.EnableMasterViewMode = False
        Me.gvNotaDetil.OptionsDetail.ShowDetailTabs = False
        Me.gvNotaDetil.OptionsView.EnableAppearanceEvenRow = True
        Me.gvNotaDetil.OptionsView.EnableAppearanceOddRow = True
        Me.gvNotaDetil.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvNotaDetil.OptionsView.ShowFooter = True
        Me.gvNotaDetil.OptionsView.ShowGroupPanel = False
        Me.gvNotaDetil.OptionsView.ShowIndicator = False
        Me.gvNotaDetil.OptionsView.ShowViewCaption = True
        Me.gvNotaDetil.PaintStyleName = "Office2003"
        Me.gvNotaDetil.ViewCaption = "Detil Pelunasan"
        Me.gvNotaDetil.ViewCaptionHeight = 20
        '
        'no_seq
        '
        Me.no_seq.AppearanceCell.Options.UseTextOptions = True
        Me.no_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.no_seq.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.no_seq.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.no_seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_seq.AppearanceHeader.Options.UseBackColor = True
        Me.no_seq.AppearanceHeader.Options.UseBorderColor = True
        Me.no_seq.AppearanceHeader.Options.UseFont = True
        Me.no_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.AllowFocus = False
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 55
        '
        'prev_no_inv
        '
        Me.prev_no_inv.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prev_no_inv.AppearanceCell.Options.UseFont = True
        Me.prev_no_inv.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.prev_no_inv.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.prev_no_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prev_no_inv.AppearanceHeader.Options.UseBackColor = True
        Me.prev_no_inv.AppearanceHeader.Options.UseFont = True
        Me.prev_no_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.prev_no_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.prev_no_inv.Caption = "No. Nota"
        Me.prev_no_inv.ColumnEdit = Me.lookUpNota
        Me.prev_no_inv.FieldName = "prev_no_inv"
        Me.prev_no_inv.Name = "prev_no_inv"
        Me.prev_no_inv.Visible = True
        Me.prev_no_inv.VisibleIndex = 1
        Me.prev_no_inv.Width = 284
        '
        'lookUpNota
        '
        Me.lookUpNota.Appearance.BackColor2 = System.Drawing.Color.Silver
        Me.lookUpNota.Appearance.Options.UseBackColor = True
        Me.lookUpNota.AutoHeight = False
        Me.lookUpNota.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookUpNota.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lookUpNota.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpNota.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lookUpNota.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_inv", 30, "No. Invoice"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tgl_inv", "Tgl. Invoice", 20, DevExpress.Utils.FormatType.DateTime, "d MMM yyyy", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_akhir", "Jumlah Akhir", 25, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tgl_jth_tempo", "Tgl. Jth Tempo", 25, DevExpress.Utils.FormatType.DateTime, "d MMM yyyy", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lookUpNota.DisplayMember = "no_inv"
        Me.lookUpNota.HideSelection = False
        Me.lookUpNota.Name = "lookUpNota"
        Me.lookUpNota.NullText = "[Pilih Nomor Nota]"
        Me.lookUpNota.ShowFooter = False
        Me.lookUpNota.ShowPopupShadow = False
        Me.lookUpNota.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookUpNota.ValidateOnEnterKey = True
        Me.lookUpNota.ValueMember = "no_inv"
        '
        'kd_kartu
        '
        Me.kd_kartu.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_kartu.AppearanceHeader.Options.UseFont = True
        Me.kd_kartu.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_kartu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_kartu.Caption = "Kartu"
        Me.kd_kartu.ColumnEdit = Me.lookUpKartu
        Me.kd_kartu.FieldName = "kd_kartu"
        Me.kd_kartu.Name = "kd_kartu"
        Me.kd_kartu.OptionsColumn.AllowEdit = False
        Me.kd_kartu.OptionsColumn.AllowFocus = False
        Me.kd_kartu.OptionsColumn.ReadOnly = True
        Me.kd_kartu.Visible = True
        Me.kd_kartu.VisibleIndex = 2
        Me.kd_kartu.Width = 115
        '
        'lookUpKartu
        '
        Me.lookUpKartu.AutoHeight = False
        Me.lookUpKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpKartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Name5")})
        Me.lookUpKartu.Name = "lookUpKartu"
        Me.lookUpKartu.NullText = "[Tidak ada kartu]"
        '
        'jml_tagihan
        '
        Me.jml_tagihan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.jml_tagihan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_tagihan.AppearanceCell.Options.UseBackColor = True
        Me.jml_tagihan.AppearanceCell.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.jml_tagihan.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.jml_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_tagihan.AppearanceHeader.Options.UseBackColor = True
        Me.jml_tagihan.AppearanceHeader.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_tagihan.Caption = "Jumlah Tagihan"
        Me.jml_tagihan.ColumnEdit = Me.txtNominal
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.OptionsColumn.AllowEdit = False
        Me.jml_tagihan.OptionsColumn.AllowFocus = False
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 3
        Me.jml_tagihan.Width = 143
        '
        'txtNominal
        '
        Me.txtNominal.AutoHeight = False
        Me.txtNominal.Mask.EditMask = "n2"
        Me.txtNominal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNominal.Mask.UseMaskAsDisplayFormat = True
        Me.txtNominal.Name = "txtNominal"
        '
        'jml_piut
        '
        Me.jml_piut.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_piut.AppearanceHeader.Options.UseFont = True
        Me.jml_piut.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_piut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_piut.Caption = "Jumlah Lunas"
        Me.jml_piut.ColumnEdit = Me.txtNominal
        Me.jml_piut.FieldName = "jml_piut"
        Me.jml_piut.Name = "jml_piut"
        Me.jml_piut.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_piut.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_piut.Visible = True
        Me.jml_piut.VisibleIndex = 4
        Me.jml_piut.Width = 125
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keterangan.AppearanceCell.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Keterangan.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keterangan.AppearanceHeader.Options.UseBackColor = True
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 5
        Me.Keterangan.Width = 292
        '
        'jml_bayar
        '
        Me.jml_bayar.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.jml_bayar.AppearanceCell.Options.UseBackColor = True
        Me.jml_bayar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_bayar.AppearanceHeader.Options.UseFont = True
        Me.jml_bayar.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_bayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_bayar.Caption = "Sub Total"
        Me.jml_bayar.DisplayFormat.FormatString = "n2"
        Me.jml_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar.FieldName = "jml_bayar"
        Me.jml_bayar.Name = "jml_bayar"
        Me.jml_bayar.OptionsColumn.AllowEdit = False
        Me.jml_bayar.OptionsColumn.ReadOnly = True
        Me.jml_bayar.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_bayar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar.UnboundExpression = "[jml_piut] + [jml_ppn] + [pendp_lain] - [biaya_lain]"
        Me.jml_bayar.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.jml_bayar.Width = 105
        '
        'bb
        '
        Me.bb.Caption = "Rekening"
        Me.bb.FieldName = "kd_buku_besar"
        Me.bb.Name = "bb"
        '
        'pnlKompensasi
        '
        Me.pnlKompensasi.Controls.Add(Me.gcKompensasi)
        Me.pnlKompensasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKompensasi.Location = New System.Drawing.Point(0, 168)
        Me.pnlKompensasi.Name = "pnlKompensasi"
        Me.pnlKompensasi.Size = New System.Drawing.Size(990, 264)
        Me.pnlKompensasi.TabIndex = 105
        '
        'gcKompensasi
        '
        Me.gcKompensasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcKompensasi.Location = New System.Drawing.Point(0, 0)
        Me.gcKompensasi.LookAndFeel.SkinName = "Blue"
        Me.gcKompensasi.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.gcKompensasi.MainView = Me.gvKompensasi
        Me.gcKompensasi.Name = "gcKompensasi"
        Me.gcKompensasi.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupRekening, Me.txtAngka, Me.lookupPusatBiaya})
        Me.gcKompensasi.Size = New System.Drawing.Size(990, 264)
        Me.gcKompensasi.TabIndex = 35
        Me.gcKompensasi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvKompensasi})
        '
        'gvKompensasi
        '
        Me.gvKompensasi.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvKompensasi.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvKompensasi.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvKompensasi.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKompensasi.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvKompensasi.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKompensasi.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvKompensasi.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvKompensasi.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvKompensasi.Appearance.Empty.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvKompensasi.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvKompensasi.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvKompensasi.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvKompensasi.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvKompensasi.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvKompensasi.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvKompensasi.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvKompensasi.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvKompensasi.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvKompensasi.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvKompensasi.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvKompensasi.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvKompensasi.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvKompensasi.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvKompensasi.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvKompensasi.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvKompensasi.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvKompensasi.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvKompensasi.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvKompensasi.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvKompensasi.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvKompensasi.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvKompensasi.Appearance.GroupRow.Options.UseFont = True
        Me.gvKompensasi.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvKompensasi.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKompensasi.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvKompensasi.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvKompensasi.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvKompensasi.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKompensasi.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvKompensasi.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvKompensasi.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.OddRow.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.OddRow.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKompensasi.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvKompensasi.Appearance.Preview.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.Preview.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvKompensasi.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvKompensasi.Appearance.Row.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.Row.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvKompensasi.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvKompensasi.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvKompensasi.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvKompensasi.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvKompensasi.Appearance.VertLine.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gvKompensasi.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvKompensasi.Appearance.ViewCaption.Options.UseBackColor = True
        Me.gvKompensasi.Appearance.ViewCaption.Options.UseFont = True
        Me.gvKompensasi.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gvKompensasi.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvKompensasi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.gvKompensasi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq1, Me.kd_buku_besar, Me.kd_buku_pusat, Me.jml_bayar1, Me.keterangan1, Me.GridColumn7})
        Me.gvKompensasi.GridControl = Me.gcKompensasi
        Me.gvKompensasi.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.gvKompensasi.Name = "gvKompensasi"
        Me.gvKompensasi.NewItemRowText = "[Tambah Data Baru Disini]"
        Me.gvKompensasi.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvKompensasi.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvKompensasi.OptionsDetail.EnableMasterViewMode = False
        Me.gvKompensasi.OptionsDetail.ShowDetailTabs = False
        Me.gvKompensasi.OptionsView.EnableAppearanceEvenRow = True
        Me.gvKompensasi.OptionsView.EnableAppearanceOddRow = True
        Me.gvKompensasi.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvKompensasi.OptionsView.ShowFooter = True
        Me.gvKompensasi.OptionsView.ShowGroupPanel = False
        Me.gvKompensasi.OptionsView.ShowIndicator = False
        Me.gvKompensasi.OptionsView.ShowViewCaption = True
        Me.gvKompensasi.PaintStyleName = "Office2003"
        Me.gvKompensasi.ViewCaption = "Data Kompensasi"
        Me.gvKompensasi.ViewCaptionHeight = 20
        '
        'no_seq1
        '
        Me.no_seq1.AppearanceCell.Options.UseTextOptions = True
        Me.no_seq1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq1.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.no_seq1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.no_seq1.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.no_seq1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_seq1.AppearanceHeader.Options.UseBackColor = True
        Me.no_seq1.AppearanceHeader.Options.UseBorderColor = True
        Me.no_seq1.AppearanceHeader.Options.UseFont = True
        Me.no_seq1.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq1.Caption = "No."
        Me.no_seq1.FieldName = "no_seq"
        Me.no_seq1.Name = "no_seq1"
        Me.no_seq1.OptionsColumn.AllowEdit = False
        Me.no_seq1.OptionsColumn.AllowFocus = False
        Me.no_seq1.Visible = True
        Me.no_seq1.VisibleIndex = 0
        Me.no_seq1.Width = 58
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_buku_besar.AppearanceCell.Options.UseFont = True
        Me.kd_buku_besar.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.kd_buku_besar.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.kd_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_buku_besar.AppearanceHeader.Options.UseBackColor = True
        Me.kd_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_besar.Caption = "Rekening"
        Me.kd_buku_besar.ColumnEdit = Me.lookupRekening
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 1
        Me.kd_buku_besar.Width = 224
        '
        'lookupRekening
        '
        Me.lookupRekening.Appearance.BackColor2 = System.Drawing.Color.Silver
        Me.lookupRekening.Appearance.Options.UseBackColor = True
        Me.lookupRekening.AutoHeight = False
        Me.lookupRekening.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookupRekening.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lookupRekening.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupRekening.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lookupRekening.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", 25, "Rekening")})
        Me.lookupRekening.DisplayMember = "no_inv"
        Me.lookupRekening.HideSelection = False
        Me.lookupRekening.Name = "lookupRekening"
        Me.lookupRekening.NullText = "[Pilih Rekening]"
        Me.lookupRekening.ShowFooter = False
        Me.lookupRekening.ShowPopupShadow = False
        Me.lookupRekening.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookupRekening.ValidateOnEnterKey = True
        Me.lookupRekening.ValueMember = "no_inv"
        '
        'kd_buku_pusat
        '
        Me.kd_buku_pusat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_buku_pusat.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_pusat.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_pusat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_pusat.Caption = "Pusat Biaya"
        Me.kd_buku_pusat.ColumnEdit = Me.lookupPusatBiaya
        Me.kd_buku_pusat.FieldName = "kd_buku_pusat"
        Me.kd_buku_pusat.Name = "kd_buku_pusat"
        Me.kd_buku_pusat.Visible = True
        Me.kd_buku_pusat.VisibleIndex = 2
        Me.kd_buku_pusat.Width = 215
        '
        'lookupPusatBiaya
        '
        Me.lookupPusatBiaya.Appearance.BackColor2 = System.Drawing.Color.Silver
        Me.lookupPusatBiaya.Appearance.Options.UseBackColor = True
        Me.lookupPusatBiaya.AutoHeight = False
        Me.lookupPusatBiaya.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookupPusatBiaya.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lookupPusatBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupPusatBiaya.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lookupPusatBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Pusat Biaya")})
        Me.lookupPusatBiaya.Name = "lookupPusatBiaya"
        Me.lookupPusatBiaya.NullText = "[Pilih Pusat Biaya]"
        Me.lookupPusatBiaya.ShowFooter = False
        Me.lookupPusatBiaya.ShowPopupShadow = False
        Me.lookupPusatBiaya.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookupPusatBiaya.ValidateOnEnterKey = True
        '
        'jml_bayar1
        '
        Me.jml_bayar1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.jml_bayar1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_bayar1.AppearanceCell.Options.UseBackColor = True
        Me.jml_bayar1.AppearanceCell.Options.UseFont = True
        Me.jml_bayar1.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.jml_bayar1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.jml_bayar1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_bayar1.AppearanceHeader.Options.UseBackColor = True
        Me.jml_bayar1.AppearanceHeader.Options.UseFont = True
        Me.jml_bayar1.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_bayar1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_bayar1.Caption = "Jumlah Kompensasi"
        Me.jml_bayar1.ColumnEdit = Me.txtAngka
        Me.jml_bayar1.DisplayFormat.FormatString = "n2"
        Me.jml_bayar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar1.FieldName = "jml_bayar"
        Me.jml_bayar1.Name = "jml_bayar1"
        Me.jml_bayar1.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_bayar1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar1.Visible = True
        Me.jml_bayar1.VisibleIndex = 3
        Me.jml_bayar1.Width = 171
        '
        'txtAngka
        '
        Me.txtAngka.AutoHeight = False
        Me.txtAngka.Mask.EditMask = "n2"
        Me.txtAngka.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAngka.Mask.UseMaskAsDisplayFormat = True
        Me.txtAngka.Name = "txtAngka"
        '
        'keterangan1
        '
        Me.keterangan1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan1.AppearanceCell.Options.UseFont = True
        Me.keterangan1.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.keterangan1.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.keterangan1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan1.AppearanceHeader.Options.UseBackColor = True
        Me.keterangan1.AppearanceHeader.Options.UseFont = True
        Me.keterangan1.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan1.Caption = "Keterangan"
        Me.keterangan1.FieldName = "keterangan"
        Me.keterangan1.Name = "keterangan1"
        Me.keterangan1.Visible = True
        Me.keterangan1.VisibleIndex = 4
        Me.keterangan1.Width = 361
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Sub Total"
        Me.GridColumn7.DisplayFormat.FormatString = "n2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "jml_bayar"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn7.UnboundExpression = "[jml_piut] + [jml_ppn] + [pendp_lain] - [biaya_lain]"
        Me.GridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn7.Width = 105
        '
        'pnlNota
        '
        Me.pnlNota.Controls.Add(Me.Panel23)
        Me.pnlNota.Controls.Add(Me.Panel21)
        Me.pnlNota.Controls.Add(Me.Panel9)
        Me.pnlNota.Controls.Add(Me.Panel2)
        Me.pnlNota.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNota.Location = New System.Drawing.Point(0, 35)
        Me.pnlNota.Name = "pnlNota"
        Me.pnlNota.Size = New System.Drawing.Size(990, 133)
        Me.pnlNota.TabIndex = 104
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.pnlKet)
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(402, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(502, 133)
        Me.Panel23.TabIndex = 33
        '
        'pnlKet
        '
        Me.pnlKet.Controls.Add(Me.Panel19)
        Me.pnlKet.Controls.Add(Me.Panel20)
        Me.pnlKet.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKet.Location = New System.Drawing.Point(0, 5)
        Me.pnlKet.Name = "pnlKet"
        Me.pnlKet.Size = New System.Drawing.Size(502, 100)
        Me.pnlKet.TabIndex = 30
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.txtKet)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel19.Location = New System.Drawing.Point(110, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(390, 100)
        Me.Panel19.TabIndex = 26
        '
        'txtKet
        '
        Me.txtKet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKet.Location = New System.Drawing.Point(0, 0)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Properties.ValidateOnEnterKey = True
        Me.txtKet.Size = New System.Drawing.Size(390, 100)
        Me.txtKet.TabIndex = 0
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.Panel18)
        Me.Panel20.Controls.Add(Me.Panel17)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(110, 100)
        Me.Panel20.TabIndex = 25
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 20)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(110, 40)
        Me.Panel18.TabIndex = 22
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Label17)
        Me.Panel17.Controls.Add(Me.Label16)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(110, 20)
        Me.Panel17.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(100, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 20)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = ":"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 20)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Keterangan"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(502, 5)
        Me.Panel24.TabIndex = 11
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel21.Location = New System.Drawing.Point(392, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(10, 133)
        Me.Panel21.TabIndex = 32
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.pnlKurs)
        Me.Panel9.Controls.Add(Me.Panel15)
        Me.Panel9.Controls.Add(Me.pnlValuta)
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Controls.Add(Me.pnlNoRef)
        Me.Panel9.Controls.Add(Me.Panel12)
        Me.Panel9.Controls.Add(Me.pnlTanggal)
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Controls.Add(Me.pnlNoTrans)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(104, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(288, 133)
        Me.Panel9.TabIndex = 31
        '
        'pnlKurs
        '
        Me.pnlKurs.Controls.Add(Me.Panel8)
        Me.pnlKurs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKurs.Location = New System.Drawing.Point(0, 105)
        Me.pnlKurs.Name = "pnlKurs"
        Me.pnlKurs.Size = New System.Drawing.Size(288, 20)
        Me.pnlKurs.TabIndex = 23
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtKurs)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(250, 20)
        Me.Panel8.TabIndex = 12
        '
        'txtKurs
        '
        Me.txtKurs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKurs.EnterMoveNextControl = True
        Me.txtKurs.Location = New System.Drawing.Point(110, 0)
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtKurs.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKurs.Properties.Appearance.Options.UseBackColor = True
        Me.txtKurs.Properties.Appearance.Options.UseForeColor = True
        Me.txtKurs.Properties.DisplayFormat.FormatString = "n2"
        Me.txtKurs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKurs.Properties.EditFormat.FormatString = "n2"
        Me.txtKurs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKurs.Properties.Mask.EditMask = "n2"
        Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtKurs.Properties.ValidateOnEnterKey = True
        Me.txtKurs.Size = New System.Drawing.Size(140, 20)
        Me.txtKurs.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(100, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 20)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = ":"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Kurs"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 100)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(288, 5)
        Me.Panel15.TabIndex = 22
        '
        'pnlValuta
        '
        Me.pnlValuta.Controls.Add(Me.Panel7)
        Me.pnlValuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlValuta.Location = New System.Drawing.Point(0, 80)
        Me.pnlValuta.Name = "pnlValuta"
        Me.pnlValuta.Size = New System.Drawing.Size(288, 20)
        Me.pnlValuta.TabIndex = 21
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lookValuta)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 20)
        Me.Panel7.TabIndex = 11
        '
        'lookValuta
        '
        Me.lookValuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lookValuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lookValuta.EnterMoveNextControl = True
        Me.lookValuta.Location = New System.Drawing.Point(110, 0)
        Me.lookValuta.Name = "lookValuta"
        Me.lookValuta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lookValuta.Properties.Appearance.Options.UseBackColor = True
        Me.lookValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Valuta")})
        Me.lookValuta.Properties.DisplayMember = "Nama_Valuta"
        Me.lookValuta.Properties.NullText = "[Valuta]"
        Me.lookValuta.Properties.ValidateOnEnterKey = True
        Me.lookValuta.Properties.ValueMember = "Kode_Valuta"
        Me.lookValuta.Size = New System.Drawing.Size(90, 20)
        Me.lookValuta.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(100, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = ":"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Valuta"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlNoRef
        '
        Me.pnlNoRef.Controls.Add(Me.Panel4)
        Me.pnlNoRef.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNoRef.Location = New System.Drawing.Point(0, 55)
        Me.pnlNoRef.Name = "pnlNoRef"
        Me.pnlNoRef.Size = New System.Drawing.Size(288, 20)
        Me.pnlNoRef.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtNoRef)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(225, 20)
        Me.Panel4.TabIndex = 9
        '
        'txtNoRef
        '
        Me.txtNoRef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoRef.EnterMoveNextControl = True
        Me.txtNoRef.Location = New System.Drawing.Point(110, 0)
        Me.txtNoRef.Name = "txtNoRef"
        Me.txtNoRef.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNoRef.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoRef.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoRef.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoRef.Properties.ValidateOnEnterKey = True
        Me.txtNoRef.Size = New System.Drawing.Size(115, 20)
        Me.txtNoRef.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(100, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. Referensi"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 50)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(288, 5)
        Me.Panel12.TabIndex = 16
        '
        'pnlTanggal
        '
        Me.pnlTanggal.Controls.Add(Me.Panel3)
        Me.pnlTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTanggal.Location = New System.Drawing.Point(0, 30)
        Me.pnlTanggal.Name = "pnlTanggal"
        Me.pnlTanggal.Size = New System.Drawing.Size(288, 20)
        Me.pnlTanggal.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.deTanggal)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 20)
        Me.Panel3.TabIndex = 3
        '
        'deTanggal
        '
        Me.deTanggal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deTanggal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.EnterMoveNextControl = True
        Me.deTanggal.Location = New System.Drawing.Point(110, 0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.deTanggal.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "d MMM yyyy"
        Me.deTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deTanggal.Properties.ShowPopupShadow = False
        Me.deTanggal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deTanggal.Properties.ValidateOnEnterKey = True
        Me.deTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTanggal.Size = New System.Drawing.Size(140, 20)
        Me.deTanggal.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(100, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = ":"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 25)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(288, 5)
        Me.Panel11.TabIndex = 14
        '
        'pnlNoTrans
        '
        Me.pnlNoTrans.Controls.Add(Me.Panel5)
        Me.pnlNoTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNoTrans.Location = New System.Drawing.Point(0, 5)
        Me.pnlNoTrans.Name = "pnlNoTrans"
        Me.pnlNoTrans.Size = New System.Drawing.Size(288, 20)
        Me.pnlNoTrans.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtNoTrans)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(275, 20)
        Me.Panel5.TabIndex = 2
        '
        'txtNoTrans
        '
        Me.txtNoTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoTrans.Location = New System.Drawing.Point(110, 0)
        Me.txtNoTrans.Name = "txtNoTrans"
        Me.txtNoTrans.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoTrans.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoTrans.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoTrans.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoTrans.Properties.ReadOnly = True
        Me.txtNoTrans.Size = New System.Drawing.Size(165, 20)
        Me.txtNoTrans.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(100, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = ":"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "No Transaksi"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(288, 5)
        Me.Panel10.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(104, 133)
        Me.Panel2.TabIndex = 0
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.Maroon
        Me.Panel44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel44.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel44.Location = New System.Drawing.Point(0, 716)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(990, 30)
        Me.Panel44.TabIndex = 103
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 35)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(523, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM PELUNASAN KOMPENSASI HUTANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'jml_ppn
        '
        Me.jml_ppn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_ppn.AppearanceCell.Options.UseFont = True
        Me.jml_ppn.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.jml_ppn.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.jml_ppn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_ppn.AppearanceHeader.Options.UseBackColor = True
        Me.jml_ppn.AppearanceHeader.Options.UseFont = True
        Me.jml_ppn.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_ppn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_ppn.Caption = "Jml. PPN"
        Me.jml_ppn.DisplayFormat.FormatString = "n2"
        Me.jml_ppn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_ppn.FieldName = "jml_ppn"
        Me.jml_ppn.Name = "jml_ppn"
        Me.jml_ppn.Visible = True
        Me.jml_ppn.VisibleIndex = 3
        Me.jml_ppn.Width = 89
        '
        'biaya_lain
        '
        Me.biaya_lain.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biaya_lain.AppearanceCell.Options.UseFont = True
        Me.biaya_lain.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.biaya_lain.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.biaya_lain.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biaya_lain.AppearanceHeader.Options.UseBackColor = True
        Me.biaya_lain.AppearanceHeader.Options.UseFont = True
        Me.biaya_lain.AppearanceHeader.Options.UseTextOptions = True
        Me.biaya_lain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.biaya_lain.Caption = "Biaya lainya"
        Me.biaya_lain.DisplayFormat.FormatString = "n2"
        Me.biaya_lain.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.biaya_lain.FieldName = "biaya_lain"
        Me.biaya_lain.Name = "biaya_lain"
        Me.biaya_lain.Visible = True
        Me.biaya_lain.VisibleIndex = 3
        Me.biaya_lain.Width = 86
        '
        'pendp_lain
        '
        Me.pendp_lain.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pendp_lain.AppearanceCell.Options.UseFont = True
        Me.pendp_lain.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pendp_lain.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.pendp_lain.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pendp_lain.AppearanceHeader.Options.UseBackColor = True
        Me.pendp_lain.AppearanceHeader.Options.UseFont = True
        Me.pendp_lain.AppearanceHeader.Options.UseTextOptions = True
        Me.pendp_lain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pendp_lain.Caption = "Pendp Lainya"
        Me.pendp_lain.DisplayFormat.FormatString = "n2"
        Me.pendp_lain.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pendp_lain.FieldName = "pendp_lain"
        Me.pendp_lain.Name = "pendp_lain"
        Me.pendp_lain.Visible = True
        Me.pendp_lain.VisibleIndex = 3
        Me.pendp_lain.Width = 122
        '
        'jml_diskon
        '
        Me.jml_diskon.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_diskon.AppearanceCell.Options.UseFont = True
        Me.jml_diskon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_diskon.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_diskon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_diskon.Caption = "Potongan"
        Me.jml_diskon.DisplayFormat.FormatString = "n2"
        Me.jml_diskon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_diskon.FieldName = "jml_diskon"
        Me.jml_diskon.Name = "jml_diskon"
        Me.jml_diskon.Visible = True
        Me.jml_diskon.VisibleIndex = 3
        '
        'errData
        '
        Me.errData.ContainerControl = Me
        '
        'frmKompensasiHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 746)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmKompensasiHutang"
        Me.Text = "frmKompensasiHutang"
        Me.pnl.ResumeLayout(False)
        Me.pnlNotaDetil.ResumeLayout(False)
        CType(Me.gcNotaDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNotaDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNominal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKompensasi.ResumeLayout(False)
        CType(Me.gcKompensasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvKompensasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupRekening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupPusatBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNota.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.pnlKet.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel20.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.pnlKurs.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlValuta.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.lookValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNoRef.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTanggal.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.deTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNoTrans.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlNotaDetil As System.Windows.Forms.Panel
    Friend WithEvents gcNotaDetil As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNotaDetil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prev_no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookUpNota As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookUpKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNominal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents jml_piut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlKompensasi As System.Windows.Forms.Panel
    Friend WithEvents gcKompensasi As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvKompensasi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupRekening As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_buku_pusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupPusatBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jml_bayar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAngka As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents keterangan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlNota As System.Windows.Forms.Panel
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents pnlKet As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents txtKet As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents pnlKurs As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents pnlValuta As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lookValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnlNoRef As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtNoRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents pnlTanggal As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents pnlNoTrans As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtNoTrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel44 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents jml_ppn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents biaya_lain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pendp_lain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents errData As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
