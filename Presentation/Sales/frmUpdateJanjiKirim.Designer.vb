<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateJanjiKirim
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateJanjiKirim))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repTglKirim = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Alasan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtAlasan = New DevExpress.XtraEditors.MemoEdit
        Me.TglKirim = New DevExpress.XtraEditors.DateEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtKode = New DevExpress.XtraEditors.TextEdit
        Me.txtCustomer = New DevExpress.XtraEditors.TextEdit
        Me.txtTgl = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTglKirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTglKirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.txtAlasan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(42, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(835, 352)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 97)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repTglKirim, Me.repStok})
        Me.GC.Size = New System.Drawing.Size(835, 255)
        Me.GC.TabIndex = 4
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.Kd_Stok, Me.tgl_kirim, Me.Alasan})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'No_seq
        '
        Me.No_seq.Caption = "No"
        Me.No_seq.FieldName = "No_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 60
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Baramg"
        Me.Kd_Stok.ColumnEdit = Me.repStok
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 1
        Me.Kd_Stok.Width = 402
        '
        'repStok
        '
        Me.repStok.AutoHeight = False
        Me.repStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repStok.DisplayMember = "Nama_Barang"
        Me.repStok.Name = "repStok"
        Me.repStok.ValueMember = "Kode_Barang"
        '
        'tgl_kirim
        '
        Me.tgl_kirim.Caption = "Janji Kirim"
        Me.tgl_kirim.ColumnEdit = Me.repTglKirim
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 2
        Me.tgl_kirim.Width = 82
        '
        'repTglKirim
        '
        Me.repTglKirim.AutoHeight = False
        Me.repTglKirim.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTglKirim.Name = "repTglKirim"
        Me.repTglKirim.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.repTglKirim.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'Alasan
        '
        Me.Alasan.Caption = "Alasan"
        Me.Alasan.FieldName = "Alasan"
        Me.Alasan.Name = "Alasan"
        Me.Alasan.Visible = True
        Me.Alasan.VisibleIndex = 3
        Me.Alasan.Width = 270
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(835, 60)
        Me.Panel2.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(547, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(467, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(113, 60)
        Me.Panel6.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alasan : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Janji Kirim : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtAlasan)
        Me.Panel5.Controls.Add(Me.TglKirim)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(580, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(255, 60)
        Me.Panel5.TabIndex = 2
        '
        'txtAlasan
        '
        Me.txtAlasan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlasan.Location = New System.Drawing.Point(0, 20)
        Me.txtAlasan.Name = "txtAlasan"
        Me.txtAlasan.Size = New System.Drawing.Size(255, 40)
        Me.txtAlasan.TabIndex = 31
        '
        'TglKirim
        '
        Me.TglKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.TglKirim.EditValue = Nothing
        Me.TglKirim.Location = New System.Drawing.Point(0, 0)
        Me.TglKirim.Name = "TglKirim"
        Me.TglKirim.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglKirim.Properties.Appearance.Options.UseFont = True
        Me.TglKirim.Properties.Appearance.Options.UseTextOptions = True
        Me.TglKirim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TglKirim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglKirim.Properties.DisplayFormat.FormatString = "yyyyMMdd"
        Me.TglKirim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglKirim.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.TglKirim.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.TglKirim.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TglKirim.Size = New System.Drawing.Size(255, 20)
        Me.TglKirim.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.txtTgl)
        Me.Panel4.Controls.Add(Me.txtNomor)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(117, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(338, 60)
        Me.Panel4.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtKode)
        Me.Panel7.Controls.Add(Me.txtCustomer)
        Me.Panel7.Location = New System.Drawing.Point(0, 39)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(398, 20)
        Me.Panel7.TabIndex = 3
        '
        'txtKode
        '
        Me.txtKode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKode.Location = New System.Drawing.Point(235, 0)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKode.Properties.Appearance.Options.UseBackColor = True
        Me.txtKode.Properties.ReadOnly = True
        Me.txtKode.Size = New System.Drawing.Size(163, 20)
        Me.txtKode.TabIndex = 2
        '
        'txtCustomer
        '
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCustomer.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(235, 20)
        Me.txtCustomer.TabIndex = 1
        '
        'txtTgl
        '
        Me.txtTgl.Location = New System.Drawing.Point(0, 19)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.Properties.ReadOnly = True
        Me.txtTgl.Size = New System.Drawing.Size(175, 20)
        Me.txtTgl.TabIndex = 2
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(175, 20)
        Me.txtNomor.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(117, 60)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Customer : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tanggal SP : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nomor SP : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 37)
        Me.Panel1.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(44, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(336, 37)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "  UPDATE JANJI KIRIM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmUpdateJanjiKirim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 402)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmUpdateJanjiKirim"
        Me.Text = "frmUpdateJanjiKirim"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTglKirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTglKirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.txtAlasan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTgl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TglKirim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAlasan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alasan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents repTglKirim As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
