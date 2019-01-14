<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRealUmHut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRealUmHut))
        Me.Pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prev_no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLOVInvoice = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_piut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_pembulatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.DtTanggalgrid = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.repBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.LOVum = New DevExpress.XtraEditors.LookUpEdit
        Me.txtJumlahGiro = New DevExpress.XtraEditors.TextEdit
        Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit
        Me.LOVGiro = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PnlSpaceAtas = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtKurs = New DevExpress.XtraEditors.TextEdit
        Me.LOVValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.LOVSupp = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNoRef = New DevExpress.XtraEditors.TextEdit
        Me.Tanggal = New DevExpress.XtraEditors.DateEdit
        Me.txtNoTrans = New DevExpress.XtraEditors.TextEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLOVInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlTengahAtas.SuspendLayout()
        CType(Me.LOVum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJumlahGiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVGiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVSupp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl
        '
        Me.Pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pnl.Controls.Add(Me.GC)
        Me.Pnl.Controls.Add(Me.Panel2)
        Me.Pnl.Controls.Add(Me.SimpleButton1)
        Me.Pnl.Controls.Add(Me.pnlTengahAtas)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(25, 12)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(941, 457)
        Me.Pnl.TabIndex = 5
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 178)
        Me.GC.LookAndFeel.SkinName = "Blue"
        Me.GC.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpStatus, Me.DtTanggalgrid, Me.repBrg, Me.RepLOVInvoice})
        Me.GC.Size = New System.Drawing.Size(941, 249)
        Me.GC.TabIndex = 11
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.prev_no_inv, Me.jml_tagihan, Me.jml_piut, Me.jml_pembulatan, Me.jml_bayar, Me.Keterangan, Me.kd_buku_besar})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.GV.Name = "GV"
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.EnableMasterViewMode = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowViewCaption = True
        Me.GV.ViewCaption = "LUNAS HUTANG DENGAN UANG MUKA"
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
        Me.no_seq.Caption = "No"
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.AllowFocus = False
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 42
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
        Me.prev_no_inv.Caption = "No. Invoice"
        Me.prev_no_inv.ColumnEdit = Me.RepLOVInvoice
        Me.prev_no_inv.FieldName = "prev_no_inv"
        Me.prev_no_inv.Name = "prev_no_inv"
        Me.prev_no_inv.Visible = True
        Me.prev_no_inv.VisibleIndex = 1
        Me.prev_no_inv.Width = 215
        '
        'RepLOVInvoice
        '
        Me.RepLOVInvoice.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepLOVInvoice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLOVInvoice.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_inv", "No. Inv."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nm. Supplir"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_tagihan", "Jumlah Tagihan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_bayar", "Jumlah Bayar"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_akhir", "Jml. Akhir")})
        Me.RepLOVInvoice.Name = "RepLOVInvoice"
        '
        'jml_tagihan
        '
        Me.jml_tagihan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_tagihan.AppearanceCell.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.jml_tagihan.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.jml_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_tagihan.AppearanceHeader.Options.UseBackColor = True
        Me.jml_tagihan.AppearanceHeader.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_tagihan.Caption = "Jml. Tagihan"
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.OptionsColumn.AllowEdit = False
        Me.jml_tagihan.OptionsColumn.AllowFocus = False
        Me.jml_tagihan.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_tagihan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 2
        Me.jml_tagihan.Width = 137
        '
        'jml_piut
        '
        Me.jml_piut.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_piut.AppearanceCell.Options.UseFont = True
        Me.jml_piut.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.jml_piut.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.jml_piut.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_piut.AppearanceHeader.Options.UseBackColor = True
        Me.jml_piut.AppearanceHeader.Options.UseFont = True
        Me.jml_piut.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_piut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_piut.Caption = "Jml. Pembayaran"
        Me.jml_piut.DisplayFormat.FormatString = "n2"
        Me.jml_piut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_piut.FieldName = "jml_piut"
        Me.jml_piut.Name = "jml_piut"
        Me.jml_piut.Visible = True
        Me.jml_piut.VisibleIndex = 3
        Me.jml_piut.Width = 106
        '
        'jml_pembulatan
        '
        Me.jml_pembulatan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_pembulatan.AppearanceHeader.Options.UseFont = True
        Me.jml_pembulatan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_pembulatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_pembulatan.Caption = "Jml. Pembulatan"
        Me.jml_pembulatan.DisplayFormat.FormatString = "n2"
        Me.jml_pembulatan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_pembulatan.FieldName = "jml_pembulatan"
        Me.jml_pembulatan.Name = "jml_pembulatan"
        Me.jml_pembulatan.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.jml_pembulatan.Visible = True
        Me.jml_pembulatan.VisibleIndex = 4
        Me.jml_pembulatan.Width = 125
        '
        'jml_bayar
        '
        Me.jml_bayar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_bayar.AppearanceHeader.Options.UseFont = True
        Me.jml_bayar.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_bayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_bayar.Caption = "Sub Total"
        Me.jml_bayar.DisplayFormat.FormatString = "n2"
        Me.jml_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar.FieldName = "jml_bayar"
        Me.jml_bayar.Name = "jml_bayar"
        Me.jml_bayar.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_bayar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar.UnboundExpression = "[jml_piut] + [jml_pembulatan]"
        Me.jml_bayar.Visible = True
        Me.jml_bayar.VisibleIndex = 5
        Me.jml_bayar.Width = 89
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
        Me.Keterangan.VisibleIndex = 6
        Me.Keterangan.Width = 210
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.Caption = "Kode"
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
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
        Me.DtTanggalgrid.Name = "DtTanggalgrid"
        Me.DtTanggalgrid.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'repBrg
        '
        Me.repBrg.Appearance.BackColor2 = System.Drawing.Color.Silver
        Me.repBrg.Appearance.Options.UseBackColor = True
        Me.repBrg.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.repBrg.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.repBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBrg.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.repBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_inv", 30, "No. Invoice"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tgl_inv", "Tgl. Invoice"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_tagihan", "Jumlah Tagihan", 25, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tgl_jth_tempo", 25, "Tgl. Jth Tempo")})
        Me.repBrg.DisplayMember = "no_inv"
        Me.repBrg.HideSelection = False
        Me.repBrg.Name = "repBrg"
        Me.repBrg.NullText = "[Pilih Nomor Invoice]"
        Me.repBrg.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repBrg.ValueMember = "no_inv"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.lblError)
        Me.Panel2.Controls.Add(Me.cmdDelete)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Controls.Add(Me.cmdEdit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 427)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(941, 30)
        Me.Panel2.TabIndex = 90
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(3, 6)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 16)
        Me.lblError.TabIndex = 90
        Me.lblError.Text = "..."
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(366, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 89
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(285, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 87
        Me.cmdSave.Text = "Save"
        Me.cmdSave.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(447, 4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 88
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.Visible = False
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
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.LOVum)
        Me.pnlTengahAtas.Controls.Add(Me.txtJumlahGiro)
        Me.pnlTengahAtas.Controls.Add(Me.txtKeterangan)
        Me.pnlTengahAtas.Controls.Add(Me.LOVGiro)
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.PnlSpaceAtas)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Controls.Add(Me.Panel4)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 34)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(941, 144)
        Me.pnlTengahAtas.TabIndex = 10
        '
        'LOVum
        '
        Me.LOVum.Cursor = System.Windows.Forms.Cursors.Default
        Me.LOVum.Location = New System.Drawing.Point(587, 0)
        Me.LOVum.Name = "LOVum"
        Me.LOVum.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVum.Properties.Appearance.Options.UseBackColor = True
        Me.LOVum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVum.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nomor", "No"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tanggal", "Tanggal"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_akhir", "Jml. Akhir")})
        Me.LOVum.Properties.NullText = ""
        Me.LOVum.Size = New System.Drawing.Size(329, 20)
        Me.LOVum.TabIndex = 7
        '
        'txtJumlahGiro
        '
        Me.txtJumlahGiro.EditValue = "0"
        Me.txtJumlahGiro.Enabled = False
        Me.txtJumlahGiro.Location = New System.Drawing.Point(587, 112)
        Me.txtJumlahGiro.Name = "txtJumlahGiro"
        Me.txtJumlahGiro.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtJumlahGiro.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJumlahGiro.Properties.Appearance.Options.UseBackColor = True
        Me.txtJumlahGiro.Properties.Appearance.Options.UseForeColor = True
        Me.txtJumlahGiro.Properties.DisplayFormat.FormatString = "n2"
        Me.txtJumlahGiro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJumlahGiro.Properties.EditFormat.FormatString = "n2"
        Me.txtJumlahGiro.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJumlahGiro.Properties.Mask.BeepOnError = True
        Me.txtJumlahGiro.Properties.Mask.EditMask = "n2"
        Me.txtJumlahGiro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtJumlahGiro.Properties.ReadOnly = True
        Me.txtJumlahGiro.Size = New System.Drawing.Size(329, 20)
        Me.txtJumlahGiro.TabIndex = 3
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(587, 42)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.AutoHeight = False
        Me.txtKeterangan.Size = New System.Drawing.Size(329, 69)
        Me.txtKeterangan.TabIndex = 2
        '
        'LOVGiro
        '
        Me.LOVGiro.Cursor = System.Windows.Forms.Cursors.Default
        Me.LOVGiro.Location = New System.Drawing.Point(587, 21)
        Me.LOVGiro.Name = "LOVGiro"
        Me.LOVGiro.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVGiro.Properties.Appearance.Options.UseBackColor = True
        Me.LOVGiro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVGiro.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nomor", "No. Dokumen"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("keterangan", "keterangan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_trans", "Jumlah", 20, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.LOVGiro.Properties.NullText = ""
        Me.LOVGiro.Size = New System.Drawing.Size(329, 20)
        Me.LOVGiro.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(474, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(107, 144)
        Me.Panel3.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Jumlah Giro : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 70)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Keterangan :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(0, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 21)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "No. Giro :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "No. UM :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlSpaceAtas
        '
        Me.PnlSpaceAtas.BackColor = System.Drawing.Color.Transparent
        Me.PnlSpaceAtas.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlSpaceAtas.Location = New System.Drawing.Point(436, 0)
        Me.PnlSpaceAtas.Name = "PnlSpaceAtas"
        Me.PnlSpaceAtas.Size = New System.Drawing.Size(38, 144)
        Me.PnlSpaceAtas.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtKurs)
        Me.Panel5.Controls.Add(Me.LOVValuta)
        Me.Panel5.Controls.Add(Me.LOVSupp)
        Me.Panel5.Controls.Add(Me.txtNoRef)
        Me.Panel5.Controls.Add(Me.Tanggal)
        Me.Panel5.Controls.Add(Me.txtNoTrans)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(183, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(253, 144)
        Me.Panel5.TabIndex = 3
        '
        'txtKurs
        '
        Me.txtKurs.EditValue = "1"
        Me.txtKurs.Location = New System.Drawing.Point(0, 105)
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtKurs.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKurs.Properties.Appearance.Options.UseBackColor = True
        Me.txtKurs.Properties.Appearance.Options.UseForeColor = True
        Me.txtKurs.Properties.Mask.BeepOnError = True
        Me.txtKurs.Properties.Mask.EditMask = "n"
        Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtKurs.Size = New System.Drawing.Size(231, 20)
        Me.txtKurs.TabIndex = 3
        '
        'LOVValuta
        '
        Me.LOVValuta.Cursor = System.Windows.Forms.Cursors.Default
        Me.LOVValuta.Location = New System.Drawing.Point(0, 84)
        Me.LOVValuta.Name = "LOVValuta"
        Me.LOVValuta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVValuta.Properties.Appearance.Options.UseBackColor = True
        Me.LOVValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_valuta", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode_valuta", "kode")})
        Me.LOVValuta.Properties.NullText = ""
        Me.LOVValuta.Size = New System.Drawing.Size(231, 20)
        Me.LOVValuta.TabIndex = 2
        '
        'LOVSupp
        '
        Me.LOVSupp.Cursor = System.Windows.Forms.Cursors.Default
        Me.LOVSupp.Location = New System.Drawing.Point(0, 63)
        Me.LOVSupp.Name = "LOVSupp"
        Me.LOVSupp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVSupp.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Supplier", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama")})
        Me.LOVSupp.Properties.NullText = ""
        Me.LOVSupp.Size = New System.Drawing.Size(231, 20)
        Me.LOVSupp.TabIndex = 1
        '
        'txtNoRef
        '
        Me.txtNoRef.Location = New System.Drawing.Point(0, 42)
        Me.txtNoRef.Name = "txtNoRef"
        Me.txtNoRef.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNoRef.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoRef.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoRef.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoRef.Size = New System.Drawing.Size(231, 20)
        Me.txtNoRef.TabIndex = 0
        '
        'Tanggal
        '
        Me.Tanggal.EditValue = New Date(2011, 12, 22, 16, 22, 52, 220)
        Me.Tanggal.Location = New System.Drawing.Point(0, 21)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Tanggal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Tanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Tanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.Tanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Tanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Tanggal.Size = New System.Drawing.Size(231, 20)
        Me.Tanggal.TabIndex = 5
        '
        'txtNoTrans
        '
        Me.txtNoTrans.Location = New System.Drawing.Point(0, 0)
        Me.txtNoTrans.Name = "txtNoTrans"
        Me.txtNoTrans.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNoTrans.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoTrans.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoTrans.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoTrans.Properties.ReadOnly = True
        Me.txtNoTrans.Size = New System.Drawing.Size(231, 20)
        Me.txtNoTrans.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 144)
        Me.Panel4.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kurs :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 21)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Valuta :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Supplier :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 21)
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
        Me.Label6.Size = New System.Drawing.Size(183, 21)
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
        Me.Label5.Size = New System.Drawing.Size(183, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "No Transaksi :"
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
        Me.Panel1.Size = New System.Drawing.Size(941, 34)
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
        Me.Label1.Size = New System.Drawing.Size(399, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PELUNASAN HUTANG DENGAN UANG MUKA"
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmRealUmHut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 501)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmRealUmHut"
        Me.Text = "frmRealUmHut"
        Me.Pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLOVInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlTengahAtas.ResumeLayout(False)
        CType(Me.LOVum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJumlahGiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVGiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVSupp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prev_no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepLOVInvoice As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_piut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_pembulatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DtTanggalgrid As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents txtJumlahGiro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LOVGiro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PnlSpaceAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LOVValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LOVSupp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNoRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNoTrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LOVum As DevExpress.XtraEditors.LookUpEdit
End Class
