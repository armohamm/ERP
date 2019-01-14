<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitorBiaya1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitorBiaya1))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.GVMonDet = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kdBKpusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nmKDpusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCMonBiaya = New DevExpress.XtraGrid.GridControl
        Me.GVMonBiaya = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_jurnal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_post = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_reff1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_reff3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kepada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_buku_pusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bulan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.total_rp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.PusBiaya = New DevExpress.XtraEditors.LookUpEdit
        Me.RekBiaya = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.TxtDebetKredit = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAct = New DevExpress.XtraEditors.SimpleButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.GVMonDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCMonBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMonBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PusBiaya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RekBiaya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.TxtDebetKredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVMonDet
        '
        Me.GVMonDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kdBKpusat, Me.nmKDpusat, Me.Debet, Me.Kredit})
        Me.GVMonDet.GridControl = Me.GCMonBiaya
        Me.GVMonDet.Name = "GVMonDet"
        '
        'kdBKpusat
        '
        Me.kdBKpusat.Caption = "Kode Buku Besar"
        Me.kdBKpusat.Name = "kdBKpusat"
        Me.kdBKpusat.Visible = True
        Me.kdBKpusat.VisibleIndex = 0
        '
        'nmKDpusat
        '
        Me.nmKDpusat.Caption = "Nama Buku Pusat"
        Me.nmKDpusat.Name = "nmKDpusat"
        Me.nmKDpusat.Visible = True
        Me.nmKDpusat.VisibleIndex = 1
        '
        'Debet
        '
        Me.Debet.Caption = "Debet"
        Me.Debet.Name = "Debet"
        Me.Debet.Visible = True
        Me.Debet.VisibleIndex = 2
        '
        'Kredit
        '
        Me.Kredit.Caption = "Kredit"
        Me.Kredit.Name = "Kredit"
        Me.Kredit.Visible = True
        Me.Kredit.VisibleIndex = 3
        '
        'GCMonBiaya
        '
        Me.GCMonBiaya.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCMonBiaya.Location = New System.Drawing.Point(0, 80)
        Me.GCMonBiaya.LookAndFeel.SkinName = "The Asphalt World"
        Me.GCMonBiaya.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCMonBiaya.MainView = Me.GVMonBiaya
        Me.GCMonBiaya.Name = "GCMonBiaya"
        Me.GCMonBiaya.Size = New System.Drawing.Size(1075, 376)
        Me.GCMonBiaya.TabIndex = 8
        Me.GCMonBiaya.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVMonBiaya, Me.GVMonDet})
        '
        'GVMonBiaya
        '
        Me.GVMonBiaya.ActiveFilterEnabled = False
        Me.GVMonBiaya.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVMonBiaya.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVMonBiaya.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVMonBiaya.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVMonBiaya.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No, Me.No_jurnal, Me.tgl_trans, Me.tgl_post, Me.no_reff1, Me.no_reff3, Me.Kepada, Me.Keterangan, Me.nm_buku_besar, Me.nm_buku_pusat, Me.saldo_val_debet, Me.saldo_val_kredit, Me.bulan, Me.qty_total, Me.total_rp})
        Me.GVMonBiaya.GridControl = Me.GCMonBiaya
        Me.GVMonBiaya.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.GVMonBiaya.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo_val_debet", Me.saldo_val_debet, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo_val_kredit", Me.saldo_val_kredit, "")})
        Me.GVMonBiaya.Name = "GVMonBiaya"
        Me.GVMonBiaya.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GVMonBiaya.OptionsBehavior.Editable = False
        Me.GVMonBiaya.OptionsBehavior.ReadOnly = True
        Me.GVMonBiaya.OptionsView.ColumnAutoWidth = False
        Me.GVMonBiaya.OptionsView.ShowFooter = True
        Me.GVMonBiaya.OptionsView.ShowViewCaption = True
        Me.GVMonBiaya.ViewCaption = "MONITOR BIAYA"
        '
        'No
        '
        Me.No.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No.AppearanceHeader.Options.UseFont = True
        Me.No.Caption = "No."
        Me.No.FieldName = "nomer"
        Me.No.Name = "No"
        Me.No.Visible = True
        Me.No.VisibleIndex = 0
        Me.No.Width = 39
        '
        'No_jurnal
        '
        Me.No_jurnal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_jurnal.AppearanceCell.Options.UseFont = True
        Me.No_jurnal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_jurnal.AppearanceHeader.Options.UseFont = True
        Me.No_jurnal.Caption = "No. Jurnal"
        Me.No_jurnal.FieldName = "no_jur"
        Me.No_jurnal.Name = "No_jurnal"
        Me.No_jurnal.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.No_jurnal.Visible = True
        Me.No_jurnal.VisibleIndex = 1
        Me.No_jurnal.Width = 89
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_trans.AppearanceCell.Options.UseFont = True
        Me.tgl_trans.Caption = "Tgl. Transaksi"
        Me.tgl_trans.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 2
        Me.tgl_trans.Width = 97
        '
        'tgl_post
        '
        Me.tgl_post.Caption = "Tgl. Posting"
        Me.tgl_post.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_post.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_post.FieldName = "tgl_posting"
        Me.tgl_post.Name = "tgl_post"
        Me.tgl_post.Visible = True
        Me.tgl_post.VisibleIndex = 3
        Me.tgl_post.Width = 86
        '
        'no_reff1
        '
        Me.no_reff1.Caption = "No. Reff1"
        Me.no_reff1.FieldName = "no_ref1"
        Me.no_reff1.Name = "no_reff1"
        Me.no_reff1.Visible = True
        Me.no_reff1.VisibleIndex = 4
        Me.no_reff1.Width = 91
        '
        'no_reff3
        '
        Me.no_reff3.Caption = "No. Reff3"
        Me.no_reff3.FieldName = "no_ref3"
        Me.no_reff3.Name = "no_reff3"
        Me.no_reff3.Visible = True
        Me.no_reff3.VisibleIndex = 5
        Me.no_reff3.Width = 97
        '
        'Kepada
        '
        Me.Kepada.Caption = "Kepada"
        Me.Kepada.FieldName = "nama"
        Me.Kepada.Name = "Kepada"
        Me.Kepada.Visible = True
        Me.Kepada.VisibleIndex = 6
        Me.Kepada.Width = 78
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 7
        Me.Keterangan.Width = 73
        '
        'nm_buku_besar
        '
        Me.nm_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.nm_buku_besar.Caption = "Rekening"
        Me.nm_buku_besar.FieldName = "nm_buku_besar"
        Me.nm_buku_besar.Name = "nm_buku_besar"
        Me.nm_buku_besar.Visible = True
        Me.nm_buku_besar.VisibleIndex = 8
        Me.nm_buku_besar.Width = 79
        '
        'nm_buku_pusat
        '
        Me.nm_buku_pusat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_buku_pusat.AppearanceHeader.Options.UseFont = True
        Me.nm_buku_pusat.Caption = "Pusat Biaya"
        Me.nm_buku_pusat.FieldName = "nm_buku_pusat"
        Me.nm_buku_pusat.Name = "nm_buku_pusat"
        Me.nm_buku_pusat.Width = 85
        '
        'saldo_val_debet
        '
        Me.saldo_val_debet.Caption = "Debet"
        Me.saldo_val_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_val_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_debet.FieldName = "saldo_val_debet"
        Me.saldo_val_debet.Name = "saldo_val_debet"
        Me.saldo_val_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_debet.Visible = True
        Me.saldo_val_debet.VisibleIndex = 9
        Me.saldo_val_debet.Width = 83
        '
        'saldo_val_kredit
        '
        Me.saldo_val_kredit.Caption = "Kredit"
        Me.saldo_val_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_val_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_kredit.FieldName = "saldo_val_kredit"
        Me.saldo_val_kredit.Name = "saldo_val_kredit"
        Me.saldo_val_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_kredit.Visible = True
        Me.saldo_val_kredit.VisibleIndex = 10
        Me.saldo_val_kredit.Width = 93
        '
        'bulan
        '
        Me.bulan.Caption = "Bulan"
        Me.bulan.FieldName = "bulan"
        Me.bulan.Name = "bulan"
        Me.bulan.Width = 50
        '
        'qty_total
        '
        Me.qty_total.Caption = "Total QTY"
        Me.qty_total.FieldName = "qty_total"
        Me.qty_total.Name = "qty_total"
        Me.qty_total.Width = 45
        '
        'total_rp
        '
        Me.total_rp.Caption = "Total Rp"
        Me.total_rp.FieldName = "total_rp"
        Me.total_rp.Name = "total_rp"
        Me.total_rp.Width = 61
        '
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Controls.Add(Me.LabelControl6)
        Me.Panel4.Controls.Add(Me.tglsampai)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(498, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(261, 43)
        Me.Panel4.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl6.Location = New System.Drawing.Point(0, 21)
        Me.LabelControl6.LookAndFeel.SkinName = "Black"
        Me.LabelControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(69, 22)
        Me.LabelControl6.TabIndex = 26
        Me.LabelControl6.Text = "Sampai : "
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(75, 21)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseBackColor = True
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(160, 20)
        Me.tglsampai.TabIndex = 25
        '
        'Panel5
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel5, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel5.Controls.Add(Me.LabelControl5)
        Me.Panel5.Controls.Add(Me.tglDari)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(261, 21)
        Me.Panel5.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl5.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl5.LookAndFeel.SkinName = "Black"
        Me.LabelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 21)
        Me.LabelControl5.TabIndex = 23
        Me.LabelControl5.Text = "Dari : "
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(75, 0)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseBackColor = True
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(160, 20)
        Me.tglDari.TabIndex = 22
        '
        'Panel2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdPrint)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.cmdAct)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1075, 43)
        Me.Panel2.TabIndex = 5
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(897, 3)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 16
        Me.cmdPrint.ToolTip = "Print Data"
        Me.cmdPrint.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdPrint.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdPrint.ToolTipTitle = "PRINT"
        Me.cmdPrint.Visible = False
        '
        'DefaultToolTipController1
        '
        '
        '
        '
        Me.DefaultToolTipController1.DefaultController.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DefaultToolTipController1.DefaultController.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseBackColor = True
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseFont = True
        Me.DefaultToolTipController1.DefaultController.Rounded = True
        Me.DefaultToolTipController1.DefaultController.ShowBeak = True
        Me.DefaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.Standard
        '
        'Panel3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(367, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 43)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Label1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter Tanggal : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel6, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel6.Controls.Add(Me.PusBiaya)
        Me.Panel6.Controls.Add(Me.RekBiaya)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(228, 43)
        Me.Panel6.TabIndex = 5
        '
        'PusBiaya
        '
        Me.PusBiaya.Location = New System.Drawing.Point(6, 21)
        Me.PusBiaya.Name = "PusBiaya"
        Me.PusBiaya.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PusBiaya.Properties.Appearance.Options.UseBackColor = True
        Me.PusBiaya.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PusBiaya.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "nm_buku_pusat")})
        Me.PusBiaya.Properties.NullText = ""
        Me.PusBiaya.Size = New System.Drawing.Size(201, 20)
        Me.PusBiaya.TabIndex = 27
        '
        'RekBiaya
        '
        Me.RekBiaya.Location = New System.Drawing.Point(6, 0)
        Me.RekBiaya.Name = "RekBiaya"
        Me.RekBiaya.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.RekBiaya.Properties.Appearance.Options.UseBackColor = True
        Me.RekBiaya.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RekBiaya.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "nm_buku_besar")})
        Me.RekBiaya.Properties.NullText = ""
        Me.RekBiaya.Size = New System.Drawing.Size(201, 20)
        Me.RekBiaya.TabIndex = 26
        '
        'Panel7
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel7, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel7.Controls.Add(Me.LabelControl1)
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 43)
        Me.Panel7.TabIndex = 9
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 20)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(139, 20)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Pusat Biaya : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(139, 20)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Rek Biaya : "
        '
        'Panel1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 37)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.lblJudul, DevExpress.Utils.DefaultBoolean.[Default])
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(350, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITORING BIAYA"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PictureBox1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnl
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnl, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnl.Controls.Add(Me.GCMonBiaya)
        Me.pnl.Controls.Add(Me.Panel11)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1075, 492)
        Me.pnl.TabIndex = 2
        '
        'Panel11
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel11, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel11.BackColor = System.Drawing.Color.Maroon
        Me.Panel11.Controls.Add(Me.Panel8)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 456)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1075, 36)
        Me.Panel11.TabIndex = 2
        '
        'Panel8
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel8, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel8.Controls.Add(Me.TxtDebetKredit)
        Me.Panel8.Controls.Add(Me.LabelControl7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(788, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(287, 36)
        Me.Panel8.TabIndex = 9
        '
        'TxtDebetKredit
        '
        Me.TxtDebetKredit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtDebetKredit.Location = New System.Drawing.Point(124, 9)
        Me.TxtDebetKredit.Name = "TxtDebetKredit"
        Me.TxtDebetKredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.TxtDebetKredit.Properties.DisplayFormat.FormatString = "n2"
        Me.TxtDebetKredit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDebetKredit.Properties.ReadOnly = True
        Me.TxtDebetKredit.Size = New System.Drawing.Size(151, 20)
        Me.TxtDebetKredit.TabIndex = 9
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(14, 6)
        Me.LabelControl7.LookAndFeel.SkinName = "Black"
        Me.LabelControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(104, 25)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "(Debet Kredit) : "
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(809, 3)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 15
        Me.cmdClear.ToolTip = "Bersihkan Pencarian"
        Me.cmdClear.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdClear.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdClear.ToolTipTitle = "CLEAR"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(853, 3)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 38)
        Me.cmdRefresh.TabIndex = 14
        Me.cmdRefresh.ToolTip = "Reset Data"
        Me.cmdRefresh.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdRefresh.ToolTipTitle = "RELOAD"
        Me.cmdRefresh.Visible = False
        '
        'cmdAct
        '
        Me.cmdAct.Image = CType(resources.GetObject("cmdAct.Image"), System.Drawing.Image)
        Me.cmdAct.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAct.Location = New System.Drawing.Point(765, 3)
        Me.cmdAct.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdAct.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAct.Name = "cmdAct"
        Me.cmdAct.Size = New System.Drawing.Size(38, 38)
        Me.cmdAct.TabIndex = 10
        Me.cmdAct.ToolTip = "Eksekusi Pencarian"
        Me.cmdAct.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdAct.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdAct.ToolTipTitle = "SEARCH"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMonitorBiaya1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 492)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonitorBiaya1"
        Me.Text = "frmMonitorBiaya"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GVMonDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCMonBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMonBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.PusBiaya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RekBiaya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.TxtDebetKredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PusBiaya As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RekBiaya As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_post As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_jurnal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_reff1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GCMonBiaya As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVMonBiaya As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_reff3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kepada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents total_rp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents nm_buku_pusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVMonDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kdBKpusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nmKDpusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TxtDebetKredit As DevExpress.XtraEditors.SpinEdit
End Class
