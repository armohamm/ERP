﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDtlSO1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDtlSO1))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_kegiatan_spk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkkegiatan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jumlah_kerja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton
        Me.pnlbawah = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkkegiatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbawah.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.GridControl1)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 300)
        Me.Panel1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkkegiatan, Me.lkbarang})
        Me.GridControl1.Size = New System.Drawing.Size(607, 300)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tanggal, Me.kd_kegiatan_spk, Me.kd_barang, Me.jumlah_kerja})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'tanggal
        '
        Me.tanggal.Caption = "Tanggal"
        Me.tanggal.FieldName = "tanggal"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.OptionsColumn.AllowEdit = False
        Me.tanggal.Visible = True
        Me.tanggal.VisibleIndex = 0
        '
        'kd_kegiatan_spk
        '
        Me.kd_kegiatan_spk.Caption = "Kegiatan Spk"
        Me.kd_kegiatan_spk.ColumnEdit = Me.lkkegiatan
        Me.kd_kegiatan_spk.FieldName = "kd_kegiatan_spk"
        Me.kd_kegiatan_spk.Name = "kd_kegiatan_spk"
        Me.kd_kegiatan_spk.Visible = True
        Me.kd_kegiatan_spk.VisibleIndex = 1
        '
        'lkkegiatan
        '
        Me.lkkegiatan.AutoHeight = False
        Me.lkkegiatan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkkegiatan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_kegiatan_spk", "kd_kegiatan_spk"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Desc_Data")})
        Me.lkkegiatan.DisplayMember = "Desc_data"
        Me.lkkegiatan.Name = "lkkegiatan"
        Me.lkkegiatan.ReadOnly = True
        Me.lkkegiatan.ValueMember = "kd_kegiatan_spk"
        '
        'kd_barang
        '
        Me.kd_barang.Caption = "Barang"
        Me.kd_barang.ColumnEdit = Me.lkbarang
        Me.kd_barang.FieldName = "kd_barang"
        Me.kd_barang.Name = "kd_barang"
        Me.kd_barang.Visible = True
        Me.kd_barang.VisibleIndex = 2
        '
        'lkbarang
        '
        Me.lkbarang.AutoHeight = False
        Me.lkbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode_Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama_Barang")})
        Me.lkbarang.DisplayMember = "Nama_Barang"
        Me.lkbarang.Name = "lkbarang"
        Me.lkbarang.ValueMember = "kd_barang"
        '
        'jumlah_kerja
        '
        Me.jumlah_kerja.Caption = "Jumlah Kerja"
        Me.jumlah_kerja.FieldName = "jumlah_kerja"
        Me.jumlah_kerja.Name = "jumlah_kerja"
        Me.jumlah_kerja.Visible = True
        Me.jumlah_kerja.VisibleIndex = 3
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Maroon
        Me.pnlAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtas.Controls.Add(Me.LabelControl1)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(631, 31)
        Me.pnlAtas.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(368, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "HASIL PRODUKSI"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(532, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "Keluar"
        '
        'pnlbawah
        '
        Me.pnlbawah.BackColor = System.Drawing.Color.Maroon
        Me.pnlbawah.Controls.Add(Me.btn_close)
        Me.pnlbawah.Location = New System.Drawing.Point(0, 359)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(631, 35)
        Me.pnlbawah.TabIndex = 4
        '
        'frmDtlSO1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(631, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlbawah)
        Me.Controls.Add(Me.pnlAtas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDtlSO1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Order"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkkegiatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbawah.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kegiatan_spk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_kerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkkegiatan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
