<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArea))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.cbStatus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmdLingkup = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtWilKet = New System.Windows.Forms.TextBox
        Me.txtNamaWilayah = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.gcArea = New DevExpress.XtraGrid.GridControl
        Me.gvArea = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_Area = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Area = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_Stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepCekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Leat_Time = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdLingkup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.gcArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepCekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel9)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(16, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(645, 468)
        Me.pnl.TabIndex = 19
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel7)
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Location = New System.Drawing.Point(16, 48)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(592, 352)
        Me.Panel9.TabIndex = 24
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(592, 100)
        Me.Panel7.TabIndex = 22
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cbStatus)
        Me.Panel6.Controls.Add(Me.cmdLingkup)
        Me.Panel6.Controls.Add(Me.txtWilKet)
        Me.Panel6.Controls.Add(Me.txtNamaWilayah)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(105, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(487, 100)
        Me.Panel6.TabIndex = 21
        '
        'cbStatus
        '
        Me.cbStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbStatus.Location = New System.Drawing.Point(0, 81)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbStatus.Properties.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cbStatus.Size = New System.Drawing.Size(487, 20)
        Me.cbStatus.TabIndex = 70
        '
        'cmdLingkup
        '
        Me.cmdLingkup.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdLingkup.Location = New System.Drawing.Point(0, 61)
        Me.cmdLingkup.Name = "cmdLingkup"
        Me.cmdLingkup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdLingkup.Properties.Items.AddRange(New Object() {"DALAM KOTA", "LUAR KOTA"})
        Me.cmdLingkup.Size = New System.Drawing.Size(487, 20)
        Me.cmdLingkup.TabIndex = 71
        '
        'txtWilKet
        '
        Me.txtWilKet.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtWilKet.Location = New System.Drawing.Point(0, 20)
        Me.txtWilKet.Multiline = True
        Me.txtWilKet.Name = "txtWilKet"
        Me.txtWilKet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWilKet.Size = New System.Drawing.Size(487, 41)
        Me.txtWilKet.TabIndex = 29
        '
        'txtNamaWilayah
        '
        Me.txtNamaWilayah.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNamaWilayah.Location = New System.Drawing.Point(0, 0)
        Me.txtNamaWilayah.Name = "txtNamaWilayah"
        Me.txtNamaWilayah.Size = New System.Drawing.Size(487, 20)
        Me.txtNamaWilayah.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(105, 100)
        Me.Panel5.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Status :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Lingkup :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 41)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Keterangan :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Nama Wilayah :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.gcArea)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 102)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(592, 250)
        Me.Panel8.TabIndex = 23
        '
        'gcArea
        '
        Me.gcArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcArea.Location = New System.Drawing.Point(0, 0)
        Me.gcArea.MainView = Me.gvArea
        Me.gcArea.Name = "gcArea"
        Me.gcArea.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepCekStat})
        Me.gcArea.Size = New System.Drawing.Size(592, 250)
        Me.gcArea.TabIndex = 67
        Me.gcArea.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArea})
        '
        'gvArea
        '
        Me.gvArea.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kode_Area, Me.Nama_Area, Me.Keterangan, Me.Rec_Stat, Me.Leat_Time})
        Me.gvArea.GridControl = Me.gcArea
        Me.gvArea.Name = "gvArea"
        Me.gvArea.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvArea.OptionsView.ShowGroupPanel = False
        '
        'Kode_Area
        '
        Me.Kode_Area.Caption = "Kode Area"
        Me.Kode_Area.FieldName = "Kode_Area"
        Me.Kode_Area.Name = "Kode_Area"
        Me.Kode_Area.OptionsColumn.AllowEdit = False
        Me.Kode_Area.Visible = True
        Me.Kode_Area.VisibleIndex = 0
        Me.Kode_Area.Width = 77
        '
        'Nama_Area
        '
        Me.Nama_Area.Caption = "Nama Area"
        Me.Nama_Area.FieldName = "Nama_Area"
        Me.Nama_Area.Name = "Nama_Area"
        Me.Nama_Area.Visible = True
        Me.Nama_Area.VisibleIndex = 1
        Me.Nama_Area.Width = 129
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 3
        Me.Keterangan.Width = 218
        '
        'Rec_Stat
        '
        Me.Rec_Stat.Caption = "Status"
        Me.Rec_Stat.FieldName = "Rec_Stat"
        Me.Rec_Stat.Name = "Rec_Stat"
        Me.Rec_Stat.Visible = True
        Me.Rec_Stat.VisibleIndex = 4
        Me.Rec_Stat.Width = 70
        '
        'RepCekStat
        '
        Me.RepCekStat.AutoHeight = False
        Me.RepCekStat.AutoWidth = True
        Me.RepCekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepCekStat.Caption = "Cek"
        Me.RepCekStat.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepCekStat.DisplayValueChecked = "Aktif"
        Me.RepCekStat.DisplayValueUnchecked = "Non Aktif"
        Me.RepCekStat.Name = "RepCekStat"
        Me.RepCekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.cmdCancel)
        Me.Panel2.Controls.Add(Me.cmdDelete)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Controls.Add(Me.cmdEdit)
        Me.Panel2.Controls.Add(Me.cmdAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(645, 37)
        Me.Panel2.TabIndex = 13
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(303, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 27)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(233, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 27)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(163, 3)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(64, 27)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(93, 3)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 27)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        Me.cmdEdit.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(23, 3)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 27)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        Me.cmdAdd.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 41)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(52, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(539, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "  MASTER WILAYAH DAN AREA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 41)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Leat_Time
        '
        Me.Leat_Time.Caption = "Waktu Kirim"
        Me.Leat_Time.DisplayFormat.FormatString = "n0"
        Me.Leat_Time.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Leat_Time.FieldName = "Leat_Time"
        Me.Leat_Time.Name = "Leat_Time"
        Me.Leat_Time.Visible = True
        Me.Leat_Time.VisibleIndex = 2
        Me.Leat_Time.Width = 77
        '
        'frmArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(983, 494)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Master Area"
        Me.pnl.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdLingkup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.gcArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepCekStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtWilKet As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaWilayah As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents gcArea As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvArea As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_Area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_Stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepCekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdLingkup As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Leat_Time As DevExpress.XtraGrid.Columns.GridColumn
End Class
