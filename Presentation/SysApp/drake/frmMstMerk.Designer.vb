<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstMerk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstMerk))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcPromo = New DevExpress.XtraGrid.GridControl
        Me.GvPromo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_Merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Alias_Merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_Stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.pnl.SuspendLayout()
        CType(Me.GcPromo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvPromo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcPromo)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 399)
        Me.pnl.TabIndex = 0
        '
        'GcPromo
        '
        Me.GcPromo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcPromo.Location = New System.Drawing.Point(0, 34)
        Me.GcPromo.MainView = Me.GvPromo
        Me.GcPromo.Name = "GcPromo"
        Me.GcPromo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CekStat})
        Me.GcPromo.Size = New System.Drawing.Size(1004, 365)
        Me.GcPromo.TabIndex = 103
        Me.GcPromo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvPromo})
        '
        'GvPromo
        '
        Me.GvPromo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kode_Merk, Me.Nama_Merk, Me.Alias_Merk, Me.Keterangan, Me.Rec_Stat})
        Me.GvPromo.GridControl = Me.GcPromo
        Me.GvPromo.Name = "GvPromo"
        Me.GvPromo.OptionsCustomization.AllowColumnMoving = False
        Me.GvPromo.OptionsCustomization.AllowFilter = False
        Me.GvPromo.OptionsCustomization.AllowGroup = False
        Me.GvPromo.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvPromo.OptionsView.RowAutoHeight = True
        Me.GvPromo.OptionsView.ShowGroupPanel = False
        '
        'Kode_Merk
        '
        Me.Kode_Merk.Caption = "Kode Merk"
        Me.Kode_Merk.FieldName = "Kode_Merk"
        Me.Kode_Merk.Name = "Kode_Merk"
        Me.Kode_Merk.Visible = True
        Me.Kode_Merk.VisibleIndex = 0
        Me.Kode_Merk.Width = 76
        '
        'Nama_Merk
        '
        Me.Nama_Merk.Caption = "Nama Merk"
        Me.Nama_Merk.FieldName = "Nama_Merk"
        Me.Nama_Merk.Name = "Nama_Merk"
        Me.Nama_Merk.Visible = True
        Me.Nama_Merk.VisibleIndex = 1
        Me.Nama_Merk.Width = 209
        '
        'Alias_Merk
        '
        Me.Alias_Merk.Caption = "Alias Merk"
        Me.Alias_Merk.FieldName = "Alias_Merk"
        Me.Alias_Merk.Name = "Alias_Merk"
        Me.Alias_Merk.Visible = True
        Me.Alias_Merk.VisibleIndex = 2
        Me.Alias_Merk.Width = 209
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 3
        Me.Keterangan.Width = 213
        '
        'Rec_Stat
        '
        Me.Rec_Stat.Caption = "Status"
        Me.Rec_Stat.ColumnEdit = Me.CekStat
        Me.Rec_Stat.FieldName = "Rec_Stat"
        Me.Rec_Stat.Name = "Rec_Stat"
        Me.Rec_Stat.Visible = True
        Me.Rec_Stat.VisibleIndex = 4
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
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE MASTER MERK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'frmMstMerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 399)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstMerk"
        Me.Text = "frmMstPromo"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcPromo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvPromo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcPromo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvPromo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_Merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alias_Merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_Stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
