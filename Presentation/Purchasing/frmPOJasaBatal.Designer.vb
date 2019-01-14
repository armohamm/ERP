<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOJasaBatal
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOJasaBatal))
        Me.GVDetail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.djumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dharga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dprosen_diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.djml_diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.flagbonus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QTY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prosen_diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Reptglkirim = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.DtTanggalgrid = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.repflag_diskon = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
        Me.Pnl = New System.Windows.Forms.Panel
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.dtBayar = New DevExpress.XtraEditors.DateEdit
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.txtJmlDiskon = New DevExpress.XtraEditors.TextEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.CEPPN = New DevExpress.XtraEditors.CheckEdit
        Me.txtJmlDiskon1 = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtJmlTotal = New DevExpress.XtraEditors.TextEdit
        Me.txtJmlPPN = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtketBatal = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.txtstatus = New DevExpress.XtraEditors.TextEdit
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.dtKirim = New DevExpress.XtraEditors.DateEdit
        Me.txtkurs = New DevExpress.XtraEditors.TextEdit
        Me.LEValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.PnlSpaceAtas = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LESupllier = New DevExpress.XtraEditors.LookUpEdit
        Me.LEPR = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNoRef = New DevExpress.XtraEditors.TextEdit
        Me.dtTanggal = New DevExpress.XtraEditors.DateEdit
        Me.txtNoPO = New DevExpress.XtraEditors.TextEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RentangBayar = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reptglkirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reptglkirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repflag_diskon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBayar.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlDiskon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlDiskon1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        CType(Me.txtstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtkurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.LESupllier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEPR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentangBayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVDetail
        '
        Me.GVDetail.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDetail.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVDetail.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVDetail.Appearance.Empty.Options.UseBackColor = True
        Me.GVDetail.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDetail.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVDetail.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVDetail.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVDetail.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVDetail.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVDetail.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDetail.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVDetail.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GVDetail.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVDetail.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVDetail.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDetail.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVDetail.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVDetail.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVDetail.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDetail.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVDetail.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVDetail.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDetail.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDetail.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVDetail.Appearance.Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GVDetail.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVDetail.Appearance.Preview.Options.UseBackColor = True
        Me.GVDetail.Appearance.Preview.Options.UseFont = True
        Me.GVDetail.Appearance.Preview.Options.UseForeColor = True
        Me.GVDetail.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.Row.Options.UseForeColor = True
        Me.GVDetail.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVDetail.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVDetail.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDetail.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVDetail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVDetail.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.djumlah, Me.GridColumn5, Me.GridColumn6, Me.dharga, Me.dprosen_diskon, Me.djml_diskon, Me.dtotal, Me.GridColumn11, Me.flagbonus})
        Me.GVDetail.GridControl = Me.GC
        Me.GVDetail.Name = "GVDetail"
        Me.GVDetail.OptionsView.ShowGroupPanel = False
        Me.GVDetail.ViewCaption = "Detail"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "No"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 37
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nama Barang"
        Me.GridColumn2.ColumnEdit = Me.repBrg
        Me.GridColumn2.FieldName = "kd_stok"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 239
        '
        'repBrg
        '
        Me.repBrg.AutoHeight = False
        Me.repBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", "Satuan")})
        Me.repBrg.DisplayMember = "Nama_Barang"
        Me.repBrg.HideSelection = False
        Me.repBrg.Name = "repBrg"
        Me.repBrg.NullText = "[Pilih Barang]"
        Me.repBrg.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repBrg.ValueMember = "Kode_Barang"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Satuan"
        Me.GridColumn3.FieldName = "kd_satuan"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 51
        '
        'djumlah
        '
        Me.djumlah.Caption = "Jumlah"
        Me.djumlah.FieldName = "qty"
        Me.djumlah.Name = "djumlah"
        Me.djumlah.OptionsColumn.AllowEdit = False
        Me.djumlah.Visible = True
        Me.djumlah.VisibleIndex = 3
        Me.djumlah.Width = 52
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Keterangan"
        Me.GridColumn5.FieldName = "keterangan"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 9
        Me.GridColumn5.Width = 216
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Spek Barang"
        Me.GridColumn6.FieldName = "spek_brg"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 74
        '
        'dharga
        '
        Me.dharga.Caption = "Harga"
        Me.dharga.DisplayFormat.FormatString = "n2"
        Me.dharga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.dharga.FieldName = "harga"
        Me.dharga.Name = "dharga"
        Me.dharga.OptionsColumn.AllowEdit = False
        Me.dharga.Visible = True
        Me.dharga.VisibleIndex = 4
        Me.dharga.Width = 77
        '
        'dprosen_diskon
        '
        Me.dprosen_diskon.Caption = "Diskon %"
        Me.dprosen_diskon.FieldName = "prosen_diskon"
        Me.dprosen_diskon.Name = "dprosen_diskon"
        Me.dprosen_diskon.Visible = True
        Me.dprosen_diskon.VisibleIndex = 5
        Me.dprosen_diskon.Width = 70
        '
        'djml_diskon
        '
        Me.djml_diskon.Caption = "Diskon Rp"
        Me.djml_diskon.DisplayFormat.FormatString = "n2"
        Me.djml_diskon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.djml_diskon.FieldName = "jml_diskon"
        Me.djml_diskon.Name = "djml_diskon"
        Me.djml_diskon.Visible = True
        Me.djml_diskon.VisibleIndex = 6
        Me.djml_diskon.Width = 76
        '
        'dtotal
        '
        Me.dtotal.Caption = "Sub Total"
        Me.dtotal.DisplayFormat.FormatString = "n4"
        Me.dtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.dtotal.FieldName = "total"
        Me.dtotal.Name = "dtotal"
        Me.dtotal.OptionsColumn.AllowEdit = False
        Me.dtotal.Visible = True
        Me.dtotal.VisibleIndex = 7
        Me.dtotal.Width = 102
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Tgl Kedatangan"
        Me.GridColumn11.FieldName = "tgl_kirim"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 8
        Me.GridColumn11.Width = 110
        '
        'flagbonus
        '
        Me.flagbonus.Caption = "Bonus"
        Me.flagbonus.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.flagbonus.FieldName = "flagbonus"
        Me.flagbonus.Name = "flagbonus"
        Me.flagbonus.Visible = True
        Me.flagbonus.VisibleIndex = 10
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.DisplayValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.DisplayValueGrayed = "T"
        Me.RepositoryItemCheckEdit1.DisplayValueUnchecked = "T"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueGrayed = "T"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "T"
        '
        'GC
        '
        GridLevelNode1.LevelTemplate = Me.GVDetail
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(-8, 151)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpStatus, Me.DtTanggalgrid, Me.repBrg, Me.Reptglkirim, Me.repflag_diskon, Me.RepositoryItemColorEdit1, Me.RepositoryItemCheckEdit1})
        Me.GC.Size = New System.Drawing.Size(1108, 238)
        Me.GC.TabIndex = 112
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GVDetail})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.Satuan, Me.Harga, Me.QTY, Me.prosen_diskon, Me.jml_diskon, Me.Total, Me.tgl_kirim, Me.Keterangan})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.PaintStyleName = "Office2003"
        '
        'no_seq
        '
        Me.no_seq.AppearanceCell.Options.UseTextOptions = True
        Me.no_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_seq.AppearanceHeader.Options.UseFont = True
        Me.no_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.Caption = "No"
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.AllowFocus = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 38
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_stok.AppearanceHeader.Options.UseFont = True
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Nama Jasa"
        Me.kd_stok.ColumnEdit = Me.repBrg
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 221
        '
        'Satuan
        '
        Me.Satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Satuan.AppearanceHeader.Options.UseFont = True
        Me.Satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.Satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "kd_satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.OptionsColumn.AllowFocus = False
        Me.Satuan.Width = 83
        '
        'Harga
        '
        Me.Harga.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harga.AppearanceHeader.Options.UseFont = True
        Me.Harga.AppearanceHeader.Options.UseTextOptions = True
        Me.Harga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Harga.Caption = "Harga"
        Me.Harga.DisplayFormat.FormatString = "n4"
        Me.Harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Harga.FieldName = "harga"
        Me.Harga.Name = "Harga"
        Me.Harga.Width = 85
        '
        'QTY
        '
        Me.QTY.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTY.AppearanceHeader.Options.UseFont = True
        Me.QTY.AppearanceHeader.Options.UseTextOptions = True
        Me.QTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.QTY.Caption = "Qty"
        Me.QTY.FieldName = "qty"
        Me.QTY.Name = "QTY"
        Me.QTY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.QTY.Width = 66
        '
        'prosen_diskon
        '
        Me.prosen_diskon.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.prosen_diskon.AppearanceHeader.Options.UseFont = True
        Me.prosen_diskon.Caption = "Diskon %"
        Me.prosen_diskon.FieldName = "prosen_diskon"
        Me.prosen_diskon.Name = "prosen_diskon"
        Me.prosen_diskon.Width = 71
        '
        'jml_diskon
        '
        Me.jml_diskon.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_diskon.AppearanceHeader.Options.UseFont = True
        Me.jml_diskon.Caption = "Diskon RP"
        Me.jml_diskon.FieldName = "jml_diskon"
        Me.jml_diskon.Name = "jml_diskon"
        Me.jml_diskon.Width = 98
        '
        'Total
        '
        Me.Total.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.AppearanceHeader.Options.UseFont = True
        Me.Total.AppearanceHeader.Options.UseTextOptions = True
        Me.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Total.Caption = "Total"
        Me.Total.DisplayFormat.FormatString = "n4"
        Me.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.FieldName = "total"
        Me.Total.Name = "Total"
        Me.Total.OptionsColumn.AllowEdit = False
        Me.Total.OptionsColumn.AllowFocus = False
        Me.Total.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 2
        Me.Total.Width = 97
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_kirim.AppearanceHeader.Options.UseFont = True
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.Caption = "Tgl. Kedatangan"
        Me.tgl_kirim.ColumnEdit = Me.Reptglkirim
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 3
        Me.tgl_kirim.Width = 114
        '
        'Reptglkirim
        '
        Me.Reptglkirim.AutoHeight = False
        Me.Reptglkirim.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Reptglkirim.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Reptglkirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Reptglkirim.EditFormat.FormatString = "dd/MM/yyyy"
        Me.Reptglkirim.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Reptglkirim.Mask.EditMask = "dd/MM/yyyy"
        Me.Reptglkirim.Name = "Reptglkirim"
        Me.Reptglkirim.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 4
        Me.Keterangan.Width = 122
        '
        'rpStatus
        '
        Me.rpStatus.AutoHeight = False
        Me.rpStatus.AutoWidth = True
        Me.rpStatus.Caption = "TIDAK AKTIF"
        Me.rpStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.rpStatus.DisplayValueChecked = "AKTIF"
        Me.rpStatus.DisplayValueUnchecked = "TIDAK AKTIF"
        Me.rpStatus.FullFocusRect = True
        Me.rpStatus.Name = "rpStatus"
        Me.rpStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.rpStatus.NullText = "TIDAK AKTIF"
        Me.rpStatus.ValueChecked = "Y"
        Me.rpStatus.ValueUnchecked = "T"
        '
        'DtTanggalgrid
        '
        Me.DtTanggalgrid.AutoHeight = False
        Me.DtTanggalgrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTanggalgrid.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DtTanggalgrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DtTanggalgrid.EditFormat.FormatString = "dd/MM/yyyy"
        Me.DtTanggalgrid.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DtTanggalgrid.Mask.EditMask = "dd/MM/yyyy"
        Me.DtTanggalgrid.Name = "DtTanggalgrid"
        Me.DtTanggalgrid.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'repflag_diskon
        '
        Me.repflag_diskon.AutoHeight = False
        Me.repflag_diskon.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repflag_diskon.DisplayValueChecked = "Diskon %"
        Me.repflag_diskon.DisplayValueUnchecked = "Diskon RP"
        Me.repflag_diskon.Name = "repflag_diskon"
        Me.repflag_diskon.ValueChecked = "Y"
        Me.repflag_diskon.ValueUnchecked = "T"
        '
        'RepositoryItemColorEdit1
        '
        Me.RepositoryItemColorEdit1.AutoHeight = False
        Me.RepositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemColorEdit1.Name = "RepositoryItemColorEdit1"
        '
        'Pnl
        '
        Me.Pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pnl.Controls.Add(Me.RentangBayar)
        Me.Pnl.Controls.Add(Me.GC)
        Me.Pnl.Controls.Add(Me.CheckEdit2)
        Me.Pnl.Controls.Add(Me.dtBayar)
        Me.Pnl.Controls.Add(Me.CheckEdit1)
        Me.Pnl.Controls.Add(Me.txtJmlDiskon)
        Me.Pnl.Controls.Add(Me.Label18)
        Me.Pnl.Controls.Add(Me.CEPPN)
        Me.Pnl.Controls.Add(Me.txtJmlDiskon1)
        Me.Pnl.Controls.Add(Me.Label11)
        Me.Pnl.Controls.Add(Me.txtSubTotal)
        Me.Pnl.Controls.Add(Me.Label15)
        Me.Pnl.Controls.Add(Me.txtJmlTotal)
        Me.Pnl.Controls.Add(Me.txtJmlPPN)
        Me.Pnl.Controls.Add(Me.Label14)
        Me.Pnl.Controls.Add(Me.Label12)
        Me.Pnl.Controls.Add(Me.txtketBatal)
        Me.Pnl.Controls.Add(Me.Label17)
        Me.Pnl.Controls.Add(Me.Label13)
        Me.Pnl.Controls.Add(Me.SimpleButton1)
        Me.Pnl.Controls.Add(Me.btSimpan)
        Me.Pnl.Controls.Add(Me.pnlTengahAtas)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(6, 6)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(1093, 541)
        Me.Pnl.TabIndex = 0
        '
        'CheckEdit2
        '
        Me.CheckEdit2.EditValue = "T"
        Me.CheckEdit2.Location = New System.Drawing.Point(140, 413)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CheckEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit2.Properties.Caption = "TAGIHAN"
        Me.CheckEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit2.Properties.DisplayValueChecked = "Y"
        Me.CheckEdit2.Properties.DisplayValueGrayed = "T"
        Me.CheckEdit2.Properties.DisplayValueUnchecked = "T"
        Me.CheckEdit2.Properties.NullText = "NON PPN"
        Me.CheckEdit2.Properties.ValueChecked = "Y"
        Me.CheckEdit2.Properties.ValueGrayed = "T"
        Me.CheckEdit2.Properties.ValueUnchecked = "T"
        Me.CheckEdit2.Size = New System.Drawing.Size(129, 22)
        Me.CheckEdit2.TabIndex = 110
        '
        'dtBayar
        '
        Me.dtBayar.EditValue = New Date(2011, 4, 14, 14, 33, 22, 762)
        Me.dtBayar.Location = New System.Drawing.Point(337, 430)
        Me.dtBayar.Name = "dtBayar"
        Me.dtBayar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBayar.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtBayar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtBayar.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtBayar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtBayar.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtBayar.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtBayar.Size = New System.Drawing.Size(127, 20)
        Me.dtBayar.TabIndex = 109
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(347, 510)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "DISKON %"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Properties.DisplayValueChecked = "DISKON %"
        Me.CheckEdit1.Properties.DisplayValueUnchecked = "DISKON RP"
        Me.CheckEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit1.Properties.NullText = "DISKON RP"
        Me.CheckEdit1.Properties.ValueChecked = "Y"
        Me.CheckEdit1.Properties.ValueUnchecked = "T"
        Me.CheckEdit1.Size = New System.Drawing.Size(108, 22)
        Me.CheckEdit1.TabIndex = 107
        Me.CheckEdit1.Visible = False
        '
        'txtJmlDiskon
        '
        Me.txtJmlDiskon.EditValue = "0"
        Me.txtJmlDiskon.Location = New System.Drawing.Point(461, 516)
        Me.txtJmlDiskon.Name = "txtJmlDiskon"
        Me.txtJmlDiskon.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtJmlDiskon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtJmlDiskon.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlDiskon.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlDiskon.Properties.Appearance.Options.UseFont = True
        Me.txtJmlDiskon.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlDiskon.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJmlDiskon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJmlDiskon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlDiskon.Properties.MaxLength = 3
        Me.txtJmlDiskon.Size = New System.Drawing.Size(50, 21)
        Me.txtJmlDiskon.TabIndex = 106
        Me.txtJmlDiskon.Visible = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(247, 514)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 20)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = "Flag Diskon :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Visible = False
        '
        'CEPPN
        '
        Me.CEPPN.Location = New System.Drawing.Point(888, 443)
        Me.CEPPN.Name = "CEPPN"
        Me.CEPPN.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEPPN.Properties.Appearance.Options.UseForeColor = True
        Me.CEPPN.Properties.Caption = "NON PPN"
        Me.CEPPN.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CEPPN.Properties.DisplayValueChecked = "PPN"
        Me.CEPPN.Properties.DisplayValueUnchecked = "NON PPN"
        Me.CEPPN.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CEPPN.Properties.NullText = "NON PPN"
        Me.CEPPN.Properties.ValueChecked = "Y"
        Me.CEPPN.Properties.ValueUnchecked = "T"
        Me.CEPPN.Size = New System.Drawing.Size(68, 22)
        Me.CEPPN.TabIndex = 104
        '
        'txtJmlDiskon1
        '
        Me.txtJmlDiskon1.EditValue = "0"
        Me.txtJmlDiskon1.Location = New System.Drawing.Point(461, 538)
        Me.txtJmlDiskon1.Name = "txtJmlDiskon1"
        Me.txtJmlDiskon1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtJmlDiskon1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtJmlDiskon1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlDiskon1.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlDiskon1.Properties.Appearance.Options.UseFont = True
        Me.txtJmlDiskon1.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlDiskon1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJmlDiskon1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJmlDiskon1.Properties.DisplayFormat.FormatString = "n2"
        Me.txtJmlDiskon1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlDiskon1.Properties.Mask.BeepOnError = True
        Me.txtJmlDiskon1.Properties.Mask.EditMask = "d"
        Me.txtJmlDiskon1.Size = New System.Drawing.Size(190, 21)
        Me.txtJmlDiskon1.TabIndex = 103
        Me.txtJmlDiskon1.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(315, 536)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 20)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Jumlah Diskon :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'txtSubTotal
        '
        Me.txtSubTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtSubTotal.Location = New System.Drawing.Point(888, 417)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSubTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSubTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSubTotal.Properties.Appearance.Options.UseFont = True
        Me.txtSubTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtSubTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSubTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txtSubTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubTotal.Properties.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(190, 21)
        Me.txtSubTotal.TabIndex = 101
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(742, 415)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 20)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Sub Total :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtJmlTotal
        '
        Me.txtJmlTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtJmlTotal.Location = New System.Drawing.Point(888, 468)
        Me.txtJmlTotal.Name = "txtJmlTotal"
        Me.txtJmlTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtJmlTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtJmlTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlTotal.Properties.Appearance.Options.UseFont = True
        Me.txtJmlTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJmlTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJmlTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txtJmlTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlTotal.Properties.ReadOnly = True
        Me.txtJmlTotal.Size = New System.Drawing.Size(190, 21)
        Me.txtJmlTotal.TabIndex = 99
        '
        'txtJmlPPN
        '
        Me.txtJmlPPN.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtJmlPPN.Location = New System.Drawing.Point(962, 444)
        Me.txtJmlPPN.Name = "txtJmlPPN"
        Me.txtJmlPPN.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtJmlPPN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtJmlPPN.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlPPN.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlPPN.Properties.Appearance.Options.UseFont = True
        Me.txtJmlPPN.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlPPN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJmlPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJmlPPN.Properties.DisplayFormat.FormatString = "n2"
        Me.txtJmlPPN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlPPN.Properties.ReadOnly = True
        Me.txtJmlPPN.Size = New System.Drawing.Size(116, 21)
        Me.txtJmlPPN.TabIndex = 98
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(742, 466)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 20)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Jumlah Total :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(742, 442)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 20)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Flag PPN :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtketBatal
        '
        Me.txtketBatal.Location = New System.Drawing.Point(140, 452)
        Me.txtketBatal.Multiline = True
        Me.txtketBatal.Name = "txtketBatal"
        Me.txtketBatal.Size = New System.Drawing.Size(247, 62)
        Me.txtketBatal.TabIndex = 88
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(-4, 451)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(142, 20)
        Me.Label17.TabIndex = 85
        Me.Label17.Text = "Keterangan Batal :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(-3, 430)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 20)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Tanggal Batal :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(449, 584)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 80
        Me.SimpleButton1.Text = "Edit"
        Me.SimpleButton1.Visible = False
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(344, 584)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btSimpan.TabIndex = 79
        Me.btSimpan.Text = "Simpan"
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.txtstatus)
        Me.pnlTengahAtas.Controls.Add(Me.txtKeterangan)
        Me.pnlTengahAtas.Controls.Add(Me.dtKirim)
        Me.pnlTengahAtas.Controls.Add(Me.txtkurs)
        Me.pnlTengahAtas.Controls.Add(Me.LEValuta)
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.PnlSpaceAtas)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Controls.Add(Me.Panel4)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 34)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(1093, 119)
        Me.pnlTengahAtas.TabIndex = 10
        '
        'txtstatus
        '
        Me.txtstatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtstatus.Location = New System.Drawing.Point(713, 100)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtstatus.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtstatus.Properties.Appearance.Options.UseBackColor = True
        Me.txtstatus.Properties.Appearance.Options.UseForeColor = True
        Me.txtstatus.Properties.ReadOnly = True
        Me.txtstatus.Size = New System.Drawing.Size(380, 20)
        Me.txtstatus.TabIndex = 14
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKeterangan.Location = New System.Drawing.Point(713, 60)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(380, 40)
        Me.txtKeterangan.TabIndex = 13
        '
        'dtKirim
        '
        Me.dtKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtKirim.EditValue = New Date(2011, 4, 14, 14, 49, 19, 0)
        Me.dtKirim.Location = New System.Drawing.Point(713, 40)
        Me.dtKirim.Name = "dtKirim"
        Me.dtKirim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtKirim.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtKirim.Size = New System.Drawing.Size(380, 20)
        Me.dtKirim.TabIndex = 9
        '
        'txtkurs
        '
        Me.txtkurs.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtkurs.Location = New System.Drawing.Point(713, 20)
        Me.txtkurs.Name = "txtkurs"
        Me.txtkurs.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtkurs.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtkurs.Properties.Appearance.Options.UseBackColor = True
        Me.txtkurs.Properties.Appearance.Options.UseForeColor = True
        Me.txtkurs.Size = New System.Drawing.Size(380, 20)
        Me.txtkurs.TabIndex = 8
        '
        'LEValuta
        '
        Me.LEValuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.LEValuta.Location = New System.Drawing.Point(713, 0)
        Me.LEValuta.Name = "LEValuta"
        Me.LEValuta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LEValuta.Properties.Appearance.Options.UseBackColor = True
        Me.LEValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Valuta")})
        Me.LEValuta.Properties.DisplayMember = "Nama_Valuta"
        Me.LEValuta.Properties.NullText = "[Valuta]"
        Me.LEValuta.Properties.ValueMember = "Kode_Valuta"
        Me.LEValuta.Size = New System.Drawing.Size(380, 20)
        Me.LEValuta.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(574, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(139, 119)
        Me.Panel3.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 20)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Status :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 40)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Keterangan :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Tanggal Janji Kirim :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Kurs :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Valuta :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlSpaceAtas
        '
        Me.PnlSpaceAtas.BackColor = System.Drawing.Color.Transparent
        Me.PnlSpaceAtas.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlSpaceAtas.Location = New System.Drawing.Point(369, 0)
        Me.PnlSpaceAtas.Name = "PnlSpaceAtas"
        Me.PnlSpaceAtas.Size = New System.Drawing.Size(205, 119)
        Me.PnlSpaceAtas.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LESupllier)
        Me.Panel5.Controls.Add(Me.LEPR)
        Me.Panel5.Controls.Add(Me.txtNoRef)
        Me.Panel5.Controls.Add(Me.dtTanggal)
        Me.Panel5.Controls.Add(Me.txtNoPO)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(142, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(227, 119)
        Me.Panel5.TabIndex = 3
        '
        'LESupllier
        '
        Me.LESupllier.Dock = System.Windows.Forms.DockStyle.Top
        Me.LESupllier.Location = New System.Drawing.Point(0, 80)
        Me.LESupllier.Name = "LESupllier"
        Me.LESupllier.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LESupllier.Properties.Appearance.Options.UseBackColor = True
        Me.LESupllier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LESupllier.Properties.DisplayMember = "Nama_Supplier"
        Me.LESupllier.Properties.NullText = "[Pilih Supplier]"
        Me.LESupllier.Properties.ReadOnly = True
        Me.LESupllier.Properties.ValueMember = "Kode_Supplier"
        Me.LESupllier.Size = New System.Drawing.Size(227, 20)
        Me.LESupllier.TabIndex = 9
        '
        'LEPR
        '
        Me.LEPR.Dock = System.Windows.Forms.DockStyle.Top
        Me.LEPR.Location = New System.Drawing.Point(0, 60)
        Me.LEPR.Name = "LEPR"
        Me.LEPR.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LEPR.Properties.Appearance.Options.UseBackColor = True
        Me.LEPR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEPR.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_pr", "NO PR")})
        Me.LEPR.Properties.DisplayMember = "no_pr"
        Me.LEPR.Properties.NullText = "[Pilih NO PR]"
        Me.LEPR.Properties.ValueMember = "no_pr"
        Me.LEPR.Size = New System.Drawing.Size(227, 20)
        Me.LEPR.TabIndex = 0
        '
        'txtNoRef
        '
        Me.txtNoRef.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNoRef.Location = New System.Drawing.Point(0, 40)
        Me.txtNoRef.Name = "txtNoRef"
        Me.txtNoRef.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNoRef.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoRef.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoRef.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoRef.Size = New System.Drawing.Size(227, 20)
        Me.txtNoRef.TabIndex = 6
        '
        'dtTanggal
        '
        Me.dtTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtTanggal.EditValue = New Date(2011, 4, 14, 14, 33, 22, 762)
        Me.dtTanggal.Location = New System.Drawing.Point(0, 20)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtTanggal.Size = New System.Drawing.Size(227, 20)
        Me.dtTanggal.TabIndex = 5
        '
        'txtNoPO
        '
        Me.txtNoPO.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNoPO.Location = New System.Drawing.Point(0, 0)
        Me.txtNoPO.Name = "txtNoPO"
        Me.txtNoPO.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoPO.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoPO.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoPO.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoPO.Properties.ReadOnly = True
        Me.txtNoPO.Size = New System.Drawing.Size(227, 20)
        Me.txtNoPO.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 119)
        Me.Panel4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Supplier :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No PR :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No Referensi :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tanggal :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "No PO :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel1.Size = New System.Drawing.Size(1093, 34)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " FORM BATAL PURCHASING ORDER JASA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RentangBayar
        '
        Me.RentangBayar.EnterMoveNextControl = True
        Me.RentangBayar.Location = New System.Drawing.Point(140, 431)
        Me.RentangBayar.Name = "RentangBayar"
        Me.RentangBayar.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.RentangBayar.Properties.Appearance.Options.UseBackColor = True
        Me.RentangBayar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RentangBayar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Lama Bayar", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RentangBayar.Properties.NullText = "[Pilih Lama Bayar]"
        Me.RentangBayar.Size = New System.Drawing.Size(189, 20)
        Me.RentangBayar.TabIndex = 113
        '
        'frmPOJasaBatal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 581)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmPOJasaBatal"
        Me.Text = "FORM BATAL PURCHASING JASA"
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reptglkirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reptglkirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repflag_diskon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl.ResumeLayout(False)
        Me.Pnl.PerformLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBayar.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlDiskon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlDiskon1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.pnlTengahAtas.PerformLayout()
        CType(Me.txtstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtkurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.LESupllier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEPR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentangBayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents LEValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PnlSpaceAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtNoRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNoPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtkurs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtKirim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents LEPR As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LESupllier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtstatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtketBatal As System.Windows.Forms.TextBox
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtJmlDiskon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CEPPN As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtJmlDiskon1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtJmlTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtJmlPPN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dtBayar As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents djumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dharga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dprosen_diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents djml_diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents flagbonus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prosen_diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Reptglkirim As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DtTanggalgrid As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repflag_diskon As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Friend WithEvents RentangBayar As DevExpress.XtraEditors.LookUpEdit
End Class
