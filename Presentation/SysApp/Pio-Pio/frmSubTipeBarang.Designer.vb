<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubTipeBarang
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
        Me.Kd_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Kd_Sub_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Sub_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_Stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Location = New System.Drawing.Point(-1, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(660, 316)
        Me.pnl.TabIndex = 0
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 41)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1})
        Me.gc.Size = New System.Drawing.Size(660, 275)
        Me.gc.TabIndex = 86
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Tipe, Me.Kd_Sub_Tipe, Me.Nama_Sub_Tipe, Me.Rec_Stat})
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
        'Kd_Tipe
        '
        Me.Kd_Tipe.Caption = "Tipe Barang"
        Me.Kd_Tipe.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.Kd_Tipe.FieldName = "Kd_Tipe"
        Me.Kd_Tipe.Name = "Kd_Tipe"
        Me.Kd_Tipe.Visible = True
        Me.Kd_Tipe.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_tipe", "kd_tipe"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama_Tipe")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Nama_Tipe"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "kd_tipe"
        '
        'Kd_Sub_Tipe
        '
        Me.Kd_Sub_Tipe.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Kd_Sub_Tipe.AppearanceHeader.Options.UseFont = True
        Me.Kd_Sub_Tipe.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_Sub_Tipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_Sub_Tipe.Caption = "Kode Sub Tipe"
        Me.Kd_Sub_Tipe.FieldName = "Kd_Sub_Tipe"
        Me.Kd_Sub_Tipe.Name = "Kd_Sub_Tipe"
        Me.Kd_Sub_Tipe.OptionsColumn.AllowEdit = False
        Me.Kd_Sub_Tipe.OptionsColumn.ReadOnly = True
        Me.Kd_Sub_Tipe.Visible = True
        Me.Kd_Sub_Tipe.VisibleIndex = 1
        Me.Kd_Sub_Tipe.Width = 60
        '
        'Nama_Sub_Tipe
        '
        Me.Nama_Sub_Tipe.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Nama_Sub_Tipe.AppearanceHeader.Options.UseFont = True
        Me.Nama_Sub_Tipe.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Sub_Tipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Sub_Tipe.Caption = "Nama Sub Tipe"
        Me.Nama_Sub_Tipe.FieldName = "Nama_Sub_Tipe"
        Me.Nama_Sub_Tipe.Name = "Nama_Sub_Tipe"
        Me.Nama_Sub_Tipe.Visible = True
        Me.Nama_Sub_Tipe.VisibleIndex = 2
        Me.Nama_Sub_Tipe.Width = 201
        '
        'Rec_Stat
        '
        Me.Rec_Stat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Rec_Stat.AppearanceHeader.Options.UseFont = True
        Me.Rec_Stat.AppearanceHeader.Options.UseTextOptions = True
        Me.Rec_Stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Rec_Stat.Caption = "Status"
        Me.Rec_Stat.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.Rec_Stat.FieldName = "Rec_Stat"
        Me.Rec_Stat.Name = "Rec_Stat"
        Me.Rec_Stat.Visible = True
        Me.Rec_Stat.VisibleIndex = 3
        Me.Rec_Stat.Width = 77
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoWidth = True
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepositoryItemCheckEdit1.Caption = "T"
        Me.RepositoryItemCheckEdit1.DisplayValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.DisplayValueUnchecked = "T"
        Me.RepositoryItemCheckEdit1.FullFocusRect = True
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.NullText = "T"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "T"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(660, 41)
        Me.Panel2.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(762, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SUB TIPE BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSubTipeBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 312)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmSubTipeBarang"
        Me.Text = "Sub Tipe Barang"
        Me.pnl.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Sub_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Sub_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_Stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Kd_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
