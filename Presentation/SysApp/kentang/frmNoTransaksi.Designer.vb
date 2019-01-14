<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNoTransaksi))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gcNoTrans = New DevExpress.XtraGrid.GridControl
        Me.gvNoTrans = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_divisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookUpEditDept = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_bukti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.reset_periode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookUpEditPeriode = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.awalan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tengah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhiran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_Stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.gcNoTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNoTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditPeriode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gcNoTrans)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(617, 377)
        Me.pnl.TabIndex = 0
        '
        'gcNoTrans
        '
        Me.gcNoTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcNoTrans.Location = New System.Drawing.Point(0, 34)
        Me.gcNoTrans.MainView = Me.gvNoTrans
        Me.gcNoTrans.Name = "gcNoTrans"
        Me.gcNoTrans.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.CekStat, Me.LookUpEditDept, Me.LookUpEditPeriode})
        Me.gcNoTrans.Size = New System.Drawing.Size(617, 343)
        Me.gcNoTrans.TabIndex = 107
        Me.gcNoTrans.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNoTrans})
        '
        'gvNoTrans
        '
        Me.gvNoTrans.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_divisi, Me.kd_bukti, Me.reset_periode, Me.awalan, Me.tengah, Me.akhiran, Me.rec_Stat})
        Me.gvNoTrans.GridControl = Me.gcNoTrans
        Me.gvNoTrans.Name = "gvNoTrans"
        Me.gvNoTrans.OptionsCustomization.AllowColumnMoving = False
        Me.gvNoTrans.OptionsCustomization.AllowFilter = False
        Me.gvNoTrans.OptionsCustomization.AllowGroup = False
        Me.gvNoTrans.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvNoTrans.OptionsView.RowAutoHeight = True
        Me.gvNoTrans.OptionsView.ShowGroupPanel = False
        '
        'kd_divisi
        '
        Me.kd_divisi.Caption = "Nama Departemen"
        Me.kd_divisi.ColumnEdit = Me.LookUpEditDept
        Me.kd_divisi.FieldName = "kd_divisi"
        Me.kd_divisi.Name = "kd_divisi"
        Me.kd_divisi.Visible = True
        Me.kd_divisi.VisibleIndex = 0
        Me.kd_divisi.Width = 135
        '
        'LookUpEditDept
        '
        Me.LookUpEditDept.AutoHeight = False
        Me.LookUpEditDept.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditDept.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Departemen")})
        Me.LookUpEditDept.Name = "LookUpEditDept"
        Me.LookUpEditDept.NullText = "[Pilih Disini]"
        '
        'kd_bukti
        '
        Me.kd_bukti.Caption = "Kode Bukti"
        Me.kd_bukti.FieldName = "kd_bukti"
        Me.kd_bukti.Name = "kd_bukti"
        Me.kd_bukti.Visible = True
        Me.kd_bukti.VisibleIndex = 1
        Me.kd_bukti.Width = 161
        '
        'reset_periode
        '
        Me.reset_periode.Caption = "Periode"
        Me.reset_periode.ColumnEdit = Me.LookUpEditPeriode
        Me.reset_periode.FieldName = "reset_periode"
        Me.reset_periode.Name = "reset_periode"
        Me.reset_periode.Visible = True
        Me.reset_periode.VisibleIndex = 2
        Me.reset_periode.Width = 243
        '
        'LookUpEditPeriode
        '
        Me.LookUpEditPeriode.AutoHeight = False
        Me.LookUpEditPeriode.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditPeriode.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Periode", 56, "Periode")})
        Me.LookUpEditPeriode.Name = "LookUpEditPeriode"
        '
        'awalan
        '
        Me.awalan.Caption = "Awalan"
        Me.awalan.FieldName = "awalan"
        Me.awalan.Name = "awalan"
        Me.awalan.Visible = True
        Me.awalan.VisibleIndex = 3
        '
        'tengah
        '
        Me.tengah.Caption = "Tengah"
        Me.tengah.FieldName = "tengah"
        Me.tengah.Name = "tengah"
        Me.tengah.Visible = True
        Me.tengah.VisibleIndex = 4
        '
        'akhiran
        '
        Me.akhiran.Caption = "Akhiran"
        Me.akhiran.FieldName = "akhiran"
        Me.akhiran.Name = "akhiran"
        Me.akhiran.Visible = True
        Me.akhiran.VisibleIndex = 5
        '
        'rec_Stat
        '
        Me.rec_Stat.Caption = "Status"
        Me.rec_Stat.ColumnEdit = Me.CekStat
        Me.rec_Stat.FieldName = "rec_Stat"
        Me.rec_Stat.Name = "rec_Stat"
        Me.rec_Stat.Visible = True
        Me.rec_Stat.VisibleIndex = 6
        Me.rec_Stat.Width = 56
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
        Me.Panel1.Size = New System.Drawing.Size(617, 34)
        Me.Panel1.TabIndex = 106
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
        Me.Label1.Size = New System.Drawing.Size(488, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "        MAINTENANCE MASTER NOMOR TRANSAKSI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmNoTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 377)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmNoTransaksi"
        Me.Text = "Nomor Transaksi"
        Me.pnl.ResumeLayout(False)
        CType(Me.gcNoTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNoTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditPeriode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gcNoTrans As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNoTrans As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_divisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_bukti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reset_periode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEditDept As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rec_Stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents awalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tengah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhiran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEditPeriode As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
