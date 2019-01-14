<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMstJnsBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMstJnsBarang))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcJnsBarang = New DevExpress.XtraGrid.GridControl
        Me.GvJnsBarang = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Jns_Persd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupJnsPsd = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Kd_Departemen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupDept = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Kd_Jns_Brg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.group = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupGroup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.GcJnsBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvJnsBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupJnsPsd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.GcJnsBarang)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 313)
        Me.pnl.TabIndex = 0
        '
        'GcJnsBarang
        '
        Me.GcJnsBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcJnsBarang.Location = New System.Drawing.Point(0, 34)
        Me.GcJnsBarang.MainView = Me.GvJnsBarang
        Me.GcJnsBarang.Name = "GcJnsBarang"
        Me.GcJnsBarang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.LookupDept, Me.LookupJnsPsd, Me.CekStat, Me.LookupGroup})
        Me.GcJnsBarang.Size = New System.Drawing.Size(1004, 279)
        Me.GcJnsBarang.TabIndex = 26
        Me.GcJnsBarang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvJnsBarang})
        '
        'GvJnsBarang
        '
        Me.GvJnsBarang.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Jns_Persd, Me.Kd_Departemen, Me.Kd_Jns_Brg, Me.Nama_Jenis, Me.group, Me.Keterangan, Me.Rec_stat})
        Me.GvJnsBarang.GridControl = Me.GcJnsBarang
        Me.GvJnsBarang.Name = "GvJnsBarang"
        Me.GvJnsBarang.OptionsCustomization.AllowGroup = False
        Me.GvJnsBarang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvJnsBarang.OptionsView.RowAutoHeight = True
        '
        'Kd_Jns_Persd
        '
        Me.Kd_Jns_Persd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Kd_Jns_Persd.AppearanceHeader.Options.UseFont = True
        Me.Kd_Jns_Persd.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_Jns_Persd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_Jns_Persd.Caption = "Kode Jenis Persediaan"
        Me.Kd_Jns_Persd.ColumnEdit = Me.LookupJnsPsd
        Me.Kd_Jns_Persd.FieldName = "Kd_Jns_Persd"
        Me.Kd_Jns_Persd.Name = "Kd_Jns_Persd"
        Me.Kd_Jns_Persd.Visible = True
        Me.Kd_Jns_Persd.VisibleIndex = 0
        Me.Kd_Jns_Persd.Width = 117
        '
        'LookupJnsPsd
        '
        Me.LookupJnsPsd.AutoHeight = False
        Me.LookupJnsPsd.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupJnsPsd.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Persediaan", "Nama Persediaan")})
        Me.LookupJnsPsd.Name = "LookupJnsPsd"
        Me.LookupJnsPsd.NullText = "klik disini"
        '
        'Kd_Departemen
        '
        Me.Kd_Departemen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Kd_Departemen.AppearanceHeader.Options.UseFont = True
        Me.Kd_Departemen.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_Departemen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_Departemen.Caption = "Kode Departemen"
        Me.Kd_Departemen.ColumnEdit = Me.LookupDept
        Me.Kd_Departemen.FieldName = "Kd_Departemen"
        Me.Kd_Departemen.Name = "Kd_Departemen"
        Me.Kd_Departemen.Visible = True
        Me.Kd_Departemen.VisibleIndex = 1
        Me.Kd_Departemen.Width = 117
        '
        'LookupDept
        '
        Me.LookupDept.AutoHeight = False
        Me.LookupDept.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupDept.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Departemen")})
        Me.LookupDept.Name = "LookupDept"
        Me.LookupDept.NullText = "klik disini"
        '
        'Kd_Jns_Brg
        '
        Me.Kd_Jns_Brg.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Kd_Jns_Brg.AppearanceHeader.Options.UseFont = True
        Me.Kd_Jns_Brg.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_Jns_Brg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_Jns_Brg.Caption = "Kode Jenis"
        Me.Kd_Jns_Brg.FieldName = "Kd_Jns_Brg"
        Me.Kd_Jns_Brg.Name = "Kd_Jns_Brg"
        Me.Kd_Jns_Brg.OptionsColumn.AllowEdit = False
        Me.Kd_Jns_Brg.Visible = True
        Me.Kd_Jns_Brg.VisibleIndex = 2
        Me.Kd_Jns_Brg.Width = 117
        '
        'Nama_Jenis
        '
        Me.Nama_Jenis.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Nama_Jenis.AppearanceHeader.Options.UseFont = True
        Me.Nama_Jenis.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Jenis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Jenis.Caption = "Nama Jenis"
        Me.Nama_Jenis.FieldName = "Nama_Jenis"
        Me.Nama_Jenis.Name = "Nama_Jenis"
        Me.Nama_Jenis.Visible = True
        Me.Nama_Jenis.VisibleIndex = 3
        Me.Nama_Jenis.Width = 117
        '
        'group
        '
        Me.group.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group.AppearanceHeader.Options.UseFont = True
        Me.group.AppearanceHeader.Options.UseTextOptions = True
        Me.group.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.group.Caption = "Group"
        Me.group.ColumnEdit = Me.LookupGroup
        Me.group.FieldName = "group"
        Me.group.Name = "group"
        Me.group.Visible = True
        Me.group.VisibleIndex = 4
        '
        'LookupGroup
        '
        Me.LookupGroup.AutoHeight = False
        Me.LookupGroup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupGroup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Desc_Data")})
        Me.LookupGroup.DisplayMember = "Desc_Data"
        Me.LookupGroup.Name = "LookupGroup"
        Me.LookupGroup.NullText = "klik disini"
        Me.LookupGroup.ValueMember = "Id_Data"
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 5
        Me.Keterangan.Width = 157
        '
        'Rec_stat
        '
        Me.Rec_stat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Rec_stat.AppearanceHeader.Options.UseFont = True
        Me.Rec_stat.AppearanceHeader.Options.UseTextOptions = True
        Me.Rec_stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.CekStat
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 6
        Me.Rec_stat.Width = 82
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = "Y"
        Me.CekStat.DisplayValueChecked = "Y"
        Me.CekStat.DisplayValueUnchecked = "T"
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CekStat.ValueChecked = "Y"
        Me.CekStat.ValueUnchecked = "T"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
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
        Me.Panel1.Size = New System.Drawing.Size(1004, 34)
        Me.Panel1.TabIndex = 27
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
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE JENIS BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmMstJnsBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 313)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmMstJnsBarang"
        Me.Text = "FrmMstJnsBarang"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcJnsBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvJnsBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupJnsPsd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcJnsBarang As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvJnsBarang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Jns_Persd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupJnsPsd As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Kd_Departemen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupDept As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Kd_Jns_Brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents group As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupGroup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
