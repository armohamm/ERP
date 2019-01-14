<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstDiscReguler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstDiscReguler))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.GcMDiscReg = New DevExpress.XtraGrid.GridControl
        Me.GvMDiscReg = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Dept = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Diskon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Diskon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Diskon3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Diskon4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Diskon5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GcMDiscReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMDiscReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1004, 34)
        Me.Panel1.TabIndex = 125
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
        Me.Label1.Text = "          Maintenance Diskon Reguler"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 340)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 37)
        Me.Panel2.TabIndex = 126
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(440, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(558, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(359, 6)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'GcMDiscReg
        '
        Me.GcMDiscReg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMDiscReg.Location = New System.Drawing.Point(0, 34)
        Me.GcMDiscReg.MainView = Me.GvMDiscReg
        Me.GcMDiscReg.Name = "GcMDiscReg"
        Me.GcMDiscReg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.GcMDiscReg.Size = New System.Drawing.Size(1004, 306)
        Me.GcMDiscReg.TabIndex = 130
        Me.GcMDiscReg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMDiscReg})
        '
        'GvMDiscReg
        '
        Me.GvMDiscReg.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Dept, Me.Kd_Diskon, Me.Keterangan, Me.Diskon1, Me.Diskon2, Me.Diskon3, Me.Diskon4, Me.Diskon5, Me.Rec_stat})
        Me.GvMDiscReg.GridControl = Me.GcMDiscReg
        Me.GvMDiscReg.Name = "GvMDiscReg"
        Me.GvMDiscReg.OptionsCustomization.AllowColumnMoving = False
        Me.GvMDiscReg.OptionsCustomization.AllowFilter = False
        Me.GvMDiscReg.OptionsCustomization.AllowGroup = False
        Me.GvMDiscReg.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvMDiscReg.OptionsView.RowAutoHeight = True
        Me.GvMDiscReg.OptionsView.ShowGroupPanel = False
        '
        'Kd_Dept
        '
        Me.Kd_Dept.Caption = "Kode Departemen"
        Me.Kd_Dept.FieldName = "Kd_Dept"
        Me.Kd_Dept.Name = "Kd_Dept"
        Me.Kd_Dept.Visible = True
        Me.Kd_Dept.VisibleIndex = 0
        Me.Kd_Dept.Width = 95
        '
        'Kd_Diskon
        '
        Me.Kd_Diskon.Caption = "Kode Diskon"
        Me.Kd_Diskon.FieldName = "Kd_Diskon"
        Me.Kd_Diskon.Name = "Kd_Diskon"
        Me.Kd_Diskon.Visible = True
        Me.Kd_Diskon.VisibleIndex = 1
        Me.Kd_Diskon.Width = 161
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 2
        Me.Keterangan.Width = 243
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.RepositoryItemComboBox1
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 8
        Me.Rec_stat.Width = 63
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Diskon1
        '
        Me.Diskon1.Caption = "Diskon 1"
        Me.Diskon1.FieldName = "Diskon1"
        Me.Diskon1.Name = "Diskon1"
        Me.Diskon1.Visible = True
        Me.Diskon1.VisibleIndex = 3
        '
        'Diskon2
        '
        Me.Diskon2.Caption = "Diskon 2"
        Me.Diskon2.FieldName = "Diskon2"
        Me.Diskon2.Name = "Diskon2"
        Me.Diskon2.Visible = True
        Me.Diskon2.VisibleIndex = 4
        '
        'Diskon3
        '
        Me.Diskon3.Caption = "Diskon 3"
        Me.Diskon3.FieldName = "Diskon3"
        Me.Diskon3.Name = "Diskon3"
        Me.Diskon3.Visible = True
        Me.Diskon3.VisibleIndex = 5
        '
        'Diskon4
        '
        Me.Diskon4.Caption = "Diskon 4"
        Me.Diskon4.FieldName = "Diskon4"
        Me.Diskon4.Name = "Diskon4"
        Me.Diskon4.Visible = True
        Me.Diskon4.VisibleIndex = 6
        '
        'Diskon5
        '
        Me.Diskon5.Caption = "Diskon 5"
        Me.Diskon5.FieldName = "Diskon5"
        Me.Diskon5.Name = "Diskon5"
        Me.Diskon5.Visible = True
        Me.Diskon5.VisibleIndex = 7
        '
        'frmMstDiscReguler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 377)
        Me.Controls.Add(Me.GcMDiscReg)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMstDiscReguler"
        Me.Text = "frmMstDiscReguler"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GcMDiscReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMDiscReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents GcMDiscReg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMDiscReg As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Dept As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Diskon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diskon2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diskon3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diskon4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diskon5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
