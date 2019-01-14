<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormHPP
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormHPP))
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.pnlDetil = New DevExpress.XtraEditors.PanelControl
        Me.gcHPP = New DevExpress.XtraGrid.GridControl
        Me.gvHPP = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookSatuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtNominal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlMaster = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.pnlKet = New DevExpress.XtraEditors.PanelControl
        Me.txtKet = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.pnlNoRef = New DevExpress.XtraEditors.PanelControl
        Me.txtNoRef = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.pnlTgl = New DevExpress.XtraEditors.PanelControl
        Me.dteTanggal = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.pnlNotrans = New DevExpress.XtraEditors.PanelControl
        Me.txtNoTrans = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.pnlDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetil.SuspendLayout()
        CType(Me.gcHPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvHPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNominal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMaster.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.pnlKet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKet.SuspendLayout()
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.pnlNoRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNoRef.SuspendLayout()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlTgl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTgl.SuspendLayout()
        CType(Me.dteTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlNotrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNotrans.SuspendLayout()
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlDetil)
        Me.pnl.Controls.Add(Me.pnlMaster)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Location = New System.Drawing.Point(59, 21)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(882, 411)
        Me.pnl.TabIndex = 0
        '
        'pnlDetil
        '
        Me.pnlDetil.Controls.Add(Me.gcHPP)
        Me.pnlDetil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetil.Location = New System.Drawing.Point(2, 161)
        Me.pnlDetil.Name = "pnlDetil"
        Me.pnlDetil.Size = New System.Drawing.Size(878, 228)
        Me.pnlDetil.TabIndex = 146
        '
        'gcHPP
        '
        Me.gcHPP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcHPP.Location = New System.Drawing.Point(2, 2)
        Me.gcHPP.MainView = Me.gvHPP
        Me.gcHPP.Name = "gcHPP"
        Me.gcHPP.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookBrg, Me.txtNominal, Me.lookSatuan})
        Me.gcHPP.Size = New System.Drawing.Size(874, 224)
        Me.gcHPP.TabIndex = 0
        Me.gcHPP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvHPP})
        '
        'gvHPP
        '
        Me.gvHPP.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvHPP.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvHPP.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvHPP.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvHPP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.satuan, Me.jml_val_trans, Me.keterangan})
        Me.gvHPP.GridControl = Me.gcHPP
        Me.gvHPP.Name = "gvHPP"
        Me.gvHPP.NewItemRowText = "Tambah data disini"
        Me.gvHPP.OptionsCustomization.AllowColumnMoving = False
        Me.gvHPP.OptionsNavigation.AutoFocusNewRow = True
        Me.gvHPP.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvHPP.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvHPP.OptionsView.ShowDetailButtons = False
        Me.gvHPP.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvHPP.OptionsView.ShowFooter = True
        Me.gvHPP.OptionsView.ShowGroupPanel = False
        Me.gvHPP.OptionsView.ShowIndicator = False
        '
        'no_seq
        '
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 40
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Nama Barang"
        Me.kd_stok.ColumnEdit = Me.lookBrg
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 328
        '
        'lookBrg
        '
        Me.lookBrg.AutoHeight = False
        Me.lookBrg.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Name1")})
        Me.lookBrg.Name = "lookBrg"
        Me.lookBrg.NullText = "[Belum Pilih]"
        Me.lookBrg.ShowFooter = False
        Me.lookBrg.ShowHeader = False
        Me.lookBrg.ShowPopupShadow = False
        Me.lookBrg.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookBrg.ValidateOnEnterKey = True
        '
        'satuan
        '
        Me.satuan.Caption = "Satuan"
        Me.satuan.ColumnEdit = Me.lookSatuan
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 2
        Me.satuan.Width = 94
        '
        'lookSatuan
        '
        Me.lookSatuan.AutoHeight = False
        Me.lookSatuan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookSatuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookSatuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama Satuan", "Name2")})
        Me.lookSatuan.Name = "lookSatuan"
        Me.lookSatuan.NullText = "[Belum Pilih]"
        Me.lookSatuan.ShowFooter = False
        Me.lookSatuan.ShowHeader = False
        Me.lookSatuan.ShowPopupShadow = False
        Me.lookSatuan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookSatuan.ValidateOnEnterKey = True
        '
        'jml_val_trans
        '
        Me.jml_val_trans.Caption = "Jumlah Rp."
        Me.jml_val_trans.ColumnEdit = Me.txtNominal
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_val_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_val_trans.Visible = True
        Me.jml_val_trans.VisibleIndex = 3
        Me.jml_val_trans.Width = 172
        '
        'txtNominal
        '
        Me.txtNominal.AutoHeight = False
        Me.txtNominal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtNominal.Mask.EditMask = "n2"
        Me.txtNominal.Mask.UseMaskAsDisplayFormat = True
        Me.txtNominal.Name = "txtNominal"
        Me.txtNominal.ValidateOnEnterKey = True
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 4
        Me.keterangan.Width = 104
        '
        'pnlMaster
        '
        Me.pnlMaster.Controls.Add(Me.PanelControl3)
        Me.pnlMaster.Controls.Add(Me.PanelControl1)
        Me.pnlMaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMaster.Location = New System.Drawing.Point(2, 36)
        Me.pnlMaster.Name = "pnlMaster"
        Me.pnlMaster.Size = New System.Drawing.Size(878, 125)
        Me.pnlMaster.TabIndex = 145
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.pnlKet)
        Me.PanelControl3.Controls.Add(Me.PanelControl7)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl3.Location = New System.Drawing.Point(327, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(375, 121)
        Me.PanelControl3.TabIndex = 7
        '
        'pnlKet
        '
        Me.pnlKet.Controls.Add(Me.txtKet)
        Me.pnlKet.Controls.Add(Me.LabelControl7)
        Me.pnlKet.Controls.Add(Me.LabelControl8)
        Me.pnlKet.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKet.Location = New System.Drawing.Point(2, 7)
        Me.pnlKet.Name = "pnlKet"
        Me.pnlKet.Size = New System.Drawing.Size(371, 90)
        Me.pnlKet.TabIndex = 5
        '
        'txtKet
        '
        Me.txtKet.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKet.EnterMoveNextControl = True
        Me.txtKet.Location = New System.Drawing.Point(97, 2)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Properties.ValidateOnEnterKey = True
        Me.txtKet.Size = New System.Drawing.Size(250, 86)
        Me.txtKet.TabIndex = 4
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl7.Location = New System.Drawing.Point(87, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Padding = New System.Windows.Forms.Padding(0, 0, 0, 67)
        Me.LabelControl7.Size = New System.Drawing.Size(10, 86)
        Me.LabelControl7.TabIndex = 1
        Me.LabelControl7.Text = ":"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl8.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 67)
        Me.LabelControl8.Size = New System.Drawing.Size(85, 86)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Keterangan"
        '
        'PanelControl7
        '
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl7.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(371, 5)
        Me.PanelControl7.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.pnlNoRef)
        Me.PanelControl1.Controls.Add(Me.pnlTgl)
        Me.PanelControl1.Controls.Add(Me.pnlNotrans)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(325, 121)
        Me.PanelControl1.TabIndex = 6
        '
        'pnlNoRef
        '
        Me.pnlNoRef.Controls.Add(Me.txtNoRef)
        Me.pnlNoRef.Controls.Add(Me.LabelControl5)
        Me.pnlNoRef.Controls.Add(Me.LabelControl6)
        Me.pnlNoRef.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNoRef.Location = New System.Drawing.Point(2, 67)
        Me.pnlNoRef.Name = "pnlNoRef"
        Me.pnlNoRef.Size = New System.Drawing.Size(321, 30)
        Me.pnlNoRef.TabIndex = 5
        '
        'txtNoRef
        '
        Me.txtNoRef.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNoRef.EnterMoveNextControl = True
        Me.txtNoRef.Location = New System.Drawing.Point(97, 2)
        Me.txtNoRef.Name = "txtNoRef"
        Me.txtNoRef.Properties.ValidateOnEnterKey = True
        Me.txtNoRef.Size = New System.Drawing.Size(201, 20)
        Me.txtNoRef.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl5.Location = New System.Drawing.Point(87, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.LabelControl5.Size = New System.Drawing.Size(10, 26)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = ":"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl6.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 7)
        Me.LabelControl6.Size = New System.Drawing.Size(85, 26)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "No. Ref."
        '
        'pnlTgl
        '
        Me.pnlTgl.Controls.Add(Me.dteTanggal)
        Me.pnlTgl.Controls.Add(Me.LabelControl3)
        Me.pnlTgl.Controls.Add(Me.LabelControl4)
        Me.pnlTgl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTgl.Location = New System.Drawing.Point(2, 37)
        Me.pnlTgl.Name = "pnlTgl"
        Me.pnlTgl.Size = New System.Drawing.Size(321, 30)
        Me.pnlTgl.TabIndex = 4
        '
        'dteTanggal
        '
        Me.dteTanggal.Dock = System.Windows.Forms.DockStyle.Left
        Me.dteTanggal.EditValue = Nothing
        Me.dteTanggal.EnterMoveNextControl = True
        Me.dteTanggal.Location = New System.Drawing.Point(97, 2)
        Me.dteTanggal.Name = "dteTanggal"
        Me.dteTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteTanggal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dteTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteTanggal.Properties.ShowPopupShadow = False
        Me.dteTanggal.Properties.ValidateOnEnterKey = True
        Me.dteTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dteTanggal.Size = New System.Drawing.Size(150, 20)
        Me.dteTanggal.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(87, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.LabelControl3.Size = New System.Drawing.Size(10, 26)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 7)
        Me.LabelControl4.Size = New System.Drawing.Size(85, 26)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Tanggal"
        '
        'pnlNotrans
        '
        Me.pnlNotrans.Controls.Add(Me.txtNoTrans)
        Me.pnlNotrans.Controls.Add(Me.LabelControl2)
        Me.pnlNotrans.Controls.Add(Me.LabelControl1)
        Me.pnlNotrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNotrans.Location = New System.Drawing.Point(2, 7)
        Me.pnlNotrans.Name = "pnlNotrans"
        Me.pnlNotrans.Size = New System.Drawing.Size(321, 30)
        Me.pnlNotrans.TabIndex = 2
        '
        'txtNoTrans
        '
        Me.txtNoTrans.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNoTrans.Location = New System.Drawing.Point(97, 2)
        Me.txtNoTrans.Name = "txtNoTrans"
        Me.txtNoTrans.Properties.ReadOnly = True
        Me.txtNoTrans.Properties.ValidateOnEnterKey = True
        Me.txtNoTrans.Size = New System.Drawing.Size(201, 20)
        Me.txtNoTrans.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(87, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.LabelControl2.Size = New System.Drawing.Size(10, 26)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 7)
        Me.LabelControl1.Size = New System.Drawing.Size(85, 26)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "No. Transaksi"
        '
        'PanelControl2
        '
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(321, 5)
        Me.PanelControl2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 389)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 20)
        Me.Panel1.TabIndex = 144
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(878, 34)
        Me.Panel5.TabIndex = 143
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
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         FORM PENYESUAIAN HPP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'aFormHPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 615)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormHPP"
        Me.Text = "aFormHPP"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.pnlDetil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetil.ResumeLayout(False)
        CType(Me.gcHPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvHPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNominal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMaster.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.pnlKet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKet.ResumeLayout(False)
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.pnlNoRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNoRef.ResumeLayout(False)
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlTgl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTgl.ResumeLayout(False)
        CType(Me.dteTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlNotrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNotrans.ResumeLayout(False)
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlMaster As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlKet As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtKet As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlNoRef As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtNoRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlTgl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dteTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlNotrans As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtNoTrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlDetil As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcHPP As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvHPP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNominal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookSatuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
