<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuppliers))
        Me.pnl = New System.Windows.Forms.Panel
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabForm = New DevExpress.XtraTab.XtraTabPage
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.noseq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.cbGrade = New System.Windows.Forms.ComboBox
        Me.cbStatus = New System.Windows.Forms.ComboBox
        Me.cb_stsGroup = New System.Windows.Forms.ComboBox
        Me.txbKet = New System.Windows.Forms.TextBox
        Me.txbRekVls = New System.Windows.Forms.TextBox
        Me.txbRekRP = New System.Windows.Forms.TextBox
        Me.txbCP = New System.Windows.Forms.TextBox
        Me.txbEmail = New System.Windows.Forms.TextBox
        Me.txbNPWP = New System.Windows.Forms.TextBox
        Me.txbFax = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txbNama = New System.Windows.Forms.TextBox
        Me.txbKdSup = New System.Windows.Forms.TextBox
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txbTelp1 = New System.Windows.Forms.TextBox
        Me.LEKota1 = New DevExpress.XtraEditors.LookUpEdit
        Me.txbAlamat1 = New System.Windows.Forms.TextBox
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.txbTelp2 = New System.Windows.Forms.TextBox
        Me.LEKota2 = New DevExpress.XtraEditors.LookUpEdit
        Me.txbAlamat2 = New System.Windows.Forms.TextBox
        Me.tabList = New DevExpress.XtraTab.XtraTabPage
        Me.gcSupplier = New DevExpress.XtraGrid.GridControl
        Me.gvSupplier = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Alamat1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kota1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueKota1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.No_Telepon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Alamat2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kota2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueKota2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.No_Telepon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_Fax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_NPWP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Email = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Jenis_Usaha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kontak_Person = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Grade = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Norek_Bank_Rupiah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Norek_Bank_Valas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnl.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabForm.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.LEKota1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.LEKota2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabList.SuspendLayout()
        CType(Me.gcSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKota1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKota2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.XtraTabControl1)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(830, 637)
        Me.pnl.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 34)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabForm
        Me.XtraTabControl1.Size = New System.Drawing.Size(828, 601)
        Me.XtraTabControl1.TabIndex = 141
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabForm, Me.tabList})
        '
        'tabForm
        '
        Me.tabForm.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.tabForm.Appearance.PageClient.Options.UseBackColor = True
        Me.tabForm.Controls.Add(Me.gc)
        Me.tabForm.Controls.Add(Me.Panel15)
        Me.tabForm.Name = "tabForm"
        Me.tabForm.Size = New System.Drawing.Size(821, 572)
        Me.tabForm.Text = "Form "
        '
        'gc
        '
        Me.gc.Location = New System.Drawing.Point(1, 391)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1})
        Me.gc.Size = New System.Drawing.Size(805, 178)
        Me.gc.TabIndex = 87
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.noseq, Me.nama, Me.Status})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.NewItemRowText = "Tambah Data disini !"
        Me.gv.OptionsCustomization.AllowColumnMoving = False
        Me.gv.OptionsCustomization.AllowFilter = False
        Me.gv.OptionsCustomization.AllowGroup = False
        Me.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gv.OptionsView.RowAutoHeight = True
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.noseq, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'noseq
        '
        Me.noseq.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.noseq.AppearanceCell.Options.UseFont = True
        Me.noseq.AppearanceCell.Options.UseTextOptions = True
        Me.noseq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.noseq.Caption = "No."
        Me.noseq.FieldName = "no_seq"
        Me.noseq.Name = "noseq"
        Me.noseq.OptionsColumn.AllowEdit = False
        Me.noseq.OptionsColumn.AllowFocus = False
        Me.noseq.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.noseq.OptionsColumn.ReadOnly = True
        Me.noseq.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.noseq.Visible = True
        Me.noseq.VisibleIndex = 0
        Me.noseq.Width = 42
        '
        'nama
        '
        Me.nama.Caption = "Nama Barang"
        Me.nama.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.nama.FieldName = "kd_barang"
        Me.nama.Name = "nama"
        Me.nama.Visible = True
        Me.nama.VisibleIndex = 1
        Me.nama.Width = 643
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 120, "Nama Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", 40, "Kode_Barang")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Nama_Barang"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "Kode_Barang"
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.Status.FieldName = "rec_stat"
        Me.Status.Name = "Status"
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 2
        Me.Status.Width = 99
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoWidth = True
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepositoryItemCheckEdit1.Caption = "T"
        Me.RepositoryItemCheckEdit1.DisplayValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.DisplayValueUnchecked = "T"
        Me.RepositoryItemCheckEdit1.FullFocusRect = True
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.NullText = "T"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "T"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.MistyRose
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Controls.Add(Me.Panel5)
        Me.Panel15.Controls.Add(Me.Panel12)
        Me.Panel15.Location = New System.Drawing.Point(6, 8)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(800, 377)
        Me.Panel15.TabIndex = 13
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel13)
        Me.Panel16.Controls.Add(Me.Panel14)
        Me.Panel16.Location = New System.Drawing.Point(0, 140)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(800, 229)
        Me.Panel16.TabIndex = 14
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.MistyRose
        Me.Panel13.Controls.Add(Me.Label14)
        Me.Panel13.Controls.Add(Me.Label24)
        Me.Panel13.Controls.Add(Me.Label7)
        Me.Panel13.Controls.Add(Me.Label25)
        Me.Panel13.Controls.Add(Me.Label19)
        Me.Panel13.Controls.Add(Me.Label16)
        Me.Panel13.Controls.Add(Me.Label13)
        Me.Panel13.Controls.Add(Me.Label18)
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Controls.Add(Me.Label17)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(110, 229)
        Me.Panel13.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.MistyRose
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(0, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 20)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "Status Supplier  : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.MistyRose
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(0, 180)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 20)
        Me.Label24.TabIndex = 139
        Me.Label24.Text = "Status Record : "
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.MistyRose
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Status Group : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.MistyRose
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(0, 120)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(110, 40)
        Me.Label25.TabIndex = 140
        Me.Label25.Text = "Keterangan : "
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.MistyRose
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(0, 100)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 20)
        Me.Label19.TabIndex = 138
        Me.Label19.Text = "Rek. Bank (Valas)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.MistyRose
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(0, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 20)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Rek. Bank (Rp)  : "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.MistyRose
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(0, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 20)
        Me.Label13.TabIndex = 132
        Me.Label13.Text = "Contact Person : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.MistyRose
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(0, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 20)
        Me.Label18.TabIndex = 130
        Me.Label18.Text = "Email : "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.MistyRose
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(0, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 20)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "NPWP  : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.MistyRose
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 20)
        Me.Label17.TabIndex = 128
        Me.Label17.Text = "Fax : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.cbGrade)
        Me.Panel14.Controls.Add(Me.cbStatus)
        Me.Panel14.Controls.Add(Me.cb_stsGroup)
        Me.Panel14.Controls.Add(Me.txbKet)
        Me.Panel14.Controls.Add(Me.txbRekVls)
        Me.Panel14.Controls.Add(Me.txbRekRP)
        Me.Panel14.Controls.Add(Me.txbCP)
        Me.Panel14.Controls.Add(Me.txbEmail)
        Me.Panel14.Controls.Add(Me.txbNPWP)
        Me.Panel14.Controls.Add(Me.txbFax)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(110, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(690, 229)
        Me.Panel14.TabIndex = 12
        '
        'cbGrade
        '
        Me.cbGrade.FormattingEnabled = True
        Me.cbGrade.Items.AddRange(New Object() {"NEW", "APPROVE", "UNAPPROVE"})
        Me.cbGrade.Location = New System.Drawing.Point(0, 202)
        Me.cbGrade.Name = "cbGrade"
        Me.cbGrade.Size = New System.Drawing.Size(117, 21)
        Me.cbGrade.TabIndex = 19
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cbStatus.Location = New System.Drawing.Point(0, 181)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(117, 21)
        Me.cbStatus.TabIndex = 16
        '
        'cb_stsGroup
        '
        Me.cb_stsGroup.FormattingEnabled = True
        Me.cb_stsGroup.Items.AddRange(New Object() {"YA", "TIDAK"})
        Me.cb_stsGroup.Location = New System.Drawing.Point(0, 160)
        Me.cb_stsGroup.Name = "cb_stsGroup"
        Me.cb_stsGroup.Size = New System.Drawing.Size(117, 21)
        Me.cb_stsGroup.TabIndex = 18
        '
        'txbKet
        '
        Me.txbKet.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbKet.Location = New System.Drawing.Point(0, 120)
        Me.txbKet.Multiline = True
        Me.txbKet.Name = "txbKet"
        Me.txbKet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbKet.Size = New System.Drawing.Size(690, 40)
        Me.txbKet.TabIndex = 17
        '
        'txbRekVls
        '
        Me.txbRekVls.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbRekVls.Location = New System.Drawing.Point(0, 100)
        Me.txbRekVls.Name = "txbRekVls"
        Me.txbRekVls.Size = New System.Drawing.Size(690, 20)
        Me.txbRekVls.TabIndex = 15
        '
        'txbRekRP
        '
        Me.txbRekRP.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbRekRP.Location = New System.Drawing.Point(0, 80)
        Me.txbRekRP.Name = "txbRekRP"
        Me.txbRekRP.Size = New System.Drawing.Size(690, 20)
        Me.txbRekRP.TabIndex = 14
        '
        'txbCP
        '
        Me.txbCP.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbCP.Location = New System.Drawing.Point(0, 60)
        Me.txbCP.Name = "txbCP"
        Me.txbCP.Size = New System.Drawing.Size(690, 20)
        Me.txbCP.TabIndex = 12
        '
        'txbEmail
        '
        Me.txbEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbEmail.Location = New System.Drawing.Point(0, 40)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(690, 20)
        Me.txbEmail.TabIndex = 10
        '
        'txbNPWP
        '
        Me.txbNPWP.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbNPWP.Location = New System.Drawing.Point(0, 20)
        Me.txbNPWP.Name = "txbNPWP"
        Me.txbNPWP.Size = New System.Drawing.Size(690, 20)
        Me.txbNPWP.TabIndex = 9
        '
        'txbFax
        '
        Me.txbFax.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbFax.Location = New System.Drawing.Point(0, 0)
        Me.txbFax.Name = "txbFax"
        Me.txbFax.Size = New System.Drawing.Size(690, 20)
        Me.txbFax.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(800, 40)
        Me.Panel5.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(110, 40)
        Me.Panel3.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.MistyRose
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(0, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 20)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "Nama Supplier  : "
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.MistyRose
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(110, 20)
        Me.Label21.TabIndex = 112
        Me.Label21.Text = "Kode Supplier : "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txbNama)
        Me.Panel4.Controls.Add(Me.txbKdSup)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(110, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(690, 40)
        Me.Panel4.TabIndex = 2
        '
        'txbNama
        '
        Me.txbNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbNama.Location = New System.Drawing.Point(0, 20)
        Me.txbNama.Name = "txbNama"
        Me.txbNama.Size = New System.Drawing.Size(690, 20)
        Me.txbNama.TabIndex = 104
        '
        'txbKdSup
        '
        Me.txbKdSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbKdSup.Location = New System.Drawing.Point(0, 0)
        Me.txbKdSup.Name = "txbKdSup"
        Me.txbKdSup.Size = New System.Drawing.Size(690, 20)
        Me.txbKdSup.TabIndex = 103
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel8)
        Me.Panel12.Controls.Add(Me.Panel11)
        Me.Panel12.Location = New System.Drawing.Point(0, 40)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(800, 100)
        Me.Panel12.TabIndex = 10
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel6)
        Me.Panel8.Controls.Add(Me.Panel7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(400, 100)
        Me.Panel8.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(110, 100)
        Me.Panel6.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.MistyRose
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(0, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 20)
        Me.Label23.TabIndex = 127
        Me.Label23.Text = "No Telp 1 : "
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MistyRose
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Kota 1 : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MistyRose
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 60)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Alamat 1 : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txbTelp1)
        Me.Panel7.Controls.Add(Me.LEKota1)
        Me.Panel7.Controls.Add(Me.txbAlamat1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(110, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(290, 100)
        Me.Panel7.TabIndex = 5
        '
        'txbTelp1
        '
        Me.txbTelp1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbTelp1.Location = New System.Drawing.Point(0, 80)
        Me.txbTelp1.Name = "txbTelp1"
        Me.txbTelp1.Size = New System.Drawing.Size(290, 20)
        Me.txbTelp1.TabIndex = 143
        '
        'LEKota1
        '
        Me.LEKota1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LEKota1.Location = New System.Drawing.Point(0, 60)
        Me.LEKota1.Name = "LEKota1"
        Me.LEKota1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEKota1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kota", "Nama Kota")})
        Me.LEKota1.Properties.DisplayMember = "Nama_Kota"
        Me.LEKota1.Properties.NullText = ""
        Me.LEKota1.Properties.ValueMember = "Kode_Kota"
        Me.LEKota1.Size = New System.Drawing.Size(290, 20)
        Me.LEKota1.TabIndex = 142
        '
        'txbAlamat1
        '
        Me.txbAlamat1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbAlamat1.Location = New System.Drawing.Point(0, 0)
        Me.txbAlamat1.MaxLength = 100
        Me.txbAlamat1.Multiline = True
        Me.txbAlamat1.Name = "txbAlamat1"
        Me.txbAlamat1.Size = New System.Drawing.Size(290, 60)
        Me.txbAlamat1.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel9)
        Me.Panel11.Controls.Add(Me.Panel10)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(400, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(400, 100)
        Me.Panel11.TabIndex = 9
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(110, 100)
        Me.Panel9.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(0, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "No Telp 2 : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Kota 2 : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 60)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Alamat 2 : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.txbTelp2)
        Me.Panel10.Controls.Add(Me.LEKota2)
        Me.Panel10.Controls.Add(Me.txbAlamat2)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(110, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(290, 100)
        Me.Panel10.TabIndex = 8
        '
        'txbTelp2
        '
        Me.txbTelp2.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbTelp2.Location = New System.Drawing.Point(0, 80)
        Me.txbTelp2.Name = "txbTelp2"
        Me.txbTelp2.Size = New System.Drawing.Size(290, 20)
        Me.txbTelp2.TabIndex = 143
        '
        'LEKota2
        '
        Me.LEKota2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LEKota2.Location = New System.Drawing.Point(0, 60)
        Me.LEKota2.Name = "LEKota2"
        Me.LEKota2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEKota2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kota", "Nama Kota")})
        Me.LEKota2.Properties.DisplayMember = "Nama_Kota"
        Me.LEKota2.Properties.NullText = ""
        Me.LEKota2.Properties.ValueMember = "Kode_Kota"
        Me.LEKota2.Size = New System.Drawing.Size(290, 20)
        Me.LEKota2.TabIndex = 142
        '
        'txbAlamat2
        '
        Me.txbAlamat2.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbAlamat2.Location = New System.Drawing.Point(0, 0)
        Me.txbAlamat2.MaxLength = 100
        Me.txbAlamat2.Multiline = True
        Me.txbAlamat2.Name = "txbAlamat2"
        Me.txbAlamat2.Size = New System.Drawing.Size(290, 60)
        Me.txbAlamat2.TabIndex = 5
        '
        'tabList
        '
        Me.tabList.Controls.Add(Me.gcSupplier)
        Me.tabList.Name = "tabList"
        Me.tabList.Size = New System.Drawing.Size(821, 572)
        Me.tabList.Text = "List Supplier"
        '
        'gcSupplier
        '
        Me.gcSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSupplier.Location = New System.Drawing.Point(0, 0)
        Me.gcSupplier.MainView = Me.gvSupplier
        Me.gcSupplier.Name = "gcSupplier"
        Me.gcSupplier.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueKota1, Me.lueKota2})
        Me.gcSupplier.Size = New System.Drawing.Size(821, 572)
        Me.gcSupplier.TabIndex = 1
        Me.gcSupplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSupplier})
        '
        'gvSupplier
        '
        Me.gvSupplier.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kode_Supplier, Me.Nama_Supplier, Me.Alamat1, Me.Kota1, Me.No_Telepon1, Me.Alamat2, Me.Kota2, Me.No_Telepon2, Me.No_Fax, Me.No_NPWP, Me.Email, Me.Jenis_Usaha, Me.Kontak_Person, Me.Grade, Me.Keterangan, Me.Norek_Bank_Rupiah, Me.Norek_Bank_Valas})
        Me.gvSupplier.GridControl = Me.gcSupplier
        Me.gvSupplier.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvSupplier.Name = "gvSupplier"
        Me.gvSupplier.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvSupplier.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvSupplier.OptionsBehavior.Editable = False
        Me.gvSupplier.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvSupplier.OptionsView.ColumnAutoWidth = False
        Me.gvSupplier.OptionsView.EnableAppearanceEvenRow = True
        Me.gvSupplier.OptionsView.EnableAppearanceOddRow = True
        Me.gvSupplier.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'Kode_Supplier
        '
        Me.Kode_Supplier.Caption = "Kode"
        Me.Kode_Supplier.FieldName = "Kode_Supplier"
        Me.Kode_Supplier.Name = "Kode_Supplier"
        Me.Kode_Supplier.Visible = True
        Me.Kode_Supplier.VisibleIndex = 0
        Me.Kode_Supplier.Width = 44
        '
        'Nama_Supplier
        '
        Me.Nama_Supplier.Caption = "Nama"
        Me.Nama_Supplier.FieldName = "Nama_Supplier"
        Me.Nama_Supplier.Name = "Nama_Supplier"
        Me.Nama_Supplier.Visible = True
        Me.Nama_Supplier.VisibleIndex = 1
        Me.Nama_Supplier.Width = 116
        '
        'Alamat1
        '
        Me.Alamat1.Caption = "Alamat 1"
        Me.Alamat1.FieldName = "Alamat1"
        Me.Alamat1.Name = "Alamat1"
        Me.Alamat1.Visible = True
        Me.Alamat1.VisibleIndex = 2
        Me.Alamat1.Width = 55
        '
        'Kota1
        '
        Me.Kota1.Caption = "Kota 1"
        Me.Kota1.ColumnEdit = Me.lueKota1
        Me.Kota1.FieldName = "Kota1"
        Me.Kota1.Name = "Kota1"
        Me.Kota1.OptionsColumn.AllowEdit = False
        Me.Kota1.Visible = True
        Me.Kota1.VisibleIndex = 3
        Me.Kota1.Width = 108
        '
        'lueKota1
        '
        Me.lueKota1.AutoHeight = False
        Me.lueKota1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKota1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kota", "Nama KOta")})
        Me.lueKota1.Name = "lueKota1"
        '
        'No_Telepon1
        '
        Me.No_Telepon1.Caption = "No. Telepon 1"
        Me.No_Telepon1.FieldName = "No_Telepon1"
        Me.No_Telepon1.Name = "No_Telepon1"
        Me.No_Telepon1.Visible = True
        Me.No_Telepon1.VisibleIndex = 4
        Me.No_Telepon1.Width = 51
        '
        'Alamat2
        '
        Me.Alamat2.Caption = "Alamat 2"
        Me.Alamat2.FieldName = "Alamat2"
        Me.Alamat2.Name = "Alamat2"
        Me.Alamat2.Visible = True
        Me.Alamat2.VisibleIndex = 5
        '
        'Kota2
        '
        Me.Kota2.Caption = "Kota 2"
        Me.Kota2.ColumnEdit = Me.lueKota2
        Me.Kota2.FieldName = "Kota2"
        Me.Kota2.Name = "Kota2"
        Me.Kota2.Visible = True
        Me.Kota2.VisibleIndex = 6
        '
        'lueKota2
        '
        Me.lueKota2.AutoHeight = False
        Me.lueKota2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKota2.Name = "lueKota2"
        '
        'No_Telepon2
        '
        Me.No_Telepon2.Caption = "No. Telepon 2"
        Me.No_Telepon2.FieldName = "No_Telepon2"
        Me.No_Telepon2.Name = "No_Telepon2"
        Me.No_Telepon2.Visible = True
        Me.No_Telepon2.VisibleIndex = 7
        Me.No_Telepon2.Width = 50
        '
        'No_Fax
        '
        Me.No_Fax.Caption = "No. Fax"
        Me.No_Fax.FieldName = "No_Fax"
        Me.No_Fax.Name = "No_Fax"
        Me.No_Fax.Visible = True
        Me.No_Fax.VisibleIndex = 8
        Me.No_Fax.Width = 57
        '
        'No_NPWP
        '
        Me.No_NPWP.Caption = "No. NPWP"
        Me.No_NPWP.FieldName = "No_NPWP"
        Me.No_NPWP.Name = "No_NPWP"
        Me.No_NPWP.Visible = True
        Me.No_NPWP.VisibleIndex = 9
        '
        'Email
        '
        Me.Email.Caption = "Email"
        Me.Email.FieldName = "Email"
        Me.Email.Name = "Email"
        Me.Email.Visible = True
        Me.Email.VisibleIndex = 10
        '
        'Jenis_Usaha
        '
        Me.Jenis_Usaha.Caption = "Jenis Usaha"
        Me.Jenis_Usaha.FieldName = "Jenis_Usaha"
        Me.Jenis_Usaha.Name = "Jenis_Usaha"
        Me.Jenis_Usaha.Visible = True
        Me.Jenis_Usaha.VisibleIndex = 11
        '
        'Kontak_Person
        '
        Me.Kontak_Person.Caption = "Contact Person"
        Me.Kontak_Person.FieldName = "Kontak_Person"
        Me.Kontak_Person.Name = "Kontak_Person"
        Me.Kontak_Person.Visible = True
        Me.Kontak_Person.VisibleIndex = 12
        '
        'Grade
        '
        Me.Grade.Caption = "Grade"
        Me.Grade.FieldName = "Grade"
        Me.Grade.Name = "Grade"
        Me.Grade.Visible = True
        Me.Grade.VisibleIndex = 13
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 14
        '
        'Norek_Bank_Rupiah
        '
        Me.Norek_Bank_Rupiah.Caption = "No. Rek. Bank (Rupiah)"
        Me.Norek_Bank_Rupiah.FieldName = "Norek_Bank_Rupiah"
        Me.Norek_Bank_Rupiah.Name = "Norek_Bank_Rupiah"
        Me.Norek_Bank_Rupiah.Visible = True
        Me.Norek_Bank_Rupiah.VisibleIndex = 15
        '
        'Norek_Bank_Valas
        '
        Me.Norek_Bank_Valas.Caption = "No. Rek. Bank (Valas)"
        Me.Norek_Bank_Valas.FieldName = "Norek_Bank_Valas"
        Me.Norek_Bank_Valas.Name = "Norek_Bank_Valas"
        Me.Norek_Bank_Valas.Visible = True
        Me.Norek_Bank_Valas.VisibleIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 34)
        Me.Panel1.TabIndex = 140
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(666, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         MASTER SUPPLIER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(851, 662)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmSuppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MASTER SUPPLIER"
        Me.pnl.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabForm.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.LEKota1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.LEKota2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabList.ResumeLayout(False)
        CType(Me.gcSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKota1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKota2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LEKota2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txbKdSup As System.Windows.Forms.TextBox
    Friend WithEvents txbNama As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txbAlamat1 As System.Windows.Forms.TextBox
    Friend WithEvents LEKota1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txbTelp1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents txbAlamat2 As System.Windows.Forms.TextBox
    Friend WithEvents txbTelp2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents txbEmail As System.Windows.Forms.TextBox
    Friend WithEvents txbNPWP As System.Windows.Forms.TextBox
    Friend WithEvents txbFax As System.Windows.Forms.TextBox
    Friend WithEvents txbRekRP As System.Windows.Forms.TextBox
    Friend WithEvents txbCP As System.Windows.Forms.TextBox
    Friend WithEvents txbKet As System.Windows.Forms.TextBox
    Friend WithEvents txbRekVls As System.Windows.Forms.TextBox
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabForm As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcSupplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alamat1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kota1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueKota1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents No_Telepon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alamat2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kota2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueKota2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents No_Telepon2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_NPWP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jenis_Usaha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kontak_Person As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Norek_Bank_Rupiah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Norek_Bank_Valas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents noseq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbGrade As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cb_stsGroup As System.Windows.Forms.ComboBox
End Class
