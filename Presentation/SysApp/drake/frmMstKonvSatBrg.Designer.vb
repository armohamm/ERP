<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstKonvSatBrg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstKonvSatBrg))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcKonvBrg = New DevExpress.XtraGrid.GridControl
        Me.GvKonvBrg = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kode_konversi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_konversi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kode_satuan_1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kode_satuan_2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.hasil = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.pnl.SuspendLayout()
        CType(Me.GcKonvBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvKonvBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcKonvBrg)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 313)
        Me.pnl.TabIndex = 0
        '
        'GcKonvBrg
        '
        Me.GcKonvBrg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcKonvBrg.Location = New System.Drawing.Point(0, 34)
        Me.GcKonvBrg.MainView = Me.GvKonvBrg
        Me.GcKonvBrg.Name = "GcKonvBrg"
        Me.GcKonvBrg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.CekStat})
        Me.GcKonvBrg.Size = New System.Drawing.Size(1004, 242)
        Me.GcKonvBrg.TabIndex = 35
        Me.GcKonvBrg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvKonvBrg})
        '
        'GvKonvBrg
        '
        Me.GvKonvBrg.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kode_konversi, Me.nm_konversi, Me.keterangan, Me.kode_satuan_1, Me.kode_satuan_2, Me.hasil, Me.Rec_stat})
        Me.GvKonvBrg.GridControl = Me.GcKonvBrg
        Me.GvKonvBrg.Name = "GvKonvBrg"
        Me.GvKonvBrg.OptionsCustomization.AllowColumnMoving = False
        Me.GvKonvBrg.OptionsCustomization.AllowFilter = False
        Me.GvKonvBrg.OptionsCustomization.AllowGroup = False
        Me.GvKonvBrg.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvKonvBrg.OptionsView.RowAutoHeight = True
        Me.GvKonvBrg.OptionsView.ShowGroupPanel = False
        '
        'kode_konversi
        '
        Me.kode_konversi.Caption = "Kode Konversi"
        Me.kode_konversi.FieldName = "kode_konversi"
        Me.kode_konversi.Name = "kode_konversi"
        Me.kode_konversi.Visible = True
        Me.kode_konversi.VisibleIndex = 0
        Me.kode_konversi.Width = 117
        '
        'nm_konversi
        '
        Me.nm_konversi.Caption = "Nama Konversi"
        Me.nm_konversi.FieldName = "nm_konversi"
        Me.nm_konversi.Name = "nm_konversi"
        Me.nm_konversi.Visible = True
        Me.nm_konversi.VisibleIndex = 1
        Me.nm_konversi.Width = 117
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 2
        Me.keterangan.Width = 117
        '
        'kode_satuan_1
        '
        Me.kode_satuan_1.Caption = "Kode Satuan 1"
        Me.kode_satuan_1.FieldName = "kode_satuan_1"
        Me.kode_satuan_1.Name = "kode_satuan_1"
        Me.kode_satuan_1.Visible = True
        Me.kode_satuan_1.VisibleIndex = 3
        Me.kode_satuan_1.Width = 117
        '
        'kode_satuan_2
        '
        Me.kode_satuan_2.Caption = "Kode Satuan 2"
        Me.kode_satuan_2.FieldName = "kode_satuan_2"
        Me.kode_satuan_2.Name = "kode_satuan_2"
        Me.kode_satuan_2.Visible = True
        Me.kode_satuan_2.VisibleIndex = 4
        '
        'hasil
        '
        Me.hasil.Caption = "Hasil"
        Me.hasil.FieldName = "hasil"
        Me.hasil.Name = "hasil"
        Me.hasil.Visible = True
        Me.hasil.VisibleIndex = 5
        '
        'Rec_stat
        '
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
        Me.Panel1.TabIndex = 36
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
        Me.Label1.Size = New System.Drawing.Size(420, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE KONVERSI SATUAN BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 276)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 37)
        Me.Panel2.TabIndex = 34
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(473, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(591, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(392, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(64, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'frmMstKonvSatBrg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 313)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstKonvSatBrg"
        Me.Text = "frmKonvSatBrg"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcKonvBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvKonvBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcKonvBrg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvKonvBrg As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kode_konversi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_konversi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kode_satuan_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kode_satuan_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hasil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
End Class
