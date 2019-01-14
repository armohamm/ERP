<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstJnsPersd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstJnsPersd))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcJnsPersd = New DevExpress.XtraGrid.GridControl
        Me.GvJnsPersd = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Jns_Persd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Persediaan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.GcJnsPersd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvJnsPersd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcJnsPersd)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 372)
        Me.pnl.TabIndex = 0
        '
        'GcJnsPersd
        '
        Me.GcJnsPersd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcJnsPersd.Location = New System.Drawing.Point(0, 34)
        Me.GcJnsPersd.MainView = Me.GvJnsPersd
        Me.GcJnsPersd.Name = "GcJnsPersd"
        Me.GcJnsPersd.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.CekStat})
        Me.GcJnsPersd.Size = New System.Drawing.Size(1004, 338)
        Me.GcJnsPersd.TabIndex = 103
        Me.GcJnsPersd.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvJnsPersd})
        '
        'GvJnsPersd
        '
        Me.GvJnsPersd.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Jns_Persd, Me.Nama_Persediaan, Me.Keterangan, Me.Rec_stat})
        Me.GvJnsPersd.GridControl = Me.GcJnsPersd
        Me.GvJnsPersd.Name = "GvJnsPersd"
        Me.GvJnsPersd.OptionsCustomization.AllowColumnMoving = False
        Me.GvJnsPersd.OptionsCustomization.AllowFilter = False
        Me.GvJnsPersd.OptionsCustomization.AllowGroup = False
        Me.GvJnsPersd.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvJnsPersd.OptionsView.RowAutoHeight = True
        Me.GvJnsPersd.OptionsView.ShowGroupPanel = False
        '
        'Kd_Jns_Persd
        '
        Me.Kd_Jns_Persd.Caption = "Kode Persediaan"
        Me.Kd_Jns_Persd.FieldName = "Kd_Jns_Persd"
        Me.Kd_Jns_Persd.Name = "Kd_Jns_Persd"
        Me.Kd_Jns_Persd.Visible = True
        Me.Kd_Jns_Persd.VisibleIndex = 0
        Me.Kd_Jns_Persd.Width = 95
        '
        'Nama_Persediaan
        '
        Me.Nama_Persediaan.Caption = "Nama Jenis Persediaan"
        Me.Nama_Persediaan.FieldName = "Nama_Persediaan"
        Me.Nama_Persediaan.Name = "Nama_Persediaan"
        Me.Nama_Persediaan.Visible = True
        Me.Nama_Persediaan.VisibleIndex = 1
        Me.Nama_Persediaan.Width = 161
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 2
        Me.Keterangan.Width = 243
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.CekStat
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 3
        Me.Rec_stat.Width = 48
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
        Me.Panel1.TabIndex = 104
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
        Me.Label1.Size = New System.Drawing.Size(433, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE MASTER JENIS PERSEDIAAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMstJnsPersd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 372)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstJnsPersd"
        Me.Text = "frmMstJnsPersd"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcJnsPersd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvJnsPersd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcJnsPersd As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvJnsPersd As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Jns_Persd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Persediaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
