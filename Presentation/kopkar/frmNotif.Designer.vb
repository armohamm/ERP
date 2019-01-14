<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotif
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
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.recDepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ColNotif = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTgl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRef = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.recDepo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.LookAndFeel.SkinName = "Money Twins"
        Me.GC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.recDepo})
        Me.GC.Size = New System.Drawing.Size(1045, 393)
        Me.GC.TabIndex = 1
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepo, Me.ColNotif, Me.colTgl, Me.colRef})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowIndicator = False
        Me.GV.OptionsView.ShowViewCaption = True
        Me.GV.ViewCaption = "INFO NOTIFIKASI"
        '
        'colDepo
        '
        Me.colDepo.Caption = "Depo"
        Me.colDepo.ColumnEdit = Me.recDepo
        Me.colDepo.FieldName = "KdCabang"
        Me.colDepo.Name = "colDepo"
        Me.colDepo.Visible = True
        Me.colDepo.VisibleIndex = 1
        Me.colDepo.Width = 131
        '
        'recDepo
        '
        Me.recDepo.AutoHeight = False
        Me.recDepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.recDepo.DisplayMember = "nama"
        Me.recDepo.Name = "recDepo"
        Me.recDepo.ValueMember = "kd_cabang"
        '
        'ColNotif
        '
        Me.ColNotif.Caption = "Notif"
        Me.ColNotif.FieldName = "Notif"
        Me.ColNotif.Name = "ColNotif"
        Me.ColNotif.Visible = True
        Me.ColNotif.VisibleIndex = 2
        Me.ColNotif.Width = 496
        '
        'colTgl
        '
        Me.colTgl.Caption = "Tanggal"
        Me.colTgl.FieldName = "Tgl"
        Me.colTgl.Name = "colTgl"
        Me.colTgl.Visible = True
        Me.colTgl.VisibleIndex = 0
        Me.colTgl.Width = 123
        '
        'colRef
        '
        Me.colRef.Caption = "Referensi"
        Me.colRef.FieldName = "Referensi"
        Me.colRef.Name = "colRef"
        Me.colRef.Visible = True
        Me.colRef.VisibleIndex = 3
        Me.colRef.Width = 194
        '
        'frmNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 393)
        Me.Controls.Add(Me.GC)
        Me.Name = "frmNotif"
        Me.Text = "frmNotif"
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.recDepo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents recDepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColNotif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRef As DevExpress.XtraGrid.Columns.GridColumn
End Class
