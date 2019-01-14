<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLunasHutangUsaha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLunasHutangUsaha))
        Me.cmdadd = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.DtTanggalgrid = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Pnl = New System.Windows.Forms.Panel
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prev_no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_piut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_ppn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pendp_lain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.biaya_lain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.Lookgiro = New DevExpress.XtraEditors.LookUpEdit
        Me.lookbayar = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PnlSpaceAtas = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtkurs = New DevExpress.XtraEditors.TextEdit
        Me.LEValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.lookcust = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNoRef = New DevExpress.XtraEditors.TextEdit
        Me.dtTanggal = New DevExpress.XtraEditors.DateEdit
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
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        CType(Me.Lookgiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookbayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.txtkurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookcust.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(67, 584)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 85
        Me.cmdadd.Text = "add"
        Me.cmdadd.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(241, 584)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 84
        Me.SimpleButton3.Text = "edit"
        Me.SimpleButton3.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(148, 584)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 83
        Me.SimpleButton2.Text = "save"
        Me.SimpleButton2.Visible = False
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.Appearance.Options.UseForeColor = True
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(253, 20)
        Me.txtNomor.TabIndex = 2
        '
        'txtSubTotal
        '
        Me.txtSubTotal.EditValue = 0
        Me.txtSubTotal.Location = New System.Drawing.Point(740, 427)
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
        Me.txtSubTotal.TabIndex = 82
        Me.txtSubTotal.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(594, 427)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 20)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Total :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Visible = False
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
        'DtTanggalgrid
        '
        Me.DtTanggalgrid.AutoHeight = False
        Me.DtTanggalgrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTanggalgrid.Name = "DtTanggalgrid"
        Me.DtTanggalgrid.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'Pnl
        '
        Me.Pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pnl.Controls.Add(Me.cmdadd)
        Me.Pnl.Controls.Add(Me.SimpleButton3)
        Me.Pnl.Controls.Add(Me.SimpleButton2)
        Me.Pnl.Controls.Add(Me.txtSubTotal)
        Me.Pnl.Controls.Add(Me.Label15)
        Me.Pnl.Controls.Add(Me.SimpleButton1)
        Me.Pnl.Controls.Add(Me.btSimpan)
        Me.Pnl.Controls.Add(Me.GC)
        Me.Pnl.Controls.Add(Me.pnlTengahAtas)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(0, 0)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(941, 457)
        Me.Pnl.TabIndex = 2
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(344, 584)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btSimpan.TabIndex = 79
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.Visible = False
        '
        'GC
        '
        Me.GC.Location = New System.Drawing.Point(0, 164)
        Me.GC.LookAndFeel.SkinName = "Blue"
        Me.GC.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpStatus, Me.DtTanggalgrid, Me.repBrg})
        Me.GC.Size = New System.Drawing.Size(941, 257)
        Me.GC.TabIndex = 11
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.prev_no_inv, Me.jml_piut, Me.jml_ppn, Me.pendp_lain, Me.biaya_lain, Me.jml_bayar, Me.Keterangan})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.GV.Name = "GV"
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.EnableMasterViewMode = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.PaintStyleName = "Office2003"
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
        Me.no_seq.Width = 36
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
        Me.prev_no_inv.ColumnEdit = Me.repBrg
        Me.prev_no_inv.FieldName = "prev_no_inv"
        Me.prev_no_inv.Name = "prev_no_inv"
        Me.prev_no_inv.Visible = True
        Me.prev_no_inv.VisibleIndex = 1
        Me.prev_no_inv.Width = 184
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
        'jml_piut
        '
        Me.jml_piut.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.jml_piut.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_piut.AppearanceCell.Options.UseBackColor = True
        Me.jml_piut.AppearanceCell.Options.UseFont = True
        Me.jml_piut.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.jml_piut.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.jml_piut.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_piut.AppearanceHeader.Options.UseBackColor = True
        Me.jml_piut.AppearanceHeader.Options.UseFont = True
        Me.jml_piut.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_piut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_piut.Caption = "Jml. Tagihan"
        Me.jml_piut.DisplayFormat.FormatString = "n2"
        Me.jml_piut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_piut.FieldName = "jml_piut"
        Me.jml_piut.Name = "jml_piut"
        Me.jml_piut.OptionsColumn.AllowEdit = False
        Me.jml_piut.OptionsColumn.AllowFocus = False
        Me.jml_piut.Visible = True
        Me.jml_piut.VisibleIndex = 2
        Me.jml_piut.Width = 115
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
        Me.pendp_lain.Caption = "Pendapatan Lainya"
        Me.pendp_lain.DisplayFormat.FormatString = "n2"
        Me.pendp_lain.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pendp_lain.FieldName = "pendp_lain"
        Me.pendp_lain.Name = "pendp_lain"
        Me.pendp_lain.Visible = True
        Me.pendp_lain.VisibleIndex = 4
        Me.pendp_lain.Width = 122
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
        Me.biaya_lain.VisibleIndex = 5
        Me.biaya_lain.Width = 86
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
        Me.jml_bayar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar.UnboundExpression = "[jml_piut] + [jml_ppn] + [pendp_lain] - [biaya_lain]"
        Me.jml_bayar.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.jml_bayar.Visible = True
        Me.jml_bayar.VisibleIndex = 6
        Me.jml_bayar.Width = 105
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
        Me.Keterangan.VisibleIndex = 7
        Me.Keterangan.Width = 171
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
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.txtKeterangan)
        Me.pnlTengahAtas.Controls.Add(Me.Lookgiro)
        Me.pnlTengahAtas.Controls.Add(Me.lookbayar)
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.PnlSpaceAtas)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Controls.Add(Me.Panel4)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 34)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(941, 130)
        Me.pnlTengahAtas.TabIndex = 10
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKeterangan.Location = New System.Drawing.Point(587, 40)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(354, 60)
        Me.txtKeterangan.TabIndex = 13
        '
        'Lookgiro
        '
        Me.Lookgiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lookgiro.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lookgiro.Location = New System.Drawing.Point(587, 20)
        Me.Lookgiro.Name = "Lookgiro"
        Me.Lookgiro.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lookgiro.Properties.Appearance.Options.UseBackColor = True
        Me.Lookgiro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookgiro.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nomor", "No. Dokumen"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("keterangan", "keterangan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_trans", "Jumlah", 20, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.Lookgiro.Properties.DisplayMember = "nomor"
        Me.Lookgiro.Properties.NullText = "[Pilih No. Dokumen]"
        Me.Lookgiro.Properties.ValueMember = "nomor"
        Me.Lookgiro.Size = New System.Drawing.Size(354, 20)
        Me.Lookgiro.TabIndex = 14
        '
        'lookbayar
        '
        Me.lookbayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lookbayar.Dock = System.Windows.Forms.DockStyle.Top
        Me.lookbayar.Location = New System.Drawing.Point(587, 0)
        Me.lookbayar.Name = "lookbayar"
        Me.lookbayar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lookbayar.Properties.Appearance.Options.UseBackColor = True
        Me.lookbayar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)})
        Me.lookbayar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Kode")})
        Me.lookbayar.Properties.DisplayMember = "Desc_Data"
        Me.lookbayar.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.lookbayar.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.lookbayar.Properties.NullText = "[Pilih Pembayaran]"
        Me.lookbayar.Properties.ValueMember = "Id_Data"
        Me.lookbayar.Size = New System.Drawing.Size(354, 20)
        Me.lookbayar.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(458, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 130)
        Me.Panel3.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 47)
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
        Me.Label18.Size = New System.Drawing.Size(129, 20)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "No. Giro/Cek :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Jenis Pembayaran :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlSpaceAtas
        '
        Me.PnlSpaceAtas.BackColor = System.Drawing.Color.Transparent
        Me.PnlSpaceAtas.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlSpaceAtas.Location = New System.Drawing.Point(436, 0)
        Me.PnlSpaceAtas.Name = "PnlSpaceAtas"
        Me.PnlSpaceAtas.Size = New System.Drawing.Size(22, 130)
        Me.PnlSpaceAtas.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtkurs)
        Me.Panel5.Controls.Add(Me.LEValuta)
        Me.Panel5.Controls.Add(Me.lookcust)
        Me.Panel5.Controls.Add(Me.txtNoRef)
        Me.Panel5.Controls.Add(Me.dtTanggal)
        Me.Panel5.Controls.Add(Me.txtNomor)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(183, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(253, 130)
        Me.Panel5.TabIndex = 3
        '
        'txtkurs
        '
        Me.txtkurs.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtkurs.Location = New System.Drawing.Point(0, 100)
        Me.txtkurs.Name = "txtkurs"
        Me.txtkurs.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtkurs.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtkurs.Properties.Appearance.Options.UseBackColor = True
        Me.txtkurs.Properties.Appearance.Options.UseForeColor = True
        Me.txtkurs.Size = New System.Drawing.Size(253, 20)
        Me.txtkurs.TabIndex = 12
        '
        'LEValuta
        '
        Me.LEValuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LEValuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.LEValuta.Location = New System.Drawing.Point(0, 80)
        Me.LEValuta.Name = "LEValuta"
        Me.LEValuta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LEValuta.Properties.Appearance.Options.UseBackColor = True
        Me.LEValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Valuta")})
        Me.LEValuta.Properties.DisplayMember = "Nama_Valuta"
        Me.LEValuta.Properties.NullText = "[Valuta]"
        Me.LEValuta.Properties.ValueMember = "Kode_Valuta"
        Me.LEValuta.Size = New System.Drawing.Size(253, 20)
        Me.LEValuta.TabIndex = 11
        '
        'lookcust
        '
        Me.lookcust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lookcust.Dock = System.Windows.Forms.DockStyle.Top
        Me.lookcust.Location = New System.Drawing.Point(0, 60)
        Me.lookcust.Name = "lookcust"
        Me.lookcust.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lookcust.Properties.Appearance.Options.UseBackColor = True
        Me.lookcust.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookcust.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama_Supplier", 102, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Alamat1", "Alamat1", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lookcust.Properties.DisplayMember = "Nama_Supplier"
        Me.lookcust.Properties.NullText = "[Pilih Supplier]"
        Me.lookcust.Properties.ValueMember = "Kode_Supplier"
        Me.lookcust.Size = New System.Drawing.Size(253, 20)
        Me.lookcust.TabIndex = 9
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
        Me.txtNoRef.Size = New System.Drawing.Size(253, 20)
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
        Me.dtTanggal.Size = New System.Drawing.Size(253, 20)
        Me.dtTanggal.TabIndex = 5
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
        Me.Panel4.Size = New System.Drawing.Size(183, 130)
        Me.Panel4.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 20)
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
        Me.Label10.Location = New System.Drawing.Point(0, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Valuta :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Supplier :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 20)
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
        Me.Label6.Size = New System.Drawing.Size(183, 20)
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PELUNASAN HUTANG USAHA"
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
        'frmLunasHutangUsaha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 470)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmLunasHutangUsaha"
        Me.Text = "Form Pelunasan Hutang Usaha"
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.pnlTengahAtas.PerformLayout()
        CType(Me.Lookgiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookbayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.txtkurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookcust.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DtTanggalgrid As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prev_no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jml_piut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_ppn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pendp_lain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents biaya_lain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Lookgiro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookbayar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PnlSpaceAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtkurs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LEValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookcust As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNoRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtTanggal As DevExpress.XtraEditors.DateEdit
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
End Class
