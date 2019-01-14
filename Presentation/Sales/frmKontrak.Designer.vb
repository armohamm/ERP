<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKontrak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKontrak))
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlField = New System.Windows.Forms.Panel
        Me.txtHadiah = New DevExpress.XtraEditors.MemoEdit
        Me.txtTotOmzet = New DevExpress.XtraEditors.SpinEdit
        Me.lblState = New System.Windows.Forms.Label
        Me.txtKdCustomer = New DevExpress.XtraEditors.TextEdit
        Me.txtProgram = New DevExpress.XtraEditors.LookUpEdit
        Me.tgl = New DevExpress.XtraEditors.TextEdit
        Me.cmdHadiah = New DevExpress.XtraEditors.LookUpEdit
        Me.txtSelama = New DevExpress.XtraEditors.TextEdit
        Me.tglSampai = New DevExpress.XtraEditors.DateEdit
        Me.tglMulai = New DevExpress.XtraEditors.DateEdit
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.txtNamaProgram = New DevExpress.XtraEditors.MemoEdit
        Me.txtStatus = New DevExpress.XtraEditors.RadioGroup
        Me.txtOmzet = New DevExpress.XtraEditors.SpinEdit
        Me.txtJnsOmzet = New DevExpress.XtraEditors.RadioGroup
        Me.pnlLabel = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Jenis = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNilai = New DevExpress.XtraEditors.SpinEdit
        Me.vValas = New DevExpress.XtraEditors.LookUpEdit
        Me.pnl.SuspendLayout()
        Me.pnlField.SuspendLayout()
        CType(Me.txtHadiah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotOmzet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKdCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProgram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdHadiah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSelama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaProgram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOmzet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJnsOmzet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vValas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlField)
        Me.pnl.Controls.Add(Me.pnlLabel)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(517, 395)
        Me.pnl.TabIndex = 0
        '
        'pnlField
        '
        Me.pnlField.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlField.Controls.Add(Me.vValas)
        Me.pnlField.Controls.Add(Me.txtNilai)
        Me.pnlField.Controls.Add(Me.txtHadiah)
        Me.pnlField.Controls.Add(Me.txtTotOmzet)
        Me.pnlField.Controls.Add(Me.lblState)
        Me.pnlField.Controls.Add(Me.txtKdCustomer)
        Me.pnlField.Controls.Add(Me.txtProgram)
        Me.pnlField.Controls.Add(Me.tgl)
        Me.pnlField.Controls.Add(Me.cmdHadiah)
        Me.pnlField.Controls.Add(Me.txtSelama)
        Me.pnlField.Controls.Add(Me.tglSampai)
        Me.pnlField.Controls.Add(Me.tglMulai)
        Me.pnlField.Controls.Add(Me.txtCustomer)
        Me.pnlField.Controls.Add(Me.txtNomor)
        Me.pnlField.Controls.Add(Me.txtNamaProgram)
        Me.pnlField.Controls.Add(Me.txtStatus)
        Me.pnlField.Controls.Add(Me.txtOmzet)
        Me.pnlField.Controls.Add(Me.txtJnsOmzet)
        Me.pnlField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlField.Location = New System.Drawing.Point(159, 37)
        Me.pnlField.Name = "pnlField"
        Me.pnlField.Size = New System.Drawing.Size(356, 356)
        Me.pnlField.TabIndex = 6
        '
        'txtHadiah
        '
        Me.txtHadiah.EnterMoveNextControl = True
        Me.txtHadiah.Location = New System.Drawing.Point(1, 244)
        Me.txtHadiah.Name = "txtHadiah"
        Me.txtHadiah.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtHadiah.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHadiah.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtHadiah.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtHadiah.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtHadiah.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtHadiah.Size = New System.Drawing.Size(352, 57)
        Me.txtHadiah.TabIndex = 16
        '
        'txtTotOmzet
        '
        Me.txtTotOmzet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotOmzet.Location = New System.Drawing.Point(0, 223)
        Me.txtTotOmzet.Name = "txtTotOmzet"
        Me.txtTotOmzet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtTotOmzet.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotOmzet.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtTotOmzet.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTotOmzet.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtTotOmzet.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtTotOmzet.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotOmzet.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotOmzet.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotOmzet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotOmzet.Properties.EditFormat.FormatString = "n2"
        Me.txtTotOmzet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotOmzet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtTotOmzet.Properties.Mask.EditMask = "n2"
        Me.txtTotOmzet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtTotOmzet.Size = New System.Drawing.Size(152, 20)
        Me.txtTotOmzet.TabIndex = 14
        '
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblState.Location = New System.Drawing.Point(235, 4)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(115, 13)
        Me.lblState.TabIndex = 13
        Me.lblState.Text = "--"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKdCustomer
        '
        Me.txtKdCustomer.EnterMoveNextControl = True
        Me.txtKdCustomer.Location = New System.Drawing.Point(228, 83)
        Me.txtKdCustomer.Name = "txtKdCustomer"
        Me.txtKdCustomer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKdCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtKdCustomer.Properties.DisplayFormat.FormatString = "n2"
        Me.txtKdCustomer.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKdCustomer.Size = New System.Drawing.Size(129, 20)
        Me.txtKdCustomer.TabIndex = 12
        '
        'txtProgram
        '
        Me.txtProgram.EnterMoveNextControl = True
        Me.txtProgram.Location = New System.Drawing.Point(0, 103)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProgram.Properties.Appearance.Options.UseBackColor = True
        Me.txtProgram.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtProgram.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgram.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtProgram.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtProgram.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtProgram.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtProgram.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProgram.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Divisi")})
        Me.txtProgram.Properties.DisplayMember = "Nama"
        Me.txtProgram.Properties.HideSelection = False
        Me.txtProgram.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtProgram.Properties.NullText = ""
        Me.txtProgram.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtProgram.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtProgram.Properties.PopupWidth = 400
        Me.txtProgram.Properties.ShowHeader = False
        Me.txtProgram.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtProgram.Properties.ValueMember = "Kode"
        Me.txtProgram.Size = New System.Drawing.Size(152, 20)
        Me.txtProgram.TabIndex = 5
        '
        'tgl
        '
        Me.tgl.EnterMoveNextControl = True
        Me.tgl.Location = New System.Drawing.Point(0, 63)
        Me.tgl.Name = "tgl"
        Me.tgl.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tgl.Properties.Appearance.Options.UseBackColor = True
        Me.tgl.Properties.ReadOnly = True
        Me.tgl.Size = New System.Drawing.Size(152, 20)
        Me.tgl.TabIndex = 3
        '
        'cmdHadiah
        '
        Me.cmdHadiah.EnterMoveNextControl = True
        Me.cmdHadiah.Location = New System.Drawing.Point(176, 137)
        Me.cmdHadiah.Name = "cmdHadiah"
        Me.cmdHadiah.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdHadiah.Properties.Appearance.Options.UseBackColor = True
        Me.cmdHadiah.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdHadiah.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHadiah.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdHadiah.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdHadiah.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdHadiah.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdHadiah.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdHadiah.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HADIAH", 50, "Kode")})
        Me.cmdHadiah.Properties.DisplayMember = "HADIAH"
        Me.cmdHadiah.Properties.HideSelection = False
        Me.cmdHadiah.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdHadiah.Properties.NullText = ""
        Me.cmdHadiah.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.cmdHadiah.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.cmdHadiah.Properties.PopupWidth = 400
        Me.cmdHadiah.Properties.ShowHeader = False
        Me.cmdHadiah.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cmdHadiah.Properties.ValueMember = "KD_HADIAH"
        Me.cmdHadiah.Size = New System.Drawing.Size(144, 20)
        Me.cmdHadiah.TabIndex = 10
        Me.cmdHadiah.Visible = False
        '
        'txtSelama
        '
        Me.txtSelama.EditValue = 0
        Me.txtSelama.Enabled = False
        Me.txtSelama.EnterMoveNextControl = True
        Me.txtSelama.Location = New System.Drawing.Point(0, 163)
        Me.txtSelama.Name = "txtSelama"
        Me.txtSelama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSelama.Properties.Appearance.Options.UseBackColor = True
        Me.txtSelama.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSelama.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSelama.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSelama.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtSelama.Properties.ReadOnly = True
        Me.txtSelama.Size = New System.Drawing.Size(56, 20)
        Me.txtSelama.TabIndex = 8
        '
        'tglSampai
        '
        Me.tglSampai.EditValue = Nothing
        Me.tglSampai.EnterMoveNextControl = True
        Me.tglSampai.Location = New System.Drawing.Point(0, 143)
        Me.tglSampai.Name = "tglSampai"
        Me.tglSampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglSampai.Properties.Appearance.Options.UseFont = True
        Me.tglSampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglSampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglSampai.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.tglSampai.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglSampai.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.tglSampai.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tglSampai.Properties.AppearanceFocused.Options.UseFont = True
        Me.tglSampai.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tglSampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglSampai.Properties.DisplayFormat.FormatString = "D"
        Me.tglSampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglSampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglSampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglSampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglSampai.Size = New System.Drawing.Size(152, 20)
        Me.tglSampai.TabIndex = 7
        '
        'tglMulai
        '
        Me.tglMulai.EditValue = Nothing
        Me.tglMulai.EnterMoveNextControl = True
        Me.tglMulai.Location = New System.Drawing.Point(0, 123)
        Me.tglMulai.Name = "tglMulai"
        Me.tglMulai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglMulai.Properties.Appearance.Options.UseFont = True
        Me.tglMulai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglMulai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglMulai.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.tglMulai.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglMulai.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.tglMulai.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tglMulai.Properties.AppearanceFocused.Options.UseFont = True
        Me.tglMulai.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tglMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglMulai.Properties.DisplayFormat.FormatString = "D"
        Me.tglMulai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglMulai.Properties.EditFormat.FormatString = "DDMMYYYY"
        Me.tglMulai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglMulai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglMulai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglMulai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglMulai.Size = New System.Drawing.Size(152, 20)
        Me.tglMulai.TabIndex = 6
        '
        'txtCustomer
        '
        Me.txtCustomer.EnterMoveNextControl = True
        Me.txtCustomer.Location = New System.Drawing.Point(0, 83)
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
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", 50, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 100, "Nama")})
        Me.txtCustomer.Properties.DisplayMember = "Nama_Customer"
        Me.txtCustomer.Properties.HideSelection = False
        Me.txtCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtCustomer.Properties.NullText = ""
        Me.txtCustomer.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtCustomer.Properties.PopupFormMinSize = New System.Drawing.Size(400, 300)
        Me.txtCustomer.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtCustomer.Properties.PopupWidth = 400
        Me.txtCustomer.Properties.ShowHeader = False
        Me.txtCustomer.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtCustomer.Properties.ValueMember = "Kd_Customer"
        Me.txtCustomer.Size = New System.Drawing.Size(229, 20)
        Me.txtCustomer.TabIndex = 4
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNomor.EnterMoveNextControl = True
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtNomor.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomor.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtNomor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomor.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtNomor.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNomor.Size = New System.Drawing.Size(229, 20)
        Me.txtNomor.TabIndex = 0
        '
        'txtNamaProgram
        '
        Me.txtNamaProgram.EnterMoveNextControl = True
        Me.txtNamaProgram.Location = New System.Drawing.Point(0, 20)
        Me.txtNamaProgram.Name = "txtNamaProgram"
        Me.txtNamaProgram.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtNamaProgram.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaProgram.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtNamaProgram.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNamaProgram.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtNamaProgram.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNamaProgram.Size = New System.Drawing.Size(356, 43)
        Me.txtNamaProgram.TabIndex = 2
        '
        'txtStatus
        '
        Me.txtStatus.EditValue = "Y"
        Me.txtStatus.Location = New System.Drawing.Point(3, 323)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtStatus.Properties.Appearance.Options.UseBackColor = True
        Me.txtStatus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtStatus.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtStatus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtStatus.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtStatus.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtStatus.Properties.DisplayFormat.FormatString = "n2"
        Me.txtStatus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtStatus.Properties.EnableFocusRect = True
        Me.txtStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Y", "AKTIF"), New DevExpress.XtraEditors.Controls.RadioGroupItem("T", "TIDAK AKTIF")})
        Me.txtStatus.Size = New System.Drawing.Size(178, 20)
        Me.txtStatus.TabIndex = 11
        '
        'txtOmzet
        '
        Me.txtOmzet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOmzet.Location = New System.Drawing.Point(0, 203)
        Me.txtOmzet.Name = "txtOmzet"
        Me.txtOmzet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtOmzet.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOmzet.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtOmzet.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtOmzet.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtOmzet.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtOmzet.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOmzet.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtOmzet.Properties.DisplayFormat.FormatString = "n2"
        Me.txtOmzet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOmzet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOmzet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtOmzet.Properties.Mask.EditMask = "n2"
        Me.txtOmzet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtOmzet.Size = New System.Drawing.Size(152, 20)
        Me.txtOmzet.TabIndex = 9
        '
        'txtJnsOmzet
        '
        Me.txtJnsOmzet.EditValue = "BULAN"
        Me.txtJnsOmzet.Location = New System.Drawing.Point(0, 183)
        Me.txtJnsOmzet.Name = "txtJnsOmzet"
        Me.txtJnsOmzet.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtJnsOmzet.Properties.Appearance.Options.UseBackColor = True
        Me.txtJnsOmzet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtJnsOmzet.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJnsOmzet.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtJnsOmzet.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtJnsOmzet.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtJnsOmzet.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtJnsOmzet.Properties.DisplayFormat.FormatString = "n0"
        Me.txtJnsOmzet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJnsOmzet.Properties.EditFormat.FormatString = "n0"
        Me.txtJnsOmzet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJnsOmzet.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("BULAN", "Bulanan"), New DevExpress.XtraEditors.Controls.RadioGroupItem("TOTAL", "Total")})
        Me.txtJnsOmzet.Size = New System.Drawing.Size(152, 21)
        Me.txtJnsOmzet.TabIndex = 15
        '
        'pnlLabel
        '
        Me.pnlLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlLabel.Controls.Add(Me.Label8)
        Me.pnlLabel.Controls.Add(Me.Label13)
        Me.pnlLabel.Controls.Add(Me.Label9)
        Me.pnlLabel.Controls.Add(Me.Label11)
        Me.pnlLabel.Controls.Add(Me.Label12)
        Me.pnlLabel.Controls.Add(Me.Jenis)
        Me.pnlLabel.Controls.Add(Me.Label7)
        Me.pnlLabel.Controls.Add(Me.Label6)
        Me.pnlLabel.Controls.Add(Me.Label5)
        Me.pnlLabel.Controls.Add(Me.Label4)
        Me.pnlLabel.Controls.Add(Me.Label3)
        Me.pnlLabel.Controls.Add(Me.Label2)
        Me.pnlLabel.Controls.Add(Me.Label10)
        Me.pnlLabel.Controls.Add(Me.Label1)
        Me.pnlLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlLabel.ForeColor = System.Drawing.Color.White
        Me.pnlLabel.Location = New System.Drawing.Point(0, 37)
        Me.pnlLabel.Name = "pnlLabel"
        Me.pnlLabel.Size = New System.Drawing.Size(159, 356)
        Me.pnlLabel.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Location = New System.Drawing.Point(0, 301)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "* Nilai Hadiah : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(0, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 61)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "* Hadiah : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Location = New System.Drawing.Point(0, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "* Total Omzet : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Location = New System.Drawing.Point(0, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "* Omzet Bulanan Rp : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Jenis
        '
        Me.Jenis.Dock = System.Windows.Forms.DockStyle.Top
        Me.Jenis.Location = New System.Drawing.Point(0, 180)
        Me.Jenis.Name = "Jenis"
        Me.Jenis.Size = New System.Drawing.Size(159, 20)
        Me.Jenis.TabIndex = 7
        Me.Jenis.Text = "* Jenis Omzet : "
        Me.Jenis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Location = New System.Drawing.Point(0, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Selama (bulan) : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "* Tanggal Berakhiri : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "* Tanggal Mulai : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "* Program : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "* Customer : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Location = New System.Drawing.Point(0, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 40)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "* Nama Program : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* No Kontrak : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 37)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(470, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "PROGRAM OMZET PENJUALAN"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Location = New System.Drawing.Point(0, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "* Status : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNilai
        '
        Me.txtNilai.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNilai.Location = New System.Drawing.Point(78, 301)
        Me.txtNilai.Name = "txtNilai"
        Me.txtNilai.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtNilai.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNilai.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtNilai.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNilai.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtNilai.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNilai.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNilai.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNilai.Properties.DisplayFormat.FormatString = "n2"
        Me.txtNilai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilai.Properties.EditFormat.FormatString = "n2"
        Me.txtNilai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNilai.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtNilai.Properties.Mask.EditMask = "n2"
        Me.txtNilai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtNilai.Size = New System.Drawing.Size(152, 20)
        Me.txtNilai.TabIndex = 17
        '
        'vValas
        '
        Me.vValas.Location = New System.Drawing.Point(2, 302)
        Me.vValas.Name = "vValas"
        Me.vValas.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.vValas.Properties.Appearance.Options.UseBackColor = True
        Me.vValas.Properties.Appearance.Options.UseTextOptions = True
        Me.vValas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vValas.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.vValas.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.vValas.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.vValas.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.vValas.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.vValas.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vValas.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.vValas.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.vValas.Properties.AppearanceFocused.Options.UseFont = True
        Me.vValas.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.vValas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vValas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Valuta", 25, "Valas"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", 100, "Keterangan")})
        Me.vValas.Properties.DisplayMember = "Kode_Valuta"
        Me.vValas.Properties.DropDownRows = 15
        Me.vValas.Properties.HideSelection = False
        Me.vValas.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.vValas.Properties.NullText = ""
        Me.vValas.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.vValas.Properties.PopupFormMinSize = New System.Drawing.Size(100, 100)
        Me.vValas.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.vValas.Properties.PopupWidth = 175
        Me.vValas.Properties.ShowHeader = False
        Me.vValas.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.vValas.Properties.ValueMember = "Kode_Valuta"
        Me.vValas.Size = New System.Drawing.Size(76, 20)
        Me.vValas.TabIndex = 18
        '
        'frmKontrak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 413)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmKontrak"
        Me.Text = "frmKontrak"
        Me.pnl.ResumeLayout(False)
        Me.pnlField.ResumeLayout(False)
        CType(Me.txtHadiah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotOmzet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKdCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProgram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdHadiah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSelama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaProgram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOmzet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJnsOmzet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vValas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlLabel As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlField As System.Windows.Forms.Panel
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Jenis As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdHadiah As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSelama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tglSampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglMulai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tgl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProgram As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNamaProgram As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKdCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStatus As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtOmzet As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtTotOmzet As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtJnsOmzet As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtHadiah As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtNilai As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents vValas As DevExpress.XtraEditors.LookUpEdit
End Class
