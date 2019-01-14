<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmService
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
        Me.components = New System.ComponentModel.Container
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmService))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.gvd = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.KD_STOK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KD_SERVICE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBom = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KELUHAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.seq_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Garansi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repGaransi = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Me.Kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repkain = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repKdKain = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_seq_service = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.gvm = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_SEQ_SP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_SP_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KD_BARANG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBarang2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.QTY2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HARGA2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TOTAL2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MARGIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HARGAMARGIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jns_service = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.thnbuat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Bom_Service = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repJNSSRVSH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.pnlTengahBawah = New System.Windows.Forms.Panel
        Me.popBiaya = New DevExpress.XtraEditors.PopupContainerControl
        Me.GC_Biaya = New DevExpress.XtraGrid.GridControl
        Me.GV_Biaya = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.tglSO = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lblStatus = New System.Windows.Forms.Label
        Me.cmbJenisSP = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtKodeCustomer = New DevExpress.XtraEditors.TextEdit
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlbawah = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.txtBiaya2 = New DevExpress.XtraEditors.PopupContainerEdit
        Me.txtBiaya = New DevExpress.XtraEditors.SpinEdit
        Me.lblTotal = New DevExpress.XtraEditors.SpinEdit
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.txtNamaPnrm = New System.Windows.Forms.TextBox
        Me.txtAlamatKirim = New DevExpress.XtraEditors.MemoEdit
        Me.tglKirim = New DevExpress.XtraEditors.DateEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnBuku = New DevExpress.XtraEditors.SimpleButton
        Me.lbljudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DXEP = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.gvd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repGaransi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repkain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKdKain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBarang2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repJNSSRVSH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.pnlTengahBawah.SuspendLayout()
        CType(Me.popBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popBiaya.SuspendLayout()
        CType(Me.GC_Biaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Biaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.tglSO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.cmbJenisSP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtKodeCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlbawah.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel23.SuspendLayout()
        CType(Me.txtBiaya2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBiaya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel22.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.txtAlamatKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvd
        '
        Me.gvd.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvd.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvd.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvd.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvd.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvd.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvd.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvd.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvd.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvd.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvd.Appearance.Empty.Options.UseBackColor = True
        Me.gvd.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gvd.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gvd.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvd.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvd.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvd.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvd.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvd.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvd.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvd.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvd.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvd.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvd.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.gvd.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvd.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvd.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvd.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvd.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.gvd.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.gvd.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvd.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvd.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gvd.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvd.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvd.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvd.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvd.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvd.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvd.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvd.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvd.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvd.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvd.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvd.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvd.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvd.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvd.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvd.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvd.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvd.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvd.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvd.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvd.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvd.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.gvd.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.gvd.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvd.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvd.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvd.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gvd.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.gvd.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvd.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvd.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvd.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvd.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvd.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.OddRow.Options.UseBackColor = True
        Me.gvd.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvd.Appearance.OddRow.Options.UseForeColor = True
        Me.gvd.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gvd.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gvd.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvd.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.gvd.Appearance.Preview.Options.UseBackColor = True
        Me.gvd.Appearance.Preview.Options.UseBorderColor = True
        Me.gvd.Appearance.Preview.Options.UseFont = True
        Me.gvd.Appearance.Preview.Options.UseForeColor = True
        Me.gvd.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gvd.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvd.Appearance.Row.Options.UseBackColor = True
        Me.gvd.Appearance.Row.Options.UseForeColor = True
        Me.gvd.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvd.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvd.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvd.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.gvd.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvd.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvd.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvd.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvd.Appearance.VertLine.Options.UseBackColor = True
        Me.gvd.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KD_STOK2, Me.KD_SERVICE, Me.KELUHAN, Me.seq_sp, Me.Garansi, Me.Kain, Me.kd_kain, Me.biaya, Me.no_seq_service})
        Me.gvd.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvd.GridControl = Me.GC
        Me.gvd.Name = "gvd"
        Me.gvd.OptionsCustomization.AllowColumnMoving = False
        Me.gvd.OptionsCustomization.AllowFilter = False
        Me.gvd.OptionsCustomization.AllowGroup = False
        Me.gvd.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvd.OptionsCustomization.AllowSort = False
        Me.gvd.OptionsView.EnableAppearanceEvenRow = True
        Me.gvd.OptionsView.EnableAppearanceOddRow = True
        Me.gvd.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvd.OptionsView.RowAutoHeight = True
        Me.gvd.OptionsView.ShowGroupPanel = False
        '
        'KD_STOK2
        '
        Me.KD_STOK2.Caption = "KD_STOK"
        Me.KD_STOK2.FieldName = "kd_stok"
        Me.KD_STOK2.Name = "KD_STOK2"
        '
        'KD_SERVICE
        '
        Me.KD_SERVICE.Caption = "Service"
        Me.KD_SERVICE.ColumnEdit = Me.repBom
        Me.KD_SERVICE.FieldName = "Kode_Service"
        Me.KD_SERVICE.Name = "KD_SERVICE"
        Me.KD_SERVICE.Visible = True
        Me.KD_SERVICE.VisibleIndex = 1
        Me.KD_SERVICE.Width = 269
        '
        'repBom
        '
        Me.repBom.AutoHeight = False
        Me.repBom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBom.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_service", "Nama Service")})
        Me.repBom.DisplayMember = "nama_service"
        Me.repBom.Name = "repBom"
        Me.repBom.NullText = ""
        Me.repBom.ValueMember = "kd_service"
        '
        'KELUHAN
        '
        Me.KELUHAN.Caption = "Keluhan"
        Me.KELUHAN.FieldName = "Keluhan"
        Me.KELUHAN.Name = "KELUHAN"
        Me.KELUHAN.Width = 466
        '
        'seq_sp
        '
        Me.seq_sp.Caption = "sp_seq"
        Me.seq_sp.FieldName = "sp_seq"
        Me.seq_sp.Name = "seq_sp"
        '
        'Garansi
        '
        Me.Garansi.Caption = "Garansi"
        Me.Garansi.ColumnEdit = Me.repGaransi
        Me.Garansi.FieldName = "Garansi"
        Me.Garansi.Name = "Garansi"
        Me.Garansi.Visible = True
        Me.Garansi.VisibleIndex = 4
        Me.Garansi.Width = 104
        '
        'repGaransi
        '
        Me.repGaransi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.repGaransi.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Y", "Ya"), New DevExpress.XtraEditors.Controls.RadioGroupItem("T", "Tidak")})
        Me.repGaransi.Name = "repGaransi"
        '
        'Kain
        '
        Me.Kain.Caption = "Tipe Kain"
        Me.Kain.ColumnEdit = Me.repkain
        Me.Kain.FieldName = "Kain"
        Me.Kain.Name = "Kain"
        Me.Kain.Visible = True
        Me.Kain.VisibleIndex = 2
        Me.Kain.Width = 215
        '
        'repkain
        '
        Me.repkain.AutoHeight = False
        Me.repkain.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repkain.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Tipe Kain")})
        Me.repkain.DisplayMember = "Nama_Tipe"
        Me.repkain.Name = "repkain"
        Me.repkain.NullText = ""
        Me.repkain.ValueMember = "Kode_Tipe"
        '
        'kd_kain
        '
        Me.kd_kain.Caption = "Jenis Kain"
        Me.kd_kain.ColumnEdit = Me.repKdKain
        Me.kd_kain.FieldName = "kd_kain"
        Me.kd_kain.Name = "kd_kain"
        Me.kd_kain.Visible = True
        Me.kd_kain.VisibleIndex = 3
        Me.kd_kain.Width = 178
        '
        'repKdKain
        '
        Me.repKdKain.AutoHeight = False
        Me.repKdKain.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKdKain.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kain", "Kain")})
        Me.repKdKain.DisplayMember = "Kain"
        Me.repKdKain.DropDownRows = 12
        Me.repKdKain.Name = "repKdKain"
        Me.repKdKain.NullText = ""
        Me.repKdKain.PopupWidth = 300
        Me.repKdKain.ValueMember = "Kode_Kain"
        '
        'biaya
        '
        Me.biaya.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biaya.AppearanceCell.Options.UseFont = True
        Me.biaya.Caption = "Biaya"
        Me.biaya.DisplayFormat.FormatString = "N2"
        Me.biaya.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.biaya.FieldName = "biaya"
        Me.biaya.Name = "biaya"
        Me.biaya.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.biaya.Visible = True
        Me.biaya.VisibleIndex = 5
        Me.biaya.Width = 159
        '
        'no_seq_service
        '
        Me.no_seq_service.Caption = "No"
        Me.no_seq_service.FieldName = "no_seq"
        Me.no_seq_service.Name = "no_seq_service"
        Me.no_seq_service.OptionsColumn.AllowEdit = False
        Me.no_seq_service.Visible = True
        Me.no_seq_service.VisibleIndex = 0
        Me.no_seq_service.Width = 38
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvd
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.gvm
        GridLevelNode2.RelationName = "Level2"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repbarang, Me.repJNSSRVSH, Me.repGaransi, Me.repkain, Me.repKdKain, Me.repBom, Me.repBarang2})
        Me.GC.Size = New System.Drawing.Size(1008, 359)
        Me.GC.TabIndex = 0
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvm, Me.GV, Me.gvd})
        '
        'gvm
        '
        Me.gvm.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvm.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvm.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvm.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvm.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvm.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvm.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvm.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvm.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvm.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvm.Appearance.Empty.Options.UseBackColor = True
        Me.gvm.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gvm.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gvm.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvm.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvm.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvm.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvm.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvm.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvm.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvm.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvm.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvm.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvm.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.gvm.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvm.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvm.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvm.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvm.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.gvm.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.gvm.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvm.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvm.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gvm.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvm.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvm.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvm.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvm.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvm.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvm.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvm.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvm.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvm.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvm.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvm.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvm.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvm.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvm.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvm.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvm.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvm.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvm.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvm.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvm.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvm.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.gvm.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.gvm.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvm.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvm.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvm.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gvm.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.gvm.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvm.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvm.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvm.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvm.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gvm.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.OddRow.Options.UseBackColor = True
        Me.gvm.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvm.Appearance.OddRow.Options.UseForeColor = True
        Me.gvm.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gvm.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gvm.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvm.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.gvm.Appearance.Preview.Options.UseBackColor = True
        Me.gvm.Appearance.Preview.Options.UseBorderColor = True
        Me.gvm.Appearance.Preview.Options.UseFont = True
        Me.gvm.Appearance.Preview.Options.UseForeColor = True
        Me.gvm.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gvm.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvm.Appearance.Row.Options.UseBackColor = True
        Me.gvm.Appearance.Row.Options.UseForeColor = True
        Me.gvm.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvm.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvm.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvm.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.gvm.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvm.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvm.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvm.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gvm.Appearance.VertLine.Options.UseBackColor = True
        Me.gvm.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq2, Me.NO_SEQ_SP, Me.NO_SP_D, Me.KD_BARANG, Me.QTY2, Me.HARGA2, Me.TOTAL2, Me.MARGIN, Me.HARGAMARGIN})
        Me.gvm.GridControl = Me.GC
        Me.gvm.Name = "gvm"
        Me.gvm.OptionsCustomization.AllowColumnMoving = False
        Me.gvm.OptionsCustomization.AllowColumnResizing = False
        Me.gvm.OptionsCustomization.AllowFilter = False
        Me.gvm.OptionsCustomization.AllowGroup = False
        Me.gvm.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvm.OptionsCustomization.AllowSort = False
        Me.gvm.OptionsView.EnableAppearanceEvenRow = True
        Me.gvm.OptionsView.EnableAppearanceOddRow = True
        Me.gvm.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvm.OptionsView.ShowFooter = True
        Me.gvm.OptionsView.ShowGroupedColumns = True
        Me.gvm.OptionsView.ShowGroupPanel = False
        '
        'no_seq2
        '
        Me.no_seq2.Caption = "No"
        Me.no_seq2.FieldName = "NO_SEQ"
        Me.no_seq2.Name = "no_seq2"
        Me.no_seq2.OptionsColumn.AllowEdit = False
        Me.no_seq2.OptionsColumn.AllowFocus = False
        Me.no_seq2.Visible = True
        Me.no_seq2.VisibleIndex = 0
        Me.no_seq2.Width = 40
        '
        'NO_SEQ_SP
        '
        Me.NO_SEQ_SP.Caption = "NO_SEQ_SP"
        Me.NO_SEQ_SP.FieldName = "NO_SEQ_SP"
        Me.NO_SEQ_SP.Name = "NO_SEQ_SP"
        '
        'NO_SP_D
        '
        Me.NO_SP_D.Caption = "NO_SP_D"
        Me.NO_SP_D.FieldName = "NO_SP"
        Me.NO_SP_D.Name = "NO_SP_D"
        '
        'KD_BARANG
        '
        Me.KD_BARANG.Caption = "Deskripsi"
        Me.KD_BARANG.ColumnEdit = Me.repBarang2
        Me.KD_BARANG.FieldName = "KD_BARANG"
        Me.KD_BARANG.Name = "KD_BARANG"
        Me.KD_BARANG.Visible = True
        Me.KD_BARANG.VisibleIndex = 1
        Me.KD_BARANG.Width = 590
        '
        'repBarang2
        '
        Me.repBarang2.AutoHeight = False
        Me.repBarang2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBarang2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", 75, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 275, "Deskripsi"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", 50, "Satuan")})
        Me.repBarang2.DisplayMember = "Nama_Barang"
        Me.repBarang2.DropDownRows = 15
        Me.repBarang2.Name = "repBarang2"
        Me.repBarang2.NullText = ""
        Me.repBarang2.ValueMember = "Kode_Barang"
        '
        'QTY2
        '
        Me.QTY2.Caption = "Qty"
        Me.QTY2.FieldName = "QTY"
        Me.QTY2.Name = "QTY2"
        Me.QTY2.Visible = True
        Me.QTY2.VisibleIndex = 3
        Me.QTY2.Width = 55
        '
        'HARGA2
        '
        Me.HARGA2.Caption = "Harga"
        Me.HARGA2.FieldName = "HARGA"
        Me.HARGA2.Name = "HARGA2"
        Me.HARGA2.OptionsColumn.AllowEdit = False
        Me.HARGA2.OptionsColumn.AllowFocus = False
        Me.HARGA2.Width = 122
        '
        'TOTAL2
        '
        Me.TOTAL2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL2.AppearanceCell.Options.UseFont = True
        Me.TOTAL2.AppearanceCell.Options.UseTextOptions = True
        Me.TOTAL2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TOTAL2.Caption = "Total"
        Me.TOTAL2.DisplayFormat.FormatString = "n2"
        Me.TOTAL2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TOTAL2.FieldName = "TOTAL"
        Me.TOTAL2.Name = "TOTAL2"
        Me.TOTAL2.OptionsColumn.AllowEdit = False
        Me.TOTAL2.OptionsColumn.AllowFocus = False
        Me.TOTAL2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.TOTAL2.Visible = True
        Me.TOTAL2.VisibleIndex = 4
        Me.TOTAL2.Width = 175
        '
        'MARGIN
        '
        Me.MARGIN.Caption = "MARGIN"
        Me.MARGIN.FieldName = "MARGIN"
        Me.MARGIN.Name = "MARGIN"
        '
        'HARGAMARGIN
        '
        Me.HARGAMARGIN.AppearanceCell.Options.UseTextOptions = True
        Me.HARGAMARGIN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HARGAMARGIN.Caption = "Harga"
        Me.HARGAMARGIN.DisplayFormat.FormatString = "N2"
        Me.HARGAMARGIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.HARGAMARGIN.FieldName = "HARGAMARGIN"
        Me.HARGAMARGIN.Name = "HARGAMARGIN"
        Me.HARGAMARGIN.OptionsColumn.AllowEdit = False
        Me.HARGAMARGIN.OptionsColumn.AllowFocus = False
        Me.HARGAMARGIN.UnboundExpression = "([HARGA]+[HARGA] *[MARGIN]/100)"
        Me.HARGAMARGIN.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.HARGAMARGIN.Visible = True
        Me.HARGAMARGIN.VisibleIndex = 2
        Me.HARGAMARGIN.Width = 127
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseFont = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseBorderColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.Kd_Stok, Me.Qty, Me.Kd_satuan, Me.jns_service, Me.Keterangan, Me.thnbuat, Me.Harga, Me.Bom_Service})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", Me.Qty, "")})
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Klik Disini Untuk Menambah Item Baru"
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.SmartDetailHeight = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'No_seq
        '
        Me.No_seq.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.No_seq.AppearanceCell.Options.UseFont = True
        Me.No_seq.AppearanceCell.Options.UseTextOptions = True
        Me.No_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.No_seq.Caption = "No"
        Me.No_seq.FieldName = "No_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.OptionsColumn.AllowFocus = False
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 37
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Barang"
        Me.Kd_Stok.ColumnEdit = Me.repbarang
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 1
        Me.Kd_Stok.Width = 394
        '
        'repbarang
        '
        Me.repbarang.AutoHeight = False
        Me.repbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 100, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", "Unit")})
        Me.repbarang.DisplayMember = "Nama_Barang"
        Me.repbarang.HideSelection = False
        Me.repbarang.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.repbarang.Name = "repbarang"
        Me.repbarang.NullText = ""
        Me.repbarang.PopupFormMinSize = New System.Drawing.Size(300, 400)
        Me.repbarang.ShowHeader = False
        Me.repbarang.ShowLines = False
        Me.repbarang.ValueMember = "Kode_Barang"
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 2
        Me.Qty.Width = 39
        '
        'Kd_satuan
        '
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "Kd_satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.OptionsColumn.AllowEdit = False
        Me.Kd_satuan.OptionsColumn.AllowFocus = False
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 3
        Me.Kd_satuan.Width = 54
        '
        'jns_service
        '
        Me.jns_service.Caption = "Service"
        Me.jns_service.FieldName = "Jns_service"
        Me.jns_service.Name = "jns_service"
        Me.jns_service.Width = 109
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Service"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 4
        Me.Keterangan.Width = 277
        '
        'thnbuat
        '
        Me.thnbuat.Caption = "Thn Buat"
        Me.thnbuat.FieldName = "thnbuat"
        Me.thnbuat.Name = "thnbuat"
        Me.thnbuat.Width = 74
        '
        'Harga
        '
        Me.Harga.Caption = "Biaya"
        Me.Harga.DisplayFormat.FormatString = "n"
        Me.Harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Harga.FieldName = "harga"
        Me.Harga.Name = "Harga"
        Me.Harga.OptionsColumn.AllowEdit = False
        Me.Harga.OptionsColumn.AllowFocus = False
        Me.Harga.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Harga.Visible = True
        Me.Harga.VisibleIndex = 5
        Me.Harga.Width = 112
        '
        'Bom_Service
        '
        Me.Bom_Service.Caption = "Bom Service"
        Me.Bom_Service.ColumnEdit = Me.repBom
        Me.Bom_Service.FieldName = "Bom_Service"
        Me.Bom_Service.Name = "Bom_Service"
        Me.Bom_Service.Width = 200
        '
        'repJNSSRVSH
        '
        Me.repJNSSRVSH.AutoHeight = False
        Me.repJNSSRVSH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repJNSSRVSH.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", 250, "Name34"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Service", 200, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.repJNSSRVSH.DisplayMember = "Desc_Data"
        Me.repJNSSRVSH.HideSelection = False
        Me.repJNSSRVSH.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.repJNSSRVSH.Name = "repJNSSRVSH"
        Me.repJNSSRVSH.NullText = ""
        Me.repJNSSRVSH.PopupWidth = 250
        Me.repJNSSRVSH.ShowHeader = False
        Me.repJNSSRVSH.ShowLines = False
        Me.repJNSSRVSH.ValueMember = "Id_Data"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlbawah)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1008, 548)
        Me.pnl.TabIndex = 1
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.pnlTengahBawah)
        Me.pnlTengah.Controls.Add(Me.pnlTengahAtas)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 37)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(1008, 423)
        Me.pnlTengah.TabIndex = 4
        '
        'pnlTengahBawah
        '
        Me.pnlTengahBawah.Controls.Add(Me.popBiaya)
        Me.pnlTengahBawah.Controls.Add(Me.GC)
        Me.pnlTengahBawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengahBawah.Location = New System.Drawing.Point(0, 64)
        Me.pnlTengahBawah.Name = "pnlTengahBawah"
        Me.pnlTengahBawah.Size = New System.Drawing.Size(1008, 359)
        Me.pnlTengahBawah.TabIndex = 1
        '
        'popBiaya
        '
        Me.popBiaya.Controls.Add(Me.GC_Biaya)
        Me.popBiaya.Location = New System.Drawing.Point(293, 88)
        Me.popBiaya.LookAndFeel.SkinName = "Money Twins"
        Me.popBiaya.Name = "popBiaya"
        Me.popBiaya.Padding = New System.Windows.Forms.Padding(3)
        Me.popBiaya.Size = New System.Drawing.Size(398, 156)
        Me.popBiaya.TabIndex = 14
        '
        'GC_Biaya
        '
        Me.GC_Biaya.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Biaya.Location = New System.Drawing.Point(3, 3)
        Me.GC_Biaya.MainView = Me.GV_Biaya
        Me.GC_Biaya.Name = "GC_Biaya"
        Me.GC_Biaya.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repBiaya})
        Me.GC_Biaya.Size = New System.Drawing.Size(392, 150)
        Me.GC_Biaya.TabIndex = 0
        Me.GC_Biaya.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Biaya})
        '
        'GV_Biaya
        '
        Me.GV_Biaya.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_biaya, Me.GridColumn1})
        Me.GV_Biaya.GridControl = Me.GC_Biaya
        Me.GV_Biaya.Name = "GV_Biaya"
        Me.GV_Biaya.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Biaya.OptionsView.ShowFooter = True
        Me.GV_Biaya.OptionsView.ShowGroupPanel = False
        '
        'kd_biaya
        '
        Me.kd_biaya.Caption = "Nama Biaya"
        Me.kd_biaya.ColumnEdit = Me.repBiaya
        Me.kd_biaya.FieldName = "kd_biaya"
        Me.kd_biaya.Name = "kd_biaya"
        Me.kd_biaya.Visible = True
        Me.kd_biaya.VisibleIndex = 0
        Me.kd_biaya.Width = 244
        '
        'repBiaya
        '
        Me.repBiaya.AutoHeight = False
        Me.repBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("deskripsi", "Biaya")})
        Me.repBiaya.DisplayMember = "deskripsi"
        Me.repBiaya.Name = "repBiaya"
        Me.repBiaya.NullText = ""
        Me.repBiaya.ValueMember = "kd_biaya"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Besar Biaya"
        Me.GridColumn1.DisplayFormat.FormatString = "n2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "biaya"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 133
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.Panel2)
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Controls.Add(Me.Panel4)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(1008, 64)
        Me.pnlTengahAtas.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(735, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(118, 64)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tglSO)
        Me.Panel3.Controls.Add(Me.txtNomor)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(853, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(155, 64)
        Me.Panel3.TabIndex = 6
        '
        'tglSO
        '
        Me.tglSO.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglSO.Enabled = False
        Me.tglSO.Location = New System.Drawing.Point(0, 20)
        Me.tglSO.Name = "tglSO"
        Me.tglSO.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglSO.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tglSO.Properties.Appearance.Options.UseBackColor = True
        Me.tglSO.Properties.Appearance.Options.UseForeColor = True
        Me.tglSO.Properties.Appearance.Options.UseTextOptions = True
        Me.tglSO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tglSO.Properties.ReadOnly = True
        Me.tglSO.Size = New System.Drawing.Size(153, 20)
        Me.tglSO.TabIndex = 7
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Enabled = False
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.Appearance.Options.UseForeColor = True
        Me.txtNomor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNomor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(153, 20)
        Me.txtNomor.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblStatus)
        Me.Panel5.Controls.Add(Me.cmbJenisSP)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(142, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(367, 64)
        Me.Panel5.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Yellow
        Me.lblStatus.Location = New System.Drawing.Point(0, 40)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(365, 20)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = " [ New ]"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbJenisSP
        '
        Me.cmbJenisSP.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbJenisSP.EditValue = "UMUM"
        Me.cmbJenisSP.Enabled = False
        Me.cmbJenisSP.Location = New System.Drawing.Point(0, 20)
        Me.cmbJenisSP.Name = "cmbJenisSP"
        Me.cmbJenisSP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbJenisSP.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJenisSP.Properties.Appearance.Options.UseBackColor = True
        Me.cmbJenisSP.Properties.Appearance.Options.UseFont = True
        Me.cmbJenisSP.Properties.Appearance.Options.UseTextOptions = True
        Me.cmbJenisSP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmbJenisSP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbJenisSP.Properties.Items.AddRange(New Object() {"UMUM", "INTERNAL"})
        Me.cmbJenisSP.Properties.LookAndFeel.SkinName = "Blue"
        Me.cmbJenisSP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbJenisSP.Size = New System.Drawing.Size(125, 20)
        Me.cmbJenisSP.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtKodeCustomer)
        Me.Panel6.Controls.Add(Me.txtCustomer)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(365, 20)
        Me.Panel6.TabIndex = 2
        '
        'txtKodeCustomer
        '
        Me.txtKodeCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKodeCustomer.Enabled = False
        Me.txtKodeCustomer.Location = New System.Drawing.Point(249, 0)
        Me.txtKodeCustomer.Name = "txtKodeCustomer"
        Me.txtKodeCustomer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeCustomer.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKodeCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtKodeCustomer.Properties.Appearance.Options.UseForeColor = True
        Me.txtKodeCustomer.Properties.ReadOnly = True
        Me.txtKodeCustomer.Size = New System.Drawing.Size(116, 20)
        Me.txtKodeCustomer.TabIndex = 1
        '
        'txtCustomer
        '
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCustomer.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtCustomer.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCustomer.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtCustomer.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", 50, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 100, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Alamat1", 150, "Alamat")})
        Me.txtCustomer.Properties.NullText = "[Pilih Pelanggan]"
        Me.txtCustomer.Properties.PopupFormMinSize = New System.Drawing.Size(400, 300)
        Me.txtCustomer.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtCustomer.Properties.PopupWidth = 400
        Me.txtCustomer.Size = New System.Drawing.Size(249, 20)
        Me.txtCustomer.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 64)
        Me.Panel4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Status :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "* Jenis Order :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "* Customer :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlbawah
        '
        Me.pnlbawah.Controls.Add(Me.Panel11)
        Me.pnlbawah.Controls.Add(Me.Panel10)
        Me.pnlbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbawah.Location = New System.Drawing.Point(0, 460)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(1008, 88)
        Me.pnlbawah.TabIndex = 3
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Black
        Me.Panel11.Controls.Add(Me.Panel9)
        Me.Panel11.Controls.Add(Me.Panel7)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(338, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(670, 88)
        Me.Panel11.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel15)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(453, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(217, 88)
        Me.Panel9.TabIndex = 5
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Black
        Me.Panel15.Controls.Add(Me.Panel23)
        Me.Panel15.Controls.Add(Me.Panel22)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(217, 44)
        Me.Panel15.TabIndex = 4
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.txtBiaya2)
        Me.Panel23.Controls.Add(Me.txtBiaya)
        Me.Panel23.Controls.Add(Me.lblTotal)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel23.Location = New System.Drawing.Point(62, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(155, 44)
        Me.Panel23.TabIndex = 6
        '
        'txtBiaya2
        '
        Me.txtBiaya2.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtBiaya2.EditValue = ""
        Me.txtBiaya2.Location = New System.Drawing.Point(0, 0)
        Me.txtBiaya2.Name = "txtBiaya2"
        Me.txtBiaya2.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.txtBiaya2.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.txtBiaya2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiaya2.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtBiaya2.Properties.Appearance.Options.UseBackColor = True
        Me.txtBiaya2.Properties.Appearance.Options.UseBorderColor = True
        Me.txtBiaya2.Properties.Appearance.Options.UseFont = True
        Me.txtBiaya2.Properties.Appearance.Options.UseForeColor = True
        Me.txtBiaya2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBiaya2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBiaya2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtBiaya2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtBiaya2.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtBiaya2.Properties.CloseOnLostFocus = False
        Me.txtBiaya2.Properties.CloseOnOuterMouseClick = False
        Me.txtBiaya2.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBiaya2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBiaya2.Properties.PopupControl = Me.popBiaya
        Me.txtBiaya2.Properties.PopupSizeable = False
        Me.txtBiaya2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtBiaya2.Size = New System.Drawing.Size(26, 22)
        Me.txtBiaya2.TabIndex = 5
        '
        'txtBiaya
        '
        Me.txtBiaya.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtBiaya.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBiaya.Location = New System.Drawing.Point(0, 0)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.txtBiaya.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.txtBiaya.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiaya.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtBiaya.Properties.Appearance.Options.UseBackColor = True
        Me.txtBiaya.Properties.Appearance.Options.UseBorderColor = True
        Me.txtBiaya.Properties.Appearance.Options.UseFont = True
        Me.txtBiaya.Properties.Appearance.Options.UseForeColor = True
        Me.txtBiaya.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBiaya.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBiaya.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtBiaya.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBiaya.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBiaya.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtBiaya.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtBiaya.Properties.ReadOnly = True
        Me.txtBiaya.Size = New System.Drawing.Size(155, 22)
        Me.txtBiaya.TabIndex = 8
        '
        'lblTotal
        '
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.lblTotal.Location = New System.Drawing.Point(0, 22)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.lblTotal.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.lblTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Properties.Appearance.Options.UseBackColor = True
        Me.lblTotal.Properties.Appearance.Options.UseBorderColor = True
        Me.lblTotal.Properties.Appearance.Options.UseFont = True
        Me.lblTotal.Properties.Appearance.Options.UseForeColor = True
        Me.lblTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.lblTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lblTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.lblTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblTotal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.lblTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.lblTotal.Properties.ReadOnly = True
        Me.lblTotal.Size = New System.Drawing.Size(155, 22)
        Me.lblTotal.TabIndex = 4
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.LabelControl6)
        Me.Panel22.Controls.Add(Me.LabelControl5)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(62, 44)
        Me.Panel22.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl6.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelControl6.Appearance.Options.UseBackColor = True
        Me.LabelControl6.Appearance.Options.UseBorderColor = True
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelControl6.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(62, 22)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Biaya :  "
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl5.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelControl5.Appearance.Options.UseBackColor = True
        Me.LabelControl5.Appearance.Options.UseBorderColor = True
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelControl5.Location = New System.Drawing.Point(0, 22)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 22)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Total :  "
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtKeterangan)
        Me.Panel7.Controls.Add(Me.LabelControl4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(263, 88)
        Me.Panel7.TabIndex = 3
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 21)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtKeterangan.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtKeterangan.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtKeterangan.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtKeterangan.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtKeterangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtKeterangan.Size = New System.Drawing.Size(263, 67)
        Me.txtKeterangan.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseBackColor = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl4.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(263, 21)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = " Keterangan"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.txtNamaPnrm)
        Me.Panel10.Controls.Add(Me.txtAlamatKirim)
        Me.Panel10.Controls.Add(Me.tglKirim)
        Me.Panel10.Controls.Add(Me.Panel8)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(338, 88)
        Me.Panel10.TabIndex = 1
        '
        'txtNamaPnrm
        '
        Me.txtNamaPnrm.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNamaPnrm.Location = New System.Drawing.Point(110, 66)
        Me.txtNamaPnrm.Name = "txtNamaPnrm"
        Me.txtNamaPnrm.Size = New System.Drawing.Size(228, 21)
        Me.txtNamaPnrm.TabIndex = 4
        '
        'txtAlamatKirim
        '
        Me.txtAlamatKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtAlamatKirim.Location = New System.Drawing.Point(110, 20)
        Me.txtAlamatKirim.Name = "txtAlamatKirim"
        Me.txtAlamatKirim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtAlamatKirim.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatKirim.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtAlamatKirim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAlamatKirim.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtAlamatKirim.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtAlamatKirim.Size = New System.Drawing.Size(228, 46)
        Me.txtAlamatKirim.TabIndex = 3
        '
        'tglKirim
        '
        Me.tglKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglKirim.EditValue = Nothing
        Me.tglKirim.Location = New System.Drawing.Point(110, 0)
        Me.tglKirim.Name = "tglKirim"
        Me.tglKirim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.tglKirim.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglKirim.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.tglKirim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tglKirim.Properties.AppearanceFocused.Options.UseFont = True
        Me.tglKirim.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tglKirim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglKirim.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglKirim.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglKirim.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglKirim.Size = New System.Drawing.Size(228, 20)
        Me.tglKirim.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Maroon
        Me.Panel8.Controls.Add(Me.LabelControl3)
        Me.Panel8.Controls.Add(Me.LabelControl2)
        Me.Panel8.Controls.Add(Me.LabelControl1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(110, 88)
        Me.Panel8.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl3.Location = New System.Drawing.Point(0, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(110, 22)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Nama Pengadu : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(110, 44)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "* Alamat Kirim : "
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 21)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "* Tanggal Kirim : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBuku)
        Me.Panel1.Controls.Add(Me.lbljudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 37)
        Me.Panel1.TabIndex = 2
        '
        'btnBuku
        '
        Me.btnBuku.Appearance.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuku.Appearance.Options.UseFont = True
        Me.btnBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuku.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBuku.Image = CType(resources.GetObject("btnBuku.Image"), System.Drawing.Image)
        Me.btnBuku.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuku.Location = New System.Drawing.Point(968, 0)
        Me.btnBuku.Name = "btnBuku"
        Me.btnBuku.Size = New System.Drawing.Size(38, 35)
        Me.btnBuku.TabIndex = 10
        Me.btnBuku.Tag = "Buku Service"
        Me.btnBuku.ToolTip = "Klik untuk melihat buku order spring"
        Me.btnBuku.ToolTipTitle = "Buku Order"
        '
        'lbljudul
        '
        Me.lbljudul.BackColor = System.Drawing.Color.Transparent
        Me.lbljudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbljudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.ForeColor = System.Drawing.Color.Gold
        Me.lbljudul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbljudul.Location = New System.Drawing.Point(38, 0)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(287, 35)
        Me.lbljudul.TabIndex = 9
        Me.lbljudul.Text = "FORM PERMINTAAN SERVICE"
        Me.lbljudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'DXEP
        '
        Me.DXEP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.DXEP.ContainerControl = Me
        '
        'frmService
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 548)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmService"
        Me.Text = "frmSO"
        CType(Me.gvd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repGaransi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repkain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKdKain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBarang2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repJNSSRVSH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.pnlTengahBawah.ResumeLayout(False)
        CType(Me.popBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popBiaya.ResumeLayout(False)
        CType(Me.GC_Biaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Biaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.tglSO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.cmbJenisSP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtKodeCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.pnlbawah.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        CType(Me.txtBiaya2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBiaya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel22.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.txtAlamatKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahBawah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtKodeCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tglKirim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAlamatKirim As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtNamaPnrm As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents repbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jns_service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvd As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KD_STOK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KD_SERVICE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KELUHAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repJNSSRVSH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lbljudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuku As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DXEP As System.Windows.Forms.ErrorProvider
    Friend WithEvents seq_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Garansi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repGaransi As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents Kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repkain As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbJenisSP As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents kd_kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents thnbuat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repKdKain As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents popBiaya As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GC_Biaya As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Biaya As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents txtBiaya2 As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Bom_Service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBom As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents no_seq_service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents tglSO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gvm As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_SEQ_SP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_SP_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KD_BARANG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QTY2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HARGA2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TOTAL2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBarang2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MARGIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HARGAMARGIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBiaya As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblTotal As DevExpress.XtraEditors.SpinEdit
End Class
