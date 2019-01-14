<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPLNSKasBon
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
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPLNSKasBon))
        Me.Pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rekening = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVRekBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pusat_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVPusBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.rpStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.DtTanggalgrid = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.repBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepLOVInvoice = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.chkHutang = New DevExpress.XtraEditors.CheckEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSelisih = New DevExpress.XtraEditors.TextEdit
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.txtRPtrans = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.LOVnomorKB = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.txtJmlAkhir = New DevExpress.XtraEditors.TextEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LOV_Unit = New DevExpress.XtraEditors.LookUpEdit
        Me.LOVKartu = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LOVNoKasBon = New DevExpress.XtraEditors.LookUpEdit
        Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit
        Me.Tanggal = New DevExpress.XtraEditors.DateEdit
        Me.txtNoTrans = New DevExpress.XtraEditors.TextEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
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
        CType(Me.LOVRekBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVPusBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLOVInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.chkHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSelisih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRPtrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVnomorKB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.LOV_Unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVKartu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVNoKasBon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Pnl.Location = New System.Drawing.Point(49, 16)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(953, 457)
        Me.Pnl.TabIndex = 5
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 191)
        Me.GC.LookAndFeel.SkinName = "Blue"
        Me.GC.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpStatus, Me.DtTanggalgrid, Me.repBrg, Me.RepLOVInvoice, Me.LOVRekBiaya, Me.LOVPusBiaya, Me.RepositoryItemSpinEdit1})
        Me.GC.Size = New System.Drawing.Size(953, 236)
        Me.GC.TabIndex = 11
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GV.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GV.Appearance.Row.Options.UseFont = True
        Me.GV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.rekening, Me.pusat_biaya, Me.Keterangan, Me.jml_trans})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Tambahkan data baru disini"
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.EnableMasterViewMode = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.rekening, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.GV.ViewCaption = "BELI LUNAS DETAIL"
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
        Me.no_seq.Width = 41
        '
        'rekening
        '
        Me.rekening.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rekening.AppearanceHeader.Options.UseFont = True
        Me.rekening.Caption = "*Nama. Rek"
        Me.rekening.ColumnEdit = Me.LOVRekBiaya
        Me.rekening.FieldName = "rekening"
        Me.rekening.Name = "rekening"
        Me.rekening.Visible = True
        Me.rekening.VisibleIndex = 1
        Me.rekening.Width = 82
        '
        'LOVRekBiaya
        '
        Me.LOVRekBiaya.AutoHeight = False
        Me.LOVRekBiaya.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVRekBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVRekBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.LOVRekBiaya.Name = "LOVRekBiaya"
        Me.LOVRekBiaya.NullText = "[Pilih rekening]"
        '
        'pusat_biaya
        '
        Me.pusat_biaya.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pusat_biaya.AppearanceHeader.Options.UseFont = True
        Me.pusat_biaya.Caption = "*Nama. Pusat Biaya"
        Me.pusat_biaya.ColumnEdit = Me.LOVPusBiaya
        Me.pusat_biaya.FieldName = "pusat_biaya"
        Me.pusat_biaya.Name = "pusat_biaya"
        Me.pusat_biaya.Width = 135
        '
        'LOVPusBiaya
        '
        Me.LOVPusBiaya.AutoHeight = False
        Me.LOVPusBiaya.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVPusBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVPusBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.LOVPusBiaya.Name = "LOVPusBiaya"
        Me.LOVPusBiaya.NullText = "[Pilih Pusat Biaya]"
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
        Me.Keterangan.VisibleIndex = 3
        Me.Keterangan.Width = 161
        '
        'jml_trans
        '
        Me.jml_trans.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_trans.AppearanceCell.Options.UseFont = True
        Me.jml_trans.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.jml_trans.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.jml_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_trans.AppearanceHeader.Options.UseBackColor = True
        Me.jml_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_trans.Caption = "*Jml. Transaksi"
        Me.jml_trans.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_trans.Visible = True
        Me.jml_trans.VisibleIndex = 3
        Me.jml_trans.Width = 108
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
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
        'RepLOVInvoice
        '
        Me.RepLOVInvoice.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepLOVInvoice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLOVInvoice.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_inv", "No. Inv."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nm. Supplir"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_tagihan", "Jumlah Tagihan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_bayar", "Jumlah Bayar"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_akhir", "Jml. Akhir")})
        Me.RepLOVInvoice.Name = "RepLOVInvoice"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.chkHutang)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtSelisih)
        Me.Panel2.Controls.Add(Me.lblError)
        Me.Panel2.Controls.Add(Me.txtRPtrans)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 427)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(953, 30)
        Me.Panel2.TabIndex = 90
        '
        'chkHutang
        '
        Me.chkHutang.Location = New System.Drawing.Point(539, 6)
        Me.chkHutang.Name = "chkHutang"
        Me.chkHutang.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chkHutang.Properties.Appearance.Options.UseForeColor = True
        Me.chkHutang.Properties.Caption = "Hutang?"
        Me.chkHutang.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkHutang.Properties.ValueChecked = "Y"
        Me.chkHutang.Properties.ValueUnchecked = "T"
        Me.chkHutang.Size = New System.Drawing.Size(75, 19)
        Me.chkHutang.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(586, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Selisih :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSelisih
        '
        Me.txtSelisih.Location = New System.Drawing.Point(703, 5)
        Me.txtSelisih.Name = "txtSelisih"
        Me.txtSelisih.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSelisih.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtSelisih.Properties.Appearance.Options.UseBackColor = True
        Me.txtSelisih.Properties.Appearance.Options.UseForeColor = True
        Me.txtSelisih.Properties.DisplayFormat.FormatString = "n2"
        Me.txtSelisih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSelisih.Properties.EditFormat.FormatString = "n2"
        Me.txtSelisih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSelisih.Properties.Mask.BeepOnError = True
        Me.txtSelisih.Properties.Mask.EditMask = "n2"
        Me.txtSelisih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSelisih.Properties.ReadOnly = True
        Me.txtSelisih.Size = New System.Drawing.Size(235, 20)
        Me.txtSelisih.TabIndex = 4
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
        'txtRPtrans
        '
        Me.txtRPtrans.EditValue = "0"
        Me.txtRPtrans.Location = New System.Drawing.Point(96, 5)
        Me.txtRPtrans.Name = "txtRPtrans"
        Me.txtRPtrans.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRPtrans.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtRPtrans.Properties.Appearance.Options.UseBackColor = True
        Me.txtRPtrans.Properties.Appearance.Options.UseForeColor = True
        Me.txtRPtrans.Properties.Mask.BeepOnError = True
        Me.txtRPtrans.Properties.Mask.EditMask = "n2"
        Me.txtRPtrans.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRPtrans.Properties.ReadOnly = True
        Me.txtRPtrans.Size = New System.Drawing.Size(139, 20)
        Me.txtRPtrans.TabIndex = 13
        Me.txtRPtrans.Visible = False
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
        Me.pnlTengahAtas.Controls.Add(Me.CheckEdit1)
        Me.pnlTengahAtas.Controls.Add(Me.LOVnomorKB)
        Me.pnlTengahAtas.Controls.Add(Me.cmdRefresh)
        Me.pnlTengahAtas.Controls.Add(Me.txtJmlAkhir)
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Controls.Add(Me.Panel4)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 34)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(953, 157)
        Me.pnlTengahAtas.TabIndex = 10
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(563, 3)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Print Ulang"
        Me.CheckEdit1.Size = New System.Drawing.Size(186, 19)
        Me.CheckEdit1.TabIndex = 5
        '
        'LOVnomorKB
        '
        Me.LOVnomorKB.Cursor = System.Windows.Forms.Cursors.Default
        Me.LOVnomorKB.Location = New System.Drawing.Point(564, 23)
        Me.LOVnomorKB.Name = "LOVnomorKB"
        Me.LOVnomorKB.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVnomorKB.Properties.Appearance.Options.UseBackColor = True
        Me.LOVnomorKB.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVnomorKB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVnomorKB.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nomor", "No."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("prev_nomor", "Prev. No."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_trans", "Jml. Transaksi"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tgl_trans", "Tanggal")})
        Me.LOVnomorKB.Properties.NullText = ""
        Me.LOVnomorKB.Size = New System.Drawing.Size(219, 20)
        Me.LOVnomorKB.TabIndex = 47
        Me.LOVnomorKB.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(618, 104)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(107, 34)
        Me.cmdRefresh.TabIndex = 7
        Me.cmdRefresh.Text = "ReCalculate"
        Me.cmdRefresh.Visible = False
        '
        'txtJmlAkhir
        '
        Me.txtJmlAkhir.Location = New System.Drawing.Point(474, 80)
        Me.txtJmlAkhir.Name = "txtJmlAkhir"
        Me.txtJmlAkhir.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtJmlAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlAkhir.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlAkhir.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlAkhir.Properties.DisplayFormat.FormatString = "n2"
        Me.txtJmlAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlAkhir.Properties.EditFormat.FormatString = "n2"
        Me.txtJmlAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlAkhir.Properties.Mask.BeepOnError = True
        Me.txtJmlAkhir.Properties.Mask.EditMask = "n2"
        Me.txtJmlAkhir.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtJmlAkhir.Properties.ReadOnly = True
        Me.txtJmlAkhir.Size = New System.Drawing.Size(218, 20)
        Me.txtJmlAkhir.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.LabelControl3)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(377, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(92, 157)
        Me.Panel3.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(6, 122)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl3.TabIndex = 46
        Me.LabelControl3.Text = "*wajib diisi"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jml Akhir :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LOV_Unit)
        Me.Panel5.Controls.Add(Me.LOVKartu)
        Me.Panel5.Controls.Add(Me.LabelControl2)
        Me.Panel5.Controls.Add(Me.LabelControl1)
        Me.Panel5.Controls.Add(Me.LabelControl9)
        Me.Panel5.Controls.Add(Me.LOVNoKasBon)
        Me.Panel5.Controls.Add(Me.txtKeterangan)
        Me.Panel5.Controls.Add(Me.Tanggal)
        Me.Panel5.Controls.Add(Me.txtNoTrans)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(119, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(258, 157)
        Me.Panel5.TabIndex = 3
        '
        'LOV_Unit
        '
        Me.LOV_Unit.Cursor = System.Windows.Forms.Cursors.Default
        Me.LOV_Unit.Location = New System.Drawing.Point(0, 131)
        Me.LOV_Unit.Name = "LOV_Unit"
        Me.LOV_Unit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOV_Unit.Properties.Appearance.Options.UseBackColor = True
        Me.LOV_Unit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOV_Unit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kd Unit"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama Unit")})
        Me.LOV_Unit.Properties.NullText = ""
        Me.LOV_Unit.Size = New System.Drawing.Size(231, 20)
        Me.LOV_Unit.TabIndex = 48
        '
        'LOVKartu
        '
        Me.LOVKartu.Cursor = System.Windows.Forms.Cursors.Default
        Me.LOVKartu.Location = New System.Drawing.Point(0, 41)
        Me.LOVKartu.Name = "LOVKartu"
        Me.LOVKartu.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVKartu.Properties.Appearance.Options.UseBackColor = True
        Me.LOVKartu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVKartu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("status", "Status"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Name24", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.LOVKartu.Properties.NullText = ""
        Me.LOVKartu.Size = New System.Drawing.Size(231, 20)
        Me.LOVKartu.TabIndex = 47
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(233, 19)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "*"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(234, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl1.TabIndex = 46
        Me.LabelControl1.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(234, 62)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl9.TabIndex = 45
        Me.LabelControl9.Text = "*"
        '
        'LOVNoKasBon
        '
        Me.LOVNoKasBon.Cursor = System.Windows.Forms.Cursors.Default
        Me.LOVNoKasBon.Location = New System.Drawing.Point(0, 62)
        Me.LOVNoKasBon.Name = "LOVNoKasBon"
        Me.LOVNoKasBon.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVNoKasBon.Properties.Appearance.Options.UseBackColor = True
        Me.LOVNoKasBon.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVNoKasBon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVNoKasBon.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_kartu", "kartu", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nomor", "Nomor"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_trans", "Jml. Trans", 20, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_akhir", "Jml. Akhir", 20, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.LOVNoKasBon.Properties.NullText = ""
        Me.LOVNoKasBon.Size = New System.Drawing.Size(231, 20)
        Me.LOVNoKasBon.TabIndex = 17
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 84)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.AutoHeight = False
        Me.txtKeterangan.Size = New System.Drawing.Size(231, 45)
        Me.txtKeterangan.TabIndex = 16
        '
        'Tanggal
        '
        Me.Tanggal.EditValue = Nothing
        Me.Tanggal.Location = New System.Drawing.Point(0, 21)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Tanggal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Tanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Tanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.Tanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Tanggal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.Tanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Tanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Tanggal.Size = New System.Drawing.Size(231, 20)
        Me.Tanggal.TabIndex = 5
        '
        'txtNoTrans
        '
        Me.txtNoTrans.Location = New System.Drawing.Point(0, 0)
        Me.txtNoTrans.Name = "txtNoTrans"
        Me.txtNoTrans.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNoTrans.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoTrans.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoTrans.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoTrans.Properties.ReadOnly = True
        Me.txtNoTrans.Size = New System.Drawing.Size(201, 20)
        Me.txtNoTrans.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(119, 157)
        Me.Panel4.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Unit :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 46)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Keterangan :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "No. Kas Bon :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama Kartu :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 21)
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
        Me.Label5.Size = New System.Drawing.Size(119, 20)
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
        Me.Panel1.Size = New System.Drawing.Size(953, 34)
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
        Me.Label1.Size = New System.Drawing.Size(391, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PELUNASAN KAS BON"
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
        'frmPLNSKasBon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 489)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmPLNSKasBon"
        Me.Text = "frmPLNSKasBon"
        Me.Pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVRekBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVPusBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLOVInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.chkHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSelisih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRPtrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVnomorKB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.LOV_Unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVKartu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVNoKasBon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RepLOVInvoice As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DtTanggalgrid As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRPtrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Tanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNoTrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LOVNoKasBon As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rekening As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pusat_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVRekBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LOVPusBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtJmlAkhir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSelisih As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LOVnomorKB As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkHutang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents LOVKartu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LOV_Unit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
