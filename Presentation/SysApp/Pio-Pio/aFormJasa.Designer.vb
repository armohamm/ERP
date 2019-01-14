<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormJasa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormJasa))
        Me.pnl = New System.Windows.Forms.Panel
        Me.tacBarangJadi = New DevExpress.XtraTab.XtraTabControl
        Me.tabForm = New DevExpress.XtraTab.XtraTabPage
        Me.Panel26 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.pnlKet = New System.Windows.Forms.Panel
        Me.txtKet = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.Panel27 = New System.Windows.Forms.Panel
        Me.pnlStatus = New System.Windows.Forms.Panel
        Me.lckStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.pnlRekJual1 = New System.Windows.Forms.Panel
        Me.lckRekJual1 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.pnlNama = New System.Windows.Forms.Panel
        Me.txtNamaBarang = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.pnlKode = New System.Windows.Forms.Panel
        Me.txtKodeBarang = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.tabList = New DevExpress.XtraTab.XtraTabPage
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.gcBarangJadi = New DevExpress.XtraGrid.GridControl
        Me.gvBarangJadi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_penjualan1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookuppenj1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.errData = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.pnl.SuspendLayout()
        CType(Me.tacBarangJadi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tacBarangJadi.SuspendLayout()
        Me.tabForm.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.pnlKet.SuspendLayout()
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatus.SuspendLayout()
        CType(Me.lckStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel21.SuspendLayout()
        Me.pnlRekJual1.SuspendLayout()
        CType(Me.lckRekJual1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.pnlNama.SuspendLayout()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKode.SuspendLayout()
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabList.SuspendLayout()
        Me.Panel25.SuspendLayout()
        CType(Me.gcBarangJadi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBarangJadi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookuppenj1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.tacBarangJadi)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(16, 24)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(584, 296)
        Me.pnl.TabIndex = 0
        '
        'tacBarangJadi
        '
        Me.tacBarangJadi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tacBarangJadi.Location = New System.Drawing.Point(0, 35)
        Me.tacBarangJadi.Name = "tacBarangJadi"
        Me.tacBarangJadi.SelectedTabPage = Me.tabForm
        Me.tacBarangJadi.Size = New System.Drawing.Size(584, 236)
        Me.tacBarangJadi.TabIndex = 24
        Me.tacBarangJadi.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabForm, Me.tabList})
        '
        'tabForm
        '
        Me.tabForm.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tabForm.Appearance.PageClient.Options.UseBackColor = True
        Me.tabForm.Controls.Add(Me.Panel26)
        Me.tabForm.Name = "tabForm"
        Me.tabForm.Size = New System.Drawing.Size(577, 207)
        Me.tabForm.Text = "Form Jasa"
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel26.Controls.Add(Me.Panel11)
        Me.Panel26.Controls.Add(Me.Panel14)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(577, 207)
        Me.Panel26.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.Panel22)
        Me.Panel11.Controls.Add(Me.Panel21)
        Me.Panel11.Controls.Add(Me.Panel16)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(64, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(450, 207)
        Me.Panel11.TabIndex = 21
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.pnlKet)
        Me.Panel22.Controls.Add(Me.Panel27)
        Me.Panel22.Controls.Add(Me.pnlStatus)
        Me.Panel22.Controls.Add(Me.Panel24)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 75)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(450, 100)
        Me.Panel22.TabIndex = 27
        '
        'pnlKet
        '
        Me.pnlKet.Controls.Add(Me.txtKet)
        Me.pnlKet.Controls.Add(Me.LabelControl37)
        Me.pnlKet.Controls.Add(Me.LabelControl38)
        Me.pnlKet.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKet.Location = New System.Drawing.Point(0, 30)
        Me.pnlKet.Name = "pnlKet"
        Me.pnlKet.Size = New System.Drawing.Size(450, 60)
        Me.pnlKet.TabIndex = 29
        '
        'txtKet
        '
        Me.txtKet.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKet.EnterMoveNextControl = True
        Me.txtKet.Location = New System.Drawing.Point(135, 0)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Properties.ValidateOnEnterKey = True
        Me.txtKet.Size = New System.Drawing.Size(300, 60)
        Me.txtKet.TabIndex = 6
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl37.Appearance.Options.UseFont = True
        Me.LabelControl37.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl37.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl37.Location = New System.Drawing.Point(125, 0)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Padding = New System.Windows.Forms.Padding(0, 0, 0, 40)
        Me.LabelControl37.Size = New System.Drawing.Size(10, 60)
        Me.LabelControl37.TabIndex = 5
        Me.LabelControl37.Text = ":"
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl38.Appearance.Options.UseFont = True
        Me.LabelControl38.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl38.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl38.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Padding = New System.Windows.Forms.Padding(5, 0, 0, 40)
        Me.LabelControl38.Size = New System.Drawing.Size(125, 60)
        Me.LabelControl38.TabIndex = 4
        Me.LabelControl38.Text = "Keterangan"
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(0, 25)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(450, 5)
        Me.Panel27.TabIndex = 28
        '
        'pnlStatus
        '
        Me.pnlStatus.Controls.Add(Me.lckStatus)
        Me.pnlStatus.Controls.Add(Me.LabelControl35)
        Me.pnlStatus.Controls.Add(Me.LabelControl36)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStatus.Location = New System.Drawing.Point(0, 5)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(450, 20)
        Me.pnlStatus.TabIndex = 27
        '
        'lckStatus
        '
        Me.lckStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.lckStatus.EnterMoveNextControl = True
        Me.lckStatus.Location = New System.Drawing.Point(135, 0)
        Me.lckStatus.Name = "lckStatus"
        Me.lckStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lckStatus.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("stat", "Name11")})
        Me.lckStatus.Properties.NullText = "[Data Kosong]"
        Me.lckStatus.Properties.ShowFooter = False
        Me.lckStatus.Properties.ShowHeader = False
        Me.lckStatus.Properties.ShowPopupShadow = False
        Me.lckStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckStatus.Properties.ValidateOnEnterKey = True
        Me.lckStatus.Size = New System.Drawing.Size(100, 20)
        Me.lckStatus.TabIndex = 8
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl35.Appearance.Options.UseFont = True
        Me.LabelControl35.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl35.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl35.Location = New System.Drawing.Point(125, 0)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl35.TabIndex = 5
        Me.LabelControl35.Text = ":"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl36.Appearance.Options.UseFont = True
        Me.LabelControl36.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl36.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl36.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl36.Size = New System.Drawing.Size(125, 20)
        Me.LabelControl36.TabIndex = 4
        Me.LabelControl36.Text = "Status"
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(450, 5)
        Me.Panel24.TabIndex = 26
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.pnlRekJual1)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(0, 55)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(450, 20)
        Me.Panel21.TabIndex = 24
        '
        'pnlRekJual1
        '
        Me.pnlRekJual1.Controls.Add(Me.lckRekJual1)
        Me.pnlRekJual1.Controls.Add(Me.LabelControl31)
        Me.pnlRekJual1.Controls.Add(Me.LabelControl32)
        Me.pnlRekJual1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRekJual1.Location = New System.Drawing.Point(0, 0)
        Me.pnlRekJual1.Name = "pnlRekJual1"
        Me.pnlRekJual1.Size = New System.Drawing.Size(450, 20)
        Me.pnlRekJual1.TabIndex = 24
        '
        'lckRekJual1
        '
        Me.lckRekJual1.Dock = System.Windows.Forms.DockStyle.Left
        Me.lckRekJual1.EnterMoveNextControl = True
        Me.lckRekJual1.Location = New System.Drawing.Point(135, 0)
        Me.lckRekJual1.Name = "lckRekJual1"
        Me.lckRekJual1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lckRekJual1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckRekJual1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckRekJual1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nm_Buku_Besar", "Name13")})
        Me.lckRekJual1.Properties.NullText = "[Data Kosong]"
        Me.lckRekJual1.Properties.ShowFooter = False
        Me.lckRekJual1.Properties.ShowHeader = False
        Me.lckRekJual1.Properties.ShowPopupShadow = False
        Me.lckRekJual1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckRekJual1.Properties.ValidateOnEnterKey = True
        Me.lckRekJual1.Size = New System.Drawing.Size(185, 20)
        Me.lckRekJual1.TabIndex = 6
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl31.Appearance.Options.UseFont = True
        Me.LabelControl31.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl31.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl31.Location = New System.Drawing.Point(125, 0)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl31.TabIndex = 5
        Me.LabelControl31.Text = ":"
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl32.Appearance.Options.UseFont = True
        Me.LabelControl32.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl32.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl32.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl32.Size = New System.Drawing.Size(125, 20)
        Me.LabelControl32.TabIndex = 4
        Me.LabelControl32.Text = "Rekening Biaya"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.pnlNama)
        Me.Panel16.Controls.Add(Me.Panel18)
        Me.Panel16.Controls.Add(Me.pnlKode)
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(450, 55)
        Me.Panel16.TabIndex = 21
        '
        'pnlNama
        '
        Me.pnlNama.Controls.Add(Me.txtNamaBarang)
        Me.pnlNama.Controls.Add(Me.LabelControl3)
        Me.pnlNama.Controls.Add(Me.LabelControl4)
        Me.pnlNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNama.Location = New System.Drawing.Point(0, 30)
        Me.pnlNama.Name = "pnlNama"
        Me.pnlNama.Size = New System.Drawing.Size(450, 20)
        Me.pnlNama.TabIndex = 24
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNamaBarang.EnterMoveNextControl = True
        Me.txtNamaBarang.Location = New System.Drawing.Point(135, 0)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNamaBarang.Properties.ValidateOnEnterKey = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(250, 20)
        Me.txtNamaBarang.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(125, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl4.Size = New System.Drawing.Size(125, 20)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Nama Jasa"
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 25)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(450, 5)
        Me.Panel18.TabIndex = 23
        '
        'pnlKode
        '
        Me.pnlKode.Controls.Add(Me.txtKodeBarang)
        Me.pnlKode.Controls.Add(Me.LabelControl2)
        Me.pnlKode.Controls.Add(Me.LabelControl1)
        Me.pnlKode.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKode.Location = New System.Drawing.Point(0, 5)
        Me.pnlKode.Name = "pnlKode"
        Me.pnlKode.Size = New System.Drawing.Size(450, 20)
        Me.pnlKode.TabIndex = 22
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKodeBarang.Enabled = False
        Me.txtKodeBarang.Location = New System.Drawing.Point(135, 0)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Properties.ReadOnly = True
        Me.txtKodeBarang.Properties.ValidateOnEnterKey = True
        Me.txtKodeBarang.Size = New System.Drawing.Size(150, 20)
        Me.txtKodeBarang.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(125, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl1.Size = New System.Drawing.Size(125, 20)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Kode Jasa"
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(450, 5)
        Me.Panel17.TabIndex = 21
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Transparent
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(64, 207)
        Me.Panel14.TabIndex = 1
        '
        'tabList
        '
        Me.tabList.Controls.Add(Me.Panel25)
        Me.tabList.Name = "tabList"
        Me.tabList.Size = New System.Drawing.Size(577, 207)
        Me.tabList.Text = "List Jasa"
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.gcBarangJadi)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(577, 207)
        Me.Panel25.TabIndex = 3
        '
        'gcBarangJadi
        '
        Me.gcBarangJadi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBarangJadi.Location = New System.Drawing.Point(0, 0)
        Me.gcBarangJadi.MainView = Me.gvBarangJadi
        Me.gcBarangJadi.Name = "gcBarangJadi"
        Me.gcBarangJadi.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookuppenj1})
        Me.gcBarangJadi.Size = New System.Drawing.Size(577, 207)
        Me.gcBarangJadi.TabIndex = 59
        Me.gcBarangJadi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBarangJadi})
        '
        'gvBarangJadi
        '
        Me.gvBarangJadi.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.gvBarangJadi.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.gvBarangJadi.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvBarangJadi.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.gvBarangJadi.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.gvBarangJadi.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.gvBarangJadi.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.gvBarangJadi.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvBarangJadi.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.gvBarangJadi.Appearance.Empty.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.gvBarangJadi.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gvBarangJadi.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvBarangJadi.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.gvBarangJadi.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvBarangJadi.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gvBarangJadi.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvBarangJadi.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvBarangJadi.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvBarangJadi.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gvBarangJadi.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvBarangJadi.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.gvBarangJadi.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.gvBarangJadi.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvBarangJadi.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvBarangJadi.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gvBarangJadi.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gvBarangJadi.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvBarangJadi.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvBarangJadi.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvBarangJadi.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.GroupPanel.Options.UseFont = True
        Me.gvBarangJadi.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.gvBarangJadi.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvBarangJadi.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvBarangJadi.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvBarangJadi.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvBarangJadi.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.gvBarangJadi.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gvBarangJadi.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvBarangJadi.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.gvBarangJadi.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.gvBarangJadi.Appearance.OddRow.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.OddRow.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.gvBarangJadi.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.gvBarangJadi.Appearance.Preview.ForeColor = System.Drawing.Color.Maroon
        Me.gvBarangJadi.Appearance.Preview.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.Preview.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvBarangJadi.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.Row.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.Row.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvBarangJadi.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.gvBarangJadi.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.gvBarangJadi.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gvBarangJadi.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvBarangJadi.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvBarangJadi.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.gvBarangJadi.Appearance.VertLine.Options.UseBackColor = True
        Me.gvBarangJadi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kode_barang, Me.Nama_Barang, Me.keterangan, Me.rek_penjualan1})
        Me.gvBarangJadi.GridControl = Me.gcBarangJadi
        Me.gvBarangJadi.GroupPanelText = "Pindah nama kolom ke panel ini mengklasifikasikan data."
        Me.gvBarangJadi.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvBarangJadi.Name = "gvBarangJadi"
        Me.gvBarangJadi.OptionsBehavior.Editable = False
        Me.gvBarangJadi.OptionsBehavior.ReadOnly = True
        Me.gvBarangJadi.OptionsView.EnableAppearanceEvenRow = True
        Me.gvBarangJadi.OptionsView.EnableAppearanceOddRow = True
        Me.gvBarangJadi.OptionsView.ShowGroupedColumns = True
        '
        'Kode_barang
        '
        Me.Kode_barang.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Kode_barang.AppearanceHeader.Options.UseFont = True
        Me.Kode_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.Kode_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kode_barang.Caption = "Kode Barang"
        Me.Kode_barang.FieldName = "Kode_Barang"
        Me.Kode_barang.Name = "Kode_barang"
        Me.Kode_barang.Visible = True
        Me.Kode_barang.VisibleIndex = 0
        Me.Kode_barang.Width = 84
        '
        'Nama_Barang
        '
        Me.Nama_Barang.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Nama_Barang.AppearanceHeader.Options.UseFont = True
        Me.Nama_Barang.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Barang.Caption = "Nama Barang"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 1
        Me.Nama_Barang.Width = 52
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 3
        Me.keterangan.Width = 92
        '
        'rek_penjualan1
        '
        Me.rek_penjualan1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rek_penjualan1.AppearanceHeader.Options.UseFont = True
        Me.rek_penjualan1.AppearanceHeader.Options.UseTextOptions = True
        Me.rek_penjualan1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rek_penjualan1.Caption = "Rek. Biaya"
        Me.rek_penjualan1.ColumnEdit = Me.lookuppenj1
        Me.rek_penjualan1.FieldName = "rek_biaya"
        Me.rek_penjualan1.Name = "rek_penjualan1"
        Me.rek_penjualan1.OptionsColumn.AllowEdit = False
        Me.rek_penjualan1.OptionsColumn.ReadOnly = True
        Me.rek_penjualan1.Visible = True
        Me.rek_penjualan1.VisibleIndex = 2
        Me.rek_penjualan1.Width = 72
        '
        'lookuppenj1
        '
        Me.lookuppenj1.AutoHeight = False
        Me.lookuppenj1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookuppenj1.Name = "lookuppenj1"
        Me.lookuppenj1.NullText = "[Kosong]"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 271)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 25)
        Me.Panel2.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 35)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(38, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MASTER JASA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'errData
        '
        Me.errData.ContainerControl = Me
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(248, 544)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Save"
        Me.SimpleButton1.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(416, 544)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Cancel"
        Me.SimpleButton2.Visible = False
        '
        'aFormJasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 742)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormJasa"
        Me.Text = "aFormBarangJadi"
        Me.pnl.ResumeLayout(False)
        CType(Me.tacBarangJadi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tacBarangJadi.ResumeLayout(False)
        Me.tabForm.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.pnlKet.ResumeLayout(False)
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatus.ResumeLayout(False)
        CType(Me.lckStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel21.ResumeLayout(False)
        Me.pnlRekJual1.ResumeLayout(False)
        CType(Me.lckRekJual1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.pnlNama.ResumeLayout(False)
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKode.ResumeLayout(False)
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabList.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        CType(Me.gcBarangJadi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBarangJadi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookuppenj1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tacBarangJadi As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabForm As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents pnlNama As System.Windows.Forms.Panel
    Friend WithEvents txtNamaBarang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents pnlKode As System.Windows.Forms.Panel
    Friend WithEvents txtKodeBarang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents gcBarangJadi As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBarangJadi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_penjualan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookuppenj1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents errData As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents pnlKet As System.Windows.Forms.Panel
    Friend WithEvents txtKet As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lckStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents pnlRekJual1 As System.Windows.Forms.Panel
    Friend WithEvents lckRekJual1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
End Class
