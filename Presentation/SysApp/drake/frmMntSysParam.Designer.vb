<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMntSysParam
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMntSysParam))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gcSysParam = New DevExpress.XtraGrid.GridControl
        Me.GVParam = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.IdTable = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ParamNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SubNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SubKode1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SubKode2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SubKode3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KetKode1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KetKode2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KetKode3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KetNoParam = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.gcSysParam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVParam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gcSysParam)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 414)
        Me.pnl.TabIndex = 0
        '
        'gcSysParam
        '
        Me.gcSysParam.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.gcSysParam.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcSysParam.Location = New System.Drawing.Point(0, 34)
        Me.gcSysParam.MainView = Me.GVParam
        Me.gcSysParam.Name = "gcSysParam"
        Me.gcSysParam.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.CekStat})
        Me.gcSysParam.Size = New System.Drawing.Size(1004, 343)
        Me.gcSysParam.TabIndex = 103
        Me.gcSysParam.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVParam})
        '
        'GVParam
        '
        Me.GVParam.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IdTable, Me.ParamNo, Me.SubNo, Me.SubKode1, Me.SubKode2, Me.SubKode3, Me.KetKode1, Me.KetKode2, Me.KetKode3, Me.KetNoParam, Me.Status})
        Me.GVParam.GridControl = Me.gcSysParam
        Me.GVParam.Name = "GVParam"
        Me.GVParam.OptionsCustomization.AllowColumnMoving = False
        Me.GVParam.OptionsCustomization.AllowColumnResizing = False
        Me.GVParam.OptionsCustomization.AllowFilter = False
        Me.GVParam.OptionsCustomization.AllowGroup = False
        Me.GVParam.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GVParam.OptionsView.RowAutoHeight = True
        Me.GVParam.OptionsView.ShowGroupPanel = False
        '
        'IdTable
        '
        Me.IdTable.Caption = "ID Table"
        Me.IdTable.FieldName = "Id_Table"
        Me.IdTable.Name = "IdTable"
        Me.IdTable.Visible = True
        Me.IdTable.VisibleIndex = 0
        Me.IdTable.Width = 60
        '
        'ParamNo
        '
        Me.ParamNo.Caption = "Param No."
        Me.ParamNo.FieldName = "Param_No"
        Me.ParamNo.Name = "ParamNo"
        Me.ParamNo.Visible = True
        Me.ParamNo.VisibleIndex = 1
        Me.ParamNo.Width = 60
        '
        'SubNo
        '
        Me.SubNo.Caption = "Param Sub No."
        Me.SubNo.FieldName = "Param_SubNo"
        Me.SubNo.Name = "SubNo"
        Me.SubNo.Visible = True
        Me.SubNo.VisibleIndex = 2
        Me.SubNo.Width = 76
        '
        'SubKode1
        '
        Me.SubKode1.Caption = "Param Sub Kode1"
        Me.SubKode1.FieldName = "Param_SubKode1"
        Me.SubKode1.Name = "SubKode1"
        Me.SubKode1.Visible = True
        Me.SubKode1.VisibleIndex = 3
        Me.SubKode1.Width = 93
        '
        'SubKode2
        '
        Me.SubKode2.Caption = "Param Sub Kode2"
        Me.SubKode2.FieldName = "Param_SubKode2"
        Me.SubKode2.Name = "SubKode2"
        Me.SubKode2.Visible = True
        Me.SubKode2.VisibleIndex = 4
        Me.SubKode2.Width = 93
        '
        'SubKode3
        '
        Me.SubKode3.Caption = "Param Sub Kode3"
        Me.SubKode3.FieldName = "Param_KetKode3"
        Me.SubKode3.Name = "SubKode3"
        Me.SubKode3.Visible = True
        Me.SubKode3.VisibleIndex = 5
        Me.SubKode3.Width = 93
        '
        'KetKode1
        '
        Me.KetKode1.Caption = "Keterangan1"
        Me.KetKode1.FieldName = "Param_KetKode1"
        Me.KetKode1.Name = "KetKode1"
        Me.KetKode1.Visible = True
        Me.KetKode1.VisibleIndex = 6
        Me.KetKode1.Width = 82
        '
        'KetKode2
        '
        Me.KetKode2.Caption = "Keterangan2"
        Me.KetKode2.FieldName = "Param_KetKode2"
        Me.KetKode2.Name = "KetKode2"
        Me.KetKode2.Visible = True
        Me.KetKode2.VisibleIndex = 7
        Me.KetKode2.Width = 82
        '
        'KetKode3
        '
        Me.KetKode3.Caption = "Keterangan3"
        Me.KetKode3.FieldName = "Param_KetKode3"
        Me.KetKode3.Name = "KetKode3"
        Me.KetKode3.Visible = True
        Me.KetKode3.VisibleIndex = 8
        Me.KetKode3.Width = 82
        '
        'KetNoParam
        '
        Me.KetNoParam.Caption = "Ket. Param"
        Me.KetNoParam.FieldName = "Param_KetNoParam"
        Me.KetNoParam.Name = "KetNoParam"
        Me.KetNoParam.Visible = True
        Me.KetNoParam.VisibleIndex = 9
        Me.KetNoParam.Width = 82
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.ColumnEdit = Me.CekStat
        Me.Status.FieldName = "Rec_Stat"
        Me.Status.Name = "Status"
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 10
        Me.Status.Width = 60
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = "NonAKTIF"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 377)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 37)
        Me.Panel2.TabIndex = 102
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(477, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(595, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 27)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "e&Xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(396, 6)
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
        Me.Panel1.TabIndex = 104
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
        Me.Label1.Text = "          MAINTENANCE PARAMETER SISTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMntSysParam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 414)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMntSysParam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMntSysParam"
        Me.pnl.ResumeLayout(False)
        CType(Me.gcSysParam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVParam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gcSysParam As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVParam As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdTable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ParamNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubKode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubKode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubKode3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KetKode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KetKode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KetKode3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KetNoParam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
