<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportGL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportGL))
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lookPeriode = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.txtModulSaldoAwal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.lookRekening = New DevExpress.XtraEditors.LookUpEdit
        Me.LookUpSaldo = New DevExpress.XtraEditors.LookUpEdit
        Me.lookVal = New DevExpress.XtraEditors.LookUpEdit
        Me.txtSaldoAwal = New DevExpress.XtraEditors.TextEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExe = New DevExpress.XtraEditors.SimpleButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel4.SuspendLayout()
        CType(Me.lookPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModulSaldoAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookRekening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LabelControl5.Location = New System.Drawing.Point(24, 5)
        Me.LabelControl5.LookAndFeel.SkinName = "Black"
        Me.LabelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(101, 21)
        Me.LabelControl5.TabIndex = 23
        Me.LabelControl5.Text = "Periode : "
        '
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Controls.Add(Me.lookPeriode)
        Me.Panel4.Controls.Add(Me.LabelControl4)
        Me.Panel4.Controls.Add(Me.MemoEdit1)
        Me.Panel4.Controls.Add(Me.txtModulSaldoAwal)
        Me.Panel4.Controls.Add(Me.LabelControl8)
        Me.Panel4.Controls.Add(Me.LabelControl7)
        Me.Panel4.Controls.Add(Me.LabelControl20)
        Me.Panel4.Controls.Add(Me.lookRekening)
        Me.Panel4.Controls.Add(Me.LookUpSaldo)
        Me.Panel4.Controls.Add(Me.lookVal)
        Me.Panel4.Controls.Add(Me.txtSaldoAwal)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(131, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(381, 218)
        Me.Panel4.TabIndex = 2
        '
        'lookPeriode
        '
        Me.lookPeriode.Location = New System.Drawing.Point(3, 5)
        Me.lookPeriode.Name = "lookPeriode"
        Me.lookPeriode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lookPeriode.Properties.Appearance.Options.UseBackColor = True
        Me.lookPeriode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookPeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookPeriode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Name3")})
        Me.lookPeriode.Properties.NullText = ""
        Me.lookPeriode.Properties.PopupSizeable = False
        Me.lookPeriode.Properties.ShowFooter = False
        Me.lookPeriode.Properties.ShowHeader = False
        Me.lookPeriode.Properties.ShowPopupShadow = False
        Me.lookPeriode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookPeriode.Size = New System.Drawing.Size(154, 20)
        Me.lookPeriode.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(160, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(30, 19)
        Me.LabelControl4.TabIndex = 43
        Me.LabelControl4.Text = "***"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.EditValue = "* Tanggal dan valuta dapat di filter mandiri." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "** Rekening harus menyertakan tang" & _
            "gal dan valuta." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*** Saldo awal hanya muncul dengan menyertakan tanggal, valuta " & _
            "dan rekening."
        Me.MemoEdit1.Location = New System.Drawing.Point(6, 137)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MemoEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.MemoEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.MemoEdit1.Properties.Appearance.Options.UseFont = True
        Me.MemoEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.MemoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.MemoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MemoEdit1.Size = New System.Drawing.Size(307, 75)
        Me.MemoEdit1.TabIndex = 42
        '
        'txtModulSaldoAwal
        '
        Me.txtModulSaldoAwal.Enabled = False
        Me.txtModulSaldoAwal.Location = New System.Drawing.Point(224, 85)
        Me.txtModulSaldoAwal.Name = "txtModulSaldoAwal"
        Me.txtModulSaldoAwal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtModulSaldoAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtModulSaldoAwal.Properties.Appearance.Options.UseBackColor = True
        Me.txtModulSaldoAwal.Properties.Appearance.Options.UseForeColor = True
        Me.txtModulSaldoAwal.Properties.ReadOnly = True
        Me.txtModulSaldoAwal.Size = New System.Drawing.Size(154, 20)
        Me.txtModulSaldoAwal.TabIndex = 39
        Me.txtModulSaldoAwal.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(160, 58)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(20, 19)
        Me.LabelControl8.TabIndex = 36
        Me.LabelControl8.Text = "**"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(159, 31)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl7.TabIndex = 35
        Me.LabelControl7.Text = "*"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(160, 5)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl20.TabIndex = 34
        Me.LabelControl20.Text = "*"
        '
        'lookRekening
        '
        Me.lookRekening.Location = New System.Drawing.Point(3, 59)
        Me.lookRekening.Name = "lookRekening"
        Me.lookRekening.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.lookRekening.Properties.Appearance.Options.UseBackColor = True
        Me.lookRekening.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookRekening.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.lookRekening.Properties.NullText = ""
        Me.lookRekening.Properties.PopupSizeable = False
        Me.lookRekening.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookRekening.Size = New System.Drawing.Size(154, 20)
        Me.lookRekening.TabIndex = 3
        '
        'LookUpSaldo
        '
        Me.LookUpSaldo.Location = New System.Drawing.Point(3, 111)
        Me.LookUpSaldo.Name = "LookUpSaldo"
        Me.LookUpSaldo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpSaldo.Properties.Appearance.Options.UseBackColor = True
        Me.LookUpSaldo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LookUpSaldo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpSaldo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kartu", "Kartu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("thn_buku", "Tahun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bln_buku", "Bulan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_val_debet", "Debet"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_val_kredit", "Kredit"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Buku Besar"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Buku Pusat")})
        Me.LookUpSaldo.Properties.NullText = "List Saldo"
        Me.LookUpSaldo.Size = New System.Drawing.Size(154, 20)
        Me.LookUpSaldo.TabIndex = 31
        Me.LookUpSaldo.Visible = False
        '
        'lookVal
        '
        Me.lookVal.Location = New System.Drawing.Point(3, 33)
        Me.lookVal.Name = "lookVal"
        Me.lookVal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lookVal.Properties.Appearance.Options.UseBackColor = True
        Me.lookVal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookVal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Valuta", "Kode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama")})
        Me.lookVal.Properties.NullText = ""
        Me.lookVal.Properties.PopupSizeable = False
        Me.lookVal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookVal.Size = New System.Drawing.Size(154, 20)
        Me.lookVal.TabIndex = 2
        '
        'txtSaldoAwal
        '
        Me.txtSaldoAwal.Location = New System.Drawing.Point(3, 85)
        Me.txtSaldoAwal.Name = "txtSaldoAwal"
        Me.txtSaldoAwal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldoAwal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoAwal.Properties.DisplayFormat.FormatString = "n2"
        Me.txtSaldoAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAwal.Properties.ReadOnly = True
        Me.txtSaldoAwal.Size = New System.Drawing.Size(154, 20)
        Me.txtSaldoAwal.TabIndex = 4
        '
        'Panel2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 218)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel3.Controls.Add(Me.LabelControl1)
        Me.Panel3.Controls.Add(Me.LabelControl5)
        Me.Panel3.Controls.Add(Me.LabelControl3)
        Me.Panel3.Controls.Add(Me.LabelControl2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 218)
        Me.Panel3.TabIndex = 1
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
        Me.LabelControl1.Location = New System.Drawing.Point(56, 32)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 21)
        Me.LabelControl1.TabIndex = 25
        Me.LabelControl1.Text = "Valuta : "
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
        Me.LabelControl3.Location = New System.Drawing.Point(56, 84)
        Me.LabelControl3.LookAndFeel.SkinName = "Black"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 21)
        Me.LabelControl3.TabIndex = 30
        Me.LabelControl3.Text = "Saldo Awal : "
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
        Me.LabelControl2.Location = New System.Drawing.Point(56, 58)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 21)
        Me.LabelControl2.TabIndex = 27
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
        Me.Panel1.Size = New System.Drawing.Size(528, 37)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.lblJudul, DevExpress.Utils.DefaultBoolean.[Default])
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(365, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "LAPORAN GENERAL LEDGER"
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel8
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel8, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.cmdPrint)
        Me.Panel8.Controls.Add(Me.cmdClear)
        Me.Panel8.Controls.Add(Me.cmdExe)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 255)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(528, 84)
        Me.Panel8.TabIndex = 7
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(220, 6)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 32
        Me.cmdPrint.ToolTip = "Cetak Laporan Ke Printer"
        Me.cmdPrint.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdPrint.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application
        Me.cmdPrint.ToolTipTitle = "Print"
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
        'pnl
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnl, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.Panel8)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(528, 339)
        Me.pnl.TabIndex = 2
        '
        'pnlFooter
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlFooter, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.Panel12)
        Me.pnlFooter.Controls.Add(Me.Panel10)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 303)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(528, 36)
        Me.pnlFooter.TabIndex = 2
        '
        'Panel12
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel12, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel12.BackColor = System.Drawing.Color.Maroon
        Me.Panel12.Controls.Add(Me.lblError)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(528, 36)
        Me.Panel12.TabIndex = 14
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(12, 8)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 16)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "..."
        '
        'Panel10
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel10, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(528, 36)
        Me.Panel10.TabIndex = 13
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(176, 6)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.ToolTip = "Bersihkan Isian Pada Control"
        Me.cmdClear.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdClear.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning
        Me.cmdClear.ToolTipTitle = "Clear"
        Me.cmdClear.Visible = False
        '
        'cmdExe
        '
        Me.cmdExe.Image = CType(resources.GetObject("cmdExe.Image"), System.Drawing.Image)
        Me.cmdExe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExe.Location = New System.Drawing.Point(132, 6)
        Me.cmdExe.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdExe.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExe.Name = "cmdExe"
        Me.cmdExe.Size = New System.Drawing.Size(38, 38)
        Me.cmdExe.TabIndex = 10
        Me.cmdExe.ToolTip = "Eksekusi Pencarian"
        Me.cmdExe.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdExe.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdExe.ToolTipTitle = "OK"
        Me.cmdExe.Visible = False
        '
        'frmReportGL
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 367)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmReportGL"
        Me.Text = "frmReportGL"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.lookPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModulSaldoAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookRekening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lookVal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lookRekening As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoAwal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpSaldo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtModulSaldoAwal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lookPeriode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
End Class
