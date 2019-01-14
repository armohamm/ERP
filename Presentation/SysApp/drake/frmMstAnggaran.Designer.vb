<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstAnggaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstAnggaran))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcMstAngg = New DevExpress.XtraGrid.GridControl
        Me.GvMstAngg = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.thn_buku = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bln_buku = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_pusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GcMstAngg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMstAngg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(792, 34)
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
        Me.Label1.Size = New System.Drawing.Size(375, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE MASTER ANGGARAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMstAngg)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 273)
        Me.pnl.TabIndex = 1
        '
        'GcMstAngg
        '
        Me.GcMstAngg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMstAngg.Location = New System.Drawing.Point(0, 34)
        Me.GcMstAngg.MainView = Me.GvMstAngg
        Me.GcMstAngg.Name = "GcMstAngg"
        Me.GcMstAngg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.CekStat})
        Me.GcMstAngg.Size = New System.Drawing.Size(792, 202)
        Me.GcMstAngg.TabIndex = 32
        Me.GcMstAngg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMstAngg})
        '
        'GvMstAngg
        '
        Me.GvMstAngg.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.thn_buku, Me.bln_buku, Me.kd_buku_besar, Me.kartu, Me.kd_buku_pusat, Me.kd_valuta, Me.jml_trans, Me.Rec_stat})
        Me.GvMstAngg.GridControl = Me.GcMstAngg
        Me.GvMstAngg.Name = "GvMstAngg"
        Me.GvMstAngg.OptionsCustomization.AllowColumnMoving = False
        Me.GvMstAngg.OptionsCustomization.AllowFilter = False
        Me.GvMstAngg.OptionsCustomization.AllowGroup = False
        Me.GvMstAngg.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvMstAngg.OptionsView.RowAutoHeight = True
        Me.GvMstAngg.OptionsView.ShowGroupPanel = False
        '
        'thn_buku
        '
        Me.thn_buku.Caption = "Tahun Buku"
        Me.thn_buku.FieldName = "thn_buku"
        Me.thn_buku.Name = "thn_buku"
        Me.thn_buku.Visible = True
        Me.thn_buku.VisibleIndex = 0
        Me.thn_buku.Width = 74
        '
        'bln_buku
        '
        Me.bln_buku.Caption = "Bulan Buku"
        Me.bln_buku.FieldName = "bln_buku"
        Me.bln_buku.Name = "bln_buku"
        Me.bln_buku.Visible = True
        Me.bln_buku.VisibleIndex = 1
        Me.bln_buku.Width = 72
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.Caption = "Kode Buku Besar"
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 2
        Me.kd_buku_besar.Width = 120
        '
        'kartu
        '
        Me.kartu.Caption = "Kartu"
        Me.kartu.FieldName = "kartu"
        Me.kartu.Name = "kartu"
        Me.kartu.Visible = True
        Me.kartu.VisibleIndex = 3
        Me.kartu.Width = 67
        '
        'kd_buku_pusat
        '
        Me.kd_buku_pusat.Caption = "Kode Buku Pusat"
        Me.kd_buku_pusat.FieldName = "kd_buku_pusat"
        Me.kd_buku_pusat.Name = "kd_buku_pusat"
        Me.kd_buku_pusat.Visible = True
        Me.kd_buku_pusat.VisibleIndex = 4
        Me.kd_buku_pusat.Width = 149
        '
        'kd_valuta
        '
        Me.kd_valuta.Caption = "Kode Valuta"
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 5
        Me.kd_valuta.Width = 94
        '
        'jml_trans
        '
        Me.jml_trans.Caption = "Jumlah Transaksi"
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.Visible = True
        Me.jml_trans.VisibleIndex = 6
        Me.jml_trans.Width = 116
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.CekStat
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 7
        Me.Rec_stat.Width = 79
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = "Y"
        Me.CekStat.DisplayValueChecked = "T"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 236)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 37)
        Me.Panel2.TabIndex = 31
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(352, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(470, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(271, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(64, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'frmMstAnggaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 273)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstAnggaran"
        Me.Text = "frmMstAnggaran"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GcMstAngg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMstAngg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcMstAngg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMstAngg As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents thn_buku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bln_buku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_pusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
End Class
