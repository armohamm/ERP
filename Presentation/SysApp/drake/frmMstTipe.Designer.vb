<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstTipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstTipe))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcTipe = New DevExpress.XtraGrid.GridControl
        Me.GvTipe = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Jns = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupJnsBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Kode_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Alias_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Kode_Merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.GcTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupJnsBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcTipe)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 373)
        Me.pnl.TabIndex = 0
        '
        'GcTipe
        '
        Me.GcTipe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcTipe.Location = New System.Drawing.Point(0, 34)
        Me.GcTipe.MainView = Me.GvTipe
        Me.GcTipe.Name = "GcTipe"
        Me.GcTipe.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.LookupJnsBrg, Me.CekStat, Me.repMerk})
        Me.GcTipe.Size = New System.Drawing.Size(1004, 339)
        Me.GcTipe.TabIndex = 32
        Me.GcTipe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvTipe})
        '
        'GvTipe
        '
        Me.GvTipe.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Jns, Me.Kode_Tipe, Me.Nama_Tipe, Me.Keterangan, Me.Alias_Tipe, Me.Rec_stat, Me.Kode_Merk})
        Me.GvTipe.GridControl = Me.GcTipe
        Me.GvTipe.Name = "GvTipe"
        Me.GvTipe.OptionsCustomization.AllowColumnMoving = False
        Me.GvTipe.OptionsCustomization.AllowFilter = False
        Me.GvTipe.OptionsCustomization.AllowGroup = False
        Me.GvTipe.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvTipe.OptionsView.RowAutoHeight = True
        Me.GvTipe.OptionsView.ShowGroupPanel = False
        '
        'Kd_Jns
        '
        Me.Kd_Jns.Caption = "Jenis Barang"
        Me.Kd_Jns.ColumnEdit = Me.LookupJnsBrg
        Me.Kd_Jns.FieldName = "Kd_Jns"
        Me.Kd_Jns.Name = "Kd_Jns"
        Me.Kd_Jns.Width = 79
        '
        'LookupJnsBrg
        '
        Me.LookupJnsBrg.AutoHeight = False
        Me.LookupJnsBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupJnsBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Jenis Barang")})
        Me.LookupJnsBrg.DropDownRows = 10
        Me.LookupJnsBrg.Name = "LookupJnsBrg"
        Me.LookupJnsBrg.NullText = "klik disini"
        Me.LookupJnsBrg.PopupWidth = 250
        Me.LookupJnsBrg.ShowFooter = False
        Me.LookupJnsBrg.ShowHeader = False
        Me.LookupJnsBrg.ShowLines = False
        '
        'Kode_Tipe
        '
        Me.Kode_Tipe.Caption = "Kode Tipe"
        Me.Kode_Tipe.FieldName = "Kode_Tipe"
        Me.Kode_Tipe.Name = "Kode_Tipe"
        Me.Kode_Tipe.Visible = True
        Me.Kode_Tipe.VisibleIndex = 1
        Me.Kode_Tipe.Width = 158
        '
        'Nama_Tipe
        '
        Me.Nama_Tipe.Caption = "Nama Tipe"
        Me.Nama_Tipe.FieldName = "Nama_Tipe"
        Me.Nama_Tipe.Name = "Nama_Tipe"
        Me.Nama_Tipe.Visible = True
        Me.Nama_Tipe.VisibleIndex = 2
        Me.Nama_Tipe.Width = 288
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 3
        Me.Keterangan.Width = 173
        '
        'Alias_Tipe
        '
        Me.Alias_Tipe.Caption = "Alias Tipe"
        Me.Alias_Tipe.FieldName = "Alias_Tipe"
        Me.Alias_Tipe.Name = "Alias_Tipe"
        Me.Alias_Tipe.Visible = True
        Me.Alias_Tipe.VisibleIndex = 4
        Me.Alias_Tipe.Width = 107
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.CekStat
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 5
        Me.Rec_stat.Width = 76
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
        'Kode_Merk
        '
        Me.Kode_Merk.Caption = "Merk"
        Me.Kode_Merk.ColumnEdit = Me.repMerk
        Me.Kode_Merk.FieldName = "Kode_Merk"
        Me.Kode_Merk.Name = "Kode_Merk"
        Me.Kode_Merk.Visible = True
        Me.Kode_Merk.VisibleIndex = 0
        Me.Kode_Merk.Width = 181
        '
        'repMerk
        '
        Me.repMerk.AutoHeight = False
        Me.repMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", 250, "Merk")})
        Me.repMerk.DisplayMember = "Nama_Merk"
        Me.repMerk.Name = "repMerk"
        Me.repMerk.NullText = ""
        Me.repMerk.PopupWidth = 250
        Me.repMerk.ShowFooter = False
        Me.repMerk.ShowHeader = False
        Me.repMerk.ShowLines = False
        Me.repMerk.ValueMember = "Kode_Merk"
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
        Me.Panel1.TabIndex = 33
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
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          Maintenance Tipe Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMstTipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 373)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstTipe"
        Me.Text = "frmMstTipe"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupJnsBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcTipe As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvTipe As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Jns As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kode_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alias_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupJnsBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Kode_Merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
