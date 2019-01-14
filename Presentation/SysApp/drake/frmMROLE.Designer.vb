<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMROLE
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GcMRole = New DevExpress.XtraGrid.GridControl
        Me.GvMRole = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ID_ROLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cari1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.NAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BAGIAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GcMRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cari1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 302)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 37)
        Me.Panel2.TabIndex = 16
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(306, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 27)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "e&Xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(225, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(64, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Maintenance Master Role"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 41)
        Me.Panel1.TabIndex = 15
        '
        'GcMRole
        '
        Me.GcMRole.Location = New System.Drawing.Point(12, 63)
        Me.GcMRole.MainView = Me.GvMRole
        Me.GcMRole.Name = "GcMRole"
        Me.GcMRole.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cari1})
        Me.GcMRole.Size = New System.Drawing.Size(652, 200)
        Me.GcMRole.TabIndex = 17
        Me.GcMRole.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMRole})
        '
        'GvMRole
        '
        Me.GvMRole.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID_ROLE, Me.NAMA, Me.BAGIAN})
        Me.GvMRole.GridControl = Me.GcMRole
        Me.GvMRole.Name = "GvMRole"
        Me.GvMRole.OptionsCustomization.AllowColumnMoving = False
        Me.GvMRole.OptionsCustomization.AllowColumnResizing = False
        Me.GvMRole.OptionsCustomization.AllowFilter = False
        Me.GvMRole.OptionsCustomization.AllowGroup = False
        Me.GvMRole.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvMRole.OptionsView.RowAutoHeight = True
        Me.GvMRole.OptionsView.ShowGroupPanel = False
        '
        'ID_ROLE
        '
        Me.ID_ROLE.Caption = "ID ROLE"
        Me.ID_ROLE.ColumnEdit = Me.cari1
        Me.ID_ROLE.FieldName = "ID_ROLE"
        Me.ID_ROLE.Name = "ID_ROLE"
        Me.ID_ROLE.Visible = True
        Me.ID_ROLE.VisibleIndex = 0
        '
        'cari1
        '
        Me.cari1.AutoHeight = False
        Me.cari1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cari1.Name = "cari1"
        '
        'NAMA
        '
        Me.NAMA.Caption = "Nama Role"
        Me.NAMA.FieldName = "NAMA"
        Me.NAMA.Name = "NAMA"
        Me.NAMA.Visible = True
        Me.NAMA.VisibleIndex = 1
        '
        'BAGIAN
        '
        Me.BAGIAN.Caption = "BAGIAN"
        Me.BAGIAN.FieldName = "BAGIAN"
        Me.BAGIAN.Name = "BAGIAN"
        Me.BAGIAN.Visible = True
        Me.BAGIAN.VisibleIndex = 2
        '
        'frmMROLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(676, 339)
        Me.Controls.Add(Me.GcMRole)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMROLE"
        Me.Text = "frmMROLE"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GcMRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cari1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GcMRole As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMRole As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID_ROLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BAGIAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cari1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
