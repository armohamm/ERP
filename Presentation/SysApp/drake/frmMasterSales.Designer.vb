<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasterSales))
        Me.pnl = New System.Windows.Forms.Panel
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cbStatus = New System.Windows.Forms.ComboBox
        Me.txbKet = New System.Windows.Forms.TextBox
        Me.lueArea = New DevExpress.XtraEditors.LookUpEdit
        Me.lueWilayah = New DevExpress.XtraEditors.LookUpEdit
        Me.lueDept = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.luePegawai = New DevExpress.XtraEditors.LookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GC_Sales = New DevExpress.XtraGrid.GridControl
        Me.GVSpon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.KodeSales = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NamaSales = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NamaDepartemen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NamaWilayah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NamaArea = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.recstat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupdepartemen = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.pnl.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.lueArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueWilayah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePegawai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GC_Sales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupdepartemen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.XtraTabControl1)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Location = New System.Drawing.Point(4, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(957, 372)
        Me.pnl.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(8, 37)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(935, 290)
        Me.XtraTabControl1.TabIndex = 124
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.Panel5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(928, 261)
        Me.XtraTabPage1.Text = "Maintenance Data Sales"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Location = New System.Drawing.Point(7, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(600, 180)
        Me.Panel5.TabIndex = 106
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 180)
        Me.Panel3.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Status Sales"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 60)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Keterangan"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Area"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Wilayah"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Departemen"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Kode Pegawai"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 20)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Nama Pegawai"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cbStatus)
        Me.Panel4.Controls.Add(Me.txbKet)
        Me.Panel4.Controls.Add(Me.lueArea)
        Me.Panel4.Controls.Add(Me.lueWilayah)
        Me.Panel4.Controls.Add(Me.lueDept)
        Me.Panel4.Controls.Add(Me.txtNama)
        Me.Panel4.Controls.Add(Me.luePegawai)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(100, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(500, 180)
        Me.Panel4.TabIndex = 2
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.Color.White
        Me.cbStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cbStatus.Location = New System.Drawing.Point(0, 160)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(500, 21)
        Me.cbStatus.TabIndex = 126
        '
        'txbKet
        '
        Me.txbKet.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbKet.Location = New System.Drawing.Point(0, 100)
        Me.txbKet.Multiline = True
        Me.txbKet.Name = "txbKet"
        Me.txbKet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbKet.Size = New System.Drawing.Size(500, 60)
        Me.txbKet.TabIndex = 125
        '
        'lueArea
        '
        Me.lueArea.Dock = System.Windows.Forms.DockStyle.Top
        Me.lueArea.Location = New System.Drawing.Point(0, 80)
        Me.lueArea.Name = "lueArea"
        Me.lueArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueArea.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Area", "Nama Area")})
        Me.lueArea.Properties.DisplayMember = "Nama_Area"
        Me.lueArea.Properties.NullText = "[Area]"
        Me.lueArea.Properties.ValueMember = "Kode_Area"
        Me.lueArea.Size = New System.Drawing.Size(500, 20)
        Me.lueArea.TabIndex = 124
        '
        'lueWilayah
        '
        Me.lueWilayah.Dock = System.Windows.Forms.DockStyle.Top
        Me.lueWilayah.Location = New System.Drawing.Point(0, 60)
        Me.lueWilayah.Name = "lueWilayah"
        Me.lueWilayah.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueWilayah.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Wilayah", "Nama Wilayah")})
        Me.lueWilayah.Properties.DisplayMember = "Nama_Wilayah"
        Me.lueWilayah.Properties.NullText = "[Wilayah]"
        Me.lueWilayah.Properties.ValueMember = "Kode_Wilayah"
        Me.lueWilayah.Size = New System.Drawing.Size(500, 20)
        Me.lueWilayah.TabIndex = 123
        '
        'lueDept
        '
        Me.lueDept.Dock = System.Windows.Forms.DockStyle.Top
        Me.lueDept.Location = New System.Drawing.Point(0, 40)
        Me.lueDept.Name = "lueDept"
        Me.lueDept.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDept.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Departemen")})
        Me.lueDept.Properties.DisplayMember = "Nama_Departemen"
        Me.lueDept.Properties.NullText = "[Departemen]"
        Me.lueDept.Properties.ValueMember = "Kd_Departemen"
        Me.lueDept.Size = New System.Drawing.Size(500, 20)
        Me.lueDept.TabIndex = 122
        '
        'txtNama
        '
        Me.txtNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(0, 20)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(500, 20)
        Me.txtNama.TabIndex = 121
        '
        'luePegawai
        '
        Me.luePegawai.Dock = System.Windows.Forms.DockStyle.Top
        Me.luePegawai.Location = New System.Drawing.Point(0, 0)
        Me.luePegawai.Name = "luePegawai"
        Me.luePegawai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePegawai.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama Pegawai"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Pegawai", "Kode Pegawai")})
        Me.luePegawai.Properties.DisplayMember = "Nama_Pegawai"
        Me.luePegawai.Properties.NullText = "[Nama]"
        Me.luePegawai.Properties.ValueMember = "Kode_Pegawai"
        Me.luePegawai.Size = New System.Drawing.Size(500, 20)
        Me.luePegawai.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GC_Sales)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(928, 261)
        Me.XtraTabPage2.Text = "Daftar Sales"
        '
        'GC_Sales
        '
        Me.GC_Sales.Location = New System.Drawing.Point(0, 0)
        Me.GC_Sales.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC_Sales.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC_Sales.MainView = Me.GVSpon
        Me.GC_Sales.Name = "GC_Sales"
        Me.GC_Sales.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupdepartemen})
        Me.GC_Sales.Size = New System.Drawing.Size(925, 261)
        Me.GC_Sales.TabIndex = 6
        Me.GC_Sales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSpon, Me.GridView1})
        '
        'GVSpon
        '
        Me.GVSpon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSpon.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.Empty.Options.UseBackColor = True
        Me.GVSpon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSpon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVSpon.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSpon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVSpon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSpon.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSpon.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVSpon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSpon.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSpon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVSpon.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSpon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVSpon.Appearance.Preview.Options.UseBackColor = True
        Me.GVSpon.Appearance.Preview.Options.UseFont = True
        Me.GVSpon.Appearance.Preview.Options.UseForeColor = True
        Me.GVSpon.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.Row.Options.UseBackColor = True
        Me.GVSpon.Appearance.Row.Options.UseBorderColor = True
        Me.GVSpon.Appearance.Row.Options.UseForeColor = True
        Me.GVSpon.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSpon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVSpon.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSpon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KodeSales, Me.NamaSales, Me.NamaDepartemen, Me.NamaWilayah, Me.NamaArea, Me.Keterangan, Me.recstat})
        Me.GVSpon.GridControl = Me.GC_Sales
        Me.GVSpon.GroupFormat = "{0}: [#image]{1}{2}"
        Me.GVSpon.Name = "GVSpon"
        Me.GVSpon.OptionsBehavior.Editable = False
        Me.GVSpon.OptionsBehavior.ReadOnly = True
        Me.GVSpon.OptionsCustomization.AllowColumnMoving = False
        Me.GVSpon.OptionsPrint.ExpandAllDetails = True
        Me.GVSpon.OptionsView.ColumnAutoWidth = False
        Me.GVSpon.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSpon.OptionsView.EnableAppearanceOddRow = True
        Me.GVSpon.OptionsView.ShowChildrenInGroupPanel = True
        Me.GVSpon.OptionsView.ShowGroupPanel = False
        '
        'KodeSales
        '
        Me.KodeSales.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeSales.AppearanceCell.Options.UseFont = True
        Me.KodeSales.Caption = "Kode Sales"
        Me.KodeSales.FieldName = "Kode_Sales"
        Me.KodeSales.Name = "KodeSales"
        Me.KodeSales.Visible = True
        Me.KodeSales.VisibleIndex = 0
        Me.KodeSales.Width = 153
        '
        'NamaSales
        '
        Me.NamaSales.Caption = "Nama Sales"
        Me.NamaSales.FieldName = "Nama_Sales"
        Me.NamaSales.Name = "NamaSales"
        Me.NamaSales.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.NamaSales.Visible = True
        Me.NamaSales.VisibleIndex = 1
        Me.NamaSales.Width = 117
        '
        'NamaDepartemen
        '
        Me.NamaDepartemen.Caption = "Nama Departemen"
        Me.NamaDepartemen.FieldName = "Nama_Departemen"
        Me.NamaDepartemen.Name = "NamaDepartemen"
        Me.NamaDepartemen.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.NamaDepartemen.Visible = True
        Me.NamaDepartemen.VisibleIndex = 2
        Me.NamaDepartemen.Width = 153
        '
        'NamaWilayah
        '
        Me.NamaWilayah.Caption = "Nama Wilayah"
        Me.NamaWilayah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NamaWilayah.FieldName = "Nama_Wilayah"
        Me.NamaWilayah.Name = "NamaWilayah"
        Me.NamaWilayah.Visible = True
        Me.NamaWilayah.VisibleIndex = 3
        Me.NamaWilayah.Width = 91
        '
        'NamaArea
        '
        Me.NamaArea.Caption = "Nama Area"
        Me.NamaArea.FieldName = "Nama_Area"
        Me.NamaArea.Name = "NamaArea"
        Me.NamaArea.Visible = True
        Me.NamaArea.VisibleIndex = 4
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 6
        '
        'recstat
        '
        Me.recstat.Caption = "Status"
        Me.recstat.FieldName = "Rec_Stat"
        Me.recstat.Name = "recstat"
        Me.recstat.Visible = True
        Me.recstat.VisibleIndex = 5
        '
        'lookupdepartemen
        '
        Me.lookupdepartemen.AutoHeight = False
        Me.lookupdepartemen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupdepartemen.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Departemen")})
        Me.lookupdepartemen.Name = "lookupdepartemen"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GC_Sales
        Me.GridView1.Name = "GridView1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 34)
        Me.Panel1.TabIndex = 123
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
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(41, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MAINTENANCE MASTER SALES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.cmdExit)
        Me.Panel2.Controls.Add(Me.cmdCancel)
        Me.Panel2.Controls.Add(Me.cmdDelete)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Controls.Add(Me.cmdEdit)
        Me.Panel2.Controls.Add(Me.cmdAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 333)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(957, 39)
        Me.Panel2.TabIndex = 108
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdExit.Location = New System.Drawing.Point(523, 5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(64, 27)
        Me.cmdExit.TabIndex = 26
        Me.cmdExit.Text = "E&Xit"
        Me.cmdExit.UseVisualStyleBackColor = False
        Me.cmdExit.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdCancel.Location = New System.Drawing.Point(404, 6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 27)
        Me.cmdCancel.TabIndex = 24
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        Me.cmdCancel.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdDelete.Location = New System.Drawing.Point(334, 6)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 27)
        Me.cmdDelete.TabIndex = 23
        Me.cmdDelete.Text = "&Hapus"
        Me.cmdDelete.UseVisualStyleBackColor = False
        Me.cmdDelete.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdSave.Location = New System.Drawing.Point(264, 5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(64, 27)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "&Simpan"
        Me.cmdSave.UseVisualStyleBackColor = False
        Me.cmdSave.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdEdit.Location = New System.Drawing.Point(194, 5)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 27)
        Me.cmdEdit.TabIndex = 21
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = False
        Me.cmdEdit.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(123, 5)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(62, 27)
        Me.cmdAdd.TabIndex = 20
        Me.cmdAdd.Text = "&Tambah"
        Me.cmdAdd.UseVisualStyleBackColor = False
        Me.cmdAdd.Visible = False
        '
        'frmMasterSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(973, 384)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMasterSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMasterSales"
        Me.pnl.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.lueArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueWilayah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePegawai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GC_Sales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupdepartemen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txbKet As System.Windows.Forms.TextBox
    Friend WithEvents lueArea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueWilayah As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDept As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents luePegawai As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents GC_Sales As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSpon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KodeSales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamaSales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamaDepartemen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamaWilayah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamaArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents recstat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupdepartemen As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
