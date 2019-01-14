<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKonvSatBrg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKonvSatBrg))
        Me.GcJnsBarang = New DevExpress.XtraGrid.GridControl
        Me.GvJnsBarang = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Jns_persd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Dept = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        CType(Me.GcJnsBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvJnsBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GcJnsBarang
        '
        Me.GcJnsBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcJnsBarang.Location = New System.Drawing.Point(0, 34)
        Me.GcJnsBarang.MainView = Me.GvJnsBarang
        Me.GcJnsBarang.Name = "GcJnsBarang"
        Me.GcJnsBarang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.GcJnsBarang.Size = New System.Drawing.Size(1004, 242)
        Me.GcJnsBarang.TabIndex = 32
        Me.GcJnsBarang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvJnsBarang})
        '
        'GvJnsBarang
        '
        Me.GvJnsBarang.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Jns_persd, Me.Kd_Dept, Me.Kd_Jenis, Me.Nama_Jenis, Me.Keterangan, Me.Rec_stat})
        Me.GvJnsBarang.GridControl = Me.GcJnsBarang
        Me.GvJnsBarang.Name = "GvJnsBarang"
        Me.GvJnsBarang.OptionsCustomization.AllowColumnMoving = False
        Me.GvJnsBarang.OptionsCustomization.AllowFilter = False
        Me.GvJnsBarang.OptionsCustomization.AllowGroup = False
        Me.GvJnsBarang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvJnsBarang.OptionsView.RowAutoHeight = True
        Me.GvJnsBarang.OptionsView.ShowGroupPanel = False
        '
        'Kd_Jns_persd
        '
        Me.Kd_Jns_persd.Caption = "Kode Jenis Persediaan"
        Me.Kd_Jns_persd.FieldName = "Kd_Jns_persd"
        Me.Kd_Jns_persd.Name = "Kd_Jns_persd"
        Me.Kd_Jns_persd.Visible = True
        Me.Kd_Jns_persd.VisibleIndex = 0
        Me.Kd_Jns_persd.Width = 117
        '
        'Kd_Dept
        '
        Me.Kd_Dept.Caption = "Kode Departemen"
        Me.Kd_Dept.FieldName = "Kd_Dept"
        Me.Kd_Dept.Name = "Kd_Dept"
        Me.Kd_Dept.Visible = True
        Me.Kd_Dept.VisibleIndex = 1
        Me.Kd_Dept.Width = 117
        '
        'Kd_Jenis
        '
        Me.Kd_Jenis.Caption = "Kode Jenis"
        Me.Kd_Jenis.FieldName = "Kd_Jenis"
        Me.Kd_Jenis.Name = "Kd_Jenis"
        Me.Kd_Jenis.Visible = True
        Me.Kd_Jenis.VisibleIndex = 2
        Me.Kd_Jenis.Width = 117
        '
        'Nama_Jenis
        '
        Me.Nama_Jenis.Caption = "Nama Jenis"
        Me.Nama_Jenis.FieldName = "Nama_Jenis"
        Me.Nama_Jenis.Name = "Nama_Jenis"
        Me.Nama_Jenis.Visible = True
        Me.Nama_Jenis.VisibleIndex = 3
        Me.Nama_Jenis.Width = 117
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 4
        Me.Keterangan.Width = 157
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.RepositoryItemComboBox1
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 5
        Me.Rec_stat.Width = 82
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
        Me.Label1.Text = "          Maintenance Periode Pembukuan"
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
        Me.Panel2.TabIndex = 31
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
        'frmKonvSatBrg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 313)
        Me.Controls.Add(Me.GcJnsBarang)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmKonvSatBrg"
        Me.Text = "frmKonvSatBrg"
        CType(Me.GcJnsBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvJnsBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GcJnsBarang As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvJnsBarang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Jns_persd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Dept As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
End Class
