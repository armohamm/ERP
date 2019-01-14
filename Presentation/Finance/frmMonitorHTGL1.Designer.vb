<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitorHTGL1
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
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitorHTGL1))
        Me.pnl = New System.Windows.Forms.Panel
        Me.lblLoad1 = New DevExpress.XtraEditors.LabelControl
        Me.GCMonHTGL = New DevExpress.XtraGrid.GridControl
        Me.GVMonHTGL = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_jur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.TxtDebetKredit = New DevExpress.XtraEditors.SpinEdit
        Me.txtSaldoAkhir = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.txtSaldoAwal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.txtSaldoAwalManual = New DevExpress.XtraEditors.TextEdit
        Me.LookUpSaldo = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Valuta = New DevExpress.XtraEditors.LookUpEdit
        Me.Rekening = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnl.SuspendLayout()
        CType(Me.GCMonHTGL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMonHTGL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.TxtDebetKredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.txtSaldoAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.txtSaldoAwalManual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.Valuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rekening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnl, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnl.Controls.Add(Me.lblLoad1)
        Me.pnl.Controls.Add(Me.GCMonHTGL)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.Panel8)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1026, 506)
        Me.pnl.TabIndex = 1
        '
        'lblLoad1
        '
        Me.lblLoad1.Appearance.BackColor = System.Drawing.Color.White
        Me.lblLoad1.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblLoad1.Appearance.Options.UseBackColor = True
        Me.lblLoad1.Appearance.Options.UseFont = True
        Me.lblLoad1.Appearance.Options.UseForeColor = True
        Me.lblLoad1.Location = New System.Drawing.Point(21, 201)
        Me.lblLoad1.Name = "lblLoad1"
        Me.lblLoad1.Size = New System.Drawing.Size(432, 39)
        Me.lblLoad1.TabIndex = 6
        Me.lblLoad1.Text = "Load Data, Silahkan Tunggu..."
        Me.lblLoad1.Visible = False
        '
        'GCMonHTGL
        '
        Me.GCMonHTGL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCMonHTGL.Location = New System.Drawing.Point(0, 121)
        Me.GCMonHTGL.LookAndFeel.SkinName = "The Asphalt World"
        Me.GCMonHTGL.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCMonHTGL.MainView = Me.GVMonHTGL
        Me.GCMonHTGL.Name = "GCMonHTGL"
        Me.GCMonHTGL.Size = New System.Drawing.Size(1026, 321)
        Me.GCMonHTGL.TabIndex = 8
        Me.GCMonHTGL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVMonHTGL})
        '
        'GVMonHTGL
        '
        Me.GVMonHTGL.ActiveFilterEnabled = False
        Me.GVMonHTGL.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVMonHTGL.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVMonHTGL.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVMonHTGL.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVMonHTGL.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.no_jur, Me.tgl_trans, Me.tgl_posting, Me.no_ref1, Me.no_ref3, Me.nama, Me.keterangan, Me.kd_buku_besar, Me.nm_buku_besar, Me.saldo_val_debet, Me.saldo_val_kredit})
        Me.GVMonHTGL.GridControl = Me.GCMonHTGL
        Me.GVMonHTGL.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.GVMonHTGL.Name = "GVMonHTGL"
        Me.GVMonHTGL.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GVMonHTGL.OptionsBehavior.Editable = False
        Me.GVMonHTGL.OptionsBehavior.ReadOnly = True
        Me.GVMonHTGL.OptionsView.ColumnAutoWidth = False
        Me.GVMonHTGL.OptionsView.ShowFooter = True
        Me.GVMonHTGL.OptionsView.ShowViewCaption = True
        Me.GVMonHTGL.ViewCaption = "GENERAL LEDGER"
        '
        'nomer
        '
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        '
        'no_jur
        '
        Me.no_jur.Caption = "No. Jurnal"
        Me.no_jur.FieldName = "no_jur"
        Me.no_jur.Name = "no_jur"
        Me.no_jur.Visible = True
        Me.no_jur.VisibleIndex = 0
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tgl. Trans"
        Me.tgl_trans.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        '
        'tgl_posting
        '
        Me.tgl_posting.Caption = "Tgl. Posting"
        Me.tgl_posting.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_posting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_posting.FieldName = "tgl_posting"
        Me.tgl_posting.Name = "tgl_posting"
        Me.tgl_posting.Visible = True
        Me.tgl_posting.VisibleIndex = 2
        '
        'no_ref1
        '
        Me.no_ref1.Caption = "No Reff1"
        Me.no_ref1.FieldName = "no_ref1"
        Me.no_ref1.Name = "no_ref1"
        Me.no_ref1.Visible = True
        Me.no_ref1.VisibleIndex = 3
        '
        'no_ref3
        '
        Me.no_ref3.Caption = "No. Reff3"
        Me.no_ref3.FieldName = "no_ref3"
        Me.no_ref3.Name = "no_ref3"
        Me.no_ref3.Visible = True
        Me.no_ref3.VisibleIndex = 4
        '
        'nama
        '
        Me.nama.Caption = "Nama"
        Me.nama.FieldName = "nama"
        Me.nama.Name = "nama"
        Me.nama.Visible = True
        Me.nama.VisibleIndex = 5
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 6
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.Caption = "Kd. Buku"
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        '
        'nm_buku_besar
        '
        Me.nm_buku_besar.Caption = "Rekening"
        Me.nm_buku_besar.FieldName = "nm_buku_besar"
        Me.nm_buku_besar.Name = "nm_buku_besar"
        Me.nm_buku_besar.Visible = True
        Me.nm_buku_besar.VisibleIndex = 7
        '
        'saldo_val_debet
        '
        Me.saldo_val_debet.Caption = "Saldo Debet"
        Me.saldo_val_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_val_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_debet.FieldName = "saldo_val_debet"
        Me.saldo_val_debet.Name = "saldo_val_debet"
        Me.saldo_val_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_debet.Visible = True
        Me.saldo_val_debet.VisibleIndex = 8
        '
        'saldo_val_kredit
        '
        Me.saldo_val_kredit.Caption = "Saldo Kredit"
        Me.saldo_val_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_val_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_kredit.FieldName = "saldo_val_kredit"
        Me.saldo_val_kredit.Name = "saldo_val_kredit"
        Me.saldo_val_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_kredit.Visible = True
        Me.saldo_val_kredit.VisibleIndex = 9
        '
        'pnlFooter
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlFooter, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.Panel12)
        Me.pnlFooter.Controls.Add(Me.Panel10)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 442)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1026, 64)
        Me.pnlFooter.TabIndex = 2
        '
        'Panel12
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel12, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel12.BackColor = System.Drawing.Color.Maroon
        Me.Panel12.Controls.Add(Me.lblError)
        Me.Panel12.Controls.Add(Me.Button1)
        Me.Panel12.Controls.Add(Me.Button2)
        Me.Panel12.Controls.Add(Me.Button3)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(746, 64)
        Me.Panel12.TabIndex = 14
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(3, 40)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 16)
        Me.lblError.TabIndex = 13
        Me.lblError.Text = "..."
        '
        'Button1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Button1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Button1.Location = New System.Drawing.Point(419, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Saldo Awal"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Button2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Button2.Location = New System.Drawing.Point(500, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Button3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Button3.Location = New System.Drawing.Point(581, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Saldo Akhir"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Panel10
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel10, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel10.BackColor = System.Drawing.Color.Maroon
        Me.Panel10.Controls.Add(Me.TxtDebetKredit)
        Me.Panel10.Controls.Add(Me.txtSaldoAkhir)
        Me.Panel10.Controls.Add(Me.LabelControl7)
        Me.Panel10.Controls.Add(Me.LabelControl4)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(746, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(280, 64)
        Me.Panel10.TabIndex = 13
        '
        'TxtDebetKredit
        '
        Me.TxtDebetKredit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtDebetKredit.Location = New System.Drawing.Point(101, 9)
        Me.TxtDebetKredit.Name = "TxtDebetKredit"
        Me.TxtDebetKredit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDebetKredit.Properties.Appearance.Options.UseBackColor = True
        Me.TxtDebetKredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.TxtDebetKredit.Properties.DisplayFormat.FormatString = "n2"
        Me.TxtDebetKredit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDebetKredit.Size = New System.Drawing.Size(172, 20)
        Me.TxtDebetKredit.TabIndex = 8
        '
        'txtSaldoAkhir
        '
        Me.txtSaldoAkhir.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldoAkhir.Location = New System.Drawing.Point(101, 36)
        Me.txtSaldoAkhir.Name = "txtSaldoAkhir"
        Me.txtSaldoAkhir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldoAkhir.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.txtSaldoAkhir.Properties.DisplayFormat.FormatString = "n2"
        Me.txtSaldoAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAkhir.Size = New System.Drawing.Size(172, 20)
        Me.txtSaldoAkhir.TabIndex = 7
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
        Me.LabelControl7.Location = New System.Drawing.Point(6, 7)
        Me.LabelControl7.LookAndFeel.SkinName = "Black"
        Me.LabelControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(89, 25)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "(Debet Kredit) : "
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(14, 32)
        Me.LabelControl4.LookAndFeel.SkinName = "Black"
        Me.LabelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(81, 28)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Saldo Akhir : "
        '
        'Panel8
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel8, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 80)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1026, 41)
        Me.Panel8.TabIndex = 7
        '
        'Panel11
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel11, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel11.Controls.Add(Me.txtSaldoAwal)
        Me.Panel11.Controls.Add(Me.LabelControl3)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(752, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(274, 41)
        Me.Panel11.TabIndex = 5
        '
        'txtSaldoAwal
        '
        Me.txtSaldoAwal.Location = New System.Drawing.Point(83, 10)
        Me.txtSaldoAwal.Name = "txtSaldoAwal"
        Me.txtSaldoAwal.Properties.DisplayFormat.FormatString = "n2"
        Me.txtSaldoAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAwal.Properties.Mask.BeepOnError = True
        Me.txtSaldoAwal.Properties.Mask.EditMask = "d"
        Me.txtSaldoAwal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSaldoAwal.Properties.ReadOnly = True
        Me.txtSaldoAwal.Size = New System.Drawing.Size(180, 20)
        Me.txtSaldoAwal.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl3.LookAndFeel.SkinName = "Black"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(77, 38)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Saldo Awal : "
        '
        'Panel9
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel9, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel9.Controls.Add(Me.txtSaldoAwalManual)
        Me.Panel9.Controls.Add(Me.LookUpSaldo)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1026, 41)
        Me.Panel9.TabIndex = 4
        '
        'txtSaldoAwalManual
        '
        Me.txtSaldoAwalManual.Location = New System.Drawing.Point(553, 10)
        Me.txtSaldoAwalManual.Name = "txtSaldoAwalManual"
        Me.txtSaldoAwalManual.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSaldoAwalManual.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtSaldoAwalManual.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoAwalManual.Properties.Appearance.Options.UseForeColor = True
        Me.txtSaldoAwalManual.Properties.DisplayFormat.FormatString = "n2"
        Me.txtSaldoAwalManual.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAwalManual.Properties.EditFormat.FormatString = "n2"
        Me.txtSaldoAwalManual.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAwalManual.Properties.Mask.BeepOnError = True
        Me.txtSaldoAwalManual.Properties.Mask.EditMask = "n2"
        Me.txtSaldoAwalManual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSaldoAwalManual.Properties.ReadOnly = True
        Me.txtSaldoAwalManual.Size = New System.Drawing.Size(180, 20)
        Me.txtSaldoAwalManual.TabIndex = 28
        Me.txtSaldoAwalManual.Visible = False
        '
        'LookUpSaldo
        '
        Me.LookUpSaldo.Location = New System.Drawing.Point(139, 10)
        Me.LookUpSaldo.Name = "LookUpSaldo"
        Me.LookUpSaldo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpSaldo.Properties.Appearance.Options.UseBackColor = True
        Me.LookUpSaldo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LookUpSaldo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpSaldo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kartu", "Kartu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("thn_buku", "Tahun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bln_buku", "Bulan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_val_debet", "Debet"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_val_kredit", "Kredit"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Buku Besar"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Buku Pusat")})
        Me.LookUpSaldo.Properties.NullText = "List Saldo"
        Me.LookUpSaldo.Size = New System.Drawing.Size(205, 20)
        Me.LookUpSaldo.TabIndex = 27
        Me.LookUpSaldo.Visible = False
        '
        'Panel2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdPrint)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 43)
        Me.Panel2.TabIndex = 5
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(896, 3)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 11
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
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Controls.Add(Me.LabelControl6)
        Me.Panel4.Controls.Add(Me.tglsampai)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(498, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(260, 43)
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
        Me.tglsampai.Location = New System.Drawing.Point(81, 21)
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
        Me.tglsampai.Size = New System.Drawing.Size(154, 20)
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
        Me.Panel5.Size = New System.Drawing.Size(260, 21)
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
        Me.tglDari.Location = New System.Drawing.Point(81, 0)
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
        Me.tglDari.Size = New System.Drawing.Size(154, 20)
        Me.tglDari.TabIndex = 22
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
        Me.Panel6.Controls.Add(Me.Valuta)
        Me.Panel6.Controls.Add(Me.Rekening)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(228, 43)
        Me.Panel6.TabIndex = 5
        '
        'Valuta
        '
        Me.Valuta.Location = New System.Drawing.Point(0, 21)
        Me.Valuta.Name = "Valuta"
        Me.Valuta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Valuta.Properties.Appearance.Options.UseBackColor = True
        Me.Valuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Valuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama Valuta")})
        Me.Valuta.Properties.NullText = ""
        Me.Valuta.Size = New System.Drawing.Size(205, 20)
        Me.Valuta.TabIndex = 27
        '
        'Rekening
        '
        Me.Rekening.Location = New System.Drawing.Point(0, 0)
        Me.Rekening.Name = "Rekening"
        Me.Rekening.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Rekening.Properties.Appearance.Options.UseBackColor = True
        Me.Rekening.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Rekening.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Rekening")})
        Me.Rekening.Properties.NullText = ""
        Me.Rekening.Size = New System.Drawing.Size(205, 20)
        Me.Rekening.TabIndex = 26
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
        Me.LabelControl1.Text = "Valuta : "
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
        Me.LabelControl2.Text = "Rekening : "
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
        Me.Panel1.Size = New System.Drawing.Size(1026, 37)
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
        Me.lblJudul.Size = New System.Drawing.Size(459, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITORING HARIAN TRANSAKSI GENERAL LEDGER"
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
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(764, 3)
        Me.SimpleButton1.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 38)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.ToolTip = "Eksekusi Pencarian"
        Me.SimpleButton1.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.SimpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.SimpleButton1.ToolTipTitle = "SEARCH"
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(808, 3)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.ToolTip = "Bersihkan Pencarian"
        Me.cmdClear.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdClear.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdClear.ToolTipTitle = "CLEAR"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(852, 3)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 38)
        Me.cmdRefresh.TabIndex = 3
        Me.cmdRefresh.ToolTip = "Reset Data"
        Me.cmdRefresh.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdRefresh.ToolTipTitle = "RELOAD"
        Me.cmdRefresh.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMonitorHTGL1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 506)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonitorHTGL1"
        Me.Text = "frmMonitorHTGL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.GCMonHTGL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMonHTGL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        CType(Me.TxtDebetKredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.txtSaldoAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.txtSaldoAwalManual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.Valuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rekening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Rekening As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Valuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GCMonHTGL As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVMonHTGL As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LookUpSaldo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_jur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtSaldoAwal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLoad1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoAwalManual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoAkhir As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TxtDebetKredit As DevExpress.XtraEditors.SpinEdit
End Class
