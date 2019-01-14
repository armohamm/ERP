<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PMH_Piutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PMH_Piutang))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.pnl2 = New System.Windows.Forms.Panel
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.pnl12 = New System.Windows.Forms.Panel
        Me.LOV = New DevExpress.XtraEditors.SimpleButton
        Me.TxtNama = New System.Windows.Forms.TextBox
        Me.dttgl_inv = New DevExpress.XtraEditors.DateEdit
        Me.txtketerangan = New System.Windows.Forms.TextBox
        Me.txtjml_val_trans = New System.Windows.Forms.TextBox
        Me.txtkd_cust = New System.Windows.Forms.TextBox
        Me.txtno_inv = New System.Windows.Forms.TextBox
        Me.pnl11 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton
        Me.btSave = New DevExpress.XtraEditors.SimpleButton
        Me.btDel = New DevExpress.XtraEditors.SimpleButton
        Me.btCancel = New DevExpress.XtraEditors.SimpleButton
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.pnl12.SuspendLayout()
        CType(Me.dttgl_inv.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttgl_inv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl11.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(817, 450)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 206)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(817, 244)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_inv, Me.kd_cust, Me.nm_cust, Me.jml_val_trans, Me.tgl_inv})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'no_inv
        '
        Me.no_inv.Caption = "Nomor"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 0
        Me.no_inv.Width = 155
        '
        'kd_cust
        '
        Me.kd_cust.Caption = "Kd. Cust"
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        Me.kd_cust.Visible = True
        Me.kd_cust.VisibleIndex = 2
        '
        'nm_cust
        '
        Me.nm_cust.Caption = "Nama"
        Me.nm_cust.FieldName = "nm_cust"
        Me.nm_cust.Name = "nm_cust"
        Me.nm_cust.Visible = True
        Me.nm_cust.VisibleIndex = 3
        Me.nm_cust.Width = 410
        '
        'jml_val_trans
        '
        Me.jml_val_trans.AppearanceCell.Options.UseTextOptions = True
        Me.jml_val_trans.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jml_val_trans.Caption = "Jml. Piutang"
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.OptionsColumn.AllowEdit = False
        Me.jml_val_trans.OptionsColumn.ReadOnly = True
        Me.jml_val_trans.Visible = True
        Me.jml_val_trans.VisibleIndex = 4
        Me.jml_val_trans.Width = 421
        '
        'tgl_inv
        '
        Me.tgl_inv.Caption = "Tgl Transaksi"
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 1
        Me.tgl_inv.Width = 115
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.LightGray
        Me.pnlTools.Controls.Add(Me.pnl2)
        Me.pnlTools.Controls.Add(Me.pnl1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(817, 172)
        Me.pnlTools.TabIndex = 5
        '
        'pnl2
        '
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl2.Location = New System.Drawing.Point(780, 0)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(297, 172)
        Me.pnl2.TabIndex = 1
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.pnl12)
        Me.pnl1.Controls.Add(Me.pnl11)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(780, 172)
        Me.pnl1.TabIndex = 0
        '
        'pnl12
        '
        Me.pnl12.Controls.Add(Me.LOV)
        Me.pnl12.Controls.Add(Me.TxtNama)
        Me.pnl12.Controls.Add(Me.dttgl_inv)
        Me.pnl12.Controls.Add(Me.txtketerangan)
        Me.pnl12.Controls.Add(Me.txtjml_val_trans)
        Me.pnl12.Controls.Add(Me.txtkd_cust)
        Me.pnl12.Controls.Add(Me.txtno_inv)
        Me.pnl12.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl12.Location = New System.Drawing.Point(107, 0)
        Me.pnl12.Name = "pnl12"
        Me.pnl12.Size = New System.Drawing.Size(673, 172)
        Me.pnl12.TabIndex = 3
        '
        'LOV
        '
        Me.LOV.Location = New System.Drawing.Point(117, 43)
        Me.LOV.Name = "LOV"
        Me.LOV.Size = New System.Drawing.Size(75, 20)
        Me.LOV.TabIndex = 8
        Me.LOV.Text = "List.Pegawai"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(0, 65)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.ReadOnly = True
        Me.TxtNama.Size = New System.Drawing.Size(319, 20)
        Me.TxtNama.TabIndex = 7
        '
        'dttgl_inv
        '
        Me.dttgl_inv.EditValue = Nothing
        Me.dttgl_inv.Location = New System.Drawing.Point(1, 23)
        Me.dttgl_inv.Name = "dttgl_inv"
        Me.dttgl_inv.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.dttgl_inv.Properties.Appearance.Options.UseForeColor = True
        Me.dttgl_inv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dttgl_inv.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dttgl_inv.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dttgl_inv.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dttgl_inv.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dttgl_inv.Size = New System.Drawing.Size(110, 20)
        Me.dttgl_inv.TabIndex = 6
        Me.dttgl_inv.ToolTip = "Format : dd/mm/yyyy"
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(0, 108)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(667, 55)
        Me.txtketerangan.TabIndex = 4
        '
        'txtjml_val_trans
        '
        Me.txtjml_val_trans.Location = New System.Drawing.Point(0, 86)
        Me.txtjml_val_trans.Name = "txtjml_val_trans"
        Me.txtjml_val_trans.Size = New System.Drawing.Size(319, 20)
        Me.txtjml_val_trans.TabIndex = 3
        Me.txtjml_val_trans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtkd_cust
        '
        Me.txtkd_cust.Location = New System.Drawing.Point(0, 44)
        Me.txtkd_cust.Name = "txtkd_cust"
        Me.txtkd_cust.Size = New System.Drawing.Size(111, 20)
        Me.txtkd_cust.TabIndex = 2
        '
        'txtno_inv
        '
        Me.txtno_inv.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtno_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno_inv.ForeColor = System.Drawing.Color.Yellow
        Me.txtno_inv.Location = New System.Drawing.Point(0, 3)
        Me.txtno_inv.Name = "txtno_inv"
        Me.txtno_inv.ReadOnly = True
        Me.txtno_inv.Size = New System.Drawing.Size(202, 20)
        Me.txtno_inv.TabIndex = 0
        '
        'pnl11
        '
        Me.pnl11.Controls.Add(Me.Label1)
        Me.pnl11.Controls.Add(Me.Label5)
        Me.pnl11.Controls.Add(Me.Label4)
        Me.pnl11.Controls.Add(Me.Label3)
        Me.pnl11.Controls.Add(Me.Label2)
        Me.pnl11.Controls.Add(Me.Label6)
        Me.pnl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl11.Location = New System.Drawing.Point(0, 0)
        Me.pnl11.Name = "pnl11"
        Me.pnl11.Size = New System.Drawing.Size(107, 172)
        Me.pnl11.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "KD.Karyawan :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Keterangan :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jumlah :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama Karyawan :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tanggal :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nomor :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Maroon
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox1)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(817, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(712, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "PERMOHONAN PIUTANG"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(21, 468)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 1
        Me.btAdd.Text = "Baru"
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(121, 468)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 23)
        Me.btEdit.TabIndex = 2
        Me.btEdit.Text = "Edit"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(222, 468)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "Simpan"
        '
        'btDel
        '
        Me.btDel.Location = New System.Drawing.Point(318, 468)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(75, 23)
        Me.btDel.TabIndex = 4
        Me.btDel.Text = "Hapus"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(416, 468)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 5
        Me.btCancel.Text = "Batal"
        '
        'Frm_PMH_Piutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 512)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.pnl)
        Me.Name = "Frm_PMH_Piutang"
        Me.Text = "Frm_PMH_Piutang"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        Me.pnl12.ResumeLayout(False)
        Me.pnl12.PerformLayout()
        CType(Me.dttgl_inv.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttgl_inv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl11.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents pnl12 As System.Windows.Forms.Panel
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents txtjml_val_trans As System.Windows.Forms.TextBox
    Friend WithEvents txtno_inv As System.Windows.Forms.TextBox
    Friend WithEvents pnl11 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dttgl_inv As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtkd_cust As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOV As DevExpress.XtraEditors.SimpleButton
End Class
