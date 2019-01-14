<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstSignDocs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstSignDocs))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Gcttd = New DevExpress.XtraGrid.GridControl
        Me.Gvttd = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.id_rep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.desc_rep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.posisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_peg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupkdPeg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.nama_peg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_jab = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupJab = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupNamaPeg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.Gcttd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gvttd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupkdPeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupJab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupNamaPeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Gcttd)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 313)
        Me.pnl.TabIndex = 0
        '
        'Gcttd
        '
        Me.Gcttd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gcttd.Location = New System.Drawing.Point(0, 34)
        Me.Gcttd.MainView = Me.Gvttd
        Me.Gcttd.Name = "Gcttd"
        Me.Gcttd.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.LookupkdPeg, Me.LookupJab, Me.LookupNamaPeg, Me.CekStat})
        Me.Gcttd.Size = New System.Drawing.Size(1004, 242)
        Me.Gcttd.TabIndex = 29
        Me.Gcttd.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gvttd})
        '
        'Gvttd
        '
        Me.Gvttd.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id_rep, Me.desc_rep, Me.no_seq, Me.posisi, Me.kd_peg, Me.nama_peg, Me.nama_jab, Me.Rec_stat})
        Me.Gvttd.GridControl = Me.Gcttd
        Me.Gvttd.Name = "Gvttd"
        Me.Gvttd.OptionsCustomization.AllowColumnMoving = False
        Me.Gvttd.OptionsCustomization.AllowFilter = False
        Me.Gvttd.OptionsCustomization.AllowGroup = False
        Me.Gvttd.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.Gvttd.OptionsView.RowAutoHeight = True
        Me.Gvttd.OptionsView.ShowGroupPanel = False
        '
        'id_rep
        '
        Me.id_rep.Caption = "Id Rep"
        Me.id_rep.FieldName = "id_rep"
        Me.id_rep.Name = "id_rep"
        Me.id_rep.Visible = True
        Me.id_rep.VisibleIndex = 0
        Me.id_rep.Width = 78
        '
        'desc_rep
        '
        Me.desc_rep.Caption = "Deskripsi Rep"
        Me.desc_rep.FieldName = "desc_rep"
        Me.desc_rep.Name = "desc_rep"
        Me.desc_rep.Visible = True
        Me.desc_rep.VisibleIndex = 1
        Me.desc_rep.Width = 103
        '
        'no_seq
        '
        Me.no_seq.Caption = "No Sequensial"
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 2
        Me.no_seq.Width = 96
        '
        'posisi
        '
        Me.posisi.Caption = "Posisi"
        Me.posisi.FieldName = "posisi"
        Me.posisi.Name = "posisi"
        Me.posisi.Visible = True
        Me.posisi.VisibleIndex = 3
        Me.posisi.Width = 160
        '
        'kd_peg
        '
        Me.kd_peg.Caption = "Kode Pegawai"
        Me.kd_peg.ColumnEdit = Me.LookupkdPeg
        Me.kd_peg.FieldName = "kd_peg"
        Me.kd_peg.Name = "kd_peg"
        Me.kd_peg.Visible = True
        Me.kd_peg.VisibleIndex = 4
        Me.kd_peg.Width = 140
        '
        'LookupkdPeg
        '
        Me.LookupkdPeg.AutoHeight = False
        Me.LookupkdPeg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupkdPeg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Pegawai", "Kode_Pegawai", 83, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookupkdPeg.Name = "LookupkdPeg"
        Me.LookupkdPeg.NullText = "klik disini"
        '
        'nama_peg
        '
        Me.nama_peg.Caption = "Nama Pegawai"
        Me.nama_peg.FieldName = "nama_peg"
        Me.nama_peg.Name = "nama_peg"
        Me.nama_peg.Visible = True
        Me.nama_peg.VisibleIndex = 5
        Me.nama_peg.Width = 127
        '
        'nama_jab
        '
        Me.nama_jab.Caption = "Nama Jabatan"
        Me.nama_jab.ColumnEdit = Me.LookupJab
        Me.nama_jab.FieldName = "nama_jab"
        Me.nama_jab.Name = "nama_jab"
        Me.nama_jab.Visible = True
        Me.nama_jab.VisibleIndex = 6
        Me.nama_jab.Width = 202
        '
        'LookupJab
        '
        Me.LookupJab.AutoHeight = False
        Me.LookupJab.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupJab.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jabatan", "Nama Jabatan")})
        Me.LookupJab.Name = "LookupJab"
        Me.LookupJab.NullText = "klik disini"
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.CekStat
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 7
        Me.Rec_stat.Width = 77
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = "AKTIF"
        Me.CekStat.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CekStat.DisplayValueChecked = "AKTIF"
        Me.CekStat.DisplayValueUnchecked = "NonAKTIF"
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'LookupNamaPeg
        '
        Me.LookupNamaPeg.AutoHeight = False
        Me.LookupNamaPeg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupNamaPeg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama Pegawai")})
        Me.LookupNamaPeg.Name = "LookupNamaPeg"
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
        Me.Panel2.TabIndex = 28
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(502, 5)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(620, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(421, 5)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(64, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 30
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
        Me.Label1.Size = New System.Drawing.Size(439, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE PENANDATANGANAN DOKUMEN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMstSignDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 313)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstSignDocs"
        Me.Text = "frmMstSignDoc"
        Me.pnl.ResumeLayout(False)
        CType(Me.Gcttd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gvttd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupkdPeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupJab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupNamaPeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Gcttd As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gvttd As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id_rep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents desc_rep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents posisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_peg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupkdPeg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents nama_peg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_jab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupJab As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupNamaPeg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
