<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKain
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
        Me.pnl = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_Kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Merk_Kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kode_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Warna = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcAlias = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_Stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(798, 543)
        Me.pnl.TabIndex = 0
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 41)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.lookTipe})
        Me.gc.Size = New System.Drawing.Size(798, 502)
        Me.gc.TabIndex = 83
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gv.Appearance.HeaderPanel.Options.UseFont = True
        Me.gv.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kode_Kain, Me.Merk_Kain, Me.Kode_Tipe, Me.Warna, Me.Keterangan, Me.gcAlias, Me.Rec_Stat})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.NewItemRowText = "Tambah Data disini !"
        Me.gv.OptionsCustomization.AllowColumnMoving = False
        Me.gv.OptionsCustomization.AllowFilter = False
        Me.gv.OptionsCustomization.AllowGroup = False
        Me.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gv.OptionsView.RowAutoHeight = True
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'Kode_Kain
        '
        Me.Kode_Kain.Caption = "Kode Kain"
        Me.Kode_Kain.FieldName = "Kode_Kain"
        Me.Kode_Kain.Name = "Kode_Kain"
        Me.Kode_Kain.OptionsColumn.ReadOnly = True
        Me.Kode_Kain.Visible = True
        Me.Kode_Kain.VisibleIndex = 0
        Me.Kode_Kain.Width = 60
        '
        'Merk_Kain
        '
        Me.Merk_Kain.Caption = "Merk Kain"
        Me.Merk_Kain.FieldName = "Merk_Kain"
        Me.Merk_Kain.Name = "Merk_Kain"
        Me.Merk_Kain.Visible = True
        Me.Merk_Kain.VisibleIndex = 1
        Me.Merk_Kain.Width = 144
        '
        'Kode_Tipe
        '
        Me.Kode_Tipe.Caption = "Tipe"
        Me.Kode_Tipe.ColumnEdit = Me.lookTipe
        Me.Kode_Tipe.FieldName = "Kode_Tipe"
        Me.Kode_Tipe.Name = "Kode_Tipe"
        Me.Kode_Tipe.Visible = True
        Me.Kode_Tipe.VisibleIndex = 3
        Me.Kode_Tipe.Width = 85
        '
        'lookTipe
        '
        Me.lookTipe.AutoHeight = False
        Me.lookTipe.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Name1")})
        Me.lookTipe.Name = "lookTipe"
        Me.lookTipe.NullText = "[Kosong]"
        Me.lookTipe.ShowFooter = False
        Me.lookTipe.ShowHeader = False
        Me.lookTipe.ShowPopupShadow = False
        Me.lookTipe.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'Warna
        '
        Me.Warna.Caption = "Warna Kain"
        Me.Warna.FieldName = "Warna"
        Me.Warna.Name = "Warna"
        Me.Warna.Visible = True
        Me.Warna.VisibleIndex = 2
        Me.Warna.Width = 74
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 4
        Me.Keterangan.Width = 308
        '
        'gcAlias
        '
        Me.gcAlias.Caption = "Alias"
        Me.gcAlias.FieldName = "Alias"
        Me.gcAlias.Name = "gcAlias"
        Me.gcAlias.Visible = True
        Me.gcAlias.VisibleIndex = 5
        Me.gcAlias.Width = 74
        '
        'Rec_Stat
        '
        Me.Rec_Stat.Caption = "Status"
        Me.Rec_Stat.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.Rec_Stat.FieldName = "Rec_Stat"
        Me.Rec_Stat.Name = "Rec_Stat"
        Me.Rec_Stat.Visible = True
        Me.Rec_Stat.VisibleIndex = 6
        Me.Rec_Stat.Width = 92
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoWidth = True
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepositoryItemCheckEdit1.Caption = "TIDAK AKTIF"
        Me.RepositoryItemCheckEdit1.DisplayValueChecked = "AKTIF"
        Me.RepositoryItemCheckEdit1.DisplayValueUnchecked = "TIDAK AKTIF"
        Me.RepositoryItemCheckEdit1.FullFocusRect = True
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.NullText = "TIDAK AKTIF"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "T"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(798, 41)
        Me.Panel3.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(762, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MASTER KAIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmKain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(798, 543)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmKain"
        Me.Text = "Master Kain"
        Me.pnl.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_Kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Merk_Kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Warna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAlias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_Stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Kode_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
