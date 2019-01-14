<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstHarga
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstHarga))
        Me.Harga_Rupiah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNum = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcMstHarga = New DevExpress.XtraGrid.GridControl
        Me.GvMstHarga = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me._jenisbrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_jnbrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me._merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_merk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Start_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepTgl = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.End_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Harga_Dollar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnAdd2 = New DevExpress.XtraEditors.SimpleButton
        Me.txtCari = New DevExpress.XtraEditors.TextEdit
        Me.cmdAddNew = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdSubTipe = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnTambah = New DevExpress.XtraEditors.SimpleButton
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.btnHide = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUkuran = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdTipe = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdMerk = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdJenis = New DevExpress.XtraEditors.LookUpEdit
        Me.tglBerlaku = New DevExpress.XtraEditors.DateEdit
        Me.dollar = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.rupiah = New DevExpress.XtraEditors.SpinEdit
        Me.txtBarang = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GcMstHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMstHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_jnbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_merk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepTgl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepTgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtCari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.cmdSubTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.cmdUkuran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdMerk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglBerlaku.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglBerlaku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dollar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rupiah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Harga_Rupiah
        '
        Me.Harga_Rupiah.Caption = "Harga Rupiah"
        Me.Harga_Rupiah.ColumnEdit = Me.repNum
        Me.Harga_Rupiah.FieldName = "Harga_Rupiah"
        Me.Harga_Rupiah.Name = "Harga_Rupiah"
        Me.Harga_Rupiah.Visible = True
        Me.Harga_Rupiah.VisibleIndex = 3
        Me.Harga_Rupiah.Width = 147
        '
        'repNum
        '
        Me.repNum.AutoHeight = False
        Me.repNum.DisplayFormat.FormatString = "n2"
        Me.repNum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.EditFormat.FormatString = "n2"
        Me.repNum.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.Name = "repNum"
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Nama Barang"
        Me.Nama_Barang.FieldName = "Nama"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.OptionsColumn.AllowEdit = False
        Me.Nama_Barang.OptionsColumn.AllowFocus = False
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 0
        Me.Nama_Barang.Width = 465
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMstHarga)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 399)
        Me.pnl.TabIndex = 0
        '
        'GcMstHarga
        '
        Me.GcMstHarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMstHarga.Location = New System.Drawing.Point(0, 150)
        Me.GcMstHarga.MainView = Me.GvMstHarga
        Me.GcMstHarga.Name = "GcMstHarga"
        Me.GcMstHarga.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCombo, Me.RL_jnbrg, Me.RL_merk, Me.repNum, Me.RepTgl, Me.repBarang})
        Me.GcMstHarga.Size = New System.Drawing.Size(1004, 212)
        Me.GcMstHarga.TabIndex = 137
        Me.GcMstHarga.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMstHarga})
        '
        'GvMstHarga
        '
        Me.GvMstHarga.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GvMstHarga.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvMstHarga.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GvMstHarga.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GvMstHarga.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nama_Barang, Me.Kode_Barang, Me._jenisbrg, Me._merk, Me.Start_Date, Me.End_Date, Me.Harga_Rupiah, Me.Harga_Dollar, Me.Rec_stat})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.Harga_Rupiah
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value2 = CType(0, Short)
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.Nama_Barang
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition2.Value1 = "X"
        Me.GvMstHarga.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GvMstHarga.GridControl = Me.GcMstHarga
        Me.GvMstHarga.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data."
        Me.GvMstHarga.Name = "GvMstHarga"
        Me.GvMstHarga.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMstHarga.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'Kode_Barang
        '
        Me.Kode_Barang.Caption = "Kode Barang"
        Me.Kode_Barang.ColumnEdit = Me.repBarang
        Me.Kode_Barang.FieldName = "Kode_Barang"
        Me.Kode_Barang.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.Kode_Barang.Name = "Kode_Barang"
        Me.Kode_Barang.OptionsColumn.AllowEdit = False
        Me.Kode_Barang.OptionsColumn.AllowFocus = False
        Me.Kode_Barang.OptionsColumn.ReadOnly = True
        Me.Kode_Barang.OptionsFilter.AllowFilter = False
        Me.Kode_Barang.Width = 358
        '
        'repBarang
        '
        Me.repBarang.AutoHeight = False
        Me.repBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBarang.DisplayMember = "Nama_Barang"
        Me.repBarang.Name = "repBarang"
        Me.repBarang.ValueMember = "Kode_Barang"
        '
        '_jenisbrg
        '
        Me._jenisbrg.Caption = "Jenis Barang"
        Me._jenisbrg.ColumnEdit = Me.RL_jnbrg
        Me._jenisbrg.FieldName = "_jenisbrg"
        Me._jenisbrg.Name = "_jenisbrg"
        Me._jenisbrg.OptionsColumn.AllowEdit = False
        Me._jenisbrg.OptionsColumn.AllowFocus = False
        Me._jenisbrg.OptionsColumn.ReadOnly = True
        Me._jenisbrg.Visible = True
        Me._jenisbrg.VisibleIndex = 2
        Me._jenisbrg.Width = 167
        '
        'RL_jnbrg
        '
        Me.RL_jnbrg.AutoHeight = False
        Me.RL_jnbrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_jnbrg.Name = "RL_jnbrg"
        Me.RL_jnbrg.NullText = ""
        '
        '_merk
        '
        Me._merk.Caption = "Merk"
        Me._merk.ColumnEdit = Me.RL_merk
        Me._merk.FieldName = "kd_merk"
        Me._merk.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me._merk.Name = "_merk"
        Me._merk.OptionsColumn.AllowEdit = False
        Me._merk.OptionsColumn.AllowFocus = False
        Me._merk.OptionsColumn.ReadOnly = True
        Me._merk.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me._merk.OptionsFilter.ImmediateUpdateAutoFilter = False
        Me._merk.Visible = True
        Me._merk.VisibleIndex = 1
        Me._merk.Width = 165
        '
        'RL_merk
        '
        Me.RL_merk.AutoHeight = False
        Me.RL_merk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_merk.Name = "RL_merk"
        Me.RL_merk.NullText = ""
        '
        'Start_Date
        '
        Me.Start_Date.Caption = "Start Date"
        Me.Start_Date.ColumnEdit = Me.RepTgl
        Me.Start_Date.FieldName = "Start_Date"
        Me.Start_Date.Name = "Start_Date"
        Me.Start_Date.Visible = True
        Me.Start_Date.VisibleIndex = 5
        Me.Start_Date.Width = 124
        '
        'RepTgl
        '
        Me.RepTgl.AutoHeight = False
        Me.RepTgl.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepTgl.Name = "RepTgl"
        Me.RepTgl.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'End_Date
        '
        Me.End_Date.Caption = "End Date"
        Me.End_Date.ColumnEdit = Me.RepTgl
        Me.End_Date.FieldName = "End_Date"
        Me.End_Date.Name = "End_Date"
        Me.End_Date.Width = 105
        '
        'Harga_Dollar
        '
        Me.Harga_Dollar.Caption = "Harga Dollar"
        Me.Harga_Dollar.ColumnEdit = Me.repNum
        Me.Harga_Dollar.FieldName = "Harga_Dollar"
        Me.Harga_Dollar.Name = "Harga_Dollar"
        Me.Harga_Dollar.Visible = True
        Me.Harga_Dollar.VisibleIndex = 4
        Me.Harga_Dollar.Width = 144
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.repCombo
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Width = 88
        '
        'repCombo
        '
        Me.repCombo.AutoHeight = False
        Me.repCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCombo.Items.AddRange(New Object() {"Y", "T"})
        Me.repCombo.Name = "repCombo"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.btnAdd2)
        Me.Panel3.Controls.Add(Me.txtCari)
        Me.Panel3.Controls.Add(Me.cmdAddNew)
        Me.Panel3.Controls.Add(Me.LabelControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 128)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1004, 22)
        Me.Panel3.TabIndex = 138
        '
        'btnAdd2
        '
        Me.btnAdd2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd2.Appearance.Options.UseFont = True
        Me.btnAdd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd2.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd2.Image = CType(resources.GetObject("btnAdd2.Image"), System.Drawing.Image)
        Me.btnAdd2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAdd2.Location = New System.Drawing.Point(948, 0)
        Me.btnAdd2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(28, 22)
        Me.btnAdd2.TabIndex = 14
        Me.btnAdd2.Tag = "Buku Order"
        Me.btnAdd2.Visible = False
        '
        'txtCari
        '
        Me.txtCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCari.Location = New System.Drawing.Point(124, 0)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(852, 20)
        Me.txtCari.TabIndex = 1
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNew.Appearance.Options.UseFont = True
        Me.cmdAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdAddNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdAddNew.Image = CType(resources.GetObject("cmdAddNew.Image"), System.Drawing.Image)
        Me.cmdAddNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAddNew.Location = New System.Drawing.Point(976, 0)
        Me.cmdAddNew.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(28, 22)
        Me.cmdAddNew.TabIndex = 13
        Me.cmdAddNew.Tag = "Buku Order"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(124, 22)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Pencarian : "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 362)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 37)
        Me.Panel2.TabIndex = 136
        Me.Panel2.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(474, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(592, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(393, 6)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1004, 91)
        Me.Panel4.TabIndex = 139
        Me.Panel4.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.cmdSubTipe)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.cmdUkuran)
        Me.Panel6.Controls.Add(Me.cmdTipe)
        Me.Panel6.Controls.Add(Me.cmdMerk)
        Me.Panel6.Controls.Add(Me.cmdJenis)
        Me.Panel6.Controls.Add(Me.tglBerlaku)
        Me.Panel6.Controls.Add(Me.dollar)
        Me.Panel6.Controls.Add(Me.LabelControl5)
        Me.Panel6.Controls.Add(Me.rupiah)
        Me.Panel6.Controls.Add(Me.txtBarang)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(123, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(881, 91)
        Me.Panel6.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(489, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 22)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdSubTipe
        '
        Me.cmdSubTipe.Location = New System.Drawing.Point(496, 3)
        Me.cmdSubTipe.Name = "cmdSubTipe"
        Me.cmdSubTipe.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdSubTipe.Properties.Appearance.Options.UseBackColor = True
        Me.cmdSubTipe.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmdSubTipe.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmdSubTipe.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmdSubTipe.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmdSubTipe.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdSubTipe.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubTipe.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdSubTipe.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdSubTipe.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdSubTipe.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdSubTipe.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmdSubTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdSubTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sub_Tipe", "SubTipe")})
        Me.cmdSubTipe.Properties.DisplayMember = "Nama_Sub_Tipe"
        Me.cmdSubTipe.Properties.DropDownRows = 15
        Me.cmdSubTipe.Properties.HideSelection = False
        Me.cmdSubTipe.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdSubTipe.Properties.NullText = "[Pilih SubTipe]"
        Me.cmdSubTipe.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.cmdSubTipe.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.cmdSubTipe.Properties.PopupWidth = 400
        Me.cmdSubTipe.Properties.ShowFooter = False
        Me.cmdSubTipe.Properties.ShowHeader = False
        Me.cmdSubTipe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmdSubTipe.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cmdSubTipe.Properties.ValueMember = "Kd_Sub_Tipe"
        Me.cmdSubTipe.Size = New System.Drawing.Size(153, 20)
        Me.cmdSubTipe.TabIndex = 3
        Me.cmdSubTipe.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdSubTipe.ToolTipTitle = "Nama Customer"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnTambah)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(825, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(56, 91)
        Me.Panel7.TabIndex = 10
        '
        'btnTambah
        '
        Me.btnTambah.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Appearance.Options.UseFont = True
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTambah.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnTambah.Location = New System.Drawing.Point(0, 0)
        Me.btnTambah.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(56, 44)
        Me.btnTambah.TabIndex = 1
        Me.btnTambah.Tag = "Masukan"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnHide)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 46)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(56, 45)
        Me.Panel8.TabIndex = 0
        '
        'btnHide
        '
        Me.btnHide.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.Appearance.Options.UseFont = True
        Me.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHide.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnHide.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnHide.Location = New System.Drawing.Point(0, 1)
        Me.btnHide.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(56, 44)
        Me.btnHide.TabIndex = 2
        Me.btnHide.Tag = "Hide"
        Me.btnHide.Text = "Hide"
        '
        'cmdUkuran
        '
        Me.cmdUkuran.Location = New System.Drawing.Point(655, 3)
        Me.cmdUkuran.Name = "cmdUkuran"
        Me.cmdUkuran.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdUkuran.Properties.Appearance.Options.UseBackColor = True
        Me.cmdUkuran.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmdUkuran.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmdUkuran.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmdUkuran.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmdUkuran.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdUkuran.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUkuran.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdUkuran.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdUkuran.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdUkuran.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdUkuran.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmdUkuran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdUkuran.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_ukuran", "Barang")})
        Me.cmdUkuran.Properties.DisplayMember = "nama_ukuran"
        Me.cmdUkuran.Properties.DropDownRows = 15
        Me.cmdUkuran.Properties.HideSelection = False
        Me.cmdUkuran.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdUkuran.Properties.NullText = "[Pilih Ukuran]"
        Me.cmdUkuran.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.cmdUkuran.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.cmdUkuran.Properties.PopupWidth = 400
        Me.cmdUkuran.Properties.ShowFooter = False
        Me.cmdUkuran.Properties.ShowHeader = False
        Me.cmdUkuran.Properties.ShowPopupShadow = False
        Me.cmdUkuran.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmdUkuran.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cmdUkuran.Properties.ValidateOnEnterKey = True
        Me.cmdUkuran.Properties.ValueMember = "kode_ukuran"
        Me.cmdUkuran.Size = New System.Drawing.Size(123, 20)
        Me.cmdUkuran.TabIndex = 4
        Me.cmdUkuran.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdUkuran.ToolTipTitle = "Nama Customer"
        '
        'cmdTipe
        '
        Me.cmdTipe.Location = New System.Drawing.Point(347, 3)
        Me.cmdTipe.Name = "cmdTipe"
        Me.cmdTipe.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdTipe.Properties.Appearance.Options.UseBackColor = True
        Me.cmdTipe.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmdTipe.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmdTipe.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmdTipe.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmdTipe.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdTipe.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTipe.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdTipe.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdTipe.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdTipe.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdTipe.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmdTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_tipe", "Barang")})
        Me.cmdTipe.Properties.DisplayMember = "nama_tipe"
        Me.cmdTipe.Properties.DropDownRows = 15
        Me.cmdTipe.Properties.HideSelection = False
        Me.cmdTipe.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdTipe.Properties.NullText = "[Pilih Tipe]"
        Me.cmdTipe.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.cmdTipe.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.cmdTipe.Properties.PopupWidth = 400
        Me.cmdTipe.Properties.ShowFooter = False
        Me.cmdTipe.Properties.ShowHeader = False
        Me.cmdTipe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmdTipe.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cmdTipe.Properties.ValueMember = "kode_tipe"
        Me.cmdTipe.Size = New System.Drawing.Size(143, 20)
        Me.cmdTipe.TabIndex = 2
        Me.cmdTipe.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdTipe.ToolTipTitle = "Nama Customer"
        '
        'cmdMerk
        '
        Me.cmdMerk.Location = New System.Drawing.Point(171, 3)
        Me.cmdMerk.Name = "cmdMerk"
        Me.cmdMerk.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdMerk.Properties.Appearance.Options.UseBackColor = True
        Me.cmdMerk.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmdMerk.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmdMerk.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmdMerk.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmdMerk.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdMerk.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMerk.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdMerk.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdMerk.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdMerk.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdMerk.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmdMerk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdMerk.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Barang")})
        Me.cmdMerk.Properties.DisplayMember = "Nama_Merk"
        Me.cmdMerk.Properties.DropDownRows = 15
        Me.cmdMerk.Properties.HideSelection = False
        Me.cmdMerk.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdMerk.Properties.NullText = "[Pilih Merk]"
        Me.cmdMerk.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.cmdMerk.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.cmdMerk.Properties.PopupWidth = 400
        Me.cmdMerk.Properties.ShowFooter = False
        Me.cmdMerk.Properties.ShowHeader = False
        Me.cmdMerk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmdMerk.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cmdMerk.Properties.ValueMember = "Kode_Merk"
        Me.cmdMerk.Size = New System.Drawing.Size(170, 20)
        Me.cmdMerk.TabIndex = 1
        Me.cmdMerk.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdMerk.ToolTipTitle = "Nama Customer"
        '
        'cmdJenis
        '
        Me.cmdJenis.Location = New System.Drawing.Point(1, 3)
        Me.cmdJenis.Name = "cmdJenis"
        Me.cmdJenis.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdJenis.Properties.Appearance.Options.UseBackColor = True
        Me.cmdJenis.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmdJenis.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmdJenis.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmdJenis.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmdJenis.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdJenis.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJenis.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdJenis.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdJenis.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdJenis.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdJenis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmdJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdJenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Jenis")})
        Me.cmdJenis.Properties.DisplayMember = "Nama_Jenis"
        Me.cmdJenis.Properties.DropDownRows = 15
        Me.cmdJenis.Properties.HideSelection = False
        Me.cmdJenis.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdJenis.Properties.NullText = "[Pilih Jenis Barang]"
        Me.cmdJenis.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.cmdJenis.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.cmdJenis.Properties.PopupWidth = 400
        Me.cmdJenis.Properties.ShowFooter = False
        Me.cmdJenis.Properties.ShowHeader = False
        Me.cmdJenis.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cmdJenis.Properties.ValueMember = "Kd_Jns_Brg"
        Me.cmdJenis.Size = New System.Drawing.Size(164, 20)
        Me.cmdJenis.TabIndex = 0
        Me.cmdJenis.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdJenis.ToolTipTitle = "Nama Customer"
        '
        'tglBerlaku
        '
        Me.tglBerlaku.EditValue = Nothing
        Me.tglBerlaku.Location = New System.Drawing.Point(0, 47)
        Me.tglBerlaku.Name = "tglBerlaku"
        Me.tglBerlaku.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.tglBerlaku.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglBerlaku.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.tglBerlaku.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tglBerlaku.Properties.AppearanceFocused.Options.UseFont = True
        Me.tglBerlaku.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tglBerlaku.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglBerlaku.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglBerlaku.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglBerlaku.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglBerlaku.Size = New System.Drawing.Size(164, 20)
        Me.tglBerlaku.TabIndex = 7
        '
        'dollar
        '
        Me.dollar.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.dollar.Location = New System.Drawing.Point(256, 24)
        Me.dollar.Name = "dollar"
        Me.dollar.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.dollar.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.dollar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dollar.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.dollar.Properties.Appearance.Options.UseBackColor = True
        Me.dollar.Properties.Appearance.Options.UseBorderColor = True
        Me.dollar.Properties.Appearance.Options.UseFont = True
        Me.dollar.Properties.Appearance.Options.UseForeColor = True
        Me.dollar.Properties.Appearance.Options.UseTextOptions = True
        Me.dollar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dollar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.dollar.Properties.DisplayFormat.FormatString = "n2"
        Me.dollar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.dollar.Properties.EditFormat.FormatString = "n2"
        Me.dollar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.dollar.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dollar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dollar.Size = New System.Drawing.Size(150, 22)
        Me.dollar.TabIndex = 6
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(171, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(85, 20)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Harga Dollar :"
        '
        'rupiah
        '
        Me.rupiah.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.rupiah.Location = New System.Drawing.Point(1, 24)
        Me.rupiah.Name = "rupiah"
        Me.rupiah.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.rupiah.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.rupiah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rupiah.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.rupiah.Properties.Appearance.Options.UseBackColor = True
        Me.rupiah.Properties.Appearance.Options.UseBorderColor = True
        Me.rupiah.Properties.Appearance.Options.UseFont = True
        Me.rupiah.Properties.Appearance.Options.UseForeColor = True
        Me.rupiah.Properties.Appearance.Options.UseTextOptions = True
        Me.rupiah.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.rupiah.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.rupiah.Properties.DisplayFormat.FormatString = "n2"
        Me.rupiah.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rupiah.Properties.EditFormat.FormatString = "n2"
        Me.rupiah.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rupiah.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.rupiah.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.rupiah.Size = New System.Drawing.Size(164, 22)
        Me.rupiah.TabIndex = 5
        '
        'txtBarang
        '
        Me.txtBarang.Location = New System.Drawing.Point(0, 68)
        Me.txtBarang.Name = "txtBarang"
        Me.txtBarang.Properties.AutoComplete = False
        Me.txtBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBarang.Properties.DisplayMember = "Nama_Barang"
        Me.txtBarang.Properties.NullText = "[Pilih Barang]"
        Me.txtBarang.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.txtBarang.Properties.PopupFormMinSize = New System.Drawing.Size(490, 0)
        Me.txtBarang.Properties.PopupFormSize = New System.Drawing.Size(490, 0)
        Me.txtBarang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtBarang.Properties.ValueMember = "Kode_Barang"
        Me.txtBarang.Properties.View = Me.GridLookUpEdit1View
        Me.txtBarang.Size = New System.Drawing.Size(490, 20)
        Me.txtBarang.TabIndex = 11
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowHorzLines = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        Me.GridLookUpEdit1View.OptionsView.ShowPreviewLines = False
        Me.GridLookUpEdit1View.OptionsView.ShowVertLines = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.LabelControl6)
        Me.Panel5.Controls.Add(Me.LabelControl4)
        Me.Panel5.Controls.Add(Me.LabelControl3)
        Me.Panel5.Controls.Add(Me.LabelControl2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(123, 91)
        Me.Panel5.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl6.Location = New System.Drawing.Point(0, 68)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(123, 22)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Per Barang : "
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl4.Location = New System.Drawing.Point(0, 46)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(123, 22)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Tanggal Berlaku : "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl3.Location = New System.Drawing.Point(0, 23)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(123, 23)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Harga Rupiah : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(123, 23)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Nama Barang : "
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
        Me.Panel1.Size = New System.Drawing.Size(1004, 37)
        Me.Panel1.TabIndex = 135
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(41, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MAINTENANCE MASTER HARGA BARANG JADI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMstHarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 399)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstHarga"
        Me.Text = "frmMstHarga"
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GcMstHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMstHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_jnbrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_merk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepTgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepTgl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtCari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.cmdSubTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.cmdUkuran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdMerk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglBerlaku.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglBerlaku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dollar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rupiah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcMstHarga As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMstHarga As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Start_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents End_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Harga_Rupiah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Harga_Dollar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _jenisbrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_jnbrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_merk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtCari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repNum As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepTgl As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dollar As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rupiah As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents tglBerlaku As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnTambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents repBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnHide As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdTipe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdMerk As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdJenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdUkuran As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents cmdSubTipe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBarang As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
End Class
