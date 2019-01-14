<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetingInsentif
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetingInsentif))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GBProduk = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.divisi = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.repDivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Merk = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.repMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Merk2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Merk3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Jenis = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Tipe = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GBRange = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.bawah = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.atas = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.insentif = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Rp = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.kali = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Area = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.repWil = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repWil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(938, 360)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 42)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repMerk, Me.repDivisi, Me.repWil})
        Me.GC.Size = New System.Drawing.Size(938, 318)
        Me.GC.TabIndex = 10
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBProduk, Me.GBRange, Me.insentif, Me.Area})
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.Merk, Me.Jenis, Me.Tipe, Me.bawah, Me.atas, Me.Rp, Me.kali, Me.divisi, Me.Merk2, Me.Merk3, Me.BandedGridColumn1})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsCustomization.AllowBandMoving = False
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsView.ColumnAutoWidth = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'GBProduk
        '
        Me.GBProduk.Caption = "Produk"
        Me.GBProduk.Columns.Add(Me.divisi)
        Me.GBProduk.Columns.Add(Me.Merk)
        Me.GBProduk.Columns.Add(Me.Merk2)
        Me.GBProduk.Columns.Add(Me.Merk3)
        Me.GBProduk.Columns.Add(Me.Jenis)
        Me.GBProduk.Columns.Add(Me.Tipe)
        Me.GBProduk.Name = "GBProduk"
        Me.GBProduk.Width = 348
        '
        'divisi
        '
        Me.divisi.Caption = "Divisi"
        Me.divisi.ColumnEdit = Me.repDivisi
        Me.divisi.FieldName = "Departement"
        Me.divisi.Name = "divisi"
        Me.divisi.Visible = True
        Me.divisi.Width = 73
        '
        'repDivisi
        '
        Me.repDivisi.AutoHeight = False
        Me.repDivisi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repDivisi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Divisi", "Divisi")})
        Me.repDivisi.DisplayMember = "Nama_Divisi"
        Me.repDivisi.Name = "repDivisi"
        Me.repDivisi.NullText = ""
        Me.repDivisi.ValueMember = "Kode_Divisi"
        '
        'Merk
        '
        Me.Merk.Caption = "Merk 1"
        Me.Merk.ColumnEdit = Me.repMerk
        Me.Merk.FieldName = "Kd_Merk"
        Me.Merk.Name = "Merk"
        Me.Merk.Visible = True
        Me.Merk.Width = 140
        '
        'repMerk
        '
        Me.repMerk.AutoHeight = False
        Me.repMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repMerk.DisplayMember = "Nama_Merk"
        Me.repMerk.Name = "repMerk"
        Me.repMerk.NullText = ""
        Me.repMerk.ValueMember = "Kode_Merk"
        '
        'Merk2
        '
        Me.Merk2.Caption = "Merk 2"
        Me.Merk2.ColumnEdit = Me.repMerk
        Me.Merk2.FieldName = "Kd_Merk2"
        Me.Merk2.Name = "Merk2"
        Me.Merk2.Visible = True
        Me.Merk2.Width = 135
        '
        'Merk3
        '
        Me.Merk3.Caption = "Merk 3"
        Me.Merk3.ColumnEdit = Me.repMerk
        Me.Merk3.FieldName = "Kd_Merk3"
        Me.Merk3.Name = "Merk3"
        Me.Merk3.Width = 168
        '
        'Jenis
        '
        Me.Jenis.Caption = "Jenis"
        Me.Jenis.FieldName = "kd_jenis"
        Me.Jenis.Name = "Jenis"
        Me.Jenis.Width = 116
        '
        'Tipe
        '
        Me.Tipe.Caption = "Tipe"
        Me.Tipe.FieldName = "kd_tipe"
        Me.Tipe.Name = "Tipe"
        Me.Tipe.Width = 167
        '
        'GBRange
        '
        Me.GBRange.Caption = "Range"
        Me.GBRange.Columns.Add(Me.bawah)
        Me.GBRange.Columns.Add(Me.atas)
        Me.GBRange.Name = "GBRange"
        Me.GBRange.Width = 111
        '
        'bawah
        '
        Me.bawah.Caption = "Bawah"
        Me.bawah.FieldName = "Batas_Awal"
        Me.bawah.Name = "bawah"
        Me.bawah.Visible = True
        Me.bawah.Width = 60
        '
        'atas
        '
        Me.atas.Caption = "Atas"
        Me.atas.FieldName = "Batas_Akhir"
        Me.atas.Name = "atas"
        Me.atas.Visible = True
        Me.atas.Width = 51
        '
        'insentif
        '
        Me.insentif.Caption = "Insentif"
        Me.insentif.Columns.Add(Me.Rp)
        Me.insentif.Columns.Add(Me.kali)
        Me.insentif.Name = "insentif"
        Me.insentif.Width = 152
        '
        'Rp
        '
        Me.Rp.Caption = "Rp Insentif"
        Me.Rp.DisplayFormat.FormatString = "n2"
        Me.Rp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Rp.FieldName = "Komisi"
        Me.Rp.Name = "Rp"
        Me.Rp.Visible = True
        Me.Rp.Width = 102
        '
        'kali
        '
        Me.kali.Caption = "Kali"
        Me.kali.FieldName = "Pengali"
        Me.kali.Name = "kali"
        Me.kali.Visible = True
        Me.kali.Width = 50
        '
        'Area
        '
        Me.Area.Caption = "Lingkup"
        Me.Area.Columns.Add(Me.BandedGridColumn1)
        Me.Area.Name = "Area"
        Me.Area.Width = 138
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = " "
        Me.BandedGridColumn1.ColumnEdit = Me.repWil
        Me.BandedGridColumn1.FieldName = "Lingkup"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 138
        '
        'repWil
        '
        Me.repWil.AutoHeight = False
        Me.repWil.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repWil.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESKRIPSI", "Lingkup")})
        Me.repWil.Name = "repWil"
        Me.repWil.NullText = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 42)
        Me.Panel2.TabIndex = 137
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(52, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "  MASTER INSENTIF SALES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 40)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmSetingInsentif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 384)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmSetingInsentif"
        Me.Text = "frmSetingInsentif"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repWil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents Merk As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Jenis As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Tipe As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bawah As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents atas As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Rp As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents kali As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents repMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents divisi As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents repDivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Merk2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Merk3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GBProduk As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GBRange As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents insentif As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Area As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents repWil As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
